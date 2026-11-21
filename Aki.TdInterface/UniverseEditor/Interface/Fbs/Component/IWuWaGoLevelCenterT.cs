using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061D8 RID: 25048
	public class IWuWaGoLevelCenterT
	{
		// Token: 0x1700BAC1 RID: 47809
		// (get) Token: 0x0602A97D RID: 174461 RVA: 0x005CEC32 File Offset: 0x005CCE32
		// (set) Token: 0x0602A97E RID: 174462 RVA: 0x005CEC3A File Offset: 0x005CCE3A
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700BAC2 RID: 47810
		// (get) Token: 0x0602A97F RID: 174463 RVA: 0x005CEC43 File Offset: 0x005CCE43
		// (set) Token: 0x0602A980 RID: 174464 RVA: 0x005CEC4B File Offset: 0x005CCE4B
		public string LevelKey { get; set; }

		// Token: 0x1700BAC3 RID: 47811
		// (get) Token: 0x0602A981 RID: 174465 RVA: 0x005CEC54 File Offset: 0x005CCE54
		// (set) Token: 0x0602A982 RID: 174466 RVA: 0x005CEC5C File Offset: 0x005CCE5C
		public List<int> LevelEntityIds { get; set; }

		// Token: 0x0602A983 RID: 174467 RVA: 0x005CEC65 File Offset: 0x005CCE65
		public IWuWaGoLevelCenterT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LevelKey = null;
			this.LevelEntityIds = null;
		}
	}
}
