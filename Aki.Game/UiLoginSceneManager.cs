using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x020021B4 RID: 8628
[NullableContext(1)]
[Nullable(0)]
public class UiLoginSceneManager : Singleton
{
	// Token: 0x060153B8 RID: 86968 RVA: 0x0062C560 File Offset: 0x0062A760
	public TsUiSceneRoleActor GetRoleObserver(int roleId)
	{
		TsUiSceneRoleActor tsUiSceneRoleActor;
		if (!this.Observers.TryGetValue(roleId, out tsUiSceneRoleActor) && GlobalData.World != null)
		{
			tsUiSceneRoleActor = UiSceneRoleActorManager.Instance.CreateUiSceneRoleActor(EUiModelUseWay.RoleInLogin);
			this.Observers[roleId] = tsUiSceneRoleActor;
		}
		return tsUiSceneRoleActor;
	}

	// Token: 0x060153B9 RID: 86969 RVA: 0x0062C5A0 File Offset: 0x0062A7A0
	private void DestroyCreateCharacterObservers()
	{
		foreach (int taskId in this.HuluHandleList)
		{
			MeshStreamController.Instance.RemoveMeshStreamTask(taskId);
		}
		foreach (TsUiSceneRoleActor tsUiSceneRoleActor in this.Observers.Values)
		{
			int roleActorIndex = tsUiSceneRoleActor.GetRoleActorIndex();
			UiSceneRoleActorManager.Instance.DestroyUiSceneRoleActor(roleActorIndex);
		}
		this.RoleLoadingFinishList.Clear();
		this.Observers.Clear();
	}

	// Token: 0x060153BA RID: 86970 RVA: 0x0062C660 File Offset: 0x0062A860
	public void InitCinematicTick()
	{
		this.CinematicTick = ActorSystem.Instance.Get<BP_Cinematics_Tick_C>(BP_Cinematics_Tick_C.StaticClass(), new FTransformDouble(), null, true);
		this.Spotlight1 = ActorSystem.Instance.Get<ASpotLight>(ASpotLight.StaticClass(), new FTransformDouble(), null, true);
		this.Spotlight2 = ActorSystem.Instance.Get<ASpotLight>(ASpotLight.StaticClass(), new FTransformDouble(), null, true);
	}

	// Token: 0x060153BB RID: 86971 RVA: 0x0062C6C4 File Offset: 0x0062A8C4
	private void BindCinematicTick()
	{
		IReadOnlyList<int> initialRoles = CreateCharacterConfig.Instance.GetInitialRoles();
		int roleId = initialRoles[0];
		int roleId2 = initialRoles[1];
		this.CinematicTick.UISceneRole_2 = this.GetActorMeshComponent(roleId2);
		this.CinematicTick.UISceneRole = this.GetActorMeshComponent(roleId);
		this.CinematicTick.Is_Tick = 1;
	}

