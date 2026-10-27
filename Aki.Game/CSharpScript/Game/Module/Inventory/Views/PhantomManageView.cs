using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200583D RID: 22589
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomManageView : UiViewBase
	{
		// Token: 0x0603967F RID: 235135 RVA: 0x00D9F7D6 File Offset: 0x00D9D9D6
		public PhantomManageView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039680 RID: 235136 RVA: 0x00D9F7EC File Offset: 0x00D9D9EC
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

		// Token: 0x06039681 RID: 235137 RVA: 0x00D9FBCC File Offset: 0x00D9DDCC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomManageView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomManageView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039682 RID: 235138 RVA: 0x00D9FC10 File Offset: 0x00D9DE10
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

		// Token: 0x06039683 RID: 235139 RVA: 0x00D9FCEC File Offset: 0x00D9DEEC
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

		// Token: 0x06039684 RID: 235140 RVA: 0x00D9FD6C File Offset: 0x00D9DF6C
		private void ClearInvalidSelectItems()
		{
			foreach (int uniqueId in this.ViewModel.GetSelectSet().ToList<int>())
			{
				if (InventoryModel.Instance.GetPhantomItemData(uniqueId) == null)
				{
					this.ViewModel.GetSelectSet().Clear();
					break;
				}
			}
		}

		// Token: 0x06039685 RID: 235141 RVA: 0x00D9FDE4 File Offset: 0x00D9DFE4
		protected override void OnBeforeDestroy()
		{
			this.ViewModel.UnBind(new Action<EPhantomManageViewData>(this.OnViewModelUpdate));
			this.ViewModel.ClearSelectSet();
			this.ClearFilterData();
		}

		// Token: 0x06039686 RID: 235142 RVA: 0x00D9FE10 File Offset: 0x00D9E010
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

		// Token: 0x06039687 RID: 235143 RVA: 0x00D9FF08 File Offset: 0x00D9E108
		private void RefreshList()
		{
			IEnumerable<PhantomItemData> enumerable = InventoryModel.Instance.GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId.Phantom).Cast<PhantomItemData>();
			List<PhantomItemData> list = new List<PhantomItemData>();
			foreach (PhantomItemData phantomItemData in enumerable)
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(phantomItemData.GetUniqueId());
				if (phantomBattleData != null && (this.ShowStrengthened || phantomBattleData.GetPhantomLevel() <= 0))
				{
					list.Add(phantomItemData);
				}
			}
			this.FilterEntrance.UpdateDataWithConfig(EFilterSortGroupId.PhantomManage, EFilterSortConfigId.PhantomManage, list, "", Array.Empty<object>());
		}

		// Token: 0x06039688 RID: 235144 RVA: 0x00D9FFA4 File Offset: 0x00D9E1A4
		private void RefreshItem(PhantomItemData itemData)
		{
			this.RefreshTips(itemData);
			this.RefreshRedDot(itemData);
			this.RefreshNew(itemData);
			this.RefreshSelect(itemData);
		}

		// Token: 0x06039689 RID: 235145 RVA: 0x00D9FFC4 File Offset: 0x00D9E1C4
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

		// Token: 0x0603968A RID: 235146 RVA: 0x00DA0020 File Offset: 0x00D9E220
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

		// Token: 0x0603968B RID: 235147 RVA: 0x00DA006F File Offset: 0x00D9E26F
		private void RefreshNew(PhantomItemData itemData)
		{
			InventoryModel.Instance.RemoveNewAttributeItem(itemData.GetUniqueId());
		}

		// Token: 0x0603968C RID: 235148 RVA: 0x00DA0084 File Offset: 0x00D9E284
		private void RefreshSelect(PhantomItemData itemData)
		{
			int gridIndex = this.AllData.IndexOf(itemData);
			if (this.ItemScroll.IsGridDisplaying(gridIndex))
			{
				this.ItemScroll.RefreshGridProxy(gridIndex);
			}
		}

		// Token: 0x0603968D RID: 235149 RVA: 0x00DA00B8 File Offset: 0x00D9E2B8
		private void RefreshBtn()
		{
			InventoryDefine.EItemDataFunctionValue? allSameState = this.CheckSelectStateSame();
			this.AllSameState = allSameState;
			string textId = (this.AllSameState.GetValueOrDefault() == InventoryDefine.EItemDataFunctionValue.Lock) ? "PhantomManage_UnLock" : "PhantomManage_Lock";
			this.BtnLock.SetLocalTextNew(textId, Array.Empty<object>());
			string textId2 = (this.AllSameState.GetValueOrDefault() == InventoryDefine.EItemDataFunctionValue.Deprecate) ? "PhantomManage_Reset" : "PhantomManage_Discard";
			this.BtnDispose.SetLocalTextNew(textId2, Array.Empty<object>());
		}

		// Token: 0x0603968E RID: 235150 RVA: 0x00DA012B File Offset: 0x00D9E32B
		private void OnViewModelUpdate(EPhantomManageViewData data)
		{
			if (data == EPhantomManageViewData.SelectSet)
			{
				this.RefreshBtn();
			}
		}

		// Token: 0x0603968F RID: 235151 RVA: 0x00DA0138 File Offset: 0x00D9E338
		protected int SortViewDataSelectOn(PhantomItemData dataA, PhantomItemData dataB)
		{
			int num = (this.CheckItemSelect(dataA) > false) ? 1 : 0;
			return ((this.CheckItemSelect(dataB) > false) ? 1 : 0) - num;
		}

		// Token: 0x06039690 RID: 235152 RVA: 0x00DA015C File Offset: 0x00D9E35C
		private void OnFilterSortRefresh(List<PhantomItemData> list, bool isOutSideChange, EFilterSortType operationType)
		{
			HashSet<int> selectSet = this.ViewModel.GetSelectSet();
			if (selectSet != null && selectSet.Count > 0)
			{
				list.Sort(new Comparison<PhantomItemData>(this.SortViewDataSelectOn));
			}
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

		// Token: 0x06039691 RID: 235153 RVA: 0x00DA0224 File Offset: 0x00D9E424
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

		// Token: 0x06039692 RID: 235154 RVA: 0x00DA028C File Offset: 0x00D9E48C
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

		// Token: 0x06039693 RID: 235155 RVA: 0x00DA02E8 File Offset: 0x00D9E4E8
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

		// Token: 0x06039694 RID: 235156 RVA: 0x00DA0334 File Offset: 0x00D9E534
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

		// Token: 0x06039695 RID: 235157 RVA: 0x00DA03BC File Offset: 0x00D9E5BC
		private void OnListenerFocus(PhantomItemData data)
		{
			this.RefreshTipsGrid(data.GetUniqueId());
			this.RefreshTips(data);
		}

		// Token: 0x06039696 RID: 235158 RVA: 0x00DA03D1 File Offset: 0x00D9E5D1
		private bool CheckItemSelect(PhantomItemData data)
		{
			return this.ViewModel.GetSelectSet().Contains(data.GetUniqueId());
		}

		// Token: 0x06039697 RID: 235159 RVA: 0x00DA03E9 File Offset: 0x00D9E5E9
		private bool CheckItemTips(PhantomItemData data)
		{
			return data.GetUniqueId() == this.SelectId;
		}

		// Token: 0x06039698 RID: 235160 RVA: 0x00DA03FC File Offset: 0x00D9E5FC
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

		// Token: 0x06039699 RID: 235161 RVA: 0x00DA04B8 File Offset: 0x00D9E6B8
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

		// Token: 0x0603969A RID: 235162 RVA: 0x00DA0524 File Offset: 0x00D9E724
		private bool OnItemCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			return isForceSelected;
		}

		// Token: 0x0603969B RID: 235163 RVA: 0x00DA0528 File Offset: 0x00D9E728
		private void OnClickedItem(MediumItemGridExtendCallback callbackData)
		{
			PhantomItemData phantomItemData = callbackData.Data as PhantomItemData;
			this.ViewModel.SwitchSelectState(phantomItemData.GetUniqueId(), false);
			this.RefreshTipsGrid(phantomItemData.GetUniqueId());
			this.RefreshItem(phantomItemData);
		}

		// Token: 0x0603969C RID: 235164 RVA: 0x00DA0566 File Offset: 0x00D9E766
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
			EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnItemFuncValueBatchChange, new Action<IReadOnlyList<int>>(this.OnItemFuncValueBatchChange));
		}

		// Token: 0x0603969D RID: 235165 RVA: 0x00DA05A0 File Offset: 0x00D9E7A0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
			EventSystem.Instance.Remove(EEventName.OnItemFuncValueBatchChange, new Action<IReadOnlyList<int>>(this.OnItemFuncValueBatchChange));
		}

		// Token: 0x0603969E RID: 235166 RVA: 0x00DA05DA File Offset: 0x00D9E7DA
		private PhantomManageMediumItemGrid InitItem()
		{
			PhantomManageMediumItemGrid phantomManageMediumItemGrid = new PhantomManageMediumItemGrid();
			phantomManageMediumItemGrid.SetUseFixedAsync(true);
			phantomManageMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickedItem));
			phantomManageMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnItemCanExecuteChange));
			return phantomManageMediumItemGrid;
		}

		// Token: 0x0603969F RID: 235167 RVA: 0x00DA060C File Offset: 0x00D9E80C
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

		// Token: 0x060396A0 RID: 235168 RVA: 0x00DA064F File Offset: 0x00D9E84F
		private void OnClickedBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060396A1 RID: 235169 RVA: 0x00DA0658 File Offset: 0x00D9E858
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

		// Token: 0x060396A2 RID: 235170 RVA: 0x00DA06D0 File Offset: 0x00D9E8D0
		private void OnClickedBtnClearSelect()
		{
			foreach (int uniqueId in this.ViewModel.GetSelectSet())
			{
				this.ViewModel.SetSelectState(uniqueId, false, false);
			}
			this.ItemScroll.RefreshAllGridProxies();
			base.GetExtendToggle(12).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060396A3 RID: 235171 RVA: 0x00DA074C File Offset: 0x00D9E94C
		private void OnClickedBtnLock(int __)
		{
			if (this.CheckSelectStateSame().GetValueOrDefault() != InventoryDefine.EItemDataFunctionValue.Lock)
			{
				this.OnLockConfirm();
				return;
			}
			this.OnResetConfirm(true);
		}

		// Token: 0x060396A4 RID: 235172 RVA: 0x00DA077C File Offset: 0x00D9E97C
		private void OnClickedBtnDispose(int __)
		{
			if (this.CheckSelectStateSame().GetValueOrDefault() != InventoryDefine.EItemDataFunctionValue.Deprecate)
			{
				this.ShowDisposeConfirm();
				return;
			}
			this.OnResetConfirm(false);
		}

		// Token: 0x060396A5 RID: 235173 RVA: 0x00DA07AC File Offset: 0x00D9E9AC
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

		// Token: 0x060396A6 RID: 235174 RVA: 0x00DA0824 File Offset: 0x00D9EA24
		private UniTask OnDisposeConfirm()
		{
			PhantomManageView.<OnDisposeConfirm>d__51 <OnDisposeConfirm>d__;
			<OnDisposeConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDisposeConfirm>d__.<>4__this = this;
			<OnDisposeConfirm>d__.<>1__state = -1;
			<OnDisposeConfirm>d__.<>t__builder.Start<PhantomManageView.<OnDisposeConfirm>d__51>(ref <OnDisposeConfirm>d__);
			return <OnDisposeConfirm>d__.<>t__builder.Task;
		}

		// Token: 0x060396A7 RID: 235175 RVA: 0x00DA0868 File Offset: 0x00D9EA68
		private UniTask OnLockConfirm()
		{
			PhantomManageView.<OnLockConfirm>d__52 <OnLockConfirm>d__;
			<OnLockConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnLockConfirm>d__.<>4__this = this;
			<OnLockConfirm>d__.<>1__state = -1;
			<OnLockConfirm>d__.<>t__builder.Start<PhantomManageView.<OnLockConfirm>d__52>(ref <OnLockConfirm>d__);
			return <OnLockConfirm>d__.<>t__builder.Task;
		}

		// Token: 0x060396A8 RID: 235176 RVA: 0x00DA08AC File Offset: 0x00D9EAAC
		private UniTask OnResetConfirm(bool fromLock)
		{
			PhantomManageView.<OnResetConfirm>d__53 <OnResetConfirm>d__;
			<OnResetConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnResetConfirm>d__.<>4__this = this;
			<OnResetConfirm>d__.fromLock = fromLock;
			<OnResetConfirm>d__.<>1__state = -1;
			<OnResetConfirm>d__.<>t__builder.Start<PhantomManageView.<OnResetConfirm>d__53>(ref <OnResetConfirm>d__);
			return <OnResetConfirm>d__.<>t__builder.Task;
		}

		// Token: 0x060396A9 RID: 235177 RVA: 0x00DA08F8 File Offset: 0x00D9EAF8
		private void OnClickedBtnConfig()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomManageConfigView) || UiManager.Instance.IsViewHide(EUiViewName.PhantomManageConfigView))
			{
				UiManager.Instance.CloseView(EUiViewName.PhantomManageConfigView, new Action<bool>(this.OnCloseManageConfigView));
				return;
			}
			this.OnCloseManageConfigView(true);
		}

		// Token: 0x060396AA RID: 235178 RVA: 0x00DA094A File Offset: 0x00D9EB4A
		private void OnCloseManageConfigView(bool success)
		{
			if (success)
			{
				InventoryController.Instance.OpenManageConfigView();
			}
		}

		// Token: 0x060396AB RID: 235179 RVA: 0x00DA0959 File Offset: 0x00D9EB59
		private void OnClickedBtnManage()
		{
			CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRecoveryTabView, null);
		}

		// Token: 0x060396AC RID: 235180 RVA: 0x00DA096B File Offset: 0x00D9EB6B
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

		// Token: 0x060396AD RID: 235181 RVA: 0x00DA099C File Offset: 0x00D9EB9C
		private void OnToggleShowStrengthened(EToggleState state)
		{
			this.ShowStrengthened = (state == EToggleState.ETT_Checked);
			this.RefreshList();
			this.RefreshBtn();
		}

		// Token: 0x0401E065 RID: 122981
		private int OpenParamId;

		// Token: 0x0401E066 RID: 122982
		private int SelectId;

		// Token: 0x0401E067 RID: 122983
		private InventoryDefine.EItemDataFunctionValue? AllSameState;

		// Token: 0x0401E068 RID: 122984
		private List<PhantomItemData> AllData = new List<PhantomItemData>();

		// Token: 0x0401E069 RID: 122985
		[Nullable(2)]
		private PhantomManageViewModel ViewModel;

		// Token: 0x0401E06A RID: 122986
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PhantomManageMediumItemGrid, PhantomItemData> ItemScroll;

		// Token: 0x0401E06B RID: 122987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterEntrance<PhantomItemData> FilterEntrance;

		// Token: 0x0401E06C RID: 122988
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401E06D RID: 122989
		[Nullable(2)]
		private ItemTipsWithButtonComponent ItemTipsComponent;

		// Token: 0x0401E06E RID: 122990
		[Nullable(2)]
		private ButtonItem BtnLock;

		// Token: 0x0401E06F RID: 122991
		[Nullable(2)]
		private ButtonItem BtnDispose;

		// Token: 0x0401E070 RID: 122992
		private bool ShowStrengthened;
	}
}
