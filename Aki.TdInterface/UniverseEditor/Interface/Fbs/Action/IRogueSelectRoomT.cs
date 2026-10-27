using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EEF RID: 28399
	public class IRogueSelectRoomT
	{
		// Token: 0x1700D346 RID: 54086
		// (get) Token: 0x060322FB RID: 205563 RVA: 0x006C8389 File Offset: 0x006C6589
		// (set) Token: 0x060322FC RID: 205564 RVA: 0x006C8391 File Offset: 0x006C6591
		public IRogueRoleSelectRoomT Config { get; set; }

		// Token: 0x060322FD RID: 205565 RVA: 0x006C839A File Offset: 0x006C659A
		public IRogueSelectRoomT()
		{
			this.Config = null;
		}
	}
}
