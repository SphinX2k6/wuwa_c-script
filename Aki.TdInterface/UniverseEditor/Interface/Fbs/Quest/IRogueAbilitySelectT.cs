using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040B0 RID: 16560
	public class IRogueAbilitySelectT
	{
		// Token: 0x170074E1 RID: 29921
		// (get) Token: 0x060181F7 RID: 98807 RVA: 0x0037A462 File Offset: 0x00378662
		// (set) Token: 0x060181F8 RID: 98808 RVA: 0x0037A46A File Offset: 0x0037866A
		public EShowUiType Type { get; set; }

		// Token: 0x170074E2 RID: 29922
		// (get) Token: 0x060181F9 RID: 98809 RVA: 0x0037A473 File Offset: 0x00378673
		// (set) Token: 0x060181FA RID: 98810 RVA: 0x0037A47B File Offset: 0x0037867B
		public ERogueAbilityType AbilityType { get; set; }

		// Token: 0x170074E3 RID: 29923
		// (get) Token: 0x060181FB RID: 98811 RVA: 0x0037A484 File Offset: 0x00378684
		// (set) Token: 0x060181FC RID: 98812 RVA: 0x0037A48C File Offset: 0x0037868C
		public int BindId { get; set; }

		// Token: 0x060181FD RID: 98813 RVA: 0x0037A495 File Offset: 0x00378695
		public IRogueAbilitySelectT()
		{
			this.Type = EShowUiType.All;
			this.AbilityType = ERogueAbilityType.None;
			this.BindId = 0;
		}
	}
}
