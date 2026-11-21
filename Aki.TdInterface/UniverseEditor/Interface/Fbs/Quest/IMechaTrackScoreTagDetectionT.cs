using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200436E RID: 17262
	public class IMechaTrackScoreTagDetectionT
	{
		// Token: 0x17007665 RID: 30309
		// (get) Token: 0x060185F0 RID: 99824 RVA: 0x0037994A File Offset: 0x00377B4A
		// (set) Token: 0x060185F1 RID: 99825 RVA: 0x00379952 File Offset: 0x00377B52
		public EMechaTrackScoreDetectionType Type { get; set; }

		// Token: 0x060185F2 RID: 99826 RVA: 0x0037995B File Offset: 0x00377B5B
		public IMechaTrackScoreTagDetectionT()
		{
			this.Type = EMechaTrackScoreDetectionType.StuntAction;
		}
	}
}
