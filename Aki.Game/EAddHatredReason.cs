using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E5 RID: 229
[NullableContext(1)]
[Nullable(0)]
public readonly struct EAddHatredReason : IEquatable<EAddHatredReason>
{
	// Token: 0x06000D41 RID: 3393 RVA: 0x00048219 File Offset: 0x00046419
	private EAddHatredReason(string value)
	{
		this._Value = value;
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x00048222 File Offset: 0x00046422
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x0004822A File Offset: 0x0004642A
	public bool Equals(EAddHatredReason other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x00048240 File Offset: 0x00046440
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

	// Token: 0x06000D45 RID: 3397 RVA: 0x00048265 File Offset: 0x00046465
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x00048278 File Offset: 0x00046478
	public static bool operator ==(EAddHatredReason left, EAddHatredReason right)
	{
		return left.Equals(right);
	}

	// Token: 0x06000D47 RID: 3399 RVA: 0x00048282 File Offset: 0x00046482
	public static bool operator !=(EAddHatredReason left, EAddHatredReason right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04000A90 RID: 2704
	private readonly string _Value;

	// Token: 0x04000A91 RID: 2705
	public const string None_Value = "None";

	// Token: 0x04000A92 RID: 2706
	public static readonly EAddHatredReason None = new EAddHatredReason("None");

	// Token: 0x04000A93 RID: 2707
	public const string Damage_Value = "Damage";

	// Token: 0x04000A94 RID: 2708
	public static readonly EAddHatredReason Damage = new EAddHatredReason("Damage");

	// Token: 0x04000A95 RID: 2709
	public const string Taunt_Value = "Taunt";

	// Token: 0x04000A96 RID: 2710
	public static readonly EAddHatredReason Taunt = new EAddHatredReason("Taunt");

	// Token: 0x04000A97 RID: 2711
	public const string Area_Value = "Area";

	// Token: 0x04000A98 RID: 2712
	public static readonly EAddHatredReason Area = new EAddHatredReason("Area");

	// Token: 0x04000A99 RID: 2713
	public const string ChangeRole_Value = "ChangeRole";

	// Token: 0x04000A9A RID: 2714
	public static readonly EAddHatredReason ChangeRole = new EAddHatredReason("ChangeRole");

	// Token: 0x04000A9B RID: 2715
	public const string VisionMorphBegin_Value = "VisionMorphBegin";

	// Token: 0x04000A9C RID: 2716
	public static readonly EAddHatredReason VisionMorphBegin = new EAddHatredReason("VisionMorphBegin");

	// Token: 0x04000A9D RID: 2717
	public const string VisionMorphEnd_Value = "VisionMorphEnd";

	// Token: 0x04000A9E RID: 2718
	public static readonly EAddHatredReason VisionMorphEnd = new EAddHatredReason("VisionMorphEnd");

	// Token: 0x04000A9F RID: 2719
	public const string Blueprint_Value = "Blueprint";

	// Token: 0x04000AA0 RID: 2720
	public static readonly EAddHatredReason Blueprint = new EAddHatredReason("Blueprint");

	// Token: 0x04000AA1 RID: 2721
	public const string Shared_Value = "Shared";

	// Token: 0x04000AA2 RID: 2722
	public static readonly EAddHatredReason Shared = new EAddHatredReason("Shared");
}
