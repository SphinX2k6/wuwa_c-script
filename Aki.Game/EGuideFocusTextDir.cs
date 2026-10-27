using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DB7 RID: 7607
[NullableContext(1)]
[Nullable(0)]
public readonly struct EGuideFocusTextDir : IEquatable<EGuideFocusTextDir>
{
	// Token: 0x0600E6D7 RID: 59095 RVA: 0x0036622C File Offset: 0x0036442C
	private EGuideFocusTextDir(string value)
	{
		this._value = value;
	}

	// Token: 0x0600E6D8 RID: 59096 RVA: 0x00366235 File Offset: 0x00364435
	public override string ToString()
	{
		return this._value;
	}

	// Token: 0x0600E6D9 RID: 59097 RVA: 0x0036623D File Offset: 0x0036443D
	public bool Equals(EGuideFocusTextDir other)
	{
		return this._value == other._value;
	}

	// Token: 0x0600E6DA RID: 59098 RVA: 0x00366250 File Offset: 0x00364450
	public static implicit operator string(EGuideFocusTextDir name)
	{
		return name._value;
	}

	// Token: 0x0600E6DB RID: 59099 RVA: 0x00366258 File Offset: 0x00364458
	public static explicit operator EGuideFocusTextDir(string value)
	{
		return new EGuideFocusTextDir(value);
	}

	// Token: 0x04006AD7 RID: 27351
	private readonly string _value;

	// Token: 0x04006AD8 RID: 27352
	public static readonly EGuideFocusTextDir Left = new EGuideFocusTextDir("L");

	// Token: 0x04006AD9 RID: 27353
	public static readonly EGuideFocusTextDir Right = new EGuideFocusTextDir("R");

	// Token: 0x04006ADA RID: 27354
	public static readonly EGuideFocusTextDir Up = new EGuideFocusTextDir("U");

	// Token: 0x04006ADB RID: 27355
	public static readonly EGuideFocusTextDir Down = new EGuideFocusTextDir("D");

	// Token: 0x04006ADC RID: 27356
	public static readonly EGuideFocusTextDir CenterTop = new EGuideFocusTextDir("CT");

	// Token: 0x04006ADD RID: 27357
	public static readonly EGuideFocusTextDir Float = new EGuideFocusTextDir("FL");
}
