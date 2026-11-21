using System;
using System.Runtime.CompilerServices;

// Token: 0x0200023F RID: 575
[NullableContext(1)]
[Nullable(0)]
public readonly struct ENpcBlackBoardKeys : IEquatable<ENpcBlackBoardKeys>
{
	// Token: 0x060023BE RID: 9150 RVA: 0x000DFAE6 File Offset: 0x000DDCE6
	private ENpcBlackBoardKeys(string value)
	{
		this.Value = value;
	}

	// Token: 0x060023BF RID: 9151 RVA: 0x000DFAEF File Offset: 0x000DDCEF
	public override string ToString()
	{
		return this.Value;
	}

	// Token: 0x060023C0 RID: 9152 RVA: 0x000DFAF7 File Offset: 0x000DDCF7
	public bool Equals(ENpcBlackBoardKeys other)
	{
		return this.Value == other.Value;
	}

	// Token: 0x060023C1 RID: 9153 RVA: 0x000DFB0C File Offset: 0x000DDD0C
	[NullableContext(2)]
	public override bool Equals(object obj)
	{
		if (obj is ENpcBlackBoardKeys)
		{
			ENpcBlackBoardKeys other = (ENpcBlackBoardKeys)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x000DFB31 File Offset: 0x000DDD31
	public override int GetHashCode()
	{
		string value = this.Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x000DFB44 File Offset: 0x000DDD44
	public static bool operator ==(ENpcBlackBoardKeys left, ENpcBlackBoardKeys right)
	{
		return left.Equals(right);
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x000DFB4E File Offset: 0x000DDD4E
	public static bool operator !=(ENpcBlackBoardKeys left, ENpcBlackBoardKeys right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04001806 RID: 6150
	public readonly string Value;

	// Token: 0x04001807 RID: 6151
	public const string ActiveAction_Value = "ActiveAction";

	// Token: 0x04001808 RID: 6152
	public static readonly ENpcBlackBoardKeys ActiveAction = new ENpcBlackBoardKeys("ActiveAction");

	// Token: 0x04001809 RID: 6153
	public const string TargetMontageName_Value = "TargetMontageName";

	// Token: 0x0400180A RID: 6154
	public static readonly ENpcBlackBoardKeys TargetMontageName = new ENpcBlackBoardKeys("TargetMontageName");

	// Token: 0x0400180B RID: 6155
	public const string MonsterCount_Value = "MonsterCount";

	// Token: 0x0400180C RID: 6156
	public static readonly ENpcBlackBoardKeys MonsterCount = new ENpcBlackBoardKeys("MonsterCount");

	// Token: 0x0400180D RID: 6157
	public const string NearerPlayerId_Value = "NearerPlayerId";

	// Token: 0x0400180E RID: 6158
	public static readonly ENpcBlackBoardKeys NearerPlayerId = new ENpcBlackBoardKeys("NearerPlayerId");

	// Token: 0x0400180F RID: 6159
	public const string NeutralCount_Value = "NeutralCount";

	// Token: 0x04001810 RID: 6160
	public static readonly ENpcBlackBoardKeys NeutralCount = new ENpcBlackBoardKeys("NeutralCount");
}
