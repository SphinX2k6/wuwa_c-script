using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001CA RID: 458
	[NullableContext(1)]
	[Nullable(0)]
	public class LogUploadParams : ILogUploadParams
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0004DDB5 File Offset: 0x0004BFB5
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x0004DDBD File Offset: 0x0004BFBD
		public INet Net { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0004DDC6 File Offset: 0x0004BFC6
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x0004DDCE File Offset: 0x0004BFCE
		public IPlayerInfoModel PlayerInfoModel { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0004DDD7 File Offset: 0x0004BFD7
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x0004DDDF File Offset: 0x0004BFDF
		public ILocalStorage LocalStorage { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0004DDE8 File Offset: 0x0004BFE8
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x0004DDF0 File Offset: 0x0004BFF0
		public IKuroSdkController KuroSdkController { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0004DDF9 File Offset: 0x0004BFF9
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x0004DE01 File Offset: 0x0004C001
		public ILoginModel LoginModel { get; set; }
	}
}
