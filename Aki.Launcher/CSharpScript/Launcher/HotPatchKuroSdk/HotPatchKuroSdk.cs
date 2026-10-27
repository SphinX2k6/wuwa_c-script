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
	// Token: 0x020001D9 RID: 473
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchKuroSdk : Singleton
	{
		// Token: 0x06000C88 RID: 3208 RVA: 0x0004CB68 File Offset: 0x0004AD68
		public bool GetIfGlobalSdk()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0004CB83 File Offset: 0x0004AD83
		public bool CanUseSdk()
		{
			return UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
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

		// Token: 0x06000C8B RID: 3211 RVA: 0x0004CC20 File Offset: 0x0004AE20
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

		// Token: 0x06000C8C RID: 3212 RVA: 0x0004CCFE File Offset: 0x0004AEFE
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

		// Token: 0x06000C8D RID: 3213 RVA: 0x0004CD18 File Offset: 0x0004AF18
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

		// Token: 0x06000C8E RID: 3214 RVA: 0x0004CD63 File Offset: 0x0004AF63
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

		// Token: 0x06000C8F RID: 3215 RVA: 0x0004CD94 File Offset: 0x0004AF94
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

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0004CDC5 File Offset: 0x0004AFC5
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

		// Token: 0x06000C91 RID: 3217 RVA: 0x0004CDE8 File Offset: 0x0004AFE8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0004CDEA File Offset: 0x0004AFEA
		public static void ResetStaticDefaultValue()
		{
			HotPatchKuroSdk instance = HotPatchKuroSdk._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotPatchKuroSdk._instance = null;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0004CE03 File Offset: 0x0004B003
		static HotPatchKuroSdk()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchKuroSdk.CreateStaticDefaultValue), new Action(HotPatchKuroSdk.ResetStaticDefaultValue));
		}

		// Token: 0x040007E4 RID: 2020
		private const string USESDK = "1";

		// Token: 0x040007E5 RID: 2021
		[Nullable(2)]
		private UniTaskCompletionSource InitPromise;

		// Token: 0x040007E6 RID: 2022
		[Nullable(2)]
		private static HotPatchKuroSdk _instance;
	}
}
