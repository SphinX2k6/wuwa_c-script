using System;
using System.Runtime.CompilerServices;
using Aki.Common;
using CSharpScript.Core.Common;
using CSharpScript.Core.Common.Generated;
using CSharpScript.Core.Utils;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.Util;
using CSharpScript.ThirdParty.UniTaskExtensions;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DC1 RID: 3521
[NullableContext(1)]
[Nullable(0)]
public static class GameProcedure
{
	// Token: 0x06005363 RID: 21347 RVA: 0x000E4B7C File Offset: 0x000E2D7C
	private static void LogLoadPhase(string name, double? time = null)
	{
		if (Info.Instance.IsPlayInEditor)
		{
			double num = time ?? ((double)UKuroStaticLibrary.GetPlatformTimeInSeconds());
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.BLZ;
			string message = "[LoadPhase] " + name;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("time", num);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06005364 RID: 21348 RVA: 0x000E4BE4 File Offset: 0x000E2DE4
	public static void Start(UGameInstance gameInstance)
	{
		DllUtils.Initialize();
		GeneratedUtils.Init();
		Info.IsCloudGameHook = (() => Platform.Instance.IsCloudGame());
		Info.CloudGamePlatformHook = (() => Platform.Instance.CloudGamePlatform);
		CSharpScript.Core.Common.JsonSettings.GameJsonTypeInfoResolver = JsonSourceGenContext.Default;
		CSharpScript.Core.Common.JsonSettings.CreateStaticDefaultValue();
		PerfSight.IsGlobalAreaHook = (() => BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN");
		LanguageSystem.NotifyLauncherLanguageHook = delegate(string lang)
		{
			if (PlatformSdkManagerNew.Instance.IsSdkOn)
			{
				PlatformSdkServer.Instance.SetLanguage(lang);
			}
			LauncherLanguageLib.Instance.SetPackageLanguage(lang);
		};
		EntityComponentConstant.ComponentTypeToIndexHook = delegate(string typeName)
		{
			EComponent result;
			if (!Enum.TryParse<EComponent>(typeName, out result))
			{
				return -1;
			}
			return (int)result;
		};
		Entity.GetCreatureIdsHook = delegate([Nullable(1)] Entity e)
		{
			CreatureDataComponent component = e.GetComponent<CreatureDataComponent>();
			return new ValueTuple<long?, int?>((component != null) ? new long?(component.GetCreatureDataId()) : null, (component != null) ? new int?(component.GetPbDataId()) : null);
		};
		GameBudgetInterfaceController.SubscribeBattleStateChangedHook = delegate(Action<bool> h)
		{
			EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, h);
		};
		GameBudgetInterfaceController.UnsubscribeBattleStateChangedHook = delegate(Action<bool> h)
		{
			EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, h);
		};
		GameBudgetInterfaceController.CenterRoleOffsetHook = delegate(Entity e)
		{
			CharacterMorphComponent component = e.GetComponent<CharacterMorphComponent>();
			if (component == null)
			{
				return null;
			}
			return component.GetCenterActorLocationOffset();
		};
		Info.Instance.Initialize(gameInstance);
		Log.Instance.ApplyPostHotPatchVerbosity();
		if (PublicUtil.Instance.GetIsSilentLogin())
		{
			DelegateUtils.CreateStaticDefaultValue();
			UnobservedExceptionHandler.Initialize(gameInstance);
			StaticVariableRegister.CreateRequiredStaticDefaultValue();
		}
		global::DecoratorManager.Init();
		LogAnalyzer.Instance.Initialize(true, BaseConfigController.Instance.GetPackageConfigOrDefault("Stream", null));
		float piestartTimeInSeconds = UKuroStaticLibrary.GetPIEStartTimeInSeconds();
		GameProcedure.LogLoadPhase("EngineInit Start", new double?((double)piestartTimeInSeconds));
		GameProcedure.LogLoadPhase("EngineInit End", null);
		Log.Instance.Info(ELogModule.Game, ELogAuthor.LCC, "GameProcedure：启动游戏初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (!Info.Instance.IsLowMemoryDevice && !BaseConfigController.Instance.GetIosAuditFirstDownloadTipWithSkip())
		{
			JitProfile.LoadProfile(UBlueprintPathsLibrary.ProjectContentDir() + "Aki/ScriptAssemblies/jit_profile.dat");
		}
		GameProcedure.OnStart(gameInstance).Forget();
	}

	// Token: 0x06005365 RID: 21349 RVA: 0x000E4E1C File Offset: 0x000E301C
	private static UniTask OnStart(UGameInstance instance)
	{
		GameProcedure.<OnStart>d__4 <OnStart>d__;
		<OnStart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnStart>d__.instance = instance;
		<OnStart>d__.<>1__state = -1;
		<OnStart>d__.<>t__builder.Start<GameProcedure.<OnStart>d__4>(ref <OnStart>d__);
		return <OnStart>d__.<>t__builder.Task;
	}

	// Token: 0x06005366 RID: 21350 RVA: 0x000E4E60 File Offset: 0x000E3060
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private static UniTask<T> FrameImport<[Nullable(2)] T>([Nullable(new byte[]
	{
		0,
		1
	})] UniTask<T> importTask, string moduleName)
	{
		GameProcedure.<FrameImport>d__5<T> <FrameImport>d__;
		<FrameImport>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
		<FrameImport>d__.importTask = importTask;
		<FrameImport>d__.moduleName = moduleName;
		<FrameImport>d__.<>1__state = -1;
		<FrameImport>d__.<>t__builder.Start<GameProcedure.<FrameImport>d__5<T>>(ref <FrameImport>d__);
		return <FrameImport>d__.<>t__builder.Task;
	}

	// Token: 0x06005367 RID: 21351 RVA: 0x000E4EAC File Offset: 0x000E30AC
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private static UniTask<T> MonitorImport<[Nullable(2)] T>([Nullable(new byte[]
	{
		0,
		1
	})] UniTask<T> importTask, string moduleName)
	{
		GameProcedure.<MonitorImport>d__6<T> <MonitorImport>d__;
		<MonitorImport>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
		<MonitorImport>d__.importTask = importTask;
		<MonitorImport>d__.moduleName = moduleName;
		<MonitorImport>d__.<>1__state = -1;
		<MonitorImport>d__.<>t__builder.Start<GameProcedure.<MonitorImport>d__6<T>>(ref <MonitorImport>d__);
		return <MonitorImport>d__.<>t__builder.Task;
	}

	// Token: 0x06005368 RID: 21352 RVA: 0x000E4EF8 File Offset: 0x000E30F8
	private static UniTask FrameCallAsyncGenerator(string callName, bool bMonitorTime, Delegate func, [Nullable(2)] UGameInstance instance = null)
	{
		GameProcedure.<FrameCallAsyncGenerator>d__7 <FrameCallAsyncGenerator>d__;
		<FrameCallAsyncGenerator>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FrameCallAsyncGenerator>d__.callName = callName;
		<FrameCallAsyncGenerator>d__.bMonitorTime = bMonitorTime;
		<FrameCallAsyncGenerator>d__.func = func;
		<FrameCallAsyncGenerator>d__.instance = instance;
		<FrameCallAsyncGenerator>d__.<>1__state = -1;
		<FrameCallAsyncGenerator>d__.<>t__builder.Start<GameProcedure.<FrameCallAsyncGenerator>d__7>(ref <FrameCallAsyncGenerator>d__);
		return <FrameCallAsyncGenerator>d__.<>t__builder.Task;
	}

	// Token: 0x06005369 RID: 21353 RVA: 0x000E4F53 File Offset: 0x000E3153
	private static void Tick(float delta)
	{
		Action advance = GameProcedure.GameProcedureDefine.Advance;
		if (advance != null)
		{
			advance();
		}
		GameProcedure.GameProcedureDefine.Advance = null;
	}

	// Token: 0x0600536A RID: 21354 RVA: 0x000E4F6C File Offset: 0x000E316C
	private static UniTask WaitFrame()
	{
		GameProcedure.<WaitFrame>d__9 <WaitFrame>d__;
		<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitFrame>d__.<>1__state = -1;
		<WaitFrame>d__.<>t__builder.Start<GameProcedure.<WaitFrame>d__9>(ref <WaitFrame>d__);
		return <WaitFrame>d__.<>t__builder.Task;
	}

	// Token: 0x0600536B RID: 21355 RVA: 0x000E4FA8 File Offset: 0x000E31A8
	[return: Dynamic(new bool[]
	{
		false,
		true
	})]
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private static UniTask<dynamic> ImportAsync(string path)
	{
		GameProcedure.<ImportAsync>d__10 <ImportAsync>d__;
		<ImportAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
		<ImportAsync>d__.<>1__state = -1;
		<ImportAsync>d__.<>t__builder.Start<GameProcedure.<ImportAsync>d__10>(ref <ImportAsync>d__);
		return <ImportAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04002488 RID: 9352
	private const int MaxFrameTime = 200;

	// Token: 0x0200746B RID: 29803
	[NullableContext(0)]
	public class GameProcedureDefine : IStaticVariableResetter
	{
		// Token: 0x06048868 RID: 297064 RVA: 0x012B0697 File Offset: 0x012AE897
		static GameProcedureDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameProcedure.GameProcedureDefine.CreateStaticDefaultValue), new Action(GameProcedure.GameProcedureDefine.ResetStaticDefaultValue));
		}

		// Token: 0x17009FD1 RID: 40913
		// (get) Token: 0x06048869 RID: 297065 RVA: 0x012B06B6 File Offset: 0x012AE8B6
		// (set) Token: 0x0604886A RID: 297066 RVA: 0x012B06BD File Offset: 0x012AE8BD
		public static bool Inited { get; set; }

		// Token: 0x0604886B RID: 297067 RVA: 0x012B06C5 File Offset: 0x012AE8C5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604886C RID: 297068 RVA: 0x012B06C7 File Offset: 0x012AE8C7
		public static void ResetStaticDefaultValue()
		{
			GameProcedure.GameProcedureDefine.Inited = false;
			GameProcedure.GameProcedureDefine.Advance = null;
		}

		// Token: 0x040268C0 RID: 157888
		[Nullable(1)]
		public static Action Advance;
	}

	// Token: 0x0200746C RID: 29804
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040268C1 RID: 157889
		[Nullable(0)]
		public static Action<float> <0>__Tick;
	}
}
