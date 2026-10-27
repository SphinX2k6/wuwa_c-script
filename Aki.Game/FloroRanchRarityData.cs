using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AF9 RID: 6905
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRarityData
{
	// Token: 0x0600CCF7 RID: 52471 RVA: 0x002EC843 File Offset: 0x002EAA43
	public FloroRanchRarityData(FloroRanchRarity config)
	{
		this.Config = config;
	}

	// Token: 0x170010F4 RID: 4340
	// (get) Token: 0x0600CCF8 RID: 52472 RVA: 0x002EC854 File Offset: 0x002EAA54
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x0600CCF9 RID: 52473 RVA: 0x002EC870 File Offset: 0x002EAA70
	public string GetRarityName()
	{
		return this.Config.Name;
	}

	// Token: 0x0600CCFA RID: 52474 RVA: 0x002EC88C File Offset: 0x002EAA8C
	public string GetRarityColor()
	{
		return this.Config.Color;
	}

	// Token: 0x0600CCFB RID: 52475 RVA: 0x002EC8A8 File Offset: 0x002EAAA8
	public string GetRarityDetailCardBigBg()
	{
		return this.Config.DetailCardBigBg;
	}

	// Token: 0x0600CCFC RID: 52476 RVA: 0x002EC8C4 File Offset: 0x002EAAC4
	public string GetRarityDetailCardSmallBg()
	{
		return this.Config.DetailCardSmallBg;
	}

	// Token: 0x0600CCFD RID: 52477 RVA: 0x002EC8E0 File Offset: 0x002EAAE0
	public string GetRaritySmallBg()
	{
		return this.Config.SmallCardBg;
	}

	// Token: 0x0600CCFE RID: 52478 RVA: 0x002EC8FC File Offset: 0x002EAAFC
	public string GetRarityShopItemBg()
	{
		return this.Config.ShopCardBg;
	}

	// Token: 0x0600CCFF RID: 52479 RVA: 0x002EC918 File Offset: 0x002EAB18
	public string GetSelectTexture()
	{
		return this.Config.SelectTexture;
	}

	// Token: 0x0600CD00 RID: 52480 RVA: 0x002EC934 File Offset: 0x002EAB34
	public bool IsGoldRarity()
	{
		return this.Config.Id == 4;
	}

	// Token: 0x0600CD01 RID: 52481 RVA: 0x002EC954 File Offset: 0x002EAB54
	public bool IsSpecialRarity()
	{
		return this.Config.Id == 5;
	}

	// Token: 0x04005E12 RID: 24082
	private const int GOLD_RARITY_ID = 4;

	// Token: 0x04005E13 RID: 24083
	private const int SPECIAL_RARITY_ID = 5;

	// Token: 0x04005E14 RID: 24084
	private readonly FloroRanchRarity Config;
}
