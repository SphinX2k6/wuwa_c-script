using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x02000204 RID: 516
	[NullableContext(1)]
	public interface IResponse
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000D6B RID: 3435
		// (set) Token: 0x06000D6C RID: 3436
		int Code { get; set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000D6D RID: 3437
		// (set) Token: 0x06000D6E RID: 3438
		string Result { get; set; }
	}
}
