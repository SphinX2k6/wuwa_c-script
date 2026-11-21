using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E6 RID: 230
[NullableContext(1)]
[Nullable(0)]
public readonly struct ERemoveHatredReason : IEquatable<ERemoveHatredReason>
{
	// Token: 0x06000D4F RID: 3407 RVA: 0x00048EC0 File Offset: 0x000470C0
	private ERemoveHatredReason(string value)
	{
		this._Value = value;
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x00048EC9 File Offset: 0x000470C9
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00048ED1 File Offset: 0x000470D1
	public bool Equals(ERemoveHatredReason other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x00048EE4 File Offset: 0x000470E4
	[NullableContext(2)]
	public override bool Equals(object obj)
	{
		if (obj is ERemoveHatredReason)
		{
			ERemoveHatredReason other = (ERemoveHatredReason)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00048F09 File Offset: 0x00047109
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x00048F1C File Offset: 0x0004711C
	public static bool operator ==(ERemoveHatredReason left, ERemoveHatredReason right)
	{
		return left.Equals(right);
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x00048F26 File Offset: 0x00047126
	public static bool operator !=(ERemoveHatredReason left, ERemoveHatredReason right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04000AAB RID: 2731
	private readonly string _Value;

	// Token: 0x04000AAC RID: 2732
	public const string MinAreaTimer_Value = "MinAreaTimer";

	// Token: 0x04000AAD RID: 2733
	public static readonly ERemoveHatredReason MinAreaTimer = new ERemoveHatredReason("MinAreaTimer");

	// Token: 0x04000AAE RID: 2734
	public const string MaxArea_Value = "MaxArea";

	// Token: 0x04000AAF RID: 2735
	public static readonly ERemoveHatredReason MaxArea = new ERemoveHatredReason("MaxArea");

	// Token: 0x04000AB0 RID: 2736
	public const string InActive_Value = "InActive";

	// Token: 0x04000AB1 RID: 2737
	public static readonly ERemoveHatredReason InActive = new ERemoveHatredReason("InActive");

	// Token: 0x04000AB2 RID: 2738
	public const string Clear_Value = "Clear";

	// Token: 0x04000AB3 RID: 2739
	public static readonly ERemoveHatredReason Clear = new ERemoveHatredReason("Clear");

	// Token: 0x04000AB4 RID: 2740
	public const string ForceChanged_Value = "ForceChanged";

	// Token: 0x04000AB5 RID: 2741
	public static readonly ERemoveHatredReason ForceChanged = new ERemoveHatredReason("ForceChanged");

	// Token: 0x04000AB6 RID: 2742
	public const string ChangeCamp_Value = "ChangeCamp";

	// Token: 0x04000AB7 RID: 2743
	public static readonly ERemoveHatredReason ChangeCamp = new ERemoveHatredReason("ChangeCamp");

	// Token: 0x04000AB8 RID: 2744
	public const string Dead_Value = "Dead";

	// Token: 0x04000AB9 RID: 2745
	public static readonly ERemoveHatredReason Dead = new ERemoveHatredReason("Dead");
}
