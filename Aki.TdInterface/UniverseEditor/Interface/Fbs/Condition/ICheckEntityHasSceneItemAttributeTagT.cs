using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EC7 RID: 20167
	public class ICheckEntityHasSceneItemAttributeTagT
	{
		// Token: 0x17008FF7 RID: 36855
		// (get) Token: 0x0601F4AB RID: 128171 RVA: 0x0045CA13 File Offset: 0x0045AC13
		// (set) Token: 0x0601F4AC RID: 128172 RVA: 0x0045CA1B File Offset: 0x0045AC1B
		public ECondition Type { get; set; }

		// Token: 0x17008FF8 RID: 36856
		// (get) Token: 0x0601F4AD RID: 128173 RVA: 0x0045CA24 File Offset: 0x0045AC24
		// (set) Token: 0x0601F4AE RID: 128174 RVA: 0x0045CA2C File Offset: 0x0045AC2C
		public ECheckEntityPerformanceAttributeType CheckType { get; set; }

		// Token: 0x17008FF9 RID: 36857
		// (get) Token: 0x0601F4AF RID: 128175 RVA: 0x0045CA35 File Offset: 0x0045AC35
		// (set) Token: 0x0601F4B0 RID: 128176 RVA: 0x0045CA3D File Offset: 0x0045AC3D
		public int EntityId { get; set; }

		// Token: 0x17008FFA RID: 36858
		// (get) Token: 0x0601F4B1 RID: 128177 RVA: 0x0045CA46 File Offset: 0x0045AC46
		// (set) Token: 0x0601F4B2 RID: 128178 RVA: 0x0045CA4E File Offset: 0x0045AC4E
		public List<int> Tags { get; set; }

		// Token: 0x0601F4B3 RID: 128179 RVA: 0x0045CA57 File Offset: 0x0045AC57
		public ICheckEntityHasSceneItemAttributeTagT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckType = ECheckEntityPerformanceAttributeType.MatchAll;
			this.EntityId = 0;
			this.Tags = null;
		}
	}
}
