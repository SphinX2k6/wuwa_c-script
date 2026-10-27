using System;
using System.Runtime.CompilerServices;

// Token: 0x02002C66 RID: 11366
[NullableContext(1)]
[Nullable(0)]
public readonly struct ERoleFadeCurveDefine : IEquatable<ERoleFadeCurveDefine>
{
	// Token: 0x06017C0F RID: 97295 RVA: 0x00609D75 File Offset: 0x00607F75
	private ERoleFadeCurveDefine(string value)
	{
		this._value = value;
	}

	// Token: 0x06017C10 RID: 97296 RVA: 0x00609D7E File Offset: 0x00607F7E
	public override string ToString()
	{
		return this._value;
	}

	// Token: 0x06017C11 RID: 97297 RVA: 0x00609D86 File Offset: 0x00607F86
	public bool Equals(ERoleFadeCurveDefine other)
	{
		return this._value == other._value;
	}

	// Token: 0x06017C12 RID: 97298 RVA: 0x00609D9C File Offset: 0x00607F9C
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

	// Token: 0x06017C13 RID: 97299 RVA: 0x00609DC1 File Offset: 0x00607FC1
	public override int GetHashCode()
	{
		string value = this._value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06017C14 RID: 97300 RVA: 0x00609DD4 File Offset: 0x00607FD4
	public static bool operator ==(ERoleFadeCurveDefine? left, ERoleFadeCurveDefine? right)
	{
		return left.Equals(right);
	}

	// Token: 0x06017C15 RID: 97301 RVA: 0x00609DE9 File Offset: 0x00607FE9
	public static bool operator !=(ERoleFadeCurveDefine? left, ERoleFadeCurveDefine? right)
	{
		return !left.Equals(right);
	}

	// Token: 0x06017C16 RID: 97302 RVA: 0x00609E01 File Offset: 0x00608001
	public static implicit operator string(ERoleFadeCurveDefine def)
	{
		return def.ToString();
	}

	// Token: 0x0400B0D9 RID: 45273
	private readonly string _value;

	// Token: 0x0400B0DA RID: 45274
	public static readonly ERoleFadeCurveDefine None = new ERoleFadeCurveDefine("None");

	// Token: 0x0400B0DB RID: 45275
	public static readonly ERoleFadeCurveDefine RoleFadeInCurve = new ERoleFadeCurveDefine("RoleFadeInCurve");

	// Token: 0x0400B0DC RID: 45276
	public static readonly ERoleFadeCurveDefine RoleFadeOutCurve = new ERoleFadeCurveDefine("RoleFadeOutCurve");

	// Token: 0x0400B0DD RID: 45277
	public static readonly ERoleFadeCurveDefine WeaponSkinRoleFadeInCurve = new ERoleFadeCurveDefine("WeaponSkinRoleFadeInCurve");

	// Token: 0x0400B0DE RID: 45278
	public static readonly ERoleFadeCurveDefine WeaponSkinRoleFadeOutCurve = new ERoleFadeCurveDefine("WeaponSkinRoleFadeOutCurve");

	// Token: 0x0400B0DF RID: 45279
	public static readonly ERoleFadeCurveDefine FlySkinRoleFadeInCurve = new ERoleFadeCurveDefine("FlySkinRoleFadeInCurve");

	// Token: 0x0400B0E0 RID: 45280
	public static readonly ERoleFadeCurveDefine FlySkinRoleFadeOutCurve = new ERoleFadeCurveDefine("FlySkinRoleFadeOutCurve");

	// Token: 0x0400B0E1 RID: 45281
	public static readonly ERoleFadeCurveDefine TerminalSkinRoleFadeInCurve = new ERoleFadeCurveDefine("TerminalSkinRoleFadeInCurve");

	// Token: 0x0400B0E2 RID: 45282
	public static readonly ERoleFadeCurveDefine TerminalSkinRoleFadeOutCurve = new ERoleFadeCurveDefine("TerminalSkinRoleFadeOutCurve");
}
