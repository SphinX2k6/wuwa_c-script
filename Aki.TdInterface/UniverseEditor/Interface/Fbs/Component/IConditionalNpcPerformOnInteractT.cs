using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FE6 RID: 20454
	public class IConditionalNpcPerformOnInteractT
	{
		// Token: 0x17009430 RID: 37936
		// (get) Token: 0x06020AFD RID: 133885 RVA: 0x0048B82F File Offset: 0x00489A2F
		// (set) Token: 0x06020AFE RID: 133886 RVA: 0x0048B837 File Offset: 0x00489A37
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009431 RID: 37937
		// (get) Token: 0x06020AFF RID: 133887 RVA: 0x0048B840 File Offset: 0x00489A40
		// (set) Token: 0x06020B00 RID: 133888 RVA: 0x0048B848 File Offset: 0x00489A48
		public INpcPerformOnInteractT Perform { get; set; }

		// Token: 0x06020B01 RID: 133889 RVA: 0x0048B851 File Offset: 0x00489A51
		public IConditionalNpcPerformOnInteractT()
		{
			this.Condition = null;
			this.Perform = null;
		}
	}
}
