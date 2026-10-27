using System;
using System.Runtime.CompilerServices;

// Token: 0x02002B87 RID: 11143
[NullableContext(1)]
[Nullable(0)]
public readonly struct ESurvivorsSequenceName : IEquatable<ESurvivorsSequenceName>
{
	// Token: 0x06017181 RID: 94593 RVA: 0x005DC857 File Offset: 0x005DAA57
	private ESurvivorsSequenceName(string value)
	{
		this._Value = value;
	}

	// Token: 0x06017182 RID: 94594 RVA: 0x005DC860 File Offset: 0x005DAA60
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06017183 RID: 94595 RVA: 0x005DC868 File Offset: 0x005DAA68
	public bool Equals(ESurvivorsSequenceName other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06017184 RID: 94596 RVA: 0x005DC87C File Offset: 0x005DAA7C
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

	// Token: 0x06017185 RID: 94597 RVA: 0x005DC8A1 File Offset: 0x005DAAA1
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06017186 RID: 94598 RVA: 0x005DC8B4 File Offset: 0x005DAAB4
	public static bool operator ==(ESurvivorsSequenceName left, ESurvivorsSequenceName right)
	{
		return left.Equals(right);
	}

	// Token: 0x06017187 RID: 94599 RVA: 0x005DC8BE File Offset: 0x005DAABE
	public static bool operator !=(ESurvivorsSequenceName left, ESurvivorsSequenceName right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0400ACCC RID: 44236
	private readonly string _Value;

	// Token: 0x0400ACCD RID: 44237
	public static readonly ESurvivorsSequenceName PreSelect = new ESurvivorsSequenceName("PreArm");

	// Token: 0x0400ACCE RID: 44238
	public static readonly ESurvivorsSequenceName LevelUp = new ESurvivorsSequenceName("LevelUp");

	// Token: 0x0400ACCF RID: 44239
	public static readonly ESurvivorsSequenceName Unlock = new ESurvivorsSequenceName("Unlock");

	// Token: 0x0400ACD0 RID: 44240
	public static readonly ESurvivorsSequenceName Connect = new ESurvivorsSequenceName("Connect");

	// Token: 0x0400ACD1 RID: 44241
	public static readonly ESurvivorsSequenceName Disconnect = new ESurvivorsSequenceName("Disconnect");
}
