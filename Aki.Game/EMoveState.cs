using System;
using System.Runtime.CompilerServices;

// Token: 0x02003235 RID: 12853
[NullableContext(1)]
[Nullable(0)]
public readonly struct EMoveState : IEquatable<EMoveState>
{
	// Token: 0x0601BB72 RID: 113522 RVA: 0x007A10D6 File Offset: 0x0079F2D6
	private EMoveState(string value)
	{
		this.Value = value;
	}

	// Token: 0x0601BB74 RID: 113524 RVA: 0x007A1147 File Offset: 0x0079F347
	public override string ToString()
	{
		return this.Value;
	}

	// Token: 0x0601BB75 RID: 113525 RVA: 0x007A114F File Offset: 0x0079F34F
	public bool Equals(EMoveState other)
	{
		return this.Value == other.Value;
	}

	// Token: 0x0601BB76 RID: 113526 RVA: 0x007A1164 File Offset: 0x0079F364
	public override bool Equals(object obj)
	{
		if (obj is EMoveState)
		{
			EMoveState other = (EMoveState)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0601BB77 RID: 113527 RVA: 0x007A1189 File Offset: 0x0079F389
	public override int GetHashCode()
	{
		string value = this.Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x0601BB78 RID: 113528 RVA: 0x007A119C File Offset: 0x0079F39C
	public static bool operator ==(EMoveState left, EMoveState right)
	{
		return left.Equals(right);
	}

	// Token: 0x0601BB79 RID: 113529 RVA: 0x007A11A6 File Offset: 0x0079F3A6
	public static bool operator !=(EMoveState left, EMoveState right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0400DA56 RID: 55894
	public readonly string Value;

	// Token: 0x0400DA57 RID: 55895
	public static readonly EMoveState None = new EMoveState("none");

	// Token: 0x0400DA58 RID: 55896
	public static readonly EMoveState Fly = new EMoveState("fly");

	// Token: 0x0400DA59 RID: 55897
	public static readonly EMoveState Fall = new EMoveState("fall");

	// Token: 0x0400DA5A RID: 55898
	public static readonly EMoveState Slide = new EMoveState("slide");

	// Token: 0x0400DA5B RID: 55899
	public static readonly EMoveState Ski = new EMoveState("ski");

	// Token: 0x0400DA5C RID: 55900
	public static readonly EMoveState Hook = new EMoveState("hook");

	// Token: 0x0400DA5D RID: 55901
	public const string None_Value = "none";

	// Token: 0x0400DA5E RID: 55902
	public const string Fly_Value = "fly";

	// Token: 0x0400DA5F RID: 55903
	public const string Fall_Value = "fall";

	// Token: 0x0400DA60 RID: 55904
	public const string Slide_Value = "slide";

	// Token: 0x0400DA61 RID: 55905
	public const string Ski_Value = "ski";

	// Token: 0x0400DA62 RID: 55906
	public const string Hook_Value = "hook";
}
