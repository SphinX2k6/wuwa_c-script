using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Launcher.LogUpload;

namespace CSharpScript.Game.Module.LogUpload
{
	// Token: 0x020056A6 RID: 22182
	public static class LogUploadHelper
	{
		// Token: 0x06038723 RID: 231203 RVA: 0x00D66BAC File Offset: 0x00D64DAC
		[NullableContext(1)]
		public static ILogUploadParams CreateParams()
		{
			LogUploadParams logUploadParams = new LogUploadParams();
			CSharpScript.Launcher.LogUpload.Net net = new CSharpScript.Launcher.LogUpload.Net();
			net.IsServerConnected = (() => global::Net.Instance.IsServerConnected());
			logUploadParams.Net = net;
			CSharpScript.Launcher.LogUpload.PlayerInfoModel playerInfoModel = new CSharpScript.Launcher.LogUpload.PlayerInfoModel();
			playerInfoModel.GetId = (() => global::PlayerInfoModel.Instance.GetId());
			logUploadParams.PlayerInfoModel = playerInfoModel;
			CSharpScript.Launcher.LogUpload.LocalStorage localStorage = new CSharpScript.Launcher.LogUpload.LocalStorage();
			localStorage.GetRecentlyLoginUid = delegate()
			{
				int global = CSharpScript.Game.Common.LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.RecentlyLoginUID, 0);
				if (global == 0)
				{
					return null;
				}
				return new int?(global);
			};
			logUploadParams.LocalStorage = localStorage;
			CSharpScript.Launcher.LogUpload.KuroSdkController kuroSdkController = new CSharpScript.Launcher.LogUpload.KuroSdkController();
			kuroSdkController.CanUseSdk = (() => global::KuroSdkController.Instance.CanUseSdk());
			logUploadParams.KuroSdkController = kuroSdkController;
			CSharpScript.Launcher.LogUpload.LoginModel loginModel = new CSharpScript.Launcher.LogUpload.LoginModel();
			loginModel.GetSdkLoginConfigUid = delegate()
			{
				SdkLoginConfig sdkLoginConfig = global::LoginModel.Instance.GetSdkLoginConfig();
				if (sdkLoginConfig == null)
				{
					return null;
				}
				return sdkLoginConfig.Uid;
			};
			logUploadParams.LoginModel = loginModel;
			return logUploadParams;
		}
	}
}
