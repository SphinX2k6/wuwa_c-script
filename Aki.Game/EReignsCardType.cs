using System;
using System.Runtime.CompilerServices;

// Token: 0x0200203F RID: 8255
[NullableContext(1)]
[Nullable(0)]
public readonly struct EReignsCardType : IEquatable<EReignsCardType>
{
	// Token: 0x06010353 RID: 66387 RVA: 0x003F2F38 File Offset: 0x003F1138
	private EReignsCardType(string value)
	{
		this._Value = value;
	}

	// Token: 0x06010354 RID: 66388 RVA: 0x003F2F41 File Offset: 0x003F1141
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06010355 RID: 66389 RVA: 0x003F2F49 File Offset: 0x003F1149
	public bool Equals(EReignsCardType other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06010356 RID: 66390 RVA: 0x003F2F5C File Offset: 0x003F115C
	public override bool Equals(object obj)
	{
		if (obj is EReignsCardType)
		{
			EReignsCardType other = (EReignsCardType)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06010357 RID: 66391 RVA: 0x003F2F81 File Offset: 0x003F1181
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06010358 RID: 66392 RVA: 0x003F2F94 File Offset: 0x003F1194
	public static bool operator ==(EReignsCardType left, EReignsCardType right)
	{
		return left.Equals(right);
	}

	// Token: 0x06010359 RID: 66393 RVA: 0x003F2F9E File Offset: 0x003F119E
	public static bool operator !=(EReignsCardType left, EReignsCardType right)
	{
		return !left.Equals(right);
	}

	// Token: 0x040077E2 RID: 30690
	private readonly string _Value;

	// Token: 0x040077E3 RID: 30691
	public static readonly EReignsCardType OptionResultCard = new EReignsCardType("OptionCard");

	// Token: 0x040077E4 RID: 30692
	public static readonly EReignsCardType AchievementResultCard = new EReignsCardType("AchievementCard");

	// Token: 0x040077E5 RID: 30693
	public static readonly EReignsCardType Settlement = new EReignsCardType("Settlement");

	// Token: 0x040077E6 RID: 30694
	public static readonly EReignsCardType StaticImage = new EReignsCardType("StaticImage");

	// Token: 0x040077E7 RID: 30695
	public static readonly EReignsCardType BuffCard = new EReignsCardType("BuffCard");
}
