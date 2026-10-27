using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F2D RID: 16173
	public class IMechaTrackScoreStuntActionT
	{
		// Token: 0x17007073 RID: 28787
		// (get) Token: 0x06016F86 RID: 94086 RVA: 0x003505AA File Offset: 0x0034E7AA
		// (set) Token: 0x06016F87 RID: 94087 RVA: 0x003505B2 File Offset: 0x0034E7B2
		public EMechaTrackScoreDetectionType Type { get; set; }

		// Token: 0x06016F88 RID: 94088 RVA: 0x003505BB File Offset: 0x0034E7BB
		public IMechaTrackScoreStuntActionT()
		{
			this.Type = EMechaTrackScoreDetectionType.StuntAction;
		}
	}
}
