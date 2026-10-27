using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02002C16 RID: 11286
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseShopItemData : ITrapDefenseShopGoods
{
	// Token: 0x17001F94 RID: 8084
	// (get) Token: 0x0601773C RID: 96060 RVA: 0x005F806C File Offset: 0x005F626C
	// (set) Token: 0x0601773D RID: 96061 RVA: 0x005F8074 File Offset: 0x005F6274
	public int Id { get; set; }

	// Token: 0x17001F95 RID: 8085
	// (get) Token: 0x0601773E RID: 96062 RVA: 0x005F807D File Offset: 0x005F627D
	// (set) Token: 0x0601773F RID: 96063 RVA: 0x005F8085 File Offset: 0x005F6285
	public int? OriginalPrice { get; set; }

	// Token: 0x17001F96 RID: 8086
	// (get) Token: 0x06017740 RID: 96064 RVA: 0x005F808E File Offset: 0x005F628E
	// (set) Token: 0x06017741 RID: 96065 RVA: 0x005F8096 File Offset: 0x005F6296
	public int CurrentPrice { get; set; }

	// Token: 0x17001F97 RID: 8087
	// (get) Token: 0x06017742 RID: 96066 RVA: 0x005F809F File Offset: 0x005F629F
	// (set) Token: 0x06017743 RID: 96067 RVA: 0x005F80A7 File Offset: 0x005F62A7
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

	// Token: 0x17001F98 RID: 8088
	// (get) Token: 0x06017744 RID: 96068 RVA: 0x005F80B0 File Offset: 0x005F62B0
	// (set) Token: 0x06017745 RID: 96069 RVA: 0x005F80B8 File Offset: 0x005F62B8
	public ETrapDefenseShopGoodsType Type { get; set; }

	// Token: 0x17001F99 RID: 8089
	// (get) Token: 0x06017746 RID: 96070 RVA: 0x005F80C1 File Offset: 0x005F62C1
	// (set) Token: 0x06017747 RID: 96071 RVA: 0x005F80C9 File Offset: 0x005F62C9
	public int QualityId { get; set; } = 1;

	// Token: 0x17001F9A RID: 8090
	// (get) Token: 0x06017748 RID: 96072 RVA: 0x005F80D2 File Offset: 0x005F62D2
	// (set) Token: 0x06017749 RID: 96073 RVA: 0x005F80DA File Offset: 0x005F62DA
	public string Name { get; set; }

	// Token: 0x17001F9B RID: 8091
	// (get) Token: 0x0601774A RID: 96074 RVA: 0x005F80E3 File Offset: 0x005F62E3
	// (set) Token: 0x0601774B RID: 96075 RVA: 0x005F80EB File Offset: 0x005F62EB
	public string Desc { get; set; }

	// Token: 0x17001F9C RID: 8092
	// (get) Token: 0x0601774C RID: 96076 RVA: 0x005F80F4 File Offset: 0x005F62F4
	// (set) Token: 0x0601774D RID: 96077 RVA: 0x005F80FC File Offset: 0x005F62FC
	public string Icon { get; set; }

	// Token: 0x17001F9D RID: 8093
	// (get) Token: 0x0601774E RID: 96078 RVA: 0x005F8108 File Offset: 0x005F6308
	public int CanPurchaseNum
	{
		get
		{
			int val = (int)Math.Floor((double)((float)TrapDefenseModel.Instance.BattleData.GetGoldNum() / (float)((this.CurrentPrice != 0) ? this.CurrentPrice : 1)));
			int val2 = this.BattleItemData.LimitCount - this.BattleItemData.InventoryCount;
			return Math.Min(Math.Min(val, val2), this.Stock);
		}
	}

	// Token: 0x17001F9E RID: 8094
	// (get) Token: 0x0601774F RID: 96079 RVA: 0x005F8168 File Offset: 0x005F6368
	public bool InventoryCountReachLimit
	{
		get
		{
			return this.BattleItemData.InventoryCount >= this.BattleItemData.LimitCount;
		}
	}

	// Token: 0x17001F9F RID: 8095
	// (get) Token: 0x06017750 RID: 96080 RVA: 0x005F8185 File Offset: 0x005F6385
	public bool Disable
	{
		get
		{
			return this.InventoryCountReachLimit || this.Stock <= 0;
		}
	}

	// Token: 0x17001FA0 RID: 8096
	// (get) Token: 0x06017751 RID: 96081 RVA: 0x005F819D File Offset: 0x005F639D
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

	// Token: 0x17001FA1 RID: 8097
	// (get) Token: 0x06017752 RID: 96082 RVA: 0x005F81B5 File Offset: 0x005F63B5
	// (set) Token: 0x06017753 RID: 96083 RVA: 0x005F81BD File Offset: 0x005F63BD
	public Func<PropMediumItemGrid> GetItemGridParam { get; set; }

	// Token: 0x06017754 RID: 96084 RVA: 0x005F81C6 File Offset: 0x005F63C6
	public static TrapDefenseShopItemData Create(TrapDefenseShopProductPbInfo serverData)
	{
		TrapDefenseShopItemData trapDefenseShopItemData = new TrapDefenseShopItemData();
		trapDefenseShopItemData.Init(serverData);
		return trapDefenseShopItemData;
	}

	// Token: 0x06017755 RID: 96085 RVA: 0x005F81D4 File Offset: 0x005F63D4
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

	// Token: 0x06017756 RID: 96086 RVA: 0x005F82B8 File Offset: 0x005F64B8
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

	// Token: 0x06017757 RID: 96087 RVA: 0x005F831B File Offset: 0x005F651B
	private void Init(TrapDefenseShopProductPbInfo serverData)
	{
		this.GetItemGridParam = new Func<PropMediumItemGrid>(this.BuildItemGridParam);
		this.Update(serverData);
	}

	// Token: 0x0400AF50 RID: 44880
	public TrapDefenseItem Config;

	// Token: 0x0400AF59 RID: 44889
	public int PurchaseLimit;

	// Token: 0x0400AF5A RID: 44890
	public int Stock;

	// Token: 0x0400AF5B RID: 44891
	[Nullable(2)]
	public TrapDefenseBattleItemData BattleItemData;
}
