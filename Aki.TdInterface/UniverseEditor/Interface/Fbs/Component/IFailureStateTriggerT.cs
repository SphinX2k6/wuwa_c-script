using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005229 RID: 21033
	public class IFailureStateTriggerT
	{
		// Token: 0x17009A0C RID: 39436
		// (get) Token: 0x0602231D RID: 140061 RVA: 0x004BE69B File Offset: 0x004BC89B
		// (set) Token: 0x0602231E RID: 140062 RVA: 0x004BE6A3 File Offset: 0x004BC8A3
		public List<TEntityGroupFailureConditionUnion> FailureConditions { get; set; }

		// Token: 0x17009A0D RID: 39437
		// (get) Token: 0x0602231F RID: 140063 RVA: 0x004BE6AC File Offset: 0x004BC8AC
		// (set) Token: 0x06022320 RID: 140064 RVA: 0x004BE6B4 File Offset: 0x004BC8B4
		public IOperationsAfterEntityGroupFailureT FailureOperations { get; set; }

		// Token: 0x06022321 RID: 140065 RVA: 0x004BE6BD File Offset: 0x004BC8BD
		public IFailureStateTriggerT()
		{
			this.FailureConditions = null;
			this.FailureOperations = null;
		}
	}
}
