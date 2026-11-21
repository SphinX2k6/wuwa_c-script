using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004365 RID: 17253
	public class IMechaTrackScoreMechanismStateT
	{
		// Token: 0x17007657 RID: 30295
		// (get) Token: 0x060185AE RID: 99758 RVA: 0x003792C3 File Offset: 0x003774C3
		// (set) Token: 0x060185AF RID: 99759 RVA: 0x003792CB File Offset: 0x003774CB
		public EMechaTrackScoreDetectionType Type { get; set; }

		// Token: 0x17007658 RID: 30296
		// (get) Token: 0x060185B0 RID: 99760 RVA: 0x003792D4 File Offset: 0x003774D4
		// (set) Token: 0x060185B1 RID: 99761 RVA: 0x003792DC File Offset: 0x003774DC
		public List<IMechaTrackScoreMechanismStateTypeT> MechanismStateTypes { get; set; }

		// Token: 0x060185B2 RID: 99762 RVA: 0x003792E5 File Offset: 0x003774E5
		public IMechaTrackScoreMechanismStateT()
		{
			this.Type = EMechaTrackScoreDetectionType.StuntAction;
			this.MechanismStateTypes = null;
		}
	}
}
