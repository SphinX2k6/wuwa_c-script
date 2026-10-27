using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B9B RID: 27547
	public class INewSplineMoveTargetT
	{
		// Token: 0x1700CCC7 RID: 52423
		// (get) Token: 0x0603062D RID: 198189 RVA: 0x006928F6 File Offset: 0x00690AF6
		// (set) Token: 0x0603062E RID: 198190 RVA: 0x006928FE File Offset: 0x00690AFE
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x0603062F RID: 198191 RVA: 0x00692907 File Offset: 0x00690B07
		public INewSplineMoveTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
		}
	}
}
