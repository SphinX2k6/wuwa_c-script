using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform
{
	// Token: 0x02000125 RID: 293
	[NullableContext(1)]
	[Nullable(0)]
	public class CloudGameManagerLauncher : Singleton
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x00042A5C File Offset: 0x00040C5C
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00042BAA File Offset: 0x00040DAA
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

		// Token: 0x0600096A RID: 2410 RVA: 0x00042BCD File Offset: 0x00040DCD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00042BCF File Offset: 0x00040DCF
		public static void ResetStaticDefaultValue()
		{
			CloudGameManagerLauncher instance = CloudGameManagerLauncher._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			CloudGameManagerLauncher._instance = null;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00042BE8 File Offset: 0x00040DE8
		static CloudGameManagerLauncher()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CloudGameManagerLauncher.CreateStaticDefaultValue), new Action(CloudGameManagerLauncher.ResetStaticDefaultValue));
		}

		// Token: 0x04000570 RID: 1392
		public const string CLOUD_GAME_REBOOT_CMD = "-Reboot";

		// Token: 0x04000571 RID: 1393
		public const string CLOUD_GAME_PRE_LAUNCH_CMD = "-CloudGamePreLaunch";

		// Token: 0x04000572 RID: 1394
		private readonly Regex CloudGameServerTagRegex = new Regex("-ServerTag=([^\\s]+)");

		// Token: 0x04000573 RID: 1395
		private bool IsInited;

		// Token: 0x04000574 RID: 1396
		public bool IsPreLaunch;

		// Token: 0x04000575 RID: 1397
		public string ServerTag = "";

		// Token: 0x04000576 RID: 1398
		[Nullable(2)]
		private static CloudGameManagerLauncher _instance;
	}
}
