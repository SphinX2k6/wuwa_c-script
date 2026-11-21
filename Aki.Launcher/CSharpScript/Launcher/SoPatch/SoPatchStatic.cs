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
	// Token: 0x0200010D RID: 269
	[NullableContext(1)]
	[Nullable(0)]
	public class SoPatchStatic : Singleton, ITickable
	{
		// Token: 0x060008BD RID: 2237 RVA: 0x0004187C File Offset: 0x0003FA7C
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

		// Token: 0x060008BE RID: 2238 RVA: 0x000418E0 File Offset: 0x0003FAE0
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

		// Token: 0x060008BF RID: 2239 RVA: 0x000419F4 File Offset: 0x0003FBF4
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

		// Token: 0x060008C0 RID: 2240 RVA: 0x00041A50 File Offset: 0x0003FC50
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

		// Token: 0x060008C1 RID: 2241 RVA: 0x00041A9C File Offset: 0x0003FC9C
		private UniTask FixInternal()
		{
			SoPatchStatic.<FixInternal>d__13 <FixInternal>d__;
			<FixInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FixInternal>d__.<>4__this = this;
			<FixInternal>d__.<>1__state = -1;
			<FixInternal>d__.<>t__builder.Start<SoPatchStatic.<FixInternal>d__13>(ref <FixInternal>d__);
			return <FixInternal>d__.<>t__builder.Task;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00041AE0 File Offset: 0x0003FCE0
		public UniTask Fix()
		{
			SoPatchStatic.<Fix>d__14 <Fix>d__;
			<Fix>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Fix>d__.<>4__this = this;
			<Fix>d__.<>1__state = -1;
			<Fix>d__.<>t__builder.Start<SoPatchStatic.<Fix>d__14>(ref <Fix>d__);
			return <Fix>d__.<>t__builder.Task;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00041B23 File Offset: 0x0003FD23
		public void Tick(float delta)
		{
			this.Current += (int)delta;
			if (this.Current >= SoPatchStatic.Interval)
			{
				this.Current -= SoPatchStatic.Interval;
				this.Fix().Forget();
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00041B5E File Offset: 0x0003FD5E
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

		// Token: 0x060008C5 RID: 2245 RVA: 0x00041B81 File Offset: 0x0003FD81
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00041B83 File Offset: 0x0003FD83
		public static void ResetStaticDefaultValue()
		{
			SoPatchStatic instance = SoPatchStatic._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SoPatchStatic._instance = null;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00041B9C File Offset: 0x0003FD9C
		static SoPatchStatic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SoPatchStatic.CreateStaticDefaultValue), new Action(SoPatchStatic.ResetStaticDefaultValue));
		}

		// Token: 0x04000517 RID: 1303
		[Nullable(2)]
		private UKuroVerify Verify;

		// Token: 0x04000518 RID: 1304
		[Nullable(2)]
		private SoPathConfig Config;

		// Token: 0x04000519 RID: 1305
		private string OsVersion = "";

		// Token: 0x0400051A RID: 1306
		private string Manufacturer = "";

		// Token: 0x0400051B RID: 1307
		private string Model = "";

		// Token: 0x0400051C RID: 1308
		private long DeviceValue;

		// Token: 0x0400051D RID: 1309
		private static readonly int Interval = 300000;

		// Token: 0x0400051E RID: 1310
		private int Current = 300000;

		// Token: 0x0400051F RID: 1311
		private bool IsProcessing;

		// Token: 0x04000520 RID: 1312
		[Nullable(2)]
		private static SoPatchStatic _instance;
	}
}
