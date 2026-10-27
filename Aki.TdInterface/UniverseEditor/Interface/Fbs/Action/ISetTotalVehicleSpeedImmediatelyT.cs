using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200709E RID: 28830
	public class ISetTotalVehicleSpeedImmediatelyT
	{
		// Token: 0x1700D632 RID: 54834
		// (get) Token: 0x060330CF RID: 209103 RVA: 0x006E2B9F File Offset: 0x006E0D9F
		// (set) Token: 0x060330D0 RID: 209104 RVA: 0x006E2BA7 File Offset: 0x006E0DA7
		public ESetVehicleSpeedImmediatelyType Type { get; set; }

		// Token: 0x1700D633 RID: 54835
		// (get) Token: 0x060330D1 RID: 209105 RVA: 0x006E2BB0 File Offset: 0x006E0DB0
		// (set) Token: 0x060330D2 RID: 209106 RVA: 0x006E2BB8 File Offset: 0x006E0DB8
		public TProcessedValueUnion Speed { get; set; }

		// Token: 0x060330D3 RID: 209107 RVA: 0x006E2BC1 File Offset: 0x006E0DC1
		public ISetTotalVehicleSpeedImmediatelyT()
		{
			this.Type = ESetVehicleSpeedImmediatelyType.TotalSpeed;
			this.Speed = null;
		}
	}
}
