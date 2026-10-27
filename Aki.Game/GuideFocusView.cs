using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DC8 RID: 7624
[NullableContext(1)]
[Nullable(0)]
public class GuideFocusView : GuideBaseView
{
	// Token: 0x0600E7DF RID: 59359 RVA: 0x0036C497 File Offset: 0x0036A697
	public GuideFocusView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E7E0 RID: 59360 RVA: 0x0036C4C2 File Offset: 0x0036A6C2
	protected override void OnBeforeGuideBaseViewCreate()
	{
		this.Config = new GuideFocusNew?((GuideFocusNew)this.GuideStepInfo.ViewData.ViewConf);
		this.BindInputAfterSequence();
	}

	// Token: 0x0600E7E1 RID: 59361 RVA: 0x0036C4EC File Offset: 0x0036A6EC
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
			if (topView != null)
			{
				string a = guideFocusTargetViewName;
				UiViewInfo viewInfo = topView.ViewInfo;
				EUiViewName? euiViewName = (viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null;
				if (a != ((euiViewName != null) ? euiViewName.GetValueOrDefault() : null))
				{
					UiViewInfo viewInfo2 = topView.ViewInfo;
					this.OccurredOtherPopupViewName = ((viewInfo2 != null) ? new EUiViewName?(viewInfo2.Name) : null);
				}
			}
			EventSystem.Instance.Add<EUiViewName, UiViewBase>(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnOtherPopupViewDone));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnOtherPopupViewClose));
		}
	}

	// Token: 0x0600E7E2 RID: 59362 RVA: 0x0036C6EF File Offset: 0x0036A8EF
	protected override void OnGuideBaseViewAddEvent()
	{
		EventSystem.Instance.Add(EEventName.OnSkillButtonIndexRefresh, new Action(this.CheckSkillItem));
		EventSystem.Instance.Add<bool>(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
	}

	// Token: 0x0600E7E3 RID: 59363 RVA: 0x0036C729 File Offset: 0x0036A929
	protected override void OnGuideBaseViewRemoveEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnSkillButtonIndexRefresh, new Action(this.CheckSkillItem));
		EventSystem.Instance.Remove(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
	}

	// Token: 0x0600E7E4 RID: 59364 RVA: 0x0036C764 File Offset: 0x0036A964
	protected override void OnGuideViewAfterShow()
	{
		this.RootItem.SetRaycastTarget(false);
		this.CheckAttachedItemVisible();
		this.BindInputAfterSequence();
		InputManager.Instance.SetShowCursor(this.Config.Value.ShowMouse, true);
	}

	// Token: 0x0600E7E5 RID: 59365 RVA: 0x0036C7A8 File Offset: 0x0036A9A8
	protected override void OnGuideBaseViewAfterHide()
	{
		EventSystem.Instance.Emit(EEventName.RefreshCursor);
		string[] inputEnums = this.Config.Value.InputEnums();
		base.UnbindInput(this.Config.Value.InputEnums(), inputEnums);
		EventSystem.Instance.Emit(EEventName.RefreshCursor);
	}

	// Token: 0x0600E7E6 RID: 59366 RVA: 0x0036C804 File Offset: 0x0036AA04
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

	// Token: 0x17001277 RID: 4727
	// (get) Token: 0x0600E7E7 RID: 59367 RVA: 0x0036C880 File Offset: 0x0036AA80
	private bool IsSkillButtonGuide
	{
		get
		{
			return GuideTestUtil.GetGuideFocusTargetViewName(this.Config.Value.ViewName, this.GuideStepInfo.Id) == EUiViewName.BattleView && this.Config.Value.ExtraParam() != null && this.Config.Value.ExtraParam().Length != 0 && this.Config.Value.ExtraParam()[0] == "Skill";
		}
	}

	// Token: 0x0600E7E8 RID: 59368 RVA: 0x0036C910 File Offset: 0x0036AB10
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

	// Token: 0x0600E7E9 RID: 59369 RVA: 0x0036C988 File Offset: 0x0036AB88
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

	// Token: 0x0600E7EA RID: 59370 RVA: 0x0036CA44 File Offset: 0x0036AC44
	protected override void OnDurationChange(float remainDuration)
	{
		GuideFocusItem focusItem = this.FocusItem;
		if (focusItem == null)
		{
			return;
		}
		focusItem.OnDurationChange(remainDuration);
	}

	// Token: 0x0600E7EB RID: 59371 RVA: 0x0036CA58 File Offset: 0x0036AC58
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
			return false;
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

	// Token: 0x0600E7EC RID: 59372 RVA: 0x0036CBAC File Offset: 0x0036ADAC
	private bool HasBlockingPopup()
	{
		if (this.Config == null)
		{
			return true;
		}
		string guideFocusTargetViewName = GuideTestUtil.GetGuideFocusTargetViewName(this.Config.Value.ViewName, this.GuideStepInfo.Id);
		UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Pop);
		return topView != null && topView.ViewInfo.Name != guideFocusTargetViewName && !this.guidePopupIgnoreView.Contains(topView.ViewInfo.Name);
	}

	// Token: 0x0600E7ED RID: 59373 RVA: 0x0036CC30 File Offset: 0x0036AE30
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

	// Token: 0x0600E7EE RID: 59374 RVA: 0x0036CC78 File Offset: 0x0036AE78
	private void OnStartSequenceEnd(string _)
	{
		this.UiViewSequence.PlaySequence("AutoLoopManual", false, null);
	}

	// Token: 0x0600E7EF RID: 59375 RVA: 0x0036CCA0 File Offset: 0x0036AEA0
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

	// Token: 0x0600E7F0 RID: 59376 RVA: 0x0036CCF0 File Offset: 0x0036AEF0
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

	// Token: 0x0600E7F1 RID: 59377 RVA: 0x0036CD58 File Offset: 0x0036AF58
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

	// Token: 0x0600E7F2 RID: 59378 RVA: 0x0036CDA0 File Offset: 0x0036AFA0
	[NullableContext(2)]
	public GuideStepInfo GetGuideStepInfo()
	{
		return this.GuideStepInfo;
	}

	// Token: 0x0600E7F3 RID: 59379 RVA: 0x0036CDA8 File Offset: 0x0036AFA8
	public GuideFocusNew? GetFocusViewConf()
	{
		return this.Config;
	}

	// Token: 0x0600E7F4 RID: 59380 RVA: 0x0036CDB0 File Offset: 0x0036AFB0
	public void BindInputAfterSequence()
	{
		List<string> list = new List<string>(this.Config.Value.InputEnumsIter());
		base.BindInput(list, list, new TInputHandle<float>(this.ProcessInput));
	}

	// Token: 0x0600E7F5 RID: 59381 RVA: 0x0036CDEC File Offset: 0x0036AFEC
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

	// Token: 0x0600E7F6 RID: 59382 RVA: 0x0036CE5C File Offset: 0x0036B05C
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

	// Token: 0x0600E7F7 RID: 59383 RVA: 0x0036CE94 File Offset: 0x0036B094
	private GuideFocusItem CreateFocusItem(UUIItem attachedItem, UUIItem attachedItemForShow)
	{
		UUIItem item = base.GetItem(0);
		item.SetActive(false, false);
		GuideFocusItem guideFocusItem = new GuideFocusItem(attachedItem, attachedItemForShow, this);
		guideFocusItem.Init(item);
		return guideFocusItem;
	}

	// Token: 0x0600E7F8 RID: 59384 RVA: 0x0036CEC0 File Offset: 0x0036B0C0
	private void OnOtherPopupViewDone(EUiViewName viewName, UiViewBase view)
	{
		UiViewInfo viewInfo = view.ViewInfo;
		if (viewInfo == null || viewInfo.GetContainerLayerType() != ELayerType.Pop)
		{
			return;
		}
		if (GuideTestUtil.GetGuideFocusTargetViewName(this.Config.Value.ViewName, this.GuideStepInfo.Id) == viewName)
		{
			return;
		}
		this.OccurredOtherPopupViewName = new EUiViewName?(viewName);
	}

	// Token: 0x0600E7F9 RID: 59385 RVA: 0x0036CF28 File Offset: 0x0036B128
	private void OnOtherPopupViewClose(EUiViewName viewName, int viewId)
	{
		if (this.OccurredOtherPopupViewName == viewName)
		{
			this.OccurredOtherPopupViewName = null;
		}
	}

	// Token: 0x0600E7FA RID: 59386 RVA: 0x0036CF65 File Offset: 0x0036B165
	private void OnPreparePhotoScreenShot(bool bShow)
	{
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(bShow);
	}

	// Token: 0x04006B4B RID: 27467
	private readonly HashSet<EUiViewName> guidePopupIgnoreView = new HashSet<EUiViewName>
	{
		EUiViewName.FightPhotoFocusView
	};

	// Token: 0x04006B4C RID: 27468
	public GuideFocusNew? Config;

	// Token: 0x04006B4D RID: 27469
	public bool IsAttachItemsReady;

	// Token: 0x04006B4E RID: 27470
	private bool IsAttachViewReady;

	// Token: 0x04006B4F RID: 27471
	public bool ReadyToShow;

	// Token: 0x04006B50 RID: 27472
	private float FindAttachmentTime = 4000f;

	// Token: 0x04006B51 RID: 27473
	[Nullable(2)]
	private GuideFocusItem FocusItem;

	// Token: 0x04006B52 RID: 27474
	[Nullable(2)]
	private string StartSequenceName;

	// Token: 0x04006B53 RID: 27475
	private EUiViewName? OccurredOtherPopupViewName;

	// Token: 0x0200839D RID: 33693
	[NullableContext(0)]
	private enum EGuideFocusView
	{
		// Token: 0x0402ADFD RID: 175613
		FocusItem
	}
}
