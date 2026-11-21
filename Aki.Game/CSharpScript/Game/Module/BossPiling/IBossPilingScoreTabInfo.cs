using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BDF RID: 19423
	public interface IBossPilingScoreTabInfo
	{
		// Token: 0x17006157 RID: 24919
		// (get) Token: 0x060307B3 RID: 198579
		// (set) Token: 0x060307B4 RID: 198580
		int BossHp { get; set; }

		// Token: 0x17006158 RID: 24920
		// (get) Token: 0x060307B5 RID: 198581
		// (set) Token: 0x060307B6 RID: 198582
		int Quality { get; set; }

		// Token: 0x17006159 RID: 24921
		// (get) Token: 0x060307B7 RID: 198583
		// (set) Token: 0x060307B8 RID: 198584
		bool IsAchieve { get; set; }
	}
}
