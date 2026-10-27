using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C6 RID: 454
	[NullableContext(1)]
	[Nullable(0)]
	public class LogUploadParams : ILogUploadParams
	{
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0004B5A1 File Offset: 0x000497A1
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x0004B5A9 File Offset: 0x000497A9
		public INet Net { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0004B5B2 File Offset: 0x000497B2
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0004B5BA File Offset: 0x000497BA
		public IPlayerInfoModel PlayerInfoModel { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0004B5C3 File Offset: 0x000497C3
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x0004B5CB File Offset: 0x000497CB
		public ILocalStorage LocalStorage { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0004B5D4 File Offset: 0x000497D4
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x0004B5DC File Offset: 0x000497DC
		public IKuroSdkController KuroSdkController { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0004B5E5 File Offset: 0x000497E5
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0004B5ED File Offset: 0x000497ED
		public ILoginModel LoginModel { get; set; }
	}
}
