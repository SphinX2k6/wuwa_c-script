using System;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000079 RID: 121
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public class SplashRegionBlockLib
	{
		// Token: 0x0600032F RID: 815 RVA: 0x000112B3 File Offset: 0x0000F4B3
		public static void Initialize()
		{
			if (SplashRegionBlockLib.IsInited)
			{
				return;
			}
			SplashRegionBlockLib.IsInited = true;
			if (!SplashRegionBlockLib.IsFeatureEffective())
			{
				return;
			}
			SplashRegionBlockLib.LoadCache();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000112D0 File Offset: 0x0000F4D0
		public static UniTask PrepareAsync()
		{
			SplashRegionBlockLib.<PrepareAsync>d__7 <PrepareAsync>d__;
			<PrepareAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareAsync>d__.<>1__state = -1;
			<PrepareAsync>d__.<>t__builder.Start<SplashRegionBlockLib.<PrepareAsync>d__7>(ref <PrepareAsync>d__);
			return <PrepareAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001130C File Offset: 0x0000F50C
		public unsafe static bool ShouldBlockPhaseOne()
		{
			if (!SplashRegionBlockLib.IsInited || !SplashRegionBlockLib.IsFeatureEffective())
			{
				return false;
			}
			string cachedRegion = SplashRegionBlockLib.CachedRegion;
			if (cachedRegion == null)
			{
				bool fallbackBlockOnFailure = SplashRegionBlockConfig.FallbackBlockOnFailure;
				LauncherLog instance = LauncherLog.Instance;
				string message = "[SplashRegionBlock]无 Region, 走兜底";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("fallback", fallbackBlockOnFailure);
				instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return fallbackBlockOnFailure;
			}
			bool flag = SplashRegionBlockConfig.BlockedRegions.Contains(cachedRegion);
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "[SplashRegionBlock]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("region", cachedRegion);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("blocked", flag);
			instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return flag;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000113C6 File Offset: 0x0000F5C6
		private static bool IsFeatureEffective()
		{
			return SplashRegionBlockConfig.Enabled && (SplashRegionBlockLib.IsTestModeOn() || SplashRegionBlockLib.IsGlobalPackage());
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000113E4 File Offset: 0x0000F5E4
		private static bool IsGlobalPackage()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000113FF File Offset: 0x0000F5FF
		private static bool IsTestModeOn()
		{
			return SplashRegionBlockConfig.TestMode;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00011408 File Offset: 0x0000F608
		private static void LoadCache()
		{
			string text = LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.SplashRegionBlockRegion, "") ?? "";
			if (!SplashRegionBlockLib.IsValidCountryCode(text))
			{
				return;
			}
			int deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<int>(ELauncherStorageDeviceKey.SplashRegionBlockTimestampSecs, 0);
			if (deviceSaved <= 0)
			{
				return;
			}
			SplashRegionBlockLib.CachedRegion = text;
			SplashRegionBlockLib.CachedTimestampSecs = deviceSaved;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00011458 File Offset: 0x0000F658
		private static void SetCache(string region, int timestampSecs)
		{
			SplashRegionBlockLib.CachedRegion = region;
			SplashRegionBlockLib.CachedTimestampSecs = timestampSecs;
			LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.SplashRegionBlockRegion, region);
			LauncherStorageLib.Instance.SetDeviceSaved<int>(ELauncherStorageDeviceKey.SplashRegionBlockTimestampSecs, timestampSecs);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00011484 File Offset: 0x0000F684
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<string> QueryRegionByIpAsync()
		{
			SplashRegionBlockLib.<QueryRegionByIpAsync>d__14 <QueryRegionByIpAsync>d__;
			<QueryRegionByIpAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
			<QueryRegionByIpAsync>d__.<>1__state = -1;
			<QueryRegionByIpAsync>d__.<>t__builder.Start<SplashRegionBlockLib.<QueryRegionByIpAsync>d__14>(ref <QueryRegionByIpAsync>d__);
			return <QueryRegionByIpAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000114C0 File Offset: 0x0000F6C0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<string> TryOneProviderAsync(SplashRegionGeoIpProvider provider)
		{
			SplashRegionBlockLib.<TryOneProviderAsync>d__15 <TryOneProviderAsync>d__;
			<TryOneProviderAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
			<TryOneProviderAsync>d__.provider = provider;
			<TryOneProviderAsync>d__.<>1__state = -1;
			<TryOneProviderAsync>d__.<>t__builder.Start<SplashRegionBlockLib.<TryOneProviderAsync>d__15>(ref <TryOneProviderAsync>d__);
			return <TryOneProviderAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00011504 File Offset: 0x0000F704
		private static bool IsValidCountryCode(string code)
		{
			if (code.Length != 2)
			{
				return false;
			}
			foreach (int num in code)
			{
				if (num < 65 || num > 90)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400024B RID: 587
		private const int COUNTRY_CODE_LENGTH = 2;

		// Token: 0x0400024C RID: 588
		private const int CHAR_CODE_UPPER_A = 65;

		// Token: 0x0400024D RID: 589
		private const int CHAR_CODE_UPPER_Z = 90;

		// Token: 0x0400024E RID: 590
		private static bool IsInited;

		// Token: 0x0400024F RID: 591
		[Nullable(2)]
		private static string CachedRegion;

		// Token: 0x04000250 RID: 592
		private static int CachedTimestampSecs;
	}
}
