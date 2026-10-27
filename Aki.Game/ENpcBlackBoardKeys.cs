using System;
using System.Runtime.CompilerServices;

// Token: 0x0200023B RID: 571
[NullableContext(1)]
[Nullable(0)]
public readonly struct ENpcBlackBoardKeys : IEquatable<ENpcBlackBoardKeys>
{
	// Token: 0x06002306 RID: 8966 RVA: 0x000D9626 File Offset: 0x000D7826
	private ENpcBlackBoardKeys(string value)
	{
		this.Value = value;
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x000D962F File Offset: 0x000D782F
	public override string ToString()
	{
		return this.Value;
	}

	// Token: 0x06002308 RID: 8968 RVA: 0x000D9637 File Offset: 0x000D7837
	public bool Equals(ENpcBlackBoardKeys other)
	{
		return this.Value == other.Value;
	}

	// Token: 0x06002309 RID: 8969 RVA: 0x000D964C File Offset: 0x000D784C
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

	// Token: 0x0600230A RID: 8970 RVA: 0x000D9671 File Offset: 0x000D7871
	public override int GetHashCode()
	{
		string value = this.Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x0600230B RID: 8971 RVA: 0x000D9684 File Offset: 0x000D7884
	public static bool operator ==(ENpcBlackBoardKeys left, ENpcBlackBoardKeys right)
	{
		return left.Equals(right);
	}

	// Token: 0x0600230C RID: 8972 RVA: 0x000D968E File Offset: 0x000D788E
	public static bool operator !=(ENpcBlackBoardKeys left, ENpcBlackBoardKeys right)
	{
		return !left.Equals(right);
	}

	// Token: 0x040017C2 RID: 6082
	public readonly string Value;

	// Token: 0x040017C3 RID: 6083
	public const string ActiveAction_Value = "ActiveAction";

	// Token: 0x040017C4 RID: 6084
	public static readonly ENpcBlackBoardKeys ActiveAction = new ENpcBlackBoardKeys("ActiveAction");

	// Token: 0x040017C5 RID: 6085
	public const string TargetMontageName_Value = "TargetMontageName";

	// Token: 0x040017C6 RID: 6086
	public static readonly ENpcBlackBoardKeys TargetMontageName = new ENpcBlackBoardKeys("TargetMontageName");

	// Token: 0x040017C7 RID: 6087
	public const string MonsterCount_Value = "MonsterCount";

	// Token: 0x040017C8 RID: 6088
	public static readonly ENpcBlackBoardKeys MonsterCount = new ENpcBlackBoardKeys("MonsterCount");

	// Token: 0x040017C9 RID: 6089
	public const string NearerPlayerId_Value = "NearerPlayerId";

	// Token: 0x040017CA RID: 6090
	public static readonly ENpcBlackBoardKeys NearerPlayerId = new ENpcBlackBoardKeys("NearerPlayerId");

	// Token: 0x040017CB RID: 6091
	public const string NeutralCount_Value = "NeutralCount";

	// Token: 0x040017CC RID: 6092
	public static readonly ENpcBlackBoardKeys NeutralCount = new ENpcBlackBoardKeys("NeutralCount");
}
