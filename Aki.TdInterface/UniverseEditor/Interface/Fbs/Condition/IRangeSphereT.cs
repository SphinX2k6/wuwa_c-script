using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CAD RID: 19629
	public class IRangeSphereT
	{
		// Token: 0x17008E87 RID: 36487
		// (get) Token: 0x0601F251 RID: 127569 RVA: 0x00459A55 File Offset: 0x00457C55
		// (set) Token: 0x0601F252 RID: 127570 RVA: 0x00459A5D File Offset: 0x00457C5D
		public ECondition Type { get; set; }

		// Token: 0x17008E88 RID: 36488
		// (get) Token: 0x0601F253 RID: 127571 RVA: 0x00459A66 File Offset: 0x00457C66
		// (set) Token: 0x0601F254 RID: 127572 RVA: 0x00459A6E File Offset: 0x00457C6E
		public IVectorInfoT Center { get; set; }

		// Token: 0x17008E89 RID: 36489
		// (get) Token: 0x0601F255 RID: 127573 RVA: 0x00459A77 File Offset: 0x00457C77
		// (set) Token: 0x0601F256 RID: 127574 RVA: 0x00459A7F File Offset: 0x00457C7F
		public int Radius { get; set; }

		// Token: 0x17008E8A RID: 36490
		// (get) Token: 0x0601F257 RID: 127575 RVA: 0x00459A88 File Offset: 0x00457C88
		// (set) Token: 0x0601F258 RID: 127576 RVA: 0x00459A90 File Offset: 0x00457C90
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x17008E8B RID: 36491
		// (get) Token: 0x0601F259 RID: 127577 RVA: 0x00459A99 File Offset: 0x00457C99
		// (set) Token: 0x0601F25A RID: 127578 RVA: 0x00459AA1 File Offset: 0x00457CA1
		public List<int> RangeEntities { get; set; }

		// Token: 0x17008E8C RID: 36492
		// (get) Token: 0x0601F25B RID: 127579 RVA: 0x00459AAA File Offset: 0x00457CAA
		// (set) Token: 0x0601F25C RID: 127580 RVA: 0x00459AB2 File Offset: 0x00457CB2
		public byte NullMask { get; set; }

		// Token: 0x0601F25D RID: 127581 RVA: 0x00459ABB File Offset: 0x00457CBB
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
