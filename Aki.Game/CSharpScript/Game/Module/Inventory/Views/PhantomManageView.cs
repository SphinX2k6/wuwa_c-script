using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Inventory.Views
{
	// Token: 0x02004814 RID: 18452
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomManageView : UiViewBase
	{
		// Token: 0x0602E592 RID: 189842 RVA: 0x00CEE66A File Offset: 0x00CEC86A
		public PhantomManageView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E593 RID: 189843 RVA: 0x00CEE680 File Offset: 0x00CEC880
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 7;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickedBtnClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action<EToggleState>(this.OnClickedBtnSelectAll));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickedBtnClearSelect));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickedBtnConfig));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnClickedBtnSmartDiscard));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnClickedBtnManage));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(19, new Action<EToggleState>(this.OnToggleShowStrengthened));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602E594 RID: 189844 RVA: 0x00CEEA60 File Offset: 0x00CECC60
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomManageView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomManageView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E595 RID: 189845 RVA: 0x00CEEAA4 File Offset: 0x00CECCA4
		protected override void OnStart()
		{
			this.ViewModel = new PhantomManageViewModel();
			this.ViewModel.Bind(new Action<EPhantomManageViewData>(this.OnViewModelUpdate));
			this.ItemScroll = new LoopScrollView<PhantomManageMediumItemGrid, PhantomItemData>(base.GetLoopScrollViewComponent(4), base.GetItem(5).GetOwner() as AUIBaseActor, new Func<PhantomManageMediumItemGrid>(this.InitItem), false);
			PhantomManageMediumItemGrid.CallbackCheckTips = new Func<PhantomItemData, bool>(this.CheckItemTips);
			PhantomManageMediumItemGrid.CallbackCheckSelect = new Func<PhantomItemData, bool>(this.CheckItemSelect);
			PhantomManageMediumItemGrid.CallbackListenerFocus = new Action<PhantomItemData>(this.OnListenerFocus);
			this.FilterEntrance = new FilterEntrance<PhantomItemData>(base.GetItem(8), new TUpdateDataListFunction<PhantomItemData>(this.OnFilterSortRefresh));
			this.CaptionItem = new PopupCaptionItem(base.GetItem(1));
			this.CaptionItem.SetHelpBtnActive(false);
			this.CaptionItem.SetCloseBtnShowState(false);
		}

		// Token: 0x0602E596 RID: 189846 RVA: 0x00CEEB80 File Offset: 0x00CECD80
		protected override void OnBeforeShow()
		{
			this.OpenParamId = (this.OpenParam as int?).GetValueOrDefault();
			if (((this.OpenParamId > 0) ? InventoryModel.Instance.GetPhantomItemData(this.OpenParamId) : null) != null)
			{
				this.SelectId = this.OpenParamId;
			}
			else
			{
				this.SelectId = 0;
			}
			base.SetButtonUiActive(11, false);
			this.RefreshCapacity();
			this.ClearInvalidSelectItems();
			this.RefreshList();
			this.RefreshBtn();
		}

		// Token: 0x0602E597 RID: 189847 RVA: 0x00CEEC00 File Offset: 0x00CECE00
		private void ClearInvalidSelectItems()
		{
			foreach (int uniqueId in new List<int>(this.ViewModel.GetSelectSet()))
			{
				if (InventoryModel.Instance.GetPhantomItemData(uniqueId) == null)
				{
					this.ViewModel.GetSelectSet().Clear();
					break;
				}
			}
		}

		// Token: 0x0602E598 RID: 189848 RVA: 0x00CEEC78 File Offset: 0x00CECE78
		protected override void OnBeforeDestroy()
		{
			this.ViewModel.UnBind(new Action<EPhantomManageViewData>(this.OnViewModelUpdate));
			this.ViewModel.ClearSelectSet();
			this.ClearFilterData();
		}

		// Token: 0x0602E599 RID: 189849 RVA: 0x00CEECA4 File Offset: 0x00CECEA4
		private void RefreshCapacity()
		{
			ItemMainType? itemMainTypeConfig = InventoryConfig.Instance.GetItemMainTypeConfig(3);
			if (itemMainTypeConfig == null)
			{
				return;
			}
			int packageId = itemMainTypeConfig.Value.PackageId;
			PackageCapacity? packageConfig = InventoryConfig.Instance.GetPackageConfig(packageId);
			int count = InventoryModel.Instance.GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId.Phantom).Count;
			int num = 0;
			if (packageConfig != null)
			{
				num = packageConfig.Value.Capacity;
			}
			UUIText text = base.GetText(2);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (count >= num)
			{
				UUIText uuitext = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=red>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(count);
				defaultInterpolatedStringHandler.AppendLiteral("</color>/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
			UUIText uuitext2 = text;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			uuitext2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602E59A RID: 189850 RVA: 0x00CEED9C File Offset: 0x00CECF9C
		private void RefreshList()
		{
			HashSet<ItemDataBase> itemDataBaseByMainType = InventoryModel.Instance.GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId.Phantom);
			List<PhantomItemData> list = new List<PhantomItemData>();
			foreach (ItemDataBase itemDataBase in itemDataBaseByMainType)
			{
				PhantomItemData phantomItemData = (PhantomItemData)itemDataBase;
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(phantomItemData.GetUniqueId());
				if (phantomBattleData != null && (this.ShowStrengthened || phantomBattleData.GetPhantomLevel() <= 0))
				{
					list.Add(phantomItemData);
				}
			}
			this.FilterEntrance.UpdateDataWithConfig(EFilterSortGroupId.PhantomManage, EFilterSortConfigId.PhantomManage, list, "", Array.Empty<object>());
		}

		// Token: 0x0602E59B RID: 189851 RVA: 0x00CEEE40 File Offset: 0x00CED040
		private void RefreshItem(PhantomItemData itemData)
		{
			this.RefreshTips(itemData);
			this.RefreshRedDot(itemData);
			this.RefreshNew(itemData);
			this.RefreshSelect(itemData);
		}

		// Token: 0x0602E59C RID: 189852 RVA: 0x00CEEE60 File Offset: 0x00CED060
		private void RefreshTips(PhantomItemData itemData)
		{
			int configId = itemData.GetConfigId();
			int uniqueId = itemData.GetUniqueId();
			ItemTipsData tipsDataById = ItemTipsComponentUtilTool.GetTipsDataById(configId, new int?(uniqueId), null);
			if (tipsDataById != null)
			{
				this.ItemTipsComponent.RefreshTips(tipsDataById);
				this.ItemTipsComponent.SetVisible(true);
			}
			else
			{
				this.ItemTipsComponent.SetVisible(false);
			}
			this.ItemTipsComponent.SetTipsComponentLockButton(false);
		}

		// Token: 0x0602E59D RID: 189853 RVA: 0x00CEEEBC File Offset: 0x00CED0BC
		private void RefreshRedDot(PhantomItemData itemData)
		{
			InventoryModel instance = InventoryModel.Instance;
			int configId = itemData.GetConfigId();
			int uniqueId = itemData.GetUniqueId();
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(configId);
			if (itemConfigData != null && itemConfigData.RedDotDisableRule == InventoryDefine.ERedDotDisableRule.AfterSelect)
			{
				instance.RemoveRedDotAttributeItem(uniqueId);
			}
			instance.SaveNewAttributeItemUniqueIdList();
			instance.SaveRedDotAttributeItemUniqueIdList();
		}

		// Token: 0x0602E59E RID: 189854 RVA: 0x00CEEF0B File Offset: 0x00CED10B
		private void RefreshNew(PhantomItemData itemData)
		{
			InventoryModel.Instance.RemoveNewAttributeItem(itemData.GetUniqueId());
		}

		// Token: 0x0602E59F RID: 189855 RVA: 0x00CEEF20 File Offset: 0x00CED120
		private void RefreshSelect(PhantomItemData itemData)
		{
			int gridIndex = this.AllData.IndexOf(itemData);
			if (this.ItemScroll.IsGridDisplaying(gridIndex))
			{
				this.ItemScroll.RefreshGridProxy(gridIndex);
			}
		}

		// Token: 0x0602E5A0 RID: 189856 RVA: 0x00CEEF54 File Offset: 0x00CED154
		private void RefreshBtn()
		{
			InventoryDefine.EItemDataFunctionValue? allSameState = this.CheckSelectStateSame();
			this.AllSameState = allSameState;
			string textId = (this.AllSameState.GetValueOrDefault() == InventoryDefine.EItemDataFunctionValue.Lock) ? "PhantomManage_UnLock" : "PhantomManage_Lock";
			this.BtnLock.SetLocalTextNew(textId, Array.Empty<object>());
			string textId2 = (this.AllSameState.GetValueOrDefault() == InventoryDefine.EItemDataFunctionValue.Deprecate) ? "PhantomManage_Reset" : "PhantomManage_Discard";
			this.BtnDispose.SetLocalTextNew(textId2, Array.Empty<object>());
		}

		// Token: 0x0602E5A1 RID: 189857 RVA: 0x00CEEFC7 File Offset: 0x00CED1C7
		private void OnViewModelUpdate(EPhantomManageViewData data)
		{
			if (data == EPhantomManageViewData.SelectSet)
			{
				this.RefreshBtn();
			}
		}

		// Token: 0x0602E5A2 RID: 189858 RVA: 0x00CEEFD4 File Offset: 0x00CED1D4
		private int ComparePhantomDefaultSort(PhantomItemData dataA, PhantomItemData dataB)
		{
			PhantomBattleModel instance = PhantomBattleModel.Instance;
			PhantomBattleData phantomBattleData = instance.GetPhantomBattleData(dataA.GetUniqueId());
			int num = (phantomBattleData != null) ? phantomBattleData.GetQuality() : 0;
			PhantomBattleData phantomBattleData2 = instance.GetPhantomBattleData(dataB.GetUniqueId());
			int num2 = (phantomBattleData2 != null) ? phantomBattleData2.GetQuality() : 0;
			if (num != num2)
			{
				return num2 - num;
			}
			int configId = dataA.GetConfigId();
			int configId2 = dataB.GetConfigId();
			if (configId != configId2)
			{
				return configId2 - configId;
			}
			return dataB.GetUniqueId() - dataA.GetUniqueId();
		}

		// Token: 0x0602E5A3 RID: 189859 RVA: 0x00CEF044 File Offset: 0x00CED244
		private void OnFilterSortRefresh(List<PhantomItemData> list, bool isOutSideChange, EFilterSortType operationType)
		{
			if (!isOutSideChange)
			{
				this.ResetSelectOnFilter();
			}
			list.Sort(new Comparison<PhantomItemData>(this.ComparePhantomDefaultSort));
			this.AllData = list;
			this.ItemScroll.RefreshByData(list, false, null, false);
			this.ItemTipsComponent.SetVisible(this.AllData.Count > 0);
			base.GetItem(16).SetUIActive(this.AllData.Count <= 0);
			if (this.AllData.Count <= 0)
			{
				return;
			}
			if (this.OpenParamId > 0)
			{
				this.RefreshOpenParamItem();
				return;
			}
			PhantomItemData phantomItemData = this.AllData[0];
			this.RefreshTipsGrid(phantomItemData.GetUniqueId());
			this.RefreshTips(phantomItemData);
		}

		// Token: 0x0602E5A4 RID: 189860 RVA: 0x00CEF0FC File Offset: 0x00CED2FC
		private void RefreshOpenParamItem()
		{
			for (int i = 0; i < this.AllData.Count; i++)
			{
				PhantomItemData phantomItemData = this.AllData[i];
				if (phantomItemData.GetUniqueId() == this.OpenParamId)
				{
					this.ItemScroll.RefreshGridProxy(i);
					this.RefreshItem(phantomItemData);
					this.ItemScroll.ScrollToGridIndex(i, true);
					break;
				}
			}
			this.OpenParamId = 0;
		}

		// Token: 0x0602E5A5 RID: 189861 RVA: 0x00CEF164 File Offset: 0x00CED364
		private void RefreshTipsGrid(int newUniqueId)
		{
			int selectId = this.SelectId;
			this.SelectId = newUniqueId;
			for (int i = 0; i < this.AllData.Count; i++)
			{
				int uniqueId = this.AllData[i].GetUniqueId();
				if (selectId == uniqueId || this.SelectId == uniqueId)
				{
					this.ItemScroll.RefreshGridProxy(i);
				}
			}
		}

		// Token: 0x0602E5A6 RID: 189862 RVA: 0x00CEF1C0 File Offset: 0x00CED3C0
		private void OnItemFuncValueChange(int changeId)
		{
			this.RefreshBtn();
			for (int i = 0; i < this.AllData.Count; i++)
			{
				int uniqueId = this.AllData[i].GetUniqueId();
				if (changeId == uniqueId)
				{
					this.ItemScroll.RefreshGridProxy(i);
					return;
				}
			}
		}

		// Token: 0x0602E5A7 RID: 189863 RVA: 0x00CEF20C File Offset: 0x00CED40C
		private void OnItemFuncValueBatchChange(IReadOnlyList<int> uniqueIdList)
		{
			for (int i = 0; i < this.AllData.Count; i++)
			{
				int uniqueId = this.AllData[i].GetUniqueId();
				bool flag = false;
				using (IEnumerator<int> enumerator = uniqueIdList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == uniqueId)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					this.ItemScroll.RefreshGridProxy(i);
				}
			}
			this.RefreshBtn();
		}

		// Token: 0x0602E5A8 RID: 189864 RVA: 0x00CEF294 File Offset: 0x00CED494
		private void OnListenerFocus(PhantomItemData data)
		{
			this.RefreshTipsGrid(data.GetUniqueId());
			this.RefreshTips(data);
		}

		// Token: 0x0602E5A9 RID: 189865 RVA: 0x00CEF2A9 File Offset: 0x00CED4A9
		private bool CheckItemSelect(PhantomItemData data)
		{
			return this.ViewModel.GetSelectSet().Contains(data.GetUniqueId());
		}

		// Token: 0x0602E5AA RID: 189866 RVA: 0x00CEF2C1 File Offset: 0x00CED4C1
		private bool CheckItemTips(PhantomItemData data)
		{
			return data.GetUniqueId() == this.SelectId;
		}

		// Token: 0x0602E5AB RID: 189867 RVA: 0x00CEF2D4 File Offset: 0x00CED4D4
		private InventoryDefine.EItemDataFunctionValue? CheckSelectStateSame()
		{
			HashSet<int> selectSet = this.ViewModel.GetSelectSet();
			if (selectSet.Count == 0)
			{
				InventoryDefine.EItemDataFunctionValue? result = null;
				return result;
			}
			InventoryDefine.EItemDataFunctionValue? eitemDataFunctionValue = null;
			foreach (int uniqueId in selectSet)
			{
				InventoryDefine.EItemDataFunctionValue functionValueType = InventoryModel.Instance.GetPhantomItemData(uniqueId).GetFunctionValueType();
				if (eitemDataFunctionValue == null)
				{
					eitemDataFunctionValue = new InventoryDefine.EItemDataFunctionValue?(functionValueType);
				}
				else
				{
					InventoryDefine.EItemDataFunctionValue eitemDataFunctionValue2 = functionValueType;
					InventoryDefine.EItemDataFunctionValue? result = eitemDataFunctionValue;
					if (!(eitemDataFunctionValue2 == result.GetValueOrDefault() & result != null))
					{
						result = null;
						return result;
					}
				}
			}
			return eitemDataFunctionValue;
		}

		// Token: 0x0602E5AC RID: 189868 RVA: 0x00CEF390 File Offset: 0x00CED590
		private bool CheckSelectHasLock(HashSet<int> uniqueIdSet)
		{
			if (uniqueIdSet.Count == 0)
			{
				return false;
			}
			foreach (int uniqueId in uniqueIdSet)
			{
				if (InventoryModel.Instance.GetPhantomItemData(uniqueId).GetFunctionValueType() == InventoryDefine.EItemDataFunctionValue.Lock)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602E5AD RID: 189869 RVA: 0x00CEF3FC File Offset: 0x00CED5FC
		private bool OnItemCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			return isForceSelected;
		}

		// Token: 0x0602E5AE RID: 189870 RVA: 0x00CEF400 File Offset: 0x00CED600
		private void OnClickedItem(MediumItemGridExtendCallback callbackData)
		{
			PhantomItemData phantomItemData = callbackData.Data as PhantomItemData;
			this.ViewModel.SwitchSelectState(phantomItemData.GetUniqueId(), false);
			this.RefreshTipsGrid(phantomItemData.GetUniqueId());
			this.RefreshItem(phantomItemData);
		}

		// Token: 0x0602E5AF RID: 189871 RVA: 0x00CEF43E File Offset: 0x00CED63E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
			EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnItemFuncValueBatchChange, new Action<IReadOnlyList<int>>(this.OnItemFuncValueBatchChange));
		}

		// Token: 0x0602E5B0 RID: 189872 RVA: 0x00CEF478 File Offset: 0x00CED678
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
			EventSystem.Instance.Remove(EEventName.OnItemFuncValueBatchChange, new Action<IReadOnlyList<int>>(this.OnItemFuncValueBatchChange));
		}

		// Token: 0x0602E5B1 RID: 189873 RVA: 0x00CEF4B2 File Offset: 0x00CED6B2
		private PhantomManageMediumItemGrid InitItem()
		{
			PhantomManageMediumItemGrid phantomManageMediumItemGrid = new PhantomManageMediumItemGrid();
			phantomManageMediumItemGrid.SetUseFixedAsync(true);
			phantomManageMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickedItem));
			phantomManageMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnItemCanExecuteChange));
			return phantomManageMediumItemGrid;
		}

		// Token: 0x0602E5B2 RID: 189874 RVA: 0x00CEF4E4 File Offset: 0x00CED6E4
		private void ClearFilterData()
		{
			int filterIdConst = InventoryModel.Instance.GetFilterIdConst();
			FilterStorageData data = new FilterStorageData
			{
				ConfigId = filterIdConst,
				SelectRuleMap = new Dictionary<FilterDefine.EFilterType, List<int>>()
			};
			FilterModel.Instance.SetFilterConfigData(EFilterSortConfigId.PhantomManage, 43, data, "");
		}

		// Token: 0x0602E5B3 RID: 189875 RVA: 0x00CEF527 File Offset: 0x00CED727
		private void OnClickedBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602E5B4 RID: 189876 RVA: 0x00CEF530 File Offset: 0x00CED730
		private void OnClickedBtnSelectAll(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				foreach (PhantomItemData phantomItemData in this.AllData)
				{
					this.ViewModel.SetSelectState(phantomItemData.GetUniqueId(), true, false);
				}
				this.ItemScroll.RefreshAllGridProxies();
				return;
			}
			this.OnClickedBtnClearSelect();
		}

		// Token: 0x0602E5B5 RID: 189877 RVA: 0x00CEF5A8 File Offset: 0x00CED7A8
		private void OnClickedBtnClearSelect()
		{
			foreach (int uniqueId in this.ViewModel.GetSelectSet())
			{
				this.ViewModel.SetSelectState(uniqueId, false, false);
			}
			this.ItemScroll.RefreshAllGridProxies();
			base.GetExtendToggle(12).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602E5B6 RID: 189878 RVA: 0x00CEF624 File Offset: 0x00CED824
		private void ResetSelectOnFilter()
		{
			if (this.ViewModel.GetSelectSet().Count > 0)
			{
				this.ViewModel.ClearSelectSet();
			}
			base.GetExtendToggle(12).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602E5B7 RID: 189879 RVA: 0x00CEF658 File Offset: 0x00CED858
		private void OnClickedBtnLock(int __)
		{
			if (this.CheckSelectStateSame().GetValueOrDefault() != InventoryDefine.EItemDataFunctionValue.Lock)
			{
				this.OnLockConfirm();
				return;
			}
			this.OnResetConfirm(true);
		}

		// Token: 0x0602E5B8 RID: 189880 RVA: 0x00CEF688 File Offset: 0x00CED888
		private void OnClickedBtnDispose(int __)
		{
			if (this.CheckSelectStateSame().GetValueOrDefault() != InventoryDefine.EItemDataFunctionValue.Deprecate)
			{
				this.ShowDisposeConfirm();
				return;
			}
			this.OnResetConfirm(false);
		}

		// Token: 0x0602E5B9 RID: 189881 RVA: 0x00CEF6B8 File Offset: 0x00CED8B8
		private void ShowDisposeConfirm()
		{
			HashSet<int> selectSet = this.ViewModel.GetSelectSet();
			if (selectSet.Count <= 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomManage_Tips01", Array.Empty<object>());
				return;
			}
			if (this.CheckSelectHasLock(selectSet))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomManageBatchDisposeConfirm);
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					this.OnDisposeConfirm();
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.OnDisposeConfirm();
		}

		// Token: 0x0602E5BA RID: 189882 RVA: 0x00CEF730 File Offset: 0x00CED930
		private UniTask OnDisposeConfirm()
		{
			PhantomManageView.<OnDisposeConfirm>d__52 <OnDisposeConfirm>d__;
			<OnDisposeConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDisposeConfirm>d__.<>4__this = this;
			<OnDisposeConfirm>d__.<>1__state = -1;
			<OnDisposeConfirm>d__.<>t__builder.Start<PhantomManageView.<OnDisposeConfirm>d__52>(ref <OnDisposeConfirm>d__);
			return <OnDisposeConfirm>d__.<>t__builder.Task;
		}

		// Token: 0x0602E5BB RID: 189883 RVA: 0x00CEF774 File Offset: 0x00CED974
		private UniTask OnLockConfirm()
		{
			PhantomManageView.<OnLockConfirm>d__53 <OnLockConfirm>d__;
			<OnLockConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnLockConfirm>d__.<>4__this = this;
			<OnLockConfirm>d__.<>1__state = -1;
			<OnLockConfirm>d__.<>t__builder.Start<PhantomManageView.<OnLockConfirm>d__53>(ref <OnLockConfirm>d__);
			return <OnLockConfirm>d__.<>t__builder.Task;
		}

		// Token: 0x0602E5BC RID: 189884 RVA: 0x00CEF7B8 File Offset: 0x00CED9B8
		private UniTask OnResetConfirm(bool fromLock)
		{
			PhantomManageView.<OnResetConfirm>d__54 <OnResetConfirm>d__;
			<OnResetConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnResetConfirm>d__.<>4__this = this;
			<OnResetConfirm>d__.fromLock = fromLock;
			<OnResetConfirm>d__.<>1__state = -1;
			<OnResetConfirm>d__.<>t__builder.Start<PhantomManageView.<OnResetConfirm>d__54>(ref <OnResetConfirm>d__);
			return <OnResetConfirm>d__.<>t__builder.Task;
		}

		// Token: 0x0602E5BD RID: 189885 RVA: 0x00CEF804 File Offset: 0x00CEDA04
		private void OnClickedBtnConfig()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomManageConfigView) || UiManager.Instance.IsViewHide(EUiViewName.PhantomManageConfigView))
			{
				UiManager.Instance.CloseView(EUiViewName.PhantomManageConfigView, new Action<bool>(this.OnCloseManageConfigView));
				return;
			}
			this.OnCloseManageConfigView(true);
		}

		// Token: 0x0602E5BE RID: 189886 RVA: 0x00CEF856 File Offset: 0x00CEDA56
		private void OnCloseManageConfigView(bool success)
		{
			if (success)
			{
				InventoryController.Instance.OpenManageConfigView();
			}
		}

		// Token: 0x0602E5BF RID: 189887 RVA: 0x00CEF865 File Offset: 0x00CEDA65
		private void OnClickedBtnManage()
		{
			CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRecoveryTabView, null);
		}

		// Token: 0x0602E5C0 RID: 189888 RVA: 0x00CEF877 File Offset: 0x00CEDA77
		private void OnClickedBtnSmartDiscard()
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomSmartDiscardPopupView, null, delegate(bool success, int viewId)
			{
				UiViewBase uiViewBase = null;
				if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomManageView))
				{
					uiViewBase = UiManager.Instance.GetViewByName(EUiViewName.PhantomManageView);
				}
				else if (UiManager.Instance.IsViewOpen(EUiViewName.InventoryView))
				{
					uiViewBase = UiManager.Instance.GetViewByName(EUiViewName.InventoryView);
				}
				if (uiViewBase != null)
				{
					uiViewBase.AddChildViewById(viewId);
				}
			});
		}

		// Token: 0x0602E5C1 RID: 189889 RVA: 0x00CEF8A8 File Offset: 0x00CEDAA8
		private void OnToggleShowStrengthened(EToggleState state)
		{
			this.ShowStrengthened = (state == EToggleState.ETT_Checked);
			this.RefreshList();
			this.RefreshBtn();
		}

		// Token: 0x04018AFE RID: 101118
		private int OpenParamId;

		// Token: 0x04018AFF RID: 101119
		private int SelectId;

		// Token: 0x04018B00 RID: 101120
		private InventoryDefine.EItemDataFunctionValue? AllSameState;

		// Token: 0x04018B01 RID: 101121
		private List<PhantomItemData> AllData = new List<PhantomItemData>();

		// Token: 0x04018B02 RID: 101122
		[Nullable(2)]
		private PhantomManageViewModel ViewModel;

		// Token: 0x04018B03 RID: 101123
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PhantomManageMediumItemGrid, PhantomItemData> ItemScroll;

		// Token: 0x04018B04 RID: 101124
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterEntrance<PhantomItemData> FilterEntrance;

		// Token: 0x04018B05 RID: 101125
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04018B06 RID: 101126
		[Nullable(2)]
		private ItemTipsWithButtonComponent ItemTipsComponent;

		// Token: 0x04018B07 RID: 101127
		[Nullable(2)]
		private ButtonItem BtnLock;

		// Token: 0x04018B08 RID: 101128
		[Nullable(2)]
		private ButtonItem BtnDispose;

		// Token: 0x04018B09 RID: 101129
		private bool ShowStrengthened;
	}
}
