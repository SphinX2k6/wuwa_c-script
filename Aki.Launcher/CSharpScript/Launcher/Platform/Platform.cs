using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform
{
	// Token: 0x0200012C RID: 300
	[NullableContext(1)]
	[Nullable(0)]
	public class Platform : Singleton
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00045020 File Offset: 0x00043220
		public EPlatformType Type
		{
			get
			{
				if (!this.IsInitialized)
				{
					LauncherLog.Instance.Debug("[PlatformSdkNew]平台类型未初始化,初始化平台信息", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.Initialize();
				}
				return this.TypeInternal;
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00045059 File Offset: 0x00043259
		public bool IsAndroidPlatform()
		{
			return this.Type == EPlatformType.Android;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00045064 File Offset: 0x00043264
		public bool IsIOSPlatform()
		{
			return this.Type == EPlatformType.IOS;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0004506F File Offset: 0x0004326F
		public bool IsMacPlatform()
		{
			return this.Type == EPlatformType.Mac;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0004507A File Offset: 0x0004327A
		public bool IsPs5Platform()
		{
			return this.Type == EPlatformType.PS5;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00045085 File Offset: 0x00043285
		public bool IsXSXPlatform()
		{
			return this.Type == EPlatformType.XSX;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00045091 File Offset: 0x00043291
		public bool IsWinGDKPlatform()
		{
			return this.Type == EPlatformType.WinGDK;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0004509D File Offset: 0x0004329D
		public bool IsOpenHarmonyPlatform()
		{
			return this.Type == EPlatformType.OpenHarmony;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000450A9 File Offset: 0x000432A9
		public bool IsXboxPlatform()
		{
			return this.Type == EPlatformType.XboxOne || this.Type == EPlatformType.XSX || this.Type == EPlatformType.WinGDK;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x000450CB File Offset: 0x000432CB
		public bool IsHomeConsolePlatform()
		{
			return this.IsPs5Platform() || this.IsXboxPlatform();
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000450DD File Offset: 0x000432DD
		public bool IsWindowsPlatform()
		{
			return this.Type == EPlatformType.Windows || this.IsWinGDKPlatform();
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000450F0 File Offset: 0x000432F0
		public bool IsWindowsOnlyPlatform()
		{
			return this.Type == EPlatformType.Windows;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000450FB File Offset: 0x000432FB
		public bool IsPcOrGamepadPlatform()
		{
			return this.IsPcPlatform() || this.IsGamepadPlatform();
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0004510D File Offset: 0x0004330D
		public bool IsPcPlatform()
		{
			return this.Type == EPlatformType.Windows || this.Type == EPlatformType.Mac || this.Type == EPlatformType.Linux || this.Type == EPlatformType.WinGDK;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00045136 File Offset: 0x00043336
		public bool IsMobilePlatform()
		{
			return this.Type == EPlatformType.IOS || this.Type == EPlatformType.Android || this.Type == EPlatformType.OpenHarmony;
		}

		// Token: 0x170000FF RID: 255
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x00045156 File Offset: 0x00043356
		public bool IsFakeCloudGame
		{
			set
			{
				this.IsFakeCloudGameInternal = value;
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0004515F File Offset: 0x0004335F
		public bool IsCloudGame()
		{
			return this.IsFakeCloudGameInternal || this.IsCloudGameInternal;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00045171 File Offset: 0x00043371
		public bool IsCloudGameRunningHotPatch()
		{
			return this.IsCloudGameHotPatch;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00045179 File Offset: 0x00043379
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x00045190 File Offset: 0x00043390
		public string CloudGamePlatform
		{
			get
			{
				if (this.IsFakeCloudGameInternal)
				{
					return ECloudGamePlatform.Windows.ToEnumString();
				}
				return this.CloudGamePlatformInternal;
			}
			set
			{
				this.CloudGamePlatformInternal = value;
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00045199 File Offset: 0x00043399
		public bool IsHuaWeiDevice()
		{
			return UKuroStaticLibrary.GetVendorInfo().ToUpper().Contains("HUAWEI");
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000451AF File Offset: 0x000433AF
		public bool IsHonorDevice()
		{
			return UKuroStaticLibrary.GetVendorInfo().ToUpper().Contains("HONOR");
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000451C8 File Offset: 0x000433C8
		public bool IsRedMagicDeviceLow()
		{
			string mobileDeviceModel = UKuroRenderingRuntimeBPPluginBPLibrary.GetMobileDeviceModel();
			return mobileDeviceModel.Contains("NX789J") || mobileDeviceModel.Contains("NP05J") || mobileDeviceModel.Contains("NX799J") || mobileDeviceModel.Contains("NX809J") || mobileDeviceModel.Contains("NP06J");
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0004521C File Offset: 0x0004341C
		public bool IsRedMagicDeviceHigh()
		{
			return false;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0004521F File Offset: 0x0004341F
		public bool IsRedMagicDevice()
		{
			return this.IsRedMagicDeviceLow() || this.IsRedMagicDeviceHigh();
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00045234 File Offset: 0x00043434
		public bool IsFoldingScreen()
		{
			if (this.IsOpenHarmonyPlatform())
			{
				LauncherSdkBase launcherSdkBase = LauncherSdk.Get();
				if (launcherSdkBase.IsFoldableScreen())
				{
					return !launcherSdkBase.IsScreenFolded();
				}
			}
			FVector2D androidRawResolution = UKuroRenderingRuntimeBPPluginBPLibrary.GetAndroidRawResolution();
			float num = androidRawResolution.X / androidRawResolution.Y;
			if (this.IsOpenHarmonyPlatform())
			{
				num = KuroScreen.GetPhysicalScreenResolutionV2().X / KuroScreen.GetPhysicalScreenResolutionV2().Y;
			}
			if ((double)num < 1.8 || (double)num > 2.6)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "折叠屏适配";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ScreenRatio", num);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return true;
			}
			return false;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x000452D8 File Offset: 0x000434D8
		public bool IsGamepadPlatform()
		{
			return this.Type == EPlatformType.XboxOne || this.Type == EPlatformType.XSX || this.Type == EPlatformType.PS4 || this.Type == EPlatformType.PS5;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00045304 File Offset: 0x00043504
		private unsafe void Initialize()
		{
			string text = KuroApplication.IniPlatformName();
			if (text != null)
			{
				switch (text.Length)
				{
				case 3:
				{
					char c = text[2];
					if (c <= '5')
					{
						if (c != '4')
						{
							if (c == '5')
							{
								if (text == "PS5")
								{
									this.TypeInternal = EPlatformType.PS5;
									goto IL_1E7;
								}
							}
						}
						else if (text == "PS4")
						{
							this.TypeInternal = EPlatformType.PS4;
							goto IL_1E7;
						}
					}
					else if (c != 'S')
					{
						if (c != 'X')
						{
							if (c == 'c')
							{
								if (text == "Mac")
								{
									this.TypeInternal = EPlatformType.Mac;
									goto IL_1E7;
								}
							}
						}
						else if (text == "XSX")
						{
							this.TypeInternal = EPlatformType.XSX;
							goto IL_1E7;
						}
					}
					else if (text == "IOS")
					{
						this.TypeInternal = EPlatformType.IOS;
						goto IL_1E7;
					}
					break;
				}
				case 5:
					if (text == "Linux")
					{
						this.TypeInternal = EPlatformType.Linux;
						goto IL_1E7;
					}
					break;
				case 6:
					if (text == "WinGDK")
					{
						this.TypeInternal = EPlatformType.WinGDK;
						goto IL_1E7;
					}
					break;
				case 7:
				{
					char c = text[0];
					if (c != 'A')
					{
						if (c != 'W')
						{
							if (c == 'X')
							{
								if (text == "XboxOne")
								{
									this.TypeInternal = EPlatformType.XboxOne;
									goto IL_1E7;
								}
							}
						}
						else if (text == "Windows")
						{
							this.TypeInternal = EPlatformType.Windows;
							goto IL_1E7;
						}
					}
					else if (text == "Android")
					{
						this.TypeInternal = EPlatformType.Android;
						goto IL_1E7;
					}
					break;
				}
				case 11:
					if (text == "OpenHarmony")
					{
						this.TypeInternal = EPlatformType.OpenHarmony;
						goto IL_1E7;
					}
					break;
				}
			}
			this.TypeInternal = EPlatformType.None;
			IL_1E7:
			string commandLine = UKismetSystemLibrary.GetCommandLine();
			this.IsCloudGameInternal = commandLine.Contains("-CloudGame");
			this.IsCloudGameHotPatch = commandLine.Contains("-CloudGameHotPatch");
			this.IsInitialized = true;
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]初始化平台类型";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlatformType", this.TypeInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CloudGame", this.IsCloudGameInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CloudGameHotPatch", this.IsCloudGameHotPatch);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000455AC File Offset: 0x000437AC
		public bool CheckAssetPlatformInclude(string platFormTag)
		{
			return UKuroActorSubsystem.CheckAssetPlatformInclude(platFormTag);
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x000455B4 File Offset: 0x000437B4
		public static Platform Instance
		{
			get
			{
				if (Platform._instance == null)
				{
					Platform._instance = new Platform();
					Platform._instance.OnInit();
				}
				return Platform._instance;
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000455D7 File Offset: 0x000437D7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000455D9 File Offset: 0x000437D9
		public static void ResetStaticDefaultValue()
		{
			Platform instance = Platform._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			Platform._instance = null;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000455F2 File Offset: 0x000437F2
		static Platform()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Platform.CreateStaticDefaultValue), new Action(Platform.ResetStaticDefaultValue));
		}

		// Token: 0x040005C5 RID: 1477
		private bool IsInitialized;

		// Token: 0x040005C6 RID: 1478
		private EPlatformType TypeInternal;

		// Token: 0x040005C7 RID: 1479
		private bool IsCloudGameInternal;

		// Token: 0x040005C8 RID: 1480
		private bool IsCloudGameHotPatch;

		// Token: 0x040005C9 RID: 1481
		private string CloudGamePlatformInternal = "";

		// Token: 0x040005CA RID: 1482
		private bool IsFakeCloudGameInternal;

		// Token: 0x040005CB RID: 1483
		[Nullable(2)]
		private static Platform _instance;
	}
}
