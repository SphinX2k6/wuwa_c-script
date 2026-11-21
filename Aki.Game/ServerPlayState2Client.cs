using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F62 RID: 3938
public static class ServerPlayState2Client
{
	// Token: 0x06009E02 RID: 40450 RVA: 0x002EC860 File Offset: 0x002EAA60
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

	// Token: 0x04005DCE RID: 24014
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<int, EPlayPointState> Map;
}
