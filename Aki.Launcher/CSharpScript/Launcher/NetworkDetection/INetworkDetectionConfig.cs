using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001AD RID: 429
	[NullableContext(2)]
	[Nullable(0)]
	public class INetworkDetectionConfig
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0004A262 File Offset: 0x00048462
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0004A26A File Offset: 0x0004846A
		public string ip { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0004A273 File Offset: 0x00048473
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x0004A27B File Offset: 0x0004847B
		public string PingUrl { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0004A284 File Offset: 0x00048484
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x0004A28C File Offset: 0x0004848C
		public int[] UdpPort { get; set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0004A295 File Offset: 0x00048495
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x0004A29D File Offset: 0x0004849D
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
