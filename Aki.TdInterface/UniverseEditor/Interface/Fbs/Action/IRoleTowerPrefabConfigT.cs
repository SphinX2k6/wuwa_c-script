using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007682 RID: 30338
	public class IRoleTowerPrefabConfigT
	{
		// Token: 0x1700DEAB RID: 57003
		// (get) Token: 0x0603538E RID: 217998 RVA: 0x007247A6 File Offset: 0x007229A6
		// (set) Token: 0x0603538F RID: 217999 RVA: 0x007247AE File Offset: 0x007229AE
		public ECreatePrefabType Type { get; set; }

		// Token: 0x06035390 RID: 218000 RVA: 0x007247B7 File Offset: 0x007229B7
		public IRoleTowerPrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
		}
	}
}
