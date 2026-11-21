using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FBA RID: 4026
[NullableContext(1)]
[Nullable(0)]
public abstract class FloroRanchShopItemDataBase
{
	// Token: 0x0600A114 RID: 41236 RVA: 0x002F7A68 File Offset: 0x002F5C68
	public FloroRanchShopItemDataBase(FloroRanchShopItem data)
	{
		this.IncId = data.IncId;
		this.Id = data.Id;
		this.Price = data.Price;
		this.Type = data.Type;
		this.IsSold = data.Sold;
	}

	// Token: 0x0600A115 RID: 41237
	public abstract string GetName();

	// Token: 0x1700111A RID: 4378
	// (get) Token: 0x0600A116 RID: 41238
	public abstract string Desc { get; }

	// Token: 0x0600A117 RID: 41239
	public abstract string GetIcon();

	// Token: 0x0600A118 RID: 41240
	public abstract FloroRanchRarityData GetQualityData();

	// Token: 0x0600A119 RID: 41241
	public abstract int GetRace();

	// Token: 0x0600A11A RID: 41242
	public abstract int GetEarnCount();

	// Token: 0x0600A11B RID: 41243 RVA: 0x002F7AB7 File Offset: 0x002F5CB7
	public virtual bool GetIsSpecialPhantom()
	{
		return false;
	}

	// Token: 0x0600A11C RID: 41244 RVA: 0x002F7ABA File Offset: 0x002F5CBA
	[NullableContext(2)]
	public virtual FloroRanchRaceData GetToyRaceData()
	{
		return null;
	}

	// Token: 0x04005EE4 RID: 24292
	public int IncId;

	// Token: 0x04005EE5 RID: 24293
	public int Id;

	// Token: 0x04005EE6 RID: 24294
	public int Price;

	// Token: 0x04005EE7 RID: 24295
	public FloroRanchShopItemType Type;

	// Token: 0x04005EE8 RID: 24296
	public bool IsSold;
}
