using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FB8 RID: 4024
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRarityData
{
	// Token: 0x0600A108 RID: 41224 RVA: 0x002F792F File Offset: 0x002F5B2F
	public FloroRanchRarityData(FloroRanchRarity config)
	{
		this.Config = config;
	}

	// Token: 0x17001119 RID: 4377
	// (get) Token: 0x0600A109 RID: 41225 RVA: 0x002F7940 File Offset: 0x002F5B40
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x0600A10A RID: 41226 RVA: 0x002F795C File Offset: 0x002F5B5C
	public string GetRarityName()
	{
		return this.Config.Name;
	}

	// Token: 0x0600A10B RID: 41227 RVA: 0x002F7978 File Offset: 0x002F5B78
	public string GetRarityColor()
	{
		return this.Config.Color;
	}

	// Token: 0x0600A10C RID: 41228 RVA: 0x002F7994 File Offset: 0x002F5B94
	public string GetRarityDetailCardBigBg()
	{
		return this.Config.DetailCardBigBg;
	}

	// Token: 0x0600A10D RID: 41229 RVA: 0x002F79B0 File Offset: 0x002F5BB0
	public string GetRarityDetailCardSmallBg()
	{
		return this.Config.DetailCardSmallBg;
	}

	// Token: 0x0600A10E RID: 41230 RVA: 0x002F79CC File Offset: 0x002F5BCC
	public string GetRaritySmallBg()
	{
		return this.Config.SmallCardBg;
	}

	// Token: 0x0600A10F RID: 41231 RVA: 0x002F79E8 File Offset: 0x002F5BE8
	public string GetRarityShopItemBg()
	{
		return this.Config.ShopCardBg;
	}

	// Token: 0x0600A110 RID: 41232 RVA: 0x002F7A04 File Offset: 0x002F5C04
	public string GetSelectTexture()
	{
		return this.Config.SelectTexture;
	}

	// Token: 0x0600A111 RID: 41233 RVA: 0x002F7A20 File Offset: 0x002F5C20
	public bool IsGoldRarity()
	{
		return this.Config.Id == 4;
	}

	// Token: 0x0600A112 RID: 41234 RVA: 0x002F7A40 File Offset: 0x002F5C40
	public bool IsSpecialRarity()
	{
		return this.Config.Id == 5;
	}

	// Token: 0x04005EE1 RID: 24289
	private const int GOLD_RARITY_ID = 4;

	// Token: 0x04005EE2 RID: 24290
	private const int SPECIAL_RARITY_ID = 5;

	// Token: 0x04005EE3 RID: 24291
	private readonly FloroRanchRarity Config;
}
