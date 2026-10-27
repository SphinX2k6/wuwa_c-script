using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B6F RID: 19311
	public class ICheckVehicleTriggerAngleConditionT
	{
		// Token: 0x17008C25 RID: 35877
		// (get) Token: 0x0601E6E3 RID: 124643 RVA: 0x0044310E File Offset: 0x0044130E
		// (set) Token: 0x0601E6E4 RID: 124644 RVA: 0x00443116 File Offset: 0x00441316
		public EVehicleConditionType Type { get; set; }

		// Token: 0x17008C26 RID: 35878
		// (get) Token: 0x0601E6E5 RID: 124645 RVA: 0x0044311F File Offset: 0x0044131F
		// (set) Token: 0x0601E6E6 RID: 124646 RVA: 0x00443127 File Offset: 0x00441327
		public float HorizontalAngle { get; set; }

		// Token: 0x17008C27 RID: 35879
		// (get) Token: 0x0601E6E7 RID: 124647 RVA: 0x00443130 File Offset: 0x00441330
		// (set) Token: 0x0601E6E8 RID: 124648 RVA: 0x00443138 File Offset: 0x00441338
		public float VerticalAngle { get; set; }

		// Token: 0x0601E6E9 RID: 124649 RVA: 0x00443141 File Offset: 0x00441341
		public ICheckVehicleTriggerAngleConditionT()
		{
			this.Type = EVehicleConditionType.UsingVehicle;
			this.HorizontalAngle = 0f;
			this.VerticalAngle = 0f;
		}
	}
}
