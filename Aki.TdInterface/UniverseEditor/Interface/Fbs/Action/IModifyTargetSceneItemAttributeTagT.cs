using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200720B RID: 29195
	public class IModifyTargetSceneItemAttributeTagT
	{
		// Token: 0x1700D5AE RID: 54702
		// (get) Token: 0x06032CC0 RID: 208064 RVA: 0x006DC4C0 File Offset: 0x006DA6C0
		// (set) Token: 0x06032CC1 RID: 208065 RVA: 0x006DC4C8 File Offset: 0x006DA6C8
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x1700D5AF RID: 54703
		// (get) Token: 0x06032CC2 RID: 208066 RVA: 0x006DC4D1 File Offset: 0x006DA6D1
		// (set) Token: 0x06032CC3 RID: 208067 RVA: 0x006DC4D9 File Offset: 0x006DA6D9
		public bool IsAddTag { get; set; }

		// Token: 0x1700D5B0 RID: 54704
		// (get) Token: 0x06032CC4 RID: 208068 RVA: 0x006DC4E2 File Offset: 0x006DA6E2
		// (set) Token: 0x06032CC5 RID: 208069 RVA: 0x006DC4EA File Offset: 0x006DA6EA
		public List<int> PerformanceTag { get; set; }

		// Token: 0x1700D5B1 RID: 54705
		// (get) Token: 0x06032CC6 RID: 208070 RVA: 0x006DC4F3 File Offset: 0x006DA6F3
		// (set) Token: 0x06032CC7 RID: 208071 RVA: 0x006DC4FB File Offset: 0x006DA6FB
		public List<int> EntityIds { get; set; }

		// Token: 0x06032CC8 RID: 208072 RVA: 0x006DC504 File Offset: 0x006DA704
		public IModifyTargetSceneItemAttributeTagT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
			this.IsAddTag = false;
			this.PerformanceTag = null;
			this.EntityIds = null;
		}
	}
}
