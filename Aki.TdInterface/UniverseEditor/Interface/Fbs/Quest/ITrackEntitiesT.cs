using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FD RID: 16893
	public class ITrackEntitiesT
	{
		// Token: 0x170077E6 RID: 30694
		// (get) Token: 0x06018EDE RID: 102110 RVA: 0x003964BD File Offset: 0x003946BD
		// (set) Token: 0x06018EDF RID: 102111 RVA: 0x003964C5 File Offset: 0x003946C5
		public ETrackType Type { get; set; }

		// Token: 0x170077E7 RID: 30695
		// (get) Token: 0x06018EE0 RID: 102112 RVA: 0x003964CE File Offset: 0x003946CE
		// (set) Token: 0x06018EE1 RID: 102113 RVA: 0x003964D6 File Offset: 0x003946D6
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x170077E8 RID: 30696
		// (get) Token: 0x06018EE2 RID: 102114 RVA: 0x003964DF File Offset: 0x003946DF
		// (set) Token: 0x06018EE3 RID: 102115 RVA: 0x003964E7 File Offset: 0x003946E7
		public List<int> EntityIds { get; set; }

		// Token: 0x170077E9 RID: 30697
		// (get) Token: 0x06018EE4 RID: 102116 RVA: 0x003964F0 File Offset: 0x003946F0
		// (set) Token: 0x06018EE5 RID: 102117 RVA: 0x003964F8 File Offset: 0x003946F8
		public IOutOfRangeTrackTargetT OutOfRangeTrackTargetLocation { get; set; }

		// Token: 0x170077EA RID: 30698
		// (get) Token: 0x06018EE6 RID: 102118 RVA: 0x00396501 File Offset: 0x00394701
		// (set) Token: 0x06018EE7 RID: 102119 RVA: 0x00396509 File Offset: 0x00394709
		public IOutOfRangeTrackEntityT OutOfRangeTrackTarget { get; set; }

		// Token: 0x06018EE8 RID: 102120 RVA: 0x00396512 File Offset: 0x00394712
		public ITrackEntitiesT()
		{
			this.Type = ETrackType.Locations;
			this.GravityDirection = null;
			this.EntityIds = null;
			this.OutOfRangeTrackTargetLocation = null;
			this.OutOfRangeTrackTarget = null;
		}
	}
}
