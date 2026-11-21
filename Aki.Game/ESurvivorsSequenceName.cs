using System;
using System.Runtime.CompilerServices;

// Token: 0x02002103 RID: 8451
[NullableContext(1)]
[Nullable(0)]
public readonly struct ESurvivorsSequenceName : IEquatable<ESurvivorsSequenceName>
{
	// Token: 0x06014BB2 RID: 84914 RVA: 0x00609437 File Offset: 0x00607637
	private ESurvivorsSequenceName(string value)
	{
		this._Value = value;
	}

	// Token: 0x06014BB3 RID: 84915 RVA: 0x00609440 File Offset: 0x00607640
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06014BB4 RID: 84916 RVA: 0x00609448 File Offset: 0x00607648
	public bool Equals(ESurvivorsSequenceName other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06014BB5 RID: 84917 RVA: 0x0060945C File Offset: 0x0060765C
	[NullableContext(2)]
	public override bool Equals(object obj)
	{
		if (obj is ESurvivorsSequenceName)
		{
			ESurvivorsSequenceName other = (ESurvivorsSequenceName)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06014BB6 RID: 84918 RVA: 0x00609481 File Offset: 0x00607681
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06014BB7 RID: 84919 RVA: 0x00609494 File Offset: 0x00607694
	public static bool operator ==(ESurvivorsSequenceName left, ESurvivorsSequenceName right)
	{
		return left.Equals(right);
	}

	// Token: 0x06014BB8 RID: 84920 RVA: 0x0060949E File Offset: 0x0060769E
	public static bool operator !=(ESurvivorsSequenceName left, ESurvivorsSequenceName right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0400B0D3 RID: 45267
	private readonly string _Value;

	// Token: 0x0400B0D4 RID: 45268
	public static readonly ESurvivorsSequenceName PreSelect = new ESurvivorsSequenceName("PreArm");

	// Token: 0x0400B0D5 RID: 45269
	public static readonly ESurvivorsSequenceName LevelUp = new ESurvivorsSequenceName("LevelUp");

	// Token: 0x0400B0D6 RID: 45270
	public static readonly ESurvivorsSequenceName Unlock = new ESurvivorsSequenceName("Unlock");

	// Token: 0x0400B0D7 RID: 45271
	public static readonly ESurvivorsSequenceName Connect = new ESurvivorsSequenceName("Connect");

	// Token: 0x0400B0D8 RID: 45272
	public static readonly ESurvivorsSequenceName Disconnect = new ESurvivorsSequenceName("Disconnect");
}
