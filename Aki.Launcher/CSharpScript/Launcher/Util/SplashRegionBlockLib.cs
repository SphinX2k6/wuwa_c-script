using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200007C RID: 124
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public class SplashRegionBlockLib
	{
		// Token: 0x0600033F RID: 831 RVA: 0x00012133 File Offset: 0x00010333
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

		// Token: 0x06000340 RID: 832 RVA: 0x00012150 File Offset: 0x00010350
		public static UniTask PrepareAsync()
		{
			SplashRegionBlockLib.<PrepareAsync>d__7 <PrepareAsync>d__;
			<PrepareAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareAsync>d__.<>1__state = -1;
			<PrepareAsync>d__.<>t__builder.Start<SplashRegionBlockLib.<PrepareAsync>d__7>(ref <PrepareAsync>d__);
			return <PrepareAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0001218C File Offset: 0x0001038C
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
			bool flag = Array.IndexOf<string>(SplashRegionBlockConfig.BlockedRegions, cachedRegion) >= 0;
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "[SplashRegionBlock]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("region", cachedRegion);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("blocked", flag);
			instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return flag;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001224C File Offset: 0x0001044C
		private static bool IsFeatureEffective()
		{
			return SplashRegionBlockConfig.Enabled && (SplashRegionBlockLib.IsTestModeOn() || SplashRegionBlockLib.IsGlobalPackage());
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001226A File Offset: 0x0001046A
		private static bool IsGlobalPackage()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00012285 File Offset: 0x00010485
		private static bool IsTestModeOn()
		{
			return SplashRegionBlockConfig.TestMode;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001228C File Offset: 0x0001048C
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

		// Token: 0x06000346 RID: 838 RVA: 0x000122DC File Offset: 0x000104DC
		private static void SetCache(string region, int timestampSecs)
		{
			SplashRegionBlockLib.CachedRegion = region;
			SplashRegionBlockLib.CachedTimestampSecs = timestampSecs;
			LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.SplashRegionBlockRegion, region);
			LauncherStorageLib.Instance.SetDeviceSaved<int>(ELauncherStorageDeviceKey.SplashRegionBlockTimestampSecs, timestampSecs);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00012308 File Offset: 0x00010508
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

		// Token: 0x06000348 RID: 840 RVA: 0x00012344 File Offset: 0x00010544
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

		// Token: 0x06000349 RID: 841 RVA: 0x00012388 File Offset: 0x00010588
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

		// Token: 0x04000277 RID: 631
		private const int COUNTRY_CODE_LENGTH = 2;

		// Token: 0x04000278 RID: 632
		private const int CHAR_CODE_UPPER_A = 65;

		// Token: 0x04000279 RID: 633
		private const int CHAR_CODE_UPPER_Z = 90;

		// Token: 0x0400027A RID: 634
		private static bool IsInited;

		// Token: 0x0400027B RID: 635
		[Nullable(2)]
		private static string CachedRegion;

		// Token: 0x0400027C RID: 636
		private static int CachedTimestampSecs;
	}
}
