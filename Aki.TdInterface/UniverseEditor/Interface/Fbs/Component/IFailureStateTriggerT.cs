using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005791 RID: 22417
	public class IFailureStateTriggerT
	{
		// Token: 0x1700A208 RID: 41480
		// (get) Token: 0x060242B3 RID: 148147 RVA: 0x004F915F File Offset: 0x004F735F
		// (set) Token: 0x060242B4 RID: 148148 RVA: 0x004F9167 File Offset: 0x004F7367
		public List<TEntityGroupFailureConditionUnion> FailureConditions { get; set; }

		// Token: 0x1700A209 RID: 41481
		// (get) Token: 0x060242B5 RID: 148149 RVA: 0x004F9170 File Offset: 0x004F7370
		// (set) Token: 0x060242B6 RID: 148150 RVA: 0x004F9178 File Offset: 0x004F7378
		public IOperationsAfterEntityGroupFailureT FailureOperations { get; set; }

		// Token: 0x060242B7 RID: 148151 RVA: 0x004F9181 File Offset: 0x004F7381
		public IFailureStateTriggerT()
		{
			this.FailureConditions = null;
			this.FailureOperations = null;
		}
	}
}
