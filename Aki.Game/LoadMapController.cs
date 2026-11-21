using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02002A52 RID: 10834
[NullableContext(1)]
[Nullable(0)]
public class LoadMapController : ControllerBase
{
	// Token: 0x0601B740 RID: 112448 RVA: 0x00873C59 File Offset: 0x00871E59
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601B741 RID: 112449 RVA: 0x00873C5C File Offset: 0x00871E5C
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0601B742 RID: 112450 RVA: 0x00873C5F File Offset: 0x00871E5F
	protected override void OnTick(float delta)
	{
	}

	// Token: 0x0601B743 RID: 112451 RVA: 0x00873C64 File Offset: 0x00871E64
	private UniTask OpenLoadingAsync()
	{
		LoadMapController.<OpenLoadingAsync>d__3 <OpenLoadingAsync>d__;
		<OpenLoadingAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenLoadingAsync>d__.<>1__state = -1;
		<OpenLoadingAsync>d__.<>t__builder.Start<LoadMapController.<OpenLoadingAsync>d__3>(ref <OpenLoadingAsync>d__);
		return <OpenLoadingAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B744 RID: 112452 RVA: 0x00873CA0 File Offset: 0x00871EA0
	private UniTask CheckQuestResource()
	{
		LoadMapController.<CheckQuestResource>d__4 <CheckQuestResource>d__;
		<CheckQuestResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckQuestResource>d__.<>1__state = -1;
		<CheckQuestResource>d__.<>t__builder.Start<LoadMapController.<CheckQuestResource>d__4>(ref <CheckQuestResource>d__);
		return <CheckQuestResource>d__.<>t__builder.Task;
	}

	// Token: 0x0601B745 RID: 112453 RVA: 0x00873CDB File Offset: 0x00871EDB
	private void DisableWorldPartition()
	{
		GameModeController.Instance.InitStreamingSources();
		GameModeModel.Instance.DisableStreamingSources();
	}

	// Token: 0x0601B746 RID: 112454 RVA: 0x00873CF4 File Offset: 0x00871EF4
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

	// Token: 0x0601B747 RID: 112455 RVA: 0x00873D28 File Offset: 0x00871F28
	private void PreLoadLevels()
	{
		EventSystem.Instance.Emit(EEventName.BeforeLoadMap);
		LoadModeManager.Instance.SetLoadModeByReason(ELoadMode.Loading, ELoadModeReason.PreLoadLevelInstance);
		AActor.SetKuroNetMode(EKuroNetMode.KNM_Net);
		UiManager.Instance.LockOpen();
		Net.Instance.PauseAllNotifyCallback();
		GameModeModel.Instance.AddLoadMapHandle("LoadMapController.WorldPartitionLoadLevelInstance");
	}

	// Token: 0x0601B748 RID: 112456 RVA: 0x00873D7C File Offset: 0x00871F7C
	private void PostLoadLevels()
	{
		Net.Instance.ResumeAllNotifyCallback();
		UiManager.Instance.UnLockOpen();
		LevelSequencePlayer.SetBanned(false);
		LguiEventSystemManager.Instance.RefreshCurrentInputModule();
		LoadingController.Instance.SetProgress(30, null, 1, false, true);
	}

	// Token: 0x0601B749 RID: 112457 RVA: 0x00873DB4 File Offset: 0x00871FB4
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

	// Token: 0x0601B74A RID: 112458 RVA: 0x00873E00 File Offset: 0x00872000
	private UniTask LoadLevelsAsync()
	{
		LoadMapController.<LoadLevelsAsync>d__10 <LoadLevelsAsync>d__;
		<LoadLevelsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadLevelsAsync>d__.<>4__this = this;
		<LoadLevelsAsync>d__.<>1__state = -1;
		<LoadLevelsAsync>d__.<>t__builder.Start<LoadMapController.<LoadLevelsAsync>d__10>(ref <LoadLevelsAsync>d__);
		return <LoadLevelsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B74B RID: 112459 RVA: 0x00873E44 File Offset: 0x00872044
	private UniTask ApplyMaterialParameterCollectionAsync(SceneInformation sceneInformation)
	{
		LoadMapController.<ApplyMaterialParameterCollectionAsync>d__11 <ApplyMaterialParameterCollectionAsync>d__;
		<ApplyMaterialParameterCollectionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ApplyMaterialParameterCollectionAsync>d__.sceneInformation = sceneInformation;
		<ApplyMaterialParameterCollectionAsync>d__.<>1__state = -1;
		<ApplyMaterialParameterCollectionAsync>d__.<>t__builder.Start<LoadMapController.<ApplyMaterialParameterCollectionAsync>d__11>(ref <ApplyMaterialParameterCollectionAsync>d__);
		return <ApplyMaterialParameterCollectionAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B74C RID: 112460 RVA: 0x00873E88 File Offset: 0x00872088
	private UniTask CommonAndEntityPreloadAsync()
	{
		LoadMapController.<CommonAndEntityPreloadAsync>d__12 <CommonAndEntityPreloadAsync>d__;
		<CommonAndEntityPreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CommonAndEntityPreloadAsync>d__.<>1__state = -1;
		<CommonAndEntityPreloadAsync>d__.<>t__builder.Start<LoadMapController.<CommonAndEntityPreloadAsync>d__12>(ref <CommonAndEntityPreloadAsync>d__);
		return <CommonAndEntityPreloadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B74D RID: 112461 RVA: 0x00873EC4 File Offset: 0x008720C4
	private UniTask LoadBattleViewAsync()
	{
		LoadMapController.<LoadBattleViewAsync>d__13 <LoadBattleViewAsync>d__;
		<LoadBattleViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadBattleViewAsync>d__.<>1__state = -1;
		<LoadBattleViewAsync>d__.<>t__builder.Start<LoadMapController.<LoadBattleViewAsync>d__13>(ref <LoadBattleViewAsync>d__);
		return <LoadBattleViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B74E RID: 112462 RVA: 0x00873F00 File Offset: 0x00872100
	private UniTask ControllerPreloadAsync()
	{
		LoadMapController.<ControllerPreloadAsync>d__14 <ControllerPreloadAsync>d__;
		<ControllerPreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ControllerPreloadAsync>d__.<>4__this = this;
		<ControllerPreloadAsync>d__.<>1__state = -1;
		<ControllerPreloadAsync>d__.<>t__builder.Start<LoadMapController.<ControllerPreloadAsync>d__14>(ref <ControllerPreloadAsync>d__);
		return <ControllerPreloadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B74F RID: 112463 RVA: 0x00873F44 File Offset: 0x00872144
	private UniTask AfterJoinSceneAsync()
	{
		LoadMapController.<AfterJoinSceneAsync>d__15 <AfterJoinSceneAsync>d__;
		<AfterJoinSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AfterJoinSceneAsync>d__.<>1__state = -1;
		<AfterJoinSceneAsync>d__.<>t__builder.Start<LoadMapController.<AfterJoinSceneAsync>d__15>(ref <AfterJoinSceneAsync>d__);
		return <AfterJoinSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B750 RID: 112464 RVA: 0x00873F80 File Offset: 0x00872180
	private UniTask LoadSubLevelsAsync(SceneInformation sceneInformation)
	{
		LoadMapController.<LoadSubLevelsAsync>d__16 <LoadSubLevelsAsync>d__;
		<LoadSubLevelsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadSubLevelsAsync>d__.sceneInformation = sceneInformation;
		<LoadSubLevelsAsync>d__.<>1__state = -1;
		<LoadSubLevelsAsync>d__.<>t__builder.Start<LoadMapController.<LoadSubLevelsAsync>d__16>(ref <LoadSubLevelsAsync>d__);
		return <LoadSubLevelsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B751 RID: 112465 RVA: 0x00873FC4 File Offset: 0x008721C4
	private UniTask VoxelStreamingAsync()
	{
		LoadMapController.<VoxelStreamingAsync>d__17 <VoxelStreamingAsync>d__;
		<VoxelStreamingAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<VoxelStreamingAsync>d__.<>1__state = -1;
		<VoxelStreamingAsync>d__.<>t__builder.Start<LoadMapController.<VoxelStreamingAsync>d__17>(ref <VoxelStreamingAsync>d__);
		return <VoxelStreamingAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B752 RID: 112466 RVA: 0x00874000 File Offset: 0x00872200
	private UniTask StreamingAsync()
	{
		LoadMapController.<StreamingAsync>d__18 <StreamingAsync>d__;
		<StreamingAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StreamingAsync>d__.<>1__state = -1;
		<StreamingAsync>d__.<>t__builder.Start<LoadMapController.<StreamingAsync>d__18>(ref <StreamingAsync>d__);
		return <StreamingAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B753 RID: 112467 RVA: 0x0087403C File Offset: 0x0087223C
	private UniTask CreateEntityAsync()
	{
		LoadMapController.<CreateEntityAsync>d__19 <CreateEntityAsync>d__;
		<CreateEntityAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateEntityAsync>d__.<>1__state = -1;
		<CreateEntityAsync>d__.<>t__builder.Start<LoadMapController.<CreateEntityAsync>d__19>(ref <CreateEntityAsync>d__);
		return <CreateEntityAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B754 RID: 112468 RVA: 0x00874078 File Offset: 0x00872278
	private UniTask RenderAssetStreamingAsync()
	{
		LoadMapController.<RenderAssetStreamingAsync>d__20 <RenderAssetStreamingAsync>d__;
		<RenderAssetStreamingAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RenderAssetStreamingAsync>d__.<>1__state = -1;
		<RenderAssetStreamingAsync>d__.<>t__builder.Start<LoadMapController.<RenderAssetStreamingAsync>d__20>(ref <RenderAssetStreamingAsync>d__);
		return <RenderAssetStreamingAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B755 RID: 112469 RVA: 0x008740B4 File Offset: 0x008722B4
	private UniTask WorldDoneAsync(bool isSeamlessTravel)
	{
		LoadMapController.<WorldDoneAsync>d__21 <WorldDoneAsync>d__;
		<WorldDoneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WorldDoneAsync>d__.isSeamlessTravel = isSeamlessTravel;
		<WorldDoneAsync>d__.<>1__state = -1;
		<WorldDoneAsync>d__.<>t__builder.Start<LoadMapController.<WorldDoneAsync>d__21>(ref <WorldDoneAsync>d__);
		return <WorldDoneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B756 RID: 112470 RVA: 0x008740F8 File Offset: 0x008722F8
	private UniTask LoadEndAsync(string sceneId)
	{
		LoadMapController.<LoadEndAsync>d__22 <LoadEndAsync>d__;
		<LoadEndAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadEndAsync>d__.sceneId = sceneId;
		<LoadEndAsync>d__.<>1__state = -1;
		<LoadEndAsync>d__.<>t__builder.Start<LoadMapController.<LoadEndAsync>d__22>(ref <LoadEndAsync>d__);
		return <LoadEndAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B757 RID: 112471 RVA: 0x0087413C File Offset: 0x0087233C
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

	// Token: 0x17002C7E RID: 11390
	// (get) Token: 0x0601B758 RID: 112472 RVA: 0x00874187 File Offset: 0x00872387
	public static LoadMapController Instance
	{
		get
		{
			return LoadMapController._Instance;
		}
	}

	// Token: 0x0601B759 RID: 112473 RVA: 0x0087418E File Offset: 0x0087238E
	public static LoadMapController GetOrCreateInstance()
	{
		if (LoadMapController._Instance == null)
		{
			LoadMapController.CreateInstance();
		}
		return LoadMapController._Instance;
	}

	// Token: 0x0601B75A RID: 112474 RVA: 0x008741A2 File Offset: 0x008723A2
	public static bool CreateInstance()
	{
		if (LoadMapController._Instance != null)
		{
			return true;
		}
		LoadMapController._Instance = new LoadMapController();
		return true;
	}

	// Token: 0x0601B75B RID: 112475 RVA: 0x008741B8 File Offset: 0x008723B8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B75C RID: 112476 RVA: 0x008741BA File Offset: 0x008723BA
	public static void ResetStaticDefaultValue()
	{
		LoadMapController._Instance = null;
	}

	// Token: 0x0601B75D RID: 112477 RVA: 0x008741C2 File Offset: 0x008723C2
	static LoadMapController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoadMapController.CreateStaticDefaultValue), new Action(LoadMapController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ED4B RID: 60747
	[Nullable(2)]
	private static LoadMapController _Instance;
}
