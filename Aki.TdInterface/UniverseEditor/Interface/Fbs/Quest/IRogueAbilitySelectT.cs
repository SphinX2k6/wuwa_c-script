using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044F1 RID: 17649
	public class IRogueAbilitySelectT
	{
		// Token: 0x17007AE7 RID: 31463
		// (get) Token: 0x06019898 RID: 104600 RVA: 0x003A43B2 File Offset: 0x003A25B2
		// (set) Token: 0x06019899 RID: 104601 RVA: 0x003A43BA File Offset: 0x003A25BA
		public EShowUiType Type { get; set; }

		// Token: 0x17007AE8 RID: 31464
		// (get) Token: 0x0601989A RID: 104602 RVA: 0x003A43C3 File Offset: 0x003A25C3
		// (set) Token: 0x0601989B RID: 104603 RVA: 0x003A43CB File Offset: 0x003A25CB
		public ERogueAbilityType AbilityType { get; set; }

		// Token: 0x17007AE9 RID: 31465
		// (get) Token: 0x0601989C RID: 104604 RVA: 0x003A43D4 File Offset: 0x003A25D4
		// (set) Token: 0x0601989D RID: 104605 RVA: 0x003A43DC File Offset: 0x003A25DC
		public int BindId { get; set; }

		// Token: 0x0601989E RID: 104606 RVA: 0x003A43E5 File Offset: 0x003A25E5
		public IRogueAbilitySelectT()
		{
			this.Type = EShowUiType.All;
			this.AbilityType = ERogueAbilityType.None;
			this.BindId = 0;
		}
	}
}
