using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007939 RID: 31033
	public class ISpawnChildT
	{
		// Token: 0x1700E3A3 RID: 58275
		// (get) Token: 0x06036A6A RID: 223850 RVA: 0x007500D7 File Offset: 0x0074E2D7
		// (set) Token: 0x06036A6B RID: 223851 RVA: 0x007500DF File Offset: 0x0074E2DF
		public string TemplateGuid { get; set; }

		// Token: 0x1700E3A4 RID: 58276
		// (get) Token: 0x06036A6C RID: 223852 RVA: 0x007500E8 File Offset: 0x0074E2E8
		// (set) Token: 0x06036A6D RID: 223853 RVA: 0x007500F0 File Offset: 0x0074E2F0
		public ITransformT Transform { get; set; }

		// Token: 0x06036A6E RID: 223854 RVA: 0x007500F9 File Offset: 0x0074E2F9
		public ISpawnChildT()
		{
			this.TemplateGuid = null;
			this.Transform = null;
		}
	}
}
