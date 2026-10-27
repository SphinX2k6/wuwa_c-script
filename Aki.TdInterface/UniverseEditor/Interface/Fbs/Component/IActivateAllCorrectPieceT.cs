using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E48 RID: 20040
	public class IActivateAllCorrectPieceT
	{
		// Token: 0x17008F6D RID: 36717
		// (get) Token: 0x0601F73A RID: 128826 RVA: 0x00461BD6 File Offset: 0x0045FDD6
		// (set) Token: 0x0601F73B RID: 128827 RVA: 0x00461BDE File Offset: 0x0045FDDE
		public EJigsawCompleteCondition Type { get; set; }

		// Token: 0x0601F73C RID: 128828 RVA: 0x00461BE7 File Offset: 0x0045FDE7
		public IActivateAllCorrectPieceT()
		{
			this.Type = EJigsawCompleteCondition.ActivateAllCorrectPiece;
		}
	}
}
