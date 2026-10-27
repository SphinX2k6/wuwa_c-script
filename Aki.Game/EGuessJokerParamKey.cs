using System;
using System.Runtime.CompilerServices;

// Token: 0x02001058 RID: 4184
[NullableContext(1)]
[Nullable(0)]
public readonly struct EGuessJokerParamKey : IEquatable<EGuessJokerParamKey>
{
	// Token: 0x06006B2A RID: 27434 RVA: 0x00158FCE File Offset: 0x001571CE
	private EGuessJokerParamKey(string value)
	{
		this._Value = value;
	}

	// Token: 0x06006B2B RID: 27435 RVA: 0x00158FD7 File Offset: 0x001571D7
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06006B2C RID: 27436 RVA: 0x00158FDF File Offset: 0x001571DF
	public bool Equals(EGuessJokerParamKey other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06006B2D RID: 27437 RVA: 0x00158FF4 File Offset: 0x001571F4
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

	// Token: 0x06006B2E RID: 27438 RVA: 0x00159019 File Offset: 0x00157219
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06006B2F RID: 27439 RVA: 0x0015902C File Offset: 0x0015722C
	public static bool operator ==(EGuessJokerParamKey left, EGuessJokerParamKey right)
	{
		return left.Equals(right);
	}

	// Token: 0x06006B30 RID: 27440 RVA: 0x00159036 File Offset: 0x00157236
	public static bool operator !=(EGuessJokerParamKey left, EGuessJokerParamKey right)
	{
		return !left.Equals(right);
	}

	// Token: 0x040031A9 RID: 12713
	private readonly string _Value;

	// Token: 0x040031AA RID: 12714
	public static readonly EGuessJokerParamKey GuessJokerCardMoveTime = new EGuessJokerParamKey("GuessJokerMoveCardTime");

	// Token: 0x040031AB RID: 12715
	public static readonly EGuessJokerParamKey GuessJokerCardUpTime = new EGuessJokerParamKey("GuessJokerUpCardTime");

	// Token: 0x040031AC RID: 12716
	public static readonly EGuessJokerParamKey GuessJokerCardRemoveTime = new EGuessJokerParamKey("GuessJokerRemoveCardTime");

	// Token: 0x040031AD RID: 12717
	public static readonly EGuessJokerParamKey GuessJokerAiSkillConsiderTime = new EGuessJokerParamKey("GuessJokerAiSkillConsiderTime");

	// Token: 0x040031AE RID: 12718
	public static readonly EGuessJokerParamKey GuessJokerPlayerSkillConsiderTime = new EGuessJokerParamKey("GuessJokerPlayerSkillConsiderTime");

	// Token: 0x040031AF RID: 12719
	public static readonly EGuessJokerParamKey GuessJokerNpcDrawCardWaitTime = new EGuessJokerParamKey("GuessJokerNpcDrawCardTime");

	// Token: 0x040031B0 RID: 12720
	public static readonly EGuessJokerParamKey GuessJokerCheckCardTime = new EGuessJokerParamKey("GuessJokerCheckCardTime");

	// Token: 0x040031B1 RID: 12721
	public static readonly EGuessJokerParamKey GuessJokerCheckItemMoveTime = new EGuessJokerParamKey("GuessJokerCheckItemMoveTime");

	// Token: 0x040031B2 RID: 12722
	public static readonly EGuessJokerParamKey GuessJokerCheckItemStayTime = new EGuessJokerParamKey("GuessJokerCheckItemStayTime");

	// Token: 0x040031B3 RID: 12723
	public static readonly EGuessJokerParamKey GuessJokerMaxPerformTime = new EGuessJokerParamKey("GuessJokerMaxPerformTime");

	// Token: 0x040031B4 RID: 12724
	public static readonly EGuessJokerParamKey GuessJokerFloatTipTime = new EGuessJokerParamKey("GuessJokerFloatTipTime");

	// Token: 0x040031B5 RID: 12725
	public static readonly EGuessJokerParamKey GuessJokerLuhesiDrawCardWaitTime = new EGuessJokerParamKey("GuessJokerLuhesiDrawCardWaitTime");

	// Token: 0x040031B6 RID: 12726
	public static readonly EGuessJokerParamKey GuessJokerBeChooseAiCardCount = new EGuessJokerParamKey("GuessJokerBeChooseAiCardCount");

	// Token: 0x040031B7 RID: 12727
	public static readonly EGuessJokerParamKey GuessJokerBeDrawAiCardCount = new EGuessJokerParamKey("GuessJokerBeDrawAiCardCount");

	// Token: 0x040031B8 RID: 12728
	public static readonly EGuessJokerParamKey GuessJokerBeDrawPlayerCardCount = new EGuessJokerParamKey("GuessJokerBeDrawPlayerCardCount");

	// Token: 0x040031B9 RID: 12729
	public static readonly EGuessJokerParamKey GuessJokerDrawAiCardCount = new EGuessJokerParamKey("GuessJokerDrawAiCardCount");
}
