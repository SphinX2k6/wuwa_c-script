using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02002C17 RID: 11287
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseShopBuffData : ITrapDefenseShopGoods
{
	// Token: 0x17001FA2 RID: 8098
	// (get) Token: 0x06017759 RID: 96089 RVA: 0x005F8345 File Offset: 0x005F6545
	// (set) Token: 0x0601775A RID: 96090 RVA: 0x005F834D File Offset: 0x005F654D
	public int Id { get; set; }

	// Token: 0x17001FA3 RID: 8099
	// (get) Token: 0x0601775B RID: 96091 RVA: 0x005F8356 File Offset: 0x005F6556
	// (set) Token: 0x0601775C RID: 96092 RVA: 0x005F835E File Offset: 0x005F655E
	public int? OriginalPrice { get; set; }

	// Token: 0x17001FA4 RID: 8100
	// (get) Token: 0x0601775D RID: 96093 RVA: 0x005F8367 File Offset: 0x005F6567
	// (set) Token: 0x0601775E RID: 96094 RVA: 0x005F836F File Offset: 0x005F656F
	public int CurrentPrice { get; set; }

	// Token: 0x17001FA5 RID: 8101
	// (get) Token: 0x0601775F RID: 96095 RVA: 0x005F8378 File Offset: 0x005F6578
	// (set) Token: 0x06017760 RID: 96096 RVA: 0x005F8380 File Offset: 0x005F6580
	public ETrapDefenseShopGoodsType Type { get; set; } = ETrapDefenseShopGoodsType.Buff;

	// Token: 0x17001FA6 RID: 8102
	// (get) Token: 0x06017761 RID: 96097 RVA: 0x005F8389 File Offset: 0x005F6589
	// (set) Token: 0x06017762 RID: 96098 RVA: 0x005F8391 File Offset: 0x005F6591
	public int QualityId { get; set; } = 1;

	// Token: 0x17001FA7 RID: 8103
	// (get) Token: 0x06017763 RID: 96099 RVA: 0x005F839A File Offset: 0x005F659A
	// (set) Token: 0x06017764 RID: 96100 RVA: 0x005F83A2 File Offset: 0x005F65A2
	public string Name { get; set; }

	// Token: 0x17001FA8 RID: 8104
	// (get) Token: 0x06017765 RID: 96101 RVA: 0x005F83AB File Offset: 0x005F65AB
	// (set) Token: 0x06017766 RID: 96102 RVA: 0x005F83B3 File Offset: 0x005F65B3
	public string Desc { get; set; }

	// Token: 0x17001FA9 RID: 8105
	// (get) Token: 0x06017767 RID: 96103 RVA: 0x005F83BC File Offset: 0x005F65BC
	// (set) Token: 0x06017768 RID: 96104 RVA: 0x005F83C4 File Offset: 0x005F65C4
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

	// Token: 0x17001FAA RID: 8106
	// (get) Token: 0x06017769 RID: 96105 RVA: 0x005F83CD File Offset: 0x005F65CD
	// (set) Token: 0x0601776A RID: 96106 RVA: 0x005F83D5 File Offset: 0x005F65D5
	public string Icon { get; set; }

	// Token: 0x17001FAB RID: 8107
	// (get) Token: 0x0601776B RID: 96107 RVA: 0x005F83DE File Offset: 0x005F65DE
	// (set) Token: 0x0601776C RID: 96108 RVA: 0x005F83E6 File Offset: 0x005F65E6
	public int CanPurchaseNum { get; set; }

	// Token: 0x17001FAC RID: 8108
	// (get) Token: 0x0601776D RID: 96109 RVA: 0x005F83EF File Offset: 0x005F65EF
	public bool Disable
	{
		get
		{
			return this.IsSold;
		}
	}

	// Token: 0x17001FAD RID: 8109
	// (get) Token: 0x0601776E RID: 96110 RVA: 0x005F83F7 File Offset: 0x005F65F7
	public ETrapDefenseShopGoodsUnavailableReason DisableReason
	{
		get
		{
			if (this.IsSold)
			{
				return ETrapDefenseShopGoodsUnavailableReason.SoldOut;
			}
			return ETrapDefenseShopGoodsUnavailableReason.None;
		}
	}

	// Token: 0x17001FAE RID: 8110
	// (get) Token: 0x0601776F RID: 96111 RVA: 0x005F8404 File Offset: 0x005F6604
	// (set) Token: 0x06017770 RID: 96112 RVA: 0x005F840C File Offset: 0x005F660C
	public Func<PropMediumItemGrid> GetItemGridParam { get; set; }

	// Token: 0x06017771 RID: 96113 RVA: 0x005F8415 File Offset: 0x005F6615
	public static TrapDefenseShopBuffData Create(TrapDefenseShopProductPbInfo serverData)
	{
		TrapDefenseShopBuffData trapDefenseShopBuffData = new TrapDefenseShopBuffData();
		trapDefenseShopBuffData.Init(serverData);
		return trapDefenseShopBuffData;
	}

	// Token: 0x06017772 RID: 96114 RVA: 0x005F8424 File Offset: 0x005F6624
	public void Update(TrapDefenseShopProductPbInfo serverData)
	{
		TrapDefenseShopBdGroupPbInfo bdGroupPbInfo = serverData.BdGroupPbInfo;
		this.Id = ((bdGroupPbInfo != null) ? bdGroupPbInfo.BdGrougConfigId : 0);
		TrapDefenseRougeModeData rougeModeData = TrapDefenseModel.Instance.RougeModeData;
		TrapDefenseBdBuffData bdBuffData;
		if (rougeModeData != null && rougeModeData.BdBuffDataMap.TryGetValue(this.Id, out bdBuffData))
		{
			this.BdBuffData = bdBuffData;
		}
		else
		{
			this.BdBuffData = null;
		}
		if (this.BdBuffData == null)
		{
			return;
		}
		if (this.BdBuffData.IsActive && this.BdBuffData.Level < this.BdBuffData.MaxLevel)
		{
			this.Config = (TrapDefenseConfig.Instance.GetBdBuffByLevelAndGroup(this.BdBuffData.Level + 1, this.BdBuffData.Config.Id) ?? this.BdBuffData.BdBuffConfig);
		}
		else
		{
			this.Config = this.BdBuffData.BdBuffConfig;
		}
		this.Name = this.Config.Name;
		this.Desc = this.Config.Desc;
		this.DescArgs = this.Config.DescArgs();
		this.Icon = this.Config.Icon;
		this.QualityId = this.BdBuffData.Config.Quality;
		this.OriginalPrice = new int?(serverData.OriginalPrice);
		this.CurrentPrice = serverData.DiscountPrice;
		TrapDefenseShopBdGroupPbInfo bdGroupPbInfo2 = serverData.BdGroupPbInfo;
		this.IsSold = (bdGroupPbInfo2 != null && bdGroupPbInfo2.IsSold);
	}

	// Token: 0x06017773 RID: 96115 RVA: 0x005F8598 File Offset: 0x005F6798
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
			IsDisable = new bool?(this.Disable),
			SubIconPath = this.Config.SubIcon
		};
	}

	// Token: 0x06017774 RID: 96116 RVA: 0x005F860C File Offset: 0x005F680C
	private void Init(TrapDefenseShopProductPbInfo serverData)
	{
		this.GetItemGridParam = new Func<PropMediumItemGrid>(this.BuildItemGridParam);
		this.Update(serverData);
	}

	// Token: 0x0400AF5E RID: 44894
	public TrapDefenseBdBuff Config;

	// Token: 0x0400AF67 RID: 44903
	public int PurchaseLimit;

	// Token: 0x0400AF69 RID: 44905
	[Nullable(2)]
	public TrapDefenseBdBuffData BdBuffData;

	// Token: 0x0400AF6A RID: 44906
	public bool IsSold;
}
