using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702F RID: 28719
	public class IInteractT
	{
		// Token: 0x1700D24B RID: 53835
		// (get) Token: 0x06031C62 RID: 203874 RVA: 0x006BCFF3 File Offset: 0x006BB1F3
		// (set) Token: 0x06031C63 RID: 203875 RVA: 0x006BCFFB File Offset: 0x006BB1FB
		public int Who { get; set; }

		// Token: 0x1700D24C RID: 53836
		// (get) Token: 0x06031C64 RID: 203876 RVA: 0x006BD004 File Offset: 0x006BB204
		// (set) Token: 0x06031C65 RID: 203877 RVA: 0x006BD00C File Offset: 0x006BB20C
		public string Param { get; set; }

		// Token: 0x06031C66 RID: 203878 RVA: 0x006BD015 File Offset: 0x006BB215
		public IInteractT()
		{
			this.Who = 0;
			this.Param = null;
		}
	}
}
