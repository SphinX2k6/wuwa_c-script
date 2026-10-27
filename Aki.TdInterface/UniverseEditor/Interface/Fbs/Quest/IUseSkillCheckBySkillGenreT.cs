using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200424E RID: 16974
	public class IUseSkillCheckBySkillGenreT
	{
		// Token: 0x17007880 RID: 30848
		// (get) Token: 0x060191B7 RID: 102839 RVA: 0x0039C1A4 File Offset: 0x0039A3A4
		// (set) Token: 0x060191B8 RID: 102840 RVA: 0x0039C1AC File Offset: 0x0039A3AC
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x17007881 RID: 30849
		// (get) Token: 0x060191B9 RID: 102841 RVA: 0x0039C1B5 File Offset: 0x0039A3B5
		// (set) Token: 0x060191BA RID: 102842 RVA: 0x0039C1BD File Offset: 0x0039A3BD
		public ESkillCategory SkillGenre { get; set; }

		// Token: 0x060191BB RID: 102843 RVA: 0x0039C1C6 File Offset: 0x0039A3C6
		public IUseSkillCheckBySkillGenreT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
			this.SkillGenre = ESkillCategory.Normal;
		}
	}
}
