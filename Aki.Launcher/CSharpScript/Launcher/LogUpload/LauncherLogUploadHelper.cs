using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C3 RID: 451
	public class LauncherLogUploadHelper
	{
		// Token: 0x06000C43 RID: 3139 RVA: 0x0004DC90 File Offset: 0x0004BE90
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

		// Token: 0x06000C44 RID: 3140 RVA: 0x0004DD92 File Offset: 0x0004BF92
		public static void InitLogUpload()
		{
			LauncherLogUpload.Instance.SetParams(LauncherLogUploadHelper.CreateParams());
			LauncherLogUpload.Instance.Init();
		}
	}
}
