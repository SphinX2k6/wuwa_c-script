using System;
using System.Runtime.CompilerServices;

// Token: 0x020021BF RID: 8639
[NullableContext(1)]
[Nullable(0)]
public readonly struct ERoleFadeCurveDefine : IEquatable<ERoleFadeCurveDefine>
{
	// Token: 0x06015481 RID: 87169 RVA: 0x0062F81D File Offset: 0x0062DA1D
	private ERoleFadeCurveDefine(string value)
	{
		this._value = value;
	}

	// Token: 0x06015482 RID: 87170 RVA: 0x0062F826 File Offset: 0x0062DA26
	public override string ToString()
	{
		return this._value;
	}

	// Token: 0x06015483 RID: 87171 RVA: 0x0062F82E File Offset: 0x0062DA2E
	public bool Equals(ERoleFadeCurveDefine other)
	{
		return this._value == other._value;
	}

	// Token: 0x06015484 RID: 87172 RVA: 0x0062F844 File Offset: 0x0062DA44
	[NullableContext(2)]
	public override bool Equals(object obj)
	{
		if (obj is ERoleFadeCurveDefine)
		{
			ERoleFadeCurveDefine other = (ERoleFadeCurveDefine)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06015485 RID: 87173 RVA: 0x0062F869 File Offset: 0x0062DA69
	public override int GetHashCode()
	{
		string value = this._value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06015486 RID: 87174 RVA: 0x0062F87C File Offset: 0x0062DA7C
	public static bool operator ==(ERoleFadeCurveDefine? left, ERoleFadeCurveDefine? right)
	{
		return left.Equals(right);
	}

	// Token: 0x06015487 RID: 87175 RVA: 0x0062F891 File Offset: 0x0062DA91
	public static bool operator !=(ERoleFadeCurveDefine? left, ERoleFadeCurveDefine? right)
	{
		return !left.Equals(right);
	}

	// Token: 0x06015488 RID: 87176 RVA: 0x0062F8A9 File Offset: 0x0062DAA9
	public static implicit operator string(ERoleFadeCurveDefine def)
	{
		return def.ToString();
	}

	// Token: 0x0400B444 RID: 46148
	private readonly string _value;

	// Token: 0x0400B445 RID: 46149
	public static readonly ERoleFadeCurveDefine None = new ERoleFadeCurveDefine("None");

	// Token: 0x0400B446 RID: 46150
	public static readonly ERoleFadeCurveDefine RoleFadeInCurve = new ERoleFadeCurveDefine("RoleFadeInCurve");

	// Token: 0x0400B447 RID: 46151
	public static readonly ERoleFadeCurveDefine RoleFadeOutCurve = new ERoleFadeCurveDefine("RoleFadeOutCurve");

	// Token: 0x0400B448 RID: 46152
	public static readonly ERoleFadeCurveDefine WeaponSkinRoleFadeInCurve = new ERoleFadeCurveDefine("WeaponSkinRoleFadeInCurve");

	// Token: 0x0400B449 RID: 46153
	public static readonly ERoleFadeCurveDefine WeaponSkinRoleFadeOutCurve = new ERoleFadeCurveDefine("WeaponSkinRoleFadeOutCurve");

	// Token: 0x0400B44A RID: 46154
	public static readonly ERoleFadeCurveDefine FlySkinRoleFadeInCurve = new ERoleFadeCurveDefine("FlySkinRoleFadeInCurve");

	// Token: 0x0400B44B RID: 46155
	public static readonly ERoleFadeCurveDefine FlySkinRoleFadeOutCurve = new ERoleFadeCurveDefine("FlySkinRoleFadeOutCurve");

	// Token: 0x0400B44C RID: 46156
	public static readonly ERoleFadeCurveDefine TerminalSkinRoleFadeInCurve = new ERoleFadeCurveDefine("TerminalSkinRoleFadeInCurve");

	// Token: 0x0400B44D RID: 46157
	public static readonly ERoleFadeCurveDefine TerminalSkinRoleFadeOutCurve = new ERoleFadeCurveDefine("TerminalSkinRoleFadeOutCurve");
}
