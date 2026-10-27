using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005064 RID: 20580
	public class ICyberpunkShareEmptyVehiclePerformT
	{
		// Token: 0x17009550 RID: 38224
		// (get) Token: 0x06020FC3 RID: 135107 RVA: 0x004956BF File Offset: 0x004938BF
		// (set) Token: 0x06020FC4 RID: 135108 RVA: 0x004956C7 File Offset: 0x004938C7
		public EVehicleType Type { get; set; }

		// Token: 0x17009551 RID: 38225
		// (get) Token: 0x06020FC5 RID: 135109 RVA: 0x004956D0 File Offset: 0x004938D0
		// (set) Token: 0x06020FC6 RID: 135110 RVA: 0x004956D8 File Offset: 0x004938D8
		public string Montage { get; set; }

		// Token: 0x06020FC7 RID: 135111 RVA: 0x004956E1 File Offset: 0x004938E1
		public ICyberpunkShareEmptyVehiclePerformT()
		{
			this.Type = EVehicleType.Gongduola;
			this.Montage = null;
		}
	}
}
