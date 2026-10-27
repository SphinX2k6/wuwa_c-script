using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.PackageUpdate
{
	// Token: 0x020001A4 RID: 420
	[NullableContext(1)]
	[Nullable(0)]
	public class PackageUpdateController : Singleton
	{
		// Token: 0x06000B8B RID: 2955 RVA: 0x00048E8C File Offset: 0x0004708C
		public UniTask TryOpenPackageUpdateTipsView(HotFixManager view)
		{
			PackageUpdateController.<TryOpenPackageUpdateTipsView>d__14 <TryOpenPackageUpdateTipsView>d__;
			<TryOpenPackageUpdateTipsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryOpenPackageUpdateTipsView>d__.<>4__this = this;
			<TryOpenPackageUpdateTipsView>d__.view = view;
			<TryOpenPackageUpdateTipsView>d__.<>1__state = -1;
			<TryOpenPackageUpdateTipsView>d__.<>t__builder.Start<PackageUpdateController.<TryOpenPackageUpdateTipsView>d__14>(ref <TryOpenPackageUpdateTipsView>d__);
			return <TryOpenPackageUpdateTipsView>d__.<>t__builder.Task;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00048ED8 File Offset: 0x000470D8
		private unsafe void InitParam()
		{
			string text = "";
			if (HotPatchKuroSdk.Instance.CanUseSdk())
			{
				text = UKuroSDKManager.GetPackageId();
			}
			else if (PlatformSdkManagerNew.Instance.GetPlatformSdk().GetPackageId() != "")
			{
				text = PlatformSdkManagerNew.Instance.GetPlatformSdk().GetPackageId();
			}
			this.CurrentPackageId = text;
			this.ExtraParam = this.GetExtraParam();
			LauncherLog instance = LauncherLog.Instance;
			string message = "整包配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("currentPackageId", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("exParam", this.ExtraParam);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00048F94 File Offset: 0x00047194
		private string GetExtraParam()
		{
			string packageConfigOrDefault = BaseConfigController.Instance.GetPackageConfigOrDefault("PatchVersion", null);
			string value = KuroApplication.IniPlatformName();
			string appVersion = UKuroLauncherLibrary.GetAppVersion();
			string publicValue = BaseConfigController.Instance.GetPublicValue("SdkArea");
			string value2 = LauncherLanguageLib.Instance.PackageLanguage ?? "";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 6);
			defaultInterpolatedStringHandler.AppendLiteral("packageId=");
			defaultInterpolatedStringHandler.AppendFormatted(this.CurrentPackageId);
			defaultInterpolatedStringHandler.AppendLiteral("&platform=");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("&appVersion=");
			defaultInterpolatedStringHandler.AppendFormatted(appVersion);
			defaultInterpolatedStringHandler.AppendLiteral("&patchVersion=");
			defaultInterpolatedStringHandler.AppendFormatted(packageConfigOrDefault);
			defaultInterpolatedStringHandler.AppendLiteral("&area=");
			defaultInterpolatedStringHandler.AppendFormatted(publicValue);
			defaultInterpolatedStringHandler.AppendLiteral("&lang=");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00049072 File Offset: 0x00047272
		public void TryOpenParallelPackageUpdateUrl()
		{
			this.InitParam();
			this.HttpParallelUpdateDelegate = DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(this.OnHttpParallelCallBack));
			this.OpenParallelPackageUpdateUrl();
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00049098 File Offset: 0x00047298
		private void TryOpenUrl(IUpdateUrl prefix, string extraParam, FHttpResponseHandle httpDelegate)
		{
			string url = prefix.MainUrl + "?" + extraParam;
			TMap<string, string> defaultHeader = UKuroHttp.GetDefaultHeader();
			UKuroHttp.Get(url, defaultHeader, httpDelegate, 0f);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000490CC File Offset: 0x000472CC
		private void OnHttpDescCallBack(bool state, int code, string data)
		{
			EntryJson cdnReturnConfigInfo = BaseConfigController.Instance.GetCdnReturnConfigInfo();
			this.OnHttpCallBack(cdnReturnConfigInfo.PackageUpdateDescUrl, this.ExtraParam, state, code, data);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000490FC File Offset: 0x000472FC
		private void OnHttpUpdateCallBack(bool state, int code, string data)
		{
			EntryJson cdnReturnConfigInfo = BaseConfigController.Instance.GetCdnReturnConfigInfo();
			this.OnHttpCallBack(cdnReturnConfigInfo.PackageUpdateUrl, this.ExtraParam, state, code, data);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0004912C File Offset: 0x0004732C
		private void OnHttpParallelCallBack(bool state, int code, string data)
		{
			EntryJson cdnReturnConfigInfo = BaseConfigController.Instance.GetCdnReturnConfigInfo();
			this.OnHttpCallBack(cdnReturnConfigInfo.PackageUpdateUrl, this.ExtraParam, state, code, data);
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool, int, string>(this.OnHttpParallelCallBack));
			this.HttpParallelUpdateDelegate = null;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00049174 File Offset: 0x00047374
		private void OnHttpCallBack(IUpdateUrl prefix, string extraParam, bool state, int code, string data)
		{
			if (code != 200)
			{
				string text = prefix.SubUrl + "?" + extraParam;
				LauncherLog instance = LauncherLog.Instance;
				string message = "打开链接";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("updateData!.descUrl", text);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenExternalUrl(text);
				return;
			}
			string text2 = prefix.MainUrl + "?" + extraParam;
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "打开链接";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("updateData!.descUrl", text2);
			instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenExternalUrl(text2);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00049218 File Offset: 0x00047418
		private void OpenParallelPackageUpdateUrl()
		{
			IUpdateUrl packageUpdateUrl = BaseConfigController.Instance.GetCdnReturnConfigInfo().PackageUpdateUrl;
			this.TryOpenUrl(packageUpdateUrl, this.ExtraParam, this.HttpParallelUpdateDelegate);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00049248 File Offset: 0x00047448
		private UniTask OnGetPackageUpdateData(HotFixManager view)
		{
			PackageUpdateController.<OnGetPackageUpdateData>d__24 <OnGetPackageUpdateData>d__;
			<OnGetPackageUpdateData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnGetPackageUpdateData>d__.<>4__this = this;
			<OnGetPackageUpdateData>d__.view = view;
			<OnGetPackageUpdateData>d__.<>1__state = -1;
			<OnGetPackageUpdateData>d__.<>t__builder.Start<PackageUpdateController.<OnGetPackageUpdateData>d__24>(ref <OnGetPackageUpdateData>d__);
			return <OnGetPackageUpdateData>d__.<>t__builder.Task;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00049294 File Offset: 0x00047494
		private bool PlayStationPackageIdListContains(string id)
		{
			for (int i = 0; i < this.PlayStationPackageIdList.Length; i++)
			{
				if (this.PlayStationPackageIdList[i] == id)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x000492C8 File Offset: 0x000474C8
		private UniTask CheckIfHaveNewVersionAndShowTips(HotFixManager view, bool canSelect, Action leftCallBack, Action rightCallBack, Action middleCallBack)
		{
			PackageUpdateController.<CheckIfHaveNewVersionAndShowTips>d__26 <CheckIfHaveNewVersionAndShowTips>d__;
			<CheckIfHaveNewVersionAndShowTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckIfHaveNewVersionAndShowTips>d__.view = view;
			<CheckIfHaveNewVersionAndShowTips>d__.canSelect = canSelect;
			<CheckIfHaveNewVersionAndShowTips>d__.leftCallBack = leftCallBack;
			<CheckIfHaveNewVersionAndShowTips>d__.rightCallBack = rightCallBack;
			<CheckIfHaveNewVersionAndShowTips>d__.middleCallBack = middleCallBack;
			<CheckIfHaveNewVersionAndShowTips>d__.<>1__state = -1;
			<CheckIfHaveNewVersionAndShowTips>d__.<>t__builder.Start<PackageUpdateController.<CheckIfHaveNewVersionAndShowTips>d__26>(ref <CheckIfHaveNewVersionAndShowTips>d__);
			return <CheckIfHaveNewVersionAndShowTips>d__.<>t__builder.Task;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0004932D File Offset: 0x0004752D
		public static PackageUpdateController Instance
		{
			get
			{
				if (PackageUpdateController._instance == null)
				{
					PackageUpdateController._instance = new PackageUpdateController();
					PackageUpdateController._instance.OnInit();
				}
				return PackageUpdateController._instance;
			}
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00049350 File Offset: 0x00047550
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00049352 File Offset: 0x00047552
		public static void ResetStaticDefaultValue()
		{
			PackageUpdateController instance = PackageUpdateController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PackageUpdateController._instance = null;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0004936B File Offset: 0x0004756B
		static PackageUpdateController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PackageUpdateController.CreateStaticDefaultValue), new Action(PackageUpdateController.ResetStaticDefaultValue));
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0004938C File Offset: 0x0004758C
		public PackageUpdateController()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["A1351"] = "https://apps.apple.com/cn/app/%E9%B8%A3%E6%BD%AE/id6450693428";
			dictionary["A1725"] = "https://apps.apple.com/us/app/wuthering-waves/id6475033368";
			dictionary["A1723"] = "https://play.google.com/store/apps/details?id=com.kurogame.wutheringwaves.global";
			dictionary["A1475"] = "https://apps.apple.com/cn/app/%E9%B8%A3%E6%BD%AE/id6450693428";
			dictionary["A1828"] = "https://apps.apple.com/us/app/wuthering-waves/id6475033368";
			this.PkgIdLinkMap = dictionary;
			this.PlayStationPackageIdList = new string[]
			{
				"A1768",
				"A1788",
				"A1801",
				"A1865"
			};
			base..ctor();
		}

		// Token: 0x04000731 RID: 1841
		private const string TAPPACKAGEID = "A1425";

		// Token: 0x04000732 RID: 1842
		private const string CNIOS = "A1351";

		// Token: 0x04000733 RID: 1843
		private const string GLOBALIOS = "A1725";

		// Token: 0x04000734 RID: 1844
		private const string GLOBALANDROID = "A1723";

		// Token: 0x04000735 RID: 1845
		private const string CNMAC = "A1475";

		// Token: 0x04000736 RID: 1846
		private const string GLOBALMAC = "A1828";

		// Token: 0x04000737 RID: 1847
		private bool TapInitState;

		// Token: 0x04000738 RID: 1848
		[Nullable(2)]
		private FHttpResponseHandle HttpUpdateDelegate;

		// Token: 0x04000739 RID: 1849
		[Nullable(2)]
		private FHttpResponseHandle HttpUpdateDescDelegate;

		// Token: 0x0400073A RID: 1850
		[Nullable(2)]
		private FHttpResponseHandle HttpParallelUpdateDelegate;

		// Token: 0x0400073B RID: 1851
		private string ExtraParam = "";

		// Token: 0x0400073C RID: 1852
		private string CurrentPackageId = "";

		// Token: 0x0400073D RID: 1853
		private readonly Dictionary<string, string> PkgIdLinkMap;

		// Token: 0x0400073E RID: 1854
		private readonly string[] PlayStationPackageIdList;

		// Token: 0x0400073F RID: 1855
		[Nullable(2)]
		private static PackageUpdateController _instance;
	}
}
