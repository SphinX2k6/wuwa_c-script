using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000257 RID: 599
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientFightConfigData : IClientFightConfigData
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00059B90 File Offset: 0x00057D90
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00059B98 File Offset: 0x00057D98
		public string clientMd5 { get; set; } = string.Empty;
	}
}
