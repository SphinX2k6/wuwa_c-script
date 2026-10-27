using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02002C5B RID: 11355
[NullableContext(1)]
[Nullable(0)]
public class UiLoginSceneManager : Singleton
{
	// Token: 0x06017B44 RID: 97092 RVA: 0x00606A9C File Offset: 0x00604C9C
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

	// Token: 0x06017B45 RID: 97093 RVA: 0x00606ADC File Offset: 0x00604CDC
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

	// Token: 0x06017B46 RID: 97094 RVA: 0x00606B9C File Offset: 0x00604D9C
	public void InitCinematicTick()
	{
		this.CinematicTick = ActorSystem.Instance.Get<BP_Cinematics_Tick_C>(BP_Cinematics_Tick_C.StaticClass(), new FTransformDouble(), null, true);
		this.Spotlight1 = ActorSystem.Instance.Get<ASpotLight>(ASpotLight.StaticClass(), new FTransformDouble(), null, true);
		this.Spotlight2 = ActorSystem.Instance.Get<ASpotLight>(ASpotLight.StaticClass(), new FTransformDouble(), null, true);
	}

	// Token: 0x06017B47 RID: 97095 RVA: 0x00606C00 File Offset: 0x00604E00
	private void BindCinematicTick()
	{
		IReadOnlyList<int> initialRoles = CreateCharacterConfig.Instance.GetInitialRoles();
		int roleId = initialRoles[0];
		int roleId2 = initialRoles[1];
		this.CinematicTick.UISceneRole_2 = this.GetActorMeshComponent(roleId2);
		this.CinematicTick.UISceneRole = this.GetActorMeshComponent(roleId);
		this.CinematicTick.Is_Tick = 1;
	}

	// Token: 0x06017B48 RID: 97096 RVA: 0x00606C56 File Offset: 0x00604E56
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

	// Token: 0x06017B49 RID: 97097 RVA: 0x00606C80 File Offset: 0x00604E80
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

	// Token: 0x06017B4A RID: 97098 RVA: 0x00606D00 File Offset: 0x00604F00
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

	// Token: 0x06017B4B RID: 97099 RVA: 0x00606D4C File Offset: 0x00604F4C
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

	// Token: 0x06017B4C RID: 97100 RVA: 0x00606DC7 File Offset: 0x00604FC7
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

	// Token: 0x06017B4D RID: 97101 RVA: 0x00606DF0 File Offset: 0x00604FF0
	public int SetRoleRenderingMaterial(int roleId, string effectId)
	{
		TsUiSceneRoleActor roleObserver = this.GetRoleObserver(roleId);
		return UiModelUtil.Instance.SetRenderingMaterial(roleObserver.Model, effectId);
	}

	// Token: 0x06017B4E RID: 97102 RVA: 0x00606E18 File Offset: 0x00605018
	public void RemoveRoleRenderingMaterial(int roleId, int materialId)
	{
		TsUiSceneRoleActor roleObserver = this.GetRoleObserver(roleId);
		UiModelUtil.Instance.RemoveRenderingMaterial(roleObserver.Model, materialId);
	}

	// Token: 0x06017B4F RID: 97103 RVA: 0x00606E3E File Offset: 0x0060503E
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

	// Token: 0x06017B50 RID: 97104 RVA: 0x00606E64 File Offset: 0x00605064
	public int SetHuluRenderingMaterial(int roleId, string materialId)
	{
		SkeletalObserverHandle huluHandle = this.GetRoleObserver(roleId).Model.CheckGetComponent<UiRoleHuluComponent>().GetHuluHandle();
		return UiModelUtil.Instance.SetRenderingMaterial(huluHandle.Model, materialId);
	}

	// Token: 0x06017B51 RID: 97105 RVA: 0x00606E99 File Offset: 0x00605099
	public void RemoveHuluRenderingMaterialWithEnding(int roleId, int materialId)
	{
		this.GetRoleObserver(roleId).Model.CheckGetComponent<UiRoleHuluComponent>().GetHuluHandle().Model.CheckGetComponent<UiModelRenderingMaterialComponent>().RemoveRenderingMaterialWithEnding(materialId);
	}

	// Token: 0x06017B52 RID: 97106 RVA: 0x00606EC1 File Offset: 0x006050C1
	public void SetBurstEyeMaterialId(int materialId)
	{
		this.BurstEyeMaterialId = materialId;
	}

	// Token: 0x06017B53 RID: 97107 RVA: 0x00606ECA File Offset: 0x006050CA
	public int GetBurstEyeMaterialId()
	{
		return this.BurstEyeMaterialId;
	}

	// Token: 0x06017B54 RID: 97108 RVA: 0x00606ED4 File Offset: 0x006050D4
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

	// Token: 0x06017B55 RID: 97109 RVA: 0x00606F30 File Offset: 0x00605130
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

	// Token: 0x06017B56 RID: 97110 RVA: 0x00606F6C File Offset: 0x0060516C
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

	// Token: 0x06017B57 RID: 97111 RVA: 0x00606FD6 File Offset: 0x006051D6
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

	// Token: 0x17001FD6 RID: 8150
	// (get) Token: 0x06017B58 RID: 97112 RVA: 0x00606FFE File Offset: 0x006051FE
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

	// Token: 0x06017B59 RID: 97113 RVA: 0x00607021 File Offset: 0x00605221
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017B5A RID: 97114 RVA: 0x00607023 File Offset: 0x00605223
	public static void ResetStaticDefaultValue()
	{
		UiLoginSceneManager instance = UiLoginSceneManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiLoginSceneManager._instance = null;
	}

	// Token: 0x06017B5B RID: 97115 RVA: 0x0060703C File Offset: 0x0060523C
	static UiLoginSceneManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiLoginSceneManager.CreateStaticDefaultValue), new Action(UiLoginSceneManager.ResetStaticDefaultValue));
	}

	// Token: 0x0400B096 RID: 45206
	private readonly Dictionary<int, TsUiSceneRoleActor> Observers = new Dictionary<int, TsUiSceneRoleActor>();

	// Token: 0x0400B097 RID: 45207
	private BP_Cinematics_Tick_C CinematicTick;

	// Token: 0x0400B098 RID: 45208
	private ASpotLight Spotlight1;

	// Token: 0x0400B099 RID: 45209
	private ASpotLight Spotlight2;

	// Token: 0x0400B09A RID: 45210
	private int BurstEyeMaterialId;

	// Token: 0x0400B09B RID: 45211
	private readonly List<int> RoleLoadingFinishList = new List<int>();

	// Token: 0x0400B09C RID: 45212
	private readonly List<int> HuluHandleList = new List<int>();

	// Token: 0x0400B09D RID: 45213
	private Action InitRoleFinishDelegate;

	// Token: 0x0400B09E RID: 45214
	[Nullable(2)]
	private ALevelSequenceActor LoginLoopSequence;

	// Token: 0x0400B09F RID: 45215
	private readonly FName SEQUENCE_CAMERA_TAG = new FName("SequenceCamera");

	// Token: 0x0400B0A0 RID: 45216
	private readonly FName CINEMATIC_TICK_TAG = new FName("CinematicTick");

	// Token: 0x0400B0A1 RID: 45217
	private readonly FName SPOT_LIGHT1_TAG = new FName("SpotLight1");

	// Token: 0x0400B0A2 RID: 45218
	private readonly FName SPOT_LIGHT2_TAG = new FName("SpotLight2");

	// Token: 0x0400B0A3 RID: 45219
	[Nullable(2)]
	private static UiLoginSceneManager _instance;
}
