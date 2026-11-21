using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005824 RID: 22564
	public class IFollowTrackToStartT
	{
		// Token: 0x1700A352 RID: 41810
		// (get) Token: 0x0602483B RID: 149563 RVA: 0x00504312 File Offset: 0x00502512
		// (set) Token: 0x0602483C RID: 149564 RVA: 0x0050431A File Offset: 0x0050251A
		public EFollowTrackEndType Type { get; set; }

		// Token: 0x0602483D RID: 149565 RVA: 0x00504323 File Offset: 0x00502523
		public IFollowTrackToStartT()
		{
			this.Type = EFollowTrackEndType.ToStart;
		}
	}
}
