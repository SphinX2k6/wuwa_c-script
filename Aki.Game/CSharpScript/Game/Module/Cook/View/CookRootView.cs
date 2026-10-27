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
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B22 RID: 23330
	[NullableContext(1)]
	[Nullable(0)]
	public class CookRootView : UiViewBase
	{
		// Token: 0x0603B0F0 RID: 241904 RVA: 0x00E14A2D File Offset: 0x00E12C2D
		public CookRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B0F1 RID: 241905 RVA: 0x00E14A4C File Offset: 0x00E12C4C
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

		// Token: 0x0603B0F2 RID: 241906 RVA: 0x00E14C84 File Offset: 0x00E12E84
		protected override UniTask OnBeforeStartAsync()
		{
			CookRootView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CookRootView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B0F3 RID: 241907 RVA: 0x00E14CC8 File Offset: 0x00E12EC8
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

		// Token: 0x0603B0F4 RID: 241908 RVA: 0x00E14E38 File Offset: 0x00E13038
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

		// Token: 0x0603B0F5 RID: 241909 RVA: 0x00E14E58 File Offset: 0x00E13058
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			CookRootView.<OnBeforeShowAsyncImplement>d__20 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<CookRootView.<OnBeforeShowAsyncImplement>d__20>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603B0F6 RID: 241910 RVA: 0x00E14E9B File Offset: 0x00E1309B
		protected override void OnAfterShow()
		{
			this.RefreshPopItemVisible();
			this.WaitUiBlendInCameraSequenceFinished = null;
		}

		// Token: 0x0603B0F7 RID: 241911 RVA: 0x00E14EAC File Offset: 0x00E130AC
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
			bool flag = !UiCameraAnimationManager.Instance.IsPlayingBlendInSequence();
			if (commonPopViewBase.GetActive() == flag)
			{
				return;
			}
			commonPopViewBase.SetActive(flag);
		}

		// Token: 0x0603B0F8 RID: 241912 RVA: 0x00E14EF8 File Offset: 0x00E130F8
		protected override void OnAfterPlayStartSequence()
		{
			int selectedCookingIndex = this.SelectedCookingIndex;
			this.CookItemScrollView.DeselectCurrentGridProxy(false);
			this.CookItemScrollView.ScrollToGridIndex(selectedCookingIndex, true);
			this.CookItemScrollView.SelectGridProxy(selectedCookingIndex, false);
		}

		// Token: 0x0603B0F9 RID: 241913 RVA: 0x00E14F34 File Offset: 0x00E13134
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

		// Token: 0x0603B0FA RID: 241914 RVA: 0x00E14FCC File Offset: 0x00E131CC
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

		// Token: 0x0603B0FB RID: 241915 RVA: 0x00E15088 File Offset: 0x00E13288
		private void OnShowCookRoleView(int id)
		{
			this.ShowCookRoleView(id);
		}

		// Token: 0x0603B0FC RID: 241916 RVA: 0x00E15091 File Offset: 0x00E13291
		private void ShowCookRoleView(int id)
		{
			UiManager.Instance.OpenView(EUiViewName.CookRoleView, id, null);
		}

		// Token: 0x0603B0FD RID: 241917 RVA: 0x00E150A9 File Offset: 0x00E132A9
		private void OnShowCookLevelView()
		{
			this.ShowCookLevelView();
		}

		// Token: 0x0603B0FE RID: 241918 RVA: 0x00E150B1 File Offset: 0x00E132B1
		private void ShowCookLevelView()
		{
			UiManager.Instance.OpenView(EUiViewName.CookLevelView, null, null);
		}

		// Token: 0x0603B0FF RID: 241919 RVA: 0x00E150C4 File Offset: 0x00E132C4
		protected override void OnAfterHide()
		{
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.CookerLevelKey);
		}

		// Token: 0x0603B100 RID: 241920 RVA: 0x00E150D4 File Offset: 0x00E132D4
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

		// Token: 0x0603B101 RID: 241921 RVA: 0x00E1528C File Offset: 0x00E1348C
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

		// Token: 0x0603B102 RID: 241922 RVA: 0x00E1544A File Offset: 0x00E1364A
		private MainTypeItem InitMainTypeItem()
		{
			MainTypeItem mainTypeItem = new MainTypeItem();
			mainTypeItem.SetMainTypeCallback(new Action<int>(this.OnSwitchCallback));
			return mainTypeItem;
		}

		// Token: 0x0603B103 RID: 241923 RVA: 0x00E15464 File Offset: 0x00E13664
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

		// Token: 0x0603B104 RID: 241924 RVA: 0x00E154DC File Offset: 0x00E136DC
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

		// Token: 0x0603B105 RID: 241925 RVA: 0x00E15531 File Offset: 0x00E13731
		private bool CheckIsLimitCountRefresh()
		{
			return CookModel.Instance.GetRefreshLimitTimeValue() <= 0.0;
		}

		// Token: 0x0603B106 RID: 241926 RVA: 0x00E1554B File Offset: 0x00E1374B
		private bool CheckHasItemTimeoutStateChanged()
		{
			return CookModel.Instance.CheckHasItemTimeoutStateChangedCore();
		}

		// Token: 0x0603B107 RID: 241927 RVA: 0x00E15558 File Offset: 0x00E13758
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

		// Token: 0x0603B108 RID: 241928 RVA: 0x00E155C2 File Offset: 0x00E137C2
		private CookMediumItemGrid OnGridProxyCreate()
		{
			CookMediumItemGrid cookMediumItemGrid = new CookMediumItemGrid();
			cookMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnCookItemClick));
			return cookMediumItemGrid;
		}

		// Token: 0x0603B109 RID: 241929 RVA: 0x00E155DC File Offset: 0x00E137DC
		private void SetCookLevelSprite()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_CookLevel");
			this.SetSpriteByPath(resourcePath, base.GetSprite(6), false, null, null);
		}

		// Token: 0x0603B10A RID: 241930 RVA: 0x00E15614 File Offset: 0x00E13814
		private void OnShowRedDot()
		{
			UUIItem item = base.GetItem(7);
			RedDotController.Instance.BindRedDot(ERedDotName.CookerLevel, item, null, 0);
		}

		// Token: 0x0603B10B RID: 241931 RVA: 0x00E15638 File Offset: 0x00E13838
		public void DisableRedDot()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.CookerLevel);
		}

		// Token: 0x0603B10C RID: 241932 RVA: 0x00E15648 File Offset: 0x00E13848
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

		// Token: 0x0603B10D RID: 241933 RVA: 0x00E156A1 File Offset: 0x00E138A1
		private void OnFilterRefresh(List<ICookItemData> list, bool isOutSideChange, EFilterSortType t)
		{
			this.CookItemScrollView.DeselectCurrentGridProxy(false);
			this.SelectedCookingIndex = 0;
			this.OnFilterSortRefresh(list);
		}

		// Token: 0x0603B10E RID: 241934 RVA: 0x00E156BD File Offset: 0x00E138BD
		private void OnSortRefresh(List<ICookItemData> list, bool isOutSideChange, EFilterSortType t)
		{
			this.OnFilterSortRefresh(list);
		}

		// Token: 0x0603B10F RID: 241935 RVA: 0x00E156C8 File Offset: 0x00E138C8
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

		// Token: 0x0603B110 RID: 241936 RVA: 0x00E15830 File Offset: 0x00E13A30
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

		// Token: 0x0603B111 RID: 241937 RVA: 0x00E15928 File Offset: 0x00E13B28
		private void OnCookSuccess()
		{
			this.UpdateTipsViewWithSavedData(true);
		}

		// Token: 0x0603B112 RID: 241938 RVA: 0x00E15931 File Offset: 0x00E13B31
		private void OnCookFail()
		{
			this.UpdateTipsViewWithSavedData(true);
		}

		// Token: 0x0603B113 RID: 241939 RVA: 0x00E1593A File Offset: 0x00E13B3A
		private void OnMachiningSuccess()
		{
			this.UpdateTipsViewWithSavedData(true);
		}

		// Token: 0x0603B114 RID: 241940 RVA: 0x00E15943 File Offset: 0x00E13B43
		private void OnMachiningStudyFail()
		{
			this.UpdateTipsViewWithSavedData(true);
		}

		// Token: 0x0603B115 RID: 241941 RVA: 0x00E1594C File Offset: 0x00E13B4C
		private void UpdateTipsViewWithSavedData(bool isNeedScroll = true)
		{
			this.RefreshItemScrollView(delegate
			{
				this.SetSelectedCookItem(isNeedScroll);
			});
			this.CookTipsView.RefreshTipsWithSavedData();
		}

		// Token: 0x0603B116 RID: 241942 RVA: 0x00E1598C File Offset: 0x00E13B8C
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

		// Token: 0x0603B117 RID: 241943 RVA: 0x00E15A30 File Offset: 0x00E13C30
		private List<ICookItemData> GetItemListByType(ECookListType type)
		{
			if (type == ECookListType.Cooking)
			{
				return CookModel.Instance.GetCookingDataList().ConvertAll<ICookItemData>(([Nullable(1)] ICookingData v) => v);
			}
			return CookModel.Instance.GetMachiningDataList().ConvertAll<ICookItemData>(([Nullable(1)] IMachiningData v) => v);
		}

		// Token: 0x0603B118 RID: 241944 RVA: 0x00E15A9D File Offset: 0x00E13C9D
		private List<ICookItemData> GetItemList()
		{
			return this.GetItemListByType(CookModel.Instance.CurrentCookListType);
		}

		// Token: 0x0603B119 RID: 241945 RVA: 0x00E15AB0 File Offset: 0x00E13CB0
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

		// Token: 0x0603B11A RID: 241946 RVA: 0x00E15B48 File Offset: 0x00E13D48
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

		// Token: 0x0603B11B RID: 241947 RVA: 0x00E15BF4 File Offset: 0x00E13DF4
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

		// Token: 0x0603B11C RID: 241948 RVA: 0x00E15CE7 File Offset: 0x00E13EE7
		private void OnBeginPlayCookSuccessDisplay()
		{
			this.<OnBeginPlayCookSuccessDisplay>g__Temp|60_0().Forget();
		}

		// Token: 0x0603B11D RID: 241949 RVA: 0x00E15CF4 File Offset: 0x00E13EF4
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

		// Token: 0x0603B11E RID: 241950 RVA: 0x00E15D11 File Offset: 0x00E13F11
		private void OnPlayCookSuccessDisplayFinished()
		{
			CookController.Instance.TryRequestChangeEntityStateByEvent(ECookMechanismState.CookDone, this);
		}

		// Token: 0x0603B11F RID: 241951 RVA: 0x00E15D24 File Offset: 0x00E13F24
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

		// Token: 0x0603B120 RID: 241952 RVA: 0x00E15D72 File Offset: 0x00E13F72
		private void CloseCookRole()
		{
			this.CookTipsView.RefreshCooking();
		}

		// Token: 0x0603B121 RID: 241953 RVA: 0x00E15D7F File Offset: 0x00E13F7F
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

		// Token: 0x0603B122 RID: 241954 RVA: 0x00E15DAE File Offset: 0x00E13FAE
		private void OnSkipSequenceForAction(string arg1, InputDistributeDefine.EActionType arg2, InputIdentification arg3)
		{
			this.OnSkipSequence();
		}

		// Token: 0x0603B123 RID: 241955 RVA: 0x00E15DB6 File Offset: 0x00E13FB6
		private void OnSkipSequenceForTouch(string arg1, InputDistributeDefine.ITouchData arg2, InputIdentification arg3)
		{
			this.OnSkipSequence();
		}

		// Token: 0x0603B124 RID: 241956 RVA: 0x00E15DC0 File Offset: 0x00E13FC0
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

		// Token: 0x0603B125 RID: 241957 RVA: 0x00E15E58 File Offset: 0x00E14058
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

		// Token: 0x0603B126 RID: 241958 RVA: 0x00E15F40 File Offset: 0x00E14140
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

		// Token: 0x0603B129 RID: 241961 RVA: 0x00E1606C File Offset: 0x00E1426C
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

		// Token: 0x0401ECCD RID: 126157
		public const int TIMERGAP = 1000;

		// Token: 0x0401ECCE RID: 126158
		private int SelectedCookingIndex;

		// Token: 0x0401ECCF RID: 126159
		private int SelectedMachiningIndex;

		// Token: 0x0401ECD0 RID: 126160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MainTypeItem, ECookListType> MainTypeVertical;

		// Token: 0x0401ECD1 RID: 126161
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<CookMediumItemGrid, ICookItemData> CookItemScrollView;

		// Token: 0x0401ECD2 RID: 126162
		private List<ICookingData> CookItemDataList = new List<ICookingData>();

		// Token: 0x0401ECD3 RID: 126163
		private List<IMachiningData> MachiningDataList = new List<IMachiningData>();

		// Token: 0x0401ECD4 RID: 126164
		[Nullable(2)]
		private CookingIngredientsView CookTipsView;

		// Token: 0x0401ECD5 RID: 126165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterEntrance<ICookItemData> FilterComponent;

		// Token: 0x0401ECD6 RID: 126166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private SortEntrance<ICookItemData> SortComponent;

		// Token: 0x0401ECD7 RID: 126167
		private bool IsSwitchType;

		// Token: 0x0401ECD8 RID: 126168
		[Nullable(2)]
		private StarLevelComponent StartLevelComponent;

		// Token: 0x0401ECD9 RID: 126169
		[Nullable(2)]
		private CustomPromise WaitUiBlendInCameraSequenceFinished;

		// Token: 0x0401ECDA RID: 126170
		private bool IsEnterSequenceCompleted;

		// Token: 0x0401ECDB RID: 126171
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x0200BD5A RID: 48474
		[NullableContext(0)]
		public enum ECookMainDefine
		{
			// Token: 0x040391C7 RID: 233927
			CookListTypeHorizontalLayout,
			// Token: 0x040391C8 RID: 233928
			CookListTypeHorizontalLayoutItem,
			// Token: 0x040391C9 RID: 233929
			ItemLoopScroll,
			// Token: 0x040391CA RID: 233930
			FilterItem,
			// Token: 0x040391CB RID: 233931
			IngredientDetail,
			// Token: 0x040391CC RID: 233932
			CookLevelExtendToggle,
			// Token: 0x040391CD RID: 233933
			CookLevelSprite,
			// Token: 0x040391CE RID: 233934
			RedDotItem,
			// Token: 0x040391CF RID: 233935
			NoItem,
			// Token: 0x040391D0 RID: 233936
			TxtConfirm,
			// Token: 0x040391D1 RID: 233937
			SortItem,
			// Token: 0x040391D2 RID: 233938
			PnlStar,
			// Token: 0x040391D3 RID: 233939
			PnlTime,
			// Token: 0x040391D4 RID: 233940
			TxtTime
		}
	}
}
