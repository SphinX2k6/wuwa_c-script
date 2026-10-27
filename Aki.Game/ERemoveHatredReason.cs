using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E6 RID: 230
[NullableContext(1)]
[Nullable(0)]
public readonly struct ERemoveHatredReason : IEquatable<ERemoveHatredReason>
{
	// Token: 0x06000D49 RID: 3401 RVA: 0x00048324 File Offset: 0x00046524
	private ERemoveHatredReason(string value)
	{
		this._Value = value;
	}

	// Token: 0x06000D4A RID: 3402 RVA: 0x0004832D File Offset: 0x0004652D
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x00048335 File Offset: 0x00046535
	public bool Equals(ERemoveHatredReason other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x00048348 File Offset: 0x00046548
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

	// Token: 0x06000D4D RID: 3405 RVA: 0x0004836D File Offset: 0x0004656D
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x00048380 File Offset: 0x00046580
	public static bool operator ==(ERemoveHatredReason left, ERemoveHatredReason right)
	{
		return left.Equals(right);
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x0004838A File Offset: 0x0004658A
	public static bool operator !=(ERemoveHatredReason left, ERemoveHatredReason right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04000AA3 RID: 2723
	private readonly string _Value;

	// Token: 0x04000AA4 RID: 2724
	public const string MinAreaTimer_Value = "MinAreaTimer";

	// Token: 0x04000AA5 RID: 2725
	public static readonly ERemoveHatredReason MinAreaTimer = new ERemoveHatredReason("MinAreaTimer");

	// Token: 0x04000AA6 RID: 2726
	public const string MaxArea_Value = "MaxArea";

	// Token: 0x04000AA7 RID: 2727
	public static readonly ERemoveHatredReason MaxArea = new ERemoveHatredReason("MaxArea");

	// Token: 0x04000AA8 RID: 2728
	public const string InActive_Value = "InActive";

	// Token: 0x04000AA9 RID: 2729
	public static readonly ERemoveHatredReason InActive = new ERemoveHatredReason("InActive");

	// Token: 0x04000AAA RID: 2730
	public const string Clear_Value = "Clear";

	// Token: 0x04000AAB RID: 2731
	public static readonly ERemoveHatredReason Clear = new ERemoveHatredReason("Clear");

	// Token: 0x04000AAC RID: 2732
	public const string ForceChanged_Value = "ForceChanged";

	// Token: 0x04000AAD RID: 2733
	public static readonly ERemoveHatredReason ForceChanged = new ERemoveHatredReason("ForceChanged");

	// Token: 0x04000AAE RID: 2734
	public const string ChangeCamp_Value = "ChangeCamp";

	// Token: 0x04000AAF RID: 2735
	public static readonly ERemoveHatredReason ChangeCamp = new ERemoveHatredReason("ChangeCamp");

	// Token: 0x04000AB0 RID: 2736
	public const string Dead_Value = "Dead";

	// Token: 0x04000AB1 RID: 2737
	public static readonly ERemoveHatredReason Dead = new ERemoveHatredReason("Dead");
}
