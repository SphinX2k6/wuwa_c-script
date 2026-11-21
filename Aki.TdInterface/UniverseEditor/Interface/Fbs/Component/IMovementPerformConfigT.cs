using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B77 RID: 23415
	public class IMovementPerformConfigT
	{
		// Token: 0x1700AB1E RID: 43806
		// (get) Token: 0x06026930 RID: 158000 RVA: 0x00548548 File Offset: 0x00546748
		// (set) Token: 0x06026931 RID: 158001 RVA: 0x00548550 File Offset: 0x00546750
		public List<IVehicleMontagePlayConfigT> VehicleMontagePlayConfigs { get; set; }

		// Token: 0x1700AB1F RID: 43807
		// (get) Token: 0x06026932 RID: 158002 RVA: 0x00548559 File Offset: 0x00546759
		// (set) Token: 0x06026933 RID: 158003 RVA: 0x00548561 File Offset: 0x00546761
		public List<ISpeedEffectConfigT> PlayerSpeedEffectConfigs { get; set; }

		// Token: 0x1700AB20 RID: 43808
		// (get) Token: 0x06026934 RID: 158004 RVA: 0x0054856A File Offset: 0x0054676A
		// (set) Token: 0x06026935 RID: 158005 RVA: 0x00548572 File Offset: 0x00546772
		public byte NullMask { get; set; }

		// Token: 0x06026936 RID: 158006 RVA: 0x0054857B File Offset: 0x0054677B
		public IMovementPerformConfigT()
		{
			this.VehicleMontagePlayConfigs = null;
			this.PlayerSpeedEffectConfigs = null;
			this.NullMask = 0;
		}
	}
}
