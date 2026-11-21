using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C3B RID: 19515
	public class IEntityStateT
	{
		// Token: 0x17008A65 RID: 35429
		// (get) Token: 0x0601DE8E RID: 122510 RVA: 0x00431B0F File Offset: 0x0042FD0F
		// (set) Token: 0x0601DE8F RID: 122511 RVA: 0x00431B17 File Offset: 0x0042FD17
		public int EntityId { get; set; }

		// Token: 0x17008A66 RID: 35430
		// (get) Token: 0x0601DE90 RID: 122512 RVA: 0x00431B20 File Offset: 0x0042FD20
		// (set) Token: 0x0601DE91 RID: 122513 RVA: 0x00431B28 File Offset: 0x0042FD28
		public IEntityDataT Data { get; set; }

		// Token: 0x0601DE92 RID: 122514 RVA: 0x00431B31 File Offset: 0x0042FD31
		public IEntityStateT()
		{
			this.EntityId = 0;
			this.Data = null;
		}
	}
}
