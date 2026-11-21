using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B53 RID: 23379
	public class IMotorHookAccelerationT
	{
		// Token: 0x1700AAA6 RID: 43686
		// (get) Token: 0x06026780 RID: 157568 RVA: 0x00544947 File Offset: 0x00542B47
		// (set) Token: 0x06026781 RID: 157569 RVA: 0x0054494F File Offset: 0x00542B4F
		public int MaxSpeed { get; set; }

		// Token: 0x1700AAA7 RID: 43687
		// (get) Token: 0x06026782 RID: 157570 RVA: 0x00544958 File Offset: 0x00542B58
		// (set) Token: 0x06026783 RID: 157571 RVA: 0x00544960 File Offset: 0x00542B60
		public string SpeedSampleCurve { get; set; }

		// Token: 0x06026784 RID: 157572 RVA: 0x00544969 File Offset: 0x00542B69
		public IMotorHookAccelerationT()
		{
			this.MaxSpeed = 0;
			this.SpeedSampleCurve = null;
		}
	}
}
