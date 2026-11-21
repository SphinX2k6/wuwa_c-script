using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C4 RID: 452
	[NullableContext(1)]
	public interface ILogUploadParams
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000C46 RID: 3142
		INet Net { get; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000C47 RID: 3143
		IPlayerInfoModel PlayerInfoModel { get; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000C48 RID: 3144
		ILocalStorage LocalStorage { get; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000C49 RID: 3145
		IKuroSdkController KuroSdkController { get; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000C4A RID: 3146
		ILoginModel LoginModel { get; }
	}
}
