using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EEC RID: 28396
	public class IRogueRoleSelectRoomT
	{
		// Token: 0x1700D343 RID: 54083
		// (get) Token: 0x060322E9 RID: 205545 RVA: 0x006C81A2 File Offset: 0x006C63A2
		// (set) Token: 0x060322EA RID: 205546 RVA: 0x006C81AA File Offset: 0x006C63AA
		public ERogueSelectRoomType Type { get; set; }

		// Token: 0x060322EB RID: 205547 RVA: 0x006C81B3 File Offset: 0x006C63B3
		public IRogueRoleSelectRoomT()
		{
			this.Type = ERogueSelectRoomType.Role;
		}
	}
}
