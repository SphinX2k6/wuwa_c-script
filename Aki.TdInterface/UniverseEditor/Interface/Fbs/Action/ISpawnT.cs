using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200716A RID: 29034
	public class ISpawnT
	{
		// Token: 0x1700D7B9 RID: 55225
		// (get) Token: 0x060337A8 RID: 210856 RVA: 0x006EF607 File Offset: 0x006ED807
		// (set) Token: 0x060337A9 RID: 210857 RVA: 0x006EF60F File Offset: 0x006ED80F
		public int TemplateGuid { get; set; }

		// Token: 0x1700D7BA RID: 55226
		// (get) Token: 0x060337AA RID: 210858 RVA: 0x006EF618 File Offset: 0x006ED818
		// (set) Token: 0x060337AB RID: 210859 RVA: 0x006EF620 File Offset: 0x006ED820
		public ITransformT Transform { get; set; }

		// Token: 0x060337AC RID: 210860 RVA: 0x006EF629 File Offset: 0x006ED829
		public ISpawnT()
		{
			this.TemplateGuid = 0;
			this.Transform = null;
		}
	}
}
