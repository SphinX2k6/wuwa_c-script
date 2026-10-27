using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A7 RID: 28839
	public class ISetVehicleSpeedImmediatelyTypeT
	{
		// Token: 0x1700D640 RID: 54848
		// (get) Token: 0x0603311D RID: 209181 RVA: 0x006E368A File Offset: 0x006E188A
		// (set) Token: 0x0603311E RID: 209182 RVA: 0x006E3692 File Offset: 0x006E1892
		public ESetVehicleSpeedImmediatelyType Type { get; set; }

		// Token: 0x0603311F RID: 209183 RVA: 0x006E369B File Offset: 0x006E189B
		public ISetVehicleSpeedImmediatelyTypeT()
		{
			this.Type = ESetVehicleSpeedImmediatelyType.TotalSpeed;
		}
	}
}
