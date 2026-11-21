using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004644 RID: 17988
	public class ITrackCaptureVisionsT
	{
		// Token: 0x17007DE5 RID: 32229
		// (get) Token: 0x0601A588 RID: 107912 RVA: 0x003BFEEA File Offset: 0x003BE0EA
		// (set) Token: 0x0601A589 RID: 107913 RVA: 0x003BFEF2 File Offset: 0x003BE0F2
		public ETrackType Type { get; set; }

		// Token: 0x17007DE6 RID: 32230
		// (get) Token: 0x0601A58A RID: 107914 RVA: 0x003BFEFB File Offset: 0x003BE0FB
		// (set) Token: 0x0601A58B RID: 107915 RVA: 0x003BFF03 File Offset: 0x003BE103
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x17007DE7 RID: 32231
		// (get) Token: 0x0601A58C RID: 107916 RVA: 0x003BFF0C File Offset: 0x003BE10C
		// (set) Token: 0x0601A58D RID: 107917 RVA: 0x003BFF14 File Offset: 0x003BE114
		public List<int> VisionDropEntities { get; set; }

		// Token: 0x0601A58E RID: 107918 RVA: 0x003BFF1D File Offset: 0x003BE11D
		public ITrackCaptureVisionsT()
		{
			this.Type = ETrackType.Locations;
			this.GravityDirection = null;
			this.VisionDropEntities = null;
		}
	}
}
