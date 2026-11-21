using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D2F RID: 32047
	public class IVehicleWaterfallClimbGravityConfigT
	{
		// Token: 0x1700EFE2 RID: 61410
		// (get) Token: 0x06039DB8 RID: 236984 RVA: 0x007CE4B0 File Offset: 0x007CC6B0
		// (set) Token: 0x06039DB9 RID: 236985 RVA: 0x007CE4B8 File Offset: 0x007CC6B8
		public int SafePositionEntityId { get; set; }

		// Token: 0x1700EFE3 RID: 61411
		// (get) Token: 0x06039DBA RID: 236986 RVA: 0x007CE4C1 File Offset: 0x007CC6C1
		// (set) Token: 0x06039DBB RID: 236987 RVA: 0x007CE4C9 File Offset: 0x007CC6C9
		public EWorldAxisType GravityDirection { get; set; }

		// Token: 0x06039DBC RID: 236988 RVA: 0x007CE4D2 File Offset: 0x007CC6D2
		public IVehicleWaterfallClimbGravityConfigT()
		{
			this.SafePositionEntityId = 0;
			this.GravityDirection = EWorldAxisType.PositiveX;
		}
	}
}
