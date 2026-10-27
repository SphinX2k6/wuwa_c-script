using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000252 RID: 594
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientFightConfigData : IClientFightConfigData
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0005704C File Offset: 0x0005524C
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x00057054 File Offset: 0x00055254
		public string clientMd5 { get; set; } = string.Empty;
	}
}
