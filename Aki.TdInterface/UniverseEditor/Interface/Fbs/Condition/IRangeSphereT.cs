using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051A6 RID: 20902
	public class IRangeSphereT
	{
		// Token: 0x170095B5 RID: 38325
		// (get) Token: 0x06020E73 RID: 134771 RVA: 0x0048D5A5 File Offset: 0x0048B7A5
		// (set) Token: 0x06020E74 RID: 134772 RVA: 0x0048D5AD File Offset: 0x0048B7AD
		public ECondition Type { get; set; }

		// Token: 0x170095B6 RID: 38326
		// (get) Token: 0x06020E75 RID: 134773 RVA: 0x0048D5B6 File Offset: 0x0048B7B6
		// (set) Token: 0x06020E76 RID: 134774 RVA: 0x0048D5BE File Offset: 0x0048B7BE
		public IVectorInfoT Center { get; set; }

		// Token: 0x170095B7 RID: 38327
		// (get) Token: 0x06020E77 RID: 134775 RVA: 0x0048D5C7 File Offset: 0x0048B7C7
		// (set) Token: 0x06020E78 RID: 134776 RVA: 0x0048D5CF File Offset: 0x0048B7CF
		public int Radius { get; set; }

		// Token: 0x170095B8 RID: 38328
		// (get) Token: 0x06020E79 RID: 134777 RVA: 0x0048D5D8 File Offset: 0x0048B7D8
		// (set) Token: 0x06020E7A RID: 134778 RVA: 0x0048D5E0 File Offset: 0x0048B7E0
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x170095B9 RID: 38329
		// (get) Token: 0x06020E7B RID: 134779 RVA: 0x0048D5E9 File Offset: 0x0048B7E9
		// (set) Token: 0x06020E7C RID: 134780 RVA: 0x0048D5F1 File Offset: 0x0048B7F1
		public List<int> RangeEntities { get; set; }

		// Token: 0x170095BA RID: 38330
		// (get) Token: 0x06020E7D RID: 134781 RVA: 0x0048D5FA File Offset: 0x0048B7FA
		// (set) Token: 0x06020E7E RID: 134782 RVA: 0x0048D602 File Offset: 0x0048B802
		public byte NullMask { get; set; }

		// Token: 0x06020E7F RID: 134783 RVA: 0x0048D60B File Offset: 0x0048B80B
		public IRangeSphereT()
		{
			this.Type = ECondition.CompareVar;
			this.Center = null;
			this.Radius = 0;
			this.OnlinePlayerConditionTargetOption = null;
			this.RangeEntities = null;
			this.NullMask = 0;
		}
	}
}
