using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F27 RID: 16167
	public class IMechaTrackScoreMechanismStateT
	{
		// Token: 0x17007068 RID: 28776
		// (get) Token: 0x06016F56 RID: 94038 RVA: 0x0035009B File Offset: 0x0034E29B
		// (set) Token: 0x06016F57 RID: 94039 RVA: 0x003500A3 File Offset: 0x0034E2A3
		public EMechaTrackScoreDetectionType Type { get; set; }

		// Token: 0x17007069 RID: 28777
		// (get) Token: 0x06016F58 RID: 94040 RVA: 0x003500AC File Offset: 0x0034E2AC
		// (set) Token: 0x06016F59 RID: 94041 RVA: 0x003500B4 File Offset: 0x0034E2B4
		public List<IMechaTrackScoreMechanismStateTypeT> MechanismStateTypes { get; set; }

		// Token: 0x06016F5A RID: 94042 RVA: 0x003500BD File Offset: 0x0034E2BD
		public IMechaTrackScoreMechanismStateT()
		{
			this.Type = EMechaTrackScoreDetectionType.StuntAction;
			this.MechanismStateTypes = null;
		}
	}
}
