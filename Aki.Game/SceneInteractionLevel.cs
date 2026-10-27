using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using UnrealEngine;

// Token: 0x02003493 RID: 13459
[NullableContext(1)]
[Nullable(0)]
public class SceneInteractionLevel
{
	// Token: 0x0601D499 RID: 119961 RVA: 0x00829C54 File Offset: 0x00827E54
	public void Init(ULevelStreamingDynamic levelStreamingDynamic, string inLevelName, FVectorDouble location, FRotator rotation, int handleId, EKuroSceneInteractionState? initState, [Nullable(2)] Action onLevelStreamingCompleteCallback, bool afterLoadVisible, bool isInitShow = false, int pbDataId = 0, int entityId = 0, [Nullable(2)] Action onLevelStreamingLoadedCompleteCallback = null)
	{
		this.LevelStreamingDynamic = levelStreamingDynamic;
		this.LevelName = inLevelName;
		this.Location = new FVectorDouble?(location);
		this.Rotation = new FRotator?(rotation);
		this.HandleId = handleId;
		this.CurrentState = initState;
		this.HasTempState = false;
		this.IsInitShow = isInitShow;
		this.PbDataId = pbDataId;
		this.EntityId = entityId;
		this.LevelStreamingDynamic.bInitiallyLoaded = true;
		this.LevelStreamingDynamic.bInitiallyVisible = true;
		this.LevelStreamingDynamic.SetShouldBeLoaded(true);
		this.LevelStreamingDynamic.SetShouldBeVisible(afterLoadVisible);
		this.LoadingLevelComplete = false;
		this.IsDestroyed = false;
		this.OnLevelStreamingShowCallback = onLevelStreamingCompleteCallback;
		this.OnLevelStreamingLoadedCallback = onLevelStreamingLoadedCompleteCallback;
		bool enableSceneInteractionLog = SceneInteractionLevel.EnableSceneInteractionLog;
		this.LevelStreamingDynamic.OnLevelShown.Add(delegate()
		{
			this.OnLevelShow("Init");
		});
		this.LevelStreamingDynamic.OnLevelLoaded.Add(delegate()
		{
			this.OnLevelLoaded("Init");
		});
	}

