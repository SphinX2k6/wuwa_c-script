using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535C RID: 21340
	public class IActivateSpecifiedPieceT
	{
		// Token: 0x170096AA RID: 38570
		// (get) Token: 0x0602139F RID: 136095 RVA: 0x00495F53 File Offset: 0x00494153
		// (set) Token: 0x060213A0 RID: 136096 RVA: 0x00495F5B File Offset: 0x0049415B
		public EJigsawCompleteCondition Type { get; set; }

		// Token: 0x170096AB RID: 38571
		// (get) Token: 0x060213A1 RID: 136097 RVA: 0x00495F64 File Offset: 0x00494164
		// (set) Token: 0x060213A2 RID: 136098 RVA: 0x00495F6C File Offset: 0x0049416C
		public List<IActivateSpecifiedPieceConfigT> Config { get; set; }

		// Token: 0x060213A3 RID: 136099 RVA: 0x00495F75 File Offset: 0x00494175
		public IActivateSpecifiedPieceT()
		{
			this.Type = EJigsawCompleteCondition.ActivateAllCorrectPiece;
			this.Config = null;
		}
	}
}
