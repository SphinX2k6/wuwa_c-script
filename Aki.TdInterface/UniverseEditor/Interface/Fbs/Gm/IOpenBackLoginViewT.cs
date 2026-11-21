using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ADE RID: 19166
	public class IOpenBackLoginViewT
	{
		// Token: 0x1700865A RID: 34394
		// (get) Token: 0x0601CDFA RID: 118266 RVA: 0x004109CF File Offset: 0x0040EBCF
		// (set) Token: 0x0601CDFB RID: 118267 RVA: 0x004109D7 File Offset: 0x0040EBD7
		public EGmCommand Type { get; set; }

		// Token: 0x1700865B RID: 34395
		// (get) Token: 0x0601CDFC RID: 118268 RVA: 0x004109E0 File Offset: 0x0040EBE0
		// (set) Token: 0x0601CDFD RID: 118269 RVA: 0x004109E8 File Offset: 0x0040EBE8
		public string Account { get; set; }

		// Token: 0x0601CDFE RID: 118270 RVA: 0x004109F1 File Offset: 0x0040EBF1
		public IOpenBackLoginViewT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Account = null;
		}
	}
}