	// Token: 0x060153BC RID: 86972 RVA: 0x0062C71A File Offset: 0x0062A91A
	private USkeletalMeshComponent GetActorMeshComponent(int roleId)
	{
		UiModelBase model = this.Observers[roleId].Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent == null)
		{
			return null;
		}
		return uiModelActorComponent.MainMeshComponent;
	}

	// Token: 0x060153BD RID: 86973 RVA: 0x0062C744 File Offset: 0x0062A944
	private void DestroyCinematicTick()
	{
		if (this.CinematicTick != null)
		{
			ActorSystem.Instance.Put("UiLoginSceneManager.DestroyCinematicTick1", this.CinematicTick, null);
			this.CinematicTick = null;
		}
		if (this.Spotlight1 != null)
		{
			ActorSystem.Instance.Put("UiLoginSceneManager.DestroyCinematicTick2", this.Spotlight1, null);
			this.Spotlight1 = null;
		}
		if (this.Spotlight2 != null)
		{
			ActorSystem.Instance.Put("UiLoginSceneManager.DestroyCinematicTick3", this.Spotlight2, null);
			this.Spotlight2 = null;
		}
	}

	// Token: 0x060153BE RID: 86974 RVA: 0x0062C7C4 File Offset: 0x0062A9C4
	public void InitRoleObservers(Action delegateAction = null)
	{
		this.InitRoleFinishDelegate = delegateAction;
		this.DestroyCreateCharacterObservers();
		IReadOnlyList<int> initialRoles = CreateCharacterConfig.Instance.GetInitialRoles();
		int roleId = initialRoles[0];
		this.CreateRoleObserver(roleId, "GirlCase");
		int roleId2 = initialRoles[1];
		this.CreateRoleObserver(roleId2, "BoyCase");
	}

	// Token: 0x060153BF RID: 86975 RVA: 0x0062C810 File Offset: 0x0062AA10
	private void CreateRoleObserver(int roleId, string tag)
	{
		TsUiSceneRoleActor observer = this.GetRoleObserver(roleId);
		UiModelBase model = observer.Model;
		UiModelBase model3 = model;
		UiRoleLoadComponent uiRoleLoadComponent = (model3 != null) ? model3.CheckGetComponent<UiRoleLoadComponent>() : null;
		if (uiRoleLoadComponent == null)
		{
			return;
		}
		Action <>9__1;
		uiRoleLoadComponent.LoadModelByRoleConfigId(roleId, -1, false, delegate
		{
			UiRoleHuluComponent uiRoleHuluComponent = model.CheckGetComponent<UiRoleHuluComponent>();
			object obj;
			if (uiRoleHuluComponent == null)
			{
				obj = null;
			}
			else
			{
				SkeletalObserverHandle huluHandle = uiRoleHuluComponent.GetHuluHandle();
				obj = ((huluHandle != null) ? huluHandle.Model : null);
			}
			object obj2 = obj;
			UiModelLoadComponent uiModelLoadComponent = (obj2 != null) ? obj2.CheckGetComponent<UiModelLoadComponent>() : null;
			TArray<USkeletalMesh> tarray = (uiModelLoadComponent != null) ? uiModelLoadComponent.GetModelAllMesh() : null;
			if (tarray != null)
			{
				MeshStreamTaskContext meshStreamTaskContext = new MeshStreamTaskContext();
				meshStreamTaskContext.SkeletalMeshes = tarray;
				MeshStreamTaskContext meshStreamTaskContext2 = meshStreamTaskContext;
				Action onTaskFinish;
				if ((onTaskFinish = <>9__1) == null)
				{
					onTaskFinish = (<>9__1 = delegate()
					{
						UiRoleHuluComponent uiRoleHuluComponent2 = model.CheckGetComponent<UiRoleHuluComponent>();
						if (uiRoleHuluComponent2 == null)
						{
							return;
						}
						uiRoleHuluComponent2.SetActive(true);
					});
				}
				meshStreamTaskContext2.OnTaskFinish = onTaskFinish;
				int item = MeshStreamController.Instance.AddMeshStreamTask(meshStreamTaskContext);
				this.HuluHandleList.Add(item);
			}
			UiModelUtil.Instance.SetVisible(model, true);
			UiRoleStateMachineComponent uiRoleStateMachineComponent = model.CheckGetComponent<UiRoleStateMachineComponent>();
			if (uiRoleStateMachineComponent != null)
			{
				uiRoleStateMachineComponent.SetState(EPerformanceRoleState.CreateRole_Idle, false, false, false);
			}
			UiModelBase model2 = observer.Model;
			UiModelActorComponent uiModelActorComponent = (model2 != null) ? model2.CheckGetComponent<UiModelActorComponent>() : null;
			if (uiModelActorComponent != null)
			{
				uiModelActorComponent.SetTransformByTag(tag);
			}
			if (((uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null) != null)
			{
				uiModelActorComponent.MainMeshComponent.KuroLodMask = 1;
				uiModelActorComponent.MainMeshComponent.KuroAnimInstanceLod = 1;
			}
			this.RoleLoadingFinishList.Add(roleId);
			if (this.RoleLoadingFinishList.Count >= 2)
			{
				this.BindCinematicTick();
				Action initRoleFinishDelegate = this.InitRoleFinishDelegate;
				if (initRoleFinishDelegate != null)
				{
					initRoleFinishDelegate();
				}
				this.InitRoleFinishDelegate = null;
			}
		});
	}

	// Token: 0x060153C0 RID: 86976 RVA: 0x0062C88B File Offset: 0x0062AA8B
	public void PlayRoleMontage(int roleId, EPerformanceRoleState roleState)
	{
		UiModelBase model = this.GetRoleObserver(roleId).Model;
		UiRoleStateMachineComponent uiRoleStateMachineComponent = (model != null) ? model.CheckGetComponent<UiRoleStateMachineComponent>() : null;
		if (uiRoleStateMachineComponent == null)
		{
			return;
		}
		uiRoleStateMachineComponent.SetState(roleState, false, false, false);
	}

	// Token: 0x060153C1 RID: 86977 RVA: 0x0062C8B4 File Offset: 0x0062AAB4
	public int SetRoleRenderingMaterial(int roleId, string effectId)
	{
		TsUiSceneRoleActor roleObserver = this.GetRoleObserver(roleId);
		return UiModelUtil.Instance.SetRenderingMaterial(roleObserver.Model, effectId);
	}

	// Token: 0x060153C2 RID: 86978 RVA: 0x0062C8DC File Offset: 0x0062AADC
	public void RemoveRoleRenderingMaterial(int roleId, int materialId)
	{
		TsUiSceneRoleActor roleObserver = this.GetRoleObserver(roleId);
		UiModelUtil.Instance.RemoveRenderingMaterial(roleObserver.Model, materialId);
	}

	// Token: 0x060153C3 RID: 86979 RVA: 0x0062C902 File Offset: 0x0062AB02
	public void RemoveRoleRenderingMaterialWithEnding(int roleId, int materialId)
	{
		UiModelBase model = this.GetRoleObserver(roleId).Model;
		UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = (model != null) ? model.CheckGetComponent<UiModelRenderingMaterialComponent>() : null;
		if (uiModelRenderingMaterialComponent == null)
		{
			return;
		}
		uiModelRenderingMaterialComponent.RemoveRenderingMaterialWithEnding(materialId);
	}

	// Token: 0x060153C4 RID: 86980 RVA: 0x0062C928 File Offset: 0x0062AB28
	public int SetHuluRenderingMaterial(int roleId, string materialId)
	{
		SkeletalObserverHandle huluHandle = this.GetRoleObserver(roleId).Model.CheckGetComponent<UiRoleHuluComponent>().GetHuluHandle();
		return UiModelUtil.Instance.SetRenderingMaterial(huluHandle.Model, materialId);
	}

	// Token: 0x060153C5 RID: 86981 RVA: 0x0062C95D File Offset: 0x0062AB5D
	public void RemoveHuluRenderingMaterialWithEnding(int roleId, int materialId)
	{
		this.GetRoleObserver(roleId).Model.CheckGetComponent<UiRoleHuluComponent>().GetHuluHandle().Model.CheckGetComponent<UiModelRenderingMaterialComponent>().RemoveRenderingMaterialWithEnding(materialId);
	}

	// Token: 0x060153C6 RID: 86982 RVA: 0x0062C985 File Offset: 0x0062AB85
	public void SetBurstEyeMaterialId(int materialId)
	{
		this.BurstEyeMaterialId = materialId;
	}

	// Token: 0x060153C7 RID: 86983 RVA: 0x0062C98E File Offset: 0x0062AB8E
	public int GetBurstEyeMaterialId()
	{
		return this.BurstEyeMaterialId;
	}

	// Token: 0x060153C8 RID: 86984 RVA: 0x0062C998 File Offset: 0x0062AB98
	public void LoadSequenceAsync(string resourceId, Action callBack = null, bool playReverse = false, Action startCallBack = null)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		ResourceSystem.Instance.LoadAsync<ULevelSequence>(resourcePath, delegate([Nullable(2)] ULevelSequence levelSequenceObject, string path)
		{
			if (levelSequenceObject != null && levelSequenceObject.IsValid())
			{
				Action startCallBack2 = startCallBack;
				if (startCallBack2 != null)
				{
					startCallBack2();
				}
				ALevelSequenceActor alevelSequenceActor = new ALevelSequenceActor();
				ULevelSequencePlayer.CreateLevelSequencePlayer(GlobalData.World, levelSequenceObject, new FMovieSceneSequencePlaybackSettings(), ref alevelSequenceActor);
				ALevelSequenceActor alevelSequenceActor2 = alevelSequenceActor;
				alevelSequenceActor2.ResetBindings();
				ULevelSequence sequence = alevelSequenceActor2.GetSequence();
				if (sequence.HasBindingTag(this.SEQUENCE_CAMERA_TAG, true))
				{
					BP_CineCamera_C cineCamera = CameraController.Instance.MainModel.WidgetCamera.GetComponent<WidgetCameraDisplayComponent>().CineCamera;
					alevelSequenceActor2.AddBindingByTag(this.SEQUENCE_CAMERA_TAG, cineCamera, false, false);
				}
				if (this.CinematicTick != null && sequence.HasBindingTag(this.CINEMATIC_TICK_TAG, true))
				{
					alevelSequenceActor2.AddBindingByTag(this.CINEMATIC_TICK_TAG, this.CinematicTick, false, false);
				}
				if (this.Spotlight1 != null && sequence.HasBindingTag(this.SPOT_LIGHT1_TAG, true))
				{
					alevelSequenceActor2.AddBindingByTag(this.SPOT_LIGHT1_TAG, this.Spotlight1, false, false);
				}
				if (this.Spotlight2 != null && sequence.HasBindingTag(this.SPOT_LIGHT2_TAG, true))
				{
					alevelSequenceActor2.AddBindingByTag(this.SPOT_LIGHT2_TAG, this.Spotlight2, false, false);
				}
				if (callBack != null)
				{
					alevelSequenceActor2.SequencePlayer.OnFinished.Add(callBack);
				}
				if (playReverse)
				{
					alevelSequenceActor2.SequencePlayer.PlayReverse();
				}
				else
				{
					alevelSequenceActor2.SequencePlayer.Play();
				}
				if (this.LoginLoopSequence != null)
				{
					this.LoginLoopSequence.SequencePlayer.StopAtCurrentTime();
					this.BlendCameraSequence();
				}
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiLoginSceneManager;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "登录场景Sequence异步加载失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Action startCallBack3 = startCallBack;
			if (startCallBack3 != null)
			{
				startCallBack3();
			}
			Action callBack2 = callBack;
			if (callBack2 == null)
			{
				return;
			}
			callBack2();
		}, 100, "js_undefined");
	}

	// Token: 0x060153C9 RID: 86985 RVA: 0x0062C9F4 File Offset: 0x0062ABF4
	public void PlayLoginLoopSequence()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("LevelSequence_Login");
		ResourceSystem.Instance.LoadAsync<ULevelSequence>(resourcePath, delegate([Nullable(2)] ULevelSequence levelSequenceObject, string path)
		{
			if (levelSequenceObject == null || !levelSequenceObject.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiLoginSceneManager;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "登录场景Sequence异步加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ALevelSequenceActor loginLoopSequence = new ALevelSequenceActor();
			ULevelSequencePlayer.CreateLevelSequencePlayer(GlobalData.World, levelSequenceObject, new FMovieSceneSequencePlaybackSettings(), ref loginLoopSequence);
			this.LoginLoopSequence = loginLoopSequence;
			this.LoginLoopSequence.ResetBindings();
			BP_CineCamera_C cineCamera = CameraController.Instance.MainModel.WidgetCamera.GetComponent<WidgetCameraDisplayComponent>().CineCamera;
			this.LoginLoopSequence.AddBindingByTag(this.SEQUENCE_CAMERA_TAG, cineCamera, false, false);
			this.LoginLoopSequence.SequencePlayer.PlayLooping(-1);
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, false, "MainCamera", null);
			Log.Instance.Info(ELogModule.UiLoginSceneManager, ELogAuthor.XXJ, "播放进入循环缓动镜头", default(ReadOnlySpan<ValueTuple<string, object>>));
		}, 100, "js_undefined");
	}

	// Token: 0x060153CA RID: 86986 RVA: 0x0062CA30 File Offset: 0x0062AC30
	private void BlendCameraSequence()
	{
		APlayerController playerController = UGameplayStatics.GetPlayerController(GlobalData.World, 0);
		if (playerController == null)
		{
			Log.Instance.Error(ELogModule.UiLoginSceneManager, ELogAuthor.XXJ, "[BlendCameraSequence]混合相机动画失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		BP_CineCamera_C cineCamera = CameraController.Instance.MainModel.WidgetCamera.GetComponent<WidgetCameraDisplayComponent>().CineCamera;
		playerController.SetViewTargetWithBlend(cineCamera, 0.5f, EViewTargetBlendFunction.VTBlend_Linear, 0f, true, true);
	}

	// Token: 0x060153CB RID: 86987 RVA: 0x0062CA9A File Offset: 0x0062AC9A
	public void Destroy()
	{
		this.DestroyCreateCharacterObservers();
		this.DestroyCinematicTick();
		if (this.LoginLoopSequence != null)
		{
			this.LoginLoopSequence.K2_DestroyActor();
			this.LoginLoopSequence = null;
		}
	}

	// Token: 0x17002027 RID: 8231
	// (get) Token: 0x060153CC RID: 86988 RVA: 0x0062CAC2 File Offset: 0x0062ACC2
	public static UiLoginSceneManager Instance
	{
		get
		{
			if (UiLoginSceneManager._instance == null)
			{
				UiLoginSceneManager._instance = new UiLoginSceneManager();
				UiLoginSceneManager._instance.OnInit();
			}
			return UiLoginSceneManager._instance;
		}
	}

	// Token: 0x060153CD RID: 86989 RVA: 0x0062CAE5 File Offset: 0x0062ACE5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060153CE RID: 86990 RVA: 0x0062CAE7 File Offset: 0x0062ACE7
	public static void ResetStaticDefaultValue()
	{
		UiLoginSceneManager instance = UiLoginSceneManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiLoginSceneManager._instance = null;
	}

	// Token: 0x060153CF RID: 86991 RVA: 0x0062CB00 File Offset: 0x0062AD00
	static UiLoginSceneManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiLoginSceneManager.CreateStaticDefaultValue), new Action(UiLoginSceneManager.ResetStaticDefaultValue));
	}

	// Token: 0x0400B402 RID: 46082
	private readonly Dictionary<int, TsUiSceneRoleActor> Observers = new Dictionary<int, TsUiSceneRoleActor>();

	// Token: 0x0400B403 RID: 46083
	private BP_Cinematics_Tick_C CinematicTick;

	// Token: 0x0400B404 RID: 46084
	private ASpotLight Spotlight1;

	// Token: 0x0400B405 RID: 46085
	private ASpotLight Spotlight2;

	// Token: 0x0400B406 RID: 46086
	private int BurstEyeMaterialId;

	// Token: 0x0400B407 RID: 46087
	private readonly List<int> RoleLoadingFinishList = new List<int>();

	// Token: 0x0400B408 RID: 46088
	private readonly List<int> HuluHandleList = new List<int>();

	// Token: 0x0400B409 RID: 46089
	private Action InitRoleFinishDelegate;

	// Token: 0x0400B40A RID: 46090
	[Nullable(2)]
	private ALevelSequenceActor LoginLoopSequence;

	// Token: 0x0400B40B RID: 46091
	private readonly FName SEQUENCE_CAMERA_TAG = new FName("SequenceCamera");

	// Token: 0x0400B40C RID: 46092
	private readonly FName CINEMATIC_TICK_TAG = new FName("CinematicTick");

	// Token: 0x0400B40D RID: 46093
	private readonly FName SPOT_LIGHT1_TAG = new FName("SpotLight1");

	// Token: 0x0400B40E RID: 46094
	private readonly FName SPOT_LIGHT2_TAG = new FName("SpotLight2");

	// Token: 0x0400B40F RID: 46095
	[Nullable(2)]
	private static UiLoginSceneManager _instance;
}
