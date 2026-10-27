using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F21 RID: 16161
	public class IMechaTrackScoreDetectionTypeT
	{
		// Token: 0x17007062 RID: 28770
		// (get) Token: 0x06016F2C RID: 93996 RVA: 0x0034FBAA File Offset: 0x0034DDAA
		// (set) Token: 0x06016F2D RID: 93997 RVA: 0x0034FBB2 File Offset: 0x0034DDB2
		public EMechaTrackScoreDetectionType Type { get; set; }

		// Token: 0x06016F2E RID: 93998 RVA: 0x0034FBBB File Offset: 0x0034DDBB
		public IMechaTrackScoreDetectionTypeT()
		{
			this.Type = EMechaTrackScoreDetectionType.StuntAction;
		}
	}
}
