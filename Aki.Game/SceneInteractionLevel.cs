using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using UnrealEngine;

// Token: 0x02002A07 RID: 10759
[NullableContext(1)]
[Nullable(0)]
public class SceneInteractionLevel
{
	// Token: 0x0601B195 RID: 110997 RVA: 0x00850D10 File Offset: 0x0084EF10
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

	// Token: 0x0601B196 RID: 110998 RVA: 0x00850E00 File Offset: 0x0084F000
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

	// Token: 0x17002C3D RID: 11325
	// (get) Token: 0x0601B197 RID: 110999 RVA: 0x00850F0F File Offset: 0x0084F10F
	[Nullable(2)]
	public AActor MainActor
	{
		[NullableContext(2)]
		get
		{
			return this.InteractionActor;
		}
	}

	// Token: 0x0601B198 RID: 111000 RVA: 0x00850F17 File Offset: 0x0084F117
	public void SetStreamingPriority(int priority)
	{
		ULevelStreamingDynamic levelStreamingDynamic = this.LevelStreamingDynamic;
		if (levelStreamingDynamic != null && levelStreamingDynamic.IsValid())
		{
			this.LevelStreamingDynamic.SetPriority(priority);
		}
	}

	// Token: 0x0601B199 RID: 111001 RVA: 0x00850F3C File Offset: 0x0084F13C
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

	// Token: 0x0601B19A RID: 111002 RVA: 0x00850F86 File Offset: 0x0084F186
	public bool IsStreamingComplete()
	{
		return this.LoadingLevelComplete;
	}

	// Token: 0x0601B19B RID: 111003 RVA: 0x00850F8E File Offset: 0x0084F18E
	public bool IsInfoDestroyed()
	{
		return this.IsDestroyed;
	}

	// Token: 0x0601B19C RID: 111004 RVA: 0x00850F98 File Offset: 0x0084F198
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

	// Token: 0x0601B19D RID: 111005 RVA: 0x00851018 File Offset: 0x0084F218
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

	// Token: 0x0601B19E RID: 111006 RVA: 0x00851064 File Offset: 0x0084F264
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

	// Token: 0x0601B19F RID: 111007 RVA: 0x008510BD File Offset: 0x0084F2BD
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

	// Token: 0x0601B1A0 RID: 111008 RVA: 0x008510F0 File Offset: 0x0084F2F0
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

	// Token: 0x0601B1A1 RID: 111009 RVA: 0x0085117C File Offset: 0x0084F37C
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

	// Token: 0x0601B1A2 RID: 111010 RVA: 0x008511C8 File Offset: 0x0084F3C8
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

	// Token: 0x0601B1A3 RID: 111011 RVA: 0x008511FC File Offset: 0x0084F3FC
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

	// Token: 0x0601B1A4 RID: 111012 RVA: 0x0085128C File Offset: 0x0084F48C
	public EKuroSceneInteractionState GetCurrentState()
	{
		if (this.InteractionActor != null)
		{
			return this.InteractionActor.GetCurrentState();
		}
		return EKuroSceneInteractionState.Error;
	}

	// Token: 0x0601B1A5 RID: 111013 RVA: 0x008512A4 File Offset: 0x0084F4A4
	public void ChangePlayDirection(bool bPlayBack)
	{
		if (this.InteractionActor != null)
		{
			this.InteractionActor.ChangeDirection(bPlayBack);
		}
	}

	// Token: 0x0601B1A6 RID: 111014 RVA: 0x008512BA File Offset: 0x0084F4BA
	public void PlaySceneEffect(ESceneInteractionEffect effectKey)
	{
		if (this.InteractionActor != null)
		{
			this.InteractionActor.PlayIndependentEffect(effectKey);
		}
	}

	// Token: 0x0601B1A7 RID: 111015 RVA: 0x008512D0 File Offset: 0x0084F4D0
	public void EndSceneEffect(ESceneInteractionEffect effectKey)
	{
		if (this.InteractionActor != null)
		{
			this.InteractionActor.EndIndependentEffect(effectKey);
		}
	}

	// Token: 0x0601B1A8 RID: 111016 RVA: 0x008512E6 File Offset: 0x0084F4E6
	public void PlaySceneEndEffect(ESceneInteractionEffect effectKey)
	{
		if (this.InteractionActor != null)
		{
			this.InteractionActor.PlayIndependentEndEffect(effectKey);
		}
	}

	// Token: 0x0601B1A9 RID: 111017 RVA: 0x008512FC File Offset: 0x0084F4FC
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

	// Token: 0x0601B1AA RID: 111018 RVA: 0x0085153C File Offset: 0x0084F73C
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

	// Token: 0x0601B1AB RID: 111019 RVA: 0x0085155C File Offset: 0x0084F75C
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

	// Token: 0x0601B1AC RID: 111020 RVA: 0x00851654 File Offset: 0x0084F854
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

