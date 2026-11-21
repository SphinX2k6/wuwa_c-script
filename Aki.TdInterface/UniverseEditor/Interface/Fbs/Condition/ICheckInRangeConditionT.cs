using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F42 RID: 20290
	public class ICheckInRangeConditionT
	{
		// Token: 0x170090FA RID: 37114
		// (get) Token: 0x0601F8E7 RID: 129255 RVA: 0x00463EBC File Offset: 0x004620BC
		// (set) Token: 0x0601F8E8 RID: 129256 RVA: 0x00463EC4 File Offset: 0x004620C4
		public ECondition Type { get; set; }

		// Token: 0x170090FB RID: 37115
		// (get) Token: 0x0601F8E9 RID: 129257 RVA: 0x00463ECD File Offset: 0x004620CD
		// (set) Token: 0x0601F8EA RID: 129258 RVA: 0x00463ED5 File Offset: 0x004620D5
		public List<int> RangeEntities { get; set; }

		// Token: 0x170090FC RID: 37116
		// (get) Token: 0x0601F8EB RID: 129259 RVA: 0x00463EDE File Offset: 0x004620DE
		// (set) Token: 0x0601F8EC RID: 129260 RVA: 0x00463EE6 File Offset: 0x004620E6
		public bool InRange { get; set; }

		// Token: 0x170090FD RID: 37117
		// (get) Token: 0x0601F8ED RID: 129261 RVA: 0x00463EEF File Offset: 0x004620EF
		// (set) Token: 0x0601F8EE RID: 129262 RVA: 0x00463EF7 File Offset: 0x004620F7
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601F8EF RID: 129263 RVA: 0x00463F00 File Offset: 0x00462100
		public ICheckInRangeConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.RangeEntities = null;
			this.InRange = false;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
