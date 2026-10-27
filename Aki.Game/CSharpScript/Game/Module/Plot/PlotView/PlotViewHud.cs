using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005067 RID: 20583
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotViewHud : UiTickViewBase, ISimulatePlot
	{
		// Token: 0x06034B77 RID: 215927 RVA: 0x00C78D2D File Offset: 0x00C76F2D
		public void SimulateClickSubtitle()
		{
		}

		// Token: 0x06034B78 RID: 215928 RVA: 0x00C78D2F File Offset: 0x00C76F2F
		public void SimulateClickOption()
		{
		}

		// Token: 0x17008035 RID: 32821
		// (get) Token: 0x06034B79 RID: 215929 RVA: 0x00C78D31 File Offset: 0x00C76F31
		[Nullable(2)]
		public ITalkItem CurrentSubtitle
		{
			[NullableContext(2)]
			get
			{
				return this.CommonLogic.CurrentContent;
			}
		}

		// Token: 0x06034B7A RID: 215930 RVA: 0x00C78D3E File Offset: 0x00C76F3E
		public PlotViewHud(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034B7B RID: 215931 RVA: 0x00C78D58 File Offset: 0x00C76F58
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

		// Token: 0x06034B7C RID: 215932 RVA: 0x00C78F34 File Offset: 0x00C77134
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

		// Token: 0x06034B7D RID: 215933 RVA: 0x00C79010 File Offset: 0x00C77210
		protected override UniTask OnBeforeStartAsync()
		{
			PlotViewHud.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PlotViewHud.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B7E RID: 215934 RVA: 0x00C79054 File Offset: 0x00C77254
		private UniTask OpenEntitySequenceViewAsync()
		{
			PlotViewHud.<OpenEntitySequenceViewAsync>d__26 <OpenEntitySequenceViewAsync>d__;
			<OpenEntitySequenceViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenEntitySequenceViewAsync>d__.<>4__this = this;
			<OpenEntitySequenceViewAsync>d__.<>1__state = -1;
			<OpenEntitySequenceViewAsync>d__.<>t__builder.Start<PlotViewHud.<OpenEntitySequenceViewAsync>d__26>(ref <OpenEntitySequenceViewAsync>d__);
			return <OpenEntitySequenceViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B7F RID: 215935 RVA: 0x00C79098 File Offset: 0x00C77298
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

		// Token: 0x06034B80 RID: 215936 RVA: 0x00C790D3 File Offset: 0x00C772D3
		private void HandleSubtitleAnimFinished()
		{
			if (this.IsControlEntitySequenceBridge())
			{
				return;
			}
			this.DelayHandleSubtitleActions();
		}

		// Token: 0x06034B81 RID: 215937 RVA: 0x00C790E4 File Offset: 0x00C772E4
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

		// Token: 0x06034B82 RID: 215938 RVA: 0x00C79150 File Offset: 0x00C77350
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

		// Token: 0x06034B83 RID: 215939 RVA: 0x00C791A7 File Offset: 0x00C773A7
		private void TrySubmitSubtitle()
		{
			if (!this.IsSubtitleFinishDelay || !this.IsAudioFinishDelay || this.IsControlEntitySequenceBridge())
			{
				return;
			}
			this.HandleSubtitleActions();
		}

		// Token: 0x06034B84 RID: 215940 RVA: 0x00C791C8 File Offset: 0x00C773C8
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

		// Token: 0x06034B85 RID: 215941 RVA: 0x00C79219 File Offset: 0x00C77419
		private void RemoveDelayTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.DelayTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimer);
			}
			this.DelayTimer = null;
		}

		// Token: 0x06034B86 RID: 215942 RVA: 0x00C79245 File Offset: 0x00C77445
		private void RemoveAudioEndDelayTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.AudioEndDelayTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AudioEndDelayTimer);
			}
			this.AudioEndDelayTimer = null;
		}

		// Token: 0x06034B87 RID: 215943 RVA: 0x00C79274 File Offset: 0x00C77474
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PlotViewHud.<OnPlayingCloseSequenceAsync>d__35 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PlotViewHud.<OnPlayingCloseSequenceAsync>d__35>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B88 RID: 215944 RVA: 0x00C792B8 File Offset: 0x00C774B8
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

		// Token: 0x06034B89 RID: 215945 RVA: 0x00C79400 File Offset: 0x00C77600
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

		// Token: 0x06034B8A RID: 215946 RVA: 0x00C79545 File Offset: 0x00C77745
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

		// Token: 0x06034B8B RID: 215947 RVA: 0x00C79584 File Offset: 0x00C77784
		private UniTask RefreshEntitySequenceParentAsync()
		{
			PlotViewHud.<RefreshEntitySequenceParentAsync>d__39 <RefreshEntitySequenceParentAsync>d__;
			<RefreshEntitySequenceParentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEntitySequenceParentAsync>d__.<>4__this = this;
			<RefreshEntitySequenceParentAsync>d__.<>1__state = -1;
			<RefreshEntitySequenceParentAsync>d__.<>t__builder.Start<PlotViewHud.<RefreshEntitySequenceParentAsync>d__39>(ref <RefreshEntitySequenceParentAsync>d__);
			return <RefreshEntitySequenceParentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B8C RID: 215948 RVA: 0x00C795C7 File Offset: 0x00C777C7
		private void ShowOptions()
		{
			this.IsInOption = true;
			this.CommonLogic.ShowOptions();
			this.BindInput();
		}

		// Token: 0x06034B8D RID: 215949 RVA: 0x00C795E1 File Offset: 0x00C777E1
		private void ClearOptions()
		{
			this.IsInOption = false;
			this.CommonLogic.ClearOptions();
			this.UnbindInput();
		}

		// Token: 0x06034B8E RID: 215950 RVA: 0x00C795FC File Offset: 0x00C777FC
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

		// Token: 0x06034B8F RID: 215951 RVA: 0x00C79637 File Offset: 0x00C77837
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

		// Token: 0x06034B90 RID: 215952 RVA: 0x00C79675 File Offset: 0x00C77875
		protected virtual void OnPlotContentUpdated(string text)
		{
		}

		// Token: 0x06034B91 RID: 215953 RVA: 0x00C79677 File Offset: 0x00C77877
		private void HandlePortraitVisible(SetHeadIconVisible headIconInfo, Action callback)
		{
			this.CommonLogic.HandlePortraitVisible(this.RootItem, headIconInfo, callback);
		}

		// Token: 0x06034B92 RID: 215954 RVA: 0x00C7968C File Offset: 0x00C7788C
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

		// Token: 0x06034B93 RID: 215955 RVA: 0x00C796D9 File Offset: 0x00C778D9
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

		// Token: 0x06034B94 RID: 215956 RVA: 0x00C79710 File Offset: 0x00C77910
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

		// Token: 0x06034B95 RID: 215957 RVA: 0x00C7978F File Offset: 0x00C7798F
		private void HandlePlotOptionSelected(int inOptionIndex)
		{
			if (!this.IsControlEntitySequenceBridge())
			{
				return;
			}
			this.ClearPlotSubtitle();
			this.SetControlEntityHudVisible(false);
		}

		// Token: 0x06034B96 RID: 215958 RVA: 0x00C797A7 File Offset: 0x00C779A7
		private void HandleSubSequenceStop()
		{
			if (!this.IsControlEntitySequenceBridge())
			{
				return;
			}
			this.ClearPlotSubtitle();
			this.SetControlEntityHudVisible(false);
		}

		// Token: 0x06034B97 RID: 215959 RVA: 0x00C797BF File Offset: 0x00C779BF
		private void OnHang(bool isHang = false)
		{
			this.OnHang(isHang, true);
		}

		// Token: 0x06034B98 RID: 215960 RVA: 0x00C797CC File Offset: 0x00C779CC
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

		// Token: 0x06034B99 RID: 215961 RVA: 0x00C7983C File Offset: 0x00C77A3C
		protected override void OnAfterPlayStartSequence()
		{
			this.AttachView();
		}

		// Token: 0x06034B9A RID: 215962 RVA: 0x00C79844 File Offset: 0x00C77A44
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, true);
			PlotModel instance = PlotModel.Instance;
			this.OnHang(instance != null && instance.HangViewHud, false);
			this.SetEnableTranslucent(PlotModel.Instance.TranslucentHud);
			this.IsControlEntityHudVisible = true;
		}

		// Token: 0x06034B9B RID: 215963 RVA: 0x00C7989C File Offset: 0x00C77A9C
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, false);
			this.OnHang(true, false);
			this.IsControlEntityHudVisible = false;
		}

		// Token: 0x06034B9C RID: 215964 RVA: 0x00C798CC File Offset: 0x00C77ACC
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

		// Token: 0x06034B9D RID: 215965 RVA: 0x00C7993B File Offset: 0x00C77B3B
		private bool IsControlEntitySequenceBridge()
		{
			return PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.ControlEntity;
		}

		// Token: 0x06034B9E RID: 215966 RVA: 0x00C79954 File Offset: 0x00C77B54
		private bool CheckHasSubtitleOptions(ITalkItem subtitle)
		{
			if (subtitle.Type.GetValueOrDefault() != ETalkItemType.SystemOption)
			{
				List<ITalkOption> options = subtitle.Options;
				return ((options != null) ? options.Count : 0) > 0;
			}
			return true;
		}

		// Token: 0x06034B9F RID: 215967 RVA: 0x00C79989 File Offset: 0x00C77B89
		private void PauseSequenceForControlEntityOption()
		{
			if (this.PauseByControlEntityOption)
			{
				return;
			}
			this.PauseByControlEntityOption = true;
			SequenceController.Instance.PauseSequence("ControlEntityHudOption");
		}

		// Token: 0x06034BA0 RID: 215968 RVA: 0x00C799AC File Offset: 0x00C77BAC
		private void ResumeSequenceForControlEntityOption()
		{
			if (!this.PauseByControlEntityOption)
			{
				return;
			}
			this.PauseByControlEntityOption = false;
			SequenceController.Instance.ResumeSequence("ControlEntityHudOption", null);
		}

		// Token: 0x06034BA1 RID: 215969 RVA: 0x00C799E4 File Offset: 0x00C77BE4
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

		// Token: 0x06034BA2 RID: 215970 RVA: 0x00C79A60 File Offset: 0x00C77C60
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

		// Token: 0x06034BA3 RID: 215971 RVA: 0x00C79B2C File Offset: 0x00C77D2C
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

		// Token: 0x06034BA4 RID: 215972 RVA: 0x00C79B88 File Offset: 0x00C77D88
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

		// Token: 0x06034BA5 RID: 215973 RVA: 0x00C79C26 File Offset: 0x00C77E26
		private void UpdateUiParam(UiParam param)
		{
			this.OpenParam = param;
			this.AttachView();
			this.SetTextWidth();
			this.SetPlotPosition();
		}

		// Token: 0x06034BA6 RID: 215974 RVA: 0x00C79C41 File Offset: 0x00C77E41
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

		// Token: 0x06034BA7 RID: 215975 RVA: 0x00C79C80 File Offset: 0x00C77E80
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

		// Token: 0x06034BA8 RID: 215976 RVA: 0x00C79D07 File Offset: 0x00C77F07
		private void PauseOptions()
		{
			if (!this.IsInOption)
			{
				return;
			}
			this.CommonLogic.MuteTimeLimitedOption = true;
			this.UnbindInput();
		}

		// Token: 0x06034BA9 RID: 215977 RVA: 0x00C79D24 File Offset: 0x00C77F24
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

		// Token: 0x06034BAA RID: 215978 RVA: 0x00C79D54 File Offset: 0x00C77F54
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

		// Token: 0x06034BAB RID: 215979 RVA: 0x00C79DB8 File Offset: 0x00C77FB8
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

		// Token: 0x06034BAC RID: 215980 RVA: 0x00C79E08 File Offset: 0x00C78008
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

		// Token: 0x06034BAD RID: 215981 RVA: 0x00C79F3F File Offset: 0x00C7813F
		private void SelectedOne(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			this.SelectedOption(0);
		}

		// Token: 0x06034BAE RID: 215982 RVA: 0x00C79F48 File Offset: 0x00C78148
		private void SelectedTwo(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			this.SelectedOption(1);
		}

		// Token: 0x06034BAF RID: 215983 RVA: 0x00C79F54 File Offset: 0x00C78154
		private void SelectedOption(int index)
		{
			if (this.CommonLogic.Options == null)
			{
				return;
			}
			this.CommonLogic.Options.First((PlotOptionItem item) => item.OptionIndex == index).OptionClick(new bool?(true));
		}

		// Token: 0x06034BB0 RID: 215984 RVA: 0x00C79FA3 File Offset: 0x00C781A3
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

		// Token: 0x06034BB1 RID: 215985 RVA: 0x00C79FD3 File Offset: 0x00C781D3
		protected override void OnTick(float delta)
		{
			this.CommonLogic.OnTick(delta);
		}

		// Token: 0x0401C1A0 RID: 115104
		private const float TRANSLUCENT_ALPHA = 0.6f;

		// Token: 0x0401C1A1 RID: 115105
		private const string CONTROL_ENTITY_OPTION_PAUSE = "ControlEntityHudOption";

		// Token: 0x0401C1A2 RID: 115106
		private PlotTextCommonLogic CommonLogic;

		// Token: 0x0401C1A3 RID: 115107
		[Nullable(2)]
		private TimerHandle DelayTimer;

		// Token: 0x0401C1A4 RID: 115108
		[Nullable(2)]
		private TimerHandle AudioEndDelayTimer;

		// Token: 0x0401C1A5 RID: 115109
		private bool IsSubtitleFinishDelay;

		// Token: 0x0401C1A6 RID: 115110
		private bool IsAudioFinishDelay;

		// Token: 0x0401C1A7 RID: 115111
		private bool IsInSubtitle;

		// Token: 0x0401C1A8 RID: 115112
		private bool IsInOption;

		// Token: 0x0401C1A9 RID: 115113
		private bool IsHang;

		// Token: 0x0401C1AA RID: 115114
		private bool HasBindActionGamepad;

		// Token: 0x0401C1AB RID: 115115
		private bool HasBindActionOther;

		// Token: 0x0401C1AC RID: 115116
		private bool PauseByControlEntityOption;

		// Token: 0x0401C1AD RID: 115117
		private int CurrentSequenceSubtitleId = -1;

		// Token: 0x0401C1AE RID: 115118
		private bool IsControlEntityHudVisible = true;

		// Token: 0x0401C1AF RID: 115119
		[Nullable(2)]
		private EntitySequenceView EntitySequenceView;

		// Token: 0x0401C1B0 RID: 115120
		private int EntitySequenceAttachToken;

		// Token: 0x0200B1EA RID: 45546
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x04035F5A RID: 221018
			NpcName,
			// Token: 0x04035F5B RID: 221019
			NpcTitle,
			// Token: 0x04035F5C RID: 221020
			Content,
			// Token: 0x04035F5D RID: 221021
			LineItem,
			// Token: 0x04035F5E RID: 221022
			PlotItem,
			// Token: 0x04035F5F RID: 221023
			LeftPoint,
			// Token: 0x04035F60 RID: 221024
			RightPoint,
			// Token: 0x04035F61 RID: 221025
			CenterPoint,
			// Token: 0x04035F62 RID: 221026
			TextScrollView,
			// Token: 0x04035F63 RID: 221027
			OptionPanel,
			// Token: 0x04035F64 RID: 221028
			OptionLayout,
			// Token: 0x04035F65 RID: 221029
			OptionItem,
			// Token: 0x04035F66 RID: 221030
			OptionLimitBar
		}
	}
}
