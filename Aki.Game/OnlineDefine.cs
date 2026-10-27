using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022E7 RID: 8935
[NullableContext(1)]
[Nullable(0)]
public static class OnlineDefine
{
	// Token: 0x0601195E RID: 72030 RVA: 0x0044F740 File Offset: 0x0044D940
	// Note: this type is marked as 'beforefieldinit'.
	static OnlineDefine()
	{
		Dictionary<EContinuingChallenge, string> dictionary = new Dictionary<EContinuingChallenge, string>();
		dictionary[EContinuingChallenge.Accept] = "ContinuingChallengeAccept";
		dictionary[EContinuingChallenge.Leave] = "ContinuingChallengeRefuse";
		dictionary[EContinuingChallenge.Pending] = "ContinuingChallengePending";
		OnlineDefine.onlineContinuingChallengeIcon = dictionary;
		Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
		dictionary2[0] = "OnlineDisabledByNonOnlineQuest";
		dictionary2[1] = "OnlineDisabledByNonOnlinePlay";
		dictionary2[2] = "OnlineDisabledByTrialRole";
		dictionary2[3] = "OnlineDisabledByGravity";
		dictionary2[4] = "OnlineDisabledByTrialRole";
		OnlineDefine.onlineDisabledSourceTipsId = dictionary2;
	}

	// Token: 0x0400858F RID: 34191
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EContinuingChallenge, string> onlineContinuingChallengeIcon;

	// Token: 0x04008590 RID: 34192
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<int, string> onlineDisabledSourceTipsId;
}
