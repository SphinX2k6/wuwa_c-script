using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F55 RID: 24405
	public class ISpawnMonsterCompleteConditionT
	{
		// Token: 0x1700B4BE RID: 46270
		// (get) Token: 0x0602903A RID: 167994 RVA: 0x0059A36A File Offset: 0x0059856A
		// (set) Token: 0x0602903B RID: 167995 RVA: 0x0059A372 File Offset: 0x00598572
		public ESpawnMonsterCompleteCondition Type { get; set; }

		// Token: 0x0602903C RID: 167996 RVA: 0x0059A37B File Offset: 0x0059857B
		public ISpawnMonsterCompleteConditionT()
		{
			this.Type = ESpawnMonsterCompleteCondition.AllKill;
		}
	}
}
