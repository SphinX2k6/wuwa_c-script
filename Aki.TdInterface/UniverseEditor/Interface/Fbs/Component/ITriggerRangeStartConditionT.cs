using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060FB RID: 24827
	public class ITriggerRangeStartConditionT
	{
		// Token: 0x1700B8D4 RID: 47316
		// (get) Token: 0x0602A150 RID: 172368 RVA: 0x005BE9B0 File Offset: 0x005BCBB0
		// (set) Token: 0x0602A151 RID: 172369 RVA: 0x005BE9B8 File Offset: 0x005BCBB8
		public ESpawnMonsterStartCondition Type { get; set; }

		// Token: 0x1700B8D5 RID: 47317
		// (get) Token: 0x0602A152 RID: 172370 RVA: 0x005BE9C1 File Offset: 0x005BCBC1
		// (set) Token: 0x0602A153 RID: 172371 RVA: 0x005BE9C9 File Offset: 0x005BCBC9
		public int Range { get; set; }

		// Token: 0x0602A154 RID: 172372 RVA: 0x005BE9D2 File Offset: 0x005BCBD2
		public ITriggerRangeStartConditionT()
		{
			this.Type = ESpawnMonsterStartCondition.Immediate;
			this.Range = 0;
		}
	}
}
