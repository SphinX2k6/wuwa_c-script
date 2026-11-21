using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046AA RID: 18090
	public class IUseSkillCheckBySkillGenreT
	{
		// Token: 0x17007EB1 RID: 32433
		// (get) Token: 0x0601A923 RID: 108835 RVA: 0x003C787C File Offset: 0x003C5A7C
		// (set) Token: 0x0601A924 RID: 108836 RVA: 0x003C7884 File Offset: 0x003C5A84
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x17007EB2 RID: 32434
		// (get) Token: 0x0601A925 RID: 108837 RVA: 0x003C788D File Offset: 0x003C5A8D
		// (set) Token: 0x0601A926 RID: 108838 RVA: 0x003C7895 File Offset: 0x003C5A95
		public ESkillCategory SkillGenre { get; set; }

		// Token: 0x0601A927 RID: 108839 RVA: 0x003C789E File Offset: 0x003C5A9E
		public IUseSkillCheckBySkillGenreT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
			this.SkillGenre = ESkillCategory.Normal;
		}
	}
}
