using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005359 RID: 21337
	public class IActivateAllCorrectPieceT
	{
		// Token: 0x170096A6 RID: 38566
		// (get) Token: 0x06021385 RID: 136069 RVA: 0x00495BEE File Offset: 0x00493DEE
		// (set) Token: 0x06021386 RID: 136070 RVA: 0x00495BF6 File Offset: 0x00493DF6
		public EJigsawCompleteCondition Type { get; set; }

		// Token: 0x06021387 RID: 136071 RVA: 0x00495BFF File Offset: 0x00493DFF
		public IActivateAllCorrectPieceT()
		{
			this.Type = EJigsawCompleteCondition.ActivateAllCorrectPiece;
		}
	}
}
