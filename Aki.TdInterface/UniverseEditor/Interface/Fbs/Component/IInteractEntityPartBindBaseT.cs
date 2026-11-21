using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CA RID: 22986
	public class IInteractEntityPartBindBaseT
	{
		// Token: 0x1700A714 RID: 42772
		// (get) Token: 0x06025863 RID: 153699 RVA: 0x00525EEA File Offset: 0x005240EA
		// (set) Token: 0x06025864 RID: 153700 RVA: 0x00525EF2 File Offset: 0x005240F2
		public EInteractEntityPartBindType Type { get; set; }

		// Token: 0x06025865 RID: 153701 RVA: 0x00525EFB File Offset: 0x005240FB
		public IInteractEntityPartBindBaseT()
		{
			this.Type = EInteractEntityPartBindType.Prefab;
		}
	}
}
