using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005444 RID: 21572
	public class IInteractEntityPartBindBaseT
	{
		// Token: 0x17009EDA RID: 40666
		// (get) Token: 0x060237AB RID: 145323 RVA: 0x004E8E76 File Offset: 0x004E7076
		// (set) Token: 0x060237AC RID: 145324 RVA: 0x004E8E7E File Offset: 0x004E707E
		public EInteractEntityPartBindType Type { get; set; }

		// Token: 0x060237AD RID: 145325 RVA: 0x004E8E87 File Offset: 0x004E7087
		public IInteractEntityPartBindBaseT()
		{
			this.Type = EInteractEntityPartBindType.Prefab;
		}
	}
}
