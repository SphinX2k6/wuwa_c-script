using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D5C RID: 23900
	public class IBvbRecycleBoardCardDataT
	{
		// Token: 0x1700B313 RID: 45843
		// (get) Token: 0x06028E40 RID: 167488 RVA: 0x0059E482 File Offset: 0x0059C682
		// (set) Token: 0x06028E41 RID: 167489 RVA: 0x0059E48A File Offset: 0x0059C68A
		public EGoalActType Type { get; set; }

		// Token: 0x06028E42 RID: 167490 RVA: 0x0059E493 File Offset: 0x0059C693
		public IBvbRecycleBoardCardDataT()
		{
			this.Type = EGoalActType.Deploy;
		}
	}
}
