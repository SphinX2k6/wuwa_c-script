using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004655 RID: 18005
	public class IGetAllGraduatedPhantomT
	{
		// Token: 0x17007FCE RID: 32718
		// (get) Token: 0x0601B499 RID: 111769 RVA: 0x003E1C0A File Offset: 0x003DFE0A
		// (set) Token: 0x0601B49A RID: 111770 RVA: 0x003E1C12 File Offset: 0x003DFE12
		public EGmCommand Type { get; set; }

		// Token: 0x0601B49B RID: 111771 RVA: 0x003E1C1B File Offset: 0x003DFE1B
		public IGetAllGraduatedPhantomT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
