using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001BF RID: 447
	public class LauncherLogUploadHelper
	{
		// Token: 0x06000C0C RID: 3084 RVA: 0x0004B47C File Offset: 0x0004967C
		[NullableContext(1)]
		public static ILogUploadParams CreateParams()
		{
			LogUploadParams logUploadParams = new LogUploadParams();
			Net net = new Net();
			net.IsServerConnected = (() => false);
			logUploadParams.Net = net;
			PlayerInfoModel playerInfoModel = new PlayerInfoModel();
			playerInfoModel.GetId = (() => new int?(0));
			logUploadParams.PlayerInfoModel = playerInfoModel;
			LocalStorage localStorage = new LocalStorage();
			localStorage.GetRecentlyLoginUid = (() => LauncherStorageLib.Instance.GetGlobal<int?>(ELauncherStorageGlobalKey.RecentlyLoginUID, null));
			logUploadParams.LocalStorage = localStorage;
			KuroSdkController kuroSdkController = new KuroSdkController();
			kuroSdkController.CanUseSdk = (() => HotPatchKuroSdk.Instance.CanUseSdk());
			logUploadParams.KuroSdkController = kuroSdkController;
			LoginModel loginModel = new LoginModel();
			loginModel.GetSdkLoginConfigUid = (() => null);
			logUploadParams.LoginModel = loginModel;
			return logUploadParams;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0004B57E File Offset: 0x0004977E
		public static void InitLogUpload()
		{
			LauncherLogUpload.Instance.SetParams(LauncherLogUploadHelper.CreateParams());
			LauncherLogUpload.Instance.Init();
		}
	}
}
