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
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x0200464A RID: 17994
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeRootView : UiViewBase
	{
		// Token: 0x0602D402 RID: 185346 RVA: 0x00CA9CB7 File Offset: 0x00CA7EB7
		public ComposeRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D403 RID: 185347 RVA: 0x00CA9CE4 File Offset: 0x00CA7EE4
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

		// Token: 0x0602D404 RID: 185348 RVA: 0x00CA9F1C File Offset: 0x00CA811C
		protected override UniTask OnBeforeStartAsync()
		{
			ComposeRootView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposeRootView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D405 RID: 185349 RVA: 0x00CA9F60 File Offset: 0x00CA8160
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

		// Token: 0x0602D406 RID: 185350 RVA: 0x00CAA0AB File Offset: 0x00CA82AB
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

		// Token: 0x0602D407 RID: 185351 RVA: 0x00CAA0CC File Offset: 0x00CA82CC
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			ComposeRootView.<OnBeforeShowAsyncImplement>d__23 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<ComposeRootView.<OnBeforeShowAsyncImplement>d__23>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602D408 RID: 185352 RVA: 0x00CAA10F File Offset: 0x00CA830F
		protected override void OnAfterShow()
		{
			this.RefreshPopItemVisible();
			this.WaitUiBlendInCameraSequenceFinished = null;
		}

		// Token: 0x0602D409 RID: 185353 RVA: 0x00CAA120 File Offset: 0x00CA8320
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

		// Token: 0x0602D40A RID: 185354 RVA: 0x00CAA1B8 File Offset: 0x00CA83B8
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
			bool flag = !UiCameraModel.Instance.IsPlayingBlendInSequence();
			if (popItem.GetActive() == flag)
			{
				return;
			}
			popItem.SetActive(flag);
		}

		// Token: 0x0602D40B RID: 185355 RVA: 0x00CAA200 File Offset: 0x00CA8400
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

		// Token: 0x0602D40C RID: 185356 RVA: 0x00CAA2A0 File Offset: 0x00CA84A0
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

		// Token: 0x0602D40D RID: 185357 RVA: 0x00CAA38C File Offset: 0x00CA858C
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

		// Token: 0x0602D40E RID: 185358 RVA: 0x00CAA468 File Offset: 0x00CA8668
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

		// Token: 0x0602D40F RID: 185359 RVA: 0x00CAA54C File Offset: 0x00CA874C
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

		// Token: 0x0602D410 RID: 185360 RVA: 0x00CAA588 File Offset: 0x00CA8788
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

		// Token: 0x0602D411 RID: 185361 RVA: 0x00CAA5DD File Offset: 0x00CA87DD
		private bool CheckIsLimitCountRefresh()
		{
			return ComposeModel.Instance.GetRefreshLimitTimeValue() <= 0.0;
		}

		// Token: 0x0602D412 RID: 185362 RVA: 0x00CAA5F8 File Offset: 0x00CA87F8
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

		// Token: 0x0602D413 RID: 185363 RVA: 0x00CAA67C File Offset: 0x00CA887C
		private void OnBeginPlayCompositeWorkingDisplay()
		{
			this.<OnBeginPlayCompositeWorkingDisplay>g__Temp|35_0().Forget();
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, true);
		}

		// Token: 0x0602D414 RID: 185364 RVA: 0x00CAA69C File Offset: 0x00CA889C
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

		// Token: 0x0602D415 RID: 185365 RVA: 0x00CAA70B File Offset: 0x00CA890B
		private void OnPlayEnterDisplayFinished()
		{
			if (!UiManager.Instance.IsViewShow(EUiViewName.ComposeCarryOnView))
			{
				return;
			}
			ComposeController.Instance.PlayCompositeLoopDisplay();
		}

		// Token: 0x0602D416 RID: 185366 RVA: 0x00CAA72C File Offset: 0x00CA892C
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

		// Token: 0x0602D417 RID: 185367 RVA: 0x00CAA79C File Offset: 0x00CA899C
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

		// Token: 0x0602D418 RID: 185368 RVA: 0x00CAA853 File Offset: 0x00CA8A53
		private ComposeMediumItemGrid OnGridProxyCreate()
		{
			ComposeMediumItemGrid composeMediumItemGrid = new ComposeMediumItemGrid();
			composeMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnComposeItemClick));
			return composeMediumItemGrid;
		}

		// Token: 0x0602D419 RID: 185369 RVA: 0x00CAA86C File Offset: 0x00CA8A6C
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

		// Token: 0x0602D41A RID: 185370 RVA: 0x00CAA96E File Offset: 0x00CA8B6E
		private MainTypeItem InitMainTypeItem()
		{
			MainTypeItem mainTypeItem = new MainTypeItem();
			mainTypeItem.SetMainTypeCallback(new Action<int>(this.OnSwitchCallback));
			return mainTypeItem;
		}

		// Token: 0x0602D41B RID: 185371 RVA: 0x00CAA988 File Offset: 0x00CA8B88
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

		// Token: 0x0602D41C RID: 185372 RVA: 0x00CAAA41 File Offset: 0x00CA8C41
		private void SwitchComposeLevelShow()
		{
			(base.GetButton(5).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(ComposeModel.Instance.CurrentComposeListType == EComposeListType.ReagentProduction);
			this.SetComposeLevelSprite();
		}

		// Token: 0x0602D41D RID: 185373 RVA: 0x00CAAA74 File Offset: 0x00CA8C74
		private void SetComposeLevelSprite()
		{
			if (ComposeModel.Instance.CurrentComposeListType == EComposeListType.ReagentProduction)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ReagentProductionLevel");
				this.SetSpriteByPath(resourcePath, base.GetSprite(6), false, null, null);
			}
		}

		// Token: 0x0602D41E RID: 185374 RVA: 0x00CAAAB8 File Offset: 0x00CA8CB8
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

		// Token: 0x0602D41F RID: 185375 RVA: 0x00CAABEC File Offset: 0x00CA8DEC
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

		// Token: 0x0602D420 RID: 185376 RVA: 0x00CAACBF File Offset: 0x00CA8EBF
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IBaseItemData> GetItemList()
		{
			return this.GetItemListByType(ComposeModel.Instance.CurrentComposeListType);
		}

		// Token: 0x0602D421 RID: 185377 RVA: 0x00CAACD4 File Offset: 0x00CA8ED4
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

		// Token: 0x0602D422 RID: 185378 RVA: 0x00CAAE78 File Offset: 0x00CA9078
		private void OnCookResponse()
		{
			this.KeepSelectOnSort = true;
			this.SwitchComposeItemScroll();
			this.KeepSelectOnSort = false;
		}

		// Token: 0x0602D423 RID: 185379 RVA: 0x00CAAE90 File Offset: 0x00CA9090
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

		// Token: 0x0602D424 RID: 185380 RVA: 0x00CAAF67 File Offset: 0x00CA9167
		private void OnShowRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.ComposeReagentProduction, base.GetItem(7), null, 0);
		}

		// Token: 0x0602D425 RID: 185381 RVA: 0x00CAAF7E File Offset: 0x00CA917E
		private void ShowComposeLevelView()
		{
			ComposeModel.Instance.CurrentComposeViewType = EComposeViewType.ComposeLevelType;
			UiManager.Instance.OpenView(EUiViewName.ComposeLevelView, null, null);
		}

		// Token: 0x0602D426 RID: 185382 RVA: 0x00CAAF9C File Offset: 0x00CA919C
		private void ShowComposeRoleView(int id)
		{
			ComposeModel.Instance.CurrentComposeViewType = EComposeViewType.ComposeRoleType;
			UiManager.Instance.OpenView(EUiViewName.ManufactureHelpRoleView, id, null);
		}

		// Token: 0x0602D427 RID: 185383 RVA: 0x00CAAFC0 File Offset: 0x00CA91C0
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

		// Token: 0x0602D428 RID: 185384 RVA: 0x00CAB090 File Offset: 0x00CA9290
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

		// Token: 0x0602D429 RID: 185385 RVA: 0x00CAB108 File Offset: 0x00CA9308
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

		// Token: 0x0602D42A RID: 185386 RVA: 0x00CAB14C File Offset: 0x00CA934C
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

		// Token: 0x0602D42B RID: 185387 RVA: 0x00CAB190 File Offset: 0x00CA9390
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

		// Token: 0x04018428 RID: 99368
		private const int TIMERGAP = 1000;

		// Token: 0x04018429 RID: 99369
		private int SelectedReagentProductionIndex;

		// Token: 0x0401842A RID: 99370
		private int SelectedStructureIndex;

		// Token: 0x0401842B RID: 99371
		private int SelectedPurificationIndex;

		// Token: 0x0401842C RID: 99372
		[Nullable(2)]
		private ComposeIngredientsView ComposeDetailsInfoView;

		// Token: 0x0401842D RID: 99373
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MainTypeItem, EComposeListType> MainTypeHorizontal;

		// Token: 0x0401842E RID: 99374
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ComposeMediumItemGrid, IBaseItemData> ComposeItemScrollView;

		// Token: 0x0401842F RID: 99375
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterEntrance<IBaseItemData> FilterComponent;

		// Token: 0x04018430 RID: 99376
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private SortEntrance<IBaseItemData> SortComponent;

		// Token: 0x04018431 RID: 99377
		private List<IReagentProductionData> ReagentProductionDataList = new List<IReagentProductionData>();

		// Token: 0x04018432 RID: 99378
		private List<IStructureData> StructureDataList = new List<IStructureData>();

		// Token: 0x04018433 RID: 99379
		private List<IPurificationData> PurificationDataList = new List<IPurificationData>();

		// Token: 0x04018434 RID: 99380
		[Nullable(2)]
		private StarLevelComponent StartLevelComponent;

		// Token: 0x04018435 RID: 99381
		private bool KeepSelectOnSort;

		// Token: 0x04018436 RID: 99382
		private bool IsEnterSequenceCompleted;

		// Token: 0x04018437 RID: 99383
		[Nullable(2)]
		private CustomPromise WaitUiBlendInCameraSequenceFinished;

		// Token: 0x04018438 RID: 99384
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x0200A260 RID: 41568
		[NullableContext(0)]
		private class EComposeRootDefine
		{
			// Token: 0x04032631 RID: 206385
			public const int ComposeListTypeHorizontalLayout = 0;

			// Token: 0x04032632 RID: 206386
			public const int ComposeListTypeHorizontalLayoutItem = 1;

			// Token: 0x04032633 RID: 206387
			public const int ItemLoopScroll = 2;

			// Token: 0x04032634 RID: 206388
			public const int FilterItem = 3;

			// Token: 0x04032635 RID: 206389
			public const int IngredientDetail = 4;

			// Token: 0x04032636 RID: 206390
			public const int ComposeLevelButton = 5;

			// Token: 0x04032637 RID: 206391
			public const int ComposeLevelSprite = 6;

			// Token: 0x04032638 RID: 206392
			public const int RedDotItem = 7;

			// Token: 0x04032639 RID: 206393
			public const int NoItem = 8;

			// Token: 0x0403263A RID: 206394
			public const int TxtConfirm = 9;

			// Token: 0x0403263B RID: 206395
			public const int SortItem = 10;

			// Token: 0x0403263C RID: 206396
			public const int PnlStar = 11;

			// Token: 0x0403263D RID: 206397
			public const int PnlTime = 12;

			// Token: 0x0403263E RID: 206398
			public const int TxtTime = 13;
		}
	}
}
