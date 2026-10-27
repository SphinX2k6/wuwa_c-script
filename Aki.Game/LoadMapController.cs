using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x020034DE RID: 13534
[NullableContext(1)]
[Nullable(0)]
public class LoadMapController : ControllerBase
{
	// Token: 0x0601DA36 RID: 121398 RVA: 0x0084BA4D File Offset: 0x00849C4D
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601DA37 RID: 121399 RVA: 0x0084BA50 File Offset: 0x00849C50
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0601DA38 RID: 121400 RVA: 0x0084BA53 File Offset: 0x00849C53
	protected override void OnTick(float delta)
	{
	}

	// Token: 0x0601DA39 RID: 121401 RVA: 0x0084BA58 File Offset: 0x00849C58
	private UniTask OpenLoadingAsync()
	{
		LoadMapController.<OpenLoadingAsync>d__3 <OpenLoadingAsync>d__;
		<OpenLoadingAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenLoadingAsync>d__.<>1__state = -1;
		<OpenLoadingAsync>d__.<>t__builder.Start<LoadMapController.<OpenLoadingAsync>d__3>(ref <OpenLoadingAsync>d__);
		return <OpenLoadingAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA3A RID: 121402 RVA: 0x0084BA94 File Offset: 0x00849C94
	private UniTask CheckQuestResource()
	{
		LoadMapController.<CheckQuestResource>d__4 <CheckQuestResource>d__;
		<CheckQuestResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckQuestResource>d__.<>1__state = -1;
		<CheckQuestResource>d__.<>t__builder.Start<LoadMapController.<CheckQuestResource>d__4>(ref <CheckQuestResource>d__);
		return <CheckQuestResource>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA3B RID: 121403 RVA: 0x0084BACF File Offset: 0x00849CCF
	private void DisableWorldPartition()
	{
		GameModeController.Instance.InitStreamingSources();
		GameModeModel.Instance.DisableStreamingSources();
	}

	// Token: 0x0601DA3C RID: 121404 RVA: 0x0084BAE8 File Offset: 0x00849CE8
	private void SetAlwaysLoadActorsEnable(bool enableActor)
	{
		UWorld world = GlobalData.World.GetWorld();
		if (world != null && world.IsValid())
		{
			if (enableActor)
			{
				UKuroLevelPlayLibrary.FakeAddAlwaysLoadedActorsToWorld(world);
				return;
			}
			UKuroLevelPlayLibrary.FakeRemoveAlwaysLoadedActorsFromWorld(world);
		}
	}

	// Token: 0x0601DA3D RID: 121405 RVA: 0x0084BB1C File Offset: 0x00849D1C
	private void PreLoadLevels()
	{
		EventSystem.Instance.Emit(EEventName.BeforeLoadMap);
		LoadModeManager.Instance.SetLoadModeByReason(ELoadMode.Loading, ELoadModeReason.PreLoadLevelInstance);
		AActor.SetKuroNetMode(EKuroNetMode.KNM_Net);
		UiManager.Instance.LockOpen();
		Net.Instance.PauseAllNotifyCallback();
		GameModeModel.Instance.AddLoadMapHandle("LoadMapController.WorldPartitionLoadLevelInstance");
	}

	// Token: 0x0601DA3E RID: 121406 RVA: 0x0084BB70 File Offset: 0x00849D70
	private void PostLoadLevels()
	{
		Net.Instance.ResumeAllNotifyCallback();
		UiManager.Instance.UnLockOpen();
		LevelSequencePlayer.SetBanned(false);
		LguiEventSystemManager.Instance.RefreshCurrentInputModule();
		LoadingController.Instance.SetProgress(30, null, 1, false, true);
	}

	// Token: 0x0601DA3F RID: 121407 RVA: 0x0084BBA8 File Offset: 0x00849DA8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<ULevelStreamingDynamic> LoadLevelInstanceAsync(string mapPath, bool shouldBeLoaded, bool shouldBeVisible)
	{
		LoadMapController.<LoadLevelInstanceAsync>d__9 <LoadLevelInstanceAsync>d__;
		<LoadLevelInstanceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ULevelStreamingDynamic>.Create();
		<LoadLevelInstanceAsync>d__.mapPath = mapPath;
		<LoadLevelInstanceAsync>d__.shouldBeVisible = shouldBeVisible;
		<LoadLevelInstanceAsync>d__.<>1__state = -1;
		<LoadLevelInstanceAsync>d__.<>t__builder.Start<LoadMapController.<LoadLevelInstanceAsync>d__9>(ref <LoadLevelInstanceAsync>d__);
		return <LoadLevelInstanceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA40 RID: 121408 RVA: 0x0084BBF4 File Offset: 0x00849DF4
	private UniTask LoadLevelsAsync()
	{
		LoadMapController.<LoadLevelsAsync>d__10 <LoadLevelsAsync>d__;
		<LoadLevelsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadLevelsAsync>d__.<>4__this = this;
		<LoadLevelsAsync>d__.<>1__state = -1;
		<LoadLevelsAsync>d__.<>t__builder.Start<LoadMapController.<LoadLevelsAsync>d__10>(ref <LoadLevelsAsync>d__);
		return <LoadLevelsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA41 RID: 121409 RVA: 0x0084BC38 File Offset: 0x00849E38
	private UniTask ApplyMaterialParameterCollectionAsync(SceneInformation sceneInformation)
	{
		LoadMapController.<ApplyMaterialParameterCollectionAsync>d__11 <ApplyMaterialParameterCollectionAsync>d__;
		<ApplyMaterialParameterCollectionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ApplyMaterialParameterCollectionAsync>d__.sceneInformation = sceneInformation;
		<ApplyMaterialParameterCollectionAsync>d__.<>1__state = -1;
		<ApplyMaterialParameterCollectionAsync>d__.<>t__builder.Start<LoadMapController.<ApplyMaterialParameterCollectionAsync>d__11>(ref <ApplyMaterialParameterCollectionAsync>d__);
		return <ApplyMaterialParameterCollectionAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA42 RID: 121410 RVA: 0x0084BC7C File Offset: 0x00849E7C
	private UniTask CommonAndEntityPreloadAsync()
	{
		LoadMapController.<CommonAndEntityPreloadAsync>d__12 <CommonAndEntityPreloadAsync>d__;
		<CommonAndEntityPreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CommonAndEntityPreloadAsync>d__.<>1__state = -1;
		<CommonAndEntityPreloadAsync>d__.<>t__builder.Start<LoadMapController.<CommonAndEntityPreloadAsync>d__12>(ref <CommonAndEntityPreloadAsync>d__);
		return <CommonAndEntityPreloadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA43 RID: 121411 RVA: 0x0084BCB8 File Offset: 0x00849EB8
	private UniTask LoadBattleViewAsync()
	{
		LoadMapController.<LoadBattleViewAsync>d__13 <LoadBattleViewAsync>d__;
		<LoadBattleViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadBattleViewAsync>d__.<>1__state = -1;
		<LoadBattleViewAsync>d__.<>t__builder.Start<LoadMapController.<LoadBattleViewAsync>d__13>(ref <LoadBattleViewAsync>d__);
		return <LoadBattleViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA44 RID: 121412 RVA: 0x0084BCF4 File Offset: 0x00849EF4
	private UniTask ControllerPreloadAsync()
	{
		LoadMapController.<ControllerPreloadAsync>d__14 <ControllerPreloadAsync>d__;
		<ControllerPreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ControllerPreloadAsync>d__.<>4__this = this;
		<ControllerPreloadAsync>d__.<>1__state = -1;
		<ControllerPreloadAsync>d__.<>t__builder.Start<LoadMapController.<ControllerPreloadAsync>d__14>(ref <ControllerPreloadAsync>d__);
		return <ControllerPreloadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA45 RID: 121413 RVA: 0x0084BD38 File Offset: 0x00849F38
	private UniTask AfterJoinSceneAsync()
	{
		LoadMapController.<AfterJoinSceneAsync>d__15 <AfterJoinSceneAsync>d__;
		<AfterJoinSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AfterJoinSceneAsync>d__.<>1__state = -1;
		<AfterJoinSceneAsync>d__.<>t__builder.Start<LoadMapController.<AfterJoinSceneAsync>d__15>(ref <AfterJoinSceneAsync>d__);
		return <AfterJoinSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA46 RID: 121414 RVA: 0x0084BD74 File Offset: 0x00849F74
	private UniTask LoadSubLevelsAsync(SceneInformation sceneInformation)
	{
		LoadMapController.<LoadSubLevelsAsync>d__16 <LoadSubLevelsAsync>d__;
		<LoadSubLevelsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadSubLevelsAsync>d__.sceneInformation = sceneInformation;
		<LoadSubLevelsAsync>d__.<>1__state = -1;
		<LoadSubLevelsAsync>d__.<>t__builder.Start<LoadMapController.<LoadSubLevelsAsync>d__16>(ref <LoadSubLevelsAsync>d__);
		return <LoadSubLevelsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA47 RID: 121415 RVA: 0x0084BDB8 File Offset: 0x00849FB8
	private UniTask VoxelStreamingAsync()
	{
		LoadMapController.<VoxelStreamingAsync>d__17 <VoxelStreamingAsync>d__;
		<VoxelStreamingAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<VoxelStreamingAsync>d__.<>1__state = -1;
		<VoxelStreamingAsync>d__.<>t__builder.Start<LoadMapController.<VoxelStreamingAsync>d__17>(ref <VoxelStreamingAsync>d__);
		return <VoxelStreamingAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA48 RID: 121416 RVA: 0x0084BDF4 File Offset: 0x00849FF4
	private UniTask StreamingAsync()
	{
		LoadMapController.<StreamingAsync>d__18 <StreamingAsync>d__;
		<StreamingAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StreamingAsync>d__.<>1__state = -1;
		<StreamingAsync>d__.<>t__builder.Start<LoadMapController.<StreamingAsync>d__18>(ref <StreamingAsync>d__);
		return <StreamingAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA49 RID: 121417 RVA: 0x0084BE30 File Offset: 0x0084A030
	private UniTask CreateEntityAsync()
	{
		LoadMapController.<CreateEntityAsync>d__19 <CreateEntityAsync>d__;
		<CreateEntityAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateEntityAsync>d__.<>1__state = -1;
		<CreateEntityAsync>d__.<>t__builder.Start<LoadMapController.<CreateEntityAsync>d__19>(ref <CreateEntityAsync>d__);
		return <CreateEntityAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA4A RID: 121418 RVA: 0x0084BE6C File Offset: 0x0084A06C
	private UniTask RenderAssetStreamingAsync()
	{
		LoadMapController.<RenderAssetStreamingAsync>d__20 <RenderAssetStreamingAsync>d__;
		<RenderAssetStreamingAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RenderAssetStreamingAsync>d__.<>1__state = -1;
		<RenderAssetStreamingAsync>d__.<>t__builder.Start<LoadMapController.<RenderAssetStreamingAsync>d__20>(ref <RenderAssetStreamingAsync>d__);
		return <RenderAssetStreamingAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA4B RID: 121419 RVA: 0x0084BEA8 File Offset: 0x0084A0A8
	private UniTask WorldDoneAsync(bool isSeamlessTravel)
	{
		LoadMapController.<WorldDoneAsync>d__21 <WorldDoneAsync>d__;
		<WorldDoneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WorldDoneAsync>d__.isSeamlessTravel = isSeamlessTravel;
		<WorldDoneAsync>d__.<>1__state = -1;
		<WorldDoneAsync>d__.<>t__builder.Start<LoadMapController.<WorldDoneAsync>d__21>(ref <WorldDoneAsync>d__);
		return <WorldDoneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA4C RID: 121420 RVA: 0x0084BEEC File Offset: 0x0084A0EC
	private UniTask LoadEndAsync(string sceneId)
	{
		LoadMapController.<LoadEndAsync>d__22 <LoadEndAsync>d__;
		<LoadEndAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadEndAsync>d__.sceneId = sceneId;
		<LoadEndAsync>d__.<>1__state = -1;
		<LoadEndAsync>d__.<>t__builder.Start<LoadMapController.<LoadEndAsync>d__22>(ref <LoadEndAsync>d__);
		return <LoadEndAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601DA4D RID: 121421 RVA: 0x0084BF30 File Offset: 0x0084A130
	public UniTask Load(SceneInformation sceneInformation)
	{
		LoadMapController.<Load>d__23 <Load>d__;
		<Load>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Load>d__.<>4__this = this;
		<Load>d__.sceneInformation = sceneInformation;
		<Load>d__.<>1__state = -1;
		<Load>d__.<>t__builder.Start<LoadMapController.<Load>d__23>(ref <Load>d__);
		return <Load>d__.<>t__builder.Task;
	}

	// Token: 0x170028E6 RID: 10470
	// (get) Token: 0x0601DA4E RID: 121422 RVA: 0x0084BF7B File Offset: 0x0084A17B
	public static LoadMapController Instance
	{
		get
		{
			return LoadMapController._Instance;
		}
	}

	// Token: 0x0601DA4F RID: 121423 RVA: 0x0084BF82 File Offset: 0x0084A182
	public static LoadMapController GetOrCreateInstance()
	{
		if (LoadMapController._Instance == null)
		{
			LoadMapController.CreateInstance();
		}
		return LoadMapController._Instance;
	}

	// Token: 0x0601DA50 RID: 121424 RVA: 0x0084BF96 File Offset: 0x0084A196
	public static bool CreateInstance()
	{
		if (LoadMapController._Instance != null)
		{
			return true;
		}
		LoadMapController._Instance = new LoadMapController();
		return true;
	}

	// Token: 0x0601DA51 RID: 121425 RVA: 0x0084BFAC File Offset: 0x0084A1AC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DA52 RID: 121426 RVA: 0x0084BFAE File Offset: 0x0084A1AE
	public static void ResetStaticDefaultValue()
	{
		LoadMapController._Instance = null;
	}

	// Token: 0x0601DA53 RID: 121427 RVA: 0x0084BFB6 File Offset: 0x0084A1B6
	static LoadMapController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoadMapController.CreateStaticDefaultValue), new Action(LoadMapController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E894 RID: 59540
	[Nullable(2)]
	private static LoadMapController _Instance;
}
