using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A7C RID: 19068
	public class ICheckInRangeConditionT
	{
		// Token: 0x17008A1E RID: 35358
		// (get) Token: 0x0601DE44 RID: 122436 RVA: 0x00432D30 File Offset: 0x00430F30
		// (set) Token: 0x0601DE45 RID: 122437 RVA: 0x00432D38 File Offset: 0x00430F38
		public ECondition Type { get; set; }

		// Token: 0x17008A1F RID: 35359
		// (get) Token: 0x0601DE46 RID: 122438 RVA: 0x00432D41 File Offset: 0x00430F41
		// (set) Token: 0x0601DE47 RID: 122439 RVA: 0x00432D49 File Offset: 0x00430F49
		public List<int> RangeEntities { get; set; }

		// Token: 0x17008A20 RID: 35360
		// (get) Token: 0x0601DE48 RID: 122440 RVA: 0x00432D52 File Offset: 0x00430F52
		// (set) Token: 0x0601DE49 RID: 122441 RVA: 0x00432D5A File Offset: 0x00430F5A
		public bool InRange { get; set; }

		// Token: 0x17008A21 RID: 35361
		// (get) Token: 0x0601DE4A RID: 122442 RVA: 0x00432D63 File Offset: 0x00430F63
		// (set) Token: 0x0601DE4B RID: 122443 RVA: 0x00432D6B File Offset: 0x00430F6B
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601DE4C RID: 122444 RVA: 0x00432D74 File Offset: 0x00430F74
		public ICheckInRangeConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.RangeEntities = null;
			this.InRange = false;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
