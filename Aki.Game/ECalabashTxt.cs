using System;
using System.Runtime.CompilerServices;

// Token: 0x02001733 RID: 5939
[NullableContext(1)]
[Nullable(0)]
public readonly struct ECalabashTxt : IEquatable<ECalabashTxt>
{
	// Token: 0x0600ABA8 RID: 43944 RVA: 0x00267E25 File Offset: 0x00266025
	private ECalabashTxt(string value)
	{
		this._Value = value;
	}

	// Token: 0x0600ABA9 RID: 43945 RVA: 0x00267E2E File Offset: 0x0026602E
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x0600ABAA RID: 43946 RVA: 0x00267E36 File Offset: 0x00266036
	public bool Equals(ECalabashTxt other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x0600ABAB RID: 43947 RVA: 0x00267E4C File Offset: 0x0026604C
	public override bool Equals(object obj)
	{
		if (obj is ECalabashTxt)
		{
			ECalabashTxt other = (ECalabashTxt)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0600ABAC RID: 43948 RVA: 0x00267E71 File Offset: 0x00266071
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x0600ABAD RID: 43949 RVA: 0x00267E84 File Offset: 0x00266084
	public static bool operator ==(ECalabashTxt left, ECalabashTxt right)
	{
		return left.Equals(right);
	}

	// Token: 0x0600ABAE RID: 43950 RVA: 0x00267E8E File Offset: 0x0026608E
	public static bool operator !=(ECalabashTxt left, ECalabashTxt right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04004DC0 RID: 19904
	private readonly string _Value;

	// Token: 0x04004DC1 RID: 19905
	public static readonly ECalabashTxt UpAbsorptionTargetAdvanced = new ECalabashTxt("UpAbsorptionTarget_Advanced");

	// Token: 0x04004DC2 RID: 19906
	public static readonly ECalabashTxt UpAbsorptionTargetJunior = new ECalabashTxt("UpAbsorptionTarget_Junior");

	// Token: 0x04004DC3 RID: 19907
	public static readonly ECalabashTxt UpAbsorptionTargetNameJunior = new ECalabashTxt("UpAbsorptionTargetName_Junior");
}
