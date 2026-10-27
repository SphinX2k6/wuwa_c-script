using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200550A RID: 21770
	public class ILocationSafetyComponentT
	{
		// Token: 0x1700A0BC RID: 41148
		// (get) Token: 0x06023F51 RID: 147281 RVA: 0x004F87C7 File Offset: 0x004F69C7
		// (set) Token: 0x06023F52 RID: 147282 RVA: 0x004F87CF File Offset: 0x004F69CF
		public bool Disabled { get; set; }

		// Token: 0x1700A0BD RID: 41149
		// (get) Token: 0x06023F53 RID: 147283 RVA: 0x004F87D8 File Offset: 0x004F69D8
		// (set) Token: 0x06023F54 RID: 147284 RVA: 0x004F87E0 File Offset: 0x004F69E0
		public EDetectionFrequency DetectionFrequency { get; set; }

		// Token: 0x1700A0BE RID: 41150
		// (get) Token: 0x06023F55 RID: 147285 RVA: 0x004F87E9 File Offset: 0x004F69E9
		// (set) Token: 0x06023F56 RID: 147286 RVA: 0x004F87F1 File Offset: 0x004F69F1
		public IVectorInfoT SafeLocation { get; set; }

		// Token: 0x1700A0BF RID: 41151
		// (get) Token: 0x06023F57 RID: 147287 RVA: 0x004F87FA File Offset: 0x004F69FA
		// (set) Token: 0x06023F58 RID: 147288 RVA: 0x004F8802 File Offset: 0x004F6A02
		public byte NullMask { get; set; }

		// Token: 0x06023F59 RID: 147289 RVA: 0x004F880B File Offset: 0x004F6A0B
		public ILocationSafetyComponentT()
		{
			this.Disabled = false;
			this.DetectionFrequency = EDetectionFrequency.Low;
			this.SafeLocation = null;
			this.NullMask = 0;
		}
	}
}
