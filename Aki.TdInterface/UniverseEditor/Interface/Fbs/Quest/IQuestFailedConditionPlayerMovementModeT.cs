using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FE7 RID: 16359
	public class IQuestFailedConditionPlayerMovementModeT
	{
		// Token: 0x170072CC RID: 29388
		// (get) Token: 0x060178C3 RID: 96451 RVA: 0x003655C4 File Offset: 0x003637C4
		// (set) Token: 0x060178C4 RID: 96452 RVA: 0x003655CC File Offset: 0x003637CC
		public EPlayerMovementMode Mode { get; set; }

		// Token: 0x170072CD RID: 29389
		// (get) Token: 0x060178C5 RID: 96453 RVA: 0x003655D5 File Offset: 0x003637D5
		// (set) Token: 0x060178C6 RID: 96454 RVA: 0x003655DD File Offset: 0x003637DD
		public ECompare Compare { get; set; }

		// Token: 0x060178C7 RID: 96455 RVA: 0x003655E6 File Offset: 0x003637E6
		public IQuestFailedConditionPlayerMovementModeT()
		{
			this.Mode = EPlayerMovementMode.Ski;
			this.Compare = ECompare.Eq;
		}
	}
}
