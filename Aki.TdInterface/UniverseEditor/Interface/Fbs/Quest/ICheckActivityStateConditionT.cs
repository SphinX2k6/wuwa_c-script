using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D44 RID: 15684
	public class ICheckActivityStateConditionT
	{
		// Token: 0x17006B9A RID: 27546
		// (get) Token: 0x06015ADB RID: 88795 RVA: 0x00320C45 File Offset: 0x0031EE45
		// (set) Token: 0x06015ADC RID: 88796 RVA: 0x00320C4D File Offset: 0x0031EE4D
		public EChildQuest Type { get; set; }

		// Token: 0x17006B9B RID: 27547
		// (get) Token: 0x06015ADD RID: 88797 RVA: 0x00320C56 File Offset: 0x0031EE56
		// (set) Token: 0x06015ADE RID: 88798 RVA: 0x00320C5E File Offset: 0x0031EE5E
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006B9C RID: 27548
		// (get) Token: 0x06015ADF RID: 88799 RVA: 0x00320C67 File Offset: 0x0031EE67
		// (set) Token: 0x06015AE0 RID: 88800 RVA: 0x00320C6F File Offset: 0x0031EE6F
		public int ActivityId { get; set; }

		// Token: 0x17006B9D RID: 27549
		// (get) Token: 0x06015AE1 RID: 88801 RVA: 0x00320C78 File Offset: 0x0031EE78
		// (set) Token: 0x06015AE2 RID: 88802 RVA: 0x00320C80 File Offset: 0x0031EE80
		public ECompare Compare { get; set; }

		// Token: 0x17006B9E RID: 27550
		// (get) Token: 0x06015AE3 RID: 88803 RVA: 0x00320C89 File Offset: 0x0031EE89
		// (set) Token: 0x06015AE4 RID: 88804 RVA: 0x00320C91 File Offset: 0x0031EE91
		public EActivityState ActivityState { get; set; }

		// Token: 0x06015AE5 RID: 88805 RVA: 0x00320C9A File Offset: 0x0031EE9A
		public ICheckActivityStateConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.ActivityId = 0;
			this.Compare = ECompare.Eq;
			this.ActivityState = EActivityState.BeforeOpen;
		}
	}
}
