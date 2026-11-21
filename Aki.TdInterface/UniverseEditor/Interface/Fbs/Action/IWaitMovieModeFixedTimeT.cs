using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E0D RID: 32269
	public class IWaitMovieModeFixedTimeT
	{
		// Token: 0x1700F1B6 RID: 61878
		// (get) Token: 0x0603A511 RID: 238865 RVA: 0x007DB478 File Offset: 0x007D9678
		// (set) Token: 0x0603A512 RID: 238866 RVA: 0x007DB480 File Offset: 0x007D9680
		public EEnterMovieModeDurationType Type { get; set; }

		// Token: 0x1700F1B7 RID: 61879
		// (get) Token: 0x0603A513 RID: 238867 RVA: 0x007DB489 File Offset: 0x007D9689
		// (set) Token: 0x0603A514 RID: 238868 RVA: 0x007DB491 File Offset: 0x007D9691
		public float Duration { get; set; }

		// Token: 0x0603A515 RID: 238869 RVA: 0x007DB49A File Offset: 0x007D969A
		public IWaitMovieModeFixedTimeT()
		{
			this.Type = EEnterMovieModeDurationType.BorderAnimFinished;
			this.Duration = 0f;
		}
	}
}
