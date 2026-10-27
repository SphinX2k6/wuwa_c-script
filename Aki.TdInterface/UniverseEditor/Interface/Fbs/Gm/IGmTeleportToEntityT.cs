using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004670 RID: 18032
	public class IGmTeleportToEntityT
	{
		// Token: 0x1700800A RID: 32778
		// (get) Token: 0x0601B5ED RID: 112109 RVA: 0x003E41B2 File Offset: 0x003E23B2
		// (set) Token: 0x0601B5EE RID: 112110 RVA: 0x003E41BA File Offset: 0x003E23BA
		public EGmCommand Type { get; set; }

		// Token: 0x1700800B RID: 32779
		// (get) Token: 0x0601B5EF RID: 112111 RVA: 0x003E41C3 File Offset: 0x003E23C3
		// (set) Token: 0x0601B5F0 RID: 112112 RVA: 0x003E41CB File Offset: 0x003E23CB
		public int EntityId { get; set; }

		// Token: 0x1700800C RID: 32780
		// (get) Token: 0x0601B5F1 RID: 112113 RVA: 0x003E41D4 File Offset: 0x003E23D4
		// (set) Token: 0x0601B5F2 RID: 112114 RVA: 0x003E41DC File Offset: 0x003E23DC
		public int PreIncId { get; set; }

		// Token: 0x0601B5F3 RID: 112115 RVA: 0x003E41E5 File Offset: 0x003E23E5
		public IGmTeleportToEntityT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.EntityId = 0;
			this.PreIncId = 0;
		}
	}
}
