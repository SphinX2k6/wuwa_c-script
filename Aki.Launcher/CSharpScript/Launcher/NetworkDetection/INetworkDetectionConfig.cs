using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001B1 RID: 433
	[NullableContext(2)]
	[Nullable(0)]
	public class INetworkDetectionConfig
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0004CA52 File Offset: 0x0004AC52
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x0004CA5A File Offset: 0x0004AC5A
		public string ip { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0004CA63 File Offset: 0x0004AC63
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x0004CA6B File Offset: 0x0004AC6B
		public string PingUrl { get; set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0004CA74 File Offset: 0x0004AC74
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x0004CA7C File Offset: 0x0004AC7C
		public int[] UdpPort { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0004CA85 File Offset: 0x0004AC85
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x0004CA8D File Offset: 0x0004AC8D
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] LoginUrl { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
