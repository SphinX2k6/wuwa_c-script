using System;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D8A RID: 15754
	public class BossChallengeStateVisibility : IBossChallengeStateVisibility
	{
		// Token: 0x17005266 RID: 21094
		// (get) Token: 0x06028496 RID: 165014 RVA: 0x00B48926 File Offset: 0x00B46B26
		// (set) Token: 0x06028497 RID: 165015 RVA: 0x00B4892E File Offset: 0x00B46B2E
		public bool ShowUnlock { get; set; }

		// Token: 0x17005267 RID: 21095
		// (get) Token: 0x06028498 RID: 165016 RVA: 0x00B48937 File Offset: 0x00B46B37
		// (set) Token: 0x06028499 RID: 165017 RVA: 0x00B4893F File Offset: 0x00B46B3F
		public bool ShowEmptyIcon { get; set; }

		// Token: 0x17005268 RID: 21096
		// (get) Token: 0x0602849A RID: 165018 RVA: 0x00B48948 File Offset: 0x00B46B48
		// (set) Token: 0x0602849B RID: 165019 RVA: 0x00B48950 File Offset: 0x00B46B50
		public bool ShowFinished { get; set; }
	}
}
