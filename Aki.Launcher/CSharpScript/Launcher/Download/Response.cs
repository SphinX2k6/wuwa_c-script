using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x02000205 RID: 517
	[NullableContext(1)]
	[Nullable(0)]
	public class Response : IResponse
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00052A3D File Offset: 0x00050C3D
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x00052A45 File Offset: 0x00050C45
		public int Code { get; set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00052A4E File Offset: 0x00050C4E
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x00052A56 File Offset: 0x00050C56
		public string Result { get; set; }
	}
}
