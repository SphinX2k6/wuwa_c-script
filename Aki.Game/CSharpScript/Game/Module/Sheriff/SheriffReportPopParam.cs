using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BF9 RID: 15353
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffReportPopParam : ISheriffReportPopParam
	{
		// Token: 0x1700506A RID: 20586
		// (get) Token: 0x060275A6 RID: 161190 RVA: 0x00B07F7F File Offset: 0x00B0617F
		// (set) Token: 0x060275A7 RID: 161191 RVA: 0x00B07F87 File Offset: 0x00B06187
		public int CriminalId { get; set; }

		// Token: 0x1700506B RID: 20587
		// (get) Token: 0x060275A8 RID: 161192 RVA: 0x00B07F90 File Offset: 0x00B06190
		// (set) Token: 0x060275A9 RID: 161193 RVA: 0x00B07F98 File Offset: 0x00B06198
		public Action CloseCallback { get; set; } = delegate()
		{
		};
	}
}
