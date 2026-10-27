using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007509 RID: 29961
	public class IVehicleEnteringPlayerTargetT
	{
		// Token: 0x1700E35C RID: 58204
		// (get) Token: 0x060367D4 RID: 223188 RVA: 0x00766F22 File Offset: 0x00765122
		// (set) Token: 0x060367D5 RID: 223189 RVA: 0x00766F2A File Offset: 0x0076512A
		public EVehicleEnteringTarget Type { get; set; }

		// Token: 0x1700E35D RID: 58205
		// (get) Token: 0x060367D6 RID: 223190 RVA: 0x00766F33 File Offset: 0x00765133
		// (set) Token: 0x060367D7 RID: 223191 RVA: 0x00766F3B File Offset: 0x0076513B
		public int TargetVehicle { get; set; }

		// Token: 0x1700E35E RID: 58206
		// (get) Token: 0x060367D8 RID: 223192 RVA: 0x00766F44 File Offset: 0x00765144
		// (set) Token: 0x060367D9 RID: 223193 RVA: 0x00766F4C File Offset: 0x0076514C
		public byte NullMask { get; set; }

		// Token: 0x060367DA RID: 223194 RVA: 0x00766F55 File Offset: 0x00765155
		public IVehicleEnteringPlayerTargetT()
		{
			this.Type = EVehicleEnteringTarget.Player;
			this.TargetVehicle = 0;
			this.NullMask = 0;
		}
	}
}
