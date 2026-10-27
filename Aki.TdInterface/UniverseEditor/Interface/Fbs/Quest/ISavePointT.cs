using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004104 RID: 16644
	public class ISavePointT
	{
		// Token: 0x1700754E RID: 30030
		// (get) Token: 0x06018447 RID: 99399 RVA: 0x0037E2A3 File Offset: 0x0037C4A3
		// (set) Token: 0x06018448 RID: 99400 RVA: 0x0037E2AB File Offset: 0x0037C4AB
		public ESaveConfig Type { get; set; }

		// Token: 0x1700754F RID: 30031
		// (get) Token: 0x06018449 RID: 99401 RVA: 0x0037E2B4 File Offset: 0x0037C4B4
		// (set) Token: 0x0601844A RID: 99402 RVA: 0x0037E2BC File Offset: 0x0037C4BC
		public bool RelinkRollback { get; set; }

		// Token: 0x17007550 RID: 30032
		// (get) Token: 0x0601844B RID: 99403 RVA: 0x0037E2C5 File Offset: 0x0037C4C5
		// (set) Token: 0x0601844C RID: 99404 RVA: 0x0037E2CD File Offset: 0x0037C4CD
		public IPositionRollbackConfigT PosRollbackCfg { get; set; }

		// Token: 0x17007551 RID: 30033
		// (get) Token: 0x0601844D RID: 99405 RVA: 0x0037E2D6 File Offset: 0x0037C4D6
		// (set) Token: 0x0601844E RID: 99406 RVA: 0x0037E2DE File Offset: 0x0037C4DE
		public byte NullMask { get; set; }

		// Token: 0x0601844F RID: 99407 RVA: 0x0037E2E7 File Offset: 0x0037C4E7
		public ISavePointT()
		{
			this.Type = ESaveConfig.SaveNew;
			this.RelinkRollback = false;
			this.PosRollbackCfg = null;
			this.NullMask = 0;
		}
	}
}
