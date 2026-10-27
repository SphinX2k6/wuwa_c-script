using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544A RID: 21578
	public class IInteractEntityPartModelBindT
	{
		// Token: 0x17009EE0 RID: 40672
		// (get) Token: 0x060237D3 RID: 145363 RVA: 0x004E9323 File Offset: 0x004E7523
		// (set) Token: 0x060237D4 RID: 145364 RVA: 0x004E932B File Offset: 0x004E752B
		public EInteractEntityPartBindType Type { get; set; }

		// Token: 0x17009EE1 RID: 40673
		// (get) Token: 0x060237D5 RID: 145365 RVA: 0x004E9334 File Offset: 0x004E7534
		// (set) Token: 0x060237D6 RID: 145366 RVA: 0x004E933C File Offset: 0x004E753C
		public List<IInteractEntityPartModelOptionPointT> OptionPoints { get; set; }

		// Token: 0x060237D7 RID: 145367 RVA: 0x004E9345 File Offset: 0x004E7545
		public IInteractEntityPartModelBindT()
		{
			this.Type = EInteractEntityPartBindType.Prefab;
			this.OptionPoints = null;
		}
	}
}
