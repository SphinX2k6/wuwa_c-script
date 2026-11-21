using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E5 RID: 229
[NullableContext(1)]
[Nullable(0)]
public readonly struct EAddHatredReason : IEquatable<EAddHatredReason>
{
	// Token: 0x06000D47 RID: 3399 RVA: 0x00048DB5 File Offset: 0x00046FB5
	private EAddHatredReason(string value)
	{
		this._Value = value;
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x00048DBE File Offset: 0x00046FBE
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x00048DC6 File Offset: 0x00046FC6
	public bool Equals(EAddHatredReason other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06000D4A RID: 3402 RVA: 0x00048DDC File Offset: 0x00046FDC
	[NullableContext(2)]
	public override bool Equals(object obj)
	{
		if (obj is EAddHatredReason)
		{
			EAddHatredReason other = (EAddHatredReason)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x00048E01 File Offset: 0x00047001
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x00048E14 File Offset: 0x00047014
	public static bool operator ==(EAddHatredReason left, EAddHatredReason right)
	{
		return left.Equals(right);
	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x00048E1E File Offset: 0x0004701E
	public static bool operator !=(EAddHatredReason left, EAddHatredReason right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04000A98 RID: 2712
	private readonly string _Value;

	// Token: 0x04000A99 RID: 2713
	public const string None_Value = "None";

	// Token: 0x04000A9A RID: 2714
	public static readonly EAddHatredReason None = new EAddHatredReason("None");

	// Token: 0x04000A9B RID: 2715
	public const string Damage_Value = "Damage";

	// Token: 0x04000A9C RID: 2716
	public static readonly EAddHatredReason Damage = new EAddHatredReason("Damage");

	// Token: 0x04000A9D RID: 2717
	public const string Taunt_Value = "Taunt";

	// Token: 0x04000A9E RID: 2718
	public static readonly EAddHatredReason Taunt = new EAddHatredReason("Taunt");

	// Token: 0x04000A9F RID: 2719
	public const string Area_Value = "Area";

	// Token: 0x04000AA0 RID: 2720
	public static readonly EAddHatredReason Area = new EAddHatredReason("Area");

	// Token: 0x04000AA1 RID: 2721
	public const string ChangeRole_Value = "ChangeRole";

	// Token: 0x04000AA2 RID: 2722
	public static readonly EAddHatredReason ChangeRole = new EAddHatredReason("ChangeRole");

	// Token: 0x04000AA3 RID: 2723
	public const string VisionMorphBegin_Value = "VisionMorphBegin";

	// Token: 0x04000AA4 RID: 2724
	public static readonly EAddHatredReason VisionMorphBegin = new EAddHatredReason("VisionMorphBegin");

	// Token: 0x04000AA5 RID: 2725
	public const string VisionMorphEnd_Value = "VisionMorphEnd";

	// Token: 0x04000AA6 RID: 2726
	public static readonly EAddHatredReason VisionMorphEnd = new EAddHatredReason("VisionMorphEnd");

	// Token: 0x04000AA7 RID: 2727
	public const string Blueprint_Value = "Blueprint";

	// Token: 0x04000AA8 RID: 2728
	public static readonly EAddHatredReason Blueprint = new EAddHatredReason("Blueprint");

	// Token: 0x04000AA9 RID: 2729
	public const string Shared_Value = "Shared";

	// Token: 0x04000AAA RID: 2730
	public static readonly EAddHatredReason Shared = new EAddHatredReason("Shared");
}
