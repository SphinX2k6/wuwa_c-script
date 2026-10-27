using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E2F RID: 28207
	public class IReignsSetPropertyVisibleT
	{
		// Token: 0x1700D234 RID: 53812
		// (get) Token: 0x06031D6C RID: 204140 RVA: 0x006BEF64 File Offset: 0x006BD164
		// (set) Token: 0x06031D6D RID: 204141 RVA: 0x006BEF6C File Offset: 0x006BD16C
		public int PropertyId { get; set; }

		// Token: 0x1700D235 RID: 53813
		// (get) Token: 0x06031D6E RID: 204142 RVA: 0x006BEF75 File Offset: 0x006BD175
		// (set) Token: 0x06031D6F RID: 204143 RVA: 0x006BEF7D File Offset: 0x006BD17D
		public bool IsVisible { get; set; }

		// Token: 0x06031D70 RID: 204144 RVA: 0x006BEF86 File Offset: 0x006BD186
		public IReignsSetPropertyVisibleT()
		{
			this.PropertyId = 0;
			this.IsVisible = false;
		}
	}
}
