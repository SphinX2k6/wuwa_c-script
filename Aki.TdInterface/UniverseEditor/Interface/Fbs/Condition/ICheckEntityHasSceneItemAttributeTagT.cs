using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A07 RID: 18951
	public class ICheckEntityHasSceneItemAttributeTagT
	{
		// Token: 0x17008927 RID: 35111
		// (get) Token: 0x0601DA38 RID: 121400 RVA: 0x0042BDA7 File Offset: 0x00429FA7
		// (set) Token: 0x0601DA39 RID: 121401 RVA: 0x0042BDAF File Offset: 0x00429FAF
		public ECondition Type { get; set; }

		// Token: 0x17008928 RID: 35112
		// (get) Token: 0x0601DA3A RID: 121402 RVA: 0x0042BDB8 File Offset: 0x00429FB8
		// (set) Token: 0x0601DA3B RID: 121403 RVA: 0x0042BDC0 File Offset: 0x00429FC0
		public ECheckEntityPerformanceAttributeType CheckType { get; set; }

		// Token: 0x17008929 RID: 35113
		// (get) Token: 0x0601DA3C RID: 121404 RVA: 0x0042BDC9 File Offset: 0x00429FC9
		// (set) Token: 0x0601DA3D RID: 121405 RVA: 0x0042BDD1 File Offset: 0x00429FD1
		public int EntityId { get; set; }

		// Token: 0x1700892A RID: 35114
		// (get) Token: 0x0601DA3E RID: 121406 RVA: 0x0042BDDA File Offset: 0x00429FDA
		// (set) Token: 0x0601DA3F RID: 121407 RVA: 0x0042BDE2 File Offset: 0x00429FE2
		public List<int> Tags { get; set; }

		// Token: 0x0601DA40 RID: 121408 RVA: 0x0042BDEB File Offset: 0x00429FEB
		public ICheckEntityHasSceneItemAttributeTagT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckType = ECheckEntityPerformanceAttributeType.MatchAll;
			this.EntityId = 0;
			this.Tags = null;
		}
	}
}
