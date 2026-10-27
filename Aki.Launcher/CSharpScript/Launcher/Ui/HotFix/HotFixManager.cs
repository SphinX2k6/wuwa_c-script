using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.LogUpload;
using CSharpScript.Launcher.Notice;
using CSharpScript.Launcher.Server;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Update.ResourceDiffUpdate.Config;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000DF RID: 223
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixManager : IStaticVariableResetter
	{
		// Token: 0x06000717 RID: 1815 RVA: 0x0003A0DC File Offset: 0x000382DC
		static HotFixManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotFixManager.CreateStaticDefaultValue), new Action(HotFixManager.ResetStaticDefaultValue));
			HotFixManager.ErrorDialogIds = new HashSet<string>
			{
				"DownloadIndexFileFailed",
				"BinPatchFailed",
				"DownloadResourcePatchFailed",
				"MoveFilesFailed",
				"EvaluateDownloadResourcePatchFailed",
				"NetworkDetection_Http_Wrong",
				"NetworkDetection_Udp_Wrong",
				"GetResourceInfoFailed",
				"ValidateResourceFailed",
				"ResolveIndexFileFailed",
				"NetworkDetection_Domain_Wrong",
				"GetRemoteConfigFailed",
				"GetRemoteVersionFailed"
			};
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0003A22A File Offset: 0x0003842A
		public static void CreateStaticDefaultValue()
		{
			HotFixManager.DownLoadType = EVideoResSizeType.StartMaxNeed;
			HotFixManager.ResDownLoadType = EResUpdateType.Max;
			HotFixManager.SelectResourceQualityTier = ETier.None;
			HotFixManager.ApplyTierChangeHandler = null;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0003A244 File Offset: 0x00038444
		public static void ResetStaticDefaultValue()
		{
			HotFixManager.DownLoadViewChosePromise = null;
			HotFixManager.DownLoadViewChoseDoneCallBack = null;
			HotFixManager.FreeSpaceCheckPromise = null;
			HotFixManager.FreeSpaceCheckDoneCallBack = null;
			HotFixManager.DownLoadType = EVideoResSizeType.StartMaxNeed;
			HotFixManager.NeedDownLoadByte = 0L;
			HotFixManager.SdkLoginHotFixManagerHandle = null;
			HotFixManager.SdkLoginPromiseResolve = null;
			HotFixManager.OnSdkLoginSuccessCallBack = null;
			HotFixManager.LaunchSdkLoginServerIp = "";
			HotFixManager.LaunchSubPackageHttpData = null;
			HotFixManager.HandleLoginData = null;
			HotFixManager.GetLoginSubPackageDownLoadHttpTimes = 0;
			HotFixManager.SuggestSeverData = null;
			HotFixManager.LoginUrlPollingIndex = 0;
			HotFixManager.ResDownLoadType = EResUpdateType.Max;
			HotFixManager.HandleAutoClear = false;
			HotFixManager.SelectResourceQualityTier = ETier.None;
			HotFixManager.ApplyTierChangeHandler = null;
			HotFixManager.MobilePreDownloadApplyTierChangeHandler = null;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0003A2CE File Offset: 0x000384CE
		public void SetNetworkType(ENetworkType networkType)
		{
			this.NetworkType = new ENetworkType?(networkType);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0003A2DC File Offset: 0x000384DC
		public ENetworkType? GetNetworkType()
		{
			return this.NetworkType;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0003A2E4 File Offset: 0x000384E4
		public static IReadOnlyList<ETier> GetSupportedResourceQualityTiers()
		{
			return LauncherDeviceTierLib.GetDeviceSupportTiers();
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0003A2EB File Offset: 0x000384EB
		public static bool IsResourceQualityTierSupported(ETier tier)
		{
			return HotFixManager.GetSupportedResourceQualityTiers().Contains(tier);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0003A2F8 File Offset: 0x000384F8
		public static ETier GetRecommendTier()
		{
			return LauncherDeviceTierLib.GetRecommendedTier();
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0003A2FF File Offset: 0x000384FF
		public static bool IsMobileHighEndDevice()
		{
			return LauncherDeviceTierLib.GetDeviceSupportTiers().Count > 1;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0003A30E File Offset: 0x0003850E
		public static bool IsTierEnabled()
		{
			return RemoteInfo.Instance.IsResourceQualityTierEnabled();
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x0003A31A File Offset: 0x0003851A
		public static ETier LocalResourceQualityTier
		{
			get
			{
				return RemoteInfo.Instance.ActiveTier;
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0003A326 File Offset: 0x00038526
		public static ETier GetLocalResourceQualityTier()
		{
			return LauncherDeviceTierLib.GetActiveTier();
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0003A330 File Offset: 0x00038530
		public static ETier? GetTargetResourceQualityTier()
		{
			int? deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<int?>(ELauncherStorageDeviceKey.TargetResourceQualityTier, null);
			if (deviceSaved != null)
			{
				return new ETier?((ETier)deviceSaved.Value);
			}
			return null;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0003A372 File Offset: 0x00038572
		public static void SetTargetResourceQualityTier(ETier tier)
		{
			LauncherStorageLib.Instance.SetDeviceSaved<int>(ELauncherStorageDeviceKey.TargetResourceQualityTier, (int)tier);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0003A384 File Offset: 0x00038584
		[NullableContext(2)]
		public static string GetResourceQualityTierLabelOf(ETier? tier)
		{
			if (tier != null)
			{
				switch (tier.GetValueOrDefault())
				{
				case ETier.SD:
					return EResourceQualityTierLabel.Smooth.ToEnumString();
				case ETier.HD:
					return EResourceQualityTierLabel.HD.ToEnumString();
				case ETier.UHD:
					return EResourceQualityTierLabel.Ultimate.ToEnumString();
				}
			}
			return null;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0003A3CE File Offset: 0x000385CE
		[NullableContext(2)]
		public static string GetLocalResourceQualityTierLabel()
		{
			return HotFixManager.GetResourceQualityTierLabelOf(new ETier?(HotFixManager.LocalResourceQualityTier));
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0003A3DF File Offset: 0x000385DF
		public static EResourceQualityTierTextId GetResourceQualityTierTextId(ETier tier)
		{
			switch (tier)
			{
			case ETier.HD:
				return EResourceQualityTierTextId.HD;
			case ETier.UHD:
				return EResourceQualityTierTextId.Ultimate;
			}
			return EResourceQualityTierTextId.Smooth;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0003A3FC File Offset: 0x000385FC
		public static string GetResourceQualityTierName(ETier tier)
		{
			return LauncherConfigLib.Instance.GetHotPatchText(HotFixManager.GetResourceQualityTierTextId(tier).ToEnumString()) ?? "";
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0003A41C File Offset: 0x0003861C
		public static long GetResourceQualityTierInstalledSize(ETier tier)
		{
			return ResourceDiffUpdaterManager.Instance.GetTierPacksSavedSize(tier);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0003A42C File Offset: 0x0003862C
		public static string ByteToGbNumber(long byteValue)
		{
			double num = (double)byteValue;
			if (num <= 0.0)
			{
				return "0";
			}
			return (num / 1073741824.0).ToString("0.##");
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0003A468 File Offset: 0x00038668
		public UniTask Init(UObject worldContextObject)
		{
			HotFixManager.<Init>d__37 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.worldContextObject = worldContextObject;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<HotFixManager.<Init>d__37>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0003A4B4 File Offset: 0x000386B4
		public static UniTask SdkLogin(Action callBack, bool isFormView = false)
		{
			HotFixManager.<SdkLogin>d__41 <SdkLogin>d__;
			<SdkLogin>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SdkLogin>d__.callBack = callBack;
			<SdkLogin>d__.isFormView = isFormView;
			<SdkLogin>d__.<>1__state = -1;
			<SdkLogin>d__.<>t__builder.Start<HotFixManager.<SdkLogin>d__41>(ref <SdkLogin>d__);
			return <SdkLogin>d__.<>t__builder.Task;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x0003A4FF File Offset: 0x000386FF
		[Nullable(2)]
		public static FLoginStruct LoginData
		{
			[NullableContext(2)]
			get
			{
				return HotFixManager.HandleLoginData;
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0003A508 File Offset: 0x00038708
		public static void RefreshLoginStateOnLogin(FLoginStruct data)
		{
			if (HotFixManager.SdkLoginPromiseResolve == null)
			{
				LauncherLog.Instance.Error("触发HotFix阶段Sdk登录回调时，SdkLoginPromiseResolve为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (data.LoginCode < 1)
			{
				LauncherLog.Instance.Warn("HotFix阶段进行Sdk登录失败 - 直接全量下载资源", default(ReadOnlySpan<ValueTuple<string, object>>));
				HotFixManager.LaunchSubPackageHttpData = null;
				Action sdkLoginPromiseResolve = HotFixManager.SdkLoginPromiseResolve;
				if (sdkLoginPromiseResolve == null)
				{
					return;
				}
				sdkLoginPromiseResolve();
				return;
			}
			else
			{
				LauncherLog.Instance.Info("HotFix阶段进行Sdk登录成功", default(ReadOnlySpan<ValueTuple<string, object>>));
				HotFixManager.SaveHotFixSdkLoginState(true);
				Action onSdkLoginSuccessCallBack = HotFixManager.OnSdkLoginSuccessCallBack;
				if (onSdkLoginSuccessCallBack != null)
				{
					onSdkLoginSuccessCallBack();
				}
				HotFixManager.OnSdkLoginSuccessCallBack = null;
				HotFixManager.HandleLoginData = data;
				if (ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
				{
					HotFixManager.RequestSuggestServerData();
					return;
				}
				LauncherLog.Instance.Info("HotFix阶段进行Sdk登录成功后 - 分包灰度未命中", default(ReadOnlySpan<ValueTuple<string, object>>));
				Action sdkLoginPromiseResolve2 = HotFixManager.SdkLoginPromiseResolve;
				if (sdkLoginPromiseResolve2 == null)
				{
					return;
				}
				sdkLoginPromiseResolve2();
				return;
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0003A5E4 File Offset: 0x000387E4
		public static void SaveHotFixSdkLoginState(bool isLogin)
		{
			if (UKuroVariableFunctionLibrary.HasBoolValue("hot_fix_login"))
			{
				UKuroVariableFunctionLibrary.RemoveBoolValue("hot_fix_login");
			}
			UKuroVariableFunctionLibrary.SetBoolValue("hot_fix_login", isLogin);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0003A60C File Offset: 0x0003880C
		public static bool GetHotFixSdkLoginState()
		{
			if (!UKuroVariableFunctionLibrary.HasBoolValue("hot_fix_login"))
			{
				return false;
			}
			bool flag = false;
			return UKuroVariableFunctionLibrary.GetBoolValue("hot_fix_login", ref flag) && flag;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0003A63C File Offset: 0x0003883C
		private static void RequestSuggestServerData()
		{
			if (HotFixManager.HandleLoginData == null)
			{
				LauncherLog.Instance.Error("HotFix阶段RequestSuggestServerData失败，没有登录数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				HotFixManager.LaunchSubPackageHttpData = null;
				HotFixManager.SdkLoginPromiseResolve();
				return;
			}
			LauncherServer.Instance.RequestSuggestServerData(HotFixManager.HandleLoginData.Uid, HotFixManager.HandleLoginData.UserName, HotFixManager.HandleLoginData.Token, delegate(ILoginServersData result)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "HotFix阶段获取推荐服务器";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", result.name);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				HotFixManager.SuggestSeverData = result;
				HotFixManager.LoginUrlPollingIndex = 0;
				HotFixManager.GetLoginSubPackageDownLoadHttp();
			});
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0003A6C8 File Offset: 0x000388C8
		private static UniTask GetLoginSubPackageDownLoadHttp()
		{
			HotFixManager.<GetLoginSubPackageDownLoadHttp>d__54 <GetLoginSubPackageDownLoadHttp>d__;
			<GetLoginSubPackageDownLoadHttp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GetLoginSubPackageDownLoadHttp>d__.<>1__state = -1;
			<GetLoginSubPackageDownLoadHttp>d__.<>t__builder.Start<HotFixManager.<GetLoginSubPackageDownLoadHttp>d__54>(ref <GetLoginSubPackageDownLoadHttp>d__);
			return <GetLoginSubPackageDownLoadHttp>d__.<>t__builder.Task;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0003A704 File Offset: 0x00038904
		private static void ContinueLauncherSdkLogin(bool isSuccess)
		{
			if (isSuccess)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "HotFix阶段登录-等待Promise结束";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Resolve", HotFixManager.SdkLoginPromiseResolve);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				HotFixManager.SdkLoginPromiseResolve();
				return;
			}
			HotFixManager sdkLoginHotFixManagerHandle = HotFixManager.SdkLoginHotFixManagerHandle;
			if (sdkLoginHotFixManagerHandle == null)
			{
				return;
			}
			sdkLoginHotFixManagerHandle.ShowDialog(true, "HotFixTipsTitle", "SubPackageHttp_Fail_Content", "SubPackageHttp_Fail_ButtonText_0", "SubPackageHttp_Fail_ButtonText_1", null, Array.Empty<string>()).ContinueWith(delegate(bool result)
			{
				if (!result)
				{
					LauncherLog.Instance.Info("HotFix阶段获取分包资源Http失败，直接全量下载", default(ReadOnlySpan<ValueTuple<string, object>>));
					HotFixManager.LaunchSubPackageHttpData = null;
					HotFixManager.SdkLoginPromiseResolve();
					return;
				}
				LauncherLog.Instance.Info("HotFix阶段获取分包资源Http失败，尝试重新获取HTTP", default(ReadOnlySpan<ValueTuple<string, object>>));
				HotFixManager.LoginUrlPollingIndex++;
				HotFixManager.GetLoginSubPackageDownLoadHttp();
			}).Forget();
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0003A799 File Offset: 0x00038999
		public void RefreshViewLoginStateBeforeLogin()
		{
			this.SdkLoginFinish = false;
			this.WaitFrame(30).ContinueWith(delegate()
			{
				if (this.SdkLoginFinish)
				{
					return;
				}
				this.HotFixView.SetProgressActive(false);
				this.HotFixView.RefreshLoginStateBeforeLogin();
			});
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0003A7BC File Offset: 0x000389BC
		public void RefreshViewLoginStateOnLoginSuccess()
		{
			this.SdkLoginFinish = true;
			this.HotFixView.RefreshLoginStateOnLoginSuccess();
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0003A7D0 File Offset: 0x000389D0
		public unsafe static string BuildSubPackageHttp(string uId, string userName, string token)
		{
			string serverPort = HotFixManager.GetServerPort();
			string launchSdkLoginServerIp = HotFixManager.LaunchSdkLoginServerIp;
			string value = Uri.EscapeDataString(userName);
			string item = UKuroStaticLibrary.HashStringWithSHA1(token);
			LauncherLog instance = LauncherLog.Instance;
			string message = "BuildSubPackageHttp";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("uId", uId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("userName", userName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("token", item);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			FBasicInfo basicInfo = UKuroSDKManager.GetBasicInfo();
			string value2 = (basicInfo != null) ? basicInfo.DeviceId : null;
			string value3 = launchSdkLoginServerIp.StartsWith("http") ? launchSdkLoginServerIp : ("http://" + launchSdkLoginServerIp + ":" + serverPort);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(88, 6);
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			defaultInterpolatedStringHandler.AppendLiteral("/api/getResourcePackageInfo?loginType=1&userId=");
			defaultInterpolatedStringHandler.AppendFormatted(uId);
			defaultInterpolatedStringHandler.AppendLiteral("&userName=");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("&token=");
			defaultInterpolatedStringHandler.AppendFormatted(token);
			defaultInterpolatedStringHandler.AppendLiteral("&deviceId=");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral("&loginTraceId=");
			defaultInterpolatedStringHandler.AppendFormatted(LauncherSdk.Get().LauncherTraceId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0003A91C File Offset: 0x00038B1C
		public static string GetServerPort()
		{
			string result = "5500";
			string[] array = UKismetSystemLibrary.GetCommandLine().Split(' ', StringSplitOptions.None);
			int num = -1;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == "-LocalGameServerStartPort")
				{
					num = i;
					break;
				}
			}
			int num2;
			if (num == -1 || num + 1 >= array.Length || !int.TryParse(array[num + 1], out num2))
			{
				return result;
			}
			return (num2 + 1).ToString();
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0003A990 File Offset: 0x00038B90
		public UniTask CloseHotFix()
		{
			HotFixManager.<CloseHotFix>d__61 <CloseHotFix>d__;
			<CloseHotFix>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseHotFix>d__.<>4__this = this;
			<CloseHotFix>d__.<>1__state = -1;
			<CloseHotFix>d__.<>t__builder.Start<HotFixManager.<CloseHotFix>d__61>(ref <CloseHotFix>d__);
			return <CloseHotFix>d__.<>t__builder.Task;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0003A9D3 File Offset: 0x00038BD3
		public void Destroy()
		{
			this.HotFixView.Destroy();
			this.HotFixView = null;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0003A9E8 File Offset: 0x00038BE8
		public UniTask ShowInfo(bool bWithProgress, [Nullable(2)] string textId, params string[] args)
		{
			HotFixManager.<ShowInfo>d__63 <ShowInfo>d__;
			<ShowInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowInfo>d__.<>4__this = this;
			<ShowInfo>d__.bWithProgress = bWithProgress;
			<ShowInfo>d__.textId = textId;
			<ShowInfo>d__.args = args;
			<ShowInfo>d__.<>1__state = -1;
			<ShowInfo>d__.<>t__builder.Start<HotFixManager.<ShowInfo>d__63>(ref <ShowInfo>d__);
			return <ShowInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0003AA44 File Offset: 0x00038C44
		public UniTask ShowEmptyInfo()
		{
			HotFixManager.<ShowEmptyInfo>d__64 <ShowEmptyInfo>d__;
			<ShowEmptyInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowEmptyInfo>d__.<>4__this = this;
			<ShowEmptyInfo>d__.<>1__state = -1;
			<ShowEmptyInfo>d__.<>t__builder.Start<HotFixManager.<ShowEmptyInfo>d__64>(ref <ShowEmptyInfo>d__);
			return <ShowEmptyInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0003AA88 File Offset: 0x00038C88
		public UniTask UpdateProgress(bool bNeedWait, float rate, string textId, params string[] args)
		{
			HotFixManager.<UpdateProgress>d__65 <UpdateProgress>d__;
			<UpdateProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateProgress>d__.<>4__this = this;
			<UpdateProgress>d__.bNeedWait = bNeedWait;
			<UpdateProgress>d__.rate = rate;
			<UpdateProgress>d__.textId = textId;
			<UpdateProgress>d__.args = args;
			<UpdateProgress>d__.<>1__state = -1;
			<UpdateProgress>d__.<>t__builder.Start<HotFixManager.<UpdateProgress>d__65>(ref <UpdateProgress>d__);
			return <UpdateProgress>d__.<>t__builder.Task;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0003AAEC File Offset: 0x00038CEC
		public UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal)
		{
			HotFixManager.<UpdatePatchDownProgress>d__66 <UpdatePatchDownProgress>d__;
			<UpdatePatchDownProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdatePatchDownProgress>d__.<>4__this = this;
			<UpdatePatchDownProgress>d__.bNeedWait = bNeedWait;
			<UpdatePatchDownProgress>d__.rate = rate;
			<UpdatePatchDownProgress>d__.fileName = fileName;
			<UpdatePatchDownProgress>d__.speedText = speedText;
			<UpdatePatchDownProgress>d__.sizeCurrent = sizeCurrent;
			<UpdatePatchDownProgress>d__.sizeTotal = sizeTotal;
			<UpdatePatchDownProgress>d__.<>1__state = -1;
			<UpdatePatchDownProgress>d__.<>t__builder.Start<HotFixManager.<UpdatePatchDownProgress>d__66>(ref <UpdatePatchDownProgress>d__);
			return <UpdatePatchDownProgress>d__.<>t__builder.Task;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0003AB64 File Offset: 0x00038D64
		public unsafe void ShowToolView()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "SetToolWindowActive";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("value", true);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("this.HotFixView", this.HotFixView);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.HotFixView.SetToolWindowActive(true);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0003ABD6 File Offset: 0x00038DD6
		public void SetDownLoadActive(bool value)
		{
			this.HotFixView.SetDownLoadActive(value);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0003ABE4 File Offset: 0x00038DE4
		public void SetFreeSpaceTipsPopActive(bool value)
		{
			this.HotFixView.SetFreeSpaceTipsPopActive(value);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0003ABF4 File Offset: 0x00038DF4
		[return: Nullable(0)]
		public UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, [Nullable(2)] string leftId, [Nullable(2)] string rightId, [Nullable(2)] string middleId, params string[] contentArgs)
		{
			HotFixManager.<ShowDialog>d__70 <ShowDialog>d__;
			<ShowDialog>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowDialog>d__.<>4__this = this;
			<ShowDialog>d__.bSelect = bSelect;
			<ShowDialog>d__.titleId = titleId;
			<ShowDialog>d__.contentId = contentId;
			<ShowDialog>d__.leftId = leftId;
			<ShowDialog>d__.rightId = rightId;
			<ShowDialog>d__.middleId = middleId;
			<ShowDialog>d__.contentArgs = contentArgs;
			<ShowDialog>d__.<>1__state = -1;
			<ShowDialog>d__.<>t__builder.Start<HotFixManager.<ShowDialog>d__70>(ref <ShowDialog>d__);
			return <ShowDialog>d__.<>t__builder.Task;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0003AC73 File Offset: 0x00038E73
		private static bool IsErrorDialog(string contentId)
		{
			return HotFixManager.ErrorDialogIds.Contains(contentId);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0003AC80 File Offset: 0x00038E80
		private void ResetDialogState()
		{
			this.HasDialogBeenShowed = false;
			this.HasUploadErrorLogOnClose = false;
			this.HotFixView.SetConfirmationItemActive(false);
			this.HotFixView.SetRepairButtonEnable(false);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0003ACA8 File Offset: 0x00038EA8
		private void UploadErrorLog()
		{
			LauncherLogUpload.Instance.SendLog(null, new SendLogReason
			{
				Reason = ELauncherLogUploadReason.ErrorPopup
			});
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0003ACC1 File Offset: 0x00038EC1
		[NullableContext(2)]
		public void ShowNoticeWindow(string logMsg = null)
		{
			LauncherNoticeUtils.Instance.OpenNotice(logMsg);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0003ACCE File Offset: 0x00038ECE
		public static void ShowNoticeWindowByUser()
		{
			LauncherNoticeUtils.Instance.OpenNoticeByUser();
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0003ACDC File Offset: 0x00038EDC
		public UniTask WaitFrame(int num = 1)
		{
			HotFixManager.<WaitFrame>d__76 <WaitFrame>d__;
			<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitFrame>d__.num = num;
			<WaitFrame>d__.<>1__state = -1;
			<WaitFrame>d__.<>t__builder.Start<HotFixManager.<WaitFrame>d__76>(ref <WaitFrame>d__);
			return <WaitFrame>d__.<>t__builder.Task;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0003AD1F File Offset: 0x00038F1F
		private void ShowContainerItemAndCloseConfirmationItem()
		{
			this.HotFixView.SetContainerItemActive(true);
			this.HotFixView.SetConfirmationItemActive(false);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0003AD3C File Offset: 0x00038F3C
		[NullableContext(0)]
		private UniTask<bool> InitConfirmItemLeftRight(bool canCloseOff)
		{
			HotFixManager.<InitConfirmItemLeftRight>d__78 <InitConfirmItemLeftRight>d__;
			<InitConfirmItemLeftRight>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<InitConfirmItemLeftRight>d__.<>4__this = this;
			<InitConfirmItemLeftRight>d__.canCloseOff = canCloseOff;
			<InitConfirmItemLeftRight>d__.<>1__state = -1;
			<InitConfirmItemLeftRight>d__.<>t__builder.Start<HotFixManager.<InitConfirmItemLeftRight>d__78>(ref <InitConfirmItemLeftRight>d__);
			return <InitConfirmItemLeftRight>d__.<>t__builder.Task;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0003AD88 File Offset: 0x00038F88
		[NullableContext(0)]
		private UniTask<bool> InitConfirmItemMiddle(bool canCloseOff)
		{
			HotFixManager.<InitConfirmItemMiddle>d__79 <InitConfirmItemMiddle>d__;
			<InitConfirmItemMiddle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<InitConfirmItemMiddle>d__.<>4__this = this;
			<InitConfirmItemMiddle>d__.canCloseOff = canCloseOff;
			<InitConfirmItemMiddle>d__.<>1__state = -1;
			<InitConfirmItemMiddle>d__.<>t__builder.Start<HotFixManager.<InitConfirmItemMiddle>d__79>(ref <InitConfirmItemMiddle>d__);
			return <InitConfirmItemMiddle>d__.<>t__builder.Task;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0003ADD3 File Offset: 0x00038FD3
		private void CloseConfirmation()
		{
			if (this.HotFixView.GetUploadLogToggleOn() && !this.HasUploadErrorLogOnClose)
			{
				this.HasUploadErrorLogOnClose = true;
				this.UploadErrorLog();
			}
			this.HotFixView.SetConfirmationItemActive(false);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0003AE04 File Offset: 0x00039004
		[NullableContext(0)]
		public UniTask<bool> ShowPrivacyProtocolView()
		{
			HotFixManager.<ShowPrivacyProtocolView>d__81 <ShowPrivacyProtocolView>d__;
			<ShowPrivacyProtocolView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowPrivacyProtocolView>d__.<>4__this = this;
			<ShowPrivacyProtocolView>d__.<>1__state = -1;
			<ShowPrivacyProtocolView>d__.<>t__builder.Start<HotFixManager.<ShowPrivacyProtocolView>d__81>(ref <ShowPrivacyProtocolView>d__);
			return <ShowPrivacyProtocolView>d__.<>t__builder.Task;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0003AE48 File Offset: 0x00039048
		public static void SetLocalText(UUIText uiText, [Nullable(2)] string textTableId, params string[] args)
		{
			string hotPatchText = LauncherConfigLib.Instance.GetHotPatchText(textTableId);
			if (hotPatchText == null)
			{
				uiText.SetText("", true);
				return;
			}
			string text = hotPatchText;
			if (args != null)
			{
				for (int i = 0; i < args.Length; i++)
				{
					string separator = args[i];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("{");
					defaultInterpolatedStringHandler.AppendFormatted<int>(i);
					defaultInterpolatedStringHandler.AppendLiteral("}");
					string separator2 = defaultInterpolatedStringHandler.ToStringAndClear();
					text = string.Join(separator, text.Split(separator2, StringSplitOptions.None));
				}
			}
			uiText.SetText(text, true);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0003AED0 File Offset: 0x000390D0
		public void TryShowNoticeBtn()
		{
			bool noticeBtnActive = LauncherNoticeUtils.Instance.CheckGrayBoxHit();
			HotFixUiView hotFixView = this.HotFixView;
			if (hotFixView == null)
			{
				return;
			}
			hotFixView.SetNoticeBtnActive(noticeBtnActive);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0003AEFC File Offset: 0x000390FC
		public static string ByteConverter(long byte_)
		{
			if (byte_ < 0L)
			{
				return "<0.01MB";
			}
			double num = (double)byte_;
			double num2 = 1073741824.0;
			double num3 = (num >= num2) ? (num / 1073741824.0) : (num / 1048576.0);
			string str = (num >= num2) ? "GB" : "MB";
			return num3.ToString("0.##") + " " + str;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0003AF68 File Offset: 0x00039168
		public static List<int> GetCanCleanSceneIdList()
		{
			List<int> list = new List<int>();
			if (!ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
			{
				return list;
			}
			HashSet<int> blockIds = ResourceDiffUpdaterManager.Instance.BlockModule.GetCoreBlockIds(ResourceDiffUpdaterManager.Instance.Context);
			Func<int, bool> <>9__0;
			foreach (DownLoadSubPackageRow downLoadSubPackageRow in PackSelectionTables.DownLoadSubPackageTableInstance.GetAll())
			{
				if (downLoadSubPackageRow.Type == 2)
				{
					IEnumerable<int> area = downLoadSubPackageRow.Area;
					Func<int, bool> predicate;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((int item) => blockIds.Contains(item)));
					}
					if (!area.Any(predicate))
					{
						list.Add(downLoadSubPackageRow.Id);
					}
				}
			}
			return list;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0003B038 File Offset: 0x00039238
		public static long GetCanCleanVideoSpace()
		{
			HashSet<int> unusedVideos = ResourceDiffUpdaterManager.Instance.VideoModule.GetUnusedVideos(ResourceDiffUpdaterManager.Instance.Context.FinishedQuests);
			return ResourceDiffUpdaterManager.Instance.VideoModule.GetLocalSizeByVideoIds(unusedVideos);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0003B074 File Offset: 0x00039274
		public static long GetSubPackageSpace(int packId)
		{
			DownLoadSubPackageRow byId = PackSelectionTables.DownLoadSubPackageTableInstance.GetById(packId);
			List<int> list = ((byId != null) ? byId.Area : null) ?? new List<int>();
			HashSet<string> hashSet = new HashSet<string>();
			foreach (int blockId in list)
			{
				string blockPackName = ResourceDiffUpdaterManager.Instance.BlockModule.GetBlockPackName(blockId);
				if (blockPackName != null)
				{
					hashSet.Add(blockPackName);
				}
			}
			return ResourceDiffUpdaterManager.Instance.BlockModule.GetLocalSize(hashSet.ToList<string>());
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0003B114 File Offset: 0x00039314
		public static long GetAllCanClearSpace()
		{
			List<int> canCleanSceneIdList = HotFixManager.GetCanCleanSceneIdList();
			long num = 0L;
			foreach (int packId in canCleanSceneIdList)
			{
				num += HotFixManager.GetSubPackageSpace(packId);
			}
			long canCleanVideoSpace = HotFixManager.GetCanCleanVideoSpace();
			num += canCleanVideoSpace;
			num += HotFixManager.GetAllCanClearVoiceSpace();
			return num;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0003B180 File Offset: 0x00039380
		public static long GetAllCanClearVoiceSpace()
		{
			long num = 0L;
			string packageAudioLanguage = LauncherLanguageLib.Instance.GetPackageAudioLanguage();
			IEnumerable<LaunchLangDefine> allLanguageDefines = LauncherLanguageLib.Instance.GetAllLanguageDefines();
			HashSet<string> hashSet = new HashSet<string>();
			foreach (LaunchLangDefine launchLangDefine in allLanguageDefines)
			{
				string audioCode = launchLangDefine.AudioCode;
				if (!hashSet.Contains(audioCode))
				{
					hashSet.Add(audioCode);
					if (!(audioCode == packageAudioLanguage))
					{
						LanguageUpdater updater = LanguageUpdateManager.Instance.GetUpdater(audioCode);
						if (updater != null && updater.Status == ELanguageDownloadStatus.Done && ResourceDiffUpdaterManager.Instance.VoiceModule.GetLocalSizeByAudioCode(audioCode) > 0L)
						{
							num += updater.TotalDiskSize;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0003B240 File Offset: 0x00039440
		public static void ClearSubPackage(List<int> sceneIdList, bool clearVideo)
		{
			long num = clearVideo ? HotFixManager.GetCanCleanVideoSpace() : 0L;
			foreach (int packId in sceneIdList)
			{
				num += HotFixManager.GetSubPackageSpace(packId);
			}
			List<MobileResCleanUpStateLogContentData> list = new List<MobileResCleanUpStateLogContentData>();
			HashSet<string> hashSet = new HashSet<string>();
			foreach (int id in sceneIdList)
			{
				foreach (int num2 in PackSelectionTables.DownLoadSubPackageTableInstance.GetById(id).Area)
				{
					string blockPackName = ResourceDiffUpdaterManager.Instance.BlockModule.GetBlockPackName(num2);
					if (blockPackName != null)
					{
						hashSet.Add(blockPackName);
						list.Add(new MobileResCleanUpStateLogContentData
						{
							Type = 1,
							Id = num2
						});
					}
				}
			}
			ResourceDiffUpdaterManager.Instance.BlockModule.Delete(hashSet.ToList<string>());
			if (clearVideo)
			{
				HashSet<int> unusedVideos = ResourceDiffUpdaterManager.Instance.VideoModule.GetUnusedVideos(ResourceDiffUpdaterManager.Instance.Context.FinishedQuests);
				foreach (int id2 in unusedVideos)
				{
					list.Add(new MobileResCleanUpStateLogContentData
					{
						Type = 2,
						Id = id2
					});
				}
				ResourceDiffUpdaterManager.Instance.VideoModule.DeleteByVideoIds(unusedVideos);
			}
			int cleanUpSpace = (int)(num / 1048576L);
			FLoginStruct loginData = HotFixManager.LoginData;
			new MobileResCleanUpStateLog(cleanUpSpace, ((loginData != null) ? loginData.Uid : null) ?? "", ResourceDiffUpdaterManager.Instance.TraceId.ToString(), list, 1, null).Report();
			FLoginStruct loginData2 = HotFixManager.LoginData;
			new MobileResCleanUpFinishStateLog(((loginData2 != null) ? loginData2.Uid : null) ?? "", ResourceDiffUpdaterManager.Instance.TraceId.ToString(), null).Report();
		}

		// Token: 0x04000449 RID: 1097
		private static readonly HashSet<string> ErrorDialogIds;

		// Token: 0x0400044A RID: 1098
		private const long GB_BYTES = 1073741824L;

		// Token: 0x0400044B RID: 1099
		private const long MB_BYTES = 1048576L;

		// Token: 0x0400044C RID: 1100
		private const int LOGINURL_TIMEOUT = 3;

		// Token: 0x0400044D RID: 1101
		private const int LOGIN_BUTTON_SHOW_TIME = 30;

		// Token: 0x0400044E RID: 1102
		private const int LOGIN_SUCCESS = 1;

		// Token: 0x0400044F RID: 1103
		private const string HOTFIX_LOGIN = "hot_fix_login";

		// Token: 0x04000450 RID: 1104
		[Nullable(2)]
		private HotFixUiView HotFixView;

		// Token: 0x04000451 RID: 1105
		private ENetworkType? NetworkType;

		// Token: 0x04000452 RID: 1106
		private bool HasDialogBeenShowed;

		// Token: 0x04000453 RID: 1107
		private bool HasUploadErrorLogOnClose;

		// Token: 0x04000454 RID: 1108
		public static bool HandleAutoClear = false;

		// Token: 0x04000455 RID: 1109
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyList<ETier> mobileResourceQualityTiers = new ETier[]
		{
			ETier.SD,
			ETier.HD
		};

		// Token: 0x04000456 RID: 1110
		public static ETier SelectResourceQualityTier;

		// Token: 0x04000457 RID: 1111
		[Nullable(2)]
		public static Action<ETier, ETier> ApplyTierChangeHandler = null;

		// Token: 0x04000458 RID: 1112
		[Nullable(2)]
		public static Action<ETier, ETier> MobilePreDownloadApplyTierChangeHandler = null;

		// Token: 0x04000459 RID: 1113
		[Nullable(2)]
		private static HotFixManager SdkLoginHotFixManagerHandle = null;

		// Token: 0x0400045A RID: 1114
		[Nullable(2)]
		private static Action SdkLoginPromiseResolve = null;

		// Token: 0x0400045B RID: 1115
		[Nullable(2)]
		private static Action OnSdkLoginSuccessCallBack = null;

		// Token: 0x0400045C RID: 1116
		public static string LaunchSdkLoginServerIp = "";

		// Token: 0x0400045D RID: 1117
		[Nullable(2)]
		public static SubPackageHttpData LaunchSubPackageHttpData = null;

		// Token: 0x0400045E RID: 1118
		[Nullable(2)]
		private static FLoginStruct HandleLoginData = null;

		// Token: 0x0400045F RID: 1119
		private static int GetLoginSubPackageDownLoadHttpTimes = 0;

		// Token: 0x04000460 RID: 1120
		[Nullable(2)]
		private static ILoginServersData SuggestSeverData = null;

		// Token: 0x04000461 RID: 1121
		private static int LoginUrlPollingIndex = 0;

		// Token: 0x04000462 RID: 1122
		private bool SdkLoginFinish;

		// Token: 0x04000463 RID: 1123
		[Nullable(2)]
		public static UniTaskCompletionSource DownLoadViewChosePromise = null;

		// Token: 0x04000464 RID: 1124
		[Nullable(2)]
		public static Action DownLoadViewChoseDoneCallBack = null;

		// Token: 0x04000465 RID: 1125
		[Nullable(2)]
		public static UniTaskCompletionSource FreeSpaceCheckPromise = null;

		// Token: 0x04000466 RID: 1126
		[Nullable(2)]
		public static Action FreeSpaceCheckDoneCallBack = null;

		// Token: 0x04000467 RID: 1127
		public static EVideoResSizeType DownLoadType;

		// Token: 0x04000468 RID: 1128
		public static EResUpdateType ResDownLoadType;

		// Token: 0x04000469 RID: 1129
		public static long NeedDownLoadByte = 0L;

		// Token: 0x02000368 RID: 872
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04001187 RID: 4487
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<FLoginStruct> <0>__RefreshLoginStateOnLogin;
		}
	}
}
