using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005931 RID: 22833
	public class IHoldCfgT
	{
		// Token: 0x1700A595 RID: 42389
		// (get) Token: 0x06025214 RID: 152084 RVA: 0x00518501 File Offset: 0x00516701
		// (set) Token: 0x06025215 RID: 152085 RVA: 0x00518509 File Offset: 0x00516709
		public IHoldingTrackTargetT TrackTarget { get; set; }

		// Token: 0x06025216 RID: 152086 RVA: 0x00518512 File Offset: 0x00516712
		public IHoldCfgT()
		{
			this.TrackTarget = null;
		}
	}
}
