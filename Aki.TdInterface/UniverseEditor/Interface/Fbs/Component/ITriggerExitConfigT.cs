using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE8 RID: 23272
	public class ITriggerExitConfigT
	{
		// Token: 0x1700AF86 RID: 44934
		// (get) Token: 0x06027B82 RID: 162690 RVA: 0x00576CF0 File Offset: 0x00574EF0
		// (set) Token: 0x06027B83 RID: 162691 RVA: 0x00576CF8 File Offset: 0x00574EF8
		public int ExtraRange { get; set; }

		// Token: 0x1700AF87 RID: 44935
		// (get) Token: 0x06027B84 RID: 162692 RVA: 0x00576D01 File Offset: 0x00574F01
		// (set) Token: 0x06027B85 RID: 162693 RVA: 0x00576D09 File Offset: 0x00574F09
		public int MaxTriggerTimes { get; set; }

		// Token: 0x1700AF88 RID: 44936
		// (get) Token: 0x06027B86 RID: 162694 RVA: 0x00576D12 File Offset: 0x00574F12
		// (set) Token: 0x06027B87 RID: 162695 RVA: 0x00576D1A File Offset: 0x00574F1A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700AF89 RID: 44937
		// (get) Token: 0x06027B88 RID: 162696 RVA: 0x00576D23 File Offset: 0x00574F23
		// (set) Token: 0x06027B89 RID: 162697 RVA: 0x00576D2B File Offset: 0x00574F2B
		public int MatchTypeCount { get; set; }

		// Token: 0x1700AF8A RID: 44938
		// (get) Token: 0x06027B8A RID: 162698 RVA: 0x00576D34 File Offset: 0x00574F34
		// (set) Token: 0x06027B8B RID: 162699 RVA: 0x00576D3C File Offset: 0x00574F3C
		public bool ExitByNotEnterCondition { get; set; }

		// Token: 0x1700AF8B RID: 44939
		// (get) Token: 0x06027B8C RID: 162700 RVA: 0x00576D45 File Offset: 0x00574F45
		// (set) Token: 0x06027B8D RID: 162701 RVA: 0x00576D4D File Offset: 0x00574F4D
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700AF8C RID: 44940
		// (get) Token: 0x06027B8E RID: 162702 RVA: 0x00576D56 File Offset: 0x00574F56
		// (set) Token: 0x06027B8F RID: 162703 RVA: 0x00576D5E File Offset: 0x00574F5E
		public bool DisableExecuteActionsWhenDestroy { get; set; }

		// Token: 0x1700AF8D RID: 44941
		// (get) Token: 0x06027B90 RID: 162704 RVA: 0x00576D67 File Offset: 0x00574F67
		// (set) Token: 0x06027B91 RID: 162705 RVA: 0x00576D6F File Offset: 0x00574F6F
		public byte NullMask { get; set; }

		// Token: 0x06027B92 RID: 162706 RVA: 0x00576D78 File Offset: 0x00574F78
		public ITriggerExitConfigT()
		{
			this.ExtraRange = 0;
			this.MaxTriggerTimes = 0;
			this.Condition = null;
			this.MatchTypeCount = 0;
			this.ExitByNotEnterCondition = false;
			this.Actions = null;
			this.DisableExecuteActionsWhenDestroy = false;
			this.NullMask = 0;
		}
	}
}
