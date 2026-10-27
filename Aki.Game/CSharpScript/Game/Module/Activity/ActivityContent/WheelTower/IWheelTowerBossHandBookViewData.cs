using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F33 RID: 24371
	public interface IWheelTowerBossHandBookViewData
	{
		// Token: 0x17008F30 RID: 36656
		// (get) Token: 0x0603DE83 RID: 253571
		// (set) Token: 0x0603DE84 RID: 253572
		bool IsEndless { get; set; }

		// Token: 0x17008F31 RID: 36657
		// (get) Token: 0x0603DE85 RID: 253573
		// (set) Token: 0x0603DE86 RID: 253574
		int BossId { get; set; }

		// Token: 0x17008F32 RID: 36658
		// (get) Token: 0x0603DE87 RID: 253575
		// (set) Token: 0x0603DE88 RID: 253576
		int BossRound { get; set; }

		// Token: 0x17008F33 RID: 36659
		// (get) Token: 0x0603DE89 RID: 253577
		// (set) Token: 0x0603DE8A RID: 253578
		int TeamRound { get; set; }
	}
}
