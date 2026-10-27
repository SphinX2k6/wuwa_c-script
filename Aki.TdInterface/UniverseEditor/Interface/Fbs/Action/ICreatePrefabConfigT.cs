using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064E7 RID: 25831
	public class ICreatePrefabConfigT
	{
		// Token: 0x1700C02D RID: 49197
		// (get) Token: 0x0602CCFD RID: 183549 RVA: 0x0062869A File Offset: 0x0062689A
		// (set) Token: 0x0602CCFE RID: 183550 RVA: 0x006286A2 File Offset: 0x006268A2
		public ECreatePrefabType Type { get; set; }

		// Token: 0x0602CCFF RID: 183551 RVA: 0x006286AB File Offset: 0x006268AB
		public ICreatePrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
		}
	}
}
