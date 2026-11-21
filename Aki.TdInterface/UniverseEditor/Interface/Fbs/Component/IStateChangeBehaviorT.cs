using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FAC RID: 24492
	public class IStateChangeBehaviorT
	{
		// Token: 0x1700B563 RID: 46435
		// (get) Token: 0x0602933C RID: 168764 RVA: 0x005A00FF File Offset: 0x0059E2FF
		// (set) Token: 0x0602933D RID: 168765 RVA: 0x005A0107 File Offset: 0x0059E307
		public string State { get; set; }

		// Token: 0x1700B564 RID: 46436
		// (get) Token: 0x0602933E RID: 168766 RVA: 0x005A0110 File Offset: 0x0059E310
		// (set) Token: 0x0602933F RID: 168767 RVA: 0x005A0118 File Offset: 0x0059E318
		public List<IActionInfoT> Action { get; set; }

		// Token: 0x1700B565 RID: 46437
		// (get) Token: 0x06029340 RID: 168768 RVA: 0x005A0121 File Offset: 0x0059E321
		// (set) Token: 0x06029341 RID: 168769 RVA: 0x005A0129 File Offset: 0x0059E329
		public IDelayChangeStateT DelayChangeState { get; set; }

		// Token: 0x1700B566 RID: 46438
		// (get) Token: 0x06029342 RID: 168770 RVA: 0x005A0132 File Offset: 0x0059E332
		// (set) Token: 0x06029343 RID: 168771 RVA: 0x005A013A File Offset: 0x0059E33A
		public bool PendingConditionAvailable { get; set; }

		// Token: 0x1700B567 RID: 46439
		// (get) Token: 0x06029344 RID: 168772 RVA: 0x005A0143 File Offset: 0x0059E343
		// (set) Token: 0x06029345 RID: 168773 RVA: 0x005A014B File Offset: 0x0059E34B
		public List<IConditionActionT> ConditionAction { get; set; }

		// Token: 0x1700B568 RID: 46440
		// (get) Token: 0x06029346 RID: 168774 RVA: 0x005A0154 File Offset: 0x0059E354
		// (set) Token: 0x06029347 RID: 168775 RVA: 0x005A015C File Offset: 0x0059E35C
		public byte NullMask { get; set; }

		// Token: 0x06029348 RID: 168776 RVA: 0x005A0165 File Offset: 0x0059E365
		public IStateChangeBehaviorT()
		{
			this.State = null;
			this.Action = null;
			this.DelayChangeState = null;
			this.PendingConditionAvailable = false;
			this.ConditionAction = null;
			this.NullMask = 0;
		}
	}
}
