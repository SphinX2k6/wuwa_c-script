using System;
using System.Runtime.CompilerServices;

// Token: 0x02000783 RID: 1923
[NullableContext(1)]
[Nullable(0)]
public readonly struct EMapTravelAnim : IEquatable<EMapTravelAnim>
{
	// Token: 0x0600584E RID: 22606 RVA: 0x001CD42D File Offset: 0x001CB62D
	private EMapTravelAnim(string value)
	{
		this._Value = value;
	}

	// Token: 0x0600584F RID: 22607 RVA: 0x001CD436 File Offset: 0x001CB636
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06005850 RID: 22608 RVA: 0x001CD43E File Offset: 0x001CB63E
	public bool Equals(EMapTravelAnim other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06005851 RID: 22609 RVA: 0x001CD454 File Offset: 0x001CB654
	public override bool Equals(object obj)
	{
		if (obj is EMapTravelAnim)
		{
			EMapTravelAnim other = (EMapTravelAnim)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06005852 RID: 22610 RVA: 0x001CD479 File Offset: 0x001CB679
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06005853 RID: 22611 RVA: 0x001CD48C File Offset: 0x001CB68C
	public static bool operator ==(EMapTravelAnim left, EMapTravelAnim right)
	{
		return left.Equals(right);
	}

	// Token: 0x06005854 RID: 22612 RVA: 0x001CD496 File Offset: 0x001CB696
	public static bool operator !=(EMapTravelAnim left, EMapTravelAnim right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04003C28 RID: 15400
	private readonly string _Value;

	// Token: 0x04003C29 RID: 15401
	public static readonly EMapTravelAnim AniOpen = new EMapTravelAnim("AniOpen");

	// Token: 0x04003C2A RID: 15402
	public static readonly EMapTravelAnim AniClose = new EMapTravelAnim("AniClose");
}
