using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050A6 RID: 20646
	public class IDollGrabShowcaseComponentT
	{
		// Token: 0x17009609 RID: 38409
		// (get) Token: 0x060212A5 RID: 135845 RVA: 0x0049BC54 File Offset: 0x00499E54
		// (set) Token: 0x060212A6 RID: 135846 RVA: 0x0049BC5C File Offset: 0x00499E5C
		public bool Disabled { get; set; }

		// Token: 0x1700960A RID: 38410
		// (get) Token: 0x060212A7 RID: 135847 RVA: 0x0049BC65 File Offset: 0x00499E65
		// (set) Token: 0x060212A8 RID: 135848 RVA: 0x0049BC6D File Offset: 0x00499E6D
		public EDollGrabShowcaseBelongType BelongType { get; set; }

		// Token: 0x1700960B RID: 38411
		// (get) Token: 0x060212A9 RID: 135849 RVA: 0x0049BC76 File Offset: 0x00499E76
		// (set) Token: 0x060212AA RID: 135850 RVA: 0x0049BC7E File Offset: 0x00499E7E
		public int BindInfiniteModeDollGrabEntityId { get; set; }

		// Token: 0x1700960C RID: 38412
		// (get) Token: 0x060212AB RID: 135851 RVA: 0x0049BC87 File Offset: 0x00499E87
		// (set) Token: 0x060212AC RID: 135852 RVA: 0x0049BC8F File Offset: 0x00499E8F
		public IDollGrabShowcaseDollCameraConfigT CameraConfig { get; set; }

		// Token: 0x1700960D RID: 38413
		// (get) Token: 0x060212AD RID: 135853 RVA: 0x0049BC98 File Offset: 0x00499E98
		// (set) Token: 0x060212AE RID: 135854 RVA: 0x0049BCA0 File Offset: 0x00499EA0
		public List<IShowcaseDeliveryRewardT> DeliveryRewards { get; set; }

		// Token: 0x1700960E RID: 38414
		// (get) Token: 0x060212AF RID: 135855 RVA: 0x0049BCA9 File Offset: 0x00499EA9
		// (set) Token: 0x060212B0 RID: 135856 RVA: 0x0049BCB1 File Offset: 0x00499EB1
		public byte NullMask { get; set; }

		// Token: 0x060212B1 RID: 135857 RVA: 0x0049BCBA File Offset: 0x00499EBA
		public IDollGrabShowcaseComponentT()
		{
			this.Disabled = false;
			this.BelongType = EDollGrabShowcaseBelongType.LandOfXuanfang;
			this.BindInfiniteModeDollGrabEntityId = 0;
			this.CameraConfig = null;
			this.DeliveryRewards = null;
			this.NullMask = 0;
		}
	}
}
