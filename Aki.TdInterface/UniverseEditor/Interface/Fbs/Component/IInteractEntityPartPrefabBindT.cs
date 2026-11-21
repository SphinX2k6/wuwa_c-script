using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D6 RID: 22998
	public class IInteractEntityPartPrefabBindT
	{
		// Token: 0x1700A724 RID: 42788
		// (get) Token: 0x060258C1 RID: 153793 RVA: 0x005269A7 File Offset: 0x00524BA7
		// (set) Token: 0x060258C2 RID: 153794 RVA: 0x005269AF File Offset: 0x00524BAF
		public EInteractEntityPartBindType Type { get; set; }

		// Token: 0x1700A725 RID: 42789
		// (get) Token: 0x060258C3 RID: 153795 RVA: 0x005269B8 File Offset: 0x00524BB8
		// (set) Token: 0x060258C4 RID: 153796 RVA: 0x005269C0 File Offset: 0x00524BC0
		public List<IInteractEntityPartPrefabOptionPointT> OptionPoints { get; set; }

		// Token: 0x060258C5 RID: 153797 RVA: 0x005269C9 File Offset: 0x00524BC9
		public IInteractEntityPartPrefabBindT()
		{
			this.Type = EInteractEntityPartBindType.Prefab;
			this.OptionPoints = null;
		}
	}
}
