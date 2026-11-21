using System;
using System.Runtime.CompilerServices;

// Token: 0x02000560 RID: 1376
[NullableContext(1)]
[Nullable(0)]
public readonly struct EActivityRewardSource : IEquatable<EActivityRewardSource>
{
	// Token: 0x060042AE RID: 17070 RVA: 0x00173DAB File Offset: 0x00171FAB
	private EActivityRewardSource(string value)
	{
		this._Value = value;
	}

	// Token: 0x060042AF RID: 17071 RVA: 0x00173DB4 File Offset: 0x00171FB4
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x060042B0 RID: 17072 RVA: 0x00173DBC File Offset: 0x00171FBC
	public bool Equals(EActivityRewardSource other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x060042B1 RID: 17073 RVA: 0x00173DD0 File Offset: 0x00171FD0
	public override bool Equals(object obj)
	{
		if (obj is EActivityRewardSource)
		{
			EActivityRewardSource other = (EActivityRewardSource)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x060042B2 RID: 17074 RVA: 0x00173DF5 File Offset: 0x00171FF5
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x060042B3 RID: 17075 RVA: 0x00173E08 File Offset: 0x00172008
	public static bool operator ==(EActivityRewardSource left, EActivityRewardSource right)
	{
		return left.Equals(right);
	}

	// Token: 0x060042B4 RID: 17076 RVA: 0x00173E12 File Offset: 0x00172012
	public static bool operator !=(EActivityRewardSource left, EActivityRewardSource right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04003443 RID: 13379
	private readonly string _Value;

	// Token: 0x04003444 RID: 13380
	public static readonly EActivityRewardSource BossRush = new EActivityRewardSource("BossRush");

	// Token: 0x04003445 RID: 13381
	public static readonly EActivityRewardSource Collection = new EActivityRewardSource("Collection");

	// Token: 0x04003446 RID: 13382
	public static readonly EActivityRewardSource MoonChasing = new EActivityRewardSource("MoonChasing");

	// Token: 0x04003447 RID: 13383
	public static readonly EActivityRewardSource Mowing = new EActivityRewardSource("Mowing");

	// Token: 0x04003448 RID: 13384
	public static readonly EActivityRewardSource MowingRisk = new EActivityRewardSource("MowingRisk");

	// Token: 0x04003449 RID: 13385
	public static readonly EActivityRewardSource DreamLink = new EActivityRewardSource("DreamLink");

	// Token: 0x0400344A RID: 13386
	public static readonly EActivityRewardSource DarkCoastDelivery = new EActivityRewardSource("DarkCoastDelivery");

	// Token: 0x0400344B RID: 13387
	public static readonly EActivityRewardSource TowerDefence = new EActivityRewardSource("TowerDefence");

	// Token: 0x0400344C RID: 13388
	public static readonly EActivityRewardSource FarmGold = new EActivityRewardSource("FarmGold");

	// Token: 0x0400344D RID: 13389
	public static readonly EActivityRewardSource WeeklyRogue = new EActivityRewardSource("WeeklyRogue");

	// Token: 0x0400344E RID: 13390
	public static readonly EActivityRewardSource RogueRes = new EActivityRewardSource("RogueRes");

	// Token: 0x0400344F RID: 13391
	public static readonly EActivityRewardSource Infrastructure = new EActivityRewardSource("Infrastructure");
}
