using System;
using System.Runtime.CompilerServices;

// Token: 0x020019E4 RID: 6628
[NullableContext(1)]
[Nullable(0)]
public readonly struct ETextKey : IEquatable<ETextKey>
{
	// Token: 0x0601054D RID: 66893 RVA: 0x004C470E File Offset: 0x004C290E
	private ETextKey(string value)
	{
		this._Value = value;
	}

	// Token: 0x0601054E RID: 66894 RVA: 0x004C4717 File Offset: 0x004C2917
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x0601054F RID: 66895 RVA: 0x004C471F File Offset: 0x004C291F
	public bool Equals(ETextKey other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06010550 RID: 66896 RVA: 0x004C4734 File Offset: 0x004C2934
	public override bool Equals(object obj)
	{
		if (obj is ETextKey)
		{
			ETextKey other = (ETextKey)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06010551 RID: 66897 RVA: 0x004C4759 File Offset: 0x004C2959
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06010552 RID: 66898 RVA: 0x004C476C File Offset: 0x004C296C
	public static bool operator ==(ETextKey left, ETextKey right)
	{
		return left.Equals(right);
	}

	// Token: 0x06010553 RID: 66899 RVA: 0x004C4776 File Offset: 0x004C2976
	public static bool operator !=(ETextKey left, ETextKey right)
	{
		return !left.Equals(right);
	}

	// Token: 0x040090A4 RID: 37028
	private readonly string _Value;

	// Token: 0x040090A5 RID: 37029
	public static readonly ETextKey VisionIdentifyLock = new ETextKey("VisionIdentifyLock");

	// Token: 0x040090A6 RID: 37030
	public static readonly ETextKey VisionRefineNotOpen = new ETextKey("Text_PhantomRefineNotOpen_Text");

	// Token: 0x040090A7 RID: 37031
	public static readonly ETextKey VisionRefineConditionUnfit = new ETextKey("Text_PhantomRefineConditionUnfit_Text");
}
