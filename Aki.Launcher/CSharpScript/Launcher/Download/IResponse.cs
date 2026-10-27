using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001FF RID: 511
	[NullableContext(1)]
	public interface IResponse
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000D2A RID: 3370
		// (set) Token: 0x06000D2B RID: 3371
		int Code { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000D2C RID: 3372
		// (set) Token: 0x06000D2D RID: 3373
		string Result { get; set; }
	}
}
