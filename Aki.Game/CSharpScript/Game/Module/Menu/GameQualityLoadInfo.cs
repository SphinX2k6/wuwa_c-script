using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x02005401 RID: 21505
	[NullableContext(1)]
	[Nullable(0)]
	public class GameQualityLoadInfo : IGameQualityLoadInfo
	{
		// Token: 0x17008429 RID: 33833
		// (get) Token: 0x06036F54 RID: 225108 RVA: 0x00D04F84 File Offset: 0x00D03184
		// (set) Token: 0x06036F55 RID: 225109 RVA: 0x00D04F8C File Offset: 0x00D0318C
		public string Desc { get; set; } = "";

		// Token: 0x1700842A RID: 33834
		// (get) Token: 0x06036F56 RID: 225110 RVA: 0x00D04F95 File Offset: 0x00D03195
		// (set) Token: 0x06036F57 RID: 225111 RVA: 0x00D04F9D File Offset: 0x00D0319D
		public int Percentage { get; set; }

		// Token: 0x1700842B RID: 33835
		// (get) Token: 0x06036F58 RID: 225112 RVA: 0x00D04FA6 File Offset: 0x00D031A6
		// (set) Token: 0x06036F59 RID: 225113 RVA: 0x00D04FAE File Offset: 0x00D031AE
		public string BarColor { get; set; } = "";
	}
}
