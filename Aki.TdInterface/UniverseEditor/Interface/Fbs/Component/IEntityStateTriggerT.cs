using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051BD RID: 20925
	public class IEntityStateTriggerT
	{
		// Token: 0x17009910 RID: 39184
		// (get) Token: 0x06021E84 RID: 138884 RVA: 0x004B43ED File Offset: 0x004B25ED
		// (set) Token: 0x06021E85 RID: 138885 RVA: 0x004B43F5 File Offset: 0x004B25F5
		public IEntityGroupConditionT GroupCondition { get; set; }

		// Token: 0x17009911 RID: 39185
		// (get) Token: 0x06021E86 RID: 138886 RVA: 0x004B43FE File Offset: 0x004B25FE
		// (set) Token: 0x06021E87 RID: 138887 RVA: 0x004B4406 File Offset: 0x004B2606
		public List<IActionInfoT> SuccessActions { get; set; }

		// Token: 0x17009912 RID: 39186
		// (get) Token: 0x06021E88 RID: 138888 RVA: 0x004B440F File Offset: 0x004B260F
		// (set) Token: 0x06021E89 RID: 138889 RVA: 0x004B4417 File Offset: 0x004B2617
		public List<IActionInfoT> FailActions { get; set; }

		// Token: 0x17009913 RID: 39187
		// (get) Token: 0x06021E8A RID: 138890 RVA: 0x004B4420 File Offset: 0x004B2620
		// (set) Token: 0x06021E8B RID: 138891 RVA: 0x004B4428 File Offset: 0x004B2628
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009914 RID: 39188
		// (get) Token: 0x06021E8C RID: 138892 RVA: 0x004B4431 File Offset: 0x004B2631
		// (set) Token: 0x06021E8D RID: 138893 RVA: 0x004B4439 File Offset: 0x004B2639
		public byte NullMask { get; set; }

		// Token: 0x06021E8E RID: 138894 RVA: 0x004B4442 File Offset: 0x004B2642
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
