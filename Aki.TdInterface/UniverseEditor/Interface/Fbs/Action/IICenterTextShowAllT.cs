using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006940 RID: 26944
	public class IICenterTextShowAllT
	{
		// Token: 0x1700C7E9 RID: 51177
		// (get) Token: 0x0602F0C8 RID: 192712 RVA: 0x00669D22 File Offset: 0x00667F22
		// (set) Token: 0x0602F0C9 RID: 192713 RVA: 0x00669D2A File Offset: 0x00667F2A
		public ECenterTextShowAnim Type { get; set; }

		// Token: 0x0602F0CA RID: 192714 RVA: 0x00669D33 File Offset: 0x00667F33
		public IICenterTextShowAllT()
		{
			this.Type = ECenterTextShowAnim.ShowAll;
		}
	}
}
