using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200218F RID: 8591
public class LordGymChallengeRecord
{
	// Token: 0x06010B2A RID: 68394 RVA: 0x0040E3BC File Offset: 0x0040C5BC
	[NullableContext(2)]
	public IDifficultyVerifyLordChallengeRecord GetLordChallengeRecord(int lordId, int difficulty)
	{
		if (!this.RecordMap.ContainsKey(lordId))
		{
			return null;
		}
		return this.RecordMap[lordId][difficulty];
	}

	// Token: 0x04007F26 RID: 32550
	[Nullable(1)]
	private readonly Dictionary<int, List<IDifficultyVerifyLordChallengeRecord>> RecordMap = new Dictionary<int, List<IDifficultyVerifyLordChallengeRecord>>();
}
