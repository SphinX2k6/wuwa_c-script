using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.Manufacture.Compose.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02005674 RID: 22132
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeRootView : UiViewBase
	{
		// Token: 0x06038505 RID: 230661 RVA: 0x00D5BBB7 File Offset: 0x00D59DB7
		public ComposeRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038506 RID: 230662 RVA: 0x00D5BBE4 File Offset: 0x00D59DE4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.ShowComposeLevelView));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038507 RID: 230663 RVA: 0x00D5BE1C File Offset: 0x00D5A01C
		protected override UniTask OnBeforeStartAsync()
		{
			ComposeRootView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposeRootView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038508 RID: 230664 RVA: 0x00D5BE60 File Offset: 0x00D5A060
		protected override void OnStart()
		{
			this.FilterComponent = new FilterEntrance<IBaseItemData>(base.GetItem(3), new TUpdateDataListFunction<IBaseItemData>(this.OnFilterSortRefresh));
			this.FilterComponent.SetActive(false);
			this.SortComponent = new SortEntrance<IBaseItemData>(base.GetItem(10), new TUpdateDataListFunction<IBaseItemData>(this.OnFilterSortRefresh));
			this.SortComponent.SetSortToggleState(true);
			this.ComposeItemScrollView = new LoopScrollView<ComposeMediumItemGrid, IBaseItemData>(base.GetLoopScrollViewComponent(2), base.GetLoopScrollViewComponent(2).TemplateGrid, new Func<ComposeMediumItemGrid>(this.OnGridProxyCreate), false);
			LguiUtil.Instance.SetLocalText(base.GetText(9), "ComposeLevelButtonText", Array.Empty<object>());
			this.StartLevelComponent = new StarLevelComponent(base.GetHorizontalLayout(11));
			CommonManager.Instance.SetCurrentSystem(CSharpScript.Game.Module.Manufacture.Common.ESystemType.ComposeSystem);
			ComposeController.Instance.RegisterCurrentInteractionEntity();
			this.WaitUiBlendInCameraSequenceFinished = new CustomPromise();
			ComposeModel.Instance.CurrentInteractCreatureDataLongId = InteractionModel.Instance.InteractCreatureDataLongId;
			EventSystem.Instance.Add(EEventName.OnExecuteUiCameraSequenceEvent, new Action<string>(this.OnExecuteUiCameraSequenceEvent));
			if (InteractionModel.Instance.CurrentInteractEntityId == null)
			{
				global::Log.Instance.Info(ELogModule.Compose, ELogAuthor.WZ, "[LevelEventOpenSystem] 打开合成界面时找不到交互对象，直接关闭界面", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.CloseMe(null);
			}
		}

		// Token: 0x06038509 RID: 230665 RVA: 0x00D5BFAB File Offset: 0x00D5A1AB
		protected override void OnBeforeShow()
		{
			this.ShowComposeMainView();
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			childPopView.PopItem.SetMaskResponsibleState(false);
		}

		// Token: 0x0603850A RID: 230666 RVA: 0x00D5BFCC File Offset: 0x00D5A1CC
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			ComposeRootView.<OnBeforeShowAsyncImplement>d__23 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<ComposeRootView.<OnBeforeShowAsyncImplement>d__23>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603850B RID: 230667 RVA: 0x00D5C00F File Offset: 0x00D5A20F
		protected override void OnAfterShow()
		{
			this.RefreshPopItemVisible();
			this.WaitUiBlendInCameraSequenceFinished = null;
		}

		// Token: 0x0603850C RID: 230668 RVA: 0x00D5C020 File Offset: 0x00D5A220
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnExecuteUiCameraSequenceEvent, new Action<string>(this.OnExecuteUiCameraSequenceEvent));
			this.MainTypeHorizontal.ClearChildren();
			this.ComposeItemScrollView.ClearGridProxies();
			this.StartLevelComponent.Clear();
			ComposeModel instance = ComposeModel.Instance;
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.ComposeLevelKey);
			ComposeController.Instance.PlayLeaveCompositeAudio();
			ComposeController.Instance.ClearCurrentInteractionEntityDisplay();
			instance.ClearComposeRoleItemDataList();
			instance.CurrentComposeRoleId = 0;
			instance.CurrentComposeListType = EComposeListType.ReagentProduction;
			RedDotController.Instance.UnBindRedDot(ERedDotName.ComposeReagentProduction);
			this.WaitUiBlendInCameraSequenceFinished = null;
		}

		// Token: 0x0603850D RID: 230669 RVA: 0x00D5C0B8 File Offset: 0x00D5A2B8
		private void RefreshPopItemVisible()
		{
			CommonPopViewBase popItem = this.ChildPopView.PopItem;
			if (popItem == null)
			{
				return;
			}
			if (this.IsEnterSequenceCompleted)
			{
				return;
			}
			bool flag = !UiCameraAnimationManager.Instance.IsPlayingBlendInSequence();
			if (popItem.GetActive() == flag)
			{
				return;
			}
			popItem.SetActive(flag);
		}

		// Token: 0x0603850E RID: 230670 RVA: 0x00D5C100 File Offset: 0x00D5A300
		private void CheckShowTab()
		{
			ComposeModel.Instance.CurrentComposeViewType = EComposeViewType.ComposeMainType;
			List<MainTypeItem> layoutItemList = this.MainTypeHorizontal.GetLayoutItemList();
			bool flag = false;
			EComposeListType currentComposeListType = ComposeModel.Instance.CurrentComposeListType;
			for (int i = 0; i < layoutItemList.Count; i++)
			{
				MainTypeItem mainTypeItem = layoutItemList[i];
				EComposeListType mainType = mainTypeItem.GetMainType();
				if (this.GetItemListByType(currentComposeListType).Count > 0 || i == layoutItemList.Count - 1)
				{
					mainTypeItem.SetUiActive(true);
					if (currentComposeListType == mainType && !flag)
					{
						this.MainTypeHorizontal.SelectGridProxy(mainTypeItem.GridIndex, false);
						flag = true;
					}
				}
				else
				{
					mainTypeItem.SetUiActive(false);
				}
			}
		}

		// Token: 0x0603850F RID: 230671 RVA: 0x00D5C1A0 File Offset: 0x00D5A3A0
		private void ShowComposeMainView()
		{
			this.CheckShowTab();
			this.KeepSelectOnSort = true;
			this.SortComponent.SetResultDataDirty();
			this.SortComponent.UpdateData(EFilterSortGroupId.ReagentList, this.GetItemList(), Array.Empty<object>());
			int uniqueIdByGroupId = this.SortComponent.GetUniqueIdByGroupId(EFilterSortGroupId.ReagentList);
			this.FilterComponent.SetSortUniqueId(uniqueIdByGroupId);
			this.FilterComponent.SetActive(true);
			this.FilterComponent.UpdateData(EFilterSortGroupId.ReagentList, this.GetItemList(), Array.Empty<object>());
			int uniqueIdByGroupId2 = this.FilterComponent.GetUniqueIdByGroupId(EFilterSortGroupId.ReagentList);
			this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId2);
			this.KeepSelectOnSort = false;
			this.SwitchComposeLevelShow();
			this.OnShowRedDot();
			this.SwitchMainTitleByListType();
			int value = CommonManager.Instance.GetComposeMaxLevel().Value;
			int value2 = CommonManager.Instance.GetCurrentRewardLevel().Value;
			this.StartLevelComponent.ShowLevel(value2, value);
			this.RefreshLimitTime();
		}

		// Token: 0x06038510 RID: 230672 RVA: 0x00D5C28C File Offset: 0x00D5A48C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.GetComposeData, new Action(this.ShowComposeMainView));
			EventSystem.Instance.Add(EEventName.OpenHelpRole, new Action<int>(this.ShowComposeRoleView));
			EventSystem.Instance.Add(EEventName.ComposeSuccess, new Action(this.OnCookResponse));
			EventSystem.Instance.Add(EEventName.ComposeFail, new Action(this.OnCookResponse));
			EventSystem.Instance.Add(EEventName.OnBeginPlayCompositeWorkingDisplay, new Action(this.OnBeginPlayCompositeWorkingDisplay));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			this.RefreshTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnSecondTimerRefresh), 1000f, 1f, null, null, true);
		}

		// Token: 0x06038511 RID: 230673 RVA: 0x00D5C368 File Offset: 0x00D5A568
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.GetComposeData, new Action(this.ShowComposeMainView));
			EventSystem.Instance.Remove(EEventName.ComposeSuccess, new Action(this.OnCookResponse));
			EventSystem.Instance.Remove(EEventName.ComposeFail, new Action(this.OnCookResponse));
			EventSystem.Instance.Remove(EEventName.OpenHelpRole, new Action<int>(this.ShowComposeRoleView));
			EventSystem.Instance.Remove(EEventName.OnBeginPlayCompositeWorkingDisplay, new Action(this.OnBeginPlayCompositeWorkingDisplay));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			if (this.RefreshTimer != null && TimerSystem.Instance.Has(this.RefreshTimer))
			{
				TimerSystem.Instance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x06038512 RID: 230674 RVA: 0x00D5C44C File Offset: 0x00D5A64C
		private void OnSecondTimerRefresh(float delta)
		{
			this.RefreshLimitTime();
			this.ComposeDetailsInfoView.OnSecondTimerRefresh();
			if (this.CheckIsLimitCountRefresh())
			{
				this.<OnSecondTimerRefresh>g__Temp|31_0().Forget();
				return;
			}
			if (this.CheckHasItemTimeOut())
			{
				this.<OnSecondTimerRefresh>g__Temp|31_1().Forget();
			}
		}

		// Token: 0x06038513 RID: 230675 RVA: 0x00D5C488 File Offset: 0x00D5A688
		private void RefreshLimitTime()
		{
			string refreshLimitTime = ComposeModel.Instance.GetRefreshLimitTime();
			if (refreshLimitTime != null)
			{
				base.GetItem(12).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "RefreshTime", new <>z__ReadOnlySingleElementList<object>(refreshLimitTime));
				return;
			}
			base.GetItem(12).SetUIActive(false);
		}

		// Token: 0x06038514 RID: 230676 RVA: 0x00D5C4DD File Offset: 0x00D5A6DD
		private bool CheckIsLimitCountRefresh()
		{
			return ComposeModel.Instance.GetRefreshLimitTimeValue() <= 0.0;
		}

		// Token: 0x06038515 RID: 230677 RVA: 0x00D5C4F8 File Offset: 0x00D5A6F8
		private bool CheckHasItemTimeOut()
		{
			List<IBaseItemData> itemList = this.GetItemList();
			if (itemList == null)
			{
				return false;
			}
			foreach (IBaseItemData baseItemData in itemList)
			{
				if (baseItemData.ExistEndTime > 0.0 && !TimeUtil.Instance.IsInTimeSpan(baseItemData.ExistStartTime, baseItemData.ExistEndTime))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06038516 RID: 230678 RVA: 0x00D5C57C File Offset: 0x00D5A77C
		private void OnBeginPlayCompositeWorkingDisplay()
		{
			this.<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0().Forget();
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x06038517 RID: 230679 RVA: 0x00D5C59C File Offset: 0x00D5A79C
		private void OnExecuteUiCameraSequenceEvent(string sequenceEventName)
		{
			if (sequenceEventName != "OnBlackScreen")
			{
				return;
			}
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PlayLevelSequenceByName("BlackScreenShow", false);
			}
			if (this.WaitUiBlendInCameraSequenceFinished != null && this.WaitUiBlendInCameraSequenceFinished.IsPending)
			{
				this.WaitUiBlendInCameraSequenceFinished.SetResult();
			}
			ComposeController.Instance.PlayCompositeEnterDisplay(new Action(this.OnPlayEnterDisplayFinished));
			this.IsEnterSequenceCompleted = true;
		}

		// Token: 0x06038518 RID: 230680 RVA: 0x00D5C60B File Offset: 0x00D5A80B
		private void OnPlayEnterDisplayFinished()
		{
			if (!UiManager.Instance.IsViewShow(EUiViewName.ComposeCarryOnView))
			{
				return;
			}
			ComposeController.Instance.PlayCompositeLoopDisplay();
		}

		// Token: 0x06038519 RID: 230681 RVA: 0x00D5C62C File Offset: 0x00D5A82C
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.CompositeRewardView)
			{
				return;
			}
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.SetActive(true);
			}
			IUiPopFrameInterface childPopView2 = this.ChildPopView;
			if (childPopView2 != null)
			{
				childPopView2.PlayLevelSequenceByName("Start", false);
			}
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
			PlayFlow composeSuccessFlow = ComposeModel.Instance.ComposeSuccessFlow;
			ComposeController.Instance.PlayCompositeFlow(composeSuccessFlow);
		}

		// Token: 0x0603851A RID: 230682 RVA: 0x00D5C69C File Offset: 0x00D5A89C
		private void SetSelectedComposeItem(bool isNeedScroll = false)
		{
			int num = 0;
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
				num = this.SelectedReagentProductionIndex;
				this.ComposeDetailsInfoView.RefreshTips(this.ReagentProductionDataList[num]);
				break;
			case EComposeListType.Structure:
				num = this.SelectedStructureIndex;
				this.ComposeDetailsInfoView.RefreshTips(this.StructureDataList[num]);
				break;
			case EComposeListType.Purification:
				num = this.SelectedPurificationIndex;
				this.ComposeDetailsInfoView.RefreshTips(this.PurificationDataList[num]);
				break;
			}
			this.ComposeItemScrollView.DeselectCurrentGridProxy(false);
			if (isNeedScroll)
			{
				this.ComposeItemScrollView.ScrollToGridIndex(num, true);
			}
			this.ComposeItemScrollView.SelectGridProxy(num, false);
		}

		// Token: 0x0603851B RID: 230683 RVA: 0x00D5C753 File Offset: 0x00D5A953
		private ComposeMediumItemGrid OnGridProxyCreate()
		{
			ComposeMediumItemGrid composeMediumItemGrid = new ComposeMediumItemGrid();
			composeMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnComposeItemClick));
			return composeMediumItemGrid;
		}

		// Token: 0x0603851C RID: 230684 RVA: 0x00D5C76C File Offset: 0x00D5A96C
		private void OnComposeItemClick(MediumItemGridExtendCallback callbackParameter)
		{
			IBaseItemData baseItemData = callbackParameter.Data as IBaseItemData;
			int gridIndex = 0;
			this.ComposeItemScrollView.DeselectCurrentGridProxy(false);
			switch (baseItemData.MainType)
			{
			case EComposeListType.ReagentProduction:
			{
				IReagentProductionData item = baseItemData as IReagentProductionData;
				this.SelectedReagentProductionIndex = this.ReagentProductionDataList.IndexOf(item);
				gridIndex = this.SelectedReagentProductionIndex;
				break;
			}
			case EComposeListType.Structure:
			{
				IStructureData item2 = baseItemData as IStructureData;
				this.SelectedStructureIndex = this.StructureDataList.IndexOf(item2);
				gridIndex = this.SelectedStructureIndex;
				break;
			}
			case EComposeListType.Purification:
			{
				IPurificationData item3 = baseItemData as IPurificationData;
				this.SelectedPurificationIndex = this.PurificationDataList.IndexOf(item3);
				gridIndex = this.SelectedPurificationIndex;
				break;
			}
			}
			if (!this.ComposeItemScrollView.IsGridDisplaying(gridIndex))
			{
				return;
			}
			if (baseItemData.IsNew)
			{
				NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, baseItemData.ConfigId);
				baseItemData.IsNew = false;
			}
			this.ComposeItemScrollView.SelectGridProxy(gridIndex, false);
			this.ComposeItemScrollView.RefreshGridProxy(gridIndex);
			this.ComposeDetailsInfoView.RefreshTips(baseItemData);
		}

		// Token: 0x0603851D RID: 230685 RVA: 0x00D5C86E File Offset: 0x00D5AA6E
		private MainTypeItem InitMainTypeItem()
		{
			MainTypeItem mainTypeItem = new MainTypeItem();
			mainTypeItem.SetMainTypeCallback(new Action<int>(this.OnSwitchCallback));
			return mainTypeItem;
		}

		// Token: 0x0603851E RID: 230686 RVA: 0x00D5C888 File Offset: 0x00D5AA88
		private void OnSwitchCallback(int mainType)
		{
			if (ComposeModel.Instance.CurrentComposeListType == (EComposeListType)mainType)
			{
				return;
			}
			switch (mainType)
			{
			case 1:
				ComposeModel.Instance.CurrentComposeListType = EComposeListType.ReagentProduction;
				EventSystem.Instance.Emit(EEventName.SwitchComposeType);
				this.SwitchComposeLevelShow();
				this.SwitchComposeItemScroll();
				this.SwitchMainTitleByListType();
				return;
			case 2:
				ComposeModel.Instance.CurrentComposeListType = EComposeListType.Structure;
				EventSystem.Instance.Emit(EEventName.SwitchComposeType);
				this.SwitchComposeLevelShow();
				this.SwitchComposeItemScroll();
				this.SwitchMainTitleByListType();
				return;
			case 3:
				ComposeModel.Instance.CurrentComposeListType = EComposeListType.Purification;
				EventSystem.Instance.Emit(EEventName.SwitchComposeType);
				this.SwitchComposeLevelShow();
				this.SwitchComposeItemScroll();
				this.SwitchMainTitleByListType();
				return;
			default:
				return;
			}
		}

		// Token: 0x0603851F RID: 230687 RVA: 0x00D5C941 File Offset: 0x00D5AB41
		private void SwitchComposeLevelShow()
		{
			(base.GetButton(5).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(ComposeModel.Instance.CurrentComposeListType == EComposeListType.ReagentProduction);
			this.SetComposeLevelSprite();
		}

		// Token: 0x06038520 RID: 230688 RVA: 0x00D5C974 File Offset: 0x00D5AB74
		private void SetComposeLevelSprite()
		{
			if (ComposeModel.Instance.CurrentComposeListType == EComposeListType.ReagentProduction)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ReagentProductionLevel");
				this.SetSpriteByPath(resourcePath, base.GetSprite(6), false, null, null);
			}
		}

		// Token: 0x06038521 RID: 230689 RVA: 0x00D5C9B8 File Offset: 0x00D5ABB8
		private void SwitchComposeItemScroll()
		{
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
			{
				this.FilterComponent.UpdateData(EFilterSortGroupId.ReagentList, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId = this.FilterComponent.GetUniqueIdByGroupId(EFilterSortGroupId.ReagentList);
				this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId);
				this.SortComponent.SetResultDataDirty();
				this.SortComponent.UpdateData(EFilterSortGroupId.ReagentList, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId2 = this.SortComponent.GetUniqueIdByGroupId(EFilterSortGroupId.ReagentList);
				this.FilterComponent.SetSortUniqueId(uniqueIdByGroupId2);
				return;
			}
			case EComposeListType.Structure:
			{
				this.FilterComponent.UpdateData(EFilterSortGroupId.StructureList, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId3 = this.FilterComponent.GetUniqueIdByGroupId(EFilterSortGroupId.StructureList);
				this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId3);
				this.SortComponent.SetResultDataDirty();
				this.SortComponent.UpdateData(EFilterSortGroupId.StructureList, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId4 = this.SortComponent.GetUniqueIdByGroupId(EFilterSortGroupId.StructureList);
				this.FilterComponent.SetSortUniqueId(uniqueIdByGroupId4);
				return;
			}
			case EComposeListType.Purification:
				this.SortComponent.SetResultDataDirty();
				this.SortComponent.UpdateData(EFilterSortGroupId.PurificationList, this.GetItemList(), Array.Empty<object>());
				return;
			default:
				return;
			}
		}

		// Token: 0x06038522 RID: 230690 RVA: 0x00D5CAEC File Offset: 0x00D5ACEC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IBaseItemData> GetItemListByType(EComposeListType type)
		{
			List<IBaseItemData> result;
			switch (type)
			{
			case EComposeListType.ReagentProduction:
			{
				List<IReagentProductionData> reagentProductionDataList = ComposeModel.Instance.GetReagentProductionDataList();
				List<IBaseItemData> list;
				if (reagentProductionDataList == null)
				{
					list = null;
				}
				else
				{
					list = reagentProductionDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IReagentProductionData v) => v);
				}
				result = list;
				break;
			}
			case EComposeListType.Structure:
			{
				List<IStructureData> structureDataList = ComposeModel.Instance.GetStructureDataList();
				List<IBaseItemData> list2;
				if (structureDataList == null)
				{
					list2 = null;
				}
				else
				{
					list2 = structureDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IStructureData v) => v);
				}
				result = list2;
				break;
			}
			case EComposeListType.Purification:
			{
				List<IPurificationData> purificationDataList = ComposeModel.Instance.GetPurificationDataList();
				List<IBaseItemData> list3;
				if (purificationDataList == null)
				{
					list3 = null;
				}
				else
				{
					list3 = purificationDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IPurificationData v) => v);
				}
				result = list3;
				break;
			}
			default:
				return null;
			}
			return result;
		}

		// Token: 0x06038523 RID: 230691 RVA: 0x00D5CBBF File Offset: 0x00D5ADBF
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IBaseItemData> GetItemList()
		{
			return this.GetItemListByType(ComposeModel.Instance.CurrentComposeListType);
		}

		// Token: 0x06038524 RID: 230692 RVA: 0x00D5CBD4 File Offset: 0x00D5ADD4
		private void OnFilterSortRefresh(List<IBaseItemData> list, bool arg1, EFilterSortType arg2)
		{
			List<IBaseItemData> list2 = list.ConvertAll<IBaseItemData>(([Nullable(1)] IBaseItemData v) => v).FindAll((IBaseItemData value) => value.ExistStartTime <= 0.0 || TimeUtil.Instance.IsInTimeSpan(value.ExistStartTime, value.ExistEndTime));
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
				this.SelectedReagentProductionIndex = ((!this.KeepSelectOnSort) ? 0 : this.SelectedReagentProductionIndex);
				this.ReagentProductionDataList = list2.ConvertAll<IReagentProductionData>(([Nullable(1)] IBaseItemData v) => v as IReagentProductionData);
				break;
			case EComposeListType.Structure:
				this.SelectedStructureIndex = ((!this.KeepSelectOnSort) ? 0 : this.SelectedStructureIndex);
				this.StructureDataList = list2.ConvertAll<IStructureData>(([Nullable(1)] IBaseItemData v) => v as IStructureData);
				break;
			case EComposeListType.Purification:
				this.SelectedPurificationIndex = ((!this.KeepSelectOnSort) ? 0 : this.SelectedPurificationIndex);
				this.PurificationDataList = list2.ConvertAll<IPurificationData>(([Nullable(1)] IBaseItemData v) => v as IPurificationData);
				break;
			}
			this.ComposeItemScrollView.DeselectCurrentGridProxy(false);
			this.RefreshItemScrollView();
			if (list2.Count == 0)
			{
				base.GetItem(8).SetUIActive(true);
				this.ComposeDetailsInfoView.SetActive(false);
				return;
			}
			base.GetItem(8).SetUIActive(false);
			this.ComposeDetailsInfoView.SetActive(true);
			this.SetSelectedComposeItem(!this.KeepSelectOnSort);
		}

		// Token: 0x06038525 RID: 230693 RVA: 0x00D5CD78 File Offset: 0x00D5AF78
		private void OnCookResponse()
		{
			this.KeepSelectOnSort = true;
			this.SwitchComposeItemScroll();
			this.KeepSelectOnSort = false;
		}

		// Token: 0x06038526 RID: 230694 RVA: 0x00D5CD90 File Offset: 0x00D5AF90
		private void RefreshItemScrollView()
		{
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
				this.ComposeItemScrollView.RefreshByData(this.ReagentProductionDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IReagentProductionData v) => v), false, null, false);
				return;
			case EComposeListType.Structure:
				this.ComposeItemScrollView.RefreshByData(this.StructureDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IStructureData v) => v), false, null, false);
				return;
			case EComposeListType.Purification:
				this.ComposeItemScrollView.RefreshByData(this.PurificationDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IPurificationData v) => v), false, null, false);
				return;
			default:
				return;
			}
		}

		// Token: 0x06038527 RID: 230695 RVA: 0x00D5CE67 File Offset: 0x00D5B067
		private void OnShowRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.ComposeReagentProduction, base.GetItem(7), null, 0);
		}

		// Token: 0x06038528 RID: 230696 RVA: 0x00D5CE7E File Offset: 0x00D5B07E
		private void ShowComposeLevelView()
		{
			ComposeModel.Instance.CurrentComposeViewType = EComposeViewType.ComposeLevelType;
			UiManager.Instance.OpenView(EUiViewName.ComposeLevelView, null, null);
		}

		// Token: 0x06038529 RID: 230697 RVA: 0x00D5CE9C File Offset: 0x00D5B09C
		private void ShowComposeRoleView(int id)
		{
			ComposeModel.Instance.CurrentComposeViewType = EComposeViewType.ComposeRoleType;
			UiManager.Instance.OpenView(EUiViewName.ManufactureHelpRoleView, id, null);
		}

		// Token: 0x0603852A RID: 230698 RVA: 0x00D5CEC0 File Offset: 0x00D5B0C0
		private void SwitchMainTitleByListType()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.SetTitleVisible(true);
			}
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
			{
				IUiPopFrameInterface childPopView2 = this.ChildPopView;
				if (childPopView2 == null)
				{
					return;
				}
				childPopView2.PopItem.SetTitleText(TextConfig.Instance.GetTextContentIdById("ReagentProduction") ?? "");
				return;
			}
			case EComposeListType.Structure:
			{
				IUiPopFrameInterface childPopView3 = this.ChildPopView;
				if (childPopView3 == null)
				{
					return;
				}
				childPopView3.PopItem.SetTitleText(TextConfig.Instance.GetTextContentIdById("Structure") ?? "");
				return;
			}
			case EComposeListType.Purification:
			{
				IUiPopFrameInterface childPopView4 = this.ChildPopView;
				if (childPopView4 == null)
				{
					return;
				}
				childPopView4.PopItem.SetTitleText(TextConfig.Instance.GetTextContentIdById("Purification") ?? "");
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0603852B RID: 230699 RVA: 0x00D5CF90 File Offset: 0x00D5B190
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			LoopScrollView<ComposeMediumItemGrid, IBaseItemData> composeItemScrollView = this.ComposeItemScrollView;
			if (composeItemScrollView == null || !composeItemScrollView.DataInited)
			{
				return null;
			}
			int displayIndex = int.Parse(configParams[0]);
			UUIItem gridByDisplayIndex = this.ComposeItemScrollView.GetGridByDisplayIndex(displayIndex);
			if (gridByDisplayIndex != null)
			{
				return new UUIItem[]
				{
					gridByDisplayIndex,
					gridByDisplayIndex
				};
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.JT;
			string message = "合成界面聚焦引导的额外参数配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x0603852C RID: 230700 RVA: 0x00D5D008 File Offset: 0x00D5B208
		[CompilerGenerated]
		private UniTask <OnSecondTimerRefresh>g__Temp|31_0()
		{
			ComposeRootView.<<OnSecondTimerRefresh>g__Temp|31_0>d <<OnSecondTimerRefresh>g__Temp|31_0>d;
			<<OnSecondTimerRefresh>g__Temp|31_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnSecondTimerRefresh>g__Temp|31_0>d.<>4__this = this;
			<<OnSecondTimerRefresh>g__Temp|31_0>d.<>1__state = -1;
			<<OnSecondTimerRefresh>g__Temp|31_0>d.<>t__builder.Start<ComposeRootView.<<OnSecondTimerRefresh>g__Temp|31_0>d>(ref <<OnSecondTimerRefresh>g__Temp|31_0>d);
			return <<OnSecondTimerRefresh>g__Temp|31_0>d.<>t__builder.Task;
		}

		// Token: 0x0603852D RID: 230701 RVA: 0x00D5D04C File Offset: 0x00D5B24C
		[CompilerGenerated]
		private UniTask <OnSecondTimerRefresh>g__Temp|31_1()
		{
			ComposeRootView.<<OnSecondTimerRefresh>g__Temp|31_1>d <<OnSecondTimerRefresh>g__Temp|31_1>d;
			<<OnSecondTimerRefresh>g__Temp|31_1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnSecondTimerRefresh>g__Temp|31_1>d.<>4__this = this;
			<<OnSecondTimerRefresh>g__Temp|31_1>d.<>1__state = -1;
			<<OnSecondTimerRefresh>g__Temp|31_1>d.<>t__builder.Start<ComposeRootView.<<OnSecondTimerRefresh>g__Temp|31_1>d>(ref <<OnSecondTimerRefresh>g__Temp|31_1>d);
			return <<OnSecondTimerRefresh>g__Temp|31_1>d.<>t__builder.Task;
		}

		// Token: 0x0603852E RID: 230702 RVA: 0x00D5D090 File Offset: 0x00D5B290
		[CompilerGenerated]
		private UniTask <OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0()
		{
			ComposeRootView.<<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0>d <<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0>d;
			<<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0>d.<>4__this = this;
			<<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0>d.<>1__state = -1;
			<<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0>d.<>t__builder.Start<ComposeRootView.<<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0>d>(ref <<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0>d);
			return <<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0>d.<>t__builder.Task;
		}

		// Token: 0x0401D99D RID: 121245
		private const int TIMERGAP = 1000;

		// Token: 0x0401D99E RID: 121246
		private int SelectedReagentProductionIndex;

		// Token: 0x0401D99F RID: 121247
		private int SelectedStructureIndex;

		// Token: 0x0401D9A0 RID: 121248
		private int SelectedPurificationIndex;

		// Token: 0x0401D9A1 RID: 121249
		[Nullable(2)]
		private ComposeIngredientsView ComposeDetailsInfoView;

		// Token: 0x0401D9A2 RID: 121250
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MainTypeItem, EComposeListType> MainTypeHorizontal;

		// Token: 0x0401D9A3 RID: 121251
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ComposeMediumItemGrid, IBaseItemData> ComposeItemScrollView;

		// Token: 0x0401D9A4 RID: 121252
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterEntrance<IBaseItemData> FilterComponent;

		// Token: 0x0401D9A5 RID: 121253
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private SortEntrance<IBaseItemData> SortComponent;

		// Token: 0x0401D9A6 RID: 121254
		private List<IReagentProductionData> ReagentProductionDataList = new List<IReagentProductionData>();

		// Token: 0x0401D9A7 RID: 121255
		private List<IStructureData> StructureDataList = new List<IStructureData>();

		// Token: 0x0401D9A8 RID: 121256
		private List<IPurificationData> PurificationDataList = new List<IPurificationData>();

		// Token: 0x0401D9A9 RID: 121257
		[Nullable(2)]
		private StarLevelComponent StartLevelComponent;

		// Token: 0x0401D9AA RID: 121258
		private bool KeepSelectOnSort;

		// Token: 0x0401D9AB RID: 121259
		private bool IsEnterSequenceCompleted;

		// Token: 0x0401D9AC RID: 121260
		[Nullable(2)]
		private CustomPromise WaitUiBlendInCameraSequenceFinished;

		// Token: 0x0401D9AD RID: 121261
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x0200B838 RID: 47160
		[NullableContext(0)]
		private class EComposeRootDefine
		{
			// Token: 0x04037C13 RID: 228371
			public const int ComposeListTypeHorizontalLayout = 0;

			// Token: 0x04037C14 RID: 228372
			public const int ComposeListTypeHorizontalLayoutItem = 1;

			// Token: 0x04037C15 RID: 228373
			public const int ItemLoopScroll = 2;

			// Token: 0x04037C16 RID: 228374
			public const int FilterItem = 3;

			// Token: 0x04037C17 RID: 228375
			public const int IngredientDetail = 4;

			// Token: 0x04037C18 RID: 228376
			public const int ComposeLevelButton = 5;

			// Token: 0x04037C19 RID: 228377
			public const int ComposeLevelSprite = 6;

			// Token: 0x04037C1A RID: 228378
			public const int RedDotItem = 7;

			// Token: 0x04037C1B RID: 228379
			public const int NoItem = 8;

			// Token: 0x04037C1C RID: 228380
			public const int TxtConfirm = 9;

			// Token: 0x04037C1D RID: 228381
			public const int SortItem = 10;

			// Token: 0x04037C1E RID: 228382
			public const int PnlStar = 11;

			// Token: 0x04037C1F RID: 228383
			public const int PnlTime = 12;

			// Token: 0x04037C20 RID: 228384
			public const int TxtTime = 13;
		}
	}
}
