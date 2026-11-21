using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007107 RID: 28935
	public class ILiveInteractDanmakuTriggerSkillIdT
	{
		// Token: 0x1700D3E8 RID: 54248
		// (get) Token: 0x0603241B RID: 205851 RVA: 0x006CBE30 File Offset: 0x006CA030
		// (set) Token: 0x0603241C RID: 205852 RVA: 0x006CBE38 File Offset: 0x006CA038
		public ELiveInteractDanmakuTriggerType Type { get; set; }

		// Token: 0x1700D3E9 RID: 54249
		// (get) Token: 0x0603241D RID: 205853 RVA: 0x006CBE41 File Offset: 0x006CA041
		// (set) Token: 0x0603241E RID: 205854 RVA: 0x006CBE49 File Offset: 0x006CA049
		public int SkillId { get; set; }

		// Token: 0x0603241F RID: 205855 RVA: 0x006CBE52 File Offset: 0x006CA052
		public ILiveInteractDanmakuTriggerSkillIdT()
		{
			this.Type = ELiveInteractDanmakuTriggerType.SkillGenre;
			this.SkillId = 0;
		}
	}
}
