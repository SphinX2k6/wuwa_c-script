using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x02000200 RID: 512
	[NullableContext(1)]
	[Nullable(0)]
	public class Response : IResponse
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0004FF51 File Offset: 0x0004E151
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x0004FF59 File Offset: 0x0004E159
		public int Code { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0004FF62 File Offset: 0x0004E162
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x0004FF6A File Offset: 0x0004E16A
		public string Result { get; set; }
	}
}
