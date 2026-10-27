using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A8 RID: 22952
	public class IStateElementalEnableConfigT
	{
		// Token: 0x1700AC42 RID: 44098
		// (get) Token: 0x06026E24 RID: 159268 RVA: 0x00559C67 File Offset: 0x00557E67
		// (set) Token: 0x06026E25 RID: 159269 RVA: 0x00559C6F File Offset: 0x00557E6F
		public string State { get; set; }

		// Token: 0x1700AC43 RID: 44099
		// (get) Token: 0x06026E26 RID: 159270 RVA: 0x00559C78 File Offset: 0x00557E78
		// (set) Token: 0x06026E27 RID: 159271 RVA: 0x00559C80 File Offset: 0x00557E80
		public bool ElementalEnable { get; set; }

		// Token: 0x06026E28 RID: 159272 RVA: 0x00559C89 File Offset: 0x00557E89
		public IStateElementalEnableConfigT()
		{
			this.State = null;
			this.ElementalEnable = false;
		}
	}
}
