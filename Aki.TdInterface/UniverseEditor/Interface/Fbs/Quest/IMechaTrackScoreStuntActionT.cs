using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200436B RID: 17259
	public class IMechaTrackScoreStuntActionT
	{
		// Token: 0x17007662 RID: 30306
		// (get) Token: 0x060185DE RID: 99806 RVA: 0x003797D2 File Offset: 0x003779D2
		// (set) Token: 0x060185DF RID: 99807 RVA: 0x003797DA File Offset: 0x003779DA
		public EMechaTrackScoreDetectionType Type { get; set; }

		// Token: 0x060185E0 RID: 99808 RVA: 0x003797E3 File Offset: 0x003779E3
		public IMechaTrackScoreStuntActionT()
		{
			this.Type = EMechaTrackScoreDetectionType.StuntAction;
		}
	}
}
