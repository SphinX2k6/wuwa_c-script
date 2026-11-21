using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005056 RID: 20566
	public class ICheckVehicleTriggerAngleConditionT
	{
		// Token: 0x17009335 RID: 37685
		// (get) Token: 0x06020271 RID: 131697 RVA: 0x0047595A File Offset: 0x00473B5A
		// (set) Token: 0x06020272 RID: 131698 RVA: 0x00475962 File Offset: 0x00473B62
		public EVehicleConditionType Type { get; set; }

		// Token: 0x17009336 RID: 37686
		// (get) Token: 0x06020273 RID: 131699 RVA: 0x0047596B File Offset: 0x00473B6B
		// (set) Token: 0x06020274 RID: 131700 RVA: 0x00475973 File Offset: 0x00473B73
		public float HorizontalAngle { get; set; }

		// Token: 0x17009337 RID: 37687
		// (get) Token: 0x06020275 RID: 131701 RVA: 0x0047597C File Offset: 0x00473B7C
		// (set) Token: 0x06020276 RID: 131702 RVA: 0x00475984 File Offset: 0x00473B84
		public float VerticalAngle { get; set; }

		// Token: 0x06020277 RID: 131703 RVA: 0x0047598D File Offset: 0x00473B8D
		public ICheckVehicleTriggerAngleConditionT()
		{
			this.Type = EVehicleConditionType.UsingVehicle;
			this.HorizontalAngle = 0f;
			this.VerticalAngle = 0f;
		}
	}
}
