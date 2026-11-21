using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BEE RID: 15342
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainTabItemData : ISheriffMainTabItemData
	{
		// Token: 0x17005057 RID: 20567
		// (get) Token: 0x0602757C RID: 161148 RVA: 0x00B07DDA File Offset: 0x00B05FDA
		// (set) Token: 0x0602757D RID: 161149 RVA: 0x00B07DE2 File Offset: 0x00B05FE2
		public ESheriffMainTabType TabType { get; set; }

		// Token: 0x17005058 RID: 20568
		// (get) Token: 0x0602757E RID: 161150 RVA: 0x00B07DEB File Offset: 0x00B05FEB
		// (set) Token: 0x0602757F RID: 161151 RVA: 0x00B07DF3 File Offset: 0x00B05FF3
		public string TabIcon { get; set; } = "";

		// Token: 0x17005059 RID: 20569
		// (get) Token: 0x06027580 RID: 161152 RVA: 0x00B07DFC File Offset: 0x00B05FFC
		// (set) Token: 0x06027581 RID: 161153 RVA: 0x00B07E04 File Offset: 0x00B06004
		public string TabTxt { get; set; } = "";

		// Token: 0x1700505A RID: 20570
		// (get) Token: 0x06027582 RID: 161154 RVA: 0x00B07E0D File Offset: 0x00B0600D
		// (set) Token: 0x06027583 RID: 161155 RVA: 0x00B07E15 File Offset: 0x00B06015
		public bool? IsLock { get; set; }

		// Token: 0x1700505B RID: 20571
		// (get) Token: 0x06027584 RID: 161156 RVA: 0x00B07E1E File Offset: 0x00B0601E
		// (set) Token: 0x06027585 RID: 161157 RVA: 0x00B07E26 File Offset: 0x00B06026
		public EFunctionType FunctionType { get; set; }
	}
}
