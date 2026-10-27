using System;
using System.Runtime.CompilerServices;

// Token: 0x020010AC RID: 4268
[NullableContext(1)]
[Nullable(0)]
public readonly struct EActivityRewardSource : IEquatable<EActivityRewardSource>
{
	// Token: 0x06006F18 RID: 28440 RVA: 0x0016B433 File Offset: 0x00169633
	private EActivityRewardSource(string value)
	{
		this._Value = value;
	}

	// Token: 0x06006F19 RID: 28441 RVA: 0x0016B43C File Offset: 0x0016963C
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06006F1A RID: 28442 RVA: 0x0016B444 File Offset: 0x00169644
	public bool Equals(EActivityRewardSource other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06006F1B RID: 28443 RVA: 0x0016B458 File Offset: 0x00169658
	public override bool Equals(object obj)
	{
		if (obj is EActivityRewardSource)
		{
			EActivityRewardSource other = (EActivityRewardSource)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06006F1C RID: 28444 RVA: 0x0016B47D File Offset: 0x0016967D
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06006F1D RID: 28445 RVA: 0x0016B490 File Offset: 0x00169690
	public static bool operator ==(EActivityRewardSource left, EActivityRewardSource right)
	{
		return left.Equals(right);
	}

	// Token: 0x06006F1E RID: 28446 RVA: 0x0016B49A File Offset: 0x0016969A
	public static bool operator !=(EActivityRewardSource left, EActivityRewardSource right)
	{
		return !left.Equals(right);
	}

	// Token: 0x040033AA RID: 13226
	private readonly string _Value;

	// Token: 0x040033AB RID: 13227
	public static readonly EActivityRewardSource BossRush = new EActivityRewardSource("BossRush");

	// Token: 0x040033AC RID: 13228
	public static readonly EActivityRewardSource Collection = new EActivityRewardSource("Collection");

	// Token: 0x040033AD RID: 13229
	public static readonly EActivityRewardSource MoonChasing = new EActivityRewardSource("MoonChasing");

	// Token: 0x040033AE RID: 13230
	public static readonly EActivityRewardSource Mowing = new EActivityRewardSource("Mowing");

	// Token: 0x040033AF RID: 13231
	public static readonly EActivityRewardSource MowingRisk = new EActivityRewardSource("MowingRisk");

	// Token: 0x040033B0 RID: 13232
	public static readonly EActivityRewardSource DreamLink = new EActivityRewardSource("DreamLink");

	// Token: 0x040033B1 RID: 13233
	public static readonly EActivityRewardSource DarkCoastDelivery = new EActivityRewardSource("DarkCoastDelivery");

	// Token: 0x040033B2 RID: 13234
	public static readonly EActivityRewardSource TowerDefence = new EActivityRewardSource("TowerDefence");

	// Token: 0x040033B3 RID: 13235
	public static readonly EActivityRewardSource FarmGold = new EActivityRewardSource("FarmGold");

	// Token: 0x040033B4 RID: 13236
	public static readonly EActivityRewardSource WeeklyRogue = new EActivityRewardSource("WeeklyRogue");

	// Token: 0x040033B5 RID: 13237
	public static readonly EActivityRewardSource RogueRes = new EActivityRewardSource("RogueRes");

	// Token: 0x040033B6 RID: 13238
	public static readonly EActivityRewardSource Infrastructure = new EActivityRewardSource("Infrastructure");
}
