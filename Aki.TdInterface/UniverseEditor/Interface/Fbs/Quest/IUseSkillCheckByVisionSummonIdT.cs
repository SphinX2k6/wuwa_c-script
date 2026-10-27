using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004257 RID: 16983
	public class IUseSkillCheckByVisionSummonIdT
	{
		// Token: 0x1700788F RID: 30863
		// (get) Token: 0x060191F9 RID: 102905 RVA: 0x0039C7A4 File Offset: 0x0039A9A4
		// (set) Token: 0x060191FA RID: 102906 RVA: 0x0039C7AC File Offset: 0x0039A9AC
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x17007890 RID: 30864
		// (get) Token: 0x060191FB RID: 102907 RVA: 0x0039C7B5 File Offset: 0x0039A9B5
		// (set) Token: 0x060191FC RID: 102908 RVA: 0x0039C7BD File Offset: 0x0039A9BD
		public int VisionId { get; set; }

		// Token: 0x060191FD RID: 102909 RVA: 0x0039C7C6 File Offset: 0x0039A9C6
		public IUseSkillCheckByVisionSummonIdT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
			this.VisionId = 0;
		}
	}
}
