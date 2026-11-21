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
	// Token: 0x020001A8 RID: 424
	[NullableContext(1)]
	[Nullable(0)]
	public class PackageUpdateController : Singleton
	{
		// Token: 0x06000BC2 RID: 3010 RVA: 0x0004B67C File Offset: 0x0004987C
		public UniTask TryOpenPackageUpdateTipsView(HotFixManager view)
		{
			PackageUpdateController.<TryOpenPackageUpdateTipsView>d__15 <TryOpenPackageUpdateTipsView>d__;
			<TryOpenPackageUpdateTipsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryOpenPackageUpdateTipsView>d__.<>4__this = this;
			<TryOpenPackageUpdateTipsView>d__.view = view;
			<TryOpenPackageUpdateTipsView>d__.<>1__state = -1;
			<TryOpenPackageUpdateTipsView>d__.<>t__builder.Start<PackageUpdateController.<TryOpenPackageUpdateTipsView>d__15>(ref <TryOpenPackageUpdateTipsView>d__);
			return <TryOpenPackageUpdateTipsView>d__.<>t__builder.Task;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0004B6C8 File Offset: 0x000498C8
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

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0004B784 File Offset: 0x00049984
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

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0004B862 File Offset: 0x00049A62
		public void TryOpenParallelPackageUpdateUrl()
		{
			this.InitParam();
			this.HttpParallelUpdateDelegate = DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(this.OnHttpParallelCallBack));
			this.OpenParallelPackageUpdateUrl();
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0004B888 File Offset: 0x00049A88
		private void TryOpenUrl(IUpdateUrl prefix, string extraParam, FHttpResponseHandle httpDelegate)
		{
			string url = prefix.MainUrl + "?" + extraParam;
			TMap<string, string> defaultHeader = UKuroHttp.GetDefaultHeader();
			UKuroHttp.Get(url, defaultHeader, httpDelegate, 0f);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0004B8BC File Offset: 0x00049ABC
		private void OnHttpDescCallBack(bool state, int code, string data)
		{
			EntryJson cdnReturnConfigInfo = BaseConfigController.Instance.GetCdnReturnConfigInfo();
			this.OnHttpCallBack(cdnReturnConfigInfo.PackageUpdateDescUrl, this.ExtraParam, state, code, data);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0004B8EC File Offset: 0x00049AEC
		private void OnHttpUpdateCallBack(bool state, int code, string data)
		{
			EntryJson cdnReturnConfigInfo = BaseConfigController.Instance.GetCdnReturnConfigInfo();
			this.OnHttpCallBack(cdnReturnConfigInfo.PackageUpdateUrl, this.ExtraParam, state, code, data);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0004B91C File Offset: 0x00049B1C
		private void OnHttpParallelCallBack(bool state, int code, string data)
		{
			EntryJson cdnReturnConfigInfo = BaseConfigController.Instance.GetCdnReturnConfigInfo();
			this.OnHttpCallBack(cdnReturnConfigInfo.PackageUpdateUrl, this.ExtraParam, state, code, data);
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool, int, string>(this.OnHttpParallelCallBack));
			this.HttpParallelUpdateDelegate = null;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0004B964 File Offset: 0x00049B64
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

		// Token: 0x06000BCB RID: 3019 RVA: 0x0004BA08 File Offset: 0x00049C08
		private void OpenParallelPackageUpdateUrl()
		{
			IUpdateUrl packageUpdateUrl = BaseConfigController.Instance.GetCdnReturnConfigInfo().PackageUpdateUrl;
			this.TryOpenUrl(packageUpdateUrl, this.ExtraParam, this.HttpParallelUpdateDelegate);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0004BA38 File Offset: 0x00049C38
		private UniTask OnGetPackageUpdateData(HotFixManager view)
		{
			PackageUpdateController.<OnGetPackageUpdateData>d__25 <OnGetPackageUpdateData>d__;
			<OnGetPackageUpdateData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnGetPackageUpdateData>d__.<>4__this = this;
			<OnGetPackageUpdateData>d__.view = view;
			<OnGetPackageUpdateData>d__.<>1__state = -1;
			<OnGetPackageUpdateData>d__.<>t__builder.Start<PackageUpdateController.<OnGetPackageUpdateData>d__25>(ref <OnGetPackageUpdateData>d__);
			return <OnGetPackageUpdateData>d__.<>t__builder.Task;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0004BA84 File Offset: 0x00049C84
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

		// Token: 0x06000BCE RID: 3022 RVA: 0x0004BAB8 File Offset: 0x00049CB8
		private UniTask CheckIfHaveNewVersionAndShowTips(HotFixManager view, bool canSelect, Action leftCallBack, Action rightCallBack, Action middleCallBack)
		{
			PackageUpdateController.<CheckIfHaveNewVersionAndShowTips>d__27 <CheckIfHaveNewVersionAndShowTips>d__;
			<CheckIfHaveNewVersionAndShowTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckIfHaveNewVersionAndShowTips>d__.view = view;
			<CheckIfHaveNewVersionAndShowTips>d__.canSelect = canSelect;
			<CheckIfHaveNewVersionAndShowTips>d__.leftCallBack = leftCallBack;
			<CheckIfHaveNewVersionAndShowTips>d__.rightCallBack = rightCallBack;
			<CheckIfHaveNewVersionAndShowTips>d__.middleCallBack = middleCallBack;
			<CheckIfHaveNewVersionAndShowTips>d__.<>1__state = -1;
			<CheckIfHaveNewVersionAndShowTips>d__.<>t__builder.Start<PackageUpdateController.<CheckIfHaveNewVersionAndShowTips>d__27>(ref <CheckIfHaveNewVersionAndShowTips>d__);
			return <CheckIfHaveNewVersionAndShowTips>d__.<>t__builder.Task;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0004BB1D File Offset: 0x00049D1D
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

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0004BB40 File Offset: 0x00049D40
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0004BB42 File Offset: 0x00049D42
		public static void ResetStaticDefaultValue()
		{
			PackageUpdateController instance = PackageUpdateController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PackageUpdateController._instance = null;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0004BB5B File Offset: 0x00049D5B
		static PackageUpdateController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PackageUpdateController.CreateStaticDefaultValue), new Action(PackageUpdateController.ResetStaticDefaultValue));
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0004BB7C File Offset: 0x00049D7C
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

		// Token: 0x0400076D RID: 1901
		private const string TAPPACKAGEID = "A1425";

		// Token: 0x0400076E RID: 1902
		private const string CNIOS = "A1351";

		// Token: 0x0400076F RID: 1903
		private const string GLOBALIOS = "A1725";

		// Token: 0x04000770 RID: 1904
		private const string GLOBALANDROID = "A1723";

		// Token: 0x04000771 RID: 1905
		private const string CNMAC = "A1475";

		// Token: 0x04000772 RID: 1906
		private const string GLOBALMAC = "A1828";

		// Token: 0x04000773 RID: 1907
		private const string CNOPENHARMONY = "A1529";

		// Token: 0x04000774 RID: 1908
		private bool TapInitState;

		// Token: 0x04000775 RID: 1909
		[Nullable(2)]
		private FHttpResponseHandle HttpUpdateDelegate;

		// Token: 0x04000776 RID: 1910
		[Nullable(2)]
		private FHttpResponseHandle HttpUpdateDescDelegate;

		// Token: 0x04000777 RID: 1911
		[Nullable(2)]
		private FHttpResponseHandle HttpParallelUpdateDelegate;

		// Token: 0x04000778 RID: 1912
		private string ExtraParam = "";

		// Token: 0x04000779 RID: 1913
		private string CurrentPackageId = "";

		// Token: 0x0400077A RID: 1914
		private readonly Dictionary<string, string> PkgIdLinkMap;

		// Token: 0x0400077B RID: 1915
		private readonly string[] PlayStationPackageIdList;

		// Token: 0x0400077C RID: 1916
		[Nullable(2)]
		private static PackageUpdateController _instance;
	}
}
