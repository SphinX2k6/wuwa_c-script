using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD4 RID: 27348
	public class IModifyTargetSceneItemAttributeTagT
	{
		// Token: 0x1700CAE3 RID: 51939
		// (get) Token: 0x0602FEF4 RID: 196340 RVA: 0x00684F24 File Offset: 0x00683124
		// (set) Token: 0x0602FEF5 RID: 196341 RVA: 0x00684F2C File Offset: 0x0068312C
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x1700CAE4 RID: 51940
		// (get) Token: 0x0602FEF6 RID: 196342 RVA: 0x00684F35 File Offset: 0x00683135
		// (set) Token: 0x0602FEF7 RID: 196343 RVA: 0x00684F3D File Offset: 0x0068313D
		public bool IsAddTag { get; set; }

		// Token: 0x1700CAE5 RID: 51941
		// (get) Token: 0x0602FEF8 RID: 196344 RVA: 0x00684F46 File Offset: 0x00683146
		// (set) Token: 0x0602FEF9 RID: 196345 RVA: 0x00684F4E File Offset: 0x0068314E
		public List<int> PerformanceTag { get; set; }

		// Token: 0x1700CAE6 RID: 51942
		// (get) Token: 0x0602FEFA RID: 196346 RVA: 0x00684F57 File Offset: 0x00683157
		// (set) Token: 0x0602FEFB RID: 196347 RVA: 0x00684F5F File Offset: 0x0068315F
		public List<int> EntityIds { get; set; }

		// Token: 0x0602FEFC RID: 196348 RVA: 0x00684F68 File Offset: 0x00683168
		public IModifyTargetSceneItemAttributeTagT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
			this.IsAddTag = false;
			this.PerformanceTag = null;
			this.EntityIds = null;
		}
	}
}
