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
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02005672 RID: 22130
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeIngredientsVerticalView : UiPanelBase
	{
		// Token: 0x060384D6 RID: 230614 RVA: 0x00D5A73E File Offset: 0x00D5893E
		public int GetManufactureCount()
		{
			return this.Count;
		}

		// Token: 0x060384D7 RID: 230615 RVA: 0x00D5A748 File Offset: 0x00D58948
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

		// Token: 0x060384D8 RID: 230616 RVA: 0x00D5AA64 File Offset: 0x00D58C64
		protected override UniTask OnBeforeStartAsync()
		{
			ComposeIngredientsVerticalView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposeIngredientsVerticalView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060384D9 RID: 230617 RVA: 0x00D5AAA8 File Offset: 0x00D58CA8
		protected override void OnStart()
		{
			this.SvInfoView.SetActive(true);
			base.GetItem(1).SetUIActive(false);
			base.GetItem(9).SetUIActive(true);
			base.GetItem(22).SetUIActive(false);
			base.GetItem(16).SetUIActive(true);
			base.GetText(23).ShowTextNew("NeedMaterialTitleText");
			base.GetText(17).ShowTextNew("PrefabTextItem_MaterialChoose_Text");
			base.GetItem(18).SetUIActive(true);
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
				ItemController.Instance.OpenItemTipsByItemId(itemId, true, null);
			});
		}

		// Token: 0x060384DA RID: 230618 RVA: 0x00D5AC14 File Offset: 0x00D58E14
		private void SetSum(int sum)
		{
			this.Count = sum;
			this.RefreshMaterialNeedNum();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Text_ItemSelectSynthesisQuantityTip_text", new <>z__ReadOnlySingleElementList<object>(this.Count));
			if (this.ItemData != null && this.ItemData is IReagentProductionData)
			{
				int maxCreateCount = ComposeController.Instance.GetMaxCreateCount(this.ItemData.ConfigId, null);
				this.NumberSelect.SetAddButtonInteractive(sum < maxCreateCount);
				this.NumberSelect.SetReduceButtonInteractive(sum > 1);
				this.RefreshProficiency((IReagentProductionData)this.ItemData);
			}
		}

		// Token: 0x060384DB RID: 230619 RVA: 0x00D5ACB0 File Offset: 0x00D58EB0
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

		// Token: 0x060384DC RID: 230620 RVA: 0x00D5AD34 File Offset: 0x00D58F34
		protected override void OnBeforeDestroy()
		{
			this.SvInfoView = null;
		}

		// Token: 0x060384DD RID: 230621 RVA: 0x00D5AD3D File Offset: 0x00D58F3D
		private void OnClickChangeRole()
		{
			if (this.ChangeRoleClickCall != null)
			{
				this.ChangeRoleClickCall();
			}
		}

		// Token: 0x060384DE RID: 230622 RVA: 0x00D5AD54 File Offset: 0x00D58F54
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

		// Token: 0x060384DF RID: 230623 RVA: 0x00D5ADB0 File Offset: 0x00D58FB0
		private void SetTypeName(string tag)
		{
			string textById = TextConfig.Instance.GetTextById(tag);
			this.SvInfoView.SetTypeName(null);
			this.ProficiencyViewComponent.SetTypeContent(textById);
		}

		// Token: 0x060384E0 RID: 230624 RVA: 0x00D5ADE1 File Offset: 0x00D58FE1
		private void SetExpNum(int count, int single, int sum, int times)
		{
			this.ProficiencyViewComponent.SetExpNum(count, single, sum, times);
		}

		// Token: 0x060384E1 RID: 230625 RVA: 0x00D5ADF4 File Offset: 0x00D58FF4
		private bool CheckDataValid(IBaseItemData itemData)
		{
			if (itemData == null)
			{
				Log.Instance.Error(ELogModule.Compose, ELogAuthor.LK, "缺少itemData数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x060384E2 RID: 230626 RVA: 0x00D5AE28 File Offset: 0x00D59028
		private void SetSelectedRoleTexture(int itemId)
		{
			int? currentRoleId = CommonManager.Instance.GetCurrentRoleId();
			if (currentRoleId == null)
			{
				return;
			}
			this.ProficiencyViewComponent.SetRoleTexture(currentRoleId.Value, itemId);
		}

		// Token: 0x060384E3 RID: 230627 RVA: 0x00D5AE60 File Offset: 0x00D59060
		private void SetRecommendedRoleTexture(IBaseItemData itemData)
		{
			if (!this.CheckDataValid(itemData))
			{
				return;
			}
			int num = CommonManager.Instance.GetCurrentRoleId().Value;
			if (num == 0)
			{
				num = CommonManager.Instance.GetManufactureRoleId(itemData.ConfigId).Value;
				CommonManager.Instance.SetCurrentRoleId(num);
			}
			if (num == 0)
			{
				num = PlayerInfoModel.Instance.GetPlayerRoleId();
				CommonManager.Instance.SetCurrentRoleId(num);
			}
			if (num == 0)
			{
				return;
			}
			this.ProficiencyViewComponent.SetRoleTexture(num, itemData.ConfigId);
		}

		// Token: 0x060384E4 RID: 230628 RVA: 0x00D5AEE0 File Offset: 0x00D590E0
		[return: TupleElementNames(new string[]
		{
			"hasCoin",
			"coinCount",
			"ret"
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
			List<ISingleItemInfo> list2 = new List<ISingleItemInfo>();
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

		// Token: 0x060384E5 RID: 230629 RVA: 0x00D5AF64 File Offset: 0x00D59164
		private void RefreshCommon(IBaseItemData data)
		{
			if (this.ItemData != null && this.ItemData.ConfigId != data.ConfigId)
			{
				ComposeModel.Instance.CurrentComposeRoleId = 0;
			}
			this.ItemData = data;
			this.Count = 1;
			int maxCreateCount = ComposeController.Instance.GetMaxCreateCount(this.ItemData.ConfigId, null);
			this.NumberSelect.Refresh(maxCreateCount);
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.NumberSelect.SetReduceButtonInteractive(false);
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
			this.SvInfoView.SetDescVisible(true);
			this.SvInfoView.SetDescBgVisible(false);
			string desc = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetItemAttributeDesc(synthesisFormulaById.Value.ItemId) ?? string.Empty;
			string descBg = StringUtils.IsEmpty(synthesisFormulaById.Value.ComposeBackground) ? "" : CookConfig.Instance.GetLocalText(synthesisFormulaById.Value.ComposeBackground);
			this.SvInfoView.SetDesc(desc);
			this.SvInfoView.SetDescBg(descBg);
			this.NumberSelect.SetUiActive(data.IsUnlock > 0);
			base.GetItem(9).SetUIActive(data.IsUnlock > 0);
			if (data.IsUnlock > 0)
			{
				base.GetItem(20).SetUIActive(false);
				base.GetItem(18).SetUIActive(true);
				List<ISingleItemInfo> composeMaterialList = ComposeModel.Instance.GetComposeMaterialList(data.ConfigId);
				ValueTuple<bool, int, List<ISingleItemInfo>> valueTuple = this.FilterMaterialList(composeMaterialList);
				bool item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				List<ISingleItemInfo> item3 = valueTuple.Item3;
				this.HasCoin = item;
				this.SingleNeedCoinCount = item2;
				this.MaterialScrollView.RefreshByData(item3, new Action(this.RefreshMaterialNeedNum), false);
				return;
			}
			base.GetItem(20).SetUIActive(true);
			base.GetItem(18).SetUIActive(false);
			SynthesisFormula? synthesisFormulaById2 = ComposeConfig.Instance.GetSynthesisFormulaById(this.ItemData.ConfigId);
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(synthesisFormulaById2.Value.FormulaItemId);
			if (itemConfig == null)
			{
				return;
			}
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = synthesisFormulaById2.Value.FormulaItemId,
				ItemConfigId = new int?(synthesisFormulaById2.Value.FormulaItemId),
				BottomTextId = itemConfig.Value.Name,
				IsProhibit = new bool?(true),
				IsOmitBottomText = new bool?(true)
			};
			this.UnlockMaterialComponent.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x060384E6 RID: 230630 RVA: 0x00D5B1FA File Offset: 0x00D593FA
		public void BindChangeClickCall(Action func)
		{
			this.ChangeRoleClickCall = func;
		}

		// Token: 0x060384E7 RID: 230631 RVA: 0x00D5B204 File Offset: 0x00D59404
		private void RefreshProficiency(IReagentProductionData data)
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
			int proficiency = synthesisFormulaById.Value.Proficiency;
			int maxProficiencyCount = synthesisFormulaById.Value.MaxProficiencyCount;
			this.SetExpNum(data.ComposeCount, proficiency, maxProficiencyCount, this.Count);
		}

		// Token: 0x060384E8 RID: 230632 RVA: 0x00D5B256 File Offset: 0x00D59456
		public void OnSecondTimerRefresh()
		{
			if (this.ItemData == null)
			{
				return;
			}
			this.RefreshLimitTime(this.ItemData);
		}

		// Token: 0x060384E9 RID: 230633 RVA: 0x00D5B26D File Offset: 0x00D5946D
		public void RefreshProficiencyAndHelpRole(IReagentProductionData data)
		{
			this.RefreshProficiency(data);
			this.SetSelectedRoleTexture(data.ConfigId);
		}

		// Token: 0x060384EA RID: 230634 RVA: 0x00D5B282 File Offset: 0x00D59482
		public void RefreshHelpRole()
		{
			this.SetSelectedRoleTexture(this.ItemData.ConfigId);
		}

		// Token: 0x060384EB RID: 230635 RVA: 0x00D5B298 File Offset: 0x00D59498
		private void RefreshLimitTime(IBaseItemData itemData)
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

		// Token: 0x060384EC RID: 230636 RVA: 0x00D5B310 File Offset: 0x00D59510
		private void RefreshLimitCount(IBaseItemData itemData)
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

		// Token: 0x060384ED RID: 230637 RVA: 0x00D5B3C8 File Offset: 0x00D595C8
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

		// Token: 0x060384EE RID: 230638 RVA: 0x00D5B481 File Offset: 0x00D59681
		private void SetProficiencyViewVisible(bool visible, bool keepShowRole = false)
		{
			if (keepShowRole)
			{
				this.ProficiencyViewComponent.SetExpVisible(visible);
				return;
			}
			this.ProficiencyViewComponent.SetActive(visible);
		}

		// Token: 0x060384EF RID: 230639 RVA: 0x00D5B49F File Offset: 0x00D5969F
		public void RefreshReagentProduction(IReagentProductionData data)
		{
			this.RefreshLimitTime(data);
			this.RefreshLimitCount(data);
			this.RefreshCommon(data);
			this.SetProficiencyViewVisible(true, true);
			this.SetTypeName("Material");
			this.RefreshProficiency(data);
			this.SetRecommendedRoleTexture(data);
		}

		// Token: 0x060384F0 RID: 230640 RVA: 0x00D5B4D7 File Offset: 0x00D596D7
		public void RefreshStructure(IStructureData data)
		{
			this.RefreshLimitTime(data);
			this.RefreshLimitCount(data);
			this.RefreshCommon(data);
			this.SetTypeName("Prop");
			this.SetProficiencyViewVisible(false, true);
			this.SetRecommendedRoleTexture(data);
		}

		// Token: 0x060384F1 RID: 230641 RVA: 0x00D5B508 File Offset: 0x00D59708
		public void RefreshPurification(IPurificationData data)
		{
			this.RefreshLimitTime(data);
			this.RefreshLimitCount(data);
			this.RefreshCommon(data);
			this.SetTypeName("Material");
			this.SetProficiencyViewVisible(false, true);
			this.SetRecommendedRoleTexture(data);
			if (data.IsUnlock <= 0)
			{
				this.NumberSelect.Refresh(0);
			}
		}

		// Token: 0x0401D991 RID: 121233
		[Nullable(2)]
		private SvInfo SvInfoView;

		// Token: 0x0401D992 RID: 121234
		[Nullable(2)]
		private IBaseItemData ItemData;

		// Token: 0x0401D993 RID: 121235
		private int Count = 1;

		// Token: 0x0401D994 RID: 121236
		[Nullable(2)]
		private NumberSelectComponent NumberSelect;

		// Token: 0x0401D995 RID: 121237
		[Nullable(2)]
		private Action ChangeRoleClickCall;

		// Token: 0x0401D996 RID: 121238
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> MaterialScrollView;

		// Token: 0x0401D997 RID: 121239
		private bool HasCoin;

		// Token: 0x0401D998 RID: 121240
		private int SingleNeedCoinCount;

		// Token: 0x0401D999 RID: 121241
		[Nullable(2)]
		private MediumItemGrid UnlockMaterialComponent;

		// Token: 0x0401D99A RID: 121242
		[Nullable(2)]
		private ProficiencyView ProficiencyViewComponent;

		// Token: 0x0200B832 RID: 47154
		[NullableContext(0)]
		private class EVerticalGroupComponents
		{
			// Token: 0x04037BE6 RID: 228326
			public const int SvInfo = 0;

			// Token: 0x04037BE7 RID: 228327
			public const int PnlLimit = 1;

			// Token: 0x04037BE8 RID: 228328
			public const int TxtLimitNum = 2;

			// Token: 0x04037BE9 RID: 228329
			public const int PnlQuota = 3;

			// Token: 0x04037BEA RID: 228330
			public const int TxtQuotaNum = 4;

			// Token: 0x04037BEB RID: 228331
			public const int AmountItem = 8;

			// Token: 0x04037BEC RID: 228332
			public const int PnlCost = 9;

			// Token: 0x04037BED RID: 228333
			public const int MakeCount = 10;

			// Token: 0x04037BEE RID: 228334
			public const int TxtCost = 11;

			// Token: 0x04037BEF RID: 228335
			public const int TxtPlace = 12;

			// Token: 0x04037BF0 RID: 228336
			public const int ImgCostIcon = 13;

			// Token: 0x04037BF1 RID: 228337
			public const int PnlTitle = 16;

			// Token: 0x04037BF2 RID: 228338
			public const int TxtMaterialBarTitle = 17;

			// Token: 0x04037BF3 RID: 228339
			public const int PnlLeftItem = 18;

			// Token: 0x04037BF4 RID: 228340
			public const int MaterialScrollView = 19;

			// Token: 0x04037BF5 RID: 228341
			public const int PnlCenterItem = 20;

			// Token: 0x04037BF6 RID: 228342
			public const int LockGrid = 21;

			// Token: 0x04037BF7 RID: 228343
			public const int PnlLock = 22;

			// Token: 0x04037BF8 RID: 228344
			public const int TxtLock = 23;

			// Token: 0x04037BF9 RID: 228345
			public const int PnlLimitedTime = 24;

			// Token: 0x04037BFA RID: 228346
			public const int TxtTime = 25;

			// Token: 0x04037BFB RID: 228347
			public const int ProficiencyView = 26;
		}
	}
}
