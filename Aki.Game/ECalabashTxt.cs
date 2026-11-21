using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BEC RID: 3052
[NullableContext(1)]
[Nullable(0)]
public readonly struct ECalabashTxt : IEquatable<ECalabashTxt>
{
	// Token: 0x06007F8F RID: 32655 RVA: 0x00272227 File Offset: 0x00270427
	private ECalabashTxt(string value)
	{
		this._Value = value;
	}

	// Token: 0x06007F90 RID: 32656 RVA: 0x00272230 File Offset: 0x00270430
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06007F91 RID: 32657 RVA: 0x00272238 File Offset: 0x00270438
	public bool Equals(ECalabashTxt other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06007F92 RID: 32658 RVA: 0x0027224C File Offset: 0x0027044C
	public override bool Equals(object obj)
	{
		if (obj is ECalabashTxt)
		{
			ECalabashTxt other = (ECalabashTxt)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06007F93 RID: 32659 RVA: 0x00272271 File Offset: 0x00270471
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06007F94 RID: 32660 RVA: 0x00272284 File Offset: 0x00270484
	public static bool operator ==(ECalabashTxt left, ECalabashTxt right)
	{
		return left.Equals(right);
	}

	// Token: 0x06007F95 RID: 32661 RVA: 0x0027228E File Offset: 0x0027048E
	public static bool operator !=(ECalabashTxt left, ECalabashTxt right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04004E69 RID: 20073
	private readonly string _Value;

	// Token: 0x04004E6A RID: 20074
	public static readonly ECalabashTxt UpAbsorptionTargetAdvanced = new ECalabashTxt("UpAbsorptionTarget_Advanced");

	// Token: 0x04004E6B RID: 20075
	public static readonly ECalabashTxt UpAbsorptionTargetJunior = new ECalabashTxt("UpAbsorptionTarget_Junior");

	// Token: 0x04004E6C RID: 20076
	public static readonly ECalabashTxt UpAbsorptionTargetNameJunior = new ECalabashTxt("UpAbsorptionTargetName_Junior");
}
