using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B26 RID: 19238
	public class ITeleportToEntityT
	{
		// Token: 0x170086EE RID: 34542
		// (get) Token: 0x0601D04A RID: 118858 RVA: 0x004143EC File Offset: 0x004125EC
		// (set) Token: 0x0601D04B RID: 118859 RVA: 0x004143F4 File Offset: 0x004125F4
		public EGmCommand Type { get; set; }

		// Token: 0x170086EF RID: 34543
		// (get) Token: 0x0601D04C RID: 118860 RVA: 0x004143FD File Offset: 0x004125FD
		// (set) Token: 0x0601D04D RID: 118861 RVA: 0x00414405 File Offset: 0x00412605
		public int EntityId { get; set; }

		// Token: 0x170086F0 RID: 34544
		// (get) Token: 0x0601D04E RID: 118862 RVA: 0x0041440E File Offset: 0x0041260E
		// (set) Token: 0x0601D04F RID: 118863 RVA: 0x00414416 File Offset: 0x00412616
		public float Rotation { get; set; }

		// Token: 0x170086F1 RID: 34545
		// (get) Token: 0x0601D050 RID: 118864 RVA: 0x0041441F File Offset: 0x0041261F
		// (set) Token: 0x0601D051 RID: 118865 RVA: 0x00414427 File Offset: 0x00412627
		public byte NullMask { get; set; }

		// Token: 0x0601D052 RID: 118866 RVA: 0x00414430 File Offset: 0x00412630
		public ITeleportToEntityT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.EntityId = 0;
			this.Rotation = 0f;
			this.NullMask = 0;
		}
	}
}
