using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform
{
	// Token: 0x02000129 RID: 297
	[NullableContext(1)]
	[Nullable(0)]
	public class CloudGameManagerLauncher : Singleton
	{
		// Token: 0x0600099C RID: 2460 RVA: 0x00044E50 File Offset: 0x00043050
		public unsafe void Init()
		{
			if (!Platform.Instance.IsCloudGame())
			{
				return;
			}
			if (this.IsInited)
			{
				return;
			}
			this.IsInited = true;
			string commandLine = UKismetSystemLibrary.GetCommandLine();
			this.IsPreLaunch = commandLine.Contains("-CloudGamePreLaunch");
			bool flag = commandLine.Contains("-Reboot");
			Match match = this.CloudGameServerTagRegex.Match(commandLine);
			if (match.Success)
			{
				this.ServerTag = match.Groups[1].Value;
			}
			if (!this.IsPreLaunch)
			{
				Match match2 = new Regex("-CloudGamePlatform=([^\\s]+)").Match(commandLine);
				if (match2.Success)
				{
					Platform.Instance.CloudGamePlatform = match2.Groups[1].Value;
				}
			}
			if (this.IsPreLaunch && !flag)
			{
				LauncherStorageLib.Instance.LockDbPath(true, "CloudGameManagerLauncher");
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "云游戏初始化 launcher";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsPreLaunch", this.IsPreLaunch);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isReboot", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ServerTag", this.ServerTag);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00044F9E File Offset: 0x0004319E
		public static CloudGameManagerLauncher Instance
		{
			get
			{
				if (CloudGameManagerLauncher._instance == null)
				{
					CloudGameManagerLauncher._instance = new CloudGameManagerLauncher();
					CloudGameManagerLauncher._instance.OnInit();
				}
				return CloudGameManagerLauncher._instance;
			}
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00044FC1 File Offset: 0x000431C1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00044FC3 File Offset: 0x000431C3
		public static void ResetStaticDefaultValue()
		{
			CloudGameManagerLauncher instance = CloudGameManagerLauncher._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			CloudGameManagerLauncher._instance = null;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00044FDC File Offset: 0x000431DC
		static CloudGameManagerLauncher()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CloudGameManagerLauncher.CreateStaticDefaultValue), new Action(CloudGameManagerLauncher.ResetStaticDefaultValue));
		}

		// Token: 0x040005AB RID: 1451
		public const string CLOUD_GAME_REBOOT_CMD = "-Reboot";

		// Token: 0x040005AC RID: 1452
		public const string CLOUD_GAME_PRE_LAUNCH_CMD = "-CloudGamePreLaunch";

		// Token: 0x040005AD RID: 1453
		private readonly Regex CloudGameServerTagRegex = new Regex("-ServerTag=([^\\s]+)");

		// Token: 0x040005AE RID: 1454
		private bool IsInited;

		// Token: 0x040005AF RID: 1455
		public bool IsPreLaunch;

		// Token: 0x040005B0 RID: 1456
		public string ServerTag = "";

		// Token: 0x040005B1 RID: 1457
		[Nullable(2)]
		private static CloudGameManagerLauncher _instance;
	}
}
