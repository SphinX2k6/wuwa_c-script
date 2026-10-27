using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007020 RID: 28704
	public class ISetMotorSpeedT
	{
		// Token: 0x1700D526 RID: 54566
		// (get) Token: 0x06032C65 RID: 207973 RVA: 0x006D990F File Offset: 0x006D7B0F
		// (set) Token: 0x06032C66 RID: 207974 RVA: 0x006D9917 File Offset: 0x006D7B17
		public IMotorConstraintConfigT MotorConstraint { get; set; }

		// Token: 0x1700D527 RID: 54567
		// (get) Token: 0x06032C67 RID: 207975 RVA: 0x006D9920 File Offset: 0x006D7B20
		// (set) Token: 0x06032C68 RID: 207976 RVA: 0x006D9928 File Offset: 0x006D7B28
		public ISetMotorSpeedTargetSpeedT SpeedConfig { get; set; }

		// Token: 0x06032C69 RID: 207977 RVA: 0x006D9931 File Offset: 0x006D7B31
		public ISetMotorSpeedT()
		{
			this.MotorConstraint = null;
			this.SpeedConfig = null;
		}
	}
}
