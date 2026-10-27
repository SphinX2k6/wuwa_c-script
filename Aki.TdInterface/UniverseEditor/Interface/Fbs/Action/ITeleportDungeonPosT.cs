using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007383 RID: 29571
	public class ITeleportDungeonPosT
	{
		// Token: 0x1700E087 RID: 57479
		// (get) Token: 0x06035AE3 RID: 219875 RVA: 0x0074F1DB File Offset: 0x0074D3DB
		// (set) Token: 0x06035AE4 RID: 219876 RVA: 0x0074F1E3 File Offset: 0x0074D3E3
		public int DungeonId { get; set; }

		// Token: 0x1700E088 RID: 57480
		// (get) Token: 0x06035AE5 RID: 219877 RVA: 0x0074F1EC File Offset: 0x0074D3EC
		// (set) Token: 0x06035AE6 RID: 219878 RVA: 0x0074F1F4 File Offset: 0x0074D3F4
		public IVectorInfoT TeleportPos { get; set; }

		// Token: 0x06035AE7 RID: 219879 RVA: 0x0074F1FD File Offset: 0x0074D3FD
		public ITeleportDungeonPosT()
		{
			this.DungeonId = 0;
			this.TeleportPos = null;
		}
	}
}
