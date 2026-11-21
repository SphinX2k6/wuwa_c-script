using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200560B RID: 22027
	public class IDollGrabShowcaseComponentT
	{
		// Token: 0x17009DF6 RID: 40438
		// (get) Token: 0x060231F9 RID: 143865 RVA: 0x004D5BE0 File Offset: 0x004D3DE0
		// (set) Token: 0x060231FA RID: 143866 RVA: 0x004D5BE8 File Offset: 0x004D3DE8
		public bool Disabled { get; set; }

		// Token: 0x17009DF7 RID: 40439
		// (get) Token: 0x060231FB RID: 143867 RVA: 0x004D5BF1 File Offset: 0x004D3DF1
		// (set) Token: 0x060231FC RID: 143868 RVA: 0x004D5BF9 File Offset: 0x004D3DF9
		public EDollGrabShowcaseBelongType BelongType { get; set; }

		// Token: 0x17009DF8 RID: 40440
		// (get) Token: 0x060231FD RID: 143869 RVA: 0x004D5C02 File Offset: 0x004D3E02
		// (set) Token: 0x060231FE RID: 143870 RVA: 0x004D5C0A File Offset: 0x004D3E0A
		public int BindInfiniteModeDollGrabEntityId { get; set; }

		// Token: 0x17009DF9 RID: 40441
		// (get) Token: 0x060231FF RID: 143871 RVA: 0x004D5C13 File Offset: 0x004D3E13
		// (set) Token: 0x06023200 RID: 143872 RVA: 0x004D5C1B File Offset: 0x004D3E1B
		public IDollGrabShowcaseDollCameraConfigT CameraConfig { get; set; }

		// Token: 0x17009DFA RID: 40442
		// (get) Token: 0x06023201 RID: 143873 RVA: 0x004D5C24 File Offset: 0x004D3E24
		// (set) Token: 0x06023202 RID: 143874 RVA: 0x004D5C2C File Offset: 0x004D3E2C
		public List<IShowcaseDeliveryRewardT> DeliveryRewards { get; set; }

		// Token: 0x17009DFB RID: 40443
		// (get) Token: 0x06023203 RID: 143875 RVA: 0x004D5C35 File Offset: 0x004D3E35
		// (set) Token: 0x06023204 RID: 143876 RVA: 0x004D5C3D File Offset: 0x004D3E3D
		public byte NullMask { get; set; }

		// Token: 0x06023205 RID: 143877 RVA: 0x004D5C46 File Offset: 0x004D3E46
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
