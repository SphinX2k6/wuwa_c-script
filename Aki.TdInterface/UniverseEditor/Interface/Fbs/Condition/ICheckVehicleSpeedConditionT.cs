using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005053 RID: 20563
	public class ICheckVehicleSpeedConditionT
	{
		// Token: 0x1700932E RID: 37678
		// (get) Token: 0x06020257 RID: 131671 RVA: 0x004756AE File Offset: 0x004738AE
		// (set) Token: 0x06020258 RID: 131672 RVA: 0x004756B6 File Offset: 0x004738B6
		public EVehicleConditionType Type { get; set; }

		// Token: 0x1700932F RID: 37679
		// (get) Token: 0x06020259 RID: 131673 RVA: 0x004756BF File Offset: 0x004738BF
		// (set) Token: 0x0602025A RID: 131674 RVA: 0x004756C7 File Offset: 0x004738C7
		public ECompare CompareType { get; set; }

		// Token: 0x17009330 RID: 37680
		// (get) Token: 0x0602025B RID: 131675 RVA: 0x004756D0 File Offset: 0x004738D0
		// (set) Token: 0x0602025C RID: 131676 RVA: 0x004756D8 File Offset: 0x004738D8
		public float Speed { get; set; }

		// Token: 0x0602025D RID: 131677 RVA: 0x004756E1 File Offset: 0x004738E1
		public ICheckVehicleSpeedConditionT()
		{
			this.Type = EVehicleConditionType.UsingVehicle;
			this.CompareType = ECompare.Eq;
			this.Speed = 0f;
		}
	}
}