	// Token: 0x0601B1AD RID: 111021 RVA: 0x0085168C File Offset: 0x0084F88C
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

	// Token: 0x0601B1AE RID: 111022 RVA: 0x008516B4 File Offset: 0x0084F8B4
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

	// Token: 0x0601B1AF RID: 111023 RVA: 0x008517A8 File Offset: 0x0084F9A8
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

	// Token: 0x0601B1B0 RID: 111024 RVA: 0x0085186C File Offset: 0x0084FA6C
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

	// Token: 0x0601B1B1 RID: 111025 RVA: 0x008518D0 File Offset: 0x0084FAD0
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

	// Token: 0x0601B1B2 RID: 111026 RVA: 0x00851934 File Offset: 0x0084FB34
	public unsafe FGameplayTag? GetPartCollisionActorTag(AActor actor)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		TMap<AActor, FGameplayTag> partCollisionActorsAndCorrespondingTags = this.InteractionActor.PartCollisionActorsAndCorrespondingTags;
		if (partCollisionActorsAndCorrespondingTags == null || !ObjectUtils.IsValid(actor))
		{
			return null;
		}
		FGameplayTag value;
		if (!partCollisionActorsAndCorrespondingTags.TryGetValue(actor, out value))
		{
			List<string> list = new List<string>();
			int num = partCollisionActorsAndCorrespondingTags.Num();
			for (int i = 0; i < num; i++)
			{
				AActor key = partCollisionActorsAndCorrespondingTags.GetKey(i);
				list.Add(ObjectUtils.IsValid(key) ? key.GetName() : "Invalid");
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Interaction;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "[SceneInteractionLevel.GetPartCollisionActorTag] 受击Actor未配置在PartCollisionActorsAndCorrespondingTags中，请检查场景交互物蓝图配置";
			<>y__InlineArray9<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray9<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LevelName", this.LevelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", this.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("HandleId", this.HandleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("InteractionActor", this.InteractionActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("HitActor", actor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("HitActorPath", actor.GetPathName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("ConfiguredActorNum", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("ConfiguredActors", string.Join(",", list));
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 9));
			return null;
		}
		return new FGameplayTag?(value);
	}

	// Token: 0x0601B1B3 RID: 111027 RVA: 0x00851B30 File Offset: 0x0084FD30
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

	// Token: 0x0601B1B4 RID: 111028 RVA: 0x00851B84 File Offset: 0x0084FD84
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

	// Token: 0x0601B1B5 RID: 111029 RVA: 0x00851BE7 File Offset: 0x0084FDE7
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

	// Token: 0x0601B1B6 RID: 111030 RVA: 0x00851C03 File Offset: 0x0084FE03
	public void PlayExtraEffect(FGameplayTag tag, bool jumpToEnd)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.PlayExtraEffectOnTagsChange(tag, jumpToEnd);
	}

	// Token: 0x0601B1B7 RID: 111031 RVA: 0x00851C2A File Offset: 0x0084FE2A
	public void PlayKuroSkeletalMeshDestruction(AActor actor, bool jumpToEnd)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.PlayKuroSkeletalMeshDestruction(actor, jumpToEnd);
	}

	// Token: 0x0601B1B8 RID: 111032 RVA: 0x00851C51 File Offset: 0x0084FE51
	public void StopExtraEffect(FGameplayTag tag)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.StopExtraEffectOnTagsChange(tag);
	}

