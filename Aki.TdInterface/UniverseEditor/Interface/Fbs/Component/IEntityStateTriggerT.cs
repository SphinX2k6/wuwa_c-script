using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005722 RID: 22306
	public class IEntityStateTriggerT
	{
		// Token: 0x1700A0FF RID: 41215
		// (get) Token: 0x06023DDC RID: 146908 RVA: 0x004EE455 File Offset: 0x004EC655
		// (set) Token: 0x06023DDD RID: 146909 RVA: 0x004EE45D File Offset: 0x004EC65D
		public IEntityGroupConditionT GroupCondition { get; set; }

		// Token: 0x1700A100 RID: 41216
		// (get) Token: 0x06023DDE RID: 146910 RVA: 0x004EE466 File Offset: 0x004EC666
		// (set) Token: 0x06023DDF RID: 146911 RVA: 0x004EE46E File Offset: 0x004EC66E
		public List<IActionInfoT> SuccessActions { get; set; }

		// Token: 0x1700A101 RID: 41217
		// (get) Token: 0x06023DE0 RID: 146912 RVA: 0x004EE477 File Offset: 0x004EC677
		// (set) Token: 0x06023DE1 RID: 146913 RVA: 0x004EE47F File Offset: 0x004EC67F
		public List<IActionInfoT> FailActions { get; set; }

		// Token: 0x1700A102 RID: 41218
		// (get) Token: 0x06023DE2 RID: 146914 RVA: 0x004EE488 File Offset: 0x004EC688
		// (set) Token: 0x06023DE3 RID: 146915 RVA: 0x004EE490 File Offset: 0x004EC690
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A103 RID: 41219
		// (get) Token: 0x06023DE4 RID: 146916 RVA: 0x004EE499 File Offset: 0x004EC699
		// (set) Token: 0x06023DE5 RID: 146917 RVA: 0x004EE4A1 File Offset: 0x004EC6A1
		public byte NullMask { get; set; }

		// Token: 0x06023DE6 RID: 146918 RVA: 0x004EE4AA File Offset: 0x004EC6AA
		public IEntityStateTriggerT()
		{
			this.GroupCondition = null;
			this.SuccessActions = null;
			this.FailActions = null;
			this.Condition = null;
			this.NullMask = 0;
		}
	}
}
