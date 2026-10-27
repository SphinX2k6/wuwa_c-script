using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E9A RID: 16026
	public class IInformationBoardConfigT
	{
		// Token: 0x17006F49 RID: 28489
		// (get) Token: 0x06016A10 RID: 92688 RVA: 0x00344DB5 File Offset: 0x00342FB5
		// (set) Token: 0x06016A11 RID: 92689 RVA: 0x00344DBD File Offset: 0x00342FBD
		public IDangoAbyssInformationBoardT InformationBoard { get; set; }

		// Token: 0x06016A12 RID: 92690 RVA: 0x00344DC6 File Offset: 0x00342FC6
		public IInformationBoardConfigT()
		{
			this.InformationBoard = null;
		}
	}
}
