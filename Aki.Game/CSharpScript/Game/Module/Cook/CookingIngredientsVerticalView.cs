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
	// Token: 0x02005AFB RID: 23291
	[NullableContext(1)]
	[Nullable(0)]
	public class CookingIngredientsVerticalView : UiPanelBase
	{
		// Token: 0x17008C38 RID: 35896
		// (get) Token: 0x0603AF46 RID: 241478 RVA: 0x00E0E73B File Offset: 0x00E0C93B
		public int CurrentSetCount
		{
			get
			{
				return this.Count;
			}
		}

		// Token: 0x0603AF47 RID: 241479 RVA: 0x00E0E744 File Offset: 0x00E0C944
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

		// Token: 0x0603AF48 RID: 241480 RVA: 0x00E0EA60 File Offset: 0x00E0CC60
		protected override UniTask OnBeforeStartAsync()
		{
			CookingIngredientsVerticalView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CookingIngredientsVerticalView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AF49 RID: 241481 RVA: 0x00E0EAA4 File Offset: 0x00E0CCA4
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
				ItemController.Instance.OpenItemTipsByItemId(itemId, true, null);
			});
		}

		// Token: 0x0603AF4A RID: 241482 RVA: 0x00E0EC02 File Offset: 0x00E0CE02
		protected override void OnBeforeDestroy()
		{
			this.SvInfoView = null;
			this.MaterialScrollView = null;
			this.OnChangeMaterialSelectionDelegate = null;
		}

		// Token: 0x0603AF4B RID: 241483 RVA: 0x00E0EC1C File Offset: 0x00E0CE1C
		private ManufactureMaterialItem OnMaterialItemCreate()
		{
			ManufactureMaterialItem manufactureMaterialItem = new ManufactureMaterialItem();
			manufactureMaterialItem.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			manufactureMaterialItem.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				ISingleItemInfo singleItemInfo = callbackParameter.Data as ISingleItemInfo;
				if (singleItemInfo.Proto_IsUnlock)
				{
					ItemController.Instance.OpenItemTipsByItemId(singleItemInfo.Proto_ItemId, true, null);
					return;
				}
				ScrollingTipsController.Instance.ShowTipsById("ItemSelectCookUnlockTip", Array.Empty<object>());
			});
			return manufactureMaterialItem;
		}

		// Token: 0x0603AF4C RID: 241484 RVA: 0x00E0EC78 File Offset: 0x00E0CE78
		private void OnClickChangeRole()
		{
			EventSystem.Instance.Emit<int>(EEventName.OpenCookRole, this.ItemData.ItemId);
		}

		// Token: 0x0603AF4D RID: 241485 RVA: 0x00E0EC98 File Offset: 0x00E0CE98
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

		// Token: 0x0603AF4E RID: 241486 RVA: 0x00E0ED4C File Offset: 0x00E0CF4C
		private bool CheckDataValid(object itemData)
		{
			if (itemData == null)
			{
				Log.Instance.Error(ELogModule.Cook, ELogAuthor.LK, "缺少itemData数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x0603AF4F RID: 241487 RVA: 0x00E0ED80 File Offset: 0x00E0CF80
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

		// Token: 0x0603AF50 RID: 241488 RVA: 0x00E0EDE8 File Offset: 0x00E0CFE8
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

		// Token: 0x0603AF51 RID: 241489 RVA: 0x00E0EE6C File Offset: 0x00E0D06C
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

		// Token: 0x0603AF52 RID: 241490 RVA: 0x00E0EED8 File Offset: 0x00E0D0D8
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

		// Token: 0x0603AF53 RID: 241491 RVA: 0x00E0EF50 File Offset: 0x00E0D150
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

		// Token: 0x0603AF54 RID: 241492 RVA: 0x00E0F008 File Offset: 0x00E0D208
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

		// Token: 0x0603AF55 RID: 241493 RVA: 0x00E0F0C4 File Offset: 0x00E0D2C4
		public void RefreshProficiency(ICookingData data, int times)
		{
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(data.ItemId);
			int proficiency = cookFormulaById.Proficiency;
			int maxProficiencyCount = cookFormulaById.MaxProficiencyCount;
			this.ProficiencyViewComponent.SetExpNum(data.CookCount, proficiency, maxProficiencyCount, times);
			this.SetRecommendedRoleTexture(data);
		}

		// Token: 0x0603AF56 RID: 241494 RVA: 0x00E0F110 File Offset: 0x00E0D310
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

		// Token: 0x0603AF57 RID: 241495 RVA: 0x00E0F194 File Offset: 0x00E0D394
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

		// Token: 0x0603AF58 RID: 241496 RVA: 0x00E0F1C0 File Offset: 0x00E0D3C0
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

		// Token: 0x0603AF59 RID: 241497 RVA: 0x00E0F3F4 File Offset: 0x00E0D5F4
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

		// Token: 0x0401EC59 RID: 126041
		[Nullable(2)]
		private SvInfo SvInfoView;

		// Token: 0x0401EC5A RID: 126042
		[Nullable(2)]
		public ICookItemData ItemData;

		// Token: 0x0401EC5B RID: 126043
		[Nullable(2)]
		private NumberSelectComponent NumberSelect;

		// Token: 0x0401EC5C RID: 126044
		private int Count = 1;

		// Token: 0x0401EC5D RID: 126045
		public bool ShowMaterialItemRemoveControl;

		// Token: 0x0401EC5E RID: 126046
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> MaterialScrollView;

		// Token: 0x0401EC5F RID: 126047
		[Nullable(2)]
		private CookProficiencyView ProficiencyViewComponent;

		// Token: 0x0401EC60 RID: 126048
		private bool HasCoin;

		// Token: 0x0401EC61 RID: 126049
		private int SingleNeedCoinCount;

		// Token: 0x0401EC62 RID: 126050
		[Nullable(2)]
		private MediumItemGrid UnlockMaterialComponent;

		// Token: 0x0401EC63 RID: 126051
		[Nullable(2)]
		public Action OnChangeMaterialSelectionDelegate;

		// Token: 0x0200BD46 RID: 48454
		[NullableContext(0)]
		private enum EVerticalGroupComponents
		{
			// Token: 0x0403914A RID: 233802
			SvInfo,
			// Token: 0x0403914B RID: 233803
			PnlLimit,
			// Token: 0x0403914C RID: 233804
			TxtLimitNum,
			// Token: 0x0403914D RID: 233805
			PnlQuota,
			// Token: 0x0403914E RID: 233806
			TxtQuotaNum,
			// Token: 0x0403914F RID: 233807
			AmountItem = 8,
			// Token: 0x04039150 RID: 233808
			PnlCost,
			// Token: 0x04039151 RID: 233809
			MakeCount,
			// Token: 0x04039152 RID: 233810
			TxtCost,
			// Token: 0x04039153 RID: 233811
			TxtPlace,
			// Token: 0x04039154 RID: 233812
			ImgCostIcon,
			// Token: 0x04039155 RID: 233813
			PnlTitle = 16,
			// Token: 0x04039156 RID: 233814
			TxtMaterialBarTitle,
			// Token: 0x04039157 RID: 233815
			PnlLeftItem,
			// Token: 0x04039158 RID: 233816
			MaterialScrollView,
			// Token: 0x04039159 RID: 233817
			PnlCenterItem,
			// Token: 0x0403915A RID: 233818
			LockGrid,
			// Token: 0x0403915B RID: 233819
			PnlLock,
			// Token: 0x0403915C RID: 233820
			TxtLock,
			// Token: 0x0403915D RID: 233821
			PnlLimitedTime,
			// Token: 0x0403915E RID: 233822
			TxtTime,
			// Token: 0x0403915F RID: 233823
			ProficiencyView
		}
	}
}
