using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F69 RID: 16233
	public class IOutOfRangeTrackEntityT
	{
		// Token: 0x170070E1 RID: 28897
		// (get) Token: 0x0601717E RID: 94590 RVA: 0x00354035 File Offset: 0x00352235
		// (set) Token: 0x0601717F RID: 94591 RVA: 0x0035403D File Offset: 0x0035223D
		public int TrackEntityId { get; set; }

		// Token: 0x170070E2 RID: 28898
		// (get) Token: 0x06017180 RID: 94592 RVA: 0x00354046 File Offset: 0x00352246
		// (set) Token: 0x06017181 RID: 94593 RVA: 0x0035404E File Offset: 0x0035224E
		public IVectorInfoT Center { get; set; }

		// Token: 0x170070E3 RID: 28899
		// (get) Token: 0x06017182 RID: 94594 RVA: 0x00354057 File Offset: 0x00352257
		// (set) Token: 0x06017183 RID: 94595 RVA: 0x0035405F File Offset: 0x0035225F
		public int Radius { get; set; }

		// Token: 0x170070E4 RID: 28900
		// (get) Token: 0x06017184 RID: 94596 RVA: 0x00354068 File Offset: 0x00352268
		// (set) Token: 0x06017185 RID: 94597 RVA: 0x00354070 File Offset: 0x00352270
		public bool OverrideChildNodeTrackTarget { get; set; }

		// Token: 0x170070E5 RID: 28901
		// (get) Token: 0x06017186 RID: 94598 RVA: 0x00354079 File Offset: 0x00352279
		// (set) Token: 0x06017187 RID: 94599 RVA: 0x00354081 File Offset: 0x00352281
		public byte NullMask { get; set; }

		// Token: 0x06017188 RID: 94600 RVA: 0x0035408A File Offset: 0x0035228A
		public IOutOfRangeTrackEntityT()
		{
			this.TrackEntityId = 0;
			this.Center = null;
			this.Radius = 0;
			this.OverrideChildNodeTrackTarget = false;
			this.NullMask = 0;
		}
	}
}
