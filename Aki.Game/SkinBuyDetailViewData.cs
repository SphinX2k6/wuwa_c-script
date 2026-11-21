using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001F9E RID: 8094
[NullableContext(1)]
[Nullable(0)]
public class SkinBuyDetailViewData
{
	// Token: 0x060140A2 RID: 82082 RVA: 0x005D5E27 File Offset: 0x005D4027
	public static SkinBuyDetailViewData Create(List<ShopSkinData> goodsData)
	{
		SkinBuyDetailViewData skinBuyDetailViewData = new SkinBuyDetailViewData();
		skinBuyDetailViewData.InitData(goodsData);
		return skinBuyDetailViewData;
	}

	// Token: 0x060140A3 RID: 82083 RVA: 0x005D5E35 File Offset: 0x005D4035
	public static SkinBuyDetailViewData CreateByRoleSkinData(List<RoleSkinData> skinData)
	{
		SkinBuyDetailViewData skinBuyDetailViewData = new SkinBuyDetailViewData();
		skinBuyDetailViewData.InitDataByRoleSkinData(skinData);
		return skinBuyDetailViewData;
	}

	// Token: 0x060140A4 RID: 82084 RVA: 0x005D5E43 File Offset: 0x005D4043
	public void SetPreviewTitle(string title)
	{
		this.PreviewTitle = title;
	}

	// Token: 0x060140A5 RID: 82085 RVA: 0x005D5E4C File Offset: 0x005D404C
	public string GetPreviewTitle()
	{
		return this.PreviewTitle;
	}

	// Token: 0x060140A6 RID: 82086 RVA: 0x005D5E54 File Offset: 0x005D4054
	public void SetIsActivityReward(bool value)
	{
		this.IsActivityReward = value;
	}

	// Token: 0x060140A7 RID: 82087 RVA: 0x005D5E5D File Offset: 0x005D405D
	public bool GetIsActivityReward()
	{
		return this.IsActivityReward;
	}

	// Token: 0x060140A8 RID: 82088 RVA: 0x005D5E65 File Offset: 0x005D4065
	public void SetIndex(int index)
	{
		this.CurrentIndex = index;
	}

	// Token: 0x060140A9 RID: 82089 RVA: 0x005D5E6E File Offset: 0x005D406E
	public int GetIndex()
	{
		return this.CurrentIndex;
	}

	// Token: 0x060140AA RID: 82090 RVA: 0x005D5E78 File Offset: 0x005D4078
	public TItem[] GetConnectOtherReward()
	{
		List<TItem> list = new List<TItem>();
		InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(SkinConfig.Instance.GetRoleSkinConfig(this.GetCurrentSkinData().GetItemId()).Value.HeadId, 0);
		TItem item = new TItem(itemData, 0);
		list.Add(item);
		return list.ToArray();
	}

	// Token: 0x060140AB RID: 82091 RVA: 0x005D5ECB File Offset: 0x005D40CB
	public void InitDataByRoleSkinData(List<RoleSkinData> skinData)
	{
		this.AllSkinData = skinData;
	}

	// Token: 0x060140AC RID: 82092 RVA: 0x005D5ED4 File Offset: 0x005D40D4
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

	// Token: 0x060140AD RID: 82093 RVA: 0x005D5F4C File Offset: 0x005D414C
	public bool CheckIfHaveMutiGood()
	{
		return this.AllGoodsData.Count > 1;
	}

	// Token: 0x060140AE RID: 82094 RVA: 0x005D5F5C File Offset: 0x005D415C
	[NullableContext(2)]
	public ShopSkinData GetCurrentGoodsData()
	{
		if (this.AllGoodsData.Count == 0)
		{
			return null;
		}
		return this.AllGoodsData[this.CurrentIndex];
	}

	// Token: 0x060140AF RID: 82095 RVA: 0x005D5F7E File Offset: 0x005D417E
	public void SwitchToNextGoods()
	{
		this.CurrentIndex++;
		if (this.CurrentIndex > this.AllGoodsData.Count - 1)
		{
			this.CurrentIndex = 0;
		}
	}

	// Token: 0x060140B0 RID: 82096 RVA: 0x005D5FAA File Offset: 0x005D41AA
	public void SwitchToPreGoods()
	{
		this.CurrentIndex--;
		if (this.CurrentIndex < 0)
		{
			this.CurrentIndex = this.AllGoodsData.Count - 1;
		}
	}

	// Token: 0x060140B1 RID: 82097 RVA: 0x005D5FD6 File Offset: 0x005D41D6
	public RoleSkinData GetCurrentSkinData()
	{
		return this.AllSkinData[this.CurrentIndex];
	}

	// Token: 0x060140B2 RID: 82098 RVA: 0x005D5FE9 File Offset: 0x005D41E9
	public void SwitchToNextSkinData()
	{
		if (this.AllSkinData.Count <= 1)
		{
			return;
		}
		this.CurrentIndex = (this.CurrentIndex + 1) % this.AllSkinData.Count;
	}

	// Token: 0x060140B3 RID: 82099 RVA: 0x005D6014 File Offset: 0x005D4214
	public bool GetIfNeedShowSwitchItem()
	{
		return this.GetCurrentSkinData().GetSuitWeaponSkinId() > 0;
	}

	// Token: 0x060140B4 RID: 82100 RVA: 0x005D6024 File Offset: 0x005D4224
	public string GetDiscountText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDiscountText();
	}

	// Token: 0x060140B5 RID: 82101 RVA: 0x005D603F File Offset: 0x005D423F
	[NullableContext(2)]
	public object GetDiscountTimeData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetDiscountTimeData();
	}

	// Token: 0x060140B6 RID: 82102 RVA: 0x005D6056 File Offset: 0x005D4256
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData() != null && this.GetCurrentGoodsData().GetIfDirect();
	}

	// Token: 0x060140B7 RID: 82103 RVA: 0x005D606D File Offset: 0x005D426D
	[NullableContext(2)]
	public IPriceData GetPriceData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x060140B8 RID: 82104 RVA: 0x005D6084 File Offset: 0x005D4284
	public string GetDirectPriceText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x060140B9 RID: 82105 RVA: 0x005D609F File Offset: 0x005D429F
	public bool GetIfHaveSkinNeedRole()
	{
		return this.GetCurrentSkinData().GetIfHaveRole();
	}

	// Token: 0x0400AA8A RID: 43658
	private List<RoleSkinData> AllSkinData = new List<RoleSkinData>();

	// Token: 0x0400AA8B RID: 43659
	private List<ShopSkinData> AllGoodsData = new List<ShopSkinData>();

	// Token: 0x0400AA8C RID: 43660
	private int CurrentIndex;

	// Token: 0x0400AA8D RID: 43661
	private string PreviewTitle = "";

	// Token: 0x0400AA8E RID: 43662
	private bool IsActivityReward;
}
