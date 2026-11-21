using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007936 RID: 31030
	public class ISpawnT
	{
		// Token: 0x1700E39E RID: 58270
		// (get) Token: 0x06036A52 RID: 223826 RVA: 0x0074FE13 File Offset: 0x0074E013
		// (set) Token: 0x06036A53 RID: 223827 RVA: 0x0074FE1B File Offset: 0x0074E01B
		public int TemplateGuid { get; set; }

		// Token: 0x1700E39F RID: 58271
		// (get) Token: 0x06036A54 RID: 223828 RVA: 0x0074FE24 File Offset: 0x0074E024
		// (set) Token: 0x06036A55 RID: 223829 RVA: 0x0074FE2C File Offset: 0x0074E02C
		public ITransformT Transform { get; set; }

		// Token: 0x06036A56 RID: 223830 RVA: 0x0074FE35 File Offset: 0x0074E035
		public ISpawnT()
		{
			this.TemplateGuid = 0;
			this.Transform = null;
		}
	}
}
