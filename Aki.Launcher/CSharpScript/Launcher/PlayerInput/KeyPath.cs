using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PlayerInput
{
	// Token: 0x02000123 RID: 291
	[NullableContext(1)]
	[Nullable(0)]
	public class KeyPath : IKeyPath
	{
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00044104 File Offset: 0x00042304
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x0004410C File Offset: 0x0004230C
		[Nullable(2)]
		public string XBox { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00044115 File Offset: 0x00042315
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x0004411D File Offset: 0x0004231D
		public string Ps { get; set; } = "";
	}
}
