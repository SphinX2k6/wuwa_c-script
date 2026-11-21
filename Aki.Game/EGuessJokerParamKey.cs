using System;
using System.Runtime.CompilerServices;

// Token: 0x0200050C RID: 1292
[NullableContext(1)]
[Nullable(0)]
public readonly struct EGuessJokerParamKey : IEquatable<EGuessJokerParamKey>
{
	// Token: 0x06003EBF RID: 16063 RVA: 0x001618F6 File Offset: 0x0015FAF6
	private EGuessJokerParamKey(string value)
	{
		this._Value = value;
	}

	// Token: 0x06003EC0 RID: 16064 RVA: 0x001618FF File Offset: 0x0015FAFF
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06003EC1 RID: 16065 RVA: 0x00161907 File Offset: 0x0015FB07
	public bool Equals(EGuessJokerParamKey other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06003EC2 RID: 16066 RVA: 0x0016191C File Offset: 0x0015FB1C
	[NullableContext(2)]
	public override bool Equals(object obj)
	{
		if (obj is EGuessJokerParamKey)
		{
			EGuessJokerParamKey other = (EGuessJokerParamKey)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06003EC3 RID: 16067 RVA: 0x00161941 File Offset: 0x0015FB41
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06003EC4 RID: 16068 RVA: 0x00161954 File Offset: 0x0015FB54
	public static bool operator ==(EGuessJokerParamKey left, EGuessJokerParamKey right)
	{
		return left.Equals(right);
	}

	// Token: 0x06003EC5 RID: 16069 RVA: 0x0016195E File Offset: 0x0015FB5E
	public static bool operator !=(EGuessJokerParamKey left, EGuessJokerParamKey right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04003242 RID: 12866
	private readonly string _Value;

	// Token: 0x04003243 RID: 12867
	public static readonly EGuessJokerParamKey GuessJokerCardMoveTime = new EGuessJokerParamKey("GuessJokerMoveCardTime");

	// Token: 0x04003244 RID: 12868
	public static readonly EGuessJokerParamKey GuessJokerCardUpTime = new EGuessJokerParamKey("GuessJokerUpCardTime");

	// Token: 0x04003245 RID: 12869
	public static readonly EGuessJokerParamKey GuessJokerCardRemoveTime = new EGuessJokerParamKey("GuessJokerRemoveCardTime");

	// Token: 0x04003246 RID: 12870
	public static readonly EGuessJokerParamKey GuessJokerAiSkillConsiderTime = new EGuessJokerParamKey("GuessJokerAiSkillConsiderTime");

	// Token: 0x04003247 RID: 12871
	public static readonly EGuessJokerParamKey GuessJokerPlayerSkillConsiderTime = new EGuessJokerParamKey("GuessJokerPlayerSkillConsiderTime");

	// Token: 0x04003248 RID: 12872
	public static readonly EGuessJokerParamKey GuessJokerNpcDrawCardWaitTime = new EGuessJokerParamKey("GuessJokerNpcDrawCardTime");

	// Token: 0x04003249 RID: 12873
	public static readonly EGuessJokerParamKey GuessJokerCheckCardTime = new EGuessJokerParamKey("GuessJokerCheckCardTime");

	// Token: 0x0400324A RID: 12874
	public static readonly EGuessJokerParamKey GuessJokerCheckItemMoveTime = new EGuessJokerParamKey("GuessJokerCheckItemMoveTime");

	// Token: 0x0400324B RID: 12875
	public static readonly EGuessJokerParamKey GuessJokerCheckItemStayTime = new EGuessJokerParamKey("GuessJokerCheckItemStayTime");

	// Token: 0x0400324C RID: 12876
	public static readonly EGuessJokerParamKey GuessJokerMaxPerformTime = new EGuessJokerParamKey("GuessJokerMaxPerformTime");

	// Token: 0x0400324D RID: 12877
	public static readonly EGuessJokerParamKey GuessJokerFloatTipTime = new EGuessJokerParamKey("GuessJokerFloatTipTime");

	// Token: 0x0400324E RID: 12878
	public static readonly EGuessJokerParamKey GuessJokerLuhesiDrawCardWaitTime = new EGuessJokerParamKey("GuessJokerLuhesiDrawCardWaitTime");

	// Token: 0x0400324F RID: 12879
	public static readonly EGuessJokerParamKey GuessJokerBeChooseAiCardCount = new EGuessJokerParamKey("GuessJokerBeChooseAiCardCount");

	// Token: 0x04003250 RID: 12880
	public static readonly EGuessJokerParamKey GuessJokerBeDrawAiCardCount = new EGuessJokerParamKey("GuessJokerBeDrawAiCardCount");

	// Token: 0x04003251 RID: 12881
	public static readonly EGuessJokerParamKey GuessJokerBeDrawPlayerCardCount = new EGuessJokerParamKey("GuessJokerBeDrawPlayerCardCount");

	// Token: 0x04003252 RID: 12882
	public static readonly EGuessJokerParamKey GuessJokerDrawAiCardCount = new EGuessJokerParamKey("GuessJokerDrawAiCardCount");
}
