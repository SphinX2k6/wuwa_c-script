using System;
using System.Runtime.CompilerServices;

// Token: 0x020024FD RID: 9469
[NullableContext(1)]
[Nullable(0)]
public readonly struct ETextKey : IEquatable<ETextKey>
{
	// Token: 0x0601308E RID: 77966 RVA: 0x004B6A7E File Offset: 0x004B4C7E
	private ETextKey(string value)
	{
		this._Value = value;
	}

	// Token: 0x0601308F RID: 77967 RVA: 0x004B6A87 File Offset: 0x004B4C87
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06013090 RID: 77968 RVA: 0x004B6A8F File Offset: 0x004B4C8F
	public bool Equals(ETextKey other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06013091 RID: 77969 RVA: 0x004B6AA4 File Offset: 0x004B4CA4
	public override bool Equals(object obj)
	{
		if (obj is ETextKey)
		{
			ETextKey other = (ETextKey)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06013092 RID: 77970 RVA: 0x004B6AC9 File Offset: 0x004B4CC9
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06013093 RID: 77971 RVA: 0x004B6ADC File Offset: 0x004B4CDC
	public static bool operator ==(ETextKey left, ETextKey right)
	{
		return left.Equals(right);
	}

	// Token: 0x06013094 RID: 77972 RVA: 0x004B6AE6 File Offset: 0x004B4CE6
	public static bool operator !=(ETextKey left, ETextKey right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04008F5A RID: 36698
	private readonly string _Value;

	// Token: 0x04008F5B RID: 36699
	public static readonly ETextKey VisionIdentifyLock = new ETextKey("VisionIdentifyLock");

	// Token: 0x04008F5C RID: 36700
	public static readonly ETextKey VisionRefineNotOpen = new ETextKey("Text_PhantomRefineNotOpen_Text");

	// Token: 0x04008F5D RID: 36701
	public static readonly ETextKey VisionRefineConditionUnfit = new ETextKey("Text_PhantomRefineConditionUnfit_Text");
}
