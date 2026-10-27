using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004149 RID: 16713
	public class IStuckCheckConditionT
	{
		// Token: 0x17007665 RID: 30309
		// (get) Token: 0x06018876 RID: 100470 RVA: 0x00389368 File Offset: 0x00387568
		// (set) Token: 0x06018877 RID: 100471 RVA: 0x00389370 File Offset: 0x00387570
		public List<int> RangeEntities { get; set; }

		// Token: 0x17007666 RID: 30310
		// (get) Token: 0x06018878 RID: 100472 RVA: 0x00389379 File Offset: 0x00387579
		// (set) Token: 0x06018879 RID: 100473 RVA: 0x00389381 File Offset: 0x00387581
		public float TriggerInterval { get; set; }

		// Token: 0x17007667 RID: 30311
		// (get) Token: 0x0601887A RID: 100474 RVA: 0x0038938A File Offset: 0x0038758A
		// (set) Token: 0x0601887B RID: 100475 RVA: 0x00389392 File Offset: 0x00387592
		public int MaxTriggerTimes { get; set; }

		// Token: 0x17007668 RID: 30312
		// (get) Token: 0x0601887C RID: 100476 RVA: 0x0038939B File Offset: 0x0038759B
		// (set) Token: 0x0601887D RID: 100477 RVA: 0x003893A3 File Offset: 0x003875A3
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17007669 RID: 30313
		// (get) Token: 0x0601887E RID: 100478 RVA: 0x003893AC File Offset: 0x003875AC
		// (set) Token: 0x0601887F RID: 100479 RVA: 0x003893B4 File Offset: 0x003875B4
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06018880 RID: 100480 RVA: 0x003893BD File Offset: 0x003875BD
		public IStuckCheckConditionT()
		{
			this.RangeEntities = null;
			this.TriggerInterval = 0f;
			this.MaxTriggerTimes = 0;
			this.Condition = null;
			this.Actions = null;
		}
	}
}
