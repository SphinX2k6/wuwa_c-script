using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BF8 RID: 15352
	[NullableContext(1)]
	public interface ISheriffReportPopParam
	{
		// Token: 0x17005068 RID: 20584
		// (get) Token: 0x060275A2 RID: 161186
		// (set) Token: 0x060275A3 RID: 161187
		int CriminalId { get; set; }

		// Token: 0x17005069 RID: 20585
		// (get) Token: 0x060275A4 RID: 161188
		// (set) Token: 0x060275A5 RID: 161189
		Action CloseCallback { get; set; }
	}
}
