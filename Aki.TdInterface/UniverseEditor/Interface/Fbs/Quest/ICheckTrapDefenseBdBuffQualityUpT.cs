using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418E RID: 16782
	public class ICheckTrapDefenseBdBuffQualityUpT
	{
		// Token: 0x170071BA RID: 29114
		// (get) Token: 0x060171CD RID: 94669 RVA: 0x0034B452 File Offset: 0x00349652
		// (set) Token: 0x060171CE RID: 94670 RVA: 0x0034B45A File Offset: 0x0034965A
		public ECheckTrapDefenseEvent Type { get; set; }

		// Token: 0x060171CF RID: 94671 RVA: 0x0034B463 File Offset: 0x00349663
		public ICheckTrapDefenseBdBuffQualityUpT()
		{
			this.Type = ECheckTrapDefenseEvent.MonsterKilled;
		}
	}
}
