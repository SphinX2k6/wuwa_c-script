using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200477C RID: 18300
	public class IBlueprintConfigT
	{
		// Token: 0x17008337 RID: 33591
		// (get) Token: 0x0601C2B9 RID: 115385 RVA: 0x003FD69D File Offset: 0x003FB89D
		// (set) Token: 0x0601C2BA RID: 115386 RVA: 0x003FD6A5 File Offset: 0x003FB8A5
		public List<Record_String_IBlueprintItemT> BlueprintConfig { get; set; }

		// Token: 0x0601C2BB RID: 115387 RVA: 0x003FD6AE File Offset: 0x003FB8AE
		public IBlueprintConfigT()
		{
			this.BlueprintConfig = null;
		}
	}
}
