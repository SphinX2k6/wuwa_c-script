using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200563B RID: 22075
	public class IDynamicBulletConfigT
	{
		// Token: 0x17009E89 RID: 40585
		// (get) Token: 0x0602340F RID: 144399 RVA: 0x004D9BE1 File Offset: 0x004D7DE1
		// (set) Token: 0x06023410 RID: 144400 RVA: 0x004D9BE9 File Offset: 0x004D7DE9
		public int BulletId { get; set; }

		// Token: 0x17009E8A RID: 40586
		// (get) Token: 0x06023411 RID: 144401 RVA: 0x004D9BF2 File Offset: 0x004D7DF2
		// (set) Token: 0x06023412 RID: 144402 RVA: 0x004D9BFA File Offset: 0x004D7DFA
		public EPortalModel PortalModel { get; set; }

		// Token: 0x17009E8B RID: 40587
		// (get) Token: 0x06023413 RID: 144403 RVA: 0x004D9C03 File Offset: 0x004D7E03
		// (set) Token: 0x06023414 RID: 144404 RVA: 0x004D9C0B File Offset: 0x004D7E0B
		public string TemplateId { get; set; }

		// Token: 0x06023415 RID: 144405 RVA: 0x004D9C14 File Offset: 0x004D7E14
		public IDynamicBulletConfigT()
		{
			this.BulletId = 0;
			this.PortalModel = EPortalModel.A;
			this.TemplateId = null;
		}
	}
}
