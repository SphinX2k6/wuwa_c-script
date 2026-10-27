using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF2 RID: 28402
	public class IRogueSelectRoomTypeT
	{
		// Token: 0x1700D349 RID: 54089
		// (get) Token: 0x0603230D RID: 205581 RVA: 0x006C8516 File Offset: 0x006C6716
		// (set) Token: 0x0603230E RID: 205582 RVA: 0x006C851E File Offset: 0x006C671E
		public ERogueSelectRoomType Type { get; set; }

		// Token: 0x0603230F RID: 205583 RVA: 0x006C8527 File Offset: 0x006C6727
		public IRogueSelectRoomTypeT()
		{
			this.Type = ERogueSelectRoomType.Role;
		}
	}
}
