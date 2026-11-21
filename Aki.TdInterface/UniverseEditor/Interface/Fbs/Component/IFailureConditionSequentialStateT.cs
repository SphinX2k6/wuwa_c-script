using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200578E RID: 22414
	public class IFailureConditionSequentialStateT
	{
		// Token: 0x1700A202 RID: 41474
		// (get) Token: 0x0602428D RID: 148109 RVA: 0x004F8B37 File Offset: 0x004F6D37
		// (set) Token: 0x0602428E RID: 148110 RVA: 0x004F8B3F File Offset: 0x004F6D3F
		public ETargetGearGroupFailureCondition Type { get; set; }

		// Token: 0x1700A203 RID: 41475
		// (get) Token: 0x0602428F RID: 148111 RVA: 0x004F8B48 File Offset: 0x004F6D48
		// (set) Token: 0x06024290 RID: 148112 RVA: 0x004F8B50 File Offset: 0x004F6D50
		public List<int> Order { get; set; }

		// Token: 0x06024291 RID: 148113 RVA: 0x004F8B59 File Offset: 0x004F6D59
		public IFailureConditionSequentialStateT()
		{
			this.Type = ETargetGearGroupFailureCondition.ArbitraryState;
			this.Order = null;
		}
	}
}
