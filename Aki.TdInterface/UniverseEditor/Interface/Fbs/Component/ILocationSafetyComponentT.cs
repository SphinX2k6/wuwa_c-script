using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A90 RID: 23184
	public class ILocationSafetyComponentT
	{
		// Token: 0x1700A8F6 RID: 43254
		// (get) Token: 0x0602600B RID: 155659 RVA: 0x005358EB File Offset: 0x00533AEB
		// (set) Token: 0x0602600C RID: 155660 RVA: 0x005358F3 File Offset: 0x00533AF3
		public bool Disabled { get; set; }

		// Token: 0x1700A8F7 RID: 43255
		// (get) Token: 0x0602600D RID: 155661 RVA: 0x005358FC File Offset: 0x00533AFC
		// (set) Token: 0x0602600E RID: 155662 RVA: 0x00535904 File Offset: 0x00533B04
		public EDetectionFrequency DetectionFrequency { get; set; }

		// Token: 0x1700A8F8 RID: 43256
		// (get) Token: 0x0602600F RID: 155663 RVA: 0x0053590D File Offset: 0x00533B0D
		// (set) Token: 0x06026010 RID: 155664 RVA: 0x00535915 File Offset: 0x00533B15
		public IVectorInfoT SafeLocation { get; set; }

		// Token: 0x1700A8F9 RID: 43257
		// (get) Token: 0x06026011 RID: 155665 RVA: 0x0053591E File Offset: 0x00533B1E
		// (set) Token: 0x06026012 RID: 155666 RVA: 0x00535926 File Offset: 0x00533B26
		public byte NullMask { get; set; }

		// Token: 0x06026013 RID: 155667 RVA: 0x0053592F File Offset: 0x00533B2F
		public ILocationSafetyComponentT()
		{
			this.Disabled = false;
			this.DetectionFrequency = EDetectionFrequency.Low;
			this.SafeLocation = null;
			this.NullMask = 0;
		}
	}
}
