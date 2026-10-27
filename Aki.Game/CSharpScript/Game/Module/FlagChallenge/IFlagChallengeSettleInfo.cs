using System;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A38 RID: 23096
	public interface IFlagChallengeSettleInfo
	{
		// Token: 0x17008BEA RID: 35818
		// (get) Token: 0x0603A96C RID: 239980
		// (set) Token: 0x0603A96D RID: 239981
		int Level { get; set; }

		// Token: 0x17008BEB RID: 35819
		// (get) Token: 0x0603A96E RID: 239982
		// (set) Token: 0x0603A96F RID: 239983
		int CacheLevel { get; set; }

		// Token: 0x17008BEC RID: 35820
		// (get) Token: 0x0603A970 RID: 239984
		// (set) Token: 0x0603A971 RID: 239985
		int BoxLevel { get; set; }
	}
}
