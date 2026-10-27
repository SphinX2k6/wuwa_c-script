using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B3 RID: 21683
	public class IJigsawPieceMatchT
	{
		// Token: 0x17009FBB RID: 40891
		// (get) Token: 0x06023B76 RID: 146294 RVA: 0x004F03EB File Offset: 0x004EE5EB
		// (set) Token: 0x06023B77 RID: 146295 RVA: 0x004F03F3 File Offset: 0x004EE5F3
		public int EntityId { get; set; }

		// Token: 0x17009FBC RID: 40892
		// (get) Token: 0x06023B78 RID: 146296 RVA: 0x004F03FC File Offset: 0x004EE5FC
		// (set) Token: 0x06023B79 RID: 146297 RVA: 0x004F0404 File Offset: 0x004EE604
		public IPieceIndexT Index { get; set; }

		// Token: 0x06023B7A RID: 146298 RVA: 0x004F040D File Offset: 0x004EE60D
		public IJigsawPieceMatchT()
		{
			this.EntityId = 0;
			this.Index = null;
		}
	}
}
