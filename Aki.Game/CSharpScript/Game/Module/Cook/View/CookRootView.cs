using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004B03 RID: 19203
	[NullableContext(1)]
	[Nullable(0)]
	public class CookRootView : UiViewBase
	{
		// Token: 0x06030062 RID: 196706 RVA: 0x00D65745 File Offset: 0x00D63945
		public CookRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030063 RID: 196707 RVA: 0x00D65764 File Offset: 0x00D63964
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
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnShowCookLevelView));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030064 RID: 196708 RVA: 0x00D6599C File Offset: 0x00D63B9C
		protected override UniTask OnBeforeStartAsync()
		{
			CookRootView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CookRootView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030065 RID: 196709 RVA: 0x00D659E0 File Offset: 0x00D63BE0
		protected override void OnStart()
		{
			this.CookItemScrollView = new LoopScrollView<CookMediumItemGrid, ICookItemData>(base.GetLoopScrollViewComponent(2), base.GetLoopScrollViewComponent(2).TemplateGrid, new Func<CookMediumItemGrid>(this.OnGridProxyCreate), false);
			this.FilterComponent = new FilterEntrance<ICookItemData>(base.GetItem(3), new TUpdateDataListFunction<ICookItemData>(this.OnFilterRefresh));
			this.SortComponent = new SortEntrance<ICookItemData>(base.GetItem(10), new TUpdateDataListFunction<ICookItemData>(this.OnSortRefresh));
			this.SortComponent.SetSortToggleState(true);
			LguiUtil.Instance.SetLocalText(base.GetText(9), "CookLevelButtonText", Array.Empty<object>());
			this.StartLevelComponent = new StarLevelComponent(base.GetHorizontalLayout(11));
			if (InteractionModel.Instance.CurrentInteractEntityId == null)
			{
				Log.Instance.Info(ELogModule.Cook, ELogAuthor.WZ, "[LevelEventOpenSystem] 打开烹饪界面时找不到交互对象，直接关闭界面", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.CloseMe(null);
			}
			this.WaitUiBlendInCameraSequenceFinished = new CustomPromise();
			CookModel instance = CookModel.Instance;
			instance.CurrentInteractCreatureDataLongId = new long?(InteractionModel.Instance.InteractCreatureDataLongId.Value);
			instance.CurrentCookListType = ECookListType.Cooking;
			this.ShowCookMainView();
			CookController.Instance.TryRequestChangeEntityStateByEvent(ECookMechanismState.EnterUi, this);
			EventSystem.Instance.Add(EEventName.OnExecuteUiCameraSequenceEvent, new Action<string>(this.OnExecuteUiCameraSequenceEvent));
			EventSystem.Instance.Add(EEventName.CloseCookRole, new Action(this.CloseCookRole));
		}

		// Token: 0x06030066 RID: 196710 RVA: 0x00D65B50 File Offset: 0x00D63D50
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			CommonPopViewBase popItem = childPopView.PopItem;
			if (popItem == null)
			{
				return;
			}
			popItem.SetMaskResponsibleState(false);
		}

		// Token: 0x06030067 RID: 196711 RVA: 0x00D65B70 File Offset: 0x00D63D70
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			CookRootView.<OnBeforeShowAsyncImplement>d__20 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<CookRootView.<OnBeforeShowAsyncImplement>d__20>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06030068 RID: 196712 RVA: 0x00D65BB3 File Offset: 0x00D63DB3
		protected override void OnAfterShow()
		{
			this.RefreshPopItemVisible();
			this.WaitUiBlendInCameraSequenceFinished = null;
		}

		// Token: 0x06030069 RID: 196713 RVA: 0x00D65BC4 File Offset: 0x00D63DC4
		private void RefreshPopItemVisible()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			CommonPopViewBase commonPopViewBase = (childPopView != null) ? childPopView.PopItem : null;
			if (commonPopViewBase == null)
			{
				return;
			}
			if (this.IsEnterSequenceCompleted)
			{
				return;
			}
			bool flag = !UiCameraModel.Instance.IsPlayingBlendInSequence();
			if (commonPopViewBase.GetActive() == flag)
			{
				return;
			}
			commonPopViewBase.SetActive(flag);
		}

		// Token: 0x0603006A RID: 196714 RVA: 0x00D65C10 File Offset: 0x00D63E10
		protected override void OnAfterPlayStartSequence()
		{
			int selectedCookingIndex = this.SelectedCookingIndex;
			this.CookItemScrollView.DeselectCurrentGridProxy(false);
			this.CookItemScrollView.ScrollToGridIndex(selectedCookingIndex, true);
			this.CookItemScrollView.SelectGridProxy(selectedCookingIndex, false);
		}

		// Token: 0x0603006B RID: 196715 RVA: 0x00D65C4C File Offset: 0x00D63E4C
		private void CheckShowTab()
		{
			CookModel.Instance.CurrentCookViewType = ECookDataType.CookMain;
			List<MainTypeItem> layoutItemList = this.MainTypeVertical.GetLayoutItemList();
			bool flag = false;
			for (int i = 0; i < layoutItemList.Count; i++)
			{
				MainTypeItem mainTypeItem = layoutItemList[i];
				if (this.GetItemListByType(mainTypeItem.GetMainType()).Count > 0 || i == layoutItemList.Count - 1)
				{
					mainTypeItem.SetUiActive(true);
					if (!flag)
					{
						this.MainTypeVertical.SelectGridProxy(mainTypeItem.GridIndex, false);
						CookModel.Instance.CurrentCookListType = mainTypeItem.GetMainType();
						flag = true;
					}
				}
				else
				{
					mainTypeItem.SetUiActive(false);
				}
			}
		}

		// Token: 0x0603006C RID: 196716 RVA: 0x00D65CE4 File Offset: 0x00D63EE4
		private void ShowCookMainView()
		{
			this.CheckShowTab();
			this.SetCookLevelSprite();
			this.FilterComponent.UpdateData(EFilterSortGroupId.CookList, this.GetItemList(), Array.Empty<object>());
			int uniqueIdByGroupId = this.FilterComponent.GetUniqueIdByGroupId(EFilterSortGroupId.CookList);
			this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId);
			this.SortComponent.SetResultDataDirty();
			this.SortComponent.UpdateData(EFilterSortGroupId.CookList, this.GetItemList(), Array.Empty<object>());
			int uniqueIdByGroupId2 = this.SortComponent.GetUniqueIdByGroupId(EFilterSortGroupId.CookList);
			this.FilterComponent.SetSortUniqueId(uniqueIdByGroupId2);
			this.OnShowRedDot();
			int cookerMaxLevel = CookModel.Instance.GetCookerMaxLevel();
			int cookingLevel = CookModel.Instance.GetCookerInfo().CookingLevel;
			this.StartLevelComponent.ShowLevel(cookingLevel, cookerMaxLevel);
			this.RefreshLimitTime();
		}

		// Token: 0x0603006D RID: 196717 RVA: 0x00D65DA0 File Offset: 0x00D63FA0
		private void OnShowCookRoleView(int id)
		{
			this.ShowCookRoleView(id);
		}

		// Token: 0x0603006E RID: 196718 RVA: 0x00D65DA9 File Offset: 0x00D63FA9
		private void ShowCookRoleView(int id)
		{
			UiManager.Instance.OpenView(EUiViewName.CookRoleView, id, null);
		}

		// Token: 0x0603006F RID: 196719 RVA: 0x00D65DC1 File Offset: 0x00D63FC1
		private void OnShowCookLevelView()
		{
			this.ShowCookLevelView();
		}

		// Token: 0x06030070 RID: 196720 RVA: 0x00D65DC9 File Offset: 0x00D63FC9
		private void ShowCookLevelView()
		{
			UiManager.Instance.OpenView(EUiViewName.CookLevelView, null, null);
		}

		// Token: 0x06030071 RID: 196721 RVA: 0x00D65DDC File Offset: 0x00D63FDC
		protected override void OnAfterHide()
		{
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.CookerLevelKey);
		}

		// Token: 0x06030072 RID: 196722 RVA: 0x00D65DEC File Offset: 0x00D63FEC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpdateFormula, new Action(this.UpdateCookItemScroll));
			EventSystem.Instance.Add(EEventName.CookSuccess, new Action(this.OnCookSuccess));
			EventSystem.Instance.Add(EEventName.CookFail, new Action(this.OnCookFail));
			EventSystem.Instance.Add(EEventName.MachiningSuccess, new Action(this.OnMachiningSuccess));
			EventSystem.Instance.Add(EEventName.MachiningStudyFail, new Action(this.OnMachiningStudyFail));
			EventSystem.Instance.Add(EEventName.GetCookData, new Action(this.ShowCookMainView));
			EventSystem.Instance.Add(EEventName.OpenCookRole, new Action<int>(this.OnShowCookRoleView));
			EventSystem.Instance.Add(EEventName.OpenCookLevel, new Action(this.OnShowCookLevelView));
			EventSystem.Instance.Add(EEventName.OnBeginPlayCookSuccessDisplay, new Action(this.OnBeginPlayCookSuccessDisplay));
			EventSystem.Instance.Add(EEventName.OnBeginPlayCookFailDisplay, new Action(this.OnBeginPlayCookFailDisplay));
			EventSystem.Instance.Add(EEventName.OnPlayCookSuccessDisplayFinished, new Action(this.OnPlayCookSuccessDisplayFinished));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			InputDistributeController.Instance.BindAction("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnSkipSequenceForAction));
			InputDistributeController.Instance.BindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnSkipSequenceForTouch));
			this.RefreshTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnSecondTimerRefresh), 1000f, 1f, null, null, true);
		}

		// Token: 0x06030073 RID: 196723 RVA: 0x00D65FA4 File Offset: 0x00D641A4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UpdateFormula, new Action(this.UpdateCookItemScroll));
			EventSystem.Instance.Remove(EEventName.CookSuccess, new Action(this.OnCookSuccess));
			EventSystem.Instance.Remove(EEventName.CookFail, new Action(this.OnCookFail));
			EventSystem.Instance.Remove(EEventName.MachiningSuccess, new Action(this.OnMachiningSuccess));
			EventSystem.Instance.Remove(EEventName.MachiningStudyFail, new Action(this.OnMachiningStudyFail));
			EventSystem.Instance.Remove(EEventName.GetCookData, new Action(this.ShowCookMainView));
			EventSystem.Instance.Remove(EEventName.OpenCookRole, new Action<int>(this.OnShowCookRoleView));
			EventSystem.Instance.Remove(EEventName.OpenCookLevel, new Action(this.OnShowCookLevelView));
			EventSystem.Instance.Remove(EEventName.OnBeginPlayCookSuccessDisplay, new Action(this.OnBeginPlayCookSuccessDisplay));
			EventSystem.Instance.Remove(EEventName.OnBeginPlayCookFailDisplay, new Action(this.OnBeginPlayCookFailDisplay));
			EventSystem.Instance.Remove(EEventName.OnPlayCookSuccessDisplayFinished, new Action(this.OnPlayCookSuccessDisplayFinished));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			InputDistributeController.Instance.UnBindAction("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnSkipSequenceForAction));
			InputDistributeController.Instance.UnBindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnSkipSequenceForTouch));
			if (this.RefreshTimer != null && TimerSystem.Instance.Has(this.RefreshTimer))
			{
				TimerSystem.Instance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x06030074 RID: 196724 RVA: 0x00D66162 File Offset: 0x00D64362
		private MainTypeItem InitMainTypeItem()
		{
			MainTypeItem mainTypeItem = new MainTypeItem();
			mainTypeItem.SetMainTypeCallback(new Action<int>(this.OnSwitchCallback));
			return mainTypeItem;
		}

		// Token: 0x06030075 RID: 196725 RVA: 0x00D6617C File Offset: 0x00D6437C
		private void OnSecondTimerRefresh(float _)
		{
			this.RefreshLimitTime();
			CookingIngredientsView cookTipsView = this.CookTipsView;
			if (cookTipsView != null)
			{
				cookTipsView.OnSecondTimerRefresh();
			}
			if (this.CheckIsLimitCountRefresh() || this.CheckHasItemTimeoutStateChanged())
			{
				CookController.Instance.SendCookingDataRequestAsync().ContinueWith(delegate(bool result)
				{
					if (result)
					{
						this.UpdateCookItemScroll();
					}
				});
				return;
			}
			if (this.CheckHasItemTimeOut())
			{
				CookController.Instance.SendCookingDataRequestAsync().ContinueWith(delegate(bool result)
				{
					if (result)
					{
						this.FilterComponent.UpdateData(EFilterSortGroupId.CookList, this.GetItemList(), Array.Empty<object>());
						int uniqueIdByGroupId = this.FilterComponent.GetUniqueIdByGroupId(EFilterSortGroupId.CookList);
						this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId);
					}
				});
			}
		}

		// Token: 0x06030076 RID: 196726 RVA: 0x00D661F4 File Offset: 0x00D643F4
		private void RefreshLimitTime()
		{
			string refreshLimitTime = CookModel.Instance.GetRefreshLimitTime();
			if (refreshLimitTime != null)
			{
				base.GetItem(12).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "RefreshTime", new <>z__ReadOnlySingleElementList<object>(refreshLimitTime));
				return;
			}
			base.GetItem(12).SetUIActive(false);
		}

		// Token: 0x06030077 RID: 196727 RVA: 0x00D66249 File Offset: 0x00D64449
		private bool CheckIsLimitCountRefresh()
		{
			return CookModel.Instance.GetRefreshLimitTimeValue() <= 0.0;
		}

		// Token: 0x06030078 RID: 196728 RVA: 0x00D66263 File Offset: 0x00D64463
		private bool CheckHasItemTimeoutStateChanged()
		{
			return CookModel.Instance.CheckHasItemTimeoutStateChangedCore();
		}

		// Token: 0x06030079 RID: 196729 RVA: 0x00D66270 File Offset: 0x00D64470
		private bool CheckHasItemTimeOut()
		{
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				List<ICookItemData> itemList = this.GetItemList();
				for (int i = 0; i < itemList.Count; i++)
				{
					ICookingData cookingData = (ICookingData)itemList[i];
					if (cookingData.ExistEndTime > 0.0 && !TimeUtil.Instance.IsInTimeSpan(cookingData.ExistStartTime, cookingData.ExistEndTime))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603007A RID: 196730 RVA: 0x00D662DA File Offset: 0x00D644DA
		private CookMediumItemGrid OnGridProxyCreate()
		{
			CookMediumItemGrid cookMediumItemGrid = new CookMediumItemGrid();
			cookMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnCookItemClick));
			return cookMediumItemGrid;
		}

		// Token: 0x0603007B RID: 196731 RVA: 0x00D662F4 File Offset: 0x00D644F4
		private void SetCookLevelSprite()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_CookLevel");
			this.SetSpriteByPath(resourcePath, base.GetSprite(6), false, null, null);
		}

		// Token: 0x0603007C RID: 196732 RVA: 0x00D6632C File Offset: 0x00D6452C
		private void OnShowRedDot()
		{
			UUIItem item = base.GetItem(7);
			RedDotController.Instance.BindRedDot(ERedDotName.CookerLevel, item, null, 0);
		}

		// Token: 0x0603007D RID: 196733 RVA: 0x00D66350 File Offset: 0x00D64550
		public void DisableRedDot()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.CookerLevel);
		}

		// Token: 0x0603007E RID: 196734 RVA: 0x00D66360 File Offset: 0x00D64560
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
			this.IsEnterSequenceCompleted = true;
		}

		// Token: 0x0603007F RID: 196735 RVA: 0x00D663B9 File Offset: 0x00D645B9
		private void OnFilterRefresh(List<ICookItemData> list, bool isOutSideChange, EFilterSortType t)
		{
			this.CookItemScrollView.DeselectCurrentGridProxy(false);
			this.SelectedCookingIndex = 0;
			this.OnFilterSortRefresh(list);
		}

		// Token: 0x06030080 RID: 196736 RVA: 0x00D663D5 File Offset: 0x00D645D5
		private void OnSortRefresh(List<ICookItemData> list, bool isOutSideChange, EFilterSortType t)
		{
			this.OnFilterSortRefresh(list);
		}

		// Token: 0x06030081 RID: 196737 RVA: 0x00D663E0 File Offset: 0x00D645E0
		private void OnFilterSortRefresh(List<ICookItemData> list)
		{
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				this.CookItemDataList = new List<ICookingData>();
				using (List<ICookItemData>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ICookItemData cookItemData = enumerator.Current;
						ICookingData cookingData = cookItemData as ICookingData;
						if (cookingData != null && (cookingData.IsUnLock || cookingData.ExistEndTime <= 0.0 || TimeUtil.Instance.IsInTimeSpan(cookingData.ExistStartTime, cookingData.ExistEndTime)))
						{
							this.CookItemDataList.Add(cookingData);
						}
					}
					goto IL_ED;
				}
			}
			this.MachiningDataList = new List<IMachiningData>();
			foreach (ICookItemData cookItemData2 in list)
			{
				IMachiningData machiningData = cookItemData2 as IMachiningData;
				if (machiningData != null)
				{
					this.MachiningDataList.Add(machiningData);
				}
			}
			IL_ED:
			this.RefreshItemScrollView(delegate
			{
				if (list.Count > 0)
				{
					this.SetSelectedCookItem(true);
				}
			});
			if (list.Count == 0)
			{
				base.GetItem(8).SetUIActive(true);
				this.CookTipsView.SetUiActive(false);
				return;
			}
			base.GetItem(8).SetUIActive(false);
			this.CookTipsView.SetUiActive(true);
		}

		// Token: 0x06030082 RID: 196738 RVA: 0x00D66548 File Offset: 0x00D64748
		private void UpdateCookItemScroll()
		{
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				this.FilterComponent.UpdateData(EFilterSortGroupId.CookList, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId = this.FilterComponent.GetUniqueIdByGroupId(EFilterSortGroupId.CookList);
				this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId);
				this.SortComponent.SetResultDataDirty();
				this.SortComponent.UpdateData(EFilterSortGroupId.CookList, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId2 = this.SortComponent.GetUniqueIdByGroupId(EFilterSortGroupId.CookList);
				this.FilterComponent.SetSortUniqueId(uniqueIdByGroupId2);
				return;
			}
			this.FilterComponent.UpdateData(EFilterSortGroupId.CookMachiningList, this.GetItemList(), Array.Empty<object>());
			int uniqueIdByGroupId3 = this.FilterComponent.GetUniqueIdByGroupId(EFilterSortGroupId.CookMachiningList);
			this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId3);
			this.SortComponent.SetResultDataDirty();
			this.SortComponent.UpdateData(EFilterSortGroupId.CookMachiningList, this.GetItemList(), Array.Empty<object>());
			int uniqueIdByGroupId4 = this.SortComponent.GetUniqueIdByGroupId(EFilterSortGroupId.CookMachiningList);
			this.FilterComponent.SetSortUniqueId(uniqueIdByGroupId4);
		}

		// Token: 0x06030083 RID: 196739 RVA: 0x00D66640 File Offset: 0x00D64840
		private void OnCookSuccess()
		{
			this.UpdateTipsViewWithSavedData(true);
		}

		// Token: 0x06030084 RID: 196740 RVA: 0x00D66649 File Offset: 0x00D64849
		private void OnCookFail()
		{
			this.UpdateTipsViewWithSavedData(true);
		}

		// Token: 0x06030085 RID: 196741 RVA: 0x00D66652 File Offset: 0x00D64852
		private void OnMachiningSuccess()
		{
			this.UpdateTipsViewWithSavedData(true);
		}

		// Token: 0x06030086 RID: 196742 RVA: 0x00D6665B File Offset: 0x00D6485B
		private void OnMachiningStudyFail()
		{
			this.UpdateTipsViewWithSavedData(true);
		}

		// Token: 0x06030087 RID: 196743 RVA: 0x00D66664 File Offset: 0x00D64864
		private void UpdateTipsViewWithSavedData(bool isNeedScroll = true)
		{
			this.RefreshItemScrollView(delegate
			{
				this.SetSelectedCookItem(isNeedScroll);
			});
			this.CookTipsView.RefreshTipsWithSavedData();
		}

		// Token: 0x06030088 RID: 196744 RVA: 0x00D666A4 File Offset: 0x00D648A4
		private void SwitchMainTitleByListType()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				CommonPopViewBase popItem = childPopView.PopItem;
				if (popItem != null)
				{
					popItem.SetTitleVisible(true);
				}
			}
			ECookListType currentCookListType = CookModel.Instance.CurrentCookListType;
			if (currentCookListType != ECookListType.Cooking)
			{
				if (currentCookListType != ECookListType.Machining)
				{
					return;
				}
				IUiPopFrameInterface childPopView2 = this.ChildPopView;
				if (childPopView2 == null)
				{
					return;
				}
				CommonPopViewBase popItem2 = childPopView2.PopItem;
				if (popItem2 == null)
				{
					return;
				}
				popItem2.SetTitleText(TextConfig.Instance.GetTextContentIdById("MakingAccessory") ?? "");
				return;
			}
			else
			{
				IUiPopFrameInterface childPopView3 = this.ChildPopView;
				if (childPopView3 == null)
				{
					return;
				}
				CommonPopViewBase popItem3 = childPopView3.PopItem;
				if (popItem3 == null)
				{
					return;
				}
				popItem3.SetTitleText(TextConfig.Instance.GetTextContentIdById("MakingDishes") ?? "");
				return;
			}
		}

		// Token: 0x06030089 RID: 196745 RVA: 0x00D66748 File Offset: 0x00D64948
		private List<ICookItemData> GetItemListByType(ECookListType type)
		{
			if (type == ECookListType.Cooking)
			{
				return CookModel.Instance.GetCookingDataList().ConvertAll<ICookItemData>(([Nullable(1)] ICookingData v) => v);
			}
			return CookModel.Instance.GetMachiningDataList().ConvertAll<ICookItemData>(([Nullable(1)] IMachiningData v) => v);
		}

		// Token: 0x0603008A RID: 196746 RVA: 0x00D667B5 File Offset: 0x00D649B5
		private List<ICookItemData> GetItemList()
		{
			return this.GetItemListByType(CookModel.Instance.CurrentCookListType);
		}

		// Token: 0x0603008B RID: 196747 RVA: 0x00D667C8 File Offset: 0x00D649C8
		private void RefreshItemScrollView(Action refreshDoneCallback)
		{
			this.CookItemScrollView.DeselectCurrentGridProxy(false);
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				this.CookItemScrollView.RefreshByData(this.CookItemDataList.ConvertAll<ICookItemData>(([Nullable(1)] ICookingData v) => v), false, refreshDoneCallback, false);
				return;
			}
			this.CookItemScrollView.RefreshByData(this.MachiningDataList.ConvertAll<ICookItemData>(([Nullable(1)] IMachiningData v) => v), false, refreshDoneCallback, false);
		}

		// Token: 0x0603008C RID: 196748 RVA: 0x00D66860 File Offset: 0x00D64A60
		private void SetSelectedCookItem(bool isNeedScroll = false)
		{
			CookRootView.<>c__DisplayClass58_0 CS$<>8__locals1 = new CookRootView.<>c__DisplayClass58_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.index = 0;
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				CS$<>8__locals1.index = this.SelectedCookingIndex;
				this.CookTipsView.RefreshTips(this.CookItemDataList[CS$<>8__locals1.index]);
			}
			else
			{
				CS$<>8__locals1.index = this.SelectedMachiningIndex;
				this.CookTipsView.RefreshTips(this.MachiningDataList[CS$<>8__locals1.index]);
			}
			this.CookItemScrollView.DeselectCurrentGridProxy(false);
			if (isNeedScroll)
			{
				CS$<>8__locals1.<SetSelectedCookItem>g__Temp|0().Forget();
			}
			this.CookItemScrollView.SelectGridProxy(CS$<>8__locals1.index, false);
		}

		// Token: 0x0603008D RID: 196749 RVA: 0x00D6690C File Offset: 0x00D64B0C
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnExecuteUiCameraSequenceEvent, new Action<string>(this.OnExecuteUiCameraSequenceEvent));
			EventSystem.Instance.Remove(EEventName.CloseCookRole, new Action(this.CloseCookRole));
			CookController.Instance.TryRequestChangeEntityStateByEvent(ECookMechanismState.CloseUi, this);
			CookController.Instance.ClearCookDisplay();
			this.DisableRedDot();
			if (this.CookItemScrollView != null)
			{
				this.CookItemScrollView.ClearGridProxies();
				this.CookItemScrollView = null;
			}
			if (this.FilterComponent != null)
			{
				this.FilterComponent.Destroy(null);
				this.FilterComponent = null;
			}
			if (this.SortComponent != null)
			{
				this.SortComponent.Destroy(null);
			}
			if (this.MainTypeVertical != null)
			{
				this.MainTypeVertical.ClearChildren();
				this.MainTypeVertical = null;
			}
			this.StartLevelComponent.Clear();
			CookModel instance = CookModel.Instance;
			instance.CurrentCookRoleId = null;
			instance.ClearCookRoleItemDataList();
			this.WaitUiBlendInCameraSequenceFinished = null;
		}

		// Token: 0x0603008E RID: 196750 RVA: 0x00D669FF File Offset: 0x00D64BFF
		private void OnBeginPlayCookSuccessDisplay()
		{
			this.<OnBeginPlayCookSuccessDisplay>g__Temp|60_0().Forget();
		}

		// Token: 0x0603008F RID: 196751 RVA: 0x00D66A0C File Offset: 0x00D64C0C
		private void OnBeginPlayCookFailDisplay()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			CommonPopViewBase popItem = childPopView.PopItem;
			if (popItem == null)
			{
				return;
			}
			popItem.SetUiActive(false);
		}

		// Token: 0x06030090 RID: 196752 RVA: 0x00D66A29 File Offset: 0x00D64C29
		private void OnPlayCookSuccessDisplayFinished()
		{
			CookController.Instance.TryRequestChangeEntityStateByEvent(ECookMechanismState.CookDone, this);
		}

		// Token: 0x06030091 RID: 196753 RVA: 0x00D66A3C File Offset: 0x00D64C3C
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.CompositeRewardView)
			{
				return;
			}
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				CommonPopViewBase popItem = childPopView.PopItem;
				if (popItem != null)
				{
					popItem.SetActive(true);
				}
			}
			IUiPopFrameInterface childPopView2 = this.ChildPopView;
			if (childPopView2 == null)
			{
				return;
			}
			childPopView2.PlayLevelSequenceByName("Start", false);
		}

		// Token: 0x06030092 RID: 196754 RVA: 0x00D66A8A File Offset: 0x00D64C8A
		private void CloseCookRole()
		{
			this.CookTipsView.RefreshCooking();
		}

		// Token: 0x06030093 RID: 196755 RVA: 0x00D66A97 File Offset: 0x00D64C97
		private void OnSkipSequence()
		{
			if (CookController.Instance.IsPlayingSuccessDisplay)
			{
				CookController.Instance.SkipCookSuccessDisplay();
				return;
			}
			if (CookController.Instance.IsPlayingFailDisplay)
			{
				CookController.Instance.SkipCookFailDisplay();
			}
		}

		// Token: 0x06030094 RID: 196756 RVA: 0x00D66AC6 File Offset: 0x00D64CC6
		private void OnSkipSequenceForAction(string arg1, InputDistributeDefine.EActionType arg2, InputIdentification arg3)
		{
			this.OnSkipSequence();
		}

		// Token: 0x06030095 RID: 196757 RVA: 0x00D66ACE File Offset: 0x00D64CCE
		private void OnSkipSequenceForTouch(string arg1, InputDistributeDefine.ITouchData arg2, InputIdentification arg3)
		{
			this.OnSkipSequence();
		}

		// Token: 0x06030096 RID: 196758 RVA: 0x00D66AD8 File Offset: 0x00D64CD8
		private void OnSwitchCallback(int mainType)
		{
			if (CookModel.Instance.CurrentCookListType == (ECookListType)mainType)
			{
				return;
			}
			if (mainType == 0)
			{
				CookModel.Instance.CurrentCookListType = ECookListType.Cooking;
				EventSystem.Instance.Emit(EEventName.SwitchCookType);
				base.GetItem(3).SetUIActive(true);
				this.IsSwitchType = true;
				this.UpdateCookItemScroll();
			}
			else
			{
				CookModel.Instance.CurrentCookListType = ECookListType.Machining;
				EventSystem.Instance.Emit(EEventName.SwitchCookType);
				this.IsSwitchType = true;
				base.GetItem(3).SetUIActive(false);
				this.UpdateCookItemScroll();
			}
			this.SwitchMainTitleByListType();
			this.IsSwitchType = false;
		}

		// Token: 0x06030097 RID: 196759 RVA: 0x00D66B70 File Offset: 0x00D64D70
		private void OnCookItemClick(MediumItemGridExtendCallback callbackParameter)
		{
			ICookItemData cookItemData = callbackParameter.Data as ICookItemData;
			this.CookItemScrollView.DeselectCurrentGridProxy(false);
			int gridIndex;
			if (cookItemData.MainType == ECookListType.Cooking)
			{
				ICookingData cookingData = cookItemData as ICookingData;
				this.SelectedCookingIndex = this.CookItemDataList.IndexOf(cookingData);
				gridIndex = this.SelectedCookingIndex;
				this.CookTipsView.RefreshTips(cookingData);
			}
			else
			{
				IMachiningData machiningData = cookItemData as IMachiningData;
				this.SelectedMachiningIndex = this.MachiningDataList.IndexOf(machiningData);
				gridIndex = this.SelectedMachiningIndex;
				this.CookTipsView.RefreshTips(machiningData);
			}
			if (!this.CookItemScrollView.IsGridDisplaying(gridIndex))
			{
				return;
			}
			if (cookItemData.IsNew && !this.IsSwitchType)
			{
				NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.CookerLevelKey, cookItemData.ItemId);
				cookItemData.IsNew = false;
			}
			this.CookItemScrollView.SelectGridProxy(gridIndex, false);
			this.CookItemScrollView.RefreshGridProxy(gridIndex);
			this.SwitchMainTitleByListType();
			this.IsSwitchType = false;
		}

		// Token: 0x06030098 RID: 196760 RVA: 0x00D66C58 File Offset: 0x00D64E58
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			UUIItem guideUiItem = base.GetGuideUiItem(configParams[0]);
			if (guideUiItem != null)
			{
				return new UUIItem[]
				{
					guideUiItem,
					guideUiItem
				};
			}
			int num = int.Parse(configParams[0]);
			LoopScrollView<CookMediumItemGrid, ICookItemData> cookItemScrollView = this.CookItemScrollView;
			if (cookItemScrollView == null || !cookItemScrollView.DataInited)
			{
				return null;
			}
			if (num != 0)
			{
				UUIItem gridAndScrollToByJudge = this.CookItemScrollView.GetGridAndScrollToByJudge(num, delegate(object tempItemId, ICookItemData picked)
				{
					if (picked.MainType != ECookListType.Cooking)
					{
						return false;
					}
					ICookingData cookingData = (ICookingData)picked;
					return cookingData.SubType == ESubCookDataType.CookMenu && (int)tempItemId == cookingData.DataId;
				}, true);
				if (gridAndScrollToByJudge != null)
				{
					return new UUIItem[]
					{
						gridAndScrollToByJudge,
						gridAndScrollToByJudge
					};
				}
			}
			else
			{
				UUIItem gridByDisplayIndex = this.CookItemScrollView.GetGridByDisplayIndex(0);
				if (gridByDisplayIndex != null)
				{
					return new UUIItem[]
					{
						gridByDisplayIndex,
						gridByDisplayIndex
					};
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "烹饪界面聚焦引导的额外参数配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x0603009B RID: 196763 RVA: 0x00D66D84 File Offset: 0x00D64F84
		[CompilerGenerated]
		private UniTask <OnBeginPlayCookSuccessDisplay>g__Temp|60_0()
		{
			CookRootView.<<OnBeginPlayCookSuccessDisplay>g__Temp|60_0>d <<OnBeginPlayCookSuccessDisplay>g__Temp|60_0>d;
			<<OnBeginPlayCookSuccessDisplay>g__Temp|60_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnBeginPlayCookSuccessDisplay>g__Temp|60_0>d.<>4__this = this;
			<<OnBeginPlayCookSuccessDisplay>g__Temp|60_0>d.<>1__state = -1;
			<<OnBeginPlayCookSuccessDisplay>g__Temp|60_0>d.<>t__builder.Start<CookRootView.<<OnBeginPlayCookSuccessDisplay>g__Temp|60_0>d>(ref <<OnBeginPlayCookSuccessDisplay>g__Temp|60_0>d);
			return <<OnBeginPlayCookSuccessDisplay>g__Temp|60_0>d.<>t__builder.Task;
		}

		// Token: 0x04019789 RID: 104329
		public const int TIMERGAP = 1000;

		// Token: 0x0401978A RID: 104330
		private int SelectedCookingIndex;

		// Token: 0x0401978B RID: 104331
		private int SelectedMachiningIndex;

		// Token: 0x0401978C RID: 104332
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MainTypeItem, ECookListType> MainTypeVertical;

		// Token: 0x0401978D RID: 104333
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<CookMediumItemGrid, ICookItemData> CookItemScrollView;

		// Token: 0x0401978E RID: 104334
		private List<ICookingData> CookItemDataList = new List<ICookingData>();

		// Token: 0x0401978F RID: 104335
		private List<IMachiningData> MachiningDataList = new List<IMachiningData>();

		// Token: 0x04019790 RID: 104336
		[Nullable(2)]
		private CookingIngredientsView CookTipsView;

		// Token: 0x04019791 RID: 104337
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterEntrance<ICookItemData> FilterComponent;

		// Token: 0x04019792 RID: 104338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private SortEntrance<ICookItemData> SortComponent;

		// Token: 0x04019793 RID: 104339
		private bool IsSwitchType;

		// Token: 0x04019794 RID: 104340
		[Nullable(2)]
		private StarLevelComponent StartLevelComponent;

		// Token: 0x04019795 RID: 104341
		[Nullable(2)]
		private CustomPromise WaitUiBlendInCameraSequenceFinished;

		// Token: 0x04019796 RID: 104342
		private bool IsEnterSequenceCompleted;

		// Token: 0x04019797 RID: 104343
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x0200A763 RID: 42851
		[NullableContext(0)]
		public enum ECookMainDefine
		{
			// Token: 0x04033B93 RID: 211859
			CookListTypeHorizontalLayout,
			// Token: 0x04033B94 RID: 211860
			CookListTypeHorizontalLayoutItem,
			// Token: 0x04033B95 RID: 211861
			ItemLoopScroll,
			// Token: 0x04033B96 RID: 211862
			FilterItem,
			// Token: 0x04033B97 RID: 211863
			IngredientDetail,
			// Token: 0x04033B98 RID: 211864
			CookLevelExtendToggle,
			// Token: 0x04033B99 RID: 211865
			CookLevelSprite,
			// Token: 0x04033B9A RID: 211866
			RedDotItem,
			// Token: 0x04033B9B RID: 211867
			NoItem,
			// Token: 0x04033B9C RID: 211868
			TxtConfirm,
			// Token: 0x04033B9D RID: 211869
			SortItem,
			// Token: 0x04033B9E RID: 211870
			PnlStar,
			// Token: 0x04033B9F RID: 211871
			PnlTime,
			// Token: 0x04033BA0 RID: 211872
			TxtTime
		}
	}
}
