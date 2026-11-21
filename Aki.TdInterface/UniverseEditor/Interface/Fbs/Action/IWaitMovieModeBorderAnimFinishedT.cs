using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E0A RID: 32266
	public class IWaitMovieModeBorderAnimFinishedT
	{
		// Token: 0x1700F1B2 RID: 61874
		// (get) Token: 0x0603A4FD RID: 238845 RVA: 0x007DB292 File Offset: 0x007D9492
		// (set) Token: 0x0603A4FE RID: 238846 RVA: 0x007DB29A File Offset: 0x007D949A
		public EEnterMovieModeDurationType Type { get; set; }

		// Token: 0x0603A4FF RID: 238847 RVA: 0x007DB2A3 File Offset: 0x007D94A3
		public IWaitMovieModeBorderAnimFinishedT()
		{
			this.Type = EEnterMovieModeDurationType.BorderAnimFinished;
		}
	}
}
