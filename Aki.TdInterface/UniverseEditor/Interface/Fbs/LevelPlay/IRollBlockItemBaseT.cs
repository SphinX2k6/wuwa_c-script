using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049F9 RID: 18937
	public class IRollBlockItemBaseT
	{
		// Token: 0x170084C8 RID: 33992
		// (get) Token: 0x0601C64C RID: 116300 RVA: 0x00402DCA File Offset: 0x00400FCA
		// (set) Token: 0x0601C64D RID: 116301 RVA: 0x00402DD2 File Offset: 0x00400FD2
		public ERollBlockItemType Type { get; set; }

		// Token: 0x0601C64E RID: 116302 RVA: 0x00402DDB File Offset: 0x00400FDB
		public IRollBlockItemBaseT()
		{
			this.Type = ERollBlockItemType.BreakableObstacle;
		}
	}
}
