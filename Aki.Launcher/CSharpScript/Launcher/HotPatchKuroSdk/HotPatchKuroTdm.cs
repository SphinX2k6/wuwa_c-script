using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001DA RID: 474
	[NullableContext(1)]
	[Nullable(0)]
	public static class HotPatchKuroTdm
	{
		// Token: 0x06000C95 RID: 3221 RVA: 0x0004CE2A File Offset: 0x0004B02A
		public static bool IfCanUseTdm()
		{
			return UKuroStaticLibrary.IsModuleLoaded("KuroTDM");
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0004CE3C File Offset: 0x0004B03C
		public unsafe static void Init()
		{
			if (!HotPatchKuroTdm.IfCanUseTdm())
			{
				LauncherLog.Instance.Info("不可使用tdm 初始化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			bool flag = BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
			if (flag)
			{
				return;
			}
			if (!UKuroLauncherLibrary.IsFirstIntoLauncher())
			{
				return;
			}
			if (Platform.Instance.IsIOSPlatform())
			{
				UTDMStaticLibrary.RegisterLifeCycle();
			}
			string key = "TDMAppId";
			string key2 = "TDMAppKey";
			string text = "kuro";
			if (HotPatchKuroSdk.Instance.CanUseSdk())
			{
				text = UKuroSDKManager.GetPackageId();
			}
			string publicValue = BaseConfigController.Instance.GetPublicValue(key);
			string publicValue2 = BaseConfigController.Instance.GetPublicValue(key2);
			LauncherLog instance = LauncherLog.Instance;
			string message = "Init TDMParam";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("appIdValue", publicValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("appChannelValue", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("appKeyValue", publicValue2);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			LauncherLog.Instance.Info("SetRouterAddress", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (flag)
			{
				UTDMStaticLibrary.SetRouterAddress(false, "https://sg.tdatamaster.com:8013/tdm/v1/route");
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "SetRouterAddress";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GLOBALROUTORADDRESS", "https://sg.tdatamaster.com:8013/tdm/v1/route");
				instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				UTDMStaticLibrary.SetRouterAddress(false, "https://hc.tdm.qq.com:8013/tdm/v2/route");
				LauncherLog instance3 = LauncherLog.Instance;
				string message3 = "SetRouterAddress";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ROUTORADDRESS", "https://hc.tdm.qq.com:8013/tdm/v2/route");
				instance3.Info(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			UTDMStaticLibrary.Initialize(publicValue, text, publicValue2);
			string publicValue3 = BaseConfigController.Instance.GetPublicValue("TDMUrl");
			if (publicValue3 != "Default")
			{
				LauncherLog instance4 = LauncherLog.Instance;
				string message4 = "tdm 链接";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("targetUrl", publicValue3);
				instance4.Info(message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				UTDMStaticLibrary.SetRouterAddress(false, publicValue3);
			}
			LauncherLog.Instance.Info("GetDeviceInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			string deviceInfo = UTDMStaticLibrary.GetDeviceInfo();
			LauncherLog instance5 = LauncherLog.Instance;
			string message5 = "TDM deviceInfo";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("deviceInfo", deviceInfo);
			instance5.Info(message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
		}

		// Token: 0x040007E7 RID: 2023
		private const string GLOBALROUTORADDRESS = "https://sg.tdatamaster.com:8013/tdm/v1/route";

		// Token: 0x040007E8 RID: 2024
		private const string ROUTORADDRESS = "https://hc.tdm.qq.com:8013/tdm/v2/route";
	}
}
