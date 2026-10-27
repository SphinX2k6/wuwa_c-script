using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057C0 RID: 22464
	public interface ITowerDefenceRewardInfo : IRewardInfo
	{
		// Token: 0x17008982 RID: 35202
		// (get) Token: 0x06039208 RID: 233992
		// (set) Token: 0x06039209 RID: 233993
		bool IsSuccess { get; set; }

		// Token: 0x17008983 RID: 35203
		// (get) Token: 0x0603920A RID: 233994
		// (set) Token: 0x0603920B RID: 233995
		int Score { get; set; }

		// Token: 0x17008984 RID: 35204
		// (get) Token: 0x0603920C RID: 233996
		// (set) Token: 0x0603920D RID: 233997
		int RecordScore { get; set; }
	}
}
