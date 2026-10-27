using System;
using System.Runtime.CompilerServices;

// Token: 0x020012CF RID: 4815
[NullableContext(1)]
[Nullable(0)]
public readonly struct EMapTravelAnim : IEquatable<EMapTravelAnim>
{
	// Token: 0x060084B3 RID: 33971 RVA: 0x001C45D1 File Offset: 0x001C27D1
	private EMapTravelAnim(string value)
	{
		this._Value = value;
	}

	// Token: 0x060084B4 RID: 33972 RVA: 0x001C45DA File Offset: 0x001C27DA
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x060084B5 RID: 33973 RVA: 0x001C45E2 File Offset: 0x001C27E2
	public bool Equals(EMapTravelAnim other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x060084B6 RID: 33974 RVA: 0x001C45F8 File Offset: 0x001C27F8
	public override bool Equals(object obj)
	{
		if (obj is EMapTravelAnim)
		{
			EMapTravelAnim other = (EMapTravelAnim)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x060084B7 RID: 33975 RVA: 0x001C461D File Offset: 0x001C281D
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x060084B8 RID: 33976 RVA: 0x001C4630 File Offset: 0x001C2830
	public static bool operator ==(EMapTravelAnim left, EMapTravelAnim right)
	{
		return left.Equals(right);
	}

	// Token: 0x060084B9 RID: 33977 RVA: 0x001C463A File Offset: 0x001C283A
	public static bool operator !=(EMapTravelAnim left, EMapTravelAnim right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04003B90 RID: 15248
	private readonly string _Value;

	// Token: 0x04003B91 RID: 15249
	public static readonly EMapTravelAnim AniOpen = new EMapTravelAnim("AniOpen");

	// Token: 0x04003B92 RID: 15250
	public static readonly EMapTravelAnim AniClose = new EMapTravelAnim("AniClose");
}
