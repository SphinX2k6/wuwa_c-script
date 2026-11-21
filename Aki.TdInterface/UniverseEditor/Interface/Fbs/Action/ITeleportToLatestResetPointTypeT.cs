using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B79 RID: 31609
	public class ITeleportToLatestResetPointTypeT
	{
		// Token: 0x1700ECA7 RID: 60583
		// (get) Token: 0x06038EDA RID: 233178 RVA: 0x007B1FC2 File Offset: 0x007B01C2
		// (set) Token: 0x06038EDB RID: 233179 RVA: 0x007B1FCA File Offset: 0x007B01CA
		public ETeleportToLatestResetPointType Type { get; set; }

		// Token: 0x06038EDC RID: 233180 RVA: 0x007B1FD3 File Offset: 0x007B01D3
		public ITeleportToLatestResetPointTypeT()
		{
			this.Type = ETeleportToLatestResetPointType.Directly;
		}
	}
}
