using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E9 RID: 30697
	public class ISetMotorSpeedT
	{
		// Token: 0x1700E0FA RID: 57594
		// (get) Token: 0x06035ECB RID: 220875 RVA: 0x00739553 File Offset: 0x00737753
		// (set) Token: 0x06035ECC RID: 220876 RVA: 0x0073955B File Offset: 0x0073775B
		public IMotorConstraintConfigT MotorConstraint { get; set; }

		// Token: 0x1700E0FB RID: 57595
		// (get) Token: 0x06035ECD RID: 220877 RVA: 0x00739564 File Offset: 0x00737764
		// (set) Token: 0x06035ECE RID: 220878 RVA: 0x0073956C File Offset: 0x0073776C
		public ISetMotorSpeedTargetSpeedT SpeedConfig { get; set; }

		// Token: 0x06035ECF RID: 220879 RVA: 0x00739575 File Offset: 0x00737775
		public ISetMotorSpeedT()
		{
			this.MotorConstraint = null;
			this.SpeedConfig = null;
		}
	}
}
