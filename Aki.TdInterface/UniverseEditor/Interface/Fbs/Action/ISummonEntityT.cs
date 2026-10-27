using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007230 RID: 29232
	public class ISummonEntityT
	{
		// Token: 0x1700D8F4 RID: 55540
		// (get) Token: 0x06033DA2 RID: 212386 RVA: 0x006FA175 File Offset: 0x006F8375
		// (set) Token: 0x06033DA3 RID: 212387 RVA: 0x006FA17D File Offset: 0x006F837D
		public ISummonVehicleT SummonEntityConfig { get; set; }

		// Token: 0x06033DA4 RID: 212388 RVA: 0x006FA186 File Offset: 0x006F8386
		public ISummonEntityT()
		{
			this.SummonEntityConfig = null;
		}
	}
}
