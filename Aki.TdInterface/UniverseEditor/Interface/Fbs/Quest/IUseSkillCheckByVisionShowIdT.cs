using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046B0 RID: 18096
	public class IUseSkillCheckByVisionShowIdT
	{
		// Token: 0x17007EBB RID: 32443
		// (get) Token: 0x0601A94F RID: 108879 RVA: 0x003C7C7C File Offset: 0x003C5E7C
		// (set) Token: 0x0601A950 RID: 108880 RVA: 0x003C7C84 File Offset: 0x003C5E84
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x17007EBC RID: 32444
		// (get) Token: 0x0601A951 RID: 108881 RVA: 0x003C7C8D File Offset: 0x003C5E8D
		// (set) Token: 0x0601A952 RID: 108882 RVA: 0x003C7C95 File Offset: 0x003C5E95
		public int VisionId { get; set; }

		// Token: 0x0601A953 RID: 108883 RVA: 0x003C7C9E File Offset: 0x003C5E9E
		public IUseSkillCheckByVisionShowIdT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
			this.VisionId = 0;
		}
	}
}
