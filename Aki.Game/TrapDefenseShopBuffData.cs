using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02002192 RID: 8594
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseShopBuffData : ITrapDefenseShopGoods
{
	// Token: 0x17001FFA RID: 8186
	// (get) Token: 0x0601518B RID: 86411 RVA: 0x00624E69 File Offset: 0x00623069
	// (set) Token: 0x0601518C RID: 86412 RVA: 0x00624E71 File Offset: 0x00623071
	public int Id { get; set; }

	// Token: 0x17001FFB RID: 8187
	// (get) Token: 0x0601518D RID: 86413 RVA: 0x00624E7A File Offset: 0x0062307A
	// (set) Token: 0x0601518E RID: 86414 RVA: 0x00624E82 File Offset: 0x00623082
	public int? OriginalPrice { get; set; }

	// Token: 0x17001FFC RID: 8188
	// (get) Token: 0x0601518F RID: 86415 RVA: 0x00624E8B File Offset: 0x0062308B
	// (set) Token: 0x06015190 RID: 86416 RVA: 0x00624E93 File Offset: 0x00623093
	public int CurrentPrice { get; set; }

	// Token: 0x17001FFD RID: 8189
	// (get) Token: 0x06015191 RID: 86417 RVA: 0x00624E9C File Offset: 0x0062309C
	// (set) Token: 0x06015192 RID: 86418 RVA: 0x00624EA4 File Offset: 0x006230A4
	public ETrapDefenseShopGoodsType Type { get; set; } = ETrapDefenseShopGoodsType.Buff;

	// Token: 0x17001FFE RID: 8190
	// (get) Token: 0x06015193 RID: 86419 RVA: 0x00624EAD File Offset: 0x006230AD
	// (set) Token: 0x06015194 RID: 86420 RVA: 0x00624EB5 File Offset: 0x006230B5
	public int QualityId { get; set; } = 1;

	// Token: 0x17001FFF RID: 8191
	// (get) Token: 0x06015195 RID: 86421 RVA: 0x00624EBE File Offset: 0x006230BE
	// (set) Token: 0x06015196 RID: 86422 RVA: 0x00624EC6 File Offset: 0x006230C6
	public string Name { get; set; }

	// Token: 0x17002000 RID: 8192
	// (get) Token: 0x06015197 RID: 86423 RVA: 0x00624ECF File Offset: 0x006230CF
	// (set) Token: 0x06015198 RID: 86424 RVA: 0x00624ED7 File Offset: 0x006230D7
	public string Desc { get; set; }

	// Token: 0x17002001 RID: 8193
	// (get) Token: 0x06015199 RID: 86425 RVA: 0x00624EE0 File Offset: 0x006230E0
	// (set) Token: 0x0601519A RID: 86426 RVA: 0x00624EE8 File Offset: 0x006230E8
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

	// Token: 0x17002002 RID: 8194
	// (get) Token: 0x0601519B RID: 86427 RVA: 0x00624EF1 File Offset: 0x006230F1
	// (set) Token: 0x0601519C RID: 86428 RVA: 0x00624EF9 File Offset: 0x006230F9
	public string Icon { get; set; }

	// Token: 0x17002003 RID: 8195
	// (get) Token: 0x0601519D RID: 86429 RVA: 0x00624F02 File Offset: 0x00623102
	// (set) Token: 0x0601519E RID: 86430 RVA: 0x00624F0A File Offset: 0x0062310A
	public int CanPurchaseNum { get; set; }

	// Token: 0x17002004 RID: 8196
	// (get) Token: 0x0601519F RID: 86431 RVA: 0x00624F13 File Offset: 0x00623113
	public bool Disable
	{
		get
		{
			return this.IsSold;
		}
	}

	// Token: 0x17002005 RID: 8197
	// (get) Token: 0x060151A0 RID: 86432 RVA: 0x00624F1B File Offset: 0x0062311B
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

	// Token: 0x17002006 RID: 8198
	// (get) Token: 0x060151A1 RID: 86433 RVA: 0x00624F28 File Offset: 0x00623128
	// (set) Token: 0x060151A2 RID: 86434 RVA: 0x00624F30 File Offset: 0x00623130
	public Func<PropMediumItemGrid> GetItemGridParam { get; set; }

	// Token: 0x060151A3 RID: 86435 RVA: 0x00624F39 File Offset: 0x00623139
	public static TrapDefenseShopBuffData Create(TrapDefenseShopProductPbInfo serverData)
	{
		TrapDefenseShopBuffData trapDefenseShopBuffData = new TrapDefenseShopBuffData();
		trapDefenseShopBuffData.Init(serverData);
		return trapDefenseShopBuffData;
	}

	// Token: 0x060151A4 RID: 86436 RVA: 0x00624F48 File Offset: 0x00623148
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

	// Token: 0x060151A5 RID: 86437 RVA: 0x006250BC File Offset: 0x006232BC
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

	// Token: 0x060151A6 RID: 86438 RVA: 0x00625130 File Offset: 0x00623330
	private void Init(TrapDefenseShopProductPbInfo serverData)
	{
		this.GetItemGridParam = new Func<PropMediumItemGrid>(this.BuildItemGridParam);
		this.Update(serverData);
	}

	// Token: 0x0400B363 RID: 45923
	public TrapDefenseBdBuff Config;

	// Token: 0x0400B36C RID: 45932
	public int PurchaseLimit;

	// Token: 0x0400B36E RID: 45934
	[Nullable(2)]
	public TrapDefenseBdBuffData BdBuffData;

	// Token: 0x0400B36F RID: 45935
	public bool IsSold;
}
