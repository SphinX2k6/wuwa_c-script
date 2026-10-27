using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FF RID: 30207
	public class IWaitMovieModeFixedTimeT
	{
		// Token: 0x1700E578 RID: 58744
		// (get) Token: 0x0603706C RID: 225388 RVA: 0x0077737C File Offset: 0x0077557C
		// (set) Token: 0x0603706D RID: 225389 RVA: 0x00777384 File Offset: 0x00775584
		public EEnterMovieModeDurationType Type { get; set; }

		// Token: 0x1700E579 RID: 58745
		// (get) Token: 0x0603706E RID: 225390 RVA: 0x0077738D File Offset: 0x0077558D
		// (set) Token: 0x0603706F RID: 225391 RVA: 0x00777395 File Offset: 0x00775595
		public float Duration { get; set; }

		// Token: 0x06037070 RID: 225392 RVA: 0x0077739E File Offset: 0x0077559E
		public IWaitMovieModeFixedTimeT()
		{
			this.Type = EEnterMovieModeDurationType.BorderAnimFinished;
			this.Duration = 0f;
		}
	}
}
