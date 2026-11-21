using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Module.Plot.Sequence.Assistant;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004037 RID: 16439
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotViewHud : UiTickViewBase, ISimulatePlot
	{
		// Token: 0x06029A6A RID: 170602 RVA: 0x00BC600D File Offset: 0x00BC420D
		public void SimulateClickSubtitle()
		{
		}

		// Token: 0x06029A6B RID: 170603 RVA: 0x00BC600F File Offset: 0x00BC420F
		public void SimulateClickOption()
		{
		}

		// Token: 0x170053F5 RID: 21493
		// (get) Token: 0x06029A6C RID: 170604 RVA: 0x00BC6011 File Offset: 0x00BC4211
		[Nullable(2)]
		public ITalkItem CurrentSubtitle
		{
			[NullableContext(2)]
			get
			{
				return this.CommonLogic.CurrentContent;
			}
		}

		// Token: 0x06029A6D RID: 170605 RVA: 0x00BC601E File Offset: 0x00BC421E
		public PlotViewHud(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06029A6E RID: 170606 RVA: 0x00BC6038 File Offset: 0x00BC4238
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISliderComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06029A6F RID: 170607 RVA: 0x00BC6214 File Offset: 0x00BC4414
		protected override void OnStart()
		{
			UUIScrollViewComponent scrollView = base.GetScrollView(8);
			if (scrollView != null)
			{
				scrollView.SetCanScroll(false);
			}
			if (scrollView != null)
			{
				scrollView.SetRayCastTargetForScrollView(false);
			}
			this.CommonLogic = new PlotTextCommonLogic(base.GetItem(4), base.GetText(0), base.GetText(1), base.GetText(2), base.GetItem(3), scrollView, this, base.GetLayoutBase(10), base.GetItem(11), base.GetSlider(12), this.UiViewSequence, null, null, null, null, null, null, null, null, null);
			this.CommonLogic.SetPlotContentAnimFinishCallback(new Action(this.HandleSubtitleAnimFinished));
			this.CommonLogic.SetPlotAudioEndCallback(new Action<float>(this.HandlePlotAudioEnd));
			this.CommonLogic.SetPlotContentUpdateCallback(new Action<string>(this.OnPlotContentUpdated));
			this.SetPlotPosition();
			this.SetTextWidth();
			this.IsHang = false;
		}

		// Token: 0x06029A70 RID: 170608 RVA: 0x00BC62F0 File Offset: 0x00BC44F0
		protected override UniTask OnBeforeStartAsync()
		{
			PlotViewHud.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PlotViewHud.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029A71 RID: 170609 RVA: 0x00BC6334 File Offset: 0x00BC4534
		private UniTask OpenEntitySequenceViewAsync()
		{
			PlotViewHud.<OpenEntitySequenceViewAsync>d__26 <OpenEntitySequenceViewAsync>d__;
			<OpenEntitySequenceViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenEntitySequenceViewAsync>d__.<>4__this = this;
			<OpenEntitySequenceViewAsync>d__.<>1__state = -1;
			<OpenEntitySequenceViewAsync>d__.<>t__builder.Start<PlotViewHud.<OpenEntitySequenceViewAsync>d__26>(ref <OpenEntitySequenceViewAsync>d__);
			return <OpenEntitySequenceViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029A72 RID: 170610 RVA: 0x00BC6378 File Offset: 0x00BC4578
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<UUIItem> GetEntitySequenceButtonRootAsync()
		{
			PlotViewHud.<GetEntitySequenceButtonRootAsync>d__27 <GetEntitySequenceButtonRootAsync>d__;
			<GetEntitySequenceButtonRootAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UUIItem>.Create();
			<GetEntitySequenceButtonRootAsync>d__.<>1__state = -1;
			<GetEntitySequenceButtonRootAsync>d__.<>t__builder.Start<PlotViewHud.<GetEntitySequenceButtonRootAsync>d__27>(ref <GetEntitySequenceButtonRootAsync>d__);
			return <GetEntitySequenceButtonRootAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029A73 RID: 170611 RVA: 0x00BC63B3 File Offset: 0x00BC45B3
		private void HandleSubtitleAnimFinished()
		{
			if (this.IsControlEntitySequenceBridge())
			{
				return;
			}
			this.DelayHandleSubtitleActions();
		}

		// Token: 0x06029A74 RID: 170612 RVA: 0x00BC63C4 File Offset: 0x00BC45C4
		private void DelayHandleSubtitleActions()
		{
			if (this.IsControlEntitySequenceBridge())
			{
				return;
			}
			this.RemoveDelayTimer();
			float val = PlotModel.Instance.PlotGlobalConfig.EndWaitTimeLevelD * 1000f;
			this.DelayTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.DelayTimer = null;
				this.IsSubtitleFinishDelay = true;
				this.TrySubmitSubtitle();
			}, Math.Max(this.CommonLogic.PlayDelayTime.GetValueOrDefault(), val), null, null, true, 1f);
		}

		// Token: 0x06029A75 RID: 170613 RVA: 0x00BC6430 File Offset: 0x00BC4630
		private void HandlePlotAudioEnd(float tailTime)
		{
			if (this.IsControlEntitySequenceBridge())
			{
				return;
			}
			this.RemoveAudioEndDelayTimer();
			if (tailTime <= 20f)
			{
				this.IsAudioFinishDelay = true;
				this.TrySubmitSubtitle();
				return;
			}
			this.AudioEndDelayTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.AudioEndDelayTimer = null;
				this.IsAudioFinishDelay = true;
				this.TrySubmitSubtitle();
			}, tailTime, null, null, true, 1f);
		}

		// Token: 0x06029A76 RID: 170614 RVA: 0x00BC6487 File Offset: 0x00BC4687
		private void TrySubmitSubtitle()
		{
			if (!this.IsSubtitleFinishDelay || !this.IsAudioFinishDelay || this.IsControlEntitySequenceBridge())
			{
				return;
			}
			this.HandleSubtitleActions();
		}

		// Token: 0x06029A77 RID: 170615 RVA: 0x00BC64A8 File Offset: 0x00BC46A8
		private void HandleSubtitleActions()
		{
			this.RemoveDelayTimer();
			this.RemoveAudioEndDelayTimer();
			this.IsSubtitleFinishDelay = false;
			this.IsAudioFinishDelay = false;
			this.IsInSubtitle = false;
			if (this.IsControlEntitySequenceBridge())
			{
				return;
			}
			FlowController.Instance.FlowShowTalk.SubmitSubtitle(this.CommonLogic.CurrentContent);
		}

		// Token: 0x06029A78 RID: 170616 RVA: 0x00BC64F9 File Offset: 0x00BC46F9
		private void RemoveDelayTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.DelayTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimer);
			}
			this.DelayTimer = null;
		}

		// Token: 0x06029A79 RID: 170617 RVA: 0x00BC6525 File Offset: 0x00BC4725
		private void RemoveAudioEndDelayTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.AudioEndDelayTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AudioEndDelayTimer);
			}
			this.AudioEndDelayTimer = null;
		}

		// Token: 0x06029A7A RID: 170618 RVA: 0x00BC6554 File Offset: 0x00BC4754
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PlotViewHud.<OnPlayingCloseSequenceAsync>d__35 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PlotViewHud.<OnPlayingCloseSequenceAsync>d__35>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029A7B RID: 170619 RVA: 0x00BC6598 File Offset: 0x00BC4798
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<ITalkItem>(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.UpdatePlotSubtitle));
			EventSystem.Instance.Add<SetHeadIconVisible, Action>(EEventName.UpdatePortraitVisible, new Action<SetHeadIconVisible, Action>(this.HandlePortraitVisible));
			EventSystem.Instance.Add(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
			EventSystem.Instance.Add<bool>(EEventName.HangPlotViewHud, new Action<bool>(this.OnHang));
			EventSystem.Instance.Add<UiParam>(EEventName.UpdatePlotUiParam, new Action<UiParam>(this.UpdateUiParam));
			EventSystem.Instance.Add(EEventName.ShowPlotSubtitleOptions, new Action(this.ShowOptions));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			SequenceController.Instance.Event.Add(ESequenceEventName.UpdateSeqSubtitle, new Action<PlotSubtitleConfig>(this.UpdateSequenceSubtitle));
			SequenceController.Instance.Event.Add(ESequenceEventName.HandlePlotOptionSelected, new Action<int>(this.HandlePlotOptionSelected));
			SequenceController.Instance.Event.Add(ESequenceEventName.HandleSeqSubtitleEnd, new Action<int, bool>(this.HandleSeqSubtitleEnd));
			SequenceController.Instance.Event.Add(ESequenceEventName.HandleSubSequenceStop, new Action(this.HandleSubSequenceStop));
		}

		// Token: 0x06029A7C RID: 170620 RVA: 0x00BC66E0 File Offset: 0x00BC48E0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<ITalkItem>(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.UpdatePlotSubtitle));
			EventSystem.Instance.Remove<SetHeadIconVisible, Action>(EEventName.UpdatePortraitVisible, new Action<SetHeadIconVisible, Action>(this.HandlePortraitVisible));
			EventSystem.Instance.Remove(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
			EventSystem.Instance.Remove<bool>(EEventName.HangPlotViewHud, new Action<bool>(this.OnHang));
			EventSystem.Instance.Remove<UiParam>(EEventName.UpdatePlotUiParam, new Action<UiParam>(this.UpdateUiParam));
			EventSystem.Instance.Remove(EEventName.ShowPlotSubtitleOptions, new Action(this.ShowOptions));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			SequenceController.Instance.Event.Remove(ESequenceEventName.UpdateSeqSubtitle, new Action<PlotSubtitleConfig>(this.UpdateSequenceSubtitle));
			SequenceController.Instance.Event.Remove(ESequenceEventName.HandlePlotOptionSelected, new Action<int>(this.HandlePlotOptionSelected));
			SequenceController.Instance.Event.Remove(ESequenceEventName.HandleSeqSubtitleEnd, new Action<int, bool>(this.HandleSeqSubtitleEnd));
			SequenceController.Instance.Event.Remove(ESequenceEventName.HandleSubSequenceStop, new Action(this.HandleSubSequenceStop));
		}

		// Token: 0x06029A7D RID: 170621 RVA: 0x00BC6825 File Offset: 0x00BC4A25
		private void OnInputControllerChange(EInputControllerType _1, EInputControllerType _2)
		{
			if (this.HasBindActionGamepad || this.HasBindActionOther)
			{
				this.HandleActionBinding(false);
				this.HandleActionBinding(true);
			}
			EntitySequenceView entitySequenceView = this.EntitySequenceView;
			if (entitySequenceView != null)
			{
				entitySequenceView.RefreshActionBinding();
			}
			this.RefreshEntitySequenceParentAsync().Forget();
		}

		// Token: 0x06029A7E RID: 170622 RVA: 0x00BC6864 File Offset: 0x00BC4A64
		private UniTask RefreshEntitySequenceParentAsync()
		{
			PlotViewHud.<RefreshEntitySequenceParentAsync>d__39 <RefreshEntitySequenceParentAsync>d__;
			<RefreshEntitySequenceParentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEntitySequenceParentAsync>d__.<>4__this = this;
			<RefreshEntitySequenceParentAsync>d__.<>1__state = -1;
			<RefreshEntitySequenceParentAsync>d__.<>t__builder.Start<PlotViewHud.<RefreshEntitySequenceParentAsync>d__39>(ref <RefreshEntitySequenceParentAsync>d__);
			return <RefreshEntitySequenceParentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029A7F RID: 170623 RVA: 0x00BC68A7 File Offset: 0x00BC4AA7
		private void ShowOptions()
		{
			this.IsInOption = true;
			this.CommonLogic.ShowOptions();
			this.BindInput();
		}

		// Token: 0x06029A80 RID: 170624 RVA: 0x00BC68C1 File Offset: 0x00BC4AC1
		private void ClearOptions()
		{
			this.IsInOption = false;
			this.CommonLogic.ClearOptions();
			this.UnbindInput();
		}

		// Token: 0x06029A81 RID: 170625 RVA: 0x00BC68DC File Offset: 0x00BC4ADC
		private void UpdateSequenceSubtitle(PlotSubtitleConfig inPlotSubtitleInfo)
		{
			if (!this.IsControlEntitySequenceBridge())
			{
				return;
			}
			ITalkItem subtitles = inPlotSubtitleInfo.Subtitles;
			if (subtitles == null)
			{
				return;
			}
			this.SetControlEntityHudVisible(true);
			this.CurrentSequenceSubtitleId = subtitles.Id;
			this.UpdatePlotSubtitle(subtitles);
		}

		// Token: 0x06029A82 RID: 170626 RVA: 0x00BC6917 File Offset: 0x00BC4B17
		private void UpdatePlotSubtitle(ITalkItem inPlotSubtitleInfo)
		{
			if (this.IsHang)
			{
				return;
			}
			this.RemoveDelayTimer();
			this.RemoveAudioEndDelayTimer();
			this.IsSubtitleFinishDelay = false;
			this.IsAudioFinishDelay = false;
			this.IsInSubtitle = true;
			this.ClearOptions();
			this.CommonLogic.UpdatePlotSubtitle(inPlotSubtitleInfo);
		}

		// Token: 0x06029A83 RID: 170627 RVA: 0x00BC6955 File Offset: 0x00BC4B55
		protected virtual void OnPlotContentUpdated(string text)
		{
		}

		// Token: 0x06029A84 RID: 170628 RVA: 0x00BC6957 File Offset: 0x00BC4B57
		private void HandlePortraitVisible(SetHeadIconVisible headIconInfo, Action callback)
		{
			this.CommonLogic.HandlePortraitVisible(this.RootItem, headIconInfo, callback);
		}

		// Token: 0x06029A85 RID: 170629 RVA: 0x00BC696C File Offset: 0x00BC4B6C
		public void StopVoiceOnInterrupt(ExecuteActionArgs args)
		{
			PlotTextCommonLogic commonLogic = this.CommonLogic;
			if (commonLogic == null)
			{
				return;
			}
			commonLogic.ClearCurPlayAudio(new ExecuteActionArgs?(args));
		}

		// Token: 0x06029A86 RID: 170630 RVA: 0x00BC6984 File Offset: 0x00BC4B84
		private void ClearPlotSubtitle()
		{
			this.IsInSubtitle = false;
			this.CommonLogic.ClearPlotContent(false);
			this.ClearOptions();
			this.RemoveDelayTimer();
			this.RemoveAudioEndDelayTimer();
			this.IsSubtitleFinishDelay = false;
			this.IsAudioFinishDelay = false;
			this.ResumeSequenceForControlEntityOption();
			this.CurrentSequenceSubtitleId = -1;
		}

		// Token: 0x06029A87 RID: 170631 RVA: 0x00BC69D1 File Offset: 0x00BC4BD1
		private void ClearSubtitleDisplayOnEnd()
		{
			this.IsInSubtitle = false;
			this.CommonLogic.ClearPlotContent(true);
			this.RemoveDelayTimer();
			this.RemoveAudioEndDelayTimer();
			this.IsSubtitleFinishDelay = false;
			this.IsAudioFinishDelay = false;
			this.CurrentSequenceSubtitleId = -1;
		}

		// Token: 0x06029A88 RID: 170632 RVA: 0x00BC6A08 File Offset: 0x00BC4C08
		private void HandleSeqSubtitleEnd(int id, bool isSkip)
		{
			if (!this.IsControlEntitySequenceBridge())
			{
				return;
			}
			ITalkItem currentSubtitle = this.CurrentSubtitle;
			if (((currentSubtitle != null) ? currentSubtitle.Id : this.CurrentSequenceSubtitleId) != id)
			{
				return;
			}
			if (isSkip)
			{
				this.ClearPlotSubtitle();
				this.SetControlEntityHudVisible(false);
				return;
			}
			ITalkItem talkItem = currentSubtitle ?? PlotModel.Instance.CurTalkItem;
			if (talkItem != null && this.CheckHasSubtitleOptions(talkItem))
			{
				this.ClearSubtitleDisplayOnEnd();
				this.PauseSequenceForControlEntityOption();
				this.ShowOptions();
				return;
			}
			this.ClearPlotSubtitle();
			this.SetControlEntityHudVisible(false);
		}

		// Token: 0x06029A89 RID: 170633 RVA: 0x00BC6A87 File Offset: 0x00BC4C87
		private void HandlePlotOptionSelected(int inOptionIndex)
		{
			if (!this.IsControlEntitySequenceBridge())
			{
				return;
			}
			this.ClearPlotSubtitle();
			this.SetControlEntityHudVisible(false);
		}

		// Token: 0x06029A8A RID: 170634 RVA: 0x00BC6A9F File Offset: 0x00BC4C9F
		private void HandleSubSequenceStop()
		{
			if (!this.IsControlEntitySequenceBridge())
			{
				return;
			}
			this.ClearPlotSubtitle();
			this.SetControlEntityHudVisible(false);
		}

		// Token: 0x06029A8B RID: 170635 RVA: 0x00BC6AB7 File Offset: 0x00BC4CB7
		private void OnHang(bool isHang = false)
		{
			this.OnHang(isHang, true);
		}

		// Token: 0x06029A8C RID: 170636 RVA: 0x00BC6AC4 File Offset: 0x00BC4CC4
		private void OnHang(bool isHang = false, bool bSetActive = true)
		{
			if (this.IsHang == isHang)
			{
				return;
			}
			if (!isHang && base.IsHideOrHiding)
			{
				return;
			}
			this.IsHang = isHang;
			if (isHang)
			{
				if (bSetActive)
				{
					base.SetUiActive(false);
				}
				this.PauseSubtitle();
				this.PauseOptions();
				FlowController.Instance.CountDownSkip(true);
				return;
			}
			if (bSetActive)
			{
				base.SetUiActive(true);
			}
			this.ResumeSubtitle();
			this.ResumeOptions();
			FlowController.Instance.CountDownSkip(false);
		}

		// Token: 0x06029A8D RID: 170637 RVA: 0x00BC6B34 File Offset: 0x00BC4D34
		protected override void OnAfterPlayStartSequence()
		{
			this.AttachView();
		}

		// Token: 0x06029A8E RID: 170638 RVA: 0x00BC6B3C File Offset: 0x00BC4D3C
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, true);
			PlotModel instance = PlotModel.Instance;
			this.OnHang(instance != null && instance.HangViewHud, false);
			this.SetEnableTranslucent(PlotModel.Instance.TranslucentHud);
			this.IsControlEntityHudVisible = true;
		}

		// Token: 0x06029A8F RID: 170639 RVA: 0x00BC6B94 File Offset: 0x00BC4D94
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, false);
			this.OnHang(true, false);
			this.IsControlEntityHudVisible = false;
		}

		// Token: 0x06029A90 RID: 170640 RVA: 0x00BC6BC4 File Offset: 0x00BC4DC4
		protected override void OnBeforeDestroy()
		{
			this.EntitySequenceAttachToken++;
			PlotTextCommonLogic commonLogic = this.CommonLogic;
			if (commonLogic != null)
			{
				commonLogic.Clear();
			}
			this.RemoveDelayTimer();
			this.RemoveAudioEndDelayTimer();
			FlowController.Instance.CountDownSkip(false);
			this.ResumeSequenceForControlEntityOption();
			this.IsControlEntityHudVisible = false;
			if (this.EntitySequenceView != null)
			{
				this.EntitySequenceView.CloseAsync().Forget();
				this.EntitySequenceView = null;
			}
		}

		// Token: 0x06029A91 RID: 170641 RVA: 0x00BC6C33 File Offset: 0x00BC4E33
		private bool IsControlEntitySequenceBridge()
		{
			return PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.ControlEntity;
		}

		// Token: 0x06029A92 RID: 170642 RVA: 0x00BC6C4C File Offset: 0x00BC4E4C
		private bool CheckHasSubtitleOptions(ITalkItem subtitle)
		{
			if (subtitle.Type.GetValueOrDefault() != ETalkItemType.SystemOption)
			{
				List<ITalkOption> options = subtitle.Options;
				return ((options != null) ? options.Count : 0) > 0;
			}
			return true;
		}

		// Token: 0x06029A93 RID: 170643 RVA: 0x00BC6C81 File Offset: 0x00BC4E81
		private void PauseSequenceForControlEntityOption()
		{
			if (this.PauseByControlEntityOption)
			{
				return;
			}
			this.PauseByControlEntityOption = true;
			SequenceController.Instance.PauseSequence("ControlEntityHudOption");
		}

		// Token: 0x06029A94 RID: 170644 RVA: 0x00BC6CA4 File Offset: 0x00BC4EA4
		private void ResumeSequenceForControlEntityOption()
		{
			if (!this.PauseByControlEntityOption)
			{
				return;
			}
			this.PauseByControlEntityOption = false;
			SequenceController.Instance.ResumeSequence("ControlEntityHudOption", null);
		}

		// Token: 0x06029A95 RID: 170645 RVA: 0x00BC6CDC File Offset: 0x00BC4EDC
		private void SetControlEntityHudVisible(bool visible)
		{
			if (!this.IsControlEntitySequenceBridge() || this.IsControlEntityHudVisible == visible)
			{
				return;
			}
			this.IsControlEntityHudVisible = visible;
			base.SetUiActive(visible);
			if (visible)
			{
				UUIText text = base.GetText(2);
				if (text != null)
				{
					text.SetUIActive(false);
				}
				UUIText text2 = base.GetText(0);
				if (text2 != null)
				{
					text2.SetUIActive(false);
				}
				UUIText text3 = base.GetText(1);
				if (text3 != null)
				{
					text3.SetUIActive(false);
				}
				UUIItem item = base.GetItem(3);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
			}
		}

		// Token: 0x06029A96 RID: 170646 RVA: 0x00BC6D58 File Offset: 0x00BC4F58
		private void SetPlotPosition()
		{
			UiParam uiParam = this.OpenParam as UiParam;
			if (uiParam == null || uiParam.Position == null || uiParam.ViewName == null)
			{
				return;
			}
			if (uiParam.ViewName == EUiViewName.BattleView)
			{
				return;
			}
			UUIItem item = base.GetItem(4);
			if (uiParam.Position.GetValueOrDefault() == EPlotLowLevelPosition.Right)
			{
				item.SetUIParent(base.GetItem(6), false);
			}
			else if (uiParam.Position.GetValueOrDefault() == EPlotLowLevelPosition.Center)
			{
				item.SetUIParent(base.GetItem(7), false);
			}
			else
			{
				item.SetUIParent(base.GetItem(5), false);
			}
			item.SetAnchorOffsetX(0f);
		}

		// Token: 0x06029A97 RID: 170647 RVA: 0x00BC6E24 File Offset: 0x00BC5024
		private void SetTextWidth()
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			UiParam uiParam = this.OpenParam as UiParam;
			if (uiParam == null || uiParam.TextWidth == null)
			{
				return;
			}
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetWidth((float)uiParam.TextWidth.Value);
		}

		// Token: 0x06029A98 RID: 170648 RVA: 0x00BC6E80 File Offset: 0x00BC5080
		private void AttachView()
		{
			UiParam uiParam = this.OpenParam as UiParam;
			if (uiParam == null || uiParam.ViewName == null)
			{
				return;
			}
			UiViewBase viewByName = UiManager.Instance.GetViewByName(uiParam.ViewName.Value);
			if (viewByName == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[PlotViewHud] 父界面已经不在，子界面直接关闭";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("parent", uiParam.ViewName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.CloseMe(null);
				return;
			}
			viewByName.AddChild(this);
			if (viewByName.IsHideOrHiding)
			{
				base.Hide(null);
			}
		}

		// Token: 0x06029A99 RID: 170649 RVA: 0x00BC6F1E File Offset: 0x00BC511E
		private void UpdateUiParam(UiParam param)
		{
			this.OpenParam = param;
			this.AttachView();
			this.SetTextWidth();
			this.SetPlotPosition();
		}

		// Token: 0x06029A9A RID: 170650 RVA: 0x00BC6F39 File Offset: 0x00BC5139
		private void PauseSubtitle()
		{
			if (PlotModel.Instance.CurTalkItem == null)
			{
				return;
			}
			this.CommonLogic.PauseSubtitle();
			if (this.DelayTimer != null)
			{
				this.DelayTimer.Pause();
			}
			TimerHandle audioEndDelayTimer = this.AudioEndDelayTimer;
			if (audioEndDelayTimer == null)
			{
				return;
			}
			audioEndDelayTimer.Pause();
		}

		// Token: 0x06029A9B RID: 170651 RVA: 0x00BC6F78 File Offset: 0x00BC5178
		private void ResumeSubtitle()
		{
			if (PlotModel.Instance.CurTalkItem == null)
			{
				return;
			}
			if (!this.IsInSubtitle)
			{
				this.UpdatePlotSubtitle(PlotModel.Instance.CurTalkItem);
				return;
			}
			this.CommonLogic.ResumeSubtitle(PlotModel.Instance.CurTalkItem);
			if (this.DelayTimer != null)
			{
				this.DelayTimer.Resume();
			}
			if (TimerSystem.GameplayTimeInstance.Has(this.AudioEndDelayTimer) && this.AudioEndDelayTimer.IsPause())
			{
				this.AudioEndDelayTimer.Resume();
			}
		}

		// Token: 0x06029A9C RID: 170652 RVA: 0x00BC6FFF File Offset: 0x00BC51FF
		private void PauseOptions()
		{
			if (!this.IsInOption)
			{
				return;
			}
			this.CommonLogic.MuteTimeLimitedOption = true;
			this.UnbindInput();
		}

		// Token: 0x06029A9D RID: 170653 RVA: 0x00BC701C File Offset: 0x00BC521C
		private void ResumeOptions()
		{
			if (!PlotModel.Instance.InOptions)
			{
				return;
			}
			if (!this.IsInOption)
			{
				this.ShowOptions();
				return;
			}
			this.CommonLogic.MuteTimeLimitedOption = false;
			this.BindInput();
		}

		// Token: 0x06029A9E RID: 170654 RVA: 0x00BC704C File Offset: 0x00BC524C
		private void BindInput()
		{
			if (PlotModel.Instance.TimeLimitedOptionTag)
			{
				return;
			}
			PlotModel.Instance.TimeLimitedOptionTag = true;
			InputDistributeController.Instance.RefreshInputTag();
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData != null)
			{
				childViewData.HideBattleView(EBattleUiVisibleReason.Plot, new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
				{
					EBattleUiChild.Joystick,
					EBattleUiChild.ScreenEffect
				}), 0);
			}
			this.HandleActionBinding(true);
		}

		// Token: 0x06029A9F RID: 170655 RVA: 0x00BC70B0 File Offset: 0x00BC52B0
		private void UnbindInput()
		{
			if (!PlotModel.Instance.TimeLimitedOptionTag)
			{
				return;
			}
			PlotModel.Instance.TimeLimitedOptionTag = false;
			InputDistributeController.Instance.RefreshInputTag();
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData != null)
			{
				childViewData.ShowBattleView(EBattleUiVisibleReason.Plot, 0);
			}
			this.HandleActionBinding(false);
		}

		// Token: 0x06029AA0 RID: 170656 RVA: 0x00BC7100 File Offset: 0x00BC5300
		private void HandleActionBinding(bool bBind)
		{
			if (!bBind)
			{
				if (this.HasBindActionGamepad)
				{
					this.HasBindActionGamepad = false;
					InputDistributeController.Instance.UnBindActionIgnoreLimit("D级限时选项-1", new TInputHandle<InputDistributeDefine.EActionType>(this.SelectedOne));
					InputDistributeController.Instance.UnBindActionIgnoreLimit("D级限时选项-2", new TInputHandle<InputDistributeDefine.EActionType>(this.SelectedTwo));
				}
				if (this.HasBindActionOther)
				{
					this.HasBindActionOther = false;
					InputDistributeController.Instance.UnBindActionIgnoreLimit("切换角色1", new TInputHandle<InputDistributeDefine.EActionType>(this.SelectedOne));
					InputDistributeController.Instance.UnBindActionIgnoreLimit("切换角色2", new TInputHandle<InputDistributeDefine.EActionType>(this.SelectedTwo));
				}
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				if (this.HasBindActionGamepad)
				{
					return;
				}
				InputDistributeController.Instance.BindActionIgnoreLimit("D级限时选项-1", new TInputHandle<InputDistributeDefine.EActionType>(this.SelectedOne));
				InputDistributeController.Instance.BindActionIgnoreLimit("D级限时选项-2", new TInputHandle<InputDistributeDefine.EActionType>(this.SelectedTwo));
				this.HasBindActionGamepad = true;
				return;
			}
			else
			{
				if (this.HasBindActionOther)
				{
					return;
				}
				InputDistributeController.Instance.BindActionIgnoreLimit("切换角色1", new TInputHandle<InputDistributeDefine.EActionType>(this.SelectedOne));
				InputDistributeController.Instance.BindActionIgnoreLimit("切换角色2", new TInputHandle<InputDistributeDefine.EActionType>(this.SelectedTwo));
				this.HasBindActionOther = true;
				return;
			}
		}

		// Token: 0x06029AA1 RID: 170657 RVA: 0x00BC7237 File Offset: 0x00BC5437
		private void SelectedOne(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			this.SelectedOption(0);
		}

		// Token: 0x06029AA2 RID: 170658 RVA: 0x00BC7240 File Offset: 0x00BC5440
		private void SelectedTwo(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			this.SelectedOption(1);
		}

		// Token: 0x06029AA3 RID: 170659 RVA: 0x00BC724C File Offset: 0x00BC544C
		private void SelectedOption(int index)
		{
			if (this.CommonLogic.Options == null)
			{
				return;
			}
			PlotOptionItem[] options = this.CommonLogic.Options;
			int num = -1;
			for (int i = 0; i < options.Length; i++)
			{
				if (options[i].OptionIndex == index)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				throw new InvalidOperationException("Sequence contains no matching element");
			}
			options[num].OptionClick(new bool?(true));
		}

		// Token: 0x06029AA4 RID: 170660 RVA: 0x00BC72AF File Offset: 0x00BC54AF
		public void SetEnableTranslucent(bool enable)
		{
			if (enable)
			{
				UUIItem rootItem = base.GetRootItem();
				if (rootItem == null)
				{
					return;
				}
				rootItem.SetAlpha(0.6f);
				return;
			}
			else
			{
				UUIItem rootItem2 = base.GetRootItem();
				if (rootItem2 == null)
				{
					return;
				}
				rootItem2.SetAlpha(1f);
				return;
			}
		}

		// Token: 0x06029AA5 RID: 170661 RVA: 0x00BC72DF File Offset: 0x00BC54DF
		protected override void OnTick(float delta)
		{
			this.CommonLogic.OnTick(delta);
		}

		// Token: 0x04016BCB RID: 93131
		private const float TRANSLUCENT_ALPHA = 0.6f;

		// Token: 0x04016BCC RID: 93132
		private const string CONTROL_ENTITY_OPTION_PAUSE = "ControlEntityHudOption";

		// Token: 0x04016BCD RID: 93133
		private PlotTextCommonLogic CommonLogic;

		// Token: 0x04016BCE RID: 93134
		[Nullable(2)]
		private TimerHandle DelayTimer;

		// Token: 0x04016BCF RID: 93135
		[Nullable(2)]
		private TimerHandle AudioEndDelayTimer;

		// Token: 0x04016BD0 RID: 93136
		private bool IsSubtitleFinishDelay;

		// Token: 0x04016BD1 RID: 93137
		private bool IsAudioFinishDelay;

		// Token: 0x04016BD2 RID: 93138
		private bool IsInSubtitle;

		// Token: 0x04016BD3 RID: 93139
		private bool IsInOption;

		// Token: 0x04016BD4 RID: 93140
		private bool IsHang;

		// Token: 0x04016BD5 RID: 93141
		private bool HasBindActionGamepad;

		// Token: 0x04016BD6 RID: 93142
		private bool HasBindActionOther;

		// Token: 0x04016BD7 RID: 93143
		private bool PauseByControlEntityOption;

		// Token: 0x04016BD8 RID: 93144
		private int CurrentSequenceSubtitleId = -1;

		// Token: 0x04016BD9 RID: 93145
		private bool IsControlEntityHudVisible = true;

		// Token: 0x04016BDA RID: 93146
		[Nullable(2)]
		private EntitySequenceView EntitySequenceView;

		// Token: 0x04016BDB RID: 93147
		private int EntitySequenceAttachToken;

		// Token: 0x02009C24 RID: 39972
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x040309AF RID: 199087
			NpcName,
			// Token: 0x040309B0 RID: 199088
			NpcTitle,
			// Token: 0x040309B1 RID: 199089
			Content,
			// Token: 0x040309B2 RID: 199090
			LineItem,
			// Token: 0x040309B3 RID: 199091
			PlotItem,
			// Token: 0x040309B4 RID: 199092
			LeftPoint,
			// Token: 0x040309B5 RID: 199093
			RightPoint,
			// Token: 0x040309B6 RID: 199094
			CenterPoint,
			// Token: 0x040309B7 RID: 199095
			TextScrollView,
			// Token: 0x040309B8 RID: 199096
			OptionPanel,
			// Token: 0x040309B9 RID: 199097
			OptionLayout,
			// Token: 0x040309BA RID: 199098
			OptionItem,
			// Token: 0x040309BB RID: 199099
			OptionLimitBar
		}
	}
}
