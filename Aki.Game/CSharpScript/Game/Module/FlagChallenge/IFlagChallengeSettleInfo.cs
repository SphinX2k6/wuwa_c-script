using System;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A14 RID: 18964
	public interface IFlagChallengeSettleInfo
	{
		// Token: 0x17005FB8 RID: 24504
		// (get) Token: 0x0602F8B5 RID: 194741
		// (set) Token: 0x0602F8B6 RID: 194742
		int Level { get; set; }

		// Token: 0x17005FB9 RID: 24505
		// (get) Token: 0x0602F8B7 RID: 194743
		// (set) Token: 0x0602F8B8 RID: 194744
		int CacheLevel { get; set; }

		// Token: 0x17005FBA RID: 24506
		// (get) Token: 0x0602F8B9 RID: 194745
		// (set) Token: 0x0602F8BA RID: 194746
		int BoxLevel { get; set; }
	}
}
