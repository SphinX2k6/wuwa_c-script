using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004254 RID: 16980
	public class IUseSkillCheckByVisionShowIdT
	{
		// Token: 0x1700788A RID: 30858
		// (get) Token: 0x060191E3 RID: 102883 RVA: 0x0039C5A4 File Offset: 0x0039A7A4
		// (set) Token: 0x060191E4 RID: 102884 RVA: 0x0039C5AC File Offset: 0x0039A7AC
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x1700788B RID: 30859
		// (get) Token: 0x060191E5 RID: 102885 RVA: 0x0039C5B5 File Offset: 0x0039A7B5
		// (set) Token: 0x060191E6 RID: 102886 RVA: 0x0039C5BD File Offset: 0x0039A7BD
		public int VisionId { get; set; }

		// Token: 0x060191E7 RID: 102887 RVA: 0x0039C5C6 File Offset: 0x0039A7C6
		public IUseSkillCheckByVisionShowIdT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
			this.VisionId = 0;
		}
	}
}
