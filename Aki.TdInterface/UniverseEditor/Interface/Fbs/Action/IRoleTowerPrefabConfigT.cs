using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EFE RID: 28414
	public class IRoleTowerPrefabConfigT
	{
		// Token: 0x1700D354 RID: 54100
		// (get) Token: 0x0603234E RID: 205646 RVA: 0x006C8A72 File Offset: 0x006C6C72
		// (set) Token: 0x0603234F RID: 205647 RVA: 0x006C8A7A File Offset: 0x006C6C7A
		public ECreatePrefabType Type { get; set; }

		// Token: 0x06032350 RID: 205648 RVA: 0x006C8A83 File Offset: 0x006C6C83
		public IRoleTowerPrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
		}
	}
}
