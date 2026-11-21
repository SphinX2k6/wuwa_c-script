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

// Token: 0x02000273 RID: 627
[NullableContext(1)]
[Nullable(0)]
public static class GameProcedure
{
	// Token: 0x060026D7 RID: 9943 RVA: 0x000EB178 File Offset: 0x000E9378
	private static void LogLoadPhase(string name, double? time = null)
	{
	}

	// Token: 0x060026D8 RID: 9944 RVA: 0x000EB188 File Offset: 0x000E9388
	public static void Start(UGameInstance gameInstance)
	{
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

	// Token: 0x060026D9 RID: 9945 RVA: 0x000EB3BC File Offset: 0x000E95BC
	private static UniTask OnStart(UGameInstance instance)
	{
		GameProcedure.<OnStart>d__4 <OnStart>d__;
		<OnStart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnStart>d__.instance = instance;
		<OnStart>d__.<>1__state = -1;
		<OnStart>d__.<>t__builder.Start<GameProcedure.<OnStart>d__4>(ref <OnStart>d__);
		return <OnStart>d__.<>t__builder.Task;
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x000EB400 File Offset: 0x000E9600
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

	// Token: 0x060026DB RID: 9947 RVA: 0x000EB44C File Offset: 0x000E964C
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

	// Token: 0x060026DC RID: 9948 RVA: 0x000EB498 File Offset: 0x000E9698
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

	// Token: 0x060026DD RID: 9949 RVA: 0x000EB4F3 File Offset: 0x000E96F3
	private static void Tick(float delta)
	{
		Action advance = GameProcedure.GameProcedureDefine.Advance;
		if (advance != null)
		{
			advance();
		}
		GameProcedure.GameProcedureDefine.Advance = null;
	}

	// Token: 0x060026DE RID: 9950 RVA: 0x000EB50C File Offset: 0x000E970C
	private static UniTask WaitFrame()
	{
		GameProcedure.<WaitFrame>d__9 <WaitFrame>d__;
		<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitFrame>d__.<>1__state = -1;
		<WaitFrame>d__.<>t__builder.Start<GameProcedure.<WaitFrame>d__9>(ref <WaitFrame>d__);
		return <WaitFrame>d__.<>t__builder.Task;
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x000EB548 File Offset: 0x000E9748
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

	// Token: 0x04002508 RID: 9480
	private const int MaxFrameTime = 200;

	// Token: 0x020065FC RID: 26108
	[NullableContext(0)]
	public class GameProcedureDefine : IStaticVariableResetter
	{
		// Token: 0x0603ECC5 RID: 257221 RVA: 0x0125397C File Offset: 0x01251B7C
		static GameProcedureDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameProcedure.GameProcedureDefine.CreateStaticDefaultValue), new Action(GameProcedure.GameProcedureDefine.ResetStaticDefaultValue));
		}

		// Token: 0x1700776F RID: 30575
		// (get) Token: 0x0603ECC6 RID: 257222 RVA: 0x0125399B File Offset: 0x01251B9B
		// (set) Token: 0x0603ECC7 RID: 257223 RVA: 0x012539A2 File Offset: 0x01251BA2
		public static bool Inited { get; set; }

		// Token: 0x0603ECC8 RID: 257224 RVA: 0x012539AA File Offset: 0x01251BAA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603ECC9 RID: 257225 RVA: 0x012539AC File Offset: 0x01251BAC
		public static void ResetStaticDefaultValue()
		{
			GameProcedure.GameProcedureDefine.Inited = false;
			GameProcedure.GameProcedureDefine.Advance = null;
		}

		// Token: 0x04021BFE RID: 138238
		[Nullable(1)]
		public static Action Advance;
	}

	// Token: 0x020065FD RID: 26109
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04021BFF RID: 138239
		[Nullable(0)]
		public static Action<float> <0>__Tick;
	}
}
