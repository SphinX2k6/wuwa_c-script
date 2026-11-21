using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001DD RID: 477
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchKuroSdk : Singleton
	{
		// Token: 0x06000CBF RID: 3263 RVA: 0x0004F37C File Offset: 0x0004D57C
		public bool GetIfGlobalSdk()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0004F397 File Offset: 0x0004D597
		public bool CanUseSdk()
		{
			return UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0004F3C4 File Offset: 0x0004D5C4
		public void Init()
		{
			LauncherSdk.Init();
			if (!this.CanUseSdk())
			{
				HotPatchKuroTdm.Init();
				return;
			}
			UniTaskCompletionSource tcs = new UniTaskCompletionSource();
			this.InitPromise = tcs;
			if (UKuroLauncherLibrary.IsFirstIntoLauncher())
			{
				this.InitSdk(delegate
				{
					tcs.TrySetResult();
				});
				this.ReportEvent(HotPatchReportData.CreateData(ESdkHotPatchReportEnum.Logo, null));
				return;
			}
			tcs.TrySetResult();
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0004F434 File Offset: 0x0004D634
		private void InitSdk(Action resolve)
		{
			if (!this.CanUseSdk())
			{
				Action resolve2 = resolve;
				if (resolve2 == null)
				{
					return;
				}
				resolve2();
				return;
			}
			else
			{
				UKuroSDKManager.Start();
				if (!UKuroSDKManager.GetSdkInitState())
				{
					Action<bool> cb = null;
					cb = delegate(bool result)
					{
						UKuroSDKManager.Get().InitDelegate.Remove(cb);
						LauncherLog.Instance.Debug("SDK初始化完成", default(ReadOnlySpan<ValueTuple<string, object>>));
						HotPatchKuroTdm.Init();
						Action resolve4 = resolve;
						if (resolve4 == null)
						{
							return;
						}
						resolve4();
					};
					UKuroSDKManager.Get().InitDelegate.Add(cb);
					UKuroSDKManager.DoInitSdkProcedure();
					UKuroSDKManager.Get().ExitDelegate.Clear();
					UKuroSDKManager.Get().ExitDelegate.Add(delegate()
					{
						LauncherLog.Instance.Debug("HotPatchKuroSdk KuroSDKManager.Get()!.ExitDelegate Call", default(ReadOnlySpan<ValueTuple<string, object>>));
						KuroApplication.ExitWithReason(false, "SDK");
					});
					return;
				}
				LauncherLog.Instance.Info("SDK初始化已完成，无需再次初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				HotPatchKuroTdm.Init();
				Action resolve3 = resolve;
				if (resolve3 == null)
				{
					return;
				}
				resolve3();
				return;
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0004F512 File Offset: 0x0004D712
		[NullableContext(2)]
		public void ReportEvent(SdkReportData data)
		{
			if (data == null)
			{
				return;
			}
			if (!this.CanUseSdk())
			{
				return;
			}
			this.PushReportMsgTrySendReport(data);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0004F52C File Offset: 0x0004D72C
		private UniTask PushReportMsgTrySendReport(SdkReportData reportData)
		{
			HotPatchKuroSdk.<PushReportMsgTrySendReport>d__7 <PushReportMsgTrySendReport>d__;
			<PushReportMsgTrySendReport>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PushReportMsgTrySendReport>d__.<>4__this = this;
			<PushReportMsgTrySendReport>d__.reportData = reportData;
			<PushReportMsgTrySendReport>d__.<>1__state = -1;
			<PushReportMsgTrySendReport>d__.<>t__builder.Start<HotPatchKuroSdk.<PushReportMsgTrySendReport>d__7>(ref <PushReportMsgTrySendReport>d__);
			return <PushReportMsgTrySendReport>d__.<>t__builder.Task;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0004F577 File Offset: 0x0004D777
		public string GetChannelId()
		{
			if (PlatformSdkManagerNew.Instance.IsSdkOn)
			{
				return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetChannelId();
			}
			if (!this.CanUseSdk())
			{
				return "";
			}
			return UKuroSDKManager.GetChannelId();
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0004F5A8 File Offset: 0x0004D7A8
		public string GetPackageId()
		{
			if (PlatformSdkManagerNew.Instance.IsSdkOn)
			{
				return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetPackageId();
			}
			if (!this.CanUseSdk())
			{
				return "";
			}
			return UKuroSDKManager.GetPackageId();
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0004F5D9 File Offset: 0x0004D7D9
		public static HotPatchKuroSdk Instance
		{
			get
			{
				if (HotPatchKuroSdk._instance == null)
				{
					HotPatchKuroSdk._instance = new HotPatchKuroSdk();
					HotPatchKuroSdk._instance.OnInit();
				}
				return HotPatchKuroSdk._instance;
			}
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0004F5FC File Offset: 0x0004D7FC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0004F5FE File Offset: 0x0004D7FE
		public static void ResetStaticDefaultValue()
		{
			HotPatchKuroSdk instance = HotPatchKuroSdk._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotPatchKuroSdk._instance = null;
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0004F617 File Offset: 0x0004D817
		static HotPatchKuroSdk()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchKuroSdk.CreateStaticDefaultValue), new Action(HotPatchKuroSdk.ResetStaticDefaultValue));
		}

		// Token: 0x04000821 RID: 2081
		private const string USESDK = "1";

		// Token: 0x04000822 RID: 2082
		[Nullable(2)]
		private UniTaskCompletionSource InitPromise;

		// Token: 0x04000823 RID: 2083
		[Nullable(2)]
		private static HotPatchKuroSdk _instance;
	}
}
