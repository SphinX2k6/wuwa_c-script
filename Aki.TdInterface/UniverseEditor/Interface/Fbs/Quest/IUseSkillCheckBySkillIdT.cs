using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004251 RID: 16977
	public class IUseSkillCheckBySkillIdT
	{
		// Token: 0x17007885 RID: 30853
		// (get) Token: 0x060191CD RID: 102861 RVA: 0x0039C3A4 File Offset: 0x0039A5A4
		// (set) Token: 0x060191CE RID: 102862 RVA: 0x0039C3AC File Offset: 0x0039A5AC
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x17007886 RID: 30854
		// (get) Token: 0x060191CF RID: 102863 RVA: 0x0039C3B5 File Offset: 0x0039A5B5
		// (set) Token: 0x060191D0 RID: 102864 RVA: 0x0039C3BD File Offset: 0x0039A5BD
		public int SkillId { get; set; }

		// Token: 0x060191D1 RID: 102865 RVA: 0x0039C3C6 File Offset: 0x0039A5C6
		public IUseSkillCheckBySkillIdT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
			this.SkillId = 0;
		}
	}
}
