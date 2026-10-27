using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using AkiClient.Game.Aki.Core;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.DiffPatch.Procedure;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.HotPatchPushSdk;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Launcher
{
	// Token: 0x02000048 RID: 72
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatch : Singleton
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0000B8A0 File Offset: 0x00009AA0
		public void Start(UObject worldContext, UGameInstance gameInstance)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.SetSceneRenderingState(worldContext, true);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "r.fog 1", null);
			this.WorldContext = worldContext;
			this.GameInstance = (gameInstance as BP_MainGameInstance_C);
			LauncherLog.Instance.Info("初始化Push", default(ReadOnlySpan<ValueTuple<string, object>>));
			HotPatchPushSdk.StartPush();
			LauncherLog.Instance.Info("结束Push", default(ReadOnlySpan<ValueTuple<string, object>>));
			HotPatchKuroSdk.Instance.Init();
			LauncherAudio.Instance.Init();
			HotPatchLoginReport.Report(HotPatchLoginReport.CreateHotPatchLog("device_startup", "success", null, null, null, null));
			this.HotFixSceneManager.SetupScene(worldContext);
			this.HotFixGameSettingManager.ApplyGameSettings();
			LauncherLog.Instance.Info("播放启动进入镜头(睁开眼睛)", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (Platform.Instance.IsCloudGame())
			{
				LauncherLog.Instance.Info("CloudGame HotPatchEnterGame", default(ReadOnlySpan<ValueTuple<string, object>>));
				UKuroCloudGameWrapper.SendDataToPipeBinary("HotPatchEnterGame");
			}
			this.HotFixSceneManager.PlayStartLaunchSeq();
			this.HotFixSceneManager.PlayBlackSeq(delegate
			{
				this.ProcessLineDiff(worldContext);
			});
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000B9DC File Offset: 0x00009BDC
		public void StartLogin()
		{
			this.GameInstance.MountGamePak();
			UCSharpBlueprintFunctionLibrary.LoadDeferredRuntimeAssemblies();
			LauncherLog.Instance.Info("Game Pak mounted, preloading Blueprint Types.", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroLauncherLibrary.ReloadShaderLibrary();
			UKuroLauncherLibrary.PreloadRequiredBp();
			if (!UKuroStaticLibrary.IsEditor(this.GameInstance))
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(this.GameInstance.GetWorld(), "DisableAllScreenMessages", null);
			}
			AActor.SetKuroNetMode(EKuroNetMode.KNM_Net);
			LauncherLog.Instance.Info("Launch success, ready to call main. Byebye launcher.", default(ReadOnlySpan<ValueTuple<string, object>>));
			BaseConfigController.Instance.LoadConfigVersion();
			BaseConfigController.Instance.LoadPatchBuildInfo(true);
			UWwiseExternalSourceStatics.InitExternalSourceConfigs();
			UPuertsBlueprintLibrary.SetEnableBlueprintBind(true);
			UCSharpBlueprintFunctionLibrary.CSharpDoMain(this.GameInstance);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000BA88 File Offset: 0x00009C88
		[NullableContext(2)]
		private void OnHotPatchFinish(bool updated, IDiffPatchProcedure procedure, bool? hasDiskChange = null)
		{
			UKismetSystemLibrary.ControlScreensaver(true);
			this.State = EHotPatchState.Finish;
			LauncherLog.Instance.Info("热更完成", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.HotFixSceneManager.Destroy();
			if (updated && procedure != null && procedure is OpenHarmonyDiffPatchProcedure)
			{
				(procedure as OpenHarmonyDiffPatchProcedure).CleanupPresetResources();
			}
			if (Platform.Instance.IsCloudGameRunningHotPatch())
			{
				AppUtil.QuitGameOnPatchSuccess("HotPatchFinish", hasDiskChange.GetValueOrDefault(updated));
				return;
			}
			this.StartLogin();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000BB04 File Offset: 0x00009D04
		public UniTask ProcessLineDiff(UObject worldContext)
		{
			HotPatch.<ProcessLineDiff>d__10 <ProcessLineDiff>d__;
			<ProcessLineDiff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessLineDiff>d__.<>4__this = this;
			<ProcessLineDiff>d__.worldContext = worldContext;
			<ProcessLineDiff>d__.<>1__state = -1;
			<ProcessLineDiff>d__.<>t__builder.Start<HotPatch.<ProcessLineDiff>d__10>(ref <ProcessLineDiff>d__);
			return <ProcessLineDiff>d__.<>t__builder.Task;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000BB50 File Offset: 0x00009D50
		private unsafe int GetGLDriverVersion(int derfaultVersion, bool onlyAdreno)
		{
			string rhideviceName = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIDeviceName();
			if (onlyAdreno && !rhideviceName.Contains("Adreno"))
			{
				return derfaultVersion;
			}
			string rhidriverVersion = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIDriverVersion();
			string[] array = rhidriverVersion.Split(new string[]
			{
				"V@"
			}, StringSplitOptions.None);
			string input = "";
			if (array.Length > 1)
			{
				input = array[1];
			}
			int num = derfaultVersion;
			MatchCollection matchCollection = Regex.Matches(input, "\\d+");
			if (matchCollection.Count > 0)
			{
				num = int.Parse(matchCollection[0].Value);
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DriverVersion", rhidriverVersion);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("glVersion", num);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return num;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000BC28 File Offset: 0x00009E28
		[return: Nullable(0)]
		private UniTask<bool> CheckIosDeviceSupport(string platform, HotFixManager view, bool noHotPatchProcedure = false)
		{
			HotPatch.<CheckIosDeviceSupport>d__12 <CheckIosDeviceSupport>d__;
			<CheckIosDeviceSupport>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckIosDeviceSupport>d__.platform = platform;
			<CheckIosDeviceSupport>d__.view = view;
			<CheckIosDeviceSupport>d__.noHotPatchProcedure = noHotPatchProcedure;
			<CheckIosDeviceSupport>d__.<>1__state = -1;
			<CheckIosDeviceSupport>d__.<>t__builder.Start<HotPatch.<CheckIosDeviceSupport>d__12>(ref <CheckIosDeviceSupport>d__);
			return <CheckIosDeviceSupport>d__.<>t__builder.Task;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000BC7C File Offset: 0x00009E7C
		private UniTask CheckGLDriver(HotFixManager view)
		{
			HotPatch.<CheckGLDriver>d__13 <CheckGLDriver>d__;
			<CheckGLDriver>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckGLDriver>d__.<>4__this = this;
			<CheckGLDriver>d__.view = view;
			<CheckGLDriver>d__.<>1__state = -1;
			<CheckGLDriver>d__.<>t__builder.Start<HotPatch.<CheckGLDriver>d__13>(ref <CheckGLDriver>d__);
			return <CheckGLDriver>d__.<>t__builder.Task;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000BCC8 File Offset: 0x00009EC8
		private UniTask ShowCompileShadersProgress(HotFixManager view)
		{
			HotPatch.<ShowCompileShadersProgress>d__14 <ShowCompileShadersProgress>d__;
			<ShowCompileShadersProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowCompileShadersProgress>d__.view = view;
			<ShowCompileShadersProgress>d__.<>1__state = -1;
			<ShowCompileShadersProgress>d__.<>t__builder.Start<HotPatch.<ShowCompileShadersProgress>d__14>(ref <ShowCompileShadersProgress>d__);
			return <ShowCompileShadersProgress>d__.<>t__builder.Task;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000BD0C File Offset: 0x00009F0C
		public void ClearPatch()
		{
			LauncherLog.Instance.Info("开始清理补丁！", default(ReadOnlySpan<ValueTuple<string, object>>));
			HotPatchLog hotPatchLog = new HotPatchLog();
			hotPatchLog.s_step_id = "clear_patch_resources";
			HotPatchLogReport.Instance.Report(hotPatchLog);
			ResPackageInfo.LauncherInfo.ClearRecord();
			ResPackageInfo.ResourceInfo.ClearRecord();
			foreach (ResPackageInfo resPackageInfo in ResPackageInfo.GetAllLanguageInfos())
			{
				resPackageInfo.ClearRecord();
			}
			foreach (KeyValuePair<string, ResPackageInfo> keyValuePair in ResPackageInfo.OptionalDownLoadInfo)
			{
				keyValuePair.Value.ClearRecord();
			}
			LauncherLog.Instance.Info("清理全量包,精简包选择记录", default(ReadOnlySpan<ValueTuple<string, object>>));
			LauncherStorageLib.Instance.DeleteDeviceSaved(ELauncherStorageDeviceKey.SelectedMaxOrMinPackType);
			foreach (ResPackageInfo resPackageInfo2 in ResPackageInfo.GetAllTierableBaseInfos())
			{
				foreach (ResPackageInfo resPackageInfo3 in resPackageInfo2.GetAllTierPackageInfos())
				{
					resPackageInfo3.ClearRecord();
				}
			}
			LauncherLog.Instance.Info("清理资源档位选择记录", default(ReadOnlySpan<ValueTuple<string, object>>));
			LauncherStorageLib.Instance.DeleteDeviceSaved(ELauncherStorageDeviceKey.ResourceQualityTier);
			LauncherStorageLib.Instance.DeleteDeviceSaved(ELauncherStorageDeviceKey.TargetResourceQualityTier);
			LauncherStorageLib.Instance.DeleteDeviceSavedString("PendingClearTierDirs");
			HotPatchLog hotPatchLog2 = new HotPatchLog();
			hotPatchLog2.s_step_id = "clear_patch_check";
			List<string> list = new List<string>();
			foreach (string item in UKuroStaticLibrary.GetFilesRecursive(UKuroLauncherLibrary.GameSavedDir() + "Resources/" + UKuroLauncherLibrary.GetAppVersion(), "*", true, false))
			{
				list.Add(item);
			}
			string text = LauncherJson.Stringify<List<string>>(list, null);
			hotPatchLog2.s_step_result = text;
			HotPatchLogReport.Instance.Report(hotPatchLog2);
			string item2 = null;
			if (UKuroLauncherLibrary.Encrypt(text, ref item2))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "clear patch!";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ret", item2);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "clear patch!";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ret", text);
				instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			this.RestartToBootstrap(true, true);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000BFBC File Offset: 0x0000A1BC
		private void RestartToBootstrap(bool notifyClearPatch, bool bClearAll = true)
		{
			LauncherProcedure.Destroy();
			UKuroSqliteLibrary.CloseAllConnections();
			UKuroPrepareStatementLib.CloseAllConnection();
			UKuroGameBudgetBlueprintDefine.Clear();
			if (notifyClearPatch)
			{
				Action onClearPatch = HotPatch.OnClearPatch;
				if (onClearPatch != null)
				{
					onClearPatch();
				}
			}
			HotFixSceneManager.StopHotPatchBgm();
			if (bClearAll)
			{
				UKuroLauncherLibrary.WillClearPatchPaks();
			}
			UGameplayStatics.OpenLevel(this.WorldContext, new FName("/Game/Aki/Map/Launch/Bootstrap"), true, "");
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000C018 File Offset: 0x0000A218
		private void ProcessPendingTierClear()
		{
			string deviceSavedString = LauncherStorageLib.Instance.GetDeviceSavedString("PendingClearTierDirs", "");
			if (string.IsNullOrEmpty(deviceSavedString))
			{
				return;
			}
			try
			{
				List<string> list = LauncherJson.Parse<List<string>>(deviceSavedString, null);
				if (list != null)
				{
					List<string> list2 = new List<string>();
					foreach (string text in list)
					{
						if (UBlueprintPathsLibrary.DirectoryExists(text))
						{
							LauncherLog instance = LauncherLog.Instance;
							string message = "补删旧档位目录";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dir", text);
							instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							UKuroLauncherLibrary.DeleteDirectory(text);
							if (UBlueprintPathsLibrary.DirectoryExists(text))
							{
								list2.Add(text);
							}
						}
					}
					if (list2.Count > 0)
					{
						LauncherLog instance2 = LauncherLog.Instance;
						string message2 = "部分旧档位目录未能删除，保留记录待下次重试";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("count", list2.Count);
						instance2.Warn(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						LauncherStorageLib.Instance.SetDeviceSavedString("PendingClearTierDirs", LauncherJson.Stringify<List<string>>(list2, null));
						return;
					}
				}
			}
			catch (Exception)
			{
				LauncherLog instance3 = LauncherLog.Instance;
				string message3 = "解析待补删旧档目录记录失败";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("record", deviceSavedString);
				instance3.Error(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
			LauncherStorageLib.Instance.DeleteDeviceSavedString("PendingClearTierDirs");
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000C174 File Offset: 0x0000A374
		public unsafe void ApplyTierChange(ETier oldTier, ETier newTier)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "开始切换资源档位";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("old", oldTier);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("new", newTier);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			HotPatchLog hotPatchLog = new HotPatchLog();
			hotPatchLog.s_step_id = "apply_tier_change";
			HotPatchLogReport.Instance.Report(hotPatchLog);
			List<string> list = new List<string>();
			foreach (ResPackageInfo resPackageInfo in ResPackageInfo.GetAllTierableBaseInfos())
			{
				ResPackageInfo tierPackageInfo = resPackageInfo.GetTierPackageInfo(newTier);
				foreach (ResPackageInfo resPackageInfo2 in resPackageInfo.GetAllTierPackageInfos())
				{
					if (resPackageInfo2 != tierPackageInfo)
					{
						resPackageInfo2.ClearRecord();
						list.AddRange(resPackageInfo2.DeleteTierLocalFiles());
					}
				}
			}
			foreach (ETier etier in new ETier[]
			{
				ETier.SD,
				ETier.HD,
				ETier.UHD
			})
			{
				if (etier != newTier)
				{
					list.Add(VideoResUpdate.Instance.DeleteTierVideoDir(etier));
				}
			}
			if (list.Count > 0)
			{
				LauncherStorageLib.Instance.SetDeviceSavedString("PendingClearTierDirs", LauncherJson.Stringify<List<string>>(list, null));
			}
			if (oldTier != newTier)
			{
				this.ResetPreDownloadForTierChange();
			}
			LauncherStorageLib.Instance.SetDeviceSaved<ETier>(ELauncherStorageDeviceKey.ResourceQualityTier, newTier);
			LauncherStorageLib.Instance.DeleteDeviceSaved(ELauncherStorageDeviceKey.TargetResourceQualityTier);
			this.RestartToBootstrap(false, false);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000C32C File Offset: 0x0000A52C
		private void ResetPreDownloadForTierChange()
		{
			if (string.IsNullOrEmpty(LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PreDownloadRecord, "")))
			{
				return;
			}
			LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.PreDownloadRecord, "");
			LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.PreDownloadState, "1");
			LauncherLog.Instance.Info("切档已重置预下载完成标记，预下载将重新可用", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000C38E File Offset: 0x0000A58E
		public static HotPatch Instance
		{
			get
			{
				if (HotPatch._instance == null)
				{
					HotPatch._instance = new HotPatch();
					HotPatch._instance.OnInit();
				}
				return HotPatch._instance;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000C3B1 File Offset: 0x0000A5B1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000C3B3 File Offset: 0x0000A5B3
		public static void ResetStaticDefaultValue()
		{
			HotPatch instance = HotPatch._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotPatch._instance = null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		static HotPatch()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatch.CreateStaticDefaultValue), new Action(HotPatch.ResetStaticDefaultValue));
		}

		// Token: 0x04000109 RID: 265
		[Nullable(2)]
		[StaticVariableRuleIgnore]
		public static Action OnClearPatch;

		// Token: 0x0400010A RID: 266
		[Nullable(2)]
		private UObject WorldContext;

		// Token: 0x0400010B RID: 267
		[Nullable(2)]
		private BP_MainGameInstance_C GameInstance;

		// Token: 0x0400010C RID: 268
		protected EHotPatchState State;

		// Token: 0x0400010D RID: 269
		private readonly AppPathMisc PathModule = new AppPathMisc();

		// Token: 0x0400010E RID: 270
		public readonly HotFixSceneManager HotFixSceneManager = new HotFixSceneManager();

		// Token: 0x0400010F RID: 271
		private readonly HotFixGameSettingManager HotFixGameSettingManager = new HotFixGameSettingManager();

		// Token: 0x04000110 RID: 272
		private const string PendingClearTierDirsKey = "PendingClearTierDirs";

		// Token: 0x04000111 RID: 273
		[Nullable(2)]
		private static HotPatch _instance;
	}
}
