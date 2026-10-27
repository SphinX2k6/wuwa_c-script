using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F30 RID: 16176
	public class IMechaTrackScoreTagDetectionT
	{
		// Token: 0x17007076 RID: 28790
		// (get) Token: 0x06016F98 RID: 94104 RVA: 0x00350722 File Offset: 0x0034E922
		// (set) Token: 0x06016F99 RID: 94105 RVA: 0x0035072A File Offset: 0x0034E92A
		public EMechaTrackScoreDetectionType Type { get; set; }

		// Token: 0x06016F9A RID: 94106 RVA: 0x00350733 File Offset: 0x0034E933
		public IMechaTrackScoreTagDetectionT()
		{
			this.Type = EMechaTrackScoreDetectionType.StuntAction;
		}
	}
}
