using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ACB RID: 27339
	public class IModifySceneItemAttributeTagT
	{
		// Token: 0x1700CAD2 RID: 51922
		// (get) Token: 0x0602FE98 RID: 196248 RVA: 0x006844E1 File Offset: 0x006826E1
		// (set) Token: 0x0602FE99 RID: 196249 RVA: 0x006844E9 File Offset: 0x006826E9
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x1700CAD3 RID: 51923
		// (get) Token: 0x0602FE9A RID: 196250 RVA: 0x006844F2 File Offset: 0x006826F2
		// (set) Token: 0x0602FE9B RID: 196251 RVA: 0x006844FA File Offset: 0x006826FA
		public bool IsAddTag { get; set; }

		// Token: 0x1700CAD4 RID: 51924
		// (get) Token: 0x0602FE9C RID: 196252 RVA: 0x00684503 File Offset: 0x00682703
		// (set) Token: 0x0602FE9D RID: 196253 RVA: 0x0068450B File Offset: 0x0068270B
		public List<int> PerformanceTag { get; set; }

		// Token: 0x0602FE9E RID: 196254 RVA: 0x00684514 File Offset: 0x00682714
		public IModifySceneItemAttributeTagT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
			this.IsAddTag = false;
			this.PerformanceTag = null;
		}
	}
}
