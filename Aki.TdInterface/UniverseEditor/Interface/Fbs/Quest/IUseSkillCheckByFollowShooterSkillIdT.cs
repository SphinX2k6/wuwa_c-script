using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046A7 RID: 18087
	public class IUseSkillCheckByFollowShooterSkillIdT
	{
		// Token: 0x17007EAC RID: 32428
		// (get) Token: 0x0601A90D RID: 108813 RVA: 0x003C767C File Offset: 0x003C587C
		// (set) Token: 0x0601A90E RID: 108814 RVA: 0x003C7684 File Offset: 0x003C5884
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x17007EAD RID: 32429
		// (get) Token: 0x0601A90F RID: 108815 RVA: 0x003C768D File Offset: 0x003C588D
		// (set) Token: 0x0601A910 RID: 108816 RVA: 0x003C7695 File Offset: 0x003C5895
		public int SkillId { get; set; }

		// Token: 0x0601A911 RID: 108817 RVA: 0x003C769E File Offset: 0x003C589E
		public IUseSkillCheckByFollowShooterSkillIdT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
			this.SkillId = 0;
		}
	}
}
