using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B6C RID: 19308
	public class ICheckVehicleSpeedConditionT
	{
		// Token: 0x17008C1E RID: 35870
		// (get) Token: 0x0601E6C9 RID: 124617 RVA: 0x00442E62 File Offset: 0x00441062
		// (set) Token: 0x0601E6CA RID: 124618 RVA: 0x00442E6A File Offset: 0x0044106A
		public EVehicleConditionType Type { get; set; }

		// Token: 0x17008C1F RID: 35871
		// (get) Token: 0x0601E6CB RID: 124619 RVA: 0x00442E73 File Offset: 0x00441073
		// (set) Token: 0x0601E6CC RID: 124620 RVA: 0x00442E7B File Offset: 0x0044107B
		public ECompare CompareType { get; set; }

		// Token: 0x17008C20 RID: 35872
		// (get) Token: 0x0601E6CD RID: 124621 RVA: 0x00442E84 File Offset: 0x00441084
		// (set) Token: 0x0601E6CE RID: 124622 RVA: 0x00442E8C File Offset: 0x0044108C
		public float Speed { get; set; }

		// Token: 0x0601E6CF RID: 124623 RVA: 0x00442E95 File Offset: 0x00441095
		public ICheckVehicleSpeedConditionT()
		{
			this.Type = EVehicleConditionType.UsingVehicle;
			this.CompareType = ECompare.Eq;
			this.Speed = 0f;
		}
	}
}
