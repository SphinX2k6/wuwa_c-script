using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A23 RID: 10787
[NullableContext(1)]
[Nullable(0)]
public class SkinBuyDetailViewData
{
	// Token: 0x0601669C RID: 91804 RVA: 0x005AAE4B File Offset: 0x005A904B
	public static SkinBuyDetailViewData Create(List<ShopSkinData> goodsData)
	{
		SkinBuyDetailViewData skinBuyDetailViewData = new SkinBuyDetailViewData();
		skinBuyDetailViewData.InitData(goodsData);
		return skinBuyDetailViewData;
	}

	// Token: 0x0601669D RID: 91805 RVA: 0x005AAE59 File Offset: 0x005A9059
	public static SkinBuyDetailViewData CreateByRoleSkinData(List<RoleSkinData> skinData)
	{
		SkinBuyDetailViewData skinBuyDetailViewData = new SkinBuyDetailViewData();
		skinBuyDetailViewData.InitDataByRoleSkinData(skinData);
		return skinBuyDetailViewData;
	}

	// Token: 0x0601669E RID: 91806 RVA: 0x005AAE67 File Offset: 0x005A9067
	public void SetPreviewTitle(string title)
	{
		this.PreviewTitle = title;
	}

	// Token: 0x0601669F RID: 91807 RVA: 0x005AAE70 File Offset: 0x005A9070
	public string GetPreviewTitle()
	{
		return this.PreviewTitle;
	}

	// Token: 0x060166A0 RID: 91808 RVA: 0x005AAE78 File Offset: 0x005A9078
	public void SetIsActivityReward(bool value)
	{
		this.IsActivityReward = value;
	}

	// Token: 0x060166A1 RID: 91809 RVA: 0x005AAE81 File Offset: 0x005A9081
	public bool GetIsActivityReward()
	{
		return this.IsActivityReward;
	}

	// Token: 0x060166A2 RID: 91810 RVA: 0x005AAE89 File Offset: 0x005A9089
	public void SetIndex(int index)
	{
		this.CurrentIndex = index;
	}

	// Token: 0x060166A3 RID: 91811 RVA: 0x005AAE92 File Offset: 0x005A9092
	public int GetIndex()
	{
		return this.CurrentIndex;
	}

	// Token: 0x060166A4 RID: 91812 RVA: 0x005AAE9C File Offset: 0x005A909C
	public TItem[] GetConnectOtherReward()
	{
		List<TItem> list = new List<TItem>();
		InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(SkinConfig.Instance.GetRoleSkinConfig(this.GetCurrentSkinData().GetItemId()).Value.HeadId, 0);
		TItem item = new TItem(itemData, 0);
		list.Add(item);
		return list.ToArray();
	}

	// Token: 0x060166A5 RID: 91813 RVA: 0x005AAEEF File Offset: 0x005A90EF
	public void InitDataByRoleSkinData(List<RoleSkinData> skinData)
	{
		this.AllSkinData = skinData;
	}

	// Token: 0x060166A6 RID: 91814 RVA: 0x005AAEF8 File Offset: 0x005A90F8
	public void InitData(List<ShopSkinData> goodsData)
	{
		this.AllGoodsData = goodsData;
		this.AllSkinData = new List<RoleSkinData>();
		foreach (ShopSkinData shopSkinData in goodsData)
		{
			RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(shopSkinData.GetItemId());
			this.AllSkinData.Add(roleSkinData);
		}
	}

	// Token: 0x060166A7 RID: 91815 RVA: 0x005AAF70 File Offset: 0x005A9170
	public bool CheckIfHaveMutiGood()
	{
		return this.AllGoodsData.Count > 1;
	}

	// Token: 0x060166A8 RID: 91816 RVA: 0x005AAF80 File Offset: 0x005A9180
	[NullableContext(2)]
	public ShopSkinData GetCurrentGoodsData()
	{
		if (this.AllGoodsData.Count == 0)
		{
			return null;
		}
		return this.AllGoodsData[this.CurrentIndex];
	}

	// Token: 0x060166A9 RID: 91817 RVA: 0x005AAFA2 File Offset: 0x005A91A2
	public void SwitchToNextGoods()
	{
		this.CurrentIndex++;
		if (this.CurrentIndex > this.AllGoodsData.Count - 1)
		{
			this.CurrentIndex = 0;
		}
	}

	// Token: 0x060166AA RID: 91818 RVA: 0x005AAFCE File Offset: 0x005A91CE
	public void SwitchToPreGoods()
	{
		this.CurrentIndex--;
		if (this.CurrentIndex < 0)
		{
			this.CurrentIndex = this.AllGoodsData.Count - 1;
		}
	}

	// Token: 0x060166AB RID: 91819 RVA: 0x005AAFFA File Offset: 0x005A91FA
	public RoleSkinData GetCurrentSkinData()
	{
		return this.AllSkinData[this.CurrentIndex];
	}

	// Token: 0x060166AC RID: 91820 RVA: 0x005AB00D File Offset: 0x005A920D
	public void SwitchToNextSkinData()
	{
		if (this.AllSkinData.Count <= 1)
		{
			return;
		}
		this.CurrentIndex = (this.CurrentIndex + 1) % this.AllSkinData.Count;
	}

	// Token: 0x060166AD RID: 91821 RVA: 0x005AB038 File Offset: 0x005A9238
	public bool GetIfNeedShowSwitchItem()
	{
		return this.GetCurrentSkinData().GetSuitWeaponSkinId() > 0;
	}

	// Token: 0x060166AE RID: 91822 RVA: 0x005AB048 File Offset: 0x005A9248
	public string GetDiscountText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDiscountText();
	}

	// Token: 0x060166AF RID: 91823 RVA: 0x005AB063 File Offset: 0x005A9263
	[NullableContext(2)]
	public object GetDiscountTimeData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetDiscountTimeData();
	}

	// Token: 0x060166B0 RID: 91824 RVA: 0x005AB07A File Offset: 0x005A927A
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData() != null && this.GetCurrentGoodsData().GetIfDirect();
	}

	// Token: 0x060166B1 RID: 91825 RVA: 0x005AB091 File Offset: 0x005A9291
	[NullableContext(2)]
	public IPriceData GetPriceData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x060166B2 RID: 91826 RVA: 0x005AB0A8 File Offset: 0x005A92A8
	public string GetDirectPriceText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x060166B3 RID: 91827 RVA: 0x005AB0C3 File Offset: 0x005A92C3
	public bool GetIfHaveSkinNeedRole()
	{
		return this.GetCurrentSkinData().GetIfHaveRole();
	}

	// Token: 0x0400A6A1 RID: 42657
	private List<RoleSkinData> AllSkinData = new List<RoleSkinData>();

	// Token: 0x0400A6A2 RID: 42658
	private List<ShopSkinData> AllGoodsData = new List<ShopSkinData>();

	// Token: 0x0400A6A3 RID: 42659
	private int CurrentIndex;

	// Token: 0x0400A6A4 RID: 42660
	private string PreviewTitle = "";

	// Token: 0x0400A6A5 RID: 42661
	private bool IsActivityReward;
}
