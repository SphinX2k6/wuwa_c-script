using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A9A RID: 19098
	public class ICheckIsPlayerUsingVehicleT
	{
		// Token: 0x17008A5F RID: 35423
		// (get) Token: 0x0601DF58 RID: 122712 RVA: 0x00434DF9 File Offset: 0x00432FF9
		// (set) Token: 0x0601DF59 RID: 122713 RVA: 0x00434E01 File Offset: 0x00433001
		public EVehicleConditionType Type { get; set; }

		// Token: 0x17008A60 RID: 35424
		// (get) Token: 0x0601DF5A RID: 122714 RVA: 0x00434E0A File Offset: 0x0043300A
		// (set) Token: 0x0601DF5B RID: 122715 RVA: 0x00434E12 File Offset: 0x00433012
		public EVehicleType VehicleType { get; set; }

		// Token: 0x17008A61 RID: 35425
		// (get) Token: 0x0601DF5C RID: 122716 RVA: 0x00434E1B File Offset: 0x0043301B
		// (set) Token: 0x0601DF5D RID: 122717 RVA: 0x00434E23 File Offset: 0x00433023
		public bool CheckType { get; set; }

		// Token: 0x17008A62 RID: 35426
		// (get) Token: 0x0601DF5E RID: 122718 RVA: 0x00434E2C File Offset: 0x0043302C
		// (set) Token: 0x0601DF5F RID: 122719 RVA: 0x00434E34 File Offset: 0x00433034
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x17008A63 RID: 35427
		// (get) Token: 0x0601DF60 RID: 122720 RVA: 0x00434E3D File Offset: 0x0043303D
		// (set) Token: 0x0601DF61 RID: 122721 RVA: 0x00434E45 File Offset: 0x00433045
		public byte NullMask { get; set; }

		// Token: 0x0601DF62 RID: 122722 RVA: 0x00434E4E File Offset: 0x0043304E
		public ICheckIsPlayerUsingVehicleT()
		{
			this.Type = EVehicleConditionType.UsingVehicle;
			this.VehicleType = EVehicleType.Gongduola;
			this.CheckType = false;
			this.OnlinePlayerConditionTargetOption = null;
			this.NullMask = 0;
		}
	}
}
