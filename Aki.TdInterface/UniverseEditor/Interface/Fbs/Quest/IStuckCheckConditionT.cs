using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200458D RID: 17805
	public class IStuckCheckConditionT
	{
		// Token: 0x17007C74 RID: 31860
		// (get) Token: 0x06019F3E RID: 106302 RVA: 0x003B3924 File Offset: 0x003B1B24
		// (set) Token: 0x06019F3F RID: 106303 RVA: 0x003B392C File Offset: 0x003B1B2C
		public List<int> RangeEntities { get; set; }

		// Token: 0x17007C75 RID: 31861
		// (get) Token: 0x06019F40 RID: 106304 RVA: 0x003B3935 File Offset: 0x003B1B35
		// (set) Token: 0x06019F41 RID: 106305 RVA: 0x003B393D File Offset: 0x003B1B3D
		public float TriggerInterval { get; set; }

		// Token: 0x17007C76 RID: 31862
		// (get) Token: 0x06019F42 RID: 106306 RVA: 0x003B3946 File Offset: 0x003B1B46
		// (set) Token: 0x06019F43 RID: 106307 RVA: 0x003B394E File Offset: 0x003B1B4E
		public int MaxTriggerTimes { get; set; }

		// Token: 0x17007C77 RID: 31863
		// (get) Token: 0x06019F44 RID: 106308 RVA: 0x003B3957 File Offset: 0x003B1B57
		// (set) Token: 0x06019F45 RID: 106309 RVA: 0x003B395F File Offset: 0x003B1B5F
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17007C78 RID: 31864
		// (get) Token: 0x06019F46 RID: 106310 RVA: 0x003B3968 File Offset: 0x003B1B68
		// (set) Token: 0x06019F47 RID: 106311 RVA: 0x003B3970 File Offset: 0x003B1B70
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06019F48 RID: 106312 RVA: 0x003B3979 File Offset: 0x003B1B79
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
