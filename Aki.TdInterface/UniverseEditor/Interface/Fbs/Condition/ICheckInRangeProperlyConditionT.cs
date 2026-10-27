using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A7F RID: 19071
	public class ICheckInRangeProperlyConditionT
	{
		// Token: 0x17008A27 RID: 35367
		// (get) Token: 0x0601DE6E RID: 122478 RVA: 0x004332F4 File Offset: 0x004314F4
		// (set) Token: 0x0601DE6F RID: 122479 RVA: 0x004332FC File Offset: 0x004314FC
		public ECondition Type { get; set; }

		// Token: 0x17008A28 RID: 35368
		// (get) Token: 0x0601DE70 RID: 122480 RVA: 0x00433305 File Offset: 0x00431505
		// (set) Token: 0x0601DE71 RID: 122481 RVA: 0x0043330D File Offset: 0x0043150D
		public List<int> RangeEntities { get; set; }

		// Token: 0x17008A29 RID: 35369
		// (get) Token: 0x0601DE72 RID: 122482 RVA: 0x00433316 File Offset: 0x00431516
		// (set) Token: 0x0601DE73 RID: 122483 RVA: 0x0043331E File Offset: 0x0043151E
		public bool InRange { get; set; }

		// Token: 0x17008A2A RID: 35370
		// (get) Token: 0x0601DE74 RID: 122484 RVA: 0x00433327 File Offset: 0x00431527
		// (set) Token: 0x0601DE75 RID: 122485 RVA: 0x0043332F File Offset: 0x0043152F
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601DE76 RID: 122486 RVA: 0x00433338 File Offset: 0x00431538
		public ICheckInRangeProperlyConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.RangeEntities = null;
			this.InRange = false;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
