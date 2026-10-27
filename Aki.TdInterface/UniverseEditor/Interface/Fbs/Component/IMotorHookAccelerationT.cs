using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B5 RID: 21941
	public class IMotorHookAccelerationT
	{
		// Token: 0x1700A21E RID: 41502
		// (get) Token: 0x06024573 RID: 148851 RVA: 0x005043CF File Offset: 0x005025CF
		// (set) Token: 0x06024574 RID: 148852 RVA: 0x005043D7 File Offset: 0x005025D7
		public int MaxSpeed { get; set; }

		// Token: 0x1700A21F RID: 41503
		// (get) Token: 0x06024575 RID: 148853 RVA: 0x005043E0 File Offset: 0x005025E0
		// (set) Token: 0x06024576 RID: 148854 RVA: 0x005043E8 File Offset: 0x005025E8
		public string SpeedSampleCurve { get; set; }

		// Token: 0x06024577 RID: 148855 RVA: 0x005043F1 File Offset: 0x005025F1
		public IMotorHookAccelerationT()
		{
			this.MaxSpeed = 0;
			this.SpeedSampleCurve = null;
		}
	}
}
