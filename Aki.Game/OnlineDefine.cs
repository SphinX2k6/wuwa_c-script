using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020017CB RID: 6091
[NullableContext(1)]
[Nullable(0)]
public static class OnlineDefine
{
	// Token: 0x0600EDF6 RID: 60918 RVA: 0x0045C40C File Offset: 0x0045A60C
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

	// Token: 0x040086CD RID: 34509
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EContinuingChallenge, string> onlineContinuingChallengeIcon;

	// Token: 0x040086CE RID: 34510
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<int, string> onlineDisabledSourceTipsId;
}
