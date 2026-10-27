using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PlayerInput
{
	// Token: 0x0200011F RID: 287
	[NullableContext(1)]
	[Nullable(0)]
	public class KeyPath : IKeyPath
	{
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00041D3C File Offset: 0x0003FF3C
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x00041D44 File Offset: 0x0003FF44
		[Nullable(2)]
		public string XBox { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00041D4D File Offset: 0x0003FF4D
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00041D55 File Offset: 0x0003FF55
		public string Ps { get; set; } = "";
	}
}
