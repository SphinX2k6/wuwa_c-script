using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200716D RID: 29037
	public class ISpawnChildT
	{
		// Token: 0x1700D7BE RID: 55230
		// (get) Token: 0x060337C0 RID: 210880 RVA: 0x006EF8CB File Offset: 0x006EDACB
		// (set) Token: 0x060337C1 RID: 210881 RVA: 0x006EF8D3 File Offset: 0x006EDAD3
		public string TemplateGuid { get; set; }

		// Token: 0x1700D7BF RID: 55231
		// (get) Token: 0x060337C2 RID: 210882 RVA: 0x006EF8DC File Offset: 0x006EDADC
		// (set) Token: 0x060337C3 RID: 210883 RVA: 0x006EF8E4 File Offset: 0x006EDAE4
		public ITransformT Transform { get; set; }

		// Token: 0x060337C4 RID: 210884 RVA: 0x006EF8ED File Offset: 0x006EDAED
		public ISpawnChildT()
		{
			this.TemplateGuid = null;
			this.Transform = null;
		}
	}
}
