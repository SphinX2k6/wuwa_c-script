using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200752A RID: 29994
	public class IVehiclePlayerMotorT
	{
		// Token: 0x1700E39E RID: 58270
		// (get) Token: 0x0603691D RID: 223517 RVA: 0x0076A156 File Offset: 0x00768356
		// (set) Token: 0x0603691E RID: 223518 RVA: 0x0076A15E File Offset: 0x0076835E
		public ETargetVehicle Type { get; set; }

		// Token: 0x1700E39F RID: 58271
		// (get) Token: 0x0603691F RID: 223519 RVA: 0x0076A167 File Offset: 0x00768367
		// (set) Token: 0x06036920 RID: 223520 RVA: 0x0076A16F File Offset: 0x0076836F
		public int SummonPositionEntityId { get; set; }

		// Token: 0x1700E3A0 RID: 58272
		// (get) Token: 0x06036921 RID: 223521 RVA: 0x0076A178 File Offset: 0x00768378
		// (set) Token: 0x06036922 RID: 223522 RVA: 0x0076A180 File Offset: 0x00768380
		public byte NullMask { get; set; }

		// Token: 0x06036923 RID: 223523 RVA: 0x0076A189 File Offset: 0x00768389
		public IVehiclePlayerMotorT()
		{
			this.Type = ETargetVehicle.Current;
			this.SummonPositionEntityId = 0;
			this.NullMask = 0;
		}
	}
}
