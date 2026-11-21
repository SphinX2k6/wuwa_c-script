using System;
using System.Runtime.CompilerServices;

// Token: 0x02001512 RID: 5394
[NullableContext(1)]
[Nullable(0)]
public readonly struct EReignsCardType : IEquatable<EReignsCardType>
{
	// Token: 0x0600D7BB RID: 55227 RVA: 0x003FF530 File Offset: 0x003FD730
	private EReignsCardType(string value)
	{
		this._Value = value;
	}

	// Token: 0x0600D7BC RID: 55228 RVA: 0x003FF539 File Offset: 0x003FD739
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x0600D7BD RID: 55229 RVA: 0x003FF541 File Offset: 0x003FD741
	public bool Equals(EReignsCardType other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x0600D7BE RID: 55230 RVA: 0x003FF554 File Offset: 0x003FD754
	public override bool Equals(object obj)
	{
		if (obj is EReignsCardType)
		{
			EReignsCardType other = (EReignsCardType)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0600D7BF RID: 55231 RVA: 0x003FF579 File Offset: 0x003FD779
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x0600D7C0 RID: 55232 RVA: 0x003FF58C File Offset: 0x003FD78C
	public static bool operator ==(EReignsCardType left, EReignsCardType right)
	{
		return left.Equals(right);
	}

	// Token: 0x0600D7C1 RID: 55233 RVA: 0x003FF596 File Offset: 0x003FD796
	public static bool operator !=(EReignsCardType left, EReignsCardType right)
	{
		return !left.Equals(right);
	}

	// Token: 0x040078CB RID: 30923
	private readonly string _Value;

	// Token: 0x040078CC RID: 30924
	public static readonly EReignsCardType OptionResultCard = new EReignsCardType("OptionCard");

	// Token: 0x040078CD RID: 30925
	public static readonly EReignsCardType AchievementResultCard = new EReignsCardType("AchievementCard");

	// Token: 0x040078CE RID: 30926
	public static readonly EReignsCardType Settlement = new EReignsCardType("Settlement");

	// Token: 0x040078CF RID: 30927
	public static readonly EReignsCardType StaticImage = new EReignsCardType("StaticImage");

	// Token: 0x040078D0 RID: 30928
	public static readonly EReignsCardType BuffCard = new EReignsCardType("BuffCard");
}
