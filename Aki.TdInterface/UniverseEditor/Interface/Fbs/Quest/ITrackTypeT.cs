using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200467A RID: 18042
	public class ITrackTypeT
	{
		// Token: 0x17007E74 RID: 32372
		// (get) Token: 0x0601A7D0 RID: 108496 RVA: 0x003C55F7 File Offset: 0x003C37F7
		// (set) Token: 0x0601A7D1 RID: 108497 RVA: 0x003C55FF File Offset: 0x003C37FF
		public ETrackType Type { get; set; }

		// Token: 0x17007E75 RID: 32373
		// (get) Token: 0x0601A7D2 RID: 108498 RVA: 0x003C5608 File Offset: 0x003C3808
		// (set) Token: 0x0601A7D3 RID: 108499 RVA: 0x003C5610 File Offset: 0x003C3810
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x0601A7D4 RID: 108500 RVA: 0x003C5619 File Offset: 0x003C3819
		public ITrackTypeT()
		{
			this.Type = ETrackType.Locations;
			this.GravityDirection = null;
		}
	}
}
