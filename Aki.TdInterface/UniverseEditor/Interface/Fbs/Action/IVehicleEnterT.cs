using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CF9 RID: 31993
	public class IVehicleEnterT
	{
		// Token: 0x1700EF74 RID: 61300
		// (get) Token: 0x06039BAD RID: 236461 RVA: 0x007C9B21 File Offset: 0x007C7D21
		// (set) Token: 0x06039BAE RID: 236462 RVA: 0x007C9B29 File Offset: 0x007C7D29
		public TVehicleEnteringTargetUnion EnteringTarget { get; set; }

		// Token: 0x1700EF75 RID: 61301
		// (get) Token: 0x06039BAF RID: 236463 RVA: 0x007C9B32 File Offset: 0x007C7D32
		// (set) Token: 0x06039BB0 RID: 236464 RVA: 0x007C9B3A File Offset: 0x007C7D3A
		public TTargetVehicleUnion VehicleTarget { get; set; }

		// Token: 0x1700EF76 RID: 61302
		// (get) Token: 0x06039BB1 RID: 236465 RVA: 0x007C9B43 File Offset: 0x007C7D43
		// (set) Token: 0x06039BB2 RID: 236466 RVA: 0x007C9B4B File Offset: 0x007C7D4B
		public EVehicleSeat Seat { get; set; }

		// Token: 0x1700EF77 RID: 61303
		// (get) Token: 0x06039BB3 RID: 236467 RVA: 0x007C9B54 File Offset: 0x007C7D54
		// (set) Token: 0x06039BB4 RID: 236468 RVA: 0x007C9B5C File Offset: 0x007C7D5C
		public bool ForceExitLastVehicle { get; set; }

		// Token: 0x1700EF78 RID: 61304
		// (get) Token: 0x06039BB5 RID: 236469 RVA: 0x007C9B65 File Offset: 0x007C7D65
		// (set) Token: 0x06039BB6 RID: 236470 RVA: 0x007C9B6D File Offset: 0x007C7D6D
		public byte NullMask { get; set; }

		// Token: 0x06039BB7 RID: 236471 RVA: 0x007C9B76 File Offset: 0x007C7D76
		public IVehicleEnterT()
		{
			this.EnteringTarget = null;
			this.VehicleTarget = null;
			this.Seat = EVehicleSeat.Seat0;
			this.ForceExitLastVehicle = false;
			this.NullMask = 0;
		}
	}
}
