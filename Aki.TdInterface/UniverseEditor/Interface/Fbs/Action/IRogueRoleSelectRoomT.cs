using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007670 RID: 30320
	public class IRogueRoleSelectRoomT
	{
		// Token: 0x1700DE9A RID: 56986
		// (get) Token: 0x06035329 RID: 217897 RVA: 0x00723ED6 File Offset: 0x007220D6
		// (set) Token: 0x0603532A RID: 217898 RVA: 0x00723EDE File Offset: 0x007220DE
		public ERogueSelectRoomType Type { get; set; }

		// Token: 0x0603532B RID: 217899 RVA: 0x00723EE7 File Offset: 0x007220E7
		public IRogueRoleSelectRoomT()
		{
			this.Type = ERogueSelectRoomType.Role;
		}
	}
}
