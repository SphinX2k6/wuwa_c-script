using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005BFF RID: 23551
	public interface IBossPilingScoreTabInfo
	{
		// Token: 0x17008D85 RID: 36229
		// (get) Token: 0x0603B868 RID: 243816
		// (set) Token: 0x0603B869 RID: 243817
		int BossHp { get; set; }

		// Token: 0x17008D86 RID: 36230
		// (get) Token: 0x0603B86A RID: 243818
		// (set) Token: 0x0603B86B RID: 243819
		int Quality { get; set; }

		// Token: 0x17008D87 RID: 36231
		// (get) Token: 0x0603B86C RID: 243820
		// (set) Token: 0x0603B86D RID: 243821
		bool IsAchieve { get; set; }
	}
}
