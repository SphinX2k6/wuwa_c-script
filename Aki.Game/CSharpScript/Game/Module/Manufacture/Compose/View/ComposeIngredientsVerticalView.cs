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
	// Token: 0x02004648 RID: 17992
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeIngredientsVerticalView : UiPanelBase
	{
		// Token: 0x0602D3D3 RID: 185299 RVA: 0x00CA883E File Offset: 0x00CA6A3E
		public int GetManufactureCount()
		{
			return this.Count;
		}

		// Token: 0x0602D3D4 RID: 185300 RVA: 0x00CA8848 File Offset: 0x00CA6A48
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

		// Token: 0x0602D3D5 RID: 185301 RVA: 0x00CA8B64 File Offset: 0x00CA6D64
		protected override UniTask OnBeforeStartAsync()
		{
			ComposeIngredientsVerticalView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposeIngredientsVerticalView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D3D6 RID: 185302 RVA: 0x00CA8BA8 File Offset: 0x00CA6DA8
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
				ItemController.Instance.OpenItemTipsByItemId(itemId, true, null, false);
			});
		}

		// Token: 0x0602D3D7 RID: 185303 RVA: 0x00CA8D14 File Offset: 0x00CA6F14
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

		// Token: 0x0602D3D8 RID: 185304 RVA: 0x00CA8DB0 File Offset: 0x00CA6FB0
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

		// Token: 0x0602D3D9 RID: 185305 RVA: 0x00CA8E34 File Offset: 0x00CA7034
		protected override void OnBeforeDestroy()
		{
			this.SvInfoView = null;
		}

		// Token: 0x0602D3DA RID: 185306 RVA: 0x00CA8E3D File Offset: 0x00CA703D
		private void OnClickChangeRole()
		{
			if (this.ChangeRoleClickCall != null)
			{
				this.ChangeRoleClickCall();
			}
		}

		// Token: 0x0602D3DB RID: 185307 RVA: 0x00CA8E54 File Offset: 0x00CA7054
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

		// Token: 0x0602D3DC RID: 185308 RVA: 0x00CA8EB0 File Offset: 0x00CA70B0
		private void SetTypeName(string tag)
		{
			string textById = TextConfig.Instance.GetTextById(tag);
			this.SvInfoView.SetTypeName(null);
			this.ProficiencyViewComponent.SetTypeContent(textById);
		}

		// Token: 0x0602D3DD RID: 185309 RVA: 0x00CA8EE1 File Offset: 0x00CA70E1
		private void SetExpNum(int count, int single, int sum, int times)
		{
			this.ProficiencyViewComponent.SetExpNum(count, single, sum, times);
		}

		// Token: 0x0602D3DE RID: 185310 RVA: 0x00CA8EF4 File Offset: 0x00CA70F4
		private bool CheckDataValid(IBaseItemData itemData)
		{
			if (itemData == null)
			{
				Log.Instance.Error(ELogModule.Compose, ELogAuthor.LK, "缺少itemData数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x0602D3DF RID: 185311 RVA: 0x00CA8F28 File Offset: 0x00CA7128
		private void SetSelectedRoleTexture(int itemId)
		{
			int? currentRoleId = CommonManager.Instance.GetCurrentRoleId();
			if (currentRoleId == null)
			{
				return;
			}
			this.ProficiencyViewComponent.SetRoleTexture(currentRoleId.Value, itemId);
		}

		// Token: 0x0602D3E0 RID: 185312 RVA: 0x00CA8F60 File Offset: 0x00CA7160
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

		// Token: 0x0602D3E1 RID: 185313 RVA: 0x00CA8FE0 File Offset: 0x00CA71E0
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

		// Token: 0x0602D3E2 RID: 185314 RVA: 0x00CA9064 File Offset: 0x00CA7264
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

		// Token: 0x0602D3E3 RID: 185315 RVA: 0x00CA92FA File Offset: 0x00CA74FA
		public void BindChangeClickCall(Action func)
		{
			this.ChangeRoleClickCall = func;
		}

		// Token: 0x0602D3E4 RID: 185316 RVA: 0x00CA9304 File Offset: 0x00CA7504
		private void RefreshProficiency(IReagentProductionData data)
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
			int proficiency = synthesisFormulaById.Value.Proficiency;
			int maxProficiencyCount = synthesisFormulaById.Value.MaxProficiencyCount;
			this.SetExpNum(data.ComposeCount, proficiency, maxProficiencyCount, this.Count);
		}

		// Token: 0x0602D3E5 RID: 185317 RVA: 0x00CA9356 File Offset: 0x00CA7556
		public void OnSecondTimerRefresh()
		{
			if (this.ItemData == null)
			{
				return;
			}
			this.RefreshLimitTime(this.ItemData);
		}

		// Token: 0x0602D3E6 RID: 185318 RVA: 0x00CA936D File Offset: 0x00CA756D
		public void RefreshProficiencyAndHelpRole(IReagentProductionData data)
		{
			this.RefreshProficiency(data);
			this.SetSelectedRoleTexture(data.ConfigId);
		}

		// Token: 0x0602D3E7 RID: 185319 RVA: 0x00CA9382 File Offset: 0x00CA7582
		public void RefreshHelpRole()
		{
			this.SetSelectedRoleTexture(this.ItemData.ConfigId);
		}

		// Token: 0x0602D3E8 RID: 185320 RVA: 0x00CA9398 File Offset: 0x00CA7598
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

		// Token: 0x0602D3E9 RID: 185321 RVA: 0x00CA9410 File Offset: 0x00CA7610
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

		// Token: 0x0602D3EA RID: 185322 RVA: 0x00CA94C8 File Offset: 0x00CA76C8
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

		// Token: 0x0602D3EB RID: 185323 RVA: 0x00CA9581 File Offset: 0x00CA7781
		private void SetProficiencyViewVisible(bool visible, bool keepShowRole = false)
		{
			if (keepShowRole)
			{
				this.ProficiencyViewComponent.SetExpVisible(visible);
				return;
			}
			this.ProficiencyViewComponent.SetActive(visible);
		}

		// Token: 0x0602D3EC RID: 185324 RVA: 0x00CA959F File Offset: 0x00CA779F
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

		// Token: 0x0602D3ED RID: 185325 RVA: 0x00CA95D7 File Offset: 0x00CA77D7
		public void RefreshStructure(IStructureData data)
		{
			this.RefreshLimitTime(data);
			this.RefreshLimitCount(data);
			this.RefreshCommon(data);
			this.SetTypeName("Prop");
			this.SetProficiencyViewVisible(false, true);
			this.SetRecommendedRoleTexture(data);
		}

		// Token: 0x0602D3EE RID: 185326 RVA: 0x00CA9608 File Offset: 0x00CA7808
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

		// Token: 0x0401841C RID: 99356
		[Nullable(2)]
		private SvInfo SvInfoView;

		// Token: 0x0401841D RID: 99357
		[Nullable(2)]
		private IBaseItemData ItemData;

		// Token: 0x0401841E RID: 99358
		private int Count = 1;

		// Token: 0x0401841F RID: 99359
		[Nullable(2)]
		private NumberSelectComponent NumberSelect;

		// Token: 0x04018420 RID: 99360
		[Nullable(2)]
		private Action ChangeRoleClickCall;

		// Token: 0x04018421 RID: 99361
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> MaterialScrollView;

		// Token: 0x04018422 RID: 99362
		private bool HasCoin;

		// Token: 0x04018423 RID: 99363
		private int SingleNeedCoinCount;

		// Token: 0x04018424 RID: 99364
		[Nullable(2)]
		private MediumItemGrid UnlockMaterialComponent;

		// Token: 0x04018425 RID: 99365
		[Nullable(2)]
		private ProficiencyView ProficiencyViewComponent;

		// Token: 0x0200A25A RID: 41562
		[NullableContext(0)]
		private class EVerticalGroupComponents
		{
			// Token: 0x04032604 RID: 206340
			public const int SvInfo = 0;

			// Token: 0x04032605 RID: 206341
			public const int PnlLimit = 1;

			// Token: 0x04032606 RID: 206342
			public const int TxtLimitNum = 2;

			// Token: 0x04032607 RID: 206343
			public const int PnlQuota = 3;

			// Token: 0x04032608 RID: 206344
			public const int TxtQuotaNum = 4;

			// Token: 0x04032609 RID: 206345
			public const int AmountItem = 8;

			// Token: 0x0403260A RID: 206346
			public const int PnlCost = 9;

			// Token: 0x0403260B RID: 206347
			public const int MakeCount = 10;

			// Token: 0x0403260C RID: 206348
			public const int TxtCost = 11;

			// Token: 0x0403260D RID: 206349
			public const int TxtPlace = 12;

			// Token: 0x0403260E RID: 206350
			public const int ImgCostIcon = 13;

			// Token: 0x0403260F RID: 206351
			public const int PnlTitle = 16;

			// Token: 0x04032610 RID: 206352
			public const int TxtMaterialBarTitle = 17;

			// Token: 0x04032611 RID: 206353
			public const int PnlLeftItem = 18;

			// Token: 0x04032612 RID: 206354
			public const int MaterialScrollView = 19;

			// Token: 0x04032613 RID: 206355
			public const int PnlCenterItem = 20;

			// Token: 0x04032614 RID: 206356
			public const int LockGrid = 21;

			// Token: 0x04032615 RID: 206357
			public const int PnlLock = 22;

			// Token: 0x04032616 RID: 206358
			public const int TxtLock = 23;

			// Token: 0x04032617 RID: 206359
			public const int PnlLimitedTime = 24;

			// Token: 0x04032618 RID: 206360
			public const int TxtTime = 25;

			// Token: 0x04032619 RID: 206361
			public const int ProficiencyView = 26;
		}
	}
}
