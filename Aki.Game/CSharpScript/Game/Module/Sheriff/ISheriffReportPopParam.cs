using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C47 RID: 19527
	[NullableContext(1)]
	public interface ISheriffReportPopParam
	{
		// Token: 0x17007CBE RID: 31934
		// (get) Token: 0x060327EF RID: 206831
		// (set) Token: 0x060327F0 RID: 206832
		int CriminalId { get; set; }

		// Token: 0x17007CBF RID: 31935
		// (get) Token: 0x060327F1 RID: 206833
		// (set) Token: 0x060327F2 RID: 206834
		Action CloseCallback { get; set; }
	}
}
