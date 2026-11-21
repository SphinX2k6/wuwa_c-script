using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073EF RID: 29679
	public class IPerformerAiMoveToPlayerT
	{
		// Token: 0x1700DA04 RID: 55812
		// (get) Token: 0x06033EBA RID: 212666 RVA: 0x0070012E File Offset: 0x006FE32E
		// (set) Token: 0x06033EBB RID: 212667 RVA: 0x00700136 File Offset: 0x006FE336
		public EPerformerAiMoveToType Type { get; set; }

		// Token: 0x06033EBC RID: 212668 RVA: 0x0070013F File Offset: 0x006FE33F
		public IPerformerAiMoveToPlayerT()
		{
			this.Type = EPerformerAiMoveToType.Position;
		}
	}
}
