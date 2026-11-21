using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF3 RID: 28659
	public class IICenterTextShowAllT
	{
		// Token: 0x1700D1EC RID: 53740
		// (get) Token: 0x06031A98 RID: 203416 RVA: 0x006BA20A File Offset: 0x006B840A
		// (set) Token: 0x06031A99 RID: 203417 RVA: 0x006BA212 File Offset: 0x006B8412
		public ECenterTextShowAnim Type { get; set; }

		// Token: 0x06031A9A RID: 203418 RVA: 0x006BA21B File Offset: 0x006B841B
		public IICenterTextShowAllT()
		{
			this.Type = ECenterTextShowAnim.ShowAll;
		}
	}
}
