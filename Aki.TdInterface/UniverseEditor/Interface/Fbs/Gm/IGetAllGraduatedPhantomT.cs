using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ABD RID: 19133
	public class IGetAllGraduatedPhantomT
	{
		// Token: 0x1700860F RID: 34319
		// (get) Token: 0x0601CC6E RID: 117870 RVA: 0x0040DEA6 File Offset: 0x0040C0A6
		// (set) Token: 0x0601CC6F RID: 117871 RVA: 0x0040DEAE File Offset: 0x0040C0AE
		public EGmCommand Type { get; set; }

		// Token: 0x0601CC70 RID: 117872 RVA: 0x0040DEB7 File Offset: 0x0040C0B7
		public IGetAllGraduatedPhantomT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
