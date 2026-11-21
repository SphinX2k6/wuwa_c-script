using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200128A RID: 4746
[NullableContext(1)]
[Nullable(0)]
public class GuideFocusView : GuideBaseView
{
	// Token: 0x0600BBFE RID: 48126 RVA: 0x0037812B File Offset: 0x0037632B
	public GuideFocusView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BBFF RID: 48127 RVA: 0x00378162 File Offset: 0x00376362
	protected override void OnBeforeGuideBaseViewCreate()
	{
		this.Config = new GuideFocusNew?((GuideFocusNew)this.GuideStepInfo.ViewData.ViewConf);
		this.BindInputAfterSequence();
	}

	// Token: 0x0600BC00 RID: 48128 RVA: 0x0037818C File Offset: 0x0037638C
	protected override void OnGuideBaseViewStart()
	{
		base.GetRootItem().SetAlpha(0f);
		this.FindAttachmentTime = 4000f;
		if (this.Config.Value.ContentDirection == EGuideFocusTextDir.Down)
		{
			this.StartSequenceName = "StartManualUp";
		}
		else if (this.Config.Value.ContentDirection == EGuideFocusTextDir.Up)
		{
			this.StartSequenceName = "StartManualDown";
		}
		else if (this.Config.Value.ContentDirection == EGuideFocusTextDir.Left)
		{
			this.StartSequenceName = "StartManualRight";
		}
		else if (this.Config.Value.ContentDirection == EGuideFocusTextDir.Right)
		{
			this.StartSequenceName = "StartManualLeft";
		}
		if (this.StartSequenceName != null)
		{
			this.UiViewSequence.AddSequenceFinishEvent(this.StartSequenceName, new Action<string>(this.OnStartSequenceEnd), false);
		}
		if (this.Config != null && this.Config.GetValueOrDefault().HideWhenOtherPopViewOccur)
		{
			UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Pop);
			string guideFocusTargetViewName = GuideTestUtil.GetGuideFocusTargetViewName(this.Config.Value.ViewName, this.GuideStepInfo.Id);
			if (topView != null && topView.IsShowOrShowing)
			{
				string a = guideFocusTargetViewName;
				UiViewInfo viewInfo = topView.ViewInfo;
				EUiViewName? euiViewName = (viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null;
				if (a != ((euiViewName != null) ? euiViewName.GetValueOrDefault() : null) && !this.guidePopupIgnoreView.Contains(topView.ViewInfo.Name))
				{
					UiViewInfo viewInfo2 = topView.ViewInfo;
					this.OccurredOtherPopupViewName = ((viewInfo2 != null) ? new EUiViewName?(viewInfo2.Name) : null);
				}
			}
			EventSystem.Instance.Add<EUiViewName, UiViewBase>(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnOtherPopupViewDone));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnOtherPopupViewClose));
		}
	}

	// Token: 0x0600BC01 RID: 48129 RVA: 0x003783B2 File Offset: 0x003765B2
	protected override void OnGuideBaseViewAddEvent()
	{
		EventSystem.Instance.Add(EEventName.OnSkillButtonIndexRefresh, new Action(this.CheckSkillItem));
		EventSystem.Instance.Add<bool>(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
	}

	// Token: 0x0600BC02 RID: 48130 RVA: 0x003783EC File Offset: 0x003765EC
	protected override void OnGuideBaseViewRemoveEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnSkillButtonIndexRefresh, new Action(this.CheckSkillItem));
		EventSystem.Instance.Remove(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
	}

	// Token: 0x0600BC03 RID: 48131 RVA: 0x00378428 File Offset: 0x00376628
	protected override void OnGuideViewAfterShow()
	{
		this.RootItem.SetRaycastTarget(false);
		this.CheckAttachedItemVisible();
		this.BindInputAfterSequence();
		InputManager.Instance.SetShowCursor(this.Config.Value.ShowMouse, true);
	}

	// Token: 0x0600BC04 RID: 48132 RVA: 0x0037846C File Offset: 0x0037666C
	protected override void OnGuideBaseViewAfterHide()
	{
		EventSystem.Instance.Emit(EEventName.RefreshCursor);
		string[] inputEnums = this.Config.Value.InputEnums();
		base.UnbindInput(this.Config.Value.InputEnums(), inputEnums);
		EventSystem.Instance.Emit(EEventName.RefreshCursor);
	}

	// Token: 0x0600BC05 RID: 48133 RVA: 0x003784C8 File Offset: 0x003766C8
	protected override void OnGuideBaseViewDestroy()
	{
		if (this.FocusItem != null)
		{
			this.FocusItem.Destroy(null);
			this.FocusItem = null;
		}
		if (this.Config != null && this.Config.GetValueOrDefault().HideWhenOtherPopViewOccur)
		{
			EventSystem.Instance.Remove(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnOtherPopupViewDone));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnOtherPopupViewClose));
		}
	}

	// Token: 0x170012A1 RID: 4769
	// (get) Token: 0x0600BC06 RID: 48134 RVA: 0x00378544 File Offset: 0x00376744
	private bool IsSkillButtonGuide
	{
		get
		{
			return GuideTestUtil.GetGuideFocusTargetViewName(this.Config.Value.ViewName, this.GuideStepInfo.Id) == EUiViewName.BattleView && this.Config.Value.ExtraParam() != null && this.Config.Value.ExtraParam().Length != 0 && this.Config.Value.ExtraParam()[0] == "Skill";
		}
	}

	// Token: 0x0600BC07 RID: 48135 RVA: 0x003785D4 File Offset: 0x003767D4
	private void CheckSkillItem()
	{
		if (this.IsSkillButtonGuide)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.BattleView);
			UUIItem[] array = (viewByName != null) ? viewByName.GetGuideUiItemAndUiItemForShowEx(this.Config.Value.ExtraParam()) : null;
			if (array != null)
			{
				UUIItem uuiitem = array[0];
				GuideStepInfo guideStepInfo = this.GuideStepInfo;
				object obj;
				if (guideStepInfo == null)
				{
					obj = null;
				}
				else
				{
					GuideStepViewData viewData = guideStepInfo.ViewData;
					obj = ((viewData != null) ? viewData.GetAttachedUiItem() : null);
				}
				if (uuiitem == obj)
				{
					return;
				}
			}
			this.GuideStepInfo.SwitchState(EGuideStepState.Break);
		}
	}

	// Token: 0x0600BC08 RID: 48136 RVA: 0x0037864C File Offset: 0x0037684C
	protected override void OnGuideBaseViewTick(float delta)
	{
		this.CheckAttachedItemVisible();
		if (base.IsShow && this.Config.Value.ShowMouse)
		{
			InputManager.Instance.SetShowCursor(true, true);
		}
		GuideFocusItem focusItem = this.FocusItem;
		if (focusItem != null)
		{
			focusItem.OnTick(delta);
		}
		this.ShowInner();
		if (this.IsAttachViewReady && !this.IsAttachItemsReady)
		{
			this.FindAttachmentTime -= delta;
			if (this.FindAttachmentTime < 0f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.JT;
				string message = "[Guide][引导界面打开后5秒后目标没有显示出来,触发保底]";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("步骤Id", this.GuideStepInfo.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.CloseMe(null);
			}
		}
	}

	// Token: 0x0600BC09 RID: 48137 RVA: 0x00378708 File Offset: 0x00376908
	protected override void OnDurationChange(float remainDuration)
	{
		GuideFocusItem focusItem = this.FocusItem;
		if (focusItem == null)
		{
			return;
		}
		focusItem.OnDurationChange(remainDuration);
	}

	// Token: 0x0600BC0A RID: 48138 RVA: 0x0037871C File Offset: 0x0037691C
	private bool GetAttachedItemVisible()
	{
		this.IsAttachViewReady = false;
		UiPanelBase attachedView = this.GuideStepInfo.ViewData.GetAttachedView();
		if (attachedView == null)
		{
			return false;
		}
		if (attachedView.GetRootActor() == null)
		{
			return false;
		}
		if (!attachedView.IsUiActiveInHierarchy())
		{
			return false;
		}
		if (!((this.Config != null && this.Config.GetValueOrDefault().CheckShowByIsShowOrShowing) ? attachedView.IsShowOrShowing : attachedView.IsShow))
		{
			return false;
		}
		if (base.HasConflictView())
		{
			return false;
		}
		if (this.HasBlockingPopup())
		{
			return false;
		}
		if (!base.CheckTickCondition())
		{
			return false;
		}
		if (this.OccurredOtherPopupViewName != null)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(this.OccurredOtherPopupViewName.Value);
			if (viewByName != null && viewByName.IsShowOrShowing)
			{
				return false;
			}
		}
		this.IsAttachViewReady = true;
		if (!this.GuideStepInfo.ViewData.IsMultiAttach)
		{
			UUIItem attachedUiItemForShow = this.GuideStepInfo.ViewData.GetAttachedUiItemForShow();
			return ObjectUtils.IsValid(attachedUiItemForShow) && attachedUiItemForShow.IsUIActiveInHierarchy();
		}
		List<UUIItem> multiAttachItems = this.GuideStepInfo.ViewData.GetMultiAttachItems();
		if (multiAttachItems == null || multiAttachItems.Count == 0)
		{
			return false;
		}
		foreach (UUIItem uuiitem in multiAttachItems)
		{
			if (!ObjectUtils.IsValid(uuiitem) || !uuiitem.IsUIActiveInHierarchy())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BC0B RID: 48139 RVA: 0x00378890 File Offset: 0x00376A90
	private bool HasBlockingPopup()
	{
		if (this.Config == null)
		{
			return true;
		}
		string guideFocusTargetViewName = GuideTestUtil.GetGuideFocusTargetViewName(this.Config.Value.ViewName, this.GuideStepInfo.Id);
		UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Pop);
		return topView != null && topView.IsShowOrShowing && (topView.ViewInfo.Name != guideFocusTargetViewName && !this.guidePopupIgnoreView.Contains(topView.ViewInfo.Name));
	}

	// Token: 0x0600BC0C RID: 48140 RVA: 0x00378924 File Offset: 0x00376B24
	private void CheckAttachedItemVisible()
	{
		bool attachedItemVisible = this.GetAttachedItemVisible();
		this.SetActive(attachedItemVisible);
		if (this.IsAttachItemsReady == attachedItemVisible)
		{
			return;
		}
		this.IsAttachItemsReady = attachedItemVisible;
		if (attachedItemVisible)
		{
			base.GetRootItem().SetAlpha(0f);
			this.InitFocusItem();
		}
	}

	// Token: 0x0600BC0D RID: 48141 RVA: 0x0037896C File Offset: 0x00376B6C
	private void OnStartSequenceEnd(string _)
	{
		this.UiViewSequence.PlaySequence("AutoLoopManual", false, null);
	}

	// Token: 0x0600BC0E RID: 48142 RVA: 0x00378994 File Offset: 0x00376B94
	private void InitFocusItem()
	{
		UUIItem attachedUiItem = this.GuideStepInfo.ViewData.GetAttachedUiItem();
		if (attachedUiItem == null || !attachedUiItem.IsValid())
		{
			return;
		}
		UUIItem attachedUiItemForShow = this.GuideStepInfo.ViewData.GetAttachedUiItemForShow();
		this.FocusItem = this.CreateFocusItem(attachedUiItem, attachedUiItemForShow);
	}

	// Token: 0x0600BC0F RID: 48143 RVA: 0x003789E4 File Offset: 0x00376BE4
	private void ShowInner()
	{
		if (!base.GetActive())
		{
			return;
		}
		if (!this.ReadyToShow)
		{
			return;
		}
		this.ReadyToShow = false;
		base.GetRootItem().SetAlpha(1f);
		if (this.StartSequenceName != null)
		{
			this.UiViewSequence.PlaySequence(this.StartSequenceName, false, null);
			return;
		}
		this.OnStartSequenceEnd("");
	}

	// Token: 0x0600BC10 RID: 48144 RVA: 0x00378A4C File Offset: 0x00376C4C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BC11 RID: 48145 RVA: 0x00378A94 File Offset: 0x00376C94
	[NullableContext(2)]
	public GuideStepInfo GetGuideStepInfo()
	{
		return this.GuideStepInfo;
	}

	// Token: 0x0600BC12 RID: 48146 RVA: 0x00378A9C File Offset: 0x00376C9C
	public GuideFocusNew? GetFocusViewConf()
	{
		return this.Config;
	}

	// Token: 0x0600BC13 RID: 48147 RVA: 0x00378AA4 File Offset: 0x00376CA4
	public void BindInputAfterSequence()
	{
		List<string> list = new List<string>(this.Config.Value.InputEnumsIter());
		base.BindInput(list, list, new TInputHandle<float>(this.ProcessInput));
	}

	// Token: 0x0600BC14 RID: 48148 RVA: 0x00378AE0 File Offset: 0x00376CE0
	private void ProcessInput([Nullable(2)] string name, float value, InputIdentification _)
	{
		if (this.RootItem != null && !this.RootItem.bIsUIActive)
		{
			return;
		}
		if (name != null)
		{
			this.CombineInputMap[name] = value;
			if (!base.IsAllCombineInputPass())
			{
				return;
			}
		}
		string[] inputEnums = this.Config.Value.InputEnums();
		base.UnbindInput(this.Config.Value.InputEnums(), inputEnums);
		base.DoCloseByFinished();
	}

	// Token: 0x0600BC15 RID: 48149 RVA: 0x00378B50 File Offset: 0x00376D50
	protected override void OnGuideViewCloseWhenFinish()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null && uiViewSequence.HasSequenceNameInPlaying("Start"))
		{
			this.UiViewSequence.StopPrevSequence(false, true);
		}
		GuideFocusItem focusItem = this.FocusItem;
		if (focusItem == null)
		{
			return;
		}
		focusItem.OnBaseViewCloseWhenFinish();
	}

	// Token: 0x0600BC16 RID: 48150 RVA: 0x00378B88 File Offset: 0x00376D88
	private GuideFocusItem CreateFocusItem(UUIItem attachedItem, UUIItem attachedItemForShow)
	{
		UUIItem item = base.GetItem(0);
		item.SetActive(false, false);
		GuideFocusItem guideFocusItem = new GuideFocusItem(attachedItem, attachedItemForShow, this);
		guideFocusItem.Init(item);
		return guideFocusItem;
	}

	// Token: 0x0600BC17 RID: 48151 RVA: 0x00378BB4 File Offset: 0x00376DB4
	private void OnOtherPopupViewDone(EUiViewName viewName, UiViewBase view)
	{
		UiViewInfo viewInfo = view.ViewInfo;
		if (viewInfo == null || viewInfo.GetContainerLayerType() != ELayerType.Pop)
		{
			return;
		}
		if (GuideTestUtil.GetGuideFocusTargetViewName(this.Config.Value.ViewName, this.GuideStepInfo.Id) == viewName || this.guidePopupIgnoreView.Contains(viewName))
		{
			return;
		}
		this.OccurredOtherPopupViewName = new EUiViewName?(viewName);
	}

	// Token: 0x0600BC18 RID: 48152 RVA: 0x00378C28 File Offset: 0x00376E28
	private void OnOtherPopupViewClose(EUiViewName viewName, int viewId)
	{
		if (this.OccurredOtherPopupViewName == viewName)
		{
			this.OccurredOtherPopupViewName = null;
		}
	}

	// Token: 0x0600BC19 RID: 48153 RVA: 0x00378C65 File Offset: 0x00376E65
	private void OnPreparePhotoScreenShot(bool bShow)
	{
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(bShow);
	}

	// Token: 0x04006C2C RID: 27692
	private readonly HashSet<EUiViewName> guidePopupIgnoreView = new HashSet<EUiViewName>
	{
		EUiViewName.FightPhotoFocusView,
		EUiViewName.RoleTowerExitButtonView
	};

	// Token: 0x04006C2D RID: 27693
	public GuideFocusNew? Config;

	// Token: 0x04006C2E RID: 27694
	public bool IsAttachItemsReady;

	// Token: 0x04006C2F RID: 27695
	private bool IsAttachViewReady;

	// Token: 0x04006C30 RID: 27696
	public bool ReadyToShow;

	// Token: 0x04006C31 RID: 27697
	private float FindAttachmentTime = 4000f;

	// Token: 0x04006C32 RID: 27698
	[Nullable(2)]
	private GuideFocusItem FocusItem;

	// Token: 0x04006C33 RID: 27699
	[Nullable(2)]
	private string StartSequenceName;

	// Token: 0x04006C34 RID: 27700
	private EUiViewName? OccurredOtherPopupViewName;

	// Token: 0x02007525 RID: 29989
	[NullableContext(0)]
	private enum EGuideFocusView
	{
		// Token: 0x04026123 RID: 155939
		FocusItem
	}
}
