using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core;
using CSharpScript.Launcher;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.InputDevice;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using CSharpScript.ThirdParty.UniTaskExtensions;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02000006 RID: 6
public class Launch
{
	// Token: 0x06000054 RID: 84 RVA: 0x00005F58 File Offset: 0x00004158
	[NullableContext(1)]
	public static void DoLaunch(UGameInstance gameInstance)
	{
		CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
		StaticVariableRegister.ResetRequiredStaticDefaultValue();
		DelegateUtils.CreateStaticDefaultValue();
		UnobservedExceptionHandler.Initialize(gameInstance);
		LauncherLog instance = LauncherLog.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[ScriptBuildInfo] Optimize: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CSharpScriptBuildInfo.Optimized);
		instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		bool flag = true;
		bool flag2 = SharpherealNativeWrapper.IsEnabled();
		LauncherLog instance2 = LauncherLog.Instance;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(83, 2);
		defaultInterpolatedStringHandler.AppendLiteral("[ScriptBuildInfo] ENABLE_SHARPHEREAL_NATIVE_WRAPPER: C# compile-time=");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(flag);
		defaultInterpolatedStringHandler.AppendLiteral(", C++ runtime=");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(flag2);
		instance2.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		if (flag && !flag2)
		{
			LauncherLog.Instance.Error("[ScriptBuildInfo] 非编辑器环境 C++ 未开启 NativeWrapper,请检查 SharpherealWrapper.Build.cs 的 bCompileCppNativeWrapper 是否为 true。", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		BP_MainGameInstance_C bp_MainGameInstance_C = Launch.LaunchGameInstance = (gameInstance as BP_MainGameInstance_C);
		UWorld world = bp_MainGameInstance_C.GetWorld();
		StaticVariableRegister.CreateRequiredStaticDefaultValue();
		bp_MainGameInstance_C.IsStartFromLaunch = true;
		AppUtil.SetWorldContext(world);
		InputDevice.Instance.Initialize();
		CloudGameManagerLauncher.Instance.Init();
		LauncherStorageLib.Instance.Initialize();
		LauncherConfigLib.Instance.Initialize();
		LauncherLanguageLib.Instance.Initialize(UKuroStaticLibrary.IsEditor(world));
		LauncherResourceLib.Instance.Initialize();
		LauncherGameSettingLib.Instance.InitInLaunch(world);
		LauncherLog.Instance.Info("cs launch called, starting HotPatch 进入c#环境", default(ReadOnlySpan<ValueTuple<string, object>>));
		HotPatchLogReport.Instance.World = world;
		HotPatch.Instance.Start(world, gameInstance);
	}

	// Token: 0x04000022 RID: 34
	[Nullable(2)]
	[StaticVariableRuleIgnore]
	public static BP_MainGameInstance_C LaunchGameInstance;
}
