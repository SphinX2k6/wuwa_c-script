using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200435F RID: 17247
	public class IMechaTrackScoreDetectionTypeT
	{
		// Token: 0x17007651 RID: 30289
		// (get) Token: 0x06018584 RID: 99716 RVA: 0x00378DD2 File Offset: 0x00376FD2
		// (set) Token: 0x06018585 RID: 99717 RVA: 0x00378DDA File Offset: 0x00376FDA
		public EMechaTrackScoreDetectionType Type { get; set; }

		// Token: 0x06018586 RID: 99718 RVA: 0x00378DE3 File Offset: 0x00376FE3
		public IMechaTrackScoreDetectionTypeT()
		{
			this.Type = EMechaTrackScoreDetectionType.StuntAction;
		}
	}
}
