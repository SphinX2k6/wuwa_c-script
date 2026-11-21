using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046AD RID: 18093
	public class IUseSkillCheckBySkillIdT
	{
		// Token: 0x17007EB6 RID: 32438
		// (get) Token: 0x0601A939 RID: 108857 RVA: 0x003C7A7C File Offset: 0x003C5C7C
		// (set) Token: 0x0601A93A RID: 108858 RVA: 0x003C7A84 File Offset: 0x003C5C84
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x17007EB7 RID: 32439
		// (get) Token: 0x0601A93B RID: 108859 RVA: 0x003C7A8D File Offset: 0x003C5C8D
		// (set) Token: 0x0601A93C RID: 108860 RVA: 0x003C7A95 File Offset: 0x003C5C95
		public int SkillId { get; set; }

		// Token: 0x0601A93D RID: 108861 RVA: 0x003C7A9E File Offset: 0x003C5C9E
		public IUseSkillCheckBySkillIdT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
			this.SkillId = 0;
		}
	}
}
