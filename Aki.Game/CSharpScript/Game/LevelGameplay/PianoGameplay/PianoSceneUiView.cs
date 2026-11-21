using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C26 RID: 23590
	[NullableContext(2)]
	[Nullable(0)]
	public class PianoSceneUiView : SceneUiView
	{
		// Token: 0x06039F18 RID: 237336 RVA: 0x0104BB70 File Offset: 0x01049D70
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039F19 RID: 237337 RVA: 0x0104BC3C File Offset: 0x01049E3C
		protected override void OnStart()
		{
			this.SubtitleAnimPlayer.Init(base.GetText(0), base.GetItem(1), base.GetItem(2), base.GetItem(3), base.GetItem(4));
		}

		// Token: 0x06039F1A RID: 237338 RVA: 0x0104BC6C File Offset: 0x01049E6C
		protected override void OnBeforeShow()
		{
			this.TextComp = base.GetText(0);
			if (this.TextComp == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.PianoGameplay;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[PianoSceneUiView] 文本组件缺失";
				string item = "TalkId";
				ITalkItem currentTalkItem = this.CurrentTalkItem;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (currentTalkItem != null) ? new int?(currentTalkItem.Id) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.OpenParamMap = base.GetOpenParamMap();
			Dictionary<string, string> openParamMap = this.OpenParamMap;
			double num;
			double.TryParse(((openParamMap != null) ? openParamMap.GetValueOrDefault("FadeInEffect") : null) ?? "0", out num);
			this.SubtitleFadeInEffect = (int)num;
			Dictionary<string, string> openParamMap2 = this.OpenParamMap;
			double num2;
			double.TryParse(((openParamMap2 != null) ? openParamMap2.GetValueOrDefault("FadeOutEffect") : null) ?? "0", out num2);
			this.SubtitleFadeOutEffect = (int)num2;
			this.SetTextComponentStyle();
			if (!this.GetTalkItem())
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.PianoGameplay;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "[PianoSceneUiView] TalkItem获取失败";
				string item2 = "TalkId";
				ITalkItem currentTalkItem2 = this.CurrentTalkItem;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (currentTalkItem2 != null) ? new int?(currentTalkItem2.Id) : null);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			bool flag = false;
			Dictionary<string, string> openParamMap3 = this.OpenParamMap;
			int pbDataId;
			if (((openParamMap3 != null) ? openParamMap3.GetValueOrDefault("OwnerId") : null) != null && int.TryParse(this.OpenParamMap.GetValueOrDefault("OwnerId"), out pbDataId))
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
				if (((entityByPbDataId != null) ? entityByPbDataId.Entity : null) != null)
				{
					this.Owner = entityByPbDataId;
					flag = true;
					EventSystem.Instance.AddWithTarget(this.Owner.Entity, EEventName.OnSceneTextVoiceClose, new Action(this.OnSceneTextVoiceClose));
				}
			}
			if (!flag)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.PianoGameplay;
				ELogAuthor author3 = ELogAuthor.FJH;
				string message3 = "[PianoSceneUiView] 缺少Owner";
				string item3 = "TalkId";
				ITalkItem currentTalkItem3 = this.CurrentTalkItem;
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>(item3, (currentTalkItem3 != null) ? new int?(currentTalkItem3.Id) : null);
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
			this.InitComponents();
			this.PlayNextTalk();
		}

		// Token: 0x06039F1B RID: 237339 RVA: 0x0104BE80 File Offset: 0x0104A080
		private void RemoveOwnerEventListener()
		{
			if (this.Owner != null && this.Owner.Entity != null)
			{
				if (EventSystem.Instance.HasWithTarget(this.Owner.Entity, EEventName.OnSceneTextVoiceClose, new Action(this.OnSceneTextVoiceClose)))
				{
					EventSystem.Instance.RemoveWithTarget(this.Owner.Entity, EEventName.OnSceneTextVoiceClose, new Action(this.OnSceneTextVoiceClose));
				}
				this.Owner = null;
			}
		}

		// Token: 0x06039F1C RID: 237340 RVA: 0x0104BEF8 File Offset: 0x0104A0F8
		protected override UniTask OnBeforeHideAsync()
		{
			PianoSceneUiView.<OnBeforeHideAsync>d__24 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<PianoSceneUiView.<OnBeforeHideAsync>d__24>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039F1D RID: 237341 RVA: 0x0104BF3B File Offset: 0x0104A13B
		protected override void OnBeforeDestroy()
		{
			PlotTextWriterComponent writerComp = this.WriterComp;
			if (writerComp != null)
			{
				writerComp.Clear();
			}
			this.WriterComp = null;
			this.AudioComp = null;
			this.SubtitleAnimPlayer.Clear();
		}

		// Token: 0x06039F1E RID: 237342 RVA: 0x0104BF67 File Offset: 0x0104A167
		private void StopSubtitlePlayback()
		{
			this.StopTextAndAudio();
			this.IsSubtitleFadeOutPlaying = false;
			this.CurrentTalkItem = null;
			this.SubtitleAnimPlayer.Stop();
			CustomPromise<bool> subtitleHidePromise = this.SubtitleHidePromise;
			if (subtitleHidePromise != null)
			{
				subtitleHidePromise.SetResult(false);
			}
			this.SubtitleHidePromise = null;
		}

		// Token: 0x06039F1F RID: 237343 RVA: 0x0104BFA1 File Offset: 0x0104A1A1
		private void StopTextAndAudio()
		{
			this.IsWaitingAudioStart = false;
			this.IsTextWriterPlaying = false;
			this.IsAudioPlaying = false;
			this.ClearDelayHideTimer();
			PlotTextWriterComponent writerComp = this.WriterComp;
			if (writerComp != null)
			{
				writerComp.Stop();
			}
			PlotTextAudioComponent audioComp = this.AudioComp;
			if (audioComp == null)
			{
				return;
			}
			audioComp.StopAudio();
		}

		// Token: 0x06039F20 RID: 237344 RVA: 0x0104BFDF File Offset: 0x0104A1DF
		private void ClearDelayHideTimer()
		{
			TimerHandle delayHideTimer = this.DelayHideTimer;
			if (delayHideTimer != null && delayHideTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.DelayHideTimer);
			}
			this.DelayHideTimer = null;
		}

		// Token: 0x06039F21 RID: 237345 RVA: 0x0104C010 File Offset: 0x0104A210
		private unsafe bool GetTalkItem()
		{
			Dictionary<string, string> openParamMap = this.OpenParamMap;
			string text = (openParamMap != null) ? openParamMap.GetValueOrDefault("FlowListName") : null;
			Dictionary<string, string> openParamMap2 = this.OpenParamMap;
			string text2 = (openParamMap2 != null) ? openParamMap2.GetValueOrDefault("FlowId") : null;
			Dictionary<string, string> openParamMap3 = this.OpenParamMap;
			string text3 = (openParamMap3 != null) ? openParamMap3.GetValueOrDefault("StateId") : null;
			int num = 0;
			int num2 = 0;
			bool flag = text2 == null || (text2.Length > 0 && !int.TryParse(text2, out num));
			bool flag2 = text3 == null || (text3.Length > 0 && !int.TryParse(text3, out num2));
			if (string.IsNullOrEmpty(text) || flag || flag2)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.PianoGameplay;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[PianoSceneUiView] 获取FlowListName、FlowId、StateId失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateId", num2);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(text, num, num2);
			if (flowStateActions == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.PianoGameplay;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "[PianoSceneUiView] 获取TalkItem失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("FlowListName", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FlowId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("StateId", num2);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return false;
			}
			ShowTalk showTalk = null;
			foreach (ActionInfo actionInfo in flowStateActions)
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					showTalk = (actionInfo.Params as ShowTalk);
				}
			}
			if (showTalk == null)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.PianoGameplay;
				ELogAuthor author3 = ELogAuthor.FJH;
				string message3 = "[PianoSceneUiView] 获取ShowTalk失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("FlowListName", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("FlowId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("StateId", num2);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				return false;
			}
			this.ShowTalk = showTalk;
			this.CurrentTalkItemIndex = -1;
			List<ITalkItem> talkItems = showTalk.TalkItems;
			return talkItems != null && talkItems.Count > 0;
		}

		// Token: 0x06039F22 RID: 237346 RVA: 0x0104C2B4 File Offset: 0x0104A4B4
		private void InitComponents()
		{
			if (!this.SubtitleAnimPlayer.HasFadeIn(this.SubtitleFadeInEffect) && this.WriterComp == null)
			{
				UUIText textComp = this.TextComp;
				AActor aactor = (textComp != null) ? textComp.GetOwner() : null;
				UUIEffectTextAnimation uuieffectTextAnimation = ((aactor != null) ? aactor.GetComponentByClass(UUIEffectTextAnimation.StaticClass()) : null) as UUIEffectTextAnimation;
				ULGUIPlayTweenComponent ulguiplayTweenComponent = ((aactor != null) ? aactor.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) : null) as ULGUIPlayTweenComponent;
				if (uuieffectTextAnimation == null || ((ulguiplayTweenComponent != null) ? ulguiplayTweenComponent.GetPlayTween() : null) == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.PianoGameplay;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "[PianoSceneUiView] 文本打字机不可用，直接显示字幕";
					string item = "TalkId";
					ITalkItem currentTalkItem = this.CurrentTalkItem;
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (currentTalkItem != null) ? new int?(currentTalkItem.Id) : null);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.WriterComp = new PlotTextWriterComponent();
					this.WriterComp.Init(new PlotTextWriterComponentContext
					{
						TextComponent = this.TextComp,
						TextAnimComp = uuieffectTextAnimation,
						TweenComp = ulguiplayTweenComponent,
						OnAnimCompleteDelegate = new Action(this.OnTextAppearComplete)
					});
				}
			}
			if (this.AudioComp == null)
			{
				this.AudioComp = new PlotTextAudioComponent();
				this.AudioComp.Init(new PlotTextAudioComponentContext
				{
					OnAudioStartDelegate = new Action(this.OnAudioStart),
					OnAudioEndDelegate = new Action(this.OnAudioEnd),
					OnAudioLoadTimeoutDelegate = new Action(this.OnAudioEnd)
				});
			}
		}

		// Token: 0x06039F23 RID: 237347 RVA: 0x0104C42C File Offset: 0x0104A62C
		private void SetTextComponentStyle()
		{
			if (this.TextComp == null || this.OpenParamMap == null)
			{
				return;
			}
			if (this.OpenParamMap.GetValueOrDefault("FontSize") != null)
			{
				string valueOrDefault = this.OpenParamMap.GetValueOrDefault("FontSize");
				int num;
				if (!string.IsNullOrEmpty(valueOrDefault) && int.TryParse(valueOrDefault, out num))
				{
					this.TextComp.SetFontSize((float)num);
				}
			}
			if (this.OpenParamMap.GetValueOrDefault("BoxWidth") != null)
			{
				string valueOrDefault2 = this.OpenParamMap.GetValueOrDefault("BoxWidth");
				float width;
				if (!string.IsNullOrEmpty(valueOrDefault2) && float.TryParse(valueOrDefault2, out width))
				{
					this.TextComp.SetWidth(width);
				}
			}
			if (this.OpenParamMap.GetValueOrDefault("BoxHeight") != null)
			{
				string valueOrDefault3 = this.OpenParamMap.GetValueOrDefault("BoxHeight");
				float height;
				if (!string.IsNullOrEmpty(valueOrDefault3) && float.TryParse(valueOrDefault3, out height))
				{
					this.TextComp.SetHeight(height);
				}
			}
			if (this.OpenParamMap.GetValueOrDefault("Duration") != null)
			{
				string valueOrDefault4 = this.OpenParamMap.GetValueOrDefault("Duration");
				float num2 = 0f;
				if (string.IsNullOrWhiteSpace(valueOrDefault4) || float.TryParse(valueOrDefault4, out num2))
				{
					this.DialogTextDelayHideDuration = num2 * 1000f;
				}
			}
			if (this.OpenParamMap.GetValueOrDefault("AutoHide") != null)
			{
				this.AutoHide = (this.OpenParamMap.GetValueOrDefault("AutoHide") == "true");
			}
			else
			{
				this.AutoHide = false;
			}
			this.TextComp.SetOverflowType(UITextOverflowType.HorizontalMinMax);
			this.TextComp.bBestFit = true;
		}

		// Token: 0x06039F24 RID: 237348 RVA: 0x0104C5B2 File Offset: 0x0104A7B2
		private void OnSceneTextVoiceClose()
		{
			if (!this.IsAudioPlaying)
			{
				return;
			}
			PlotTextAudioComponent audioComp = this.AudioComp;
			if (audioComp != null)
			{
				audioComp.StopAudio();
			}
			this.OnAudioEnd();
		}

		// Token: 0x06039F25 RID: 237349 RVA: 0x0104C5D4 File Offset: 0x0104A7D4
		private void PlayNextTalk()
		{
			ShowTalk showTalk = this.ShowTalk;
			List<ITalkItem> list = (showTalk != null) ? showTalk.TalkItems : null;
			if (list == null)
			{
				return;
			}
			this.CurrentTalkItemIndex++;
			if (this.CurrentTalkItemIndex >= list.Count)
			{
				this.CurrentTalkItem = null;
				if (this.AutoHide && this.RootItem != null)
				{
					this.RootItem.SetUIActive(false);
				}
				return;
			}
			this.CurrentTalkItem = list[this.CurrentTalkItemIndex];
			this.TextComp.SetText("", true);
			this.IsWaitingAudioStart = true;
			this.IsAudioPlaying = true;
			if (!this.AudioComp.TryPlayTalkAudioByTalkItem(this.CurrentTalkItem))
			{
				this.OnAudioEnd();
			}
		}

		// Token: 0x06039F26 RID: 237350 RVA: 0x0104C684 File Offset: 0x0104A884
		private void PlayTextAppear()
		{
			this.IsWaitingAudioStart = false;
			LguiUtil.Instance.SetLocalTextNew(this.TextComp, this.CurrentTalkItem.TidTalk ?? "", Array.Empty<object>());
			this.IsTextWriterPlaying = true;
			if (this.SubtitleAnimPlayer.HasFadeIn(this.SubtitleFadeInEffect))
			{
				this.SubtitleAnimPlayer.PlayIn(this.SubtitleFadeInEffect, new Action(this.OnTextAppearComplete));
				return;
			}
			if (this.WriterComp != null)
			{
				this.WriterComp.Play();
				return;
			}
			this.SubtitleAnimPlayer.ShowImmediately();
			this.OnTextAppearComplete();
		}

		// Token: 0x06039F27 RID: 237351 RVA: 0x0104C71E File Offset: 0x0104A91E
		private void OnAudioStart()
		{
			if (!this.IsWaitingAudioStart)
			{
				return;
			}
			this.PlayTextAppear();
		}

		// Token: 0x06039F28 RID: 237352 RVA: 0x0104C72F File Offset: 0x0104A92F
		private void OnAudioEnd()
		{
			if (!this.IsAudioPlaying)
			{
				return;
			}
			this.IsAudioPlaying = false;
			if (this.IsWaitingAudioStart)
			{
				this.PlayTextAppear();
				return;
			}
			this.TryStartDelayHideTimer();
		}

		// Token: 0x06039F29 RID: 237353 RVA: 0x0104C756 File Offset: 0x0104A956
		private void OnTextAppearComplete()
		{
			if (!this.IsTextWriterPlaying)
			{
				return;
			}
			this.IsTextWriterPlaying = false;
			this.TryStartDelayHideTimer();
		}

		// Token: 0x06039F2A RID: 237354 RVA: 0x0104C770 File Offset: 0x0104A970
		private void TryStartDelayHideTimer()
		{
			if (this.CurrentTalkItem == null || this.IsTextWriterPlaying || this.IsAudioPlaying || this.IsSubtitleFadeOutPlaying || this.DelayHideTimer != null || this.DialogTextDelayHideDuration < 0f)
			{
				return;
			}
			this.DelayHideTimer = ((this.DialogTextDelayHideDuration < 20f) ? TimerSystem.Instance.Next(new TTimerAction(this.FinishCurrentTalk), null, null) : TimerSystem.Instance.Delay(new TTimerAction(this.FinishCurrentTalk), this.DialogTextDelayHideDuration, null, null, true, 1f));
		}

		// Token: 0x06039F2B RID: 237355 RVA: 0x0104C804 File Offset: 0x0104AA04
		private void FinishCurrentTalk(float _)
		{
			this.ClearDelayHideTimer();
			if (this.CurrentTalkItem == null || this.IsSubtitleFadeOutPlaying)
			{
				return;
			}
			if (!this.AutoHide && this.CurrentTalkItemIndex == this.ShowTalk.TalkItems.Count - 1)
			{
				return;
			}
			this.IsSubtitleFadeOutPlaying = true;
			this.SubtitleAnimPlayer.PlayOut(this.SubtitleFadeOutEffect, new Action(this.OnSubtitleFadeOutComplete));
		}

		// Token: 0x06039F2C RID: 237356 RVA: 0x0104C86F File Offset: 0x0104AA6F
		private void OnSubtitleFadeOutComplete()
		{
			if (!this.IsSubtitleFadeOutPlaying)
			{
				return;
			}
			this.IsSubtitleFadeOutPlaying = false;
			if (this.SubtitleHidePromise != null)
			{
				this.CurrentTalkItem = null;
				this.SubtitleHidePromise.SetResult(true);
				return;
			}
			this.PlayNextTalk();
		}

		// Token: 0x0401EA35 RID: 125493
		private ITalkItem CurrentTalkItem;

		// Token: 0x0401EA36 RID: 125494
		private PlotTextWriterComponent WriterComp;

		// Token: 0x0401EA37 RID: 125495
		private PlotTextAudioComponent AudioComp;

		// Token: 0x0401EA38 RID: 125496
		private UUIText TextComp;

		// Token: 0x0401EA39 RID: 125497
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, string> OpenParamMap;

		// Token: 0x0401EA3A RID: 125498
		private EntityHandle Owner;

		// Token: 0x0401EA3B RID: 125499
		private ShowTalk ShowTalk;

		// Token: 0x0401EA3C RID: 125500
		private int CurrentTalkItemIndex;

		// Token: 0x0401EA3D RID: 125501
		private bool IsAudioPlaying;

		// Token: 0x0401EA3E RID: 125502
		private bool IsWaitingAudioStart;

		// Token: 0x0401EA3F RID: 125503
		private bool IsTextWriterPlaying;

		// Token: 0x0401EA40 RID: 125504
		private bool IsSubtitleFadeOutPlaying;

		// Token: 0x0401EA41 RID: 125505
		private TimerHandle DelayHideTimer;

		// Token: 0x0401EA42 RID: 125506
		private float DialogTextDelayHideDuration;

		// Token: 0x0401EA43 RID: 125507
		private bool AutoHide;

		// Token: 0x0401EA44 RID: 125508
		private int SubtitleFadeInEffect;

		// Token: 0x0401EA45 RID: 125509
		private int SubtitleFadeOutEffect;

		// Token: 0x0401EA46 RID: 125510
		[Nullable(1)]
		private readonly PianoSubtitleAnimPlayer SubtitleAnimPlayer = new PianoSubtitleAnimPlayer();

		// Token: 0x0401EA47 RID: 125511
		private CustomPromise<bool> SubtitleHidePromise;

		// Token: 0x0200B792 RID: 46994
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04038B8B RID: 232331
			ItemText,
			// Token: 0x04038B8C RID: 232332
			AniTexIn,
			// Token: 0x04038B8D RID: 232333
			AniTexOut,
			// Token: 0x04038B8E RID: 232334
			AniTexRotPosIn,
			// Token: 0x04038B8F RID: 232335
			AniTexRotPosOut
		}
	}
}
