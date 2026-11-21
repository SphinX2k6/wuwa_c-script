using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D4 RID: 30676
	public class ISetJigsawFoundationTypeT
	{
		// Token: 0x1700E0DC RID: 57564
		// (get) Token: 0x06035E35 RID: 220725 RVA: 0x007384B6 File Offset: 0x007366B6
		// (set) Token: 0x06035E36 RID: 220726 RVA: 0x007384BE File Offset: 0x007366BE
		public ESetJigsawFoundationType Type { get; set; }

		// Token: 0x06035E37 RID: 220727 RVA: 0x007384C7 File Offset: 0x007366C7
		public ISetJigsawFoundationTypeT()
		{
			this.Type = ESetJigsawFoundationType.SetPieceState;
		}
	}
}
