using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419A RID: 16794
	public class ICheckTrapDefenseEventMonsterKilledT
	{
		// Token: 0x170071CA RID: 29130
		// (get) Token: 0x0601721F RID: 94751 RVA: 0x0034BD7C File Offset: 0x00349F7C
		// (set) Token: 0x06017220 RID: 94752 RVA: 0x0034BD84 File Offset: 0x00349F84
		public ECheckTrapDefenseEvent Type { get; set; }

		// Token: 0x170071CB RID: 29131
		// (get) Token: 0x06017221 RID: 94753 RVA: 0x0034BD8D File Offset: 0x00349F8D
		// (set) Token: 0x06017222 RID: 94754 RVA: 0x0034BD95 File Offset: 0x00349F95
		public int Id { get; set; }

		// Token: 0x06017223 RID: 94755 RVA: 0x0034BD9E File Offset: 0x00349F9E
		public ICheckTrapDefenseEventMonsterKilledT()
		{
			this.Type = ECheckTrapDefenseEvent.MonsterKilled;
			this.Id = 0;
		}
	}
}
