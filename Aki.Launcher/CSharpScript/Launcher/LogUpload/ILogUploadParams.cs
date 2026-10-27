using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C0 RID: 448
	[NullableContext(1)]
	public interface ILogUploadParams
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000C0F RID: 3087
		INet Net { get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000C10 RID: 3088
		IPlayerInfoModel PlayerInfoModel { get; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000C11 RID: 3089
		ILocalStorage LocalStorage { get; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000C12 RID: 3090
		IKuroSdkController KuroSdkController { get; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000C13 RID: 3091
		ILoginModel LoginModel { get; }
	}
}
