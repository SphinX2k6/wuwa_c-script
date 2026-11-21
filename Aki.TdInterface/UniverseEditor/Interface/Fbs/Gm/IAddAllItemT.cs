using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A96 RID: 19094
	public class IAddAllItemT
	{
		// Token: 0x170085C4 RID: 34244
		// (get) Token: 0x0601CB34 RID: 117556 RVA: 0x0040BFD6 File Offset: 0x0040A1D6
		// (set) Token: 0x0601CB35 RID: 117557 RVA: 0x0040BFDE File Offset: 0x0040A1DE
		public EGmCommand Type { get; set; }

		// Token: 0x0601CB36 RID: 117558 RVA: 0x0040BFE7 File Offset: 0x0040A1E7
		public IAddAllItemT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
