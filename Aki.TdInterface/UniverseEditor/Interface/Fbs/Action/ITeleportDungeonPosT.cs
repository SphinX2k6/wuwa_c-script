using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B6A RID: 31594
	public class ITeleportDungeonPosT
	{
		// Token: 0x1700EC97 RID: 60567
		// (get) Token: 0x06038E7E RID: 233086 RVA: 0x007B171B File Offset: 0x007AF91B
		// (set) Token: 0x06038E7F RID: 233087 RVA: 0x007B1723 File Offset: 0x007AF923
		public int DungeonId { get; set; }

		// Token: 0x1700EC98 RID: 60568
		// (get) Token: 0x06038E80 RID: 233088 RVA: 0x007B172C File Offset: 0x007AF92C
		// (set) Token: 0x06038E81 RID: 233089 RVA: 0x007B1734 File Offset: 0x007AF934
		public IVectorInfoT TeleportPos { get; set; }

		// Token: 0x06038E82 RID: 233090 RVA: 0x007B173D File Offset: 0x007AF93D
		public ITeleportDungeonPosT()
		{
			this.DungeonId = 0;
			this.TeleportPos = null;
		}
	}
}
