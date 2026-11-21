using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Cook.View;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.Manufacture.Common.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004ADC RID: 19164
	[NullableContext(1)]
	[Nullable(0)]
	public class CookingIngredientsVerticalView : UiPanelBase
	{
		// Token: 0x17006012 RID: 24594
		// (get) Token: 0x0602FEB8 RID: 196280 RVA: 0x00D5F42F File Offset: 0x00D5D62F
		public int CurrentSetCount
		{
			get
			{
				return this.Count;
			}
		}

		// Token: 0x0602FEB9 RID: 196281 RVA: 0x00D5F438 File Offset: 0x00D5D638
		protected unsafe override void OnRegisterComponent()
		{
			int num = 22;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0602FEBA RID: 196282 RVA: 0x00D5F754 File Offset: 0x00D5D954
		protected override UniTask OnBeforeStartAsync()
		{
			CookingIngredientsVerticalView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CookingIngredientsVerticalView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FEBB RID: 196283 RVA: 0x00D5F798 File Offset: 0x00D5D998
		protected override void OnStart()
		{
			base.GetItem(18).SetUIActive(false);
			base.GetItem(1).SetUIActive(false);
			base.GetItem(16).SetUIActive(true);
			base.GetItem(18).SetUIActive(true);
			base.GetItem(22).SetUIActive(false);
			base.GetText(23).ShowTextNew("NeedMaterialTitleText");
			base.GetText(17).ShowTextNew("PrefabTextItem_MaterialChoose_Text");
			UUIItem item = base.GetItem(8);
			this.NumberSelect = new NumberSelectComponent(item);
			INumberSelectData data = new INumberSelectData
			{
				MaxNumber = 0,
				ValueChangeFunction = new Action<int>(this.SetSum)
			};
			this.NumberSelect.Init(data);
			this.NumberSelect.SetUiActive(true);
			this.NumberSelect.SetNumberSelectTipsVisible(false);
			this.NumberSelect.SetAddReduceButtonActive(true);
			base.GetText(12).SetUIActive(false);
			this.UnlockMaterialComponent = new MediumItemGrid();
			this.UnlockMaterialComponent.Initialize(base.GetItem(21).GetOwner());
			this.UnlockMaterialComponent.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.UnlockMaterialComponent.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				int itemId = (int)callbackParameter.Data;
				ItemController.Instance.OpenItemTipsByItemId(itemId, true, null, false);
			});
		}

		// Token: 0x0602FEBC RID: 196284 RVA: 0x00D5F8F6 File Offset: 0x00D5DAF6
		protected override void OnBeforeDestroy()
		{
			this.SvInfoView = null;
			this.MaterialScrollView = null;
			this.OnChangeMaterialSelectionDelegate = null;
		}

		// Token: 0x0602FEBD RID: 196285 RVA: 0x00D5F910 File Offset: 0x00D5DB10
		private ManufactureMaterialItem OnMaterialItemCreate()
		{
			ManufactureMaterialItem manufactureMaterialItem = new ManufactureMaterialItem();
			manufactureMaterialItem.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			manufactureMaterialItem.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				ISingleItemInfo singleItemInfo = callbackParameter.Data as ISingleItemInfo;
				if (singleItemInfo.Proto_IsUnlock)
				{
					ItemController.Instance.OpenItemTipsByItemId(singleItemInfo.Proto_ItemId, true, null, false);
					return;
				}
				ScrollingTipsController.Instance.ShowTipsById("ItemSelectCookUnlockTip", Array.Empty<object>());
			});
			return manufactureMaterialItem;
		}

		// Token: 0x0602FEBE RID: 196286 RVA: 0x00D5F96C File Offset: 0x00D5DB6C
		private void OnClickChangeRole()
		{
			EventSystem.Instance.Emit<int>(EEventName.OpenCookRole, this.ItemData.ItemId);
		}

		// Token: 0x0602FEBF RID: 196287 RVA: 0x00D5F98C File Offset: 0x00D5DB8C
		private void SetSum(int sum)
		{
			this.Count = sum;
			this.RefreshMaterialNeedNum();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Text_ItemSelectCookQuantityTip_text", new <>z__ReadOnlySingleElementList<object>(this.Count));
			if (this.ItemData != null && this.ItemData.MainType == ECookListType.Cooking)
			{
				this.RefreshProficiency((ICookingData)this.ItemData, this.Count);
			}
			if (this.ItemData != null)
			{
				int maxCreateCount = CookController.Instance.GetMaxCreateCount(this.ItemData.ItemId, this.ItemData.MainType);
				this.NumberSelect.SetAddButtonInteractive(sum < maxCreateCount);
				this.NumberSelect.SetReduceButtonInteractive(sum > 1);
			}
		}

		// Token: 0x0602FEC0 RID: 196288 RVA: 0x00D5FA40 File Offset: 0x00D5DC40
		private bool CheckDataValid(object itemData)
		{
			if (itemData == null)
			{
				Log.Instance.Error(ELogModule.Cook, ELogAuthor.LK, "缺少itemData数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x0602FEC1 RID: 196289 RVA: 0x00D5FA74 File Offset: 0x00D5DC74
		private void SetRecommendedRoleTexture(ICookingData itemData)
		{
			if (!this.CheckDataValid(itemData))
			{
				return;
			}
			int? currentCookRoleId = CookModel.Instance.CurrentCookRoleId;
			if (currentCookRoleId == null)
			{
				currentCookRoleId = new int?(CookModel.Instance.GetCookRoleId(itemData.ItemId));
				CookModel.Instance.CurrentCookRoleId = currentCookRoleId;
			}
			this.ProficiencyViewComponent.SetRoleTexture(currentCookRoleId.Value, itemData.ItemId);
		}

		// Token: 0x0602FEC2 RID: 196290 RVA: 0x00D5FADC File Offset: 0x00D5DCDC
		private void RefreshMaterialNeedNum()
		{
			this.RefreshCost(this.HasCoin, this.SingleNeedCoinCount * this.Count);
			GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView = this.MaterialScrollView;
			List<ManufactureMaterialItem> list = (materialScrollView != null) ? materialScrollView.GetScrollItemList() : null;
			if (list == null)
			{
				return;
			}
			foreach (ManufactureMaterialItem manufactureMaterialItem in list)
			{
				manufactureMaterialItem.SetTimes(this.Count);
			}
		}

		// Token: 0x0602FEC3 RID: 196291 RVA: 0x00D5FB60 File Offset: 0x00D5DD60
		private void SetTypeName(string tag, ECookListType cookType)
		{
			string textById = TextConfig.Instance.GetTextById(tag);
			if (cookType == ECookListType.Cooking)
			{
				this.SvInfoView.SetTypeName(null);
				this.ProficiencyViewComponent.SetTypeContent(textById);
				return;
			}
			if (cookType != ECookListType.Machining)
			{
				this.SvInfoView.SetTypeName(null);
				this.ProficiencyViewComponent.SetTypeContent(null);
				return;
			}
			this.SvInfoView.SetTypeName(textById);
			this.ProficiencyViewComponent.SetTypeContent(null);
		}

		// Token: 0x0602FEC4 RID: 196292 RVA: 0x00D5FBCC File Offset: 0x00D5DDCC
		private void RefreshLimitTime(ICookingData itemData)
		{
			if (itemData.ExistEndTime <= 0.0)
			{
				base.GetItem(24).SetUIActive(false);
				this.NumberSelect.ResetLimitMaxValue();
				return;
			}
			base.GetItem(24).SetUIActive(true);
			global::CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat(itemData.ExistEndTime - TimeUtil.Instance.GetServerTime());
			base.GetText(25).SetText(remainTimeDataFormat.CountDownText, true);
		}

		// Token: 0x0602FEC5 RID: 196293 RVA: 0x00D5FC44 File Offset: 0x00D5DE44
		[NullableContext(2)]
		private void RefreshLimitCount(ICookingData itemData = null)
		{
			if (itemData == null || itemData.LimitTotalCount <= 0)
			{
				base.GetItem(3).SetUIActive(false);
				this.NumberSelect.ResetLimitMaxValue();
				return;
			}
			int num = itemData.LimitTotalCount - itemData.CookCount;
			this.NumberSelect.SetLimitMaxValue(Math.Max(1, num));
			string text = num.ToString();
			if (num == 0)
			{
				text = StringUtils.Format("<color=#c25757>{0}</color>", new string[]
				{
					num.ToString()
				});
			}
			base.GetItem(3).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "MakeLimit", new <>z__ReadOnlyArray<object>(new object[]
			{
				text,
				itemData.LimitTotalCount
			}));
		}

		// Token: 0x0602FEC6 RID: 196294 RVA: 0x00D5FCFC File Offset: 0x00D5DEFC
		private void RefreshCost(bool hasCoin, int count)
		{
			base.GetText(12).GetParentAsUIItem().SetUIActive(hasCoin);
			if (hasCoin)
			{
				int commonItemCount = InventoryModel.Instance.GetCommonItemCount(CookController.Instance.CookCoinId, 0);
				ItemInfo? config = ItemConfig.Instance.GetConfig(CookController.Instance.CookCoinId);
				if (commonItemCount < count)
				{
					base.GetText(11).SetText(StringUtils.Format("<color=#c25757>{0}</color>", new string[]
					{
						count.ToString()
					}), true);
				}
				else
				{
					base.GetText(11).SetText(count.ToString(), true);
				}
				base.SetTextureByPath(config.Value.IconSmall, base.GetTexture(13), null, null);
			}
		}

		// Token: 0x0602FEC7 RID: 196295 RVA: 0x00D5FDB8 File Offset: 0x00D5DFB8
		public void RefreshProficiency(ICookingData data, int times)
		{
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(data.ItemId);
			int proficiency = cookFormulaById.Proficiency;
			int maxProficiencyCount = cookFormulaById.MaxProficiencyCount;
			this.ProficiencyViewComponent.SetExpNum(data.CookCount, proficiency, maxProficiencyCount, times);
			this.SetRecommendedRoleTexture(data);
		}

		// Token: 0x0602FEC8 RID: 196296 RVA: 0x00D5FE04 File Offset: 0x00D5E004
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<bool, int, List<ISingleItemInfo>> FilterMaterialList(List<ISingleItemInfo> list)
		{
			bool item = false;
			int item2 = 0;
			List<ISingleItemInfo> list2 = new List<ISingleItemInfo>();
			foreach (ISingleItemInfo singleItemInfo in list)
			{
				if (singleItemInfo.Proto_ItemId != CookController.Instance.CookCoinId)
				{
					list2.Add(singleItemInfo);
				}
				else
				{
					item = true;
					item2 = singleItemInfo.Proto_ItemNum;
				}
			}
			return new ValueTuple<bool, int, List<ISingleItemInfo>>(item, item2, list2);
		}

		// Token: 0x0602FEC9 RID: 196297 RVA: 0x00D5FE88 File Offset: 0x00D5E088
		public void OnSecondTimerRefresh()
		{
			if (this.ItemData == null)
			{
				return;
			}
			if (this.ItemData.MainType == ECookListType.Cooking)
			{
				this.RefreshLimitTime((ICookingData)this.ItemData);
			}
		}

		// Token: 0x0602FECA RID: 196298 RVA: 0x00D5FEB4 File Offset: 0x00D5E0B4
		public void RefreshCooking(object itemData)
		{
			ICookItemData cookItemData = itemData as ICookItemData;
			if (cookItemData == null)
			{
				return;
			}
			this.ItemData = cookItemData;
			this.Count = 1;
			ICookingData cookingData = cookItemData as ICookingData;
			if (cookingData == null)
			{
				return;
			}
			this.NumberSelect.SetUiActive(cookingData.IsUnLock);
			base.GetItem(9).SetUIActive(cookingData.IsUnLock);
			this.SvInfoView.RefreshCooking(cookingData, this.Count);
			base.GetItem(26).SetUIActive(true);
			this.RefreshProficiency(cookingData, this.Count);
			this.SetTypeName("Dishes", ECookListType.Cooking);
			if (cookingData.IsUnLock)
			{
				base.GetItem(20).SetUIActive(false);
				base.GetItem(18).SetUIActive(true);
				List<ISingleItemInfo> cookMaterialList = CookModel.Instance.GetCookMaterialList(this.ItemData.ItemId, ECookListType.Cooking);
				List<ISingleItemInfo> item = this.FilterMaterialList(cookMaterialList).Item3;
				this.MaterialScrollView.RefreshByData(item, new Action(this.RefreshMaterialNeedNum), false);
				this.NumberSelect.SetUiActive(true);
				base.GetItem(9).SetUIActive(true);
				this.RefreshLimitTime((ICookingData)this.ItemData);
				this.RefreshLimitCount((ICookingData)this.ItemData);
				int maxCreateCount = CookController.Instance.GetMaxCreateCount(this.ItemData.ItemId, CookModel.Instance.CurrentCookListType);
				this.NumberSelect.Refresh(maxCreateCount);
				this.NumberSelect.SetAddReduceButtonActive(true);
				this.NumberSelect.SetReduceButtonInteractive(false);
				return;
			}
			this.RefreshLimitCount(null);
			base.GetItem(20).SetUIActive(true);
			base.GetItem(18).SetUIActive(false);
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(this.ItemData.ItemId);
			ItemInfo? config = ItemConfig.Instance.GetConfig(cookFormulaById.FormulaItemId);
			if (config == null)
			{
				return;
			}
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = cookFormulaById.FormulaItemId,
				ItemConfigId = new int?(cookFormulaById.FormulaItemId),
				BottomTextId = config.Value.Name,
				IsProhibit = new bool?(true),
				IsOmitBottomText = new bool?(true)
			};
			this.UnlockMaterialComponent.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x0602FECB RID: 196299 RVA: 0x00D600E8 File Offset: 0x00D5E2E8
		public void RefreshMachining(object itemData)
		{
			if (itemData == null)
			{
				return;
			}
			base.GetItem(20).SetUIActive(false);
			base.GetItem(18).SetUIActive(true);
			this.ItemData = (ICookItemData)itemData;
			this.SetTypeName("Accessory", ECookListType.Machining);
			this.SvInfoView.RefreshMachining((IMachiningData)this.ItemData);
			base.GetItem(26).SetUIActive(false);
			MaterialSelectionCacheData.TmpSelectedMaterialData = new List<ISelectedData>();
			this.ShowMaterialItemRemoveControl = false;
			List<ISingleItemInfo> cookMaterialList = CookModel.Instance.GetCookMaterialList(this.ItemData.ItemId, this.ItemData.MainType);
			CookModel.Instance.CreateTmpMachiningItemList(cookMaterialList);
			this.MaterialScrollView.RefreshByData(cookMaterialList, new Action(this.RefreshMaterialNeedNum), false);
			bool flag = true;
			using (List<ISingleItemInfo>.Enumerator enumerator = cookMaterialList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.Proto_IsUnlock)
					{
						flag = false;
						break;
					}
				}
			}
			this.NumberSelect.SetUiActive(flag);
			base.GetItem(9).SetUIActive(flag);
			if (!flag)
			{
				return;
			}
			int maxCreateCount = CookController.Instance.GetMaxCreateCount(this.ItemData.ItemId, CookModel.Instance.CurrentCookListType);
			this.NumberSelect.ResetLimitMaxValue();
			this.NumberSelect.Refresh(maxCreateCount);
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.NumberSelect.SetReduceButtonInteractive(false);
			base.GetItem(24).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x04019715 RID: 104213
		[Nullable(2)]
		private SvInfo SvInfoView;

		// Token: 0x04019716 RID: 104214
		[Nullable(2)]
		public ICookItemData ItemData;

		// Token: 0x04019717 RID: 104215
		[Nullable(2)]
		private NumberSelectComponent NumberSelect;

		// Token: 0x04019718 RID: 104216
		private int Count = 1;

		// Token: 0x04019719 RID: 104217
		public bool ShowMaterialItemRemoveControl;

		// Token: 0x0401971A RID: 104218
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> MaterialScrollView;

		// Token: 0x0401971B RID: 104219
		[Nullable(2)]
		private CookProficiencyView ProficiencyViewComponent;

		// Token: 0x0401971C RID: 104220
		private bool HasCoin;

		// Token: 0x0401971D RID: 104221
		private int SingleNeedCoinCount;

		// Token: 0x0401971E RID: 104222
		[Nullable(2)]
		private MediumItemGrid UnlockMaterialComponent;

		// Token: 0x0401971F RID: 104223
		[Nullable(2)]
		public Action OnChangeMaterialSelectionDelegate;

		// Token: 0x0200A74E RID: 42830
		[NullableContext(0)]
		private enum EVerticalGroupComponents
		{
			// Token: 0x04033B14 RID: 211732
			SvInfo,
			// Token: 0x04033B15 RID: 211733
			PnlLimit,
			// Token: 0x04033B16 RID: 211734
			TxtLimitNum,
			// Token: 0x04033B17 RID: 211735
			PnlQuota,
			// Token: 0x04033B18 RID: 211736
			TxtQuotaNum,
			// Token: 0x04033B19 RID: 211737
			AmountItem = 8,
			// Token: 0x04033B1A RID: 211738
			PnlCost,
			// Token: 0x04033B1B RID: 211739
			MakeCount,
			// Token: 0x04033B1C RID: 211740
			TxtCost,
			// Token: 0x04033B1D RID: 211741
			TxtPlace,
			// Token: 0x04033B1E RID: 211742
			ImgCostIcon,
			// Token: 0x04033B1F RID: 211743
			PnlTitle = 16,
			// Token: 0x04033B20 RID: 211744
			TxtMaterialBarTitle,
			// Token: 0x04033B21 RID: 211745
			PnlLeftItem,
			// Token: 0x04033B22 RID: 211746
			MaterialScrollView,
			// Token: 0x04033B23 RID: 211747
			PnlCenterItem,
			// Token: 0x04033B24 RID: 211748
			LockGrid,
			// Token: 0x04033B25 RID: 211749
			PnlLock,
			// Token: 0x04033B26 RID: 211750
			TxtLock,
			// Token: 0x04033B27 RID: 211751
			PnlLimitedTime,
			// Token: 0x04033B28 RID: 211752
			TxtTime,
			// Token: 0x04033B29 RID: 211753
			ProficiencyView
		}
	}
}
