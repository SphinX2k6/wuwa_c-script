using System;
using System.Runtime.CompilerServices;

// Token: 0x02001279 RID: 4729
[NullableContext(1)]
[Nullable(0)]
public readonly struct EGuideFocusTextDir : IEquatable<EGuideFocusTextDir>
{
	// Token: 0x0600BAF5 RID: 47861 RVA: 0x00371E8C File Offset: 0x0037008C
	private EGuideFocusTextDir(string value)
	{
		this._value = value;
	}

	// Token: 0x0600BAF6 RID: 47862 RVA: 0x00371E95 File Offset: 0x00370095
	public override string ToString()
	{
		return this._value;
	}

	// Token: 0x0600BAF7 RID: 47863 RVA: 0x00371E9D File Offset: 0x0037009D
	public bool Equals(EGuideFocusTextDir other)
	{
		return this._value == other._value;
	}

	// Token: 0x0600BAF8 RID: 47864 RVA: 0x00371EB0 File Offset: 0x003700B0
	public static implicit operator string(EGuideFocusTextDir name)
	{
		return name._value;
	}

	// Token: 0x0600BAF9 RID: 47865 RVA: 0x00371EB8 File Offset: 0x003700B8
	public static explicit operator EGuideFocusTextDir(string value)
	{
		return new EGuideFocusTextDir(value);
	}

	// Token: 0x04006BB8 RID: 27576
	private readonly string _value;

	// Token: 0x04006BB9 RID: 27577
	public static readonly EGuideFocusTextDir Left = new EGuideFocusTextDir("L");

	// Token: 0x04006BBA RID: 27578
	public static readonly EGuideFocusTextDir Right = new EGuideFocusTextDir("R");

	// Token: 0x04006BBB RID: 27579
	public static readonly EGuideFocusTextDir Up = new EGuideFocusTextDir("U");

	// Token: 0x04006BBC RID: 27580
	public static readonly EGuideFocusTextDir Down = new EGuideFocusTextDir("D");

	// Token: 0x04006BBD RID: 27581
	public static readonly EGuideFocusTextDir CenterTop = new EGuideFocusTextDir("CT");

	// Token: 0x04006BBE RID: 27582
	public static readonly EGuideFocusTextDir Float = new EGuideFocusTextDir("FL");
}
