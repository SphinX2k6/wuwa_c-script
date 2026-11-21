using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D5 RID: 26837
	public class IBvbSkipChallengeT
	{
		// Token: 0x1700C53D RID: 50493
		// (get) Token: 0x0602DEC3 RID: 188099 RVA: 0x00646BAE File Offset: 0x00644DAE
		// (set) Token: 0x0602DEC4 RID: 188100 RVA: 0x00646BB6 File Offset: 0x00644DB6
		public int ChallengeId { get; set; }

		// Token: 0x0602DEC5 RID: 188101 RVA: 0x00646BBF File Offset: 0x00644DBF
		public IBvbSkipChallengeT()
		{
			this.ChallengeId = 0;
		}
	}
}
