using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004200 RID: 16896
	public class IDarkTideWyvernPositionBossEventT
	{
		// Token: 0x1700730A RID: 29450
		// (get) Token: 0x06017736 RID: 96054 RVA: 0x0035983E File Offset: 0x00357A3E
		// (set) Token: 0x06017737 RID: 96055 RVA: 0x00359846 File Offset: 0x00357A46
		public EDarkTideBossEventType Type { get; set; }

		// Token: 0x06017738 RID: 96056 RVA: 0x0035984F File Offset: 0x00357A4F
		public IDarkTideWyvernPositionBossEventT()
		{
			this.Type = EDarkTideBossEventType.XinjilemuChase;
		}
	}
}
