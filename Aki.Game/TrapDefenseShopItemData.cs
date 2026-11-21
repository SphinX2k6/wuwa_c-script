using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02002191 RID: 8593
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseShopItemData : ITrapDefenseShopGoods
{
	// Token: 0x17001FEC RID: 8172
	// (get) Token: 0x0601516E RID: 86382 RVA: 0x00624B90 File Offset: 0x00622D90
	// (set) Token: 0x0601516F RID: 86383 RVA: 0x00624B98 File Offset: 0x00622D98
	public int Id { get; set; }

	// Token: 0x17001FED RID: 8173
	// (get) Token: 0x06015170 RID: 86384 RVA: 0x00624BA1 File Offset: 0x00622DA1
	// (set) Token: 0x06015171 RID: 86385 RVA: 0x00624BA9 File Offset: 0x00622DA9
	public int? OriginalPrice { get; set; }

	// Token: 0x17001FEE RID: 8174
	// (get) Token: 0x06015172 RID: 86386 RVA: 0x00624BB2 File Offset: 0x00622DB2
	// (set) Token: 0x06015173 RID: 86387 RVA: 0x00624BBA File Offset: 0x00622DBA
	public int CurrentPrice { get; set; }

	// Token: 0x17001FEF RID: 8175
	// (get) Token: 0x06015174 RID: 86388 RVA: 0x00624BC3 File Offset: 0x00622DC3
	// (set) Token: 0x06015175 RID: 86389 RVA: 0x00624BCB File Offset: 0x00622DCB
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] DescArgs { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001FF0 RID: 8176
	// (get) Token: 0x06015176 RID: 86390 RVA: 0x00624BD4 File Offset: 0x00622DD4
	// (set) Token: 0x06015177 RID: 86391 RVA: 0x00624BDC File Offset: 0x00622DDC
	public ETrapDefenseShopGoodsType Type { get; set; }

	// Token: 0x17001FF1 RID: 8177
	// (get) Token: 0x06015178 RID: 86392 RVA: 0x00624BE5 File Offset: 0x00622DE5
	// (set) Token: 0x06015179 RID: 86393 RVA: 0x00624BED File Offset: 0x00622DED
	public int QualityId { get; set; } = 1;

	// Token: 0x17001FF2 RID: 8178
	// (get) Token: 0x0601517A RID: 86394 RVA: 0x00624BF6 File Offset: 0x00622DF6
	// (set) Token: 0x0601517B RID: 86395 RVA: 0x00624BFE File Offset: 0x00622DFE
	public string Name { get; set; }

	// Token: 0x17001FF3 RID: 8179
	// (get) Token: 0x0601517C RID: 86396 RVA: 0x00624C07 File Offset: 0x00622E07
	// (set) Token: 0x0601517D RID: 86397 RVA: 0x00624C0F File Offset: 0x00622E0F
	public string Desc { get; set; }

	// Token: 0x17001FF4 RID: 8180
	// (get) Token: 0x0601517E RID: 86398 RVA: 0x00624C18 File Offset: 0x00622E18
	// (set) Token: 0x0601517F RID: 86399 RVA: 0x00624C20 File Offset: 0x00622E20
	public string Icon { get; set; }

	// Token: 0x17001FF5 RID: 8181
	// (get) Token: 0x06015180 RID: 86400 RVA: 0x00624C2C File Offset: 0x00622E2C
	public int CanPurchaseNum
	{
		get
		{
			int val = (int)Math.Floor((double)((float)TrapDefenseModel.Instance.BattleData.GetGoldNum() / (float)((this.CurrentPrice != 0) ? this.CurrentPrice : 1)));
			int val2 = this.BattleItemData.LimitCount - this.BattleItemData.InventoryCount;
			return Math.Min(Math.Min(val, val2), this.Stock);
		}
	}

	// Token: 0x17001FF6 RID: 8182
	// (get) Token: 0x06015181 RID: 86401 RVA: 0x00624C8C File Offset: 0x00622E8C
	public bool InventoryCountReachLimit
	{
		get
		{
			return this.BattleItemData.InventoryCount >= this.BattleItemData.LimitCount;
		}
	}

	// Token: 0x17001FF7 RID: 8183
	// (get) Token: 0x06015182 RID: 86402 RVA: 0x00624CA9 File Offset: 0x00622EA9
	public bool Disable
	{
		get
		{
			return this.InventoryCountReachLimit || this.Stock <= 0;
		}
	}

	// Token: 0x17001FF8 RID: 8184
	// (get) Token: 0x06015183 RID: 86403 RVA: 0x00624CC1 File Offset: 0x00622EC1
	public ETrapDefenseShopGoodsUnavailableReason DisableReason
	{
		get
		{
			if (this.InventoryCountReachLimit)
			{
				return ETrapDefenseShopGoodsUnavailableReason.InventoryCountReachLimit;
			}
			if (this.Stock <= 0)
			{
				return ETrapDefenseShopGoodsUnavailableReason.SoldOut;
			}
			return ETrapDefenseShopGoodsUnavailableReason.None;
		}
	}

	// Token: 0x17001FF9 RID: 8185
	// (get) Token: 0x06015184 RID: 86404 RVA: 0x00624CD9 File Offset: 0x00622ED9
	// (set) Token: 0x06015185 RID: 86405 RVA: 0x00624CE1 File Offset: 0x00622EE1
	public Func<PropMediumItemGrid> GetItemGridParam { get; set; }

	// Token: 0x06015186 RID: 86406 RVA: 0x00624CEA File Offset: 0x00622EEA
	public static TrapDefenseShopItemData Create(TrapDefenseShopProductPbInfo serverData)
	{
		TrapDefenseShopItemData trapDefenseShopItemData = new TrapDefenseShopItemData();
		trapDefenseShopItemData.Init(serverData);
		return trapDefenseShopItemData;
	}

	// Token: 0x06015187 RID: 86407 RVA: 0x00624CF8 File Offset: 0x00622EF8
	public void Update(TrapDefenseShopProductPbInfo serverData)
	{
		Dictionary<int, TrapDefenseBattleItemData> itemMap = TrapDefenseModel.Instance.BattleInventoryData.ItemMap;
		TrapDefenseShopItemPbInfo itemPbInfo = serverData.ItemPbInfo;
		TrapDefenseBattleItemData battleItemData;
		if (!itemMap.TryGetValue((itemPbInfo != null) ? itemPbInfo.ItemConfigId : 0, out battleItemData))
		{
			this.BattleItemData = null;
			return;
		}
		this.BattleItemData = battleItemData;
		this.Config = this.BattleItemData.Config;
		this.Id = this.Config.Id;
		this.Name = this.Config.Name;
		this.Desc = this.Config.Desc;
		this.Icon = this.Config.Icon;
		this.QualityId = this.Config.Quality;
		this.OriginalPrice = new int?(serverData.OriginalPrice);
		this.CurrentPrice = serverData.DiscountPrice;
		TrapDefenseShopItemPbInfo itemPbInfo2 = serverData.ItemPbInfo;
		this.Stock = ((itemPbInfo2 != null) ? itemPbInfo2.StockCount : 0);
	}

	// Token: 0x06015188 RID: 86408 RVA: 0x00624DDC File Offset: 0x00622FDC
	private PropMediumItemGrid BuildItemGridParam()
	{
		return new PropMediumItemGrid
		{
			ItemPrice = new MediumItemPrice
			{
				CurPrice = this.CurrentPrice,
				OriginalPrice = this.OriginalPrice
			},
			IconPath = this.Icon,
			QualityId = new int?(this.QualityId),
			IsDisable = new bool?(this.Disable)
		};
	}

	// Token: 0x06015189 RID: 86409 RVA: 0x00624E3F File Offset: 0x0062303F
	private void Init(TrapDefenseShopProductPbInfo serverData)
	{
		this.GetItemGridParam = new Func<PropMediumItemGrid>(this.BuildItemGridParam);
		this.Update(serverData);
	}

	// Token: 0x0400B355 RID: 45909
	public TrapDefenseItem Config;

	// Token: 0x0400B35E RID: 45918
	public int PurchaseLimit;

	// Token: 0x0400B35F RID: 45919
	public int Stock;

	// Token: 0x0400B360 RID: 45920
	[Nullable(2)]
	public TrapDefenseBattleItemData BattleItemData;
}
