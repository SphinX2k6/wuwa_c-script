using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046B3 RID: 18099
	public class IUseSkillCheckByVisionSummonIdT
	{
		// Token: 0x17007EC0 RID: 32448
		// (get) Token: 0x0601A965 RID: 108901 RVA: 0x003C7E7C File Offset: 0x003C607C
		// (set) Token: 0x0601A966 RID: 108902 RVA: 0x003C7E84 File Offset: 0x003C6084
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x17007EC1 RID: 32449
		// (get) Token: 0x0601A967 RID: 108903 RVA: 0x003C7E8D File Offset: 0x003C608D
		// (set) Token: 0x0601A968 RID: 108904 RVA: 0x003C7E95 File Offset: 0x003C6095
		public int VisionId { get; set; }

		// Token: 0x0601A969 RID: 108905 RVA: 0x003C7E9E File Offset: 0x003C609E
		public IUseSkillCheckByVisionSummonIdT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
			this.VisionId = 0;
		}
	}
}
