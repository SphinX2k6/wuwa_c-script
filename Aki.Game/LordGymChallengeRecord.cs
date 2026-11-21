using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001673 RID: 5747
public class LordGymChallengeRecord
{
	// Token: 0x0600DFBB RID: 57275 RVA: 0x0041AC9C File Offset: 0x00418E9C
	[NullableContext(2)]
	public IDifficultyVerifyLordChallengeRecord GetLordChallengeRecord(int lordId, int difficulty)
	{
		if (!this.RecordMap.ContainsKey(lordId))
		{
			return null;
		}
		return this.RecordMap[lordId][difficulty];
	}

	// Token: 0x0400806D RID: 32877
	[Nullable(1)]
	private readonly Dictionary<int, List<IDifficultyVerifyLordChallengeRecord>> RecordMap = new Dictionary<int, List<IDifficultyVerifyLordChallengeRecord>>();
}
