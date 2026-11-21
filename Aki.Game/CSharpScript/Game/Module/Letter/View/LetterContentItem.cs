using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Letter.View
{
	// Token: 0x020046A4 RID: 18084
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LetterContentItem : GridProxyAbstract<ITalkItem>
	{
		// Token: 0x0602D755 RID: 186197 RVA: 0x00CBAF4C File Offset: 0x00CB914C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602D756 RID: 186198 RVA: 0x00CBAF94 File Offset: 0x00CB9194
		[NullableContext(1)]
		public override void Refresh(ITalkItem data, bool isSelected, int gridIndex)
		{
			if (this.BoundTalkId == data.Id)
			{
				return;
			}
			this.BoundTalkId = data.Id;
			this.IsPlaying = false;
			this.HasFiredFinished = false;
			this.OnFinishedCallback = null;
			this.ClearRuntime();
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(data.TidTalk))
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.TidTalk, Array.Empty<object>());
			}
			else
			{
				text.SetText("", true);
			}
			UUIItem uuiitem = text;
			ITalkItemDialog talkItemDialog = data as ITalkItemDialog;
			bool flag;
			if (talkItemDialog == null)
			{
				flag = false;
			}
			else
			{
				ITalkItemStyle style = talkItemDialog.Style;
				ETalkItemStyle? etalkItemStyle = (style != null) ? new ETalkItemStyle?(style.Type) : null;
				ETalkItemStyle etalkItemStyle2 = ETalkItemStyle.InnerVoice;
				flag = (etalkItemStyle.GetValueOrDefault() == etalkItemStyle2 & etalkItemStyle != null);
			}
			uuiitem.SetAlpha(flag ? 0.67f : 1f);
			AActor owner = text.GetOwner();
			UUIEffectTextAnimation uuieffectTextAnimation = ((owner != null) ? owner.GetComponentByClass(UUIEffectTextAnimation.StaticClass()) : null) as UUIEffectTextAnimation;
			ULGUIPlayTweenComponent ulguiplayTweenComponent = ((owner != null) ? owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) : null) as ULGUIPlayTweenComponent;
			if (uuieffectTextAnimation == null || ulguiplayTweenComponent == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[LetterContentItem] 文本打字机组件缺失";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TalkId", data.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.WriterComp = new PlotTextWriterComponent();
			this.WriterComp.Init(new PlotTextWriterComponentContext
			{
				TextComponent = text,
				TextAnimComp = uuieffectTextAnimation,
				TweenComp = ulguiplayTweenComponent
			});
			this.TypingDurationSec = PlotComponentUtils.GetTextWriterAnimDuration(data, text, PlotComponentUtils.GetTextWriterAnimSpeed(false));
			this.WriterComp.SetPlayDuration(this.TypingDurationSec);
			this.AudioComp = new PlotTextAudioComponent();
			this.AudioComp.Init(new PlotTextAudioComponentContext
			{
				OnAudioStartDelegate = new Action(this.OnAudioStart)
			});
			this.AudioComp.TryPlayTalkAudioByTalkItem(data);
			this.ProtectEndMs = DateTimeOffset.Now.ToUnixTimeMilliseconds() + (long)PlotComponentUtils.GetTalkWaitTime(data);
			this.IsPlaying = true;
			this.WriterComp.Play();
			this.ScheduleEndTimer(this.TypingDurationSec);
		}

		// Token: 0x0602D757 RID: 186199 RVA: 0x00CBB1AC File Offset: 0x00CB93AC
		public void ForceComplete()
		{
			if (!this.IsPlaying)
			{
				return;
			}
			PlotTextWriterComponent writerComp = this.WriterComp;
			if (writerComp != null)
			{
				writerComp.JumpToEnd();
			}
			PlotTextAudioComponent audioComp = this.AudioComp;
			if (audioComp != null)
			{
				audioComp.StopAudio();
			}
			this.ClearEndTimer();
			this.ProtectEndMs = 0L;
			this.IsPlaying = false;
			this.FireFinished();
		}

		// Token: 0x0602D758 RID: 186200 RVA: 0x00CBB200 File Offset: 0x00CB9400
		public bool IsInProtectTime()
		{
			return DateTimeOffset.Now.ToUnixTimeMilliseconds() < this.ProtectEndMs;
		}

		// Token: 0x0602D759 RID: 186201 RVA: 0x00CBB224 File Offset: 0x00CB9424
		public long GetProtectRemainingMs()
		{
			return Math.Max(0L, this.ProtectEndMs - DateTimeOffset.Now.ToUnixTimeMilliseconds());
		}

		// Token: 0x0602D75A RID: 186202 RVA: 0x00CBB24C File Offset: 0x00CB944C
		public bool IsFinished()
		{
			return this.HasFiredFinished;
		}

		// Token: 0x0602D75B RID: 186203 RVA: 0x00CBB254 File Offset: 0x00CB9454
		[NullableContext(1)]
		public unsafe void SetOnFinished(Action callback)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[WL-Finish] ContentItem.SetOnFinished";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TalkId", this.BoundTalkId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HasFiredFinished", this.HasFiredFinished);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.HasFiredFinished)
			{
				callback();
				return;
			}
			this.OnFinishedCallback = callback;
		}

		// Token: 0x0602D75C RID: 186204 RVA: 0x00CBB2DD File Offset: 0x00CB94DD
		[NullableContext(1)]
		public override object GetKey(ITalkItem data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x0602D75D RID: 186205 RVA: 0x00CBB2EA File Offset: 0x00CB94EA
		protected override void OnBeforeDestroy()
		{
			this.ClearRuntime();
		}

		// Token: 0x0602D75E RID: 186206 RVA: 0x00CBB2F4 File Offset: 0x00CB94F4
		private void OnAudioStart()
		{
			PlotTextAudioComponent audioComp = this.AudioComp;
			float val = ((audioComp != null) ? audioComp.GetAudioDuration() : 0f) / 1000f;
			this.ScheduleEndTimer(Math.Max(this.TypingDurationSec, val));
		}

		// Token: 0x0602D75F RID: 186207 RVA: 0x00CBB330 File Offset: 0x00CB9530
		private void ScheduleEndTimer(float durationSeconds)
		{
			this.ClearEndTimer();
			int num = Math.Max(0, (int)Math.Floor((double)(durationSeconds * 1000f)));
			if (num <= 0)
			{
				this.IsPlaying = false;
				this.FireFinished();
				return;
			}
			this.EndTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.EndTimer = null;
				this.IsPlaying = false;
				this.FireFinished();
			}, (float)num, null, null, true, 1f);
		}

		// Token: 0x0602D760 RID: 186208 RVA: 0x00CBB390 File Offset: 0x00CB9590
		private void FireFinished()
		{
			if (this.HasFiredFinished)
			{
				return;
			}
			this.HasFiredFinished = true;
			Action onFinishedCallback = this.OnFinishedCallback;
			this.OnFinishedCallback = null;
			if (onFinishedCallback == null)
			{
				return;
			}
			onFinishedCallback();
		}

		// Token: 0x0602D761 RID: 186209 RVA: 0x00CBB3B9 File Offset: 0x00CB95B9
		private void ClearEndTimer()
		{
			if (this.EndTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.EndTimer);
				this.EndTimer = null;
			}
		}

		// Token: 0x0602D762 RID: 186210 RVA: 0x00CBB3DB File Offset: 0x00CB95DB
		private void ClearRuntime()
		{
			this.ClearEndTimer();
			PlotTextWriterComponent writerComp = this.WriterComp;
			if (writerComp != null)
			{
				writerComp.Clear();
			}
			this.WriterComp = null;
			PlotTextAudioComponent audioComp = this.AudioComp;
			if (audioComp != null)
			{
				audioComp.StopAudio();
			}
			this.AudioComp = null;
		}

		// Token: 0x04018596 RID: 99734
		private PlotTextWriterComponent WriterComp;

		// Token: 0x04018597 RID: 99735
		private PlotTextAudioComponent AudioComp;

		// Token: 0x04018598 RID: 99736
		private TimerHandle EndTimer;

		// Token: 0x04018599 RID: 99737
		private long ProtectEndMs;

		// Token: 0x0401859A RID: 99738
		private float TypingDurationSec;

		// Token: 0x0401859B RID: 99739
		private int BoundTalkId = -1;

		// Token: 0x0401859C RID: 99740
		private bool IsPlaying;

		// Token: 0x0401859D RID: 99741
		private bool HasFiredFinished;

		// Token: 0x0401859E RID: 99742
		private Action OnFinishedCallback;

		// Token: 0x0200A2CD RID: 41677
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403281A RID: 206874
			public const int TxtLetterContent = 0;
		}
	}
}
