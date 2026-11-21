using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BE4 RID: 19428
	public class IBlueprintConfigT
	{
		// Token: 0x17008978 RID: 35192
		// (get) Token: 0x0601DA8E RID: 121486 RVA: 0x00429939 File Offset: 0x00427B39
		// (set) Token: 0x0601DA8F RID: 121487 RVA: 0x00429941 File Offset: 0x00427B41
		public List<Record_String_IBlueprintItemT> BlueprintConfig { get; set; }

		// Token: 0x0601DA90 RID: 121488 RVA: 0x0042994A File Offset: 0x00427B4A
		public IBlueprintConfigT()
		{
			this.BlueprintConfig = null;
		}
	}
}
