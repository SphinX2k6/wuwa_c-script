using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000497 RID: 1175
[NullableContext(1)]
[Nullable(0)]
public class FurniturePresetItem : UiPanelBase
{
	// Token: 0x06003BFE RID: 15358 RVA: 0x001541B8 File Offset: 0x001523B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnShopButtonClick))
		};
	}

	// Token: 0x06003BFF RID: 15359 RVA: 0x001542E8 File Offset: 0x001524E8
	protected override UniTask OnBeforeStartAsync()
	{
		FurniturePresetItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurniturePresetItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003C00 RID: 15360 RVA: 0x0015432C File Offset: 0x0015252C
	public void Refresh(FurnitureAreaData areaData)
	{
		this.AreaData = areaData;
		int areaId = areaData.GetAreaId();
		FurniturePresetConfig? furniturePresetConfig = FurnitureConfig.Instance.GetFurniturePresetConfig(areaId);
		this.UpdateGridItemDataList(furniturePresetConfig.Value);
		this.UpdateCostData();
		this.PresetScrollView.RefreshByData(this.GridItemDataList, null, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), furniturePresetConfig.Value.Name, Array.Empty<object>());
		base.SetTextureByPath(furniturePresetConfig.Value.Icon, base.GetTexture(1), null, null);
		bool flag = this.LockCount > 0;
		bool flag2 = this.LockCount == this.GridItemDataList.Count;
		bool flag3 = this.LockCount == 0;
		ButtonItem applyButtonItem = this.ApplyButtonItem;
		if (applyButtonItem != null)
		{
			applyButtonItem.SetEnableClick(!flag2);
		}
		ButtonItem applyButtonItem2 = this.ApplyButtonItem;
		if (applyButtonItem2 != null)
		{
			applyButtonItem2.SetLocalTextNew(flag3 ? "DIY_FoolproofWindow_SetAll_Button" : "DIY_FoolproofWindow_SetExist_Button", Array.Empty<object>());
		}
		ButtonItem fillAndApplyButtonItem = this.FillAndApplyButtonItem;
		if (fillAndApplyButtonItem != null)
		{
			fillAndApplyButtonItem.SetUiActive(flag);
		}
		if (flag)
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.CurrencyId, 0);
			base.SetItemIcon(base.GetTexture(8), this.CurrencyId, null, null);
			UUIText text = base.GetText(9);
			text.SetText(this.NeedCostCurrency.ToString(), true);
			UUIItem uuiitem = text;
			bool bUseChangeColor = itemCountByConfigId < this.NeedCostCurrency;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			ButtonItem fillAndApplyButtonItem2 = this.FillAndApplyButtonItem;
			if (fillAndApplyButtonItem2 != null)
			{
				fillAndApplyButtonItem2.SetEnableClick(itemCountByConfigId >= this.NeedCostCurrency);
			}
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DIY_FoolproofWindow_FurList_Title", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.GridItemDataList.Count - this.LockCount,
			this.GridItemDataList.Count
		}));
	}

	// Token: 0x06003C01 RID: 15361 RVA: 0x00154520 File Offset: 0x00152720
	private void UpdateGridItemDataList(FurniturePresetConfig furniturePresetConfig)
	{
		this.GridItemDataList.Clear();
		this.LockCount = 0;
		HashSet<int> hashSet = new HashSet<int>();
		foreach (IntArray intArray in furniturePresetConfig.FurniturePlaceInfo().Values)
		{
			foreach (int num in intArray.ArrayIntIter())
			{
				if (!hashSet.Contains(num))
				{
					hashSet.Add(num);
					Furniture? furnitureConfig = FurnitureConfig.Instance.GetFurnitureConfig(num);
					bool flag = !FurnitureModel.Instance.GetIsFurnitureUnlockById(num);
					this.GridItemDataList.Add(new FurniturePresetGridItemData
					{
						FurnitureConfig = furnitureConfig.Value,
						IsLock = flag,
						IsFinished = !flag
					});
					if (flag)
					{
						this.LockCount++;
					}
				}
			}
		}
		this.SortGridItemDataList();
	}

	// Token: 0x06003C02 RID: 15362 RVA: 0x00154644 File Offset: 0x00152844
	private void SortGridItemDataList()
	{
		this.GridItemDataList.Sort(delegate(IFurniturePresetGridItemData a, IFurniturePresetGridItemData b)
		{
			if (a.IsLock == b.IsLock)
			{
				return a.FurnitureConfig.Id - b.FurnitureConfig.Id;
			}
			if (!a.IsLock)
			{
				return 1;
			}
			return -1;
		});
	}

	// Token: 0x06003C03 RID: 15363 RVA: 0x00154670 File Offset: 0x00152870
	private void UpdateCostData()
	{
		this.NeedCostCurrency = 0;
		this.GoodsSet.Clear();
		foreach (IFurniturePresetGridItemData furniturePresetGridItemData in this.GridItemDataList)
		{
			if (furniturePresetGridItemData.IsLock)
			{
				Furniture furnitureConfig = furniturePresetGridItemData.FurnitureConfig;
				if (furnitureConfig.SourceType == 1)
				{
					int getWayId = furnitureConfig.GetWayId;
					if (!this.GoodsSet.Contains(getWayId))
					{
						PayShopGoods payShopGoods = PayShopModel.Instance.GetPayShopGoods(getWayId);
						if (payShopGoods != null && payShopGoods.IfCanBuy())
						{
							IPriceData priceData = (payShopGoods != null) ? payShopGoods.GetPriceData() : null;
							this.NeedCostCurrency += ((priceData != null) ? priceData.NowPrice : 0);
							this.GoodsSet.Add(getWayId);
						}
					}
				}
			}
		}
	}

	// Token: 0x06003C04 RID: 15364 RVA: 0x00154758 File Offset: 0x00152958
	private void OnShopButtonClick()
	{
		UiManager.Instance.CloseView(EUiViewName.FurniturePresetView, delegate(bool _)
		{
			FurnitureController.Instance.OpenFurnitureShopViewAsync(0);
		});
	}

	// Token: 0x06003C05 RID: 15365 RVA: 0x00154788 File Offset: 0x00152988
	private void OnApplyButtonClick(int _)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FurniturePresetApplyConfirm);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap.Add(2, new Action(this.ApplyInternal));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06003C06 RID: 15366 RVA: 0x001547CB File Offset: 0x001529CB
	private void ApplyInternal()
	{
		if (this.AreaData == null)
		{
			return;
		}
		Action<FurnitureAreaData> onApplyDelegate = this.OnApplyDelegate;
		if (onApplyDelegate == null)
		{
			return;
		}
		onApplyDelegate(this.AreaData);
	}

	// Token: 0x06003C07 RID: 15367 RVA: 0x001547EC File Offset: 0x001529EC
	private void OnFillAndApplyButtonClick(int _)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FurniturePresetFillAndApplyConfirm);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			this.FillAndApplyInternalAsync().Forget();
		});
		confirmBoxDataNew.TextArgs = new string[]
		{
			this.NeedCostCurrency.ToString()
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06003C08 RID: 15368 RVA: 0x0015484C File Offset: 0x00152A4C
	private UniTask FillInternalAsync()
	{
		FurniturePresetItem.<FillInternalAsync>d__22 <FillInternalAsync>d__;
		<FillInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FillInternalAsync>d__.<>4__this = this;
		<FillInternalAsync>d__.<>1__state = -1;
		<FillInternalAsync>d__.<>t__builder.Start<FurniturePresetItem.<FillInternalAsync>d__22>(ref <FillInternalAsync>d__);
		return <FillInternalAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003C09 RID: 15369 RVA: 0x00154890 File Offset: 0x00152A90
	private UniTask FillAndApplyInternalAsync()
	{
		FurniturePresetItem.<FillAndApplyInternalAsync>d__23 <FillAndApplyInternalAsync>d__;
		<FillAndApplyInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FillAndApplyInternalAsync>d__.<>4__this = this;
		<FillAndApplyInternalAsync>d__.<>1__state = -1;
		<FillAndApplyInternalAsync>d__.<>t__builder.Start<FurniturePresetItem.<FillAndApplyInternalAsync>d__23>(ref <FillAndApplyInternalAsync>d__);
		return <FillAndApplyInternalAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003C0A RID: 15370 RVA: 0x001548D3 File Offset: 0x00152AD3
	private FurniturePresetGridItem CreatePresetGridItem()
	{
		return new FurniturePresetGridItem();
	}

	// Token: 0x0400304A RID: 12362
	[Nullable(2)]
	private FurnitureAreaData AreaData;

	// Token: 0x0400304B RID: 12363
	private int CurrencyId;

	// Token: 0x0400304C RID: 12364
	private int NeedCostCurrency;

	// Token: 0x0400304D RID: 12365
	private int LockCount;

	// Token: 0x0400304E RID: 12366
	private readonly HashSet<int> GoodsSet = new HashSet<int>();

	// Token: 0x0400304F RID: 12367
	private bool IsDoingFillAndApply;

	// Token: 0x04003050 RID: 12368
	private readonly List<IFurniturePresetGridItemData> GridItemDataList = new List<IFurniturePresetGridItemData>();

	// Token: 0x04003051 RID: 12369
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericScrollViewNew<FurniturePresetGridItem, IFurniturePresetGridItemData> PresetScrollView;

	// Token: 0x04003052 RID: 12370
	[Nullable(2)]
	private CommonCurrencyItemListComponent CurrencyListComponent;

	// Token: 0x04003053 RID: 12371
	[Nullable(2)]
	private ButtonItem ApplyButtonItem;

	// Token: 0x04003054 RID: 12372
	[Nullable(2)]
	private ButtonItem FillAndApplyButtonItem;

	// Token: 0x04003055 RID: 12373
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FurnitureAreaData> OnApplyDelegate;
}
