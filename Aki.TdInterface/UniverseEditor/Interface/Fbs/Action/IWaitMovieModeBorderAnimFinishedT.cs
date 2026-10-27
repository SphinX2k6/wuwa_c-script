using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FC RID: 30204
	public class IWaitMovieModeBorderAnimFinishedT
	{
		// Token: 0x1700E574 RID: 58740
		// (get) Token: 0x06037058 RID: 225368 RVA: 0x00777196 File Offset: 0x00775396
		// (set) Token: 0x06037059 RID: 225369 RVA: 0x0077719E File Offset: 0x0077539E
		public EEnterMovieModeDurationType Type { get; set; }

		// Token: 0x0603705A RID: 225370 RVA: 0x007771A7 File Offset: 0x007753A7
		public IWaitMovieModeBorderAnimFinishedT()
		{
			this.Type = EEnterMovieModeDurationType.BorderAnimFinished;
		}
	}
}
