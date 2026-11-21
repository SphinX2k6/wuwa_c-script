using System;
using System.Runtime.CompilerServices;

// Token: 0x020027A4 RID: 10148
[NullableContext(1)]
[Nullable(0)]
public readonly struct EMoveState : IEquatable<EMoveState>
{
	// Token: 0x060196FD RID: 104189 RVA: 0x007C99E2 File Offset: 0x007C7BE2
	private EMoveState(string value)
	{
		this.Value = value;
	}

	// Token: 0x060196FF RID: 104191 RVA: 0x007C9A53 File Offset: 0x007C7C53
	public override string ToString()
	{
		return this.Value;
	}

	// Token: 0x06019700 RID: 104192 RVA: 0x007C9A5B File Offset: 0x007C7C5B
	public bool Equals(EMoveState other)
	{
		return this.Value == other.Value;
	}

	// Token: 0x06019701 RID: 104193 RVA: 0x007C9A70 File Offset: 0x007C7C70
	public override bool Equals(object obj)
	{
		if (obj is EMoveState)
		{
			EMoveState other = (EMoveState)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06019702 RID: 104194 RVA: 0x007C9A95 File Offset: 0x007C7C95
	public override int GetHashCode()
	{
		string value = this.Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06019703 RID: 104195 RVA: 0x007C9AA8 File Offset: 0x007C7CA8
	public static bool operator ==(EMoveState left, EMoveState right)
	{
		return left.Equals(right);
	}

	// Token: 0x06019704 RID: 104196 RVA: 0x007C9AB2 File Offset: 0x007C7CB2
	public static bool operator !=(EMoveState left, EMoveState right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0400DEF5 RID: 57077
	public readonly string Value;

	// Token: 0x0400DEF6 RID: 57078
	public static readonly EMoveState None = new EMoveState("none");

	// Token: 0x0400DEF7 RID: 57079
	public static readonly EMoveState Fly = new EMoveState("fly");

	// Token: 0x0400DEF8 RID: 57080
	public static readonly EMoveState Fall = new EMoveState("fall");

	// Token: 0x0400DEF9 RID: 57081
	public static readonly EMoveState Slide = new EMoveState("slide");

	// Token: 0x0400DEFA RID: 57082
	public static readonly EMoveState Ski = new EMoveState("ski");

	// Token: 0x0400DEFB RID: 57083
	public static readonly EMoveState Hook = new EMoveState("hook");

	// Token: 0x0400DEFC RID: 57084
	public const string None_Value = "none";

	// Token: 0x0400DEFD RID: 57085
	public const string Fly_Value = "fly";

	// Token: 0x0400DEFE RID: 57086
	public const string Fall_Value = "fall";

	// Token: 0x0400DEFF RID: 57087
	public const string Slide_Value = "slide";

	// Token: 0x0400DF00 RID: 57088
	public const string Ski_Value = "ski";

	// Token: 0x0400DF01 RID: 57089
	public const string Hook_Value = "hook";
}
