using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006140 RID: 24896
	public class IVehicleTypedConfigT
	{
		// Token: 0x1700B974 RID: 47476
		// (get) Token: 0x0602A3FE RID: 173054 RVA: 0x005C3EC6 File Offset: 0x005C20C6
		// (set) Token: 0x0602A3FF RID: 173055 RVA: 0x005C3ECE File Offset: 0x005C20CE
		public EVehicleType Type { get; set; }

		// Token: 0x0602A400 RID: 173056 RVA: 0x005C3ED7 File Offset: 0x005C20D7
		public IVehicleTypedConfigT()
		{
			this.Type = EVehicleType.Gongduola;
		}
	}
}
