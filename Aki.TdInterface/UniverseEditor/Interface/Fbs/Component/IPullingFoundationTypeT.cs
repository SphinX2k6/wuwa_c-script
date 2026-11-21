using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DB9 RID: 23993
	public class IPullingFoundationTypeT
	{
		// Token: 0x1700B0BE RID: 45246
		// (get) Token: 0x06028004 RID: 163844 RVA: 0x00578A66 File Offset: 0x00576C66
		// (set) Token: 0x06028005 RID: 163845 RVA: 0x00578A6E File Offset: 0x00576C6E
		public EPullingFoundation Type { get; set; }

		// Token: 0x06028006 RID: 163846 RVA: 0x00578A77 File Offset: 0x00576C77
		public IPullingFoundationTypeT()
		{
			this.Type = EPullingFoundation.CategoryMatching;
		}
	}
}
