using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050D6 RID: 20694
	public class IDynamicBulletConfigT
	{
		// Token: 0x1700969C RID: 38556
		// (get) Token: 0x060214BB RID: 136379 RVA: 0x0049FC55 File Offset: 0x0049DE55
		// (set) Token: 0x060214BC RID: 136380 RVA: 0x0049FC5D File Offset: 0x0049DE5D
		public int BulletId { get; set; }

		// Token: 0x1700969D RID: 38557
		// (get) Token: 0x060214BD RID: 136381 RVA: 0x0049FC66 File Offset: 0x0049DE66
		// (set) Token: 0x060214BE RID: 136382 RVA: 0x0049FC6E File Offset: 0x0049DE6E
		public EPortalModel PortalModel { get; set; }

		// Token: 0x1700969E RID: 38558
		// (get) Token: 0x060214BF RID: 136383 RVA: 0x0049FC77 File Offset: 0x0049DE77
		// (set) Token: 0x060214C0 RID: 136384 RVA: 0x0049FC7F File Offset: 0x0049DE7F
		public string TemplateId { get; set; }

		// Token: 0x060214C1 RID: 136385 RVA: 0x0049FC88 File Offset: 0x0049DE88
		public IDynamicBulletConfigT()
		{
			this.BulletId = 0;
			this.PortalModel = EPortalModel.A;
			this.TemplateId = null;
		}
	}
}
