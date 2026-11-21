using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007673 RID: 30323
	public class IRogueSelectRoomT
	{
		// Token: 0x1700DE9D RID: 56989
		// (get) Token: 0x0603533B RID: 217915 RVA: 0x007240BD File Offset: 0x007222BD
		// (set) Token: 0x0603533C RID: 217916 RVA: 0x007240C5 File Offset: 0x007222C5
		public IRogueRoleSelectRoomT Config { get; set; }

		// Token: 0x0603533D RID: 217917 RVA: 0x007240CE File Offset: 0x007222CE
		public IRogueSelectRoomT()
		{
			this.Config = null;
		}
	}
}
