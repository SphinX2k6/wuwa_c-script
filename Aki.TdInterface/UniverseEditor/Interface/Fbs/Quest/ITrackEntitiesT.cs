using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004656 RID: 18006
	public class ITrackEntitiesT
	{
		// Token: 0x17007E14 RID: 32276
		// (get) Token: 0x0601A638 RID: 108088 RVA: 0x003C1A1D File Offset: 0x003BFC1D
		// (set) Token: 0x0601A639 RID: 108089 RVA: 0x003C1A25 File Offset: 0x003BFC25
		public ETrackType Type { get; set; }

		// Token: 0x17007E15 RID: 32277
		// (get) Token: 0x0601A63A RID: 108090 RVA: 0x003C1A2E File Offset: 0x003BFC2E
		// (set) Token: 0x0601A63B RID: 108091 RVA: 0x003C1A36 File Offset: 0x003BFC36
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x17007E16 RID: 32278
		// (get) Token: 0x0601A63C RID: 108092 RVA: 0x003C1A3F File Offset: 0x003BFC3F
		// (set) Token: 0x0601A63D RID: 108093 RVA: 0x003C1A47 File Offset: 0x003BFC47
		public List<int> EntityIds { get; set; }

		// Token: 0x17007E17 RID: 32279
		// (get) Token: 0x0601A63E RID: 108094 RVA: 0x003C1A50 File Offset: 0x003BFC50
		// (set) Token: 0x0601A63F RID: 108095 RVA: 0x003C1A58 File Offset: 0x003BFC58
		public IOutOfRangeTrackTargetT OutOfRangeTrackTargetLocation { get; set; }

		// Token: 0x17007E18 RID: 32280
		// (get) Token: 0x0601A640 RID: 108096 RVA: 0x003C1A61 File Offset: 0x003BFC61
		// (set) Token: 0x0601A641 RID: 108097 RVA: 0x003C1A69 File Offset: 0x003BFC69
		public IOutOfRangeTrackEntityT OutOfRangeTrackTarget { get; set; }

		// Token: 0x0601A642 RID: 108098 RVA: 0x003C1A72 File Offset: 0x003BFC72
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
