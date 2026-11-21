using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053BF RID: 21439
	public class IAllKillConditionT
	{
		// Token: 0x170097A6 RID: 38822
		// (get) Token: 0x06021781 RID: 137089 RVA: 0x0049DCEA File Offset: 0x0049BEEA
		// (set) Token: 0x06021782 RID: 137090 RVA: 0x0049DCF2 File Offset: 0x0049BEF2
		public ESpawnMonsterCompleteCondition Type { get; set; }

		// Token: 0x06021783 RID: 137091 RVA: 0x0049DCFB File Offset: 0x0049BEFB
		public IAllKillConditionT()
		{
			this.Type = ESpawnMonsterCompleteCondition.AllKill;
		}
	}
}
