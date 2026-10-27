using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Framework;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x02000109 RID: 265
	[NullableContext(1)]
	[Nullable(0)]
	public class SoPatchStatic : Singleton, ITickable
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x0003F4DC File Offset: 0x0003D6DC
		private UniTask RequestConfig(string appParallel, List<string> prefixList, string mixRoute, string platform)
		{
			SoPatchStatic.<RequestConfig>d__9 <RequestConfig>d__;
			<RequestConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestConfig>d__.<>4__this = this;
			<RequestConfig>d__.appParallel = appParallel;
			<RequestConfig>d__.prefixList = prefixList;
			<RequestConfig>d__.mixRoute = mixRoute;
			<RequestConfig>d__.platform = platform;
			<RequestConfig>d__.<>1__state = -1;
			<RequestConfig>d__.<>t__builder.Start<SoPatchStatic.<RequestConfig>d__9>(ref <RequestConfig>d__);
			return <RequestConfig>d__.<>t__builder.Task;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0003F540 File Offset: 0x0003D740
		private unsafe void GetDeviceAndAppInfo()
		{
			if (this.OsVersion != null && this.OsVersion.Length > 0)
			{
				return;
			}
			if (UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1")
			{
				string deviceId = UKuroSDKManager.GetBasicInfo().DeviceId;
				string text = UKuroStaticLibrary.HashStringWithSHA1(deviceId);
				if (text == null || text.Length == 0)
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "灰度检查: deviceId的SHA1值不合法";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DeviceId", deviceId ?? "");
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SHA1", text ?? "");
					instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					this.DeviceValue = Convert.ToInt64(text.Substring(0, Math.Min(8, text.Length)), 16);
				}
			}
			this.Manufacturer = UKuroAndroidModelTools.GetManufacturer();
			this.Model = UKuroAndroidModelTools.GetModel();
			this.OsVersion = UKuroAndroidModelTools.GetAndroidVersion();
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0003F654 File Offset: 0x0003D854
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<string> DownloadPatch(string mixRoute, string platform, int curVer)
		{
			SoPatchStatic.<DownloadPatch>d__11 <DownloadPatch>d__;
			<DownloadPatch>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
			<DownloadPatch>d__.<>4__this = this;
			<DownloadPatch>d__.mixRoute = mixRoute;
			<DownloadPatch>d__.platform = platform;
			<DownloadPatch>d__.curVer = curVer;
			<DownloadPatch>d__.<>1__state = -1;
			<DownloadPatch>d__.<>t__builder.Start<SoPatchStatic.<DownloadPatch>d__11>(ref <DownloadPatch>d__);
			return <DownloadPatch>d__.<>t__builder.Task;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0003F6B0 File Offset: 0x0003D8B0
		[NullableContext(0)]
		private UniTask<int> CheckSoHash([Nullable(1)] string soHash)
		{
			SoPatchStatic.<CheckSoHash>d__12 <CheckSoHash>d__;
			<CheckSoHash>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
			<CheckSoHash>d__.<>4__this = this;
			<CheckSoHash>d__.soHash = soHash;
			<CheckSoHash>d__.<>1__state = -1;
			<CheckSoHash>d__.<>t__builder.Start<SoPatchStatic.<CheckSoHash>d__12>(ref <CheckSoHash>d__);
			return <CheckSoHash>d__.<>t__builder.Task;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0003F6FC File Offset: 0x0003D8FC
		private UniTask FixInternal()
		{
			SoPatchStatic.<FixInternal>d__13 <FixInternal>d__;
			<FixInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FixInternal>d__.<>4__this = this;
			<FixInternal>d__.<>1__state = -1;
			<FixInternal>d__.<>t__builder.Start<SoPatchStatic.<FixInternal>d__13>(ref <FixInternal>d__);
			return <FixInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0003F740 File Offset: 0x0003D940
		public UniTask Fix()
		{
			SoPatchStatic.<Fix>d__14 <Fix>d__;
			<Fix>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Fix>d__.<>4__this = this;
			<Fix>d__.<>1__state = -1;
			<Fix>d__.<>t__builder.Start<SoPatchStatic.<Fix>d__14>(ref <Fix>d__);
			return <Fix>d__.<>t__builder.Task;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0003F783 File Offset: 0x0003D983
		public void Tick(float delta)
		{
			this.Current += (int)delta;
			if (this.Current >= SoPatchStatic.Interval)
			{
				this.Current -= SoPatchStatic.Interval;
				this.Fix().Forget();
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0003F7BE File Offset: 0x0003D9BE
		public static SoPatchStatic Instance
		{
			get
			{
				if (SoPatchStatic._instance == null)
				{
					SoPatchStatic._instance = new SoPatchStatic();
					SoPatchStatic._instance.OnInit();
				}
				return SoPatchStatic._instance;
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0003F7E1 File Offset: 0x0003D9E1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0003F7E3 File Offset: 0x0003D9E3
		public static void ResetStaticDefaultValue()
		{
			SoPatchStatic instance = SoPatchStatic._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SoPatchStatic._instance = null;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0003F7FC File Offset: 0x0003D9FC
		static SoPatchStatic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SoPatchStatic.CreateStaticDefaultValue), new Action(SoPatchStatic.ResetStaticDefaultValue));
		}

		// Token: 0x040004DC RID: 1244
		[Nullable(2)]
		private UKuroVerify Verify;

		// Token: 0x040004DD RID: 1245
		[Nullable(2)]
		private SoPathConfig Config;

		// Token: 0x040004DE RID: 1246
		private string OsVersion = "";

		// Token: 0x040004DF RID: 1247
		private string Manufacturer = "";

		// Token: 0x040004E0 RID: 1248
		private string Model = "";

		// Token: 0x040004E1 RID: 1249
		private long DeviceValue;

		// Token: 0x040004E2 RID: 1250
		private static readonly int Interval = 300000;

		// Token: 0x040004E3 RID: 1251
		private int Current = 300000;

		// Token: 0x040004E4 RID: 1252
		private bool IsProcessing;

		// Token: 0x040004E5 RID: 1253
		[Nullable(2)]
		private static SoPatchStatic _instance;
	}
}
