using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AEE RID: 23278
	public class ITriggerRangeStartConditionT
	{
		// Token: 0x1700AF98 RID: 44952
		// (get) Token: 0x06027BC4 RID: 162756 RVA: 0x005774EC File Offset: 0x005756EC
		// (set) Token: 0x06027BC5 RID: 162757 RVA: 0x005774F4 File Offset: 0x005756F4
		public ESpawnMonsterStartCondition Type { get; set; }

		// Token: 0x1700AF99 RID: 44953
		// (get) Token: 0x06027BC6 RID: 162758 RVA: 0x005774FD File Offset: 0x005756FD
		// (set) Token: 0x06027BC7 RID: 162759 RVA: 0x00577505 File Offset: 0x00575705
		public int Range { get; set; }

		// Token: 0x06027BC8 RID: 162760 RVA: 0x0057750E File Offset: 0x0057570E
		public ITriggerRangeStartConditionT()
		{
			this.Type = ESpawnMonsterStartCondition.Immediate;
			this.Range = 0;
		}
	}
}
