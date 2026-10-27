using System;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform
{
	// Token: 0x02000128 RID: 296
	[NullableContext(1)]
	[Nullable(0)]
	public class Platform : Singleton
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00042C2C File Offset: 0x00040E2C
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

		// Token: 0x0600096F RID: 2415 RVA: 0x00042C65 File Offset: 0x00040E65
		public bool IsAndroidPlatform()
		{
			return this.Type == EPlatformType.Android;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00042C70 File Offset: 0x00040E70
		public bool IsIOSPlatform()
		{
			return this.Type == EPlatformType.IOS;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00042C7B File Offset: 0x00040E7B
		public bool IsMacPlatform()
		{
			return this.Type == EPlatformType.Mac;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00042C86 File Offset: 0x00040E86
		public bool IsPs5Platform()
		{
			return this.Type == EPlatformType.PS5;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00042C91 File Offset: 0x00040E91
		public bool IsXSXPlatform()
		{
			return this.Type == EPlatformType.XSX;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00042C9D File Offset: 0x00040E9D
		public bool IsWinGDKPlatform()
		{
			return this.Type == EPlatformType.WinGDK;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00042CA9 File Offset: 0x00040EA9
		public bool IsOpenHarmonyPlatform()
		{
			return this.Type == EPlatformType.OpenHarmony;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00042CB5 File Offset: 0x00040EB5
		public bool IsXboxPlatform()
		{
			return this.Type == EPlatformType.XboxOne || this.Type == EPlatformType.XSX || this.Type == EPlatformType.WinGDK;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00042CD7 File Offset: 0x00040ED7
		public bool IsHomeConsolePlatform()
		{
			return this.IsPs5Platform() || this.IsXboxPlatform();
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00042CE9 File Offset: 0x00040EE9
		public bool IsWindowsPlatform()
		{
			return this.Type == EPlatformType.Windows || this.IsWinGDKPlatform();
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00042CFC File Offset: 0x00040EFC
		public bool IsWindowsOnlyPlatform()
		{
			return this.Type == EPlatformType.Windows;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00042D07 File Offset: 0x00040F07
		public bool IsPcOrGamepadPlatform()
		{
			return this.IsPcPlatform() || this.IsGamepadPlatform();
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00042D19 File Offset: 0x00040F19
		public bool IsPcPlatform()
		{
			return this.Type == EPlatformType.Windows || this.Type == EPlatformType.Mac || this.Type == EPlatformType.Linux || this.Type == EPlatformType.WinGDK;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00042D42 File Offset: 0x00040F42
		public bool IsMobilePlatform()
		{
			return this.Type == EPlatformType.IOS || this.Type == EPlatformType.Android || this.Type == EPlatformType.OpenHarmony;
		}

		// Token: 0x170000F9 RID: 249
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00042D62 File Offset: 0x00040F62
		public bool IsFakeCloudGame
		{
			set
			{
				this.IsFakeCloudGameInternal = value;
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00042D6B File Offset: 0x00040F6B
		public bool IsCloudGame()
		{
			return this.IsFakeCloudGameInternal || this.IsCloudGameInternal;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00042D7D File Offset: 0x00040F7D
		public bool IsCloudGameRunningHotPatch()
		{
			return this.IsCloudGameHotPatch;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00042D85 File Offset: 0x00040F85
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00042D9C File Offset: 0x00040F9C
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

		// Token: 0x06000982 RID: 2434 RVA: 0x00042DA5 File Offset: 0x00040FA5
		public bool IsHuaWeiDevice()
		{
			return UKuroStaticLibrary.GetVendorInfo().ToUpper().Contains("HUAWEI");
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00042DBB File Offset: 0x00040FBB
		public bool IsHonorDevice()
		{
			return UKuroStaticLibrary.GetVendorInfo().ToUpper().Contains("HONOR");
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00042DD4 File Offset: 0x00040FD4
		public bool IsRedMagicDeviceLow()
		{
			string mobileDeviceModel = UKuroRenderingRuntimeBPPluginBPLibrary.GetMobileDeviceModel();
			return mobileDeviceModel.Contains("NX789J") || mobileDeviceModel.Contains("NP05J") || mobileDeviceModel.Contains("NX799J") || mobileDeviceModel.Contains("NX809J") || mobileDeviceModel.Contains("NP06J");
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00042E28 File Offset: 0x00041028
		public bool IsRedMagicDeviceHigh()
		{
			return false;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00042E2B File Offset: 0x0004102B
		public bool IsRedMagicDevice()
		{
			return this.IsRedMagicDeviceLow() || this.IsRedMagicDeviceHigh();
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00042E40 File Offset: 0x00041040
		public bool IsFoldingScreen()
		{
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

		// Token: 0x06000988 RID: 2440 RVA: 0x00042EC4 File Offset: 0x000410C4
		public bool IsGamepadPlatform()
		{
			return this.Type == EPlatformType.XboxOne || this.Type == EPlatformType.XSX || this.Type == EPlatformType.PS4 || this.Type == EPlatformType.PS5;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00042EF0 File Offset: 0x000410F0
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

		// Token: 0x0600098A RID: 2442 RVA: 0x00043198 File Offset: 0x00041398
		public bool CheckAssetPlatformInclude(string platFormTag)
		{
			return UKuroActorSubsystem.CheckAssetPlatformInclude(platFormTag);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x000431A0 File Offset: 0x000413A0
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

		// Token: 0x0600098C RID: 2444 RVA: 0x000431C3 File Offset: 0x000413C3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000431C5 File Offset: 0x000413C5
		public static void ResetStaticDefaultValue()
		{
			Platform instance = Platform._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			Platform._instance = null;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000431DE File Offset: 0x000413DE
		static Platform()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Platform.CreateStaticDefaultValue), new Action(Platform.ResetStaticDefaultValue));
		}

		// Token: 0x0400058A RID: 1418
		private bool IsInitialized;

		// Token: 0x0400058B RID: 1419
		private EPlatformType TypeInternal;

		// Token: 0x0400058C RID: 1420
		private bool IsCloudGameInternal;

		// Token: 0x0400058D RID: 1421
		private bool IsCloudGameHotPatch;

		// Token: 0x0400058E RID: 1422
		private string CloudGamePlatformInternal = "";

		// Token: 0x0400058F RID: 1423
		private bool IsFakeCloudGameInternal;

		// Token: 0x04000590 RID: 1424
		[Nullable(2)]
		private static Platform _instance;
	}
}
