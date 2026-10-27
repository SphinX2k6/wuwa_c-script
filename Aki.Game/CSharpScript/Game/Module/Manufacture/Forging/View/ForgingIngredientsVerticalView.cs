using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005650 RID: 22096
	[NullableContext(1)]
	[Nullable(0)]
	public class ForgingIngredientsVerticalView : UiPanelBase
	{
		// Token: 0x060382CA RID: 230090 RVA: 0x00D4E7CF File Offset: 0x00D4C9CF
		public int GetManufactureCount()
		{
			return this.Count;
		}

		// Token: 0x060382CB RID: 230091 RVA: 0x00D4E7D8 File Offset: 0x00D4C9D8
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

		// Token: 0x060382CC RID: 230092 RVA: 0x00D4EAD0 File Offset: 0x00D4CCD0
		protected override UniTask OnBeforeStartAsync()
		{
			ForgingIngredientsVerticalView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ForgingIngredientsVerticalView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060382CD RID: 230093 RVA: 0x00D4EB14 File Offset: 0x00D4CD14
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
				ItemController.Instance.OpenItemTipsByItemId(itemId, true, null);
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

		// Token: 0x060382CE RID: 230094 RVA: 0x00D4EC51 File Offset: 0x00D4CE51
		protected override void OnBeforeDestroy()
		{
			this.SvInfoView.Destroy(null);
		}

		// Token: 0x060382CF RID: 230095 RVA: 0x00D4EC5F File Offset: 0x00D4CE5F
		public void BindChangeClickCall(Action func)
		{
			this.ChangeRoleClickCall = func;
		}

		// Token: 0x060382D0 RID: 230096 RVA: 0x00D4EC68 File Offset: 0x00D4CE68
		private void OnClickChangeRole()
		{
			if (this.ChangeRoleClickCall != null)
			{
				this.ChangeRoleClickCall();
			}
		}

		// Token: 0x060382D1 RID: 230097 RVA: 0x00D4EC80 File Offset: 0x00D4CE80
		private ManufactureMaterialItem OnMaterialItemCreate()
		{
			ManufactureMaterialItem manufactureMaterialItem = new ManufactureMaterialItem();
			manufactureMaterialItem.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			manufactureMaterialItem.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				ISingleItemInfo singleItemInfo = (ISingleItemInfo)callbackParameter.Data;
				ItemController.Instance.OpenItemTipsByItemId(singleItemInfo.Proto_ItemId, true, null);
			});
			return manufactureMaterialItem;
		}

		// Token: 0x060382D2 RID: 230098 RVA: 0x00D4ECDC File Offset: 0x00D4CEDC
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

		// Token: 0x060382D3 RID: 230099 RVA: 0x00D4ED5C File Offset: 0x00D4CF5C
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

		// Token: 0x060382D4 RID: 230100 RVA: 0x00D4EDE0 File Offset: 0x00D4CFE0
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

		// Token: 0x060382D5 RID: 230101 RVA: 0x00D4EF0C File Offset: 0x00D4D10C
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
			bool hasCoin = false;
			int coinCount = 0;
			List<ISingleItemInfo> item = list.Where(delegate(ISingleItemInfo value)
			{
				if (value.Proto_ItemId != ComposeController.Instance.ComposeCoinId)
				{
					return true;
				}
				hasCoin = true;
				coinCount = value.Proto_ItemNum;
				return false;
			}).ToList<ISingleItemInfo>();
			return new ValueTuple<bool, int, List<ISingleItemInfo>>(hasCoin, coinCount, item);
		}

		// Token: 0x060382D6 RID: 230102 RVA: 0x00D4EF58 File Offset: 0x00D4D158
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

		// Token: 0x060382D7 RID: 230103 RVA: 0x00D4F0B4 File Offset: 0x00D4D2B4
		private bool CheckDataValid(IWeaponForgingData itemData)
		{
			if (itemData == null)
			{
				Log.Instance.Error(ELogModule.Compose, ELogAuthor.LK, "缺少itemData数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x060382D8 RID: 230104 RVA: 0x00D4F0E8 File Offset: 0x00D4D2E8
		private void SetSelectedRoleTexture()
		{
			int value = CommonManager.Instance.GetCurrentRoleId().Value;
			if (value == 0)
			{
				return;
			}
			this.ProficiencyViewComponent.SetRoleTexture(value);
		}

		// Token: 0x060382D9 RID: 230105 RVA: 0x00D4F118 File Offset: 0x00D4D318
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

		// Token: 0x060382DA RID: 230106 RVA: 0x00D4F16B File Offset: 0x00D4D36B
		public void RefreshHelpRole()
		{
			this.SetSelectedRoleTexture();
		}

		// Token: 0x060382DB RID: 230107 RVA: 0x00D4F173 File Offset: 0x00D4D373
		public void OnSecondTimerRefresh()
		{
			if (this.ItemData == null)
			{
				return;
			}
			this.RefreshLimitTime(this.ItemData);
		}

		// Token: 0x060382DC RID: 230108 RVA: 0x00D4F18C File Offset: 0x00D4D38C
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

		// Token: 0x060382DD RID: 230109 RVA: 0x00D4F204 File Offset: 0x00D4D404
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

		// Token: 0x060382DE RID: 230110 RVA: 0x00D4F2BC File Offset: 0x00D4D4BC
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

		// Token: 0x060382DF RID: 230111 RVA: 0x00D4F378 File Offset: 0x00D4D578
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

		// Token: 0x0401D8CC RID: 121036
		private int Count = 1;

		// Token: 0x0401D8CD RID: 121037
		[Nullable(2)]
		private SvInfo SvInfoView;

		// Token: 0x0401D8CE RID: 121038
		[Nullable(2)]
		private NumberSelectComponent NumberSelect;

		// Token: 0x0401D8CF RID: 121039
		[Nullable(2)]
		private IWeaponForgingData ItemData;

		// Token: 0x0401D8D0 RID: 121040
		[Nullable(2)]
		private MediumItemGrid UnlockMaterialComponent;

		// Token: 0x0401D8D1 RID: 121041
		[Nullable(2)]
		private Action ChangeRoleClickCall;

		// Token: 0x0401D8D2 RID: 121042
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> MaterialScrollView;

		// Token: 0x0401D8D3 RID: 121043
		[Nullable(2)]
		private ProficiencyView ProficiencyViewComponent;

		// Token: 0x0401D8D4 RID: 121044
		private bool HasCoin;

		// Token: 0x0401D8D5 RID: 121045
		private int SingleNeedCoinCount;

		// Token: 0x0200B805 RID: 47109
		[NullableContext(0)]
		private class EVerticalGroupComponents
		{
			// Token: 0x04037ABA RID: 228026
			public const int SvInfo = 0;

			// Token: 0x04037ABB RID: 228027
			public const int PnlLimit = 1;

			// Token: 0x04037ABC RID: 228028
			public const int TxtLimitNum = 2;

			// Token: 0x04037ABD RID: 228029
			public const int PnlQuota = 3;

			// Token: 0x04037ABE RID: 228030
			public const int TxtQuotaNum = 4;

			// Token: 0x04037ABF RID: 228031
			public const int AmountItem = 8;

			// Token: 0x04037AC0 RID: 228032
			public const int PnlCost = 9;

			// Token: 0x04037AC1 RID: 228033
			public const int MakeCount = 10;

			// Token: 0x04037AC2 RID: 228034
			public const int TxtCost = 11;

			// Token: 0x04037AC3 RID: 228035
			public const int TxtPlace = 12;

			// Token: 0x04037AC4 RID: 228036
			public const int ImgCostIcon = 13;

			// Token: 0x04037AC5 RID: 228037
			public const int PnlTitle = 16;

			// Token: 0x04037AC6 RID: 228038
			public const int TxtMaterialBarTitle = 17;

			// Token: 0x04037AC7 RID: 228039
			public const int PnlLeftItem = 18;

			// Token: 0x04037AC8 RID: 228040
			public const int MaterialScrollView = 19;

			// Token: 0x04037AC9 RID: 228041
			public const int PnlCenterItem = 20;

			// Token: 0x04037ACA RID: 228042
			public const int LockGrid = 21;

			// Token: 0x04037ACB RID: 228043
			public const int PnlLock = 22;

			// Token: 0x04037ACC RID: 228044
			public const int TxtLock = 23;

			// Token: 0x04037ACD RID: 228045
			public const int PnlLimitedTime = 24;

			// Token: 0x04037ACE RID: 228046
			public const int TxtTime = 25;

			// Token: 0x04037ACF RID: 228047
			public const int ProficiencyView = 26;
		}
	}
}