	// Token: 0x0601B1B9 RID: 111033 RVA: 0x00851C77 File Offset: 0x0084FE77
	public void UpdateHitInfo(global::Vector pos, FVector dir)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.UpdateHitInfo(pos.ToUeVector(false), dir);
	}

	// Token: 0x0601B1BA RID: 111034 RVA: 0x00851CA4 File Offset: 0x0084FEA4
	public void UpdateRangeOverlapInfo(bool isEnter, AActor otherActor)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.UpdateRangeOverlapInfo(isEnter, otherActor);
	}

	// Token: 0x0601B1BB RID: 111035 RVA: 0x00851CCC File Offset: 0x0084FECC
	public float? GetActiveTagSequencePlaybackProgress(FGameplayTag tag)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		return this.InteractionActor.GetActiveTagSequencePlaybackProgress(tag);
	}

	// Token: 0x0601B1BC RID: 111036 RVA: 0x00851D06 File Offset: 0x0084FF06
	public void SetActiveTagSequencePlaybackProgress(FGameplayTag tag, float progress)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.SetActiveTagSequencePlaybackProgress(tag, progress);
	}

	// Token: 0x0601B1BD RID: 111037 RVA: 0x00851D30 File Offset: 0x0084FF30
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

	// Token: 0x0601B1BE RID: 111038 RVA: 0x00851D8B File Offset: 0x0084FF8B
	public void SetActiveTagSequenceDurationTime(FGameplayTag tag, float durationSecond)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.SetActiveTagSequenceDurationTime(tag, durationSecond);
	}

	// Token: 0x0601B1BF RID: 111039 RVA: 0x00851DB2 File Offset: 0x0084FFB2
	public void PauseActiveTagSequence(FGameplayTag tag)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.PauseActiveTagSequence(tag);
	}

	// Token: 0x0601B1C0 RID: 111040 RVA: 0x00851DD8 File Offset: 0x0084FFD8
	public void ResumeActiveTagSequence(FGameplayTag tag, bool bReverseFromConfig = false)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.ResumeActiveTagSequence(tag, bReverseFromConfig);
	}

	// Token: 0x0601B1C1 RID: 111041 RVA: 0x00851E00 File Offset: 0x00850000
	public bool? GetIsActiveTagSequencePlayReverseFromConfig(FGameplayTag tag)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return null;
		}
		return this.InteractionActor.GetIsActiveTagSequencePlayReverseFromConfig(tag);
	}

	// Token: 0x0601B1C2 RID: 111042 RVA: 0x00851E3A File Offset: 0x0085003A
	public void PlayActiveTagSequenceTo(FGameplayTag tag, float progress, bool bReverseFromConfig = false)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.PlayActiveTagSequenceTo(tag, progress, bReverseFromConfig);
	}

	// Token: 0x0601B1C3 RID: 111043 RVA: 0x00851E62 File Offset: 0x00850062
	public void SetOverrideSeqBindActor(AActor actorToBind, [Nullable(2)] string bindingName = null)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.SetOverrideSeqBindActor(actorToBind, bindingName);
	}

	// Token: 0x0601B1C4 RID: 111044 RVA: 0x00851E89 File Offset: 0x00850089
	public void UnsetOverrideSeqBindActor(AActor actorToUnBind, [Nullable(2)] string bindingName = null)
	{
		SceneInteractionActor interactionActor = this.InteractionActor;
		if (interactionActor == null || !interactionActor.IsValid())
		{
			return;
		}
		this.InteractionActor.UnsetOverrideSeqBindActor(actorToUnBind, bindingName);
	}

	// Token: 0x0601B1C5 RID: 111045 RVA: 0x00851EB0 File Offset: 0x008500B0
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

	// Token: 0x0601B1C6 RID: 111046 RVA: 0x00851ED6 File Offset: 0x008500D6
	public void Disable()
	{
		this.Active = false;
		if (this.InteractionActor != null)
		{
			this.InteractionActor.Active = false;
		}
	}

	// Token: 0x0601B1C7 RID: 111047 RVA: 0x00851EF3 File Offset: 0x008500F3
	public void Enable()
	{
		this.Active = true;
		if (this.InteractionActor != null)
		{
			this.InteractionActor.Active = true;
		}
	}

	// Token: 0x0400EB83 RID: 60291
	[Nullable(2)]
	protected ULevelStreamingDynamic LevelStreamingDynamic;

	// Token: 0x0400EB84 RID: 60292
	public string LevelName = "";

	// Token: 0x0400EB85 RID: 60293
	protected FVectorDouble? Location;

	// Token: 0x0400EB86 RID: 60294
	protected FRotator? Rotation;

	// Token: 0x0400EB87 RID: 60295
	protected int PbDataId;

	// Token: 0x0400EB88 RID: 60296
	protected int HandleId;

	// Token: 0x0400EB89 RID: 60297
	protected int EntityId;

	// Token: 0x0400EB8A RID: 60298
	protected EKuroSceneInteractionState? CurrentState;

	// Token: 0x0400EB8B RID: 60299
	protected bool LoadingLevelComplete;

	// Token: 0x0400EB8C RID: 60300
	[Nullable(2)]
	protected SceneInteractionActor InteractionActor;

	// Token: 0x0400EB8D RID: 60301
	protected bool HasTempState;

	// Token: 0x0400EB8E RID: 60302
	protected EKuroSceneInteractionState? TempTargetState;

	// Token: 0x0400EB8F RID: 60303
	protected bool TempNeedTransition;

	// Token: 0x0400EB90 RID: 60304
	protected bool IsDestroyed;

	// Token: 0x0400EB91 RID: 60305
	protected bool Active = true;

	// Token: 0x0400EB92 RID: 60306
	protected bool TempForce;

	// Token: 0x0400EB93 RID: 60307
	[Nullable(2)]
	protected Action OnLevelStreamingShowCallback;

	// Token: 0x0400EB94 RID: 60308
	[Nullable(2)]
	protected Action OnLevelStreamingLoadedCallback;

	// Token: 0x0400EB95 RID: 60309
	[Nullable(2)]
	protected Action OnLevelStreamingHideCallback;

	// Token: 0x0400EB96 RID: 60310
	private bool IsInitShow;

	// Token: 0x0400EB97 RID: 60311
	private static readonly bool EnableSceneInteractionLog;
}
