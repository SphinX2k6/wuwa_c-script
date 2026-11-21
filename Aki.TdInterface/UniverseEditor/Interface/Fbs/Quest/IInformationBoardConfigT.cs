using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D8 RID: 17112
	public class IInformationBoardConfigT
	{
		// Token: 0x17007536 RID: 30006
		// (get) Token: 0x0601805D RID: 98397 RVA: 0x0036DD3D File Offset: 0x0036BF3D
		// (set) Token: 0x0601805E RID: 98398 RVA: 0x0036DD45 File Offset: 0x0036BF45
		public IDangoAbyssInformationBoardT InformationBoard { get; set; }

		// Token: 0x0601805F RID: 98399 RVA: 0x0036DD4E File Offset: 0x0036BF4E
		public IInformationBoardConfigT()
		{
			this.InformationBoard = null;
		}
	}
}
