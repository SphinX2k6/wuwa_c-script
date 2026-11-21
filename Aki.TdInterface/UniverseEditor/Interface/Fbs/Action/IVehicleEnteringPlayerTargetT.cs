using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CFF RID: 31999
	public class IVehicleEnteringPlayerTargetT
	{
		// Token: 0x1700EF86 RID: 61318
		// (get) Token: 0x06039BE9 RID: 236521 RVA: 0x007CA172 File Offset: 0x007C8372
		// (set) Token: 0x06039BEA RID: 236522 RVA: 0x007CA17A File Offset: 0x007C837A
		public EVehicleEnteringTarget Type { get; set; }

		// Token: 0x1700EF87 RID: 61319
		// (get) Token: 0x06039BEB RID: 236523 RVA: 0x007CA183 File Offset: 0x007C8383
		// (set) Token: 0x06039BEC RID: 236524 RVA: 0x007CA18B File Offset: 0x007C838B
		public int TargetVehicle { get; set; }

		// Token: 0x1700EF88 RID: 61320
		// (get) Token: 0x06039BED RID: 236525 RVA: 0x007CA194 File Offset: 0x007C8394
		// (set) Token: 0x06039BEE RID: 236526 RVA: 0x007CA19C File Offset: 0x007C839C
		public byte NullMask { get; set; }

		// Token: 0x06039BEF RID: 236527 RVA: 0x007CA1A5 File Offset: 0x007C83A5
		public IVehicleEnteringPlayerTargetT()
		{
			this.Type = EVehicleEnteringTarget.Player;
			this.TargetVehicle = 0;
			this.NullMask = 0;
		}
	}
}
