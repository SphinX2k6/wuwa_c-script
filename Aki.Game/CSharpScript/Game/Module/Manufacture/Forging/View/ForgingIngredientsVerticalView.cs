using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Cook;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.Manufacture.Common.Item;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x02004626 RID: 17958
	[NullableContext(1)]
	[Nullable(0)]
	public class ForgingIngredientsVerticalView : UiPanelBase
	{
		// Token: 0x0602D1C8 RID: 184776 RVA: 0x00C9C51F File Offset: 0x00C9A71F
		public int GetManufactureCount()
		{
			return this.Count;
		}

		// Token: 0x0602D1C9 RID: 184777 RVA: 0x00C9C528 File Offset: 0x00C9A728
		protected unsafe override void OnRegisterComponent()
		{
			int num = 21;
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

		// Token: 0x0602D1CA RID: 184778 RVA: 0x00C9C820 File Offset: 0x00C9AA20
		protected override UniTask OnBeforeStartAsync()
		{
			ForgingIngredientsVerticalView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ForgingIngredientsVerticalView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D1CB RID: 184779 RVA: 0x00C9C864 File Offset: 0x00C9AA64
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
			base.GetText(17).ShowTextNew("PrefabTextItem_MaterialChoose_Text");
			base.GetText(23).ShowTextNew("NeedMaterialTitleText");
			this.UnlockMaterialComponent = new MediumItemGrid();
			this.UnlockMaterialComponent.Initialize(base.GetItem(21).GetOwner());
			this.UnlockMaterialComponent.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.UnlockMaterialComponent.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				int itemId = (int)callbackParameter.Data;
				ItemController.Instance.OpenItemTipsByItemId(itemId, true, null, false);
			});
			UUIItem item = base.GetItem(8);
			this.NumberSelect = new NumberSelectComponent(item);
			INumberSelectData data = new INumberSelectData
			{
				MaxNumber = 0,
				ValueChangeFunction = new Action<int>(this.SetSum)
			};
			this.NumberSelect.Init(data);
			this.NumberSelect.SetNumberSelectTipsVisible(false);
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.SvInfoView.ChangeRoleClickDelegate = new Action(this.OnClickChangeRole);
			this.SvInfoView.SetTypeNameVisible(false);
			base.GetText(12).SetUIActive(false);
		}

		// Token: 0x0602D1CC RID: 184780 RVA: 0x00C9C9A1 File Offset: 0x00C9ABA1
		protected override void OnBeforeDestroy()
		{
			this.SvInfoView.Destroy(null);
		}

		// Token: 0x0602D1CD RID: 184781 RVA: 0x00C9C9AF File Offset: 0x00C9ABAF
		public void BindChangeClickCall(Action func)
		{
			this.ChangeRoleClickCall = func;
		}

		// Token: 0x0602D1CE RID: 184782 RVA: 0x00C9C9B8 File Offset: 0x00C9ABB8
		private void OnClickChangeRole()
		{
			if (this.ChangeRoleClickCall != null)
			{
				this.ChangeRoleClickCall();
			}
		}

		// Token: 0x0602D1CF RID: 184783 RVA: 0x00C9C9D0 File Offset: 0x00C9ABD0
		private ManufactureMaterialItem OnMaterialItemCreate()
		{
			ManufactureMaterialItem manufactureMaterialItem = new ManufactureMaterialItem();
			manufactureMaterialItem.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			manufactureMaterialItem.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				ISingleItemInfo singleItemInfo = (ISingleItemInfo)callbackParameter.Data;
				ItemController.Instance.OpenItemTipsByItemId(singleItemInfo.Proto_ItemId, true, null, false);
			});
			return manufactureMaterialItem;
		}

		// Token: 0x0602D1D0 RID: 184784 RVA: 0x00C9CA2C File Offset: 0x00C9AC2C
		private void SetSum(int sum)
		{
			this.Count = sum;
			if (this.ItemData != null)
			{
				int maxCreateCount = ForgingController.Instance.GetMaxCreateCount(this.ItemData.ItemId);
				this.NumberSelect.SetAddButtonInteractive(sum < maxCreateCount);
				this.NumberSelect.SetReduceButtonInteractive(sum > 1);
			}
			this.RefreshMaterialNeedNum();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Text_ItemSelectForgeQuantityTip_text", new <>z__ReadOnlySingleElementList<object>(this.Count));
		}

		// Token: 0x0602D1D1 RID: 184785 RVA: 0x00C9CAAC File Offset: 0x00C9ACAC
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

		// Token: 0x0602D1D2 RID: 184786 RVA: 0x00C9CB30 File Offset: 0x00C9AD30
		private void RefreshCommon(IWeaponForgingData data)
		{
			this.ItemData = data;
			this.Count = 1;
			int maxCreateCount = CommonManager.Instance.GetMaxCreateCount(this.ItemData.ItemId);
			this.NumberSelect.Refresh(maxCreateCount);
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.NumberSelect.SetReduceButtonInteractive(false);
			this.SvInfoView.SetDescVisible(true);
			this.SvInfoView.SetDescBgVisible(false);
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(data.ItemId);
			WeaponConf? weaponItemConfig = InventoryConfig.Instance.GetWeaponItemConfig(forgeFormulaById.Value.ItemId);
			string[] weaponConfigDescParams = WeaponModel.Instance.GetWeaponConfigDescParams(weaponItemConfig.Value, 1);
			string desc = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(weaponItemConfig.Value.Desc, null), weaponConfigDescParams);
			string descBg = StringUtils.IsEmpty(forgeFormulaById.Value.Background) ? "" : CookConfig.Instance.GetLocalText(forgeFormulaById.Value.Background);
			this.SvInfoView.SetDesc(desc);
			this.SvInfoView.SetDescBg(descBg);
			this.ProficiencyViewComponent.SetExpNumVisible(false);
		}

		// Token: 0x0602D1D3 RID: 184787 RVA: 0x00C9CC5C File Offset: 0x00C9AE5C
		[return: TupleElementNames(new string[]
		{
			"hasCoin",
			"coinCount",
			"list"
		})]
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
			List<ISingleItemInfo> list2 = new List<ISingleItemInfo>(list.Count);
			foreach (ISingleItemInfo singleItemInfo in list)
			{
				if (singleItemInfo.Proto_ItemId != ComposeController.Instance.ComposeCoinId)
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

		// Token: 0x0602D1D4 RID: 184788 RVA: 0x00C9CCE4 File Offset: 0x00C9AEE4
		private void RefreshMaterial()
		{
			if (this.ItemData.IsUnlock > 0)
			{
				base.GetItem(20).SetUIActive(false);
				base.GetItem(18).SetUIActive(true);
				List<ISingleItemInfo> forgingMaterialList = ForgingModel.Instance.GetForgingMaterialList(this.ItemData.ItemId);
				ValueTuple<bool, int, List<ISingleItemInfo>> valueTuple = this.FilterMaterialList(forgingMaterialList);
				this.MaterialScrollView.RefreshByData(valueTuple.Item3, new Action(this.RefreshMaterialNeedNum), false);
				this.HasCoin = valueTuple.Item1;
				this.SingleNeedCoinCount = valueTuple.Item2;
				return;
			}
			base.GetItem(20).SetUIActive(true);
			base.GetItem(18).SetUIActive(false);
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(this.ItemData.ItemId);
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(forgeFormulaById.Value.FormulaItemId);
			if (itemConfig == null)
			{
				return;
			}
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = forgeFormulaById.Value.FormulaItemId,
				ItemConfigId = new int?(forgeFormulaById.Value.FormulaItemId),
				BottomTextId = itemConfig.Value.Name,
				IsProhibit = new bool?(true),
				IsOmitBottomText = new bool?(true)
			};
			this.UnlockMaterialComponent.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x0602D1D5 RID: 184789 RVA: 0x00C9CE40 File Offset: 0x00C9B040
		private bool CheckDataValid(IWeaponForgingData itemData)
		{
			if (itemData == null)
			{
				Log.Instance.Error(ELogModule.Compose, ELogAuthor.LK, "缺少itemData数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x0602D1D6 RID: 184790 RVA: 0x00C9CE74 File Offset: 0x00C9B074
		private void SetSelectedRoleTexture()
		{
			int value = CommonManager.Instance.GetCurrentRoleId().Value;
			if (value == 0)
			{
				return;
			}
			this.ProficiencyViewComponent.SetRoleTexture(value);
		}

		// Token: 0x0602D1D7 RID: 184791 RVA: 0x00C9CEA4 File Offset: 0x00C9B0A4
		private void SetRecommendedRoleTexture(IWeaponForgingData itemData)
		{
			if (!this.CheckDataValid(itemData))
			{
				return;
			}
			int num = CommonManager.Instance.GetCurrentRoleId().Value;
			if (num == 0)
			{
				num = PlayerInfoModel.Instance.GetPlayerRoleId();
				CommonManager.Instance.SetCurrentRoleId(num);
			}
			if (num == 0)
			{
				return;
			}
			this.ProficiencyViewComponent.SetRoleTexture(num);
		}

		// Token: 0x0602D1D8 RID: 184792 RVA: 0x00C9CEF7 File Offset: 0x00C9B0F7
		public void RefreshHelpRole()
		{
			this.SetSelectedRoleTexture();
		}

		// Token: 0x0602D1D9 RID: 184793 RVA: 0x00C9CEFF File Offset: 0x00C9B0FF
		public void OnSecondTimerRefresh()
		{
			if (this.ItemData == null)
			{
				return;
			}
			this.RefreshLimitTime(this.ItemData);
		}

		// Token: 0x0602D1DA RID: 184794 RVA: 0x00C9CF18 File Offset: 0x00C9B118
		private void RefreshLimitTime(IWeaponForgingData itemData)
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

		// Token: 0x0602D1DB RID: 184795 RVA: 0x00C9CF90 File Offset: 0x00C9B190
		private void RefreshLimitCount(IWeaponForgingData itemData)
		{
			if (itemData.TotalMakeCountInLimitTime <= 0)
			{
				base.GetItem(3).SetUIActive(false);
				this.NumberSelect.ResetLimitMaxValue();
				return;
			}
			int num = itemData.TotalMakeCountInLimitTime - itemData.MadeCountInLimitTime;
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
				itemData.TotalMakeCountInLimitTime
			}));
		}

		// Token: 0x0602D1DC RID: 184796 RVA: 0x00C9D048 File Offset: 0x00C9B248
		private void RefreshCost(bool hasCoin, int count)
		{
			base.GetText(12).GetParentAsUIItem().SetUIActive(hasCoin);
			if (hasCoin)
			{
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(ComposeController.Instance.ComposeCoinId, 0);
				ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(ComposeController.Instance.ComposeCoinId);
				if (itemCountByConfigId < count)
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

		// Token: 0x0602D1DD RID: 184797 RVA: 0x00C9D104 File Offset: 0x00C9B304
		public void RefreshForging(IWeaponForgingData data)
		{
			this.RefreshLimitTime(data);
			this.RefreshLimitCount(data);
			this.RefreshCommon(data);
			this.RefreshMaterial();
			this.SvInfoView.SetWeaponAttribute(data);
			if (data.IsUnlock > 0)
			{
				this.ProficiencyViewComponent.SetActive(false);
				this.SetRecommendedRoleTexture(this.ItemData);
				this.NumberSelect.SetActive(true);
				base.GetItem(22).SetUIActive(false);
				base.GetItem(16).SetUIActive(true);
				base.GetItem(9).SetUIActive(true);
				return;
			}
			this.ProficiencyViewComponent.SetActive(false);
			this.NumberSelect.SetActive(false);
			base.GetItem(22).SetUIActive(true);
			base.GetItem(16).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
		}

		// Token: 0x04018357 RID: 99159
		private int Count = 1;

		// Token: 0x04018358 RID: 99160
		[Nullable(2)]
		private SvInfo SvInfoView;

		// Token: 0x04018359 RID: 99161
		[Nullable(2)]
		private NumberSelectComponent NumberSelect;

		// Token: 0x0401835A RID: 99162
		[Nullable(2)]
		private IWeaponForgingData ItemData;

		// Token: 0x0401835B RID: 99163
		[Nullable(2)]
		private MediumItemGrid UnlockMaterialComponent;

		// Token: 0x0401835C RID: 99164
		[Nullable(2)]
		private Action ChangeRoleClickCall;

		// Token: 0x0401835D RID: 99165
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> MaterialScrollView;

		// Token: 0x0401835E RID: 99166
		[Nullable(2)]
		private ProficiencyView ProficiencyViewComponent;

		// Token: 0x0401835F RID: 99167
		private bool HasCoin;

		// Token: 0x04018360 RID: 99168
		private int SingleNeedCoinCount;

		// Token: 0x0200A230 RID: 41520
		[NullableContext(0)]
		private class EVerticalGroupComponents
		{
			// Token: 0x040324E4 RID: 206052
			public const int SvInfo = 0;

			// Token: 0x040324E5 RID: 206053
			public const int PnlLimit = 1;

			// Token: 0x040324E6 RID: 206054
			public const int TxtLimitNum = 2;

			// Token: 0x040324E7 RID: 206055
			public const int PnlQuota = 3;

			// Token: 0x040324E8 RID: 206056
			public const int TxtQuotaNum = 4;

			// Token: 0x040324E9 RID: 206057
			public const int AmountItem = 8;

			// Token: 0x040324EA RID: 206058
			public const int PnlCost = 9;

			// Token: 0x040324EB RID: 206059
			public const int MakeCount = 10;

			// Token: 0x040324EC RID: 206060
			public const int TxtCost = 11;

			// Token: 0x040324ED RID: 206061
			public const int TxtPlace = 12;

			// Token: 0x040324EE RID: 206062
			public const int ImgCostIcon = 13;

			// Token: 0x040324EF RID: 206063
			public const int PnlTitle = 16;

			// Token: 0x040324F0 RID: 206064
			public const int TxtMaterialBarTitle = 17;

			// Token: 0x040324F1 RID: 206065
			public const int PnlLeftItem = 18;

			// Token: 0x040324F2 RID: 206066
			public const int MaterialScrollView = 19;

			// Token: 0x040324F3 RID: 206067
			public const int PnlCenterItem = 20;

			// Token: 0x040324F4 RID: 206068
			public const int LockGrid = 21;

			// Token: 0x040324F5 RID: 206069
			public const int PnlLock = 22;

			// Token: 0x040324F6 RID: 206070
			public const int TxtLock = 23;

			// Token: 0x040324F7 RID: 206071
			public const int PnlLimitedTime = 24;

			// Token: 0x040324F8 RID: 206072
			public const int TxtTime = 25;

			// Token: 0x040324F9 RID: 206073
			public const int ProficiencyView = 26;
		}
	}
}