	// Token: 0x0601D49A RID: 119962 RVA: 0x00829D44 File Offset: 0x00827F44
	public void ToggleLevelVisible(bool visible, bool needHidden, [Nullable(2)] Action onLevelStreamingShowOrHideCallback = null, string reason = "")
	{
		ULevelStreamingDynamic levelStreamingDynamic = this.LevelStreamingDynamic;
		if (levelStreamingDynamic == null || !levelStreamingDynamic.IsValid())
		{
			return;
		}
		TArray<AActor> allActorsInLevel = this.GetAllActorsInLevel();
		if (allActorsInLevel != null && !visible && needHidden)
		{
			int i = 0;
			int num = allActorsInLevel.Num();
			while (i < num)
			{
				AActor aactor = allActorsInLevel.Get(i);
				if (aactor != null)
				{
					aactor.SetActorHiddenInGame(true);
				}
				i++;
			}
		}
		this.LevelStreamingDynamic.SetShouldBeVisible(visible);
		if (visible)
		{
			this.OnLevelStreamingShowCallback = onLevelStreamingShowOrHideCallback;
			this.LevelStreamingDynamic.OnLevelShown.Clear();
			this.LevelStreamingDynamic.OnLevelShown.Add(delegate()
			{
				this.OnLevelShow(reason);
			});
			return;
		}
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor != null)
		{
			interactionActor.TryStopCurrentState();
		}
		SceneInteractionActor interactionActor2 = this.InteractionActor;
		if (interactionActor2 != null)
		{
			interactionActor2.Clear();
		}
		this.OnLevelStreamingHideCallback = onLevelStreamingShowOrHideCallback;
		this.LevelStreamingDynamic.OnLevelHidden.Clear();
		this.LevelStreamingDynamic.OnLevelHidden.Add(delegate()
		{
			this.OnLevelHide(reason);
		});
	}

	// Token: 0x170028A5 RID: 10405
	// (get) Token: 0x0601D49B RID: 119963 RVA: 0x00829E53 File Offset: 0x00828053
	[Nullable(2)]
	public AActor MainActor
	{
		[NullableContext(2)]
		get
		{
			return this.InteractionActor;
		}
	}

	// Token: 0x0601D49C RID: 119964 RVA: 0x00829E5B File Offset: 0x0082805B
	public void SetStreamingPriority(int priority)
	{
		ULevelStreamingDynamic levelStreamingDynamic = this.LevelStreamingDynamic;
		if (levelStreamingDynamic != null && levelStreamingDynamic.IsValid())
		{
			this.LevelStreamingDynamic.SetPriority(priority);
		}
	}

	// Token: 0x0601D49D RID: 119965 RVA: 0x00829E80 File Offset: 0x00828080
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public TArray<AActor> GetAllActorsInLevel()
	{
		if (this.LevelStreamingDynamic == null)
		{
			Log.Instance.Error(ELogModule.RenderScene, ELogAuthor.HCS, "错误，流送关卡为空!!!!!!!!!!!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		ULevel loadedLevel = this.LevelStreamingDynamic.GetLoadedLevel();
		if (loadedLevel != null)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.GetLevelActors(loadedLevel);
		}
		return null;
	}

	// Token: 0x0601D49E RID: 119966 RVA: 0x00829ECA File Offset: 0x008280CA
	public bool IsStreamingComplete()
	{
		return this.LoadingLevelComplete;
	}

	// Token: 0x0601D49F RID: 119967 RVA: 0x00829ED2 File Offset: 0x008280D2
	public bool IsInfoDestroyed()
	{
		return this.IsDestroyed;
	}

	// Token: 0x0601D4A0 RID: 119968 RVA: 0x00829EDC File Offset: 0x008280DC
	public void Destroy()
	{
		this.IsDestroyed = true;
		this.SetCollisionActorsOwner(null);
		if (this.InteractionActor != null)
		{
			this.InteractionActor.Clear();
		}
		if (this.LevelStreamingDynamic != null)
		{
			this.LevelStreamingDynamic.OnLevelShown.Clear();
			this.LevelStreamingDynamic.OnLevelLoaded.Clear();
			this.LevelStreamingDynamic.SetShouldBeLoaded(false);
		}
		this.LevelStreamingDynamic = null;
		this.InteractionActor = null;
		this.OnLevelStreamingShowCallback = null;
		this.OnLevelStreamingHideCallback = null;
	}

	// Token: 0x0601D4A1 RID: 119969 RVA: 0x00829F5C File Offset: 0x0082815C
	public void Update(float deltaSeconds)
	{
		if (!this.Active)
		{
			return;
		}
		if (this.IsDestroyed)
		{
			return;
		}
		if (!this.LoadingLevelComplete)
		{
			return;
		}
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.Update(deltaSeconds);
	}

	// Token: 0x0601D4A2 RID: 119970 RVA: 0x00829FA8 File Offset: 0x008281A8
	public bool SwitchToState(EKuroSceneInteractionState targetState, bool needTransition, bool force, bool jumpToEnd)
	{
		if (!this.Active)
		{
			this.CurrentState = new EKuroSceneInteractionState?(targetState);
			return true;
		}
		if (this.InteractionActor != null)
		{
			return this.DoSwitchToState(targetState, needTransition, force, jumpToEnd);
		}
		this.HasTempState = true;
		this.TempTargetState = new EKuroSceneInteractionState?(targetState);
		this.TempNeedTransition = needTransition;
		this.TempForce = force;
		return true;
	}

	// Token: 0x0601D4A3 RID: 119971 RVA: 0x0082A001 File Offset: 0x00828201
	[return: Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public IReadOnlyDictionary<string, AActor> GetAllActor()
	{
		if (!this.LoadingLevelComplete)
		{
			return null;
		}
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		return this.InteractionActor.GetAllActor();
	}

	// Token: 0x0601D4A4 RID: 119972 RVA: 0x0082A034 File Offset: 0x00828234
	[return: Nullable(2)]
	public AActor GetActorByKey(string key)
	{
		if (!this.LoadingLevelComplete)
		{
			return null;
		}
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		AActor actorByKey = this.InteractionActor.GetActorByKey(key);
		if (actorByKey == null)
		{
			Log.Instance.Warn(ELogModule.RenderScene, ELogAuthor.HCS, string.Concat(new string[]
			{
				"获取actor失败 level:",
				this.LevelName,
				" 不存在key=",
				key,
				" 的Actor"
			}), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return actorByKey;
	}

	// Token: 0x0601D4A5 RID: 119973 RVA: 0x0082A0C0 File Offset: 0x008282C0
	public FTransformDouble? GetActorOriginalRelTransform(AActor actor)
	{
		if (!this.LoadingLevelComplete)
		{
			return null;
		}
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		return this.InteractionActor.GetActorOriginalRelTransform(actor);
	}

	// Token: 0x0601D4A6 RID: 119974 RVA: 0x0082A10C File Offset: 0x0082830C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public TArray<AActor> GetRefActorsByTag(FGameplayTag tag)
	{
		if (!this.LoadingLevelComplete)
		{
			return null;
		}
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		return this.InteractionActor.GetRefActorsByTag(tag);
	}

	// Token: 0x0601D4A7 RID: 119975 RVA: 0x0082A140 File Offset: 0x00828340
	private bool DoSwitchToState(EKuroSceneInteractionState targetState, bool needTransition, bool force, bool jumpToEnd)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return false;
		}
		if (!force)
		{
			EKuroSceneInteractionState? currentState = this.CurrentState;
			if (currentState.GetValueOrDefault() == targetState & currentState != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderScene;
				ELogAuthor author = ELogAuthor.MY;
				string message = "切换状态失败，无法切换到当前状态";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelName", this.LevelName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
		}
		this.CurrentState = new EKuroSceneInteractionState?(targetState);
		this.InteractionActor.SetState(targetState, needTransition, jumpToEnd);
		return true;
	}

	// Token: 0x0601D4A8 RID: 119976 RVA: 0x0082A1D0 File Offset: 0x008283D0
	public EKuroSceneInteractionState GetCurrentState()
	{
		if (this.InteractionActor != null)
		{
			return this.InteractionActor.GetCurrentState();
		}
		return EKuroSceneInteractionState.Error;
	}

	// Token: 0x0601D4A9 RID: 119977 RVA: 0x0082A1E8 File Offset: 0x008283E8
	public void ChangePlayDirection(bool bPlayBack)
	{
		if (this.InteractionActor != null)
		{
			this.InteractionActor.ChangeDirection(bPlayBack);
		}
	}

	// Token: 0x0601D4AA RID: 119978 RVA: 0x0082A1FE File Offset: 0x008283FE
	public void PlaySceneEffect(ESceneInteractionEffect effectKey)
	{
		if (this.InteractionActor != null)
		{
			this.InteractionActor.PlayIndependentEffect(effectKey);
		}
	}

	// Token: 0x0601D4AB RID: 119979 RVA: 0x0082A214 File Offset: 0x00828414
	public void EndSceneEffect(ESceneInteractionEffect effectKey)
	{
		if (this.InteractionActor != null)
		{
			this.InteractionActor.EndIndependentEffect(effectKey);
		}
	}

	// Token: 0x0601D4AC RID: 119980 RVA: 0x0082A22A File Offset: 0x0082842A
	public void PlaySceneEndEffect(ESceneInteractionEffect effectKey)
	{
		if (this.InteractionActor != null)
		{
			this.InteractionActor.PlayIndependentEndEffect(effectKey);
		}
	}

	// Token: 0x0601D4AD RID: 119981 RVA: 0x0082A240 File Offset: 0x00828440
	[NullableContext(2)]
	private void ApplyCustomPrimitiveData(ULevel level)
	{
		Dictionary<int, LevelCustomPrimitiveData> levelCustomPrimitiveData = RenderModuleConfig.Instance.LevelCustomPrimitiveData;
		LevelCustomPrimitiveData? levelCustomPrimitiveData2 = (levelCustomPrimitiveData != null && levelCustomPrimitiveData.ContainsKey(this.PbDataId)) ? new LevelCustomPrimitiveData?(RenderModuleConfig.Instance.LevelCustomPrimitiveData[this.PbDataId]) : null;
		if (levelCustomPrimitiveData2 != null)
		{
			LevelCustomPrimitiveData value = levelCustomPrimitiveData2.Value;
			if (value.CustomPrimitiveDataIndex0() != null && value.CustomPrimitiveDataIndex0Length > 0)
			{
				TArray<AActor> levelActors = UKuroRenderingRuntimeBPPluginBPLibrary.GetLevelActors(level);
				if (levelActors != null)
				{
					int i = 0;
					int num = levelActors.Num();
					while (i < num)
					{
						AActor aactor = levelActors.Get(i);
						if (aactor.IsValid())
						{
							TArray<UActorComponent> tarray = aactor.K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
							if (tarray != null)
							{
								for (int j = 0; j < tarray.Num(); j++)
								{
									UStaticMeshComponent ustaticMeshComponent = tarray.Get(j) as UStaticMeshComponent;
									if (ustaticMeshComponent == null || !ustaticMeshComponent.IsValid())
									{
										Log instance = Log.Instance;
										ELogModule module = ELogModule.Interaction;
										ELogAuthor author = ELogAuthor.XDW;
										string message = "[SceneInteractionLevel.OnLevelShow] Comp无效";
										ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelName", this.LevelName);
										instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
									}
									else
									{
										switch (value.CustomPrimitiveDataIndex0Length)
										{
										case 1:
											ustaticMeshComponent.SetCustomPrimitiveDataFloat(0, value.CustomPrimitiveDataIndex0()[0]);
											break;
										case 2:
											ustaticMeshComponent.SetCustomPrimitiveDataVector2(0, new FVector2D(value.CustomPrimitiveDataIndex0()[0], value.CustomPrimitiveDataIndex0()[1]));
											break;
										case 3:
											ustaticMeshComponent.SetCustomPrimitiveDataVector3(0, new FVector(value.CustomPrimitiveDataIndex0()[0], value.CustomPrimitiveDataIndex0()[1], value.CustomPrimitiveDataIndex0()[2]));
											break;
										case 4:
											ustaticMeshComponent.SetCustomPrimitiveDataVector4(0, new FVector4(value.CustomPrimitiveDataIndex0()[0], value.CustomPrimitiveDataIndex0()[1], value.CustomPrimitiveDataIndex0()[2], value.CustomPrimitiveDataIndex0()[3]));
											break;
										default:
										{
											Log instance2 = Log.Instance;
											ELogModule module2 = ELogModule.Interaction;
											ELogAuthor author2 = ELogAuthor.XDW;
											string message2 = "[SceneInteractionLevel.OnLevelShow] CustomPrimitiveData太长";
											ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("CustomPrimitiveData0", value.CustomPrimitiveDataIndex0());
											instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
											break;
										}
										}
									}
								}
							}
						}
						i++;
					}
				}
			}
		}
	}

	// Token: 0x0601D4AE RID: 119982 RVA: 0x0082A480 File Offset: 0x00828680
	private void OnLevelLoaded(string reason)
	{
		bool enableSceneInteractionLog = SceneInteractionLevel.EnableSceneInteractionLog;
		Action onLevelStreamingLoadedCallback = this.OnLevelStreamingLoadedCallback;
		if (onLevelStreamingLoadedCallback != null)
		{
			onLevelStreamingLoadedCallback();
		}
		this.OnLevelStreamingLoadedCallback = null;
	}

	// Token: 0x0601D4AF RID: 119983 RVA: 0x0082A4A0 File Offset: 0x008286A0
	private void OnLevelShow(string reason)
	{
		if (this.LevelStreamingDynamic == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderScene;
			ELogAuthor author = ELogAuthor.HCS;
			string message = "错误，流送关卡为空!!!!!!!!!!!!!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("this.LevelName", this.LevelName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.LoadingLevelComplete = true;
		ULevel loadedLevel = this.LevelStreamingDynamic.GetLoadedLevel();
		AActor sceneInteractionLevelActor = UKuroRenderingRuntimeBPPluginBPLibrary.GetSceneInteractionLevelActor(loadedLevel);
		this.InteractionActor = (sceneInteractionLevelActor as SceneInteractionActor);
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderScene;
			ELogAuthor author2 = ELogAuthor.HCS;
			string message2 = "找不到关卡蓝图,查看prefab是否按照规范进行制作";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("LevelName", this.LevelName);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.LevelStreamingDynamic.OnLevelShown.Clear();
			return;
		}
		this.InteractionActor.Init(this.PbDataId, this.HandleId, this.LevelName, delegate
		{
			this.DoSwitchToState(this.CurrentState.GetValueOrDefault(), false, true, !this.IsInitShow);
			if (this.OnLevelStreamingShowCallback != null)
			{
				this.OnLevelStreamingShowCallback();
			}
			this.OnLevelStreamingShowCallback = null;
			if (this.HasTempState)
			{
				this.DoSwitchToState(this.TempTargetState.Value, this.TempNeedTransition, this.TempForce, !this.IsInitShow);
				this.HasTempState = false;
			}
			ULevelStreamingDynamic levelStreamingDynamic = this.LevelStreamingDynamic;
			if (levelStreamingDynamic == null)
			{
				return;
			}
			levelStreamingDynamic.OnLevelShown.Clear();
		}, this.EntityId);
		this.ApplyCustomPrimitiveData(loadedLevel);
		bool enableSceneInteractionLog = SceneInteractionLevel.EnableSceneInteractionLog;
	}

	// Token: 0x0601D4B0 RID: 119984 RVA: 0x0082A598 File Offset: 0x00828798
	private void OnLevelHide(string reason)
	{
		if (this.OnLevelStreamingHideCallback != null)
		{
			this.OnLevelStreamingHideCallback();
		}
		this.OnLevelStreamingHideCallback = null;
		ULevelStreamingDynamic levelStreamingDynamic = this.LevelStreamingDynamic;
		if (levelStreamingDynamic != null)
		{
			levelStreamingDynamic.OnLevelHidden.Clear();
		}
		bool enableSceneInteractionLog = SceneInteractionLevel.EnableSceneInteractionLog;
	}

	// Token: 0x0601D4B1 RID: 119985 RVA: 0x0082A5D0 File Offset: 0x008287D0
	[NullableContext(2)]
	public AActor GetAttachActor()
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		return this.InteractionActor.GetAttachParentActor();
	}

	// Token: 0x0601D4B2 RID: 119986 RVA: 0x0082A5F8 File Offset: 0x008287F8
	public void AttachToActor(AActor parentActor)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor != null && interactionActor.IsValid())
		{
			USceneComponent rootComponent = this.InteractionActor.RootComponent;
			if (rootComponent != null && rootComponent.IsValid())
			{
				if (this.InteractionActor.RootComponent.Mobility == EComponentMobility.Static)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderScene;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "Prefab根场景组件的移动性为Static, 将被强行设置为Movable, 后续请检查Prefab并修改";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelName", this.LevelName);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.InteractionActor.RootComponent.SetMobility(EComponentMobility.Movable);
				}
				AttachToActorController.Instance.AttachToActor(this.InteractionActor, parentActor, EDetachType.DestroyExternal, "AttachToActor", null, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, true, true, false, false, false);
				this.InteractionActor.D_K2_SetActorRelativeLocation(global::Vector.ZeroVectorDouble, false, ref WorldGlobal.SweepHitResult, false);
				this.InteractionActor.K2_SetActorRelativeRotation(Rotator.ZeroRotator, false, ref WorldGlobal.SweepHitResult, false);
				return;
			}
		}
	}

	// Token: 0x0601D4B3 RID: 119987 RVA: 0x0082A6EC File Offset: 0x008288EC
	[NullableContext(2)]
	public void SetCollisionActorsOwner(AActor owner)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		if (this.InteractionActor.CollisionActors != null)
		{
			int num = this.InteractionActor.CollisionActors.Num();
			for (int i = 0; i < num; i++)
			{
				AActor aactor = this.InteractionActor.CollisionActors.Get(i);
				if (ObjectUtils.IsValid(aactor))
				{
					aactor.SetOwner(owner);
				}
			}
		}
		if (this.InteractionActor.PartCollisionActorsAndCorrespondingTags != null)
		{
			int num2 = this.InteractionActor.PartCollisionActorsAndCorrespondingTags.Num();
			for (int j = 0; j < num2; j++)
			{
				AActor key = this.InteractionActor.PartCollisionActorsAndCorrespondingTags.GetKey(j);
				if (ObjectUtils.IsValid(key))
				{
					key.SetOwner(owner);
				}
			}
		}
	}

	// Token: 0x0601D4B4 RID: 119988 RVA: 0x0082A7B0 File Offset: 0x008289B0
	[NullableContext(2)]
	public AActor GetMainCollisionActor()
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		if (this.InteractionActor.CollisionActors != null)
		{
			TArray<AActor> collisionActors = this.InteractionActor.CollisionActors;
			if (collisionActors != null && collisionActors.Num() > 0)
			{
				return this.InteractionActor.CollisionActors.Get(0);
			}
		}
		return null;
	}

	// Token: 0x0601D4B5 RID: 119989 RVA: 0x0082A814 File Offset: 0x00828A14
	[NullableContext(2)]
	public ASkeletalMeshActor GetSkeletalMeshActor()
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		if (this.InteractionActor.AllSkeletalMeshActors != null)
		{
			TArray<ASkeletalMeshActor> allSkeletalMeshActors = this.InteractionActor.AllSkeletalMeshActors;
			if (allSkeletalMeshActors != null && allSkeletalMeshActors.Num() > 0)
			{
				return this.InteractionActor.AllSkeletalMeshActors.Get(0);
			}
		}
		return null;
	}

	// Token: 0x0601D4B6 RID: 119990 RVA: 0x0082A878 File Offset: 0x00828A78
	public FGameplayTag? GetPartCollisionActorTag(AActor actor)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		TMap<AActor, FGameplayTag> partCollisionActorsAndCorrespondingTags = this.InteractionActor.PartCollisionActorsAndCorrespondingTags;
		if (partCollisionActorsAndCorrespondingTags == null)
		{
			return null;
		}
		return new FGameplayTag?(partCollisionActorsAndCorrespondingTags.Get(actor));
	}

	// Token: 0x0601D4B7 RID: 119991 RVA: 0x0082A8CC File Offset: 0x00828ACC
	public int? GetPartCollisionActorsNum()
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		TMap<AActor, FGameplayTag> partCollisionActorsAndCorrespondingTags = this.InteractionActor.PartCollisionActorsAndCorrespondingTags;
		if (partCollisionActorsAndCorrespondingTags == null)
		{
			return null;
		}
		return new int?(partCollisionActorsAndCorrespondingTags.Num());
	}

	// Token: 0x0601D4B8 RID: 119992 RVA: 0x0082A920 File Offset: 0x00828B20
	[NullableContext(2)]
	public AActor GetPartCollisionActor(int index)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		if (this.InteractionActor.PartCollisionActorsAndCorrespondingTags == null)
		{
			return null;
		}
		int num = this.InteractionActor.PartCollisionActorsAndCorrespondingTags.Num();
		if (index >= num)
		{
			return null;
		}
		TMap<AActor, FGameplayTag> partCollisionActorsAndCorrespondingTags = this.InteractionActor.PartCollisionActorsAndCorrespondingTags;
		if (partCollisionActorsAndCorrespondingTags == null)
		{
			return null;
		}
		return partCollisionActorsAndCorrespondingTags.GetKey(index);
	}

	// Token: 0x0601D4B9 RID: 119993 RVA: 0x0082A983 File Offset: 0x00828B83
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public TArray<AActor> GetInteractionEffectHookActors()
	{
		if (this.InteractionActor.InteractionEffectHookActors != null)
		{
			return this.InteractionActor.InteractionEffectHookActors;
		}
		return null;
	}

	// Token: 0x0601D4BA RID: 119994 RVA: 0x0082A99F File Offset: 0x00828B9F
	public void PlayExtraEffect(FGameplayTag tag, bool jumpToEnd)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.PlayExtraEffectOnTagsChange(tag, jumpToEnd);
	}

	// Token: 0x0601D4BB RID: 119995 RVA: 0x0082A9C6 File Offset: 0x00828BC6
	public void PlayKuroSkeletalMeshDestruction(AActor actor, bool jumpToEnd)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.PlayKuroSkeletalMeshDestruction(actor, jumpToEnd);
	}

	// Token: 0x0601D4BC RID: 119996 RVA: 0x0082A9ED File Offset: 0x00828BED
	public void StopExtraEffect(FGameplayTag tag)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.StopExtraEffectOnTagsChange(tag);
	}

	// Token: 0x0601D4BD RID: 119997 RVA: 0x0082AA13 File Offset: 0x00828C13
	public void UpdateHitInfo(global::Vector pos, FVector dir)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.UpdateHitInfo(pos.ToUeVector(false), dir);
	}

	// Token: 0x0601D4BE RID: 119998 RVA: 0x0082AA40 File Offset: 0x00828C40
	public void UpdateRangeOverlapInfo(bool isEnter, AActor otherActor)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.UpdateRangeOverlapInfo(isEnter, otherActor);
	}

	// Token: 0x0601D4BF RID: 119999 RVA: 0x0082AA68 File Offset: 0x00828C68
	public float? GetActiveTagSequencePlaybackProgress(FGameplayTag tag)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		return this.InteractionActor.GetActiveTagSequencePlaybackProgress(tag);
	}

	// Token: 0x0601D4C0 RID: 120000 RVA: 0x0082AAA2 File Offset: 0x00828CA2
	public void SetActiveTagSequencePlaybackProgress(FGameplayTag tag, float progress)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.SetActiveTagSequencePlaybackProgress(tag, progress);
	}

	// Token: 0x0601D4C1 RID: 120001 RVA: 0x0082AACC File Offset: 0x00828CCC
	public double? GetActiveTagSequenceDurationTime(FGameplayTag tag)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		float? activeTagSequenceDurationTime = this.InteractionActor.GetActiveTagSequenceDurationTime(tag);
		if (activeTagSequenceDurationTime == null)
		{
			return null;
		}
		return new double?((double)activeTagSequenceDurationTime.GetValueOrDefault());
	}

	// Token: 0x0601D4C2 RID: 120002 RVA: 0x0082AB27 File Offset: 0x00828D27
	public void SetActiveTagSequenceDurationTime(FGameplayTag tag, float durationSecond)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.SetActiveTagSequenceDurationTime(tag, durationSecond);
	}

	// Token: 0x0601D4C3 RID: 120003 RVA: 0x0082AB4E File Offset: 0x00828D4E
	public void PauseActiveTagSequence(FGameplayTag tag)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.PauseActiveTagSequence(tag);
	}

	// Token: 0x0601D4C4 RID: 120004 RVA: 0x0082AB74 File Offset: 0x00828D74
	public void ResumeActiveTagSequence(FGameplayTag tag, bool bReverseFromConfig = false)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.ResumeActiveTagSequence(tag, bReverseFromConfig);
	}

	// Token: 0x0601D4C5 RID: 120005 RVA: 0x0082AB9C File Offset: 0x00828D9C
	public bool? GetIsActiveTagSequencePlayReverseFromConfig(FGameplayTag tag)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		return this.InteractionActor.GetIsActiveTagSequencePlayReverseFromConfig(tag);
	}

	// Token: 0x0601D4C6 RID: 120006 RVA: 0x0082ABD6 File Offset: 0x00828DD6
	public void PlayActiveTagSequenceTo(FGameplayTag tag, float progress, bool bReverseFromConfig = false)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.PlayActiveTagSequenceTo(tag, progress, bReverseFromConfig);
	}

	// Token: 0x0601D4C7 RID: 120007 RVA: 0x0082ABFE File Offset: 0x00828DFE
	public void SetOverrideSeqBindActor(AActor actorToBind, [Nullable(2)] string bindingName = null)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.SetOverrideSeqBindActor(actorToBind, bindingName);
	}

	// Token: 0x0601D4C8 RID: 120008 RVA: 0x0082AC25 File Offset: 0x00828E25
	public void UnsetOverrideSeqBindActor(AActor actorToUnBind, [Nullable(2)] string bindingName = null)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.UnsetOverrideSeqBindActor(actorToUnBind, bindingName);
	}

	// Token: 0x0601D4C9 RID: 120009 RVA: 0x0082AC4C File Offset: 0x00828E4C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public TArray<AActor> GetReceivingDecalsActors()
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		return this.InteractionActor.ReceivingDecalsActors;
	}

	// Token: 0x0601D4CA RID: 120010 RVA: 0x0082AC72 File Offset: 0x00828E72
	public void Disable()
	{
		this.Active = false;
		if (this.InteractionActor != null)
		{
			this.InteractionActor.Active = false;
		}
	}

	// Token: 0x0601D4CB RID: 120011 RVA: 0x0082AC8F File Offset: 0x00828E8F
	public void Enable()
	{
		this.Active = true;
		if (this.InteractionActor != null)
		{
			this.InteractionActor.Active = true;
		}
	}

	// Token: 0x0400E6CE RID: 59086
	[Nullable(2)]
	protected ULevelStreamingDynamic LevelStreamingDynamic;

	// Token: 0x0400E6CF RID: 59087
	public string LevelName = "";

	// Token: 0x0400E6D0 RID: 59088
	protected FVectorDouble? Location;

	// Token: 0x0400E6D1 RID: 59089
	protected FRotator? Rotation;

	// Token: 0x0400E6D2 RID: 59090
	protected int PbDataId;

	// Token: 0x0400E6D3 RID: 59091
	protected int HandleId;

	// Token: 0x0400E6D4 RID: 59092
	protected int EntityId;

	// Token: 0x0400E6D5 RID: 59093
	protected EKuroSceneInteractionState? CurrentState;

	// Token: 0x0400E6D6 RID: 59094
	protected bool LoadingLevelComplete;

	// Token: 0x0400E6D7 RID: 59095
	[Nullable(2)]
	protected SceneInteractionActor InteractionActor;

	// Token: 0x0400E6D8 RID: 59096
	protected bool HasTempState;

	// Token: 0x0400E6D9 RID: 59097
	protected EKuroSceneInteractionState? TempTargetState;

	// Token: 0x0400E6DA RID: 59098
	protected bool TempNeedTransition;

	// Token: 0x0400E6DB RID: 59099
	protected bool IsDestroyed;

	// Token: 0x0400E6DC RID: 59100
	protected bool Active = true;

	// Token: 0x0400E6DD RID: 59101
	protected bool TempForce;

	// Token: 0x0400E6DE RID: 59102
	[Nullable(2)]
	protected Action OnLevelStreamingShowCallback;

	// Token: 0x0400E6DF RID: 59103
	[Nullable(2)]
	protected Action OnLevelStreamingLoadedCallback;

	// Token: 0x0400E6E0 RID: 59104
	[Nullable(2)]
	protected Action OnLevelStreamingHideCallback;

	// Token: 0x0400E6E1 RID: 59105
	private bool IsInitShow;

	// Token: 0x0400E6E2 RID: 59106
	private static readonly bool EnableSceneInteractionLog;
}
