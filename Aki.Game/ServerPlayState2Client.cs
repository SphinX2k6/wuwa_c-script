using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001AA3 RID: 6819
public static class ServerPlayState2Client
{
	// Token: 0x0600C9F1 RID: 51697 RVA: 0x002E1710 File Offset: 0x002DF910
	// Note: this type is marked as 'beforefieldinit'.
	static ServerPlayState2Client()
	{
		Dictionary<int, EPlayPointState> dictionary = new Dictionary<int, EPlayPointState>();
		dictionary[0] = EPlayPointState.Locked;
		dictionary[1] = EPlayPointState.ToBeCompleted;
		dictionary[2] = EPlayPointState.ToBeCompleted;
		dictionary[3] = EPlayPointState.Completed;
		dictionary[4] = EPlayPointState.Completed;
		ServerPlayState2Client.Map = dictionary;
	}

	// Token: 0x04005CFF RID: 23807
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<int, EPlayPointState> Map;
}
