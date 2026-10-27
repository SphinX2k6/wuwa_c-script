using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001AFB RID: 6907
[NullableContext(1)]
[Nullable(0)]
public abstract class FloroRanchShopItemDataBase
{
	// Token: 0x0600CD03 RID: 52483 RVA: 0x002EC97C File Offset: 0x002EAB7C
	public FloroRanchShopItemDataBase(FloroRanchShopItem data)
	{
		this.IncId = data.IncId;
		this.Id = data.Id;
		this.Price = data.Price;
		this.Type = data.Type;
		this.IsSold = data.Sold;
	}

	// Token: 0x0600CD04 RID: 52484
	public abstract string GetName();

	// Token: 0x170010F5 RID: 4341
	// (get) Token: 0x0600CD05 RID: 52485
	public abstract string Desc { get; }

	// Token: 0x0600CD06 RID: 52486
	public abstract string GetIcon();

	// Token: 0x0600CD07 RID: 52487
	public abstract FloroRanchRarityData GetQualityData();

	// Token: 0x0600CD08 RID: 52488
	public abstract int GetRace();

	// Token: 0x0600CD09 RID: 52489
	public abstract int GetEarnCount();

	// Token: 0x0600CD0A RID: 52490 RVA: 0x002EC9CB File Offset: 0x002EABCB
	public virtual bool GetIsSpecialPhantom()
	{
		return false;
	}

	// Token: 0x0600CD0B RID: 52491 RVA: 0x002EC9CE File Offset: 0x002EABCE
	[NullableContext(2)]
	public virtual FloroRanchRaceData GetToyRaceData()
	{
		return null;
	}

	// Token: 0x04005E15 RID: 24085
	public int IncId;

	// Token: 0x04005E16 RID: 24086
	public int Id;

	// Token: 0x04005E17 RID: 24087
	public int Price;

	// Token: 0x04005E18 RID: 24088
	public FloroRanchShopItemType Type;

	// Token: 0x04005E19 RID: 24089
	public bool IsSold;
}
