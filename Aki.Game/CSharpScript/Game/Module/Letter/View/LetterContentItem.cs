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
	// Token: 0x020056CD RID: 22221
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LetterContentItem : GridProxyAbstract<ITalkItem>
	{
		// Token: 0x06038845 RID: 231493 RVA: 0x00D6C994 File Offset: 0x00D6AB94
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

		// Token: 0x06038846 RID: 231494 RVA: 0x00D6C9DC File Offset: 0x00D6ABDC
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

		// Token: 0x06038847 RID: 231495 RVA: 0x00D6CBF4 File Offset: 0x00D6ADF4
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

		// Token: 0x06038848 RID: 231496 RVA: 0x00D6CC48 File Offset: 0x00D6AE48
		public bool IsInProtectTime()
		{
			return DateTimeOffset.Now.ToUnixTimeMilliseconds() < this.ProtectEndMs;
		}

		// Token: 0x06038849 RID: 231497 RVA: 0x00D6CC6C File Offset: 0x00D6AE6C
		public long GetProtectRemainingMs()
		{
			return Math.Max(0L, this.ProtectEndMs - DateTimeOffset.Now.ToUnixTimeMilliseconds());
		}

		// Token: 0x0603884A RID: 231498 RVA: 0x00D6CC94 File Offset: 0x00D6AE94
		public bool IsFinished()
		{
			return this.HasFiredFinished;
		}

		// Token: 0x0603884B RID: 231499 RVA: 0x00D6CC9C File Offset: 0x00D6AE9C
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

		// Token: 0x0603884C RID: 231500 RVA: 0x00D6CD25 File Offset: 0x00D6AF25
		[NullableContext(1)]
		public override object GetKey(ITalkItem data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x0603884D RID: 231501 RVA: 0x00D6CD32 File Offset: 0x00D6AF32
		protected override void OnBeforeDestroy()
		{
			this.ClearRuntime();
		}

		// Token: 0x0603884E RID: 231502 RVA: 0x00D6CD3C File Offset: 0x00D6AF3C
		private void OnAudioStart()
		{
			PlotTextAudioComponent audioComp = this.AudioComp;
			float val = ((audioComp != null) ? audioComp.GetAudioDuration() : 0f) / 1000f;
			this.ScheduleEndTimer(Math.Max(this.TypingDurationSec, val));
		}

		// Token: 0x0603884F RID: 231503 RVA: 0x00D6CD78 File Offset: 0x00D6AF78
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

		// Token: 0x06038850 RID: 231504 RVA: 0x00D6CDD8 File Offset: 0x00D6AFD8
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

		// Token: 0x06038851 RID: 231505 RVA: 0x00D6CE01 File Offset: 0x00D6B001
		private void ClearEndTimer()
		{
			if (this.EndTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.EndTimer);
				this.EndTimer = null;
			}
		}

		// Token: 0x06038852 RID: 231506 RVA: 0x00D6CE23 File Offset: 0x00D6B023
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

		// Token: 0x0401DB00 RID: 121600
		private PlotTextWriterComponent WriterComp;

		// Token: 0x0401DB01 RID: 121601
		private PlotTextAudioComponent AudioComp;

		// Token: 0x0401DB02 RID: 121602
		private TimerHandle EndTimer;

		// Token: 0x0401DB03 RID: 121603
		private long ProtectEndMs;

		// Token: 0x0401DB04 RID: 121604
		private float TypingDurationSec;

		// Token: 0x0401DB05 RID: 121605
		private int BoundTalkId = -1;

		// Token: 0x0401DB06 RID: 121606
		private bool IsPlaying;

		// Token: 0x0401DB07 RID: 121607
		private bool HasFiredFinished;

		// Token: 0x0401DB08 RID: 121608
		private Action OnFinishedCallback;

		// Token: 0x0200B8A6 RID: 47270
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04037E00 RID: 228864
			public const int TxtLetterContent = 0;
		}
	}
}
