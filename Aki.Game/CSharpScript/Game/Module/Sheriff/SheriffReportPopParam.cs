using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C48 RID: 19528
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffReportPopParam : ISheriffReportPopParam
	{
		// Token: 0x17007CC0 RID: 31936
		// (get) Token: 0x060327F3 RID: 206835 RVA: 0x00BC3367 File Offset: 0x00BC1567
		// (set) Token: 0x060327F4 RID: 206836 RVA: 0x00BC336F File Offset: 0x00BC156F
		public int CriminalId { get; set; }

		// Token: 0x17007CC1 RID: 31937
		// (get) Token: 0x060327F5 RID: 206837 RVA: 0x00BC3378 File Offset: 0x00BC1578
		// (set) Token: 0x060327F6 RID: 206838 RVA: 0x00BC3380 File Offset: 0x00BC1580
		public Action CloseCallback { get; set; } = delegate()
		{
		};
	}
}
