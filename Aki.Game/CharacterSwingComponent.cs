using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.Swing;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using UnrealEngine;

// Token: 0x0200255F RID: 9567
[NullableContext(1)]
[Nullable(0)]
public class CharacterSwingComponent : EntityComponent
{
	// Token: 0x06017A18 RID: 96792 RVA: 0x006FB7F4 File Offset: 0x006F99F4
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.MoveComp = base.Entity.GetComponent<BaseMoveComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		return true;
	}

	// Token: 0x06017A19 RID: 96793 RVA: 0x006FB848 File Offset: 0x006F9A48
	protected override void OnTick(float delta)
	{
		if (this.IsStartSwing)
		{
			PawnChairController chairController = this.ChairController;
			bool flag;
			if (chairController == null)
			{
				flag = false;
			}
			else
			{
				Entity entity = chairController.Entity;
				bool? flag2;
				if (entity == null)
				{
					flag2 = null;
				}
				else
				{
					SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
					flag2 = ((component != null) ? new bool?(component.GetIsSceneInteractionLoadCompleted()) : null);
				}
				bool? flag3 = flag2;
				flag = flag3.GetValueOrDefault();
			}
			bool flag4 = flag;
			if (this.SwingMontage != null && flag4)
			{
				SwingConfig swingConfig = this.SwingConfig;
				if (swingConfig != null && swingConfig.IsRole)
				{
					this.OnStartRoleSwing();
				}
				else
				{
					this.OnStartSwing();
				}
				this.IsStartSwing = false;
			}
		}
		if (this.SwingState == ESwingStateType.EnterSwing || this.SwingState == ESwingStateType.LoopSwing)
		{
			BaseMoveComponent moveComp = this.MoveComp;
			if (moveComp != null && moveComp.HasMoveInput)
			{
				this.ExitLoopSwing();
			}
		}
	}

	// Token: 0x06017A1A RID: 96794 RVA: 0x006FB908 File Offset: 0x006F9B08
	public unsafe void StartSwing(string daPath, int chairPbDataId, bool? immediately = false)
	{
		bool value = immediately.GetValueOrDefault();
		if (immediately == null)
		{
			value = false;
			immediately = new bool?(value);
		}
		if (this.IsSwinging || this.IsStartSwing)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[CharacterSwing] 正在荡秋千";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			CharacterActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Chair", chairPbDataId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (!this.GetChairController(chairPbDataId))
		{
			return;
		}
		this.Immediately = immediately.Value;
		this.InitConfig(daPath, delegate([Nullable(2)] UAnimMontage result, string _)
		{
			if (result == null || !result.IsValid())
			{
				return;
			}
			this.SwingMontage = result;
			this.IsStartSwing = true;
		});
	}

	// Token: 0x06017A1B RID: 96795 RVA: 0x006FB9F0 File Offset: 0x006F9BF0
	public unsafe void StartRoleSwing(string daPath, int chairPbDataId, bool immediately = false)
	{
		if (Time.Instance.Now - this.LastEndSwingTime < 1000.0)
		{
			return;
		}
		if (this.ActorComp == null)
		{
			return;
		}
		if (this.IsSwinging || this.IsStartSwing)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[CharacterSwing] 正在荡秋千";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			CharacterActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Chair", chairPbDataId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (!this.GetChairController(chairPbDataId))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "[CharacterSwing] 椅子Entity或ChairController无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item2 = "PbDataId";
			CharacterActorComponent actorComp2 = this.ActorComp;
			ptr2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? new int?(actorComp2.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Chair", chairPbDataId);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		this.Immediately = immediately;
		int pbDataId = this.ActorComp.CreatureData.GetPbDataId();
		int baseRoleId = RoleConfig.Instance.GetBaseRoleId(pbDataId);
		this.InitRoleConfig(baseRoleId, daPath, delegate([Nullable(2)] UAnimMontage result, string _)
		{
			if (result == null || !result.IsValid())
			{
				return;
			}
			this.SwingMontage = result;
			this.IsStartSwing = true;
		});
	}

	// Token: 0x06017A1C RID: 96796 RVA: 0x006FBB7E File Offset: 0x006F9D7E
	public void LeftStartSwing()
	{
		if (this.SwingState != ESwingStateType.EnterSwing)
		{
			return;
		}
		this.ChangeSwingState(ESwingStateType.LoopSwing);
	}

	// Token: 0x06017A1D RID: 96797 RVA: 0x006FBB94 File Offset: 0x006F9D94
	public void ExitLoopSwing()
	{
		if (!this.IsSwinging)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[CharacterSwing] 重复退出荡秋千";
			string item = "PbDataId";
			CharacterActorComponent actorComp = this.ActorComp;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.SwingState != ESwingStateType.EnterSwing && this.SwingState != ESwingStateType.LoopSwing)
		{
			return;
		}
		SwingConfig swingConfig = this.SwingConfig;
		if (swingConfig != null && swingConfig.ExitImmediately)
		{
			this.ExitSwingImmediately();
			return;
		}
		this.ChangeSwingState(ESwingStateType.LeftLoopSwing);
	}

	// Token: 0x06017A1E RID: 96798 RVA: 0x006FBC30 File Offset: 0x006F9E30
	public void LeftLoopSwing()
	{
		if (this.SwingState != ESwingStateType.LeftLoopSwing)
		{
			return;
		}
		this.ChangeSwingState(ESwingStateType.ExitSwing);
		this.StandUp();
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null)
		{
			return;
		}
		actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Falling,
			Context = "[CharacterSwingComponent.LeftLoopSwing]"
		});
	}

	// Token: 0x06017A1F RID: 96799 RVA: 0x006FBC80 File Offset: 0x006F9E80
	public void LeftEndSwing()
	{
		if (this.SwingState == ESwingStateType.None)
		{
			return;
		}
		if (this.SwingState == ESwingStateType.EnterSwing || this.SwingState == ESwingStateType.LoopSwing)
		{
			this.ChangeSwingState(ESwingStateType.LeftLoopSwing);
		}
		if (this.SwingState == ESwingStateType.LeftLoopSwing)
		{
			this.LeftLoopSwing();
		}
		if (this.SwingState != ESwingStateType.ExitSwing)
		{
			return;
		}
		this.FinishSwing();
	}

	// Token: 0x06017A20 RID: 96800 RVA: 0x006FBCD0 File Offset: 0x006F9ED0
	private void OnStartSwing()
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		this.AnimInstance = (((animComp != null) ? animComp.MainAnimInstance : null) as UKuroAnimInstanceChar);
		UKuroAnimInstanceChar animInstance = this.AnimInstance;
		if (((animInstance != null) ? animInstance.LogicParams : null) == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[CharacterSwing] 开始荡秋千失败，AnimInstance异常", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Custom,
				CustomMode = 14,
				Context = "[CharacterSwingComponent.StartSwing]"
			});
		}
		if (this.SitOnChair())
		{
			this.ChangeSwingState(ESwingStateType.EnterSwing);
			if (this.Immediately)
			{
				this.ChangeSwingState(ESwingStateType.LoopSwing);
			}
			return;
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		if (actorComp2 == null)
		{
			return;
		}
		actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Falling,
			Context = "[CharacterSwingComponent.StartSwing.Rollback]"
		});
	}

	// Token: 0x06017A21 RID: 96801 RVA: 0x006FBDAC File Offset: 0x006F9FAC
	private void OnStartRoleSwing()
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		this.AnimInstance = (((animComp != null) ? animComp.MainAnimInstance : null) as UKuroAnimInstanceChar);
		UKuroAnimInstanceChar animInstance = this.AnimInstance;
		if (((animInstance != null) ? animInstance.LogicParams : null) == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[CharacterSwing] 开始荡秋千失败，AnimInstance异常", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Custom,
				CustomMode = 14,
				Context = "[CharacterSwingComponent.StartSwing]"
			});
		}
		if (this.SitOnChair())
		{
			this.ChangeSwingState(ESwingStateType.EnterSwing);
			if (this.Immediately)
			{
				this.ChangeSwingState(ESwingStateType.LoopSwing);
			}
			return;
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		if (actorComp2 == null)
		{
			return;
		}
		actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Falling,
			Context = "[CharacterSwingComponent.StartSwing.Rollback]"
		});
	}

	// Token: 0x06017A22 RID: 96802 RVA: 0x006FBE88 File Offset: 0x006FA088
	private bool SitOnChair()
	{
		PawnChairController chairController = this.ChairController;
		SceneItemActorComponent sceneItemActorComponent;
		if (chairController == null)
		{
			sceneItemActorComponent = null;
		}
		else
		{
			Entity entity = chairController.Entity;
			sceneItemActorComponent = ((entity != null) ? entity.GetComponent<SceneItemActorComponent>() : null);
		}
		SceneItemActorComponent sceneItemActorComponent2 = sceneItemActorComponent;
		if (this.ChairController == null || sceneItemActorComponent2 == null)
		{
			return false;
		}
		this.ChairController.Possess(base.Entity, false);
		this.ChairController.IgnoreCollision();
		this.IgnoreCollision(this.ChairController.Entity);
		Vector sitLocation = this.ChairController.GetSitLocation();
		Vector forwardDirection = this.ChairController.GetForwardDirection();
		forwardDirection.Multiply((double)this.SwingConfig.StandUpMoveAwayDist, this.ChairPosition);
		this.ChairPosition.AdditionEqual(sitLocation);
		forwardDirection.Rotation(this.TempRotator);
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.SetActorLocationAndRotation(this.ChairPosition.ToUeVector(false), this.TempRotator.ToUeRotator(), "[CharacterSwingComponent] SitOnChair", false, null);
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		if (actorComp2 != null)
		{
			actorComp2.ClearInput(false, true);
		}
		CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
		FTransformDouble? ftransformDouble = (component != null) ? new FTransformDouble?(component.GetMeshTransform()) : null;
		if (!this.AttachToSocket(sceneItemActorComponent2))
		{
			return false;
		}
		if (ftransformDouble != null && this.SwingConfig.SitOnModelBufferTime > 10)
		{
			CharacterAnimationComponent component2 = base.Entity.GetComponent<CharacterAnimationComponent>();
			if (component2 != null)
			{
				component2.SetModelBuffer(ftransformDouble.Value, (float)this.SwingConfig.SitOnModelBufferTime);
			}
		}
		this.ChangeSitDownTag(true);
		return true;
	}

	// Token: 0x06017A23 RID: 96803 RVA: 0x006FC000 File Offset: 0x006FA200
	private void StandUp()
	{
		PawnChairController chairController = this.ChairController;
		if (chairController != null)
		{
			chairController.ResetCollision();
		}
		PawnChairController chairController2 = this.ChairController;
		if (chairController2 != null)
		{
			chairController2.UnPossess(base.Entity);
		}
		PawnChairController chairController3 = this.ChairController;
		if (((chairController3 != null) ? chairController3.Entity : null) != null)
		{
			this.ResetCollision(this.ChairController.Entity);
		}
		this.ResetAttach();
		TimerSystem.Instance.Delay(delegate(float _)
		{
			this.ChangeSitDownTag(false);
		}, 1000f, null, null, true, 1f);
		SwingConfig swingConfig = this.SwingConfig;
		if (swingConfig != null && swingConfig.ExitImmediately)
		{
			this.ResetActor();
			return;
		}
		CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
		FTransformDouble? ftransformDouble = (component != null) ? new FTransformDouble?(component.GetMeshTransform()) : null;
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.SetActorLocation(this.ChairPosition.ToUeVector(false), "[CharacterSwingComponent] SitOnChair", false);
		}
		if (ftransformDouble != null && this.SwingConfig.StandUpModelBufferTime > 10)
		{
			CharacterAnimationComponent component2 = base.Entity.GetComponent<CharacterAnimationComponent>();
			if (component2 != null)
			{
				component2.SetModelBuffer(ftransformDouble.Value, (float)this.SwingConfig.StandUpModelBufferTime);
			}
		}
		this.ResetActor();
	}

	// Token: 0x06017A24 RID: 96804 RVA: 0x006FC130 File Offset: 0x006FA330
	private void ResetActor()
	{
		if (this.ChairController != null)
		{
			this.TempVector.DeepCopy(this.ChairController.GetForwardDirection());
		}
		else
		{
			this.TempVector.DeepCopy(this.ActorComp.ActorForwardProxy);
		}
		Vector.VectorPlaneProject(this.TempVector, this.ActorComp.ActorGravityDirectProxy, this.TempVector2);
		if (!this.TempVector2.IsNearlyZero(9.999999747378752E-05))
		{
			this.TempVector2.Normalize(9.99999993922529E-09);
			this.ActorComp.ActorGravityDirectProxy.Multiply(-1.0, this.TempVector);
			MathUtils.Instance.LookRotationForwardFirst(this.TempVector2, this.TempVector, this.TempRotator);
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.SetActorRotation(this.TempRotator.ToUeRotator(), "[CharacterSwingComponent] ResetActor", false);
			}
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		if (actorComp2 != null)
		{
			actorComp2.SetInputDirect(this.ActorComp.ActorForwardProxy, false, EInputDirectSpace.World);
		}
		CharacterActorComponent actorComp3 = this.ActorComp;
		if (actorComp3 != null)
		{
			actorComp3.SetInputFacing(this.ActorComp.ActorForwardProxy, false);
		}
		CharacterActorComponent actorComp4 = this.ActorComp;
		if (actorComp4 == null)
		{
			return;
		}
		actorComp4.ClearInput(false, true);
	}

	// Token: 0x06017A25 RID: 96805 RVA: 0x006FC270 File Offset: 0x006FA470
	private void ChangeSitDownTag(bool value)
	{
		if (value)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp == null || !tagComp.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止坐下"]))
			{
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 != null)
				{
					tagComp2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止坐下"]));
				}
			}
		}
		if (!value)
		{
			BaseTagComponent tagComp3 = this.TagComp;
			if (tagComp3 != null && tagComp3.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止坐下"]))
			{
				BaseTagComponent tagComp4 = this.TagComp;
				if (tagComp4 == null)
				{
					return;
				}
				tagComp4.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止坐下"]));
			}
		}
	}

	// Token: 0x06017A26 RID: 96806 RVA: 0x006FC318 File Offset: 0x006FA518
	private unsafe bool AttachToSocket(SceneItemActorComponent chair)
	{
		SceneInteractionActor sceneInteractionActor = chair.GetInteractionMainActor() as SceneInteractionActor;
		ASkeletalMeshActor askeletalMeshActor = ((sceneInteractionActor != null) ? sceneInteractionActor.GetActorByKey(this.SwingConfig.ReferenceActor) : null) as ASkeletalMeshActor;
		if (((askeletalMeshActor != null) ? askeletalMeshActor.SkeletalMeshComponent : null) == null)
		{
			this.StandUp();
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[CharacterSwing] 椅子ReferenceActor无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.SwingAnimInstance = askeletalMeshActor.SkeletalMeshComponent.GetAnimInstance();
		FName fname = FNameUtil.GetDynamicFName(this.SwingConfig.AttachSocket) ?? FName.NAME_None;
		FTransformDouble ftransformDouble = askeletalMeshActor.SkeletalMeshComponent.D_GetSocketTransform(fname, ERelativeTransformSpace.RTS_World);
		FTransformDouble relativeTransform = chair.ActorTransform.GetRelativeTransform(ftransformDouble);
		this.TempTransform.FromUeTransform(relativeTransform);
		Vector tempVector = this.TempVector;
		FVectorDouble location = ftransformDouble.GetLocation();
		tempVector.FromUeVector(location);
		if (this.TempVector.Equals(Vector.ZeroVectorProxy, 9.999999747378752E-05))
		{
			this.TempVector.DeepCopy(chair.ActorLocationProxy);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[CharacterSwing] 找不到Socket";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", (chair != null) ? new int?(chair.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SocketName", fname);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.ActorComp.Actor.K2_AttachToComponent(askeletalMeshActor.SkeletalMeshComponent, fname, EAttachmentRule.KeepRelative, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, false, true);
		this.ActorComp.SetForbidSettingLocAndRot(false, EForbidSettingLocAndRotReason.Swing);
		this.ActorComp.Actor.D_K2_SetActorRelativeLocation(this.SwingConfig.AttachLocation.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, false);
		this.ActorComp.Actor.K2_SetActorRelativeRotation(this.SwingConfig.AttachRotator.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
		this.ActorComp.ResetAllCachedTime();
		this.ActorComp.SetForbidSettingLocAndRot(true, EForbidSettingLocAndRotReason.Swing);
		return true;
	}

	// Token: 0x06017A27 RID: 96807 RVA: 0x006FC539 File Offset: 0x006FA739
	private void ResetAttach()
	{
		this.ActorComp.Actor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		this.ActorComp.SetForbidSettingLocAndRot(false, EForbidSettingLocAndRotReason.Swing);
	}

	// Token: 0x06017A28 RID: 96808 RVA: 0x006FC55C File Offset: 0x006FA75C
	private void IgnoreCollision(Entity chair)
	{
		SceneItemActorComponent component = chair.GetComponent<SceneItemActorComponent>();
		if (component != null && component.Entity != null)
		{
			this.IgnoreActorsCollision(component, true);
		}
		this.ActorComp.Actor.CapsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Ignore);
	}

	// Token: 0x06017A29 RID: 96809 RVA: 0x006FC59C File Offset: 0x006FA79C
	[NullableContext(2)]
	private void ResetCollision(Entity chair)
	{
		this.ActorComp.Actor.CapsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Block);
		if (chair == null)
		{
			return;
		}
		SceneItemActorComponent component = chair.GetComponent<SceneItemActorComponent>();
		if (component != null && component.Entity != null)
		{
			this.IgnoreActorsCollision(component, false);
		}
	}

	// Token: 0x06017A2A RID: 96810 RVA: 0x006FC5E0 File Offset: 0x006FA7E0
	private void IgnoreActorsCollision(SceneItemActorComponent actorComp, bool bCollision)
	{
		CreatureDataComponent component = actorComp.Entity.GetComponent<CreatureDataComponent>();
		int pbDataId = (component != null) ? component.GetPbDataId() : 0;
		int? ownerEntity = CreatureModel.Instance.GetOwnerEntity(pbDataId);
		SceneItemActorComponent sceneItemActorComponent;
		if (ownerEntity != null)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(ownerEntity.Value);
			if (entityByPbDataId != null && entityByPbDataId.Valid)
			{
				sceneItemActorComponent = entityByPbDataId.Entity.GetComponent<SceneItemActorComponent>();
			}
			else
			{
				sceneItemActorComponent = actorComp;
			}
		}
		else
		{
			sceneItemActorComponent = actorComp;
		}
		TArray<AActor> tarray = new TArray<AActor>();
		sceneItemActorComponent.Owner.GetAttachedActors(ref tarray, true);
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			AActor aactor = tarray.Get(i);
			TArray<AActor> tarray2 = new TArray<AActor>();
			aactor.GetAttachedActors(ref tarray2, true);
			int num2 = tarray2.Num();
			for (int j = 0; j < num2; j++)
			{
				this.ActorComp.Actor.CapsuleComponent.IgnoreActorWhenMoving(tarray2.Get(j), bCollision);
			}
		}
	}

	// Token: 0x06017A2B RID: 96811 RVA: 0x006FC6CE File Offset: 0x006FA8CE
	private void FinishSwing()
	{
		this.LastEndSwingTime = Time.Instance.Now;
		this.ChangeSwingState(ESwingStateType.None);
		this.SwingMontage = null;
		this.SwingAnimInstance = null;
		this.SwingConfig = null;
	}

	// Token: 0x06017A2C RID: 96812 RVA: 0x006FC6FC File Offset: 0x006FA8FC
	private void ExitSwingImmediately()
	{
		this.ChangeSwingState(ESwingStateType.LeftLoopSwing);
		this.StandUp();
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Falling,
				Context = "[CharacterSwingComponent.ExitSwingImmediately]"
			});
		}
		this.FinishSwing();
	}

	// Token: 0x06017A2D RID: 96813 RVA: 0x006FC74C File Offset: 0x006FA94C
	private void InitConfig(string daPath, [Nullable(new byte[]
	{
		1,
		2,
		1
	})] Action<UAnimMontage, string> callback)
	{
		Action<BP_CharacterSwingConfig_C, string> <>9__1;
		ResourceSystem.Instance.LoadTypeAsync("BP_CharacterSwingConfig_C", delegate
		{
			ResourceSystem instance = ResourceSystem.Instance;
			string daPath2 = daPath;
			Action<BP_CharacterSwingConfig_C, string> callback2;
			if ((callback2 = <>9__1) == null)
			{
				callback2 = (<>9__1 = delegate([Nullable(2)] BP_CharacterSwingConfig_C result, string _)
				{
					if (result == null || !result.IsValid())
					{
						return;
					}
					SwingConfig swingConfig = new SwingConfig();
					if (!swingConfig.Init(result))
					{
						return;
					}
					this.SwingConfig = swingConfig;
					ResourceSystem.Instance.LoadAsync<UAnimMontage>(this.SwingConfig.AnimMontagePath, callback, 100, "js_undefined");
				});
			}
			instance.LoadAsync<BP_CharacterSwingConfig_C>(daPath2, callback2, 100, "js_undefined");
		}, "js_undefined");
	}

	// Token: 0x06017A2E RID: 96814 RVA: 0x006FC794 File Offset: 0x006FA994
	private void InitRoleConfig(int roleId, string daPath, [Nullable(new byte[]
	{
		1,
		2,
		1
	})] Action<UAnimMontage, string> callback)
	{
		Action<BP_RoleSwingConfig_C, string> <>9__1;
		ResourceSystem.Instance.LoadTypeAsync("BP_RoleSwingConfig_C", delegate
		{
			ResourceSystem instance = ResourceSystem.Instance;
			string daPath2 = daPath;
			Action<BP_RoleSwingConfig_C, string> callback2;
			if ((callback2 = <>9__1) == null)
			{
				callback2 = (<>9__1 = delegate([Nullable(2)] BP_RoleSwingConfig_C result, string _)
				{
					if (result == null || !result.IsValid())
					{
						return;
					}
					SwingConfig swingConfig = new SwingConfig();
					if (!swingConfig.InitRole(roleId, result))
					{
						return;
					}
					this.SwingConfig = swingConfig;
					ResourceSystem.Instance.LoadAsync<UAnimMontage>(this.SwingConfig.AnimMontagePath, callback, 100, "js_undefined");
				});
			}
			instance.LoadAsync<BP_RoleSwingConfig_C>(daPath2, callback2, 100, "js_undefined");
		}, "js_undefined");
	}

	// Token: 0x06017A2F RID: 96815 RVA: 0x006FC7E4 File Offset: 0x006FA9E4
	private unsafe void ChangeSwingState(ESwingStateType type)
	{
		UKuroAnimInstanceChar animInstance = this.AnimInstance;
		if (((animInstance != null) ? animInstance.LogicParams : null) == null || this.SwingAnimInstance == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[CharacterSwing] 秋千状态切换失败，AnimInstance异常", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (type == this.SwingState && type != ESwingStateType.None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[CharacterSwing] 重复设置荡秋千状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			CharacterActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("type", CharacterSwingComponent.GetSwingStateName(type));
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.SwingState = type;
		this.IsSwinging = (type > ESwingStateType.None);
		this.AnimInstance.LogicParams.bSwingState = this.IsSwinging;
		this.AnimInstance.LogicParams.SwingStateType = type;
		switch (type)
		{
		case ESwingStateType.None:
			this.SwingAnimInstance.Montage_Stop(1f, null);
			return;
		case ESwingStateType.EnterSwing:
			this.SwingAnimInstance.Montage_Play(this.SwingMontage, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
			return;
		case ESwingStateType.LoopSwing:
		case ESwingStateType.LeftLoopSwing:
			break;
		case ESwingStateType.ExitSwing:
			this.SwingAnimInstance.Montage_JumpToSection(CharacterNameDefines.Instance.END_SECTION, this.SwingMontage);
			break;
		default:
			return;
		}
	}

	// Token: 0x06017A30 RID: 96816 RVA: 0x006FC95C File Offset: 0x006FAB5C
	private bool GetChairController(int chairPbDataId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(chairPbDataId);
		WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
		PawnInteractNewComponent pawnInteractNewComponent = (worldEntity != null) ? worldEntity.GetComponent<PawnInteractNewComponent>() : null;
		SceneItemActorComponent sceneItemActorComponent = (worldEntity != null) ? worldEntity.GetComponent<SceneItemActorComponent>() : null;
		this.ChairController = (((pawnInteractNewComponent != null) ? pawnInteractNewComponent.GetSubEntityInteractLogicController() : null) as PawnChairController);
		return worldEntity != null && pawnInteractNewComponent != null && sceneItemActorComponent != null && this.ChairController != null;
	}

	// Token: 0x06017A31 RID: 96817 RVA: 0x006FC9C8 File Offset: 0x006FABC8
	private static string GetSwingStateName(ESwingStateType type)
	{
		switch (type)
		{
		case ESwingStateType.None:
			return "None";
		case ESwingStateType.EnterSwing:
			return "进入荡秋千";
		case ESwingStateType.LoopSwing:
			return "荡秋千中";
		case ESwingStateType.LeftLoopSwing:
			return "预备离开秋千";
		case ESwingStateType.ExitSwing:
			return "退出荡秋千";
		default:
			return "";
		}
	}

	// Token: 0x06017A32 RID: 96818 RVA: 0x006FCA14 File Offset: 0x006FAC14
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSwingComponent characterSwingComponent = (CharacterSwingComponent)componentTemplate;
		if (characterSwingComponent.ChairPosition != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChairPosition), "ChairPosition"))
		{
			return false;
		}
		if (characterSwingComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (characterSwingComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (characterSwingComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempRotator), "TempRotator"))
		{
			return false;
		}
		if (characterSwingComponent.TempTransform != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempTransform), "TempTransform"))
		{
			return false;
		}
		if (characterSwingComponent.ChairController == null)
		{
			this.ChairController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChairController), "ChairController"))
		{
			return false;
		}
		if (characterSwingComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterSwingComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterSwingComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (characterSwingComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (characterSwingComponent.SwingConfig == null)
		{
			this.SwingConfig = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SwingConfig), "SwingConfig"))
		{
			return false;
		}
		if (characterSwingComponent.AnimInstance == null)
		{
			this.AnimInstance = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimInstance), "AnimInstance"))
		{
			return false;
		}
		if (characterSwingComponent.SwingMontage == null)
		{
			this.SwingMontage = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SwingMontage), "SwingMontage"))
		{
			return false;
		}
		if (characterSwingComponent.SwingAnimInstance == null)
		{
			this.SwingAnimInstance = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SwingAnimInstance), "SwingAnimInstance"))
		{
			return false;
		}
		this.IsSwinging = characterSwingComponent.IsSwinging;
		this.IsStartSwing = characterSwingComponent.IsStartSwing;
		this.SwingState = characterSwingComponent.SwingState;
		this.Immediately = characterSwingComponent.Immediately;
		this.LastEndSwingTime = characterSwingComponent.LastEndSwingTime;
		return true;
	}

	// Token: 0x17002497 RID: 9367
	// (get) Token: 0x06017A33 RID: 96819 RVA: 0x006FCC9D File Offset: 0x006FAE9D
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002498 RID: 9368
	// (get) Token: 0x06017A34 RID: 96820 RVA: 0x006FCCA0 File Offset: 0x006FAEA0
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C935 RID: 51509
	private const long SWING_INTERVAL_TIME = 1000L;

	// Token: 0x0400C936 RID: 51510
	private readonly Vector ChairPosition = Vector.Create();

	// Token: 0x0400C937 RID: 51511
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x0400C938 RID: 51512
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x0400C939 RID: 51513
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x0400C93A RID: 51514
	private readonly Transform TempTransform = Transform.Create();

	// Token: 0x0400C93B RID: 51515
	[Nullable(2)]
	private PawnChairController ChairController;

	// Token: 0x0400C93C RID: 51516
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400C93D RID: 51517
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x0400C93E RID: 51518
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400C93F RID: 51519
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400C940 RID: 51520
	[Nullable(2)]
	private SwingConfig SwingConfig;

	// Token: 0x0400C941 RID: 51521
	[Nullable(2)]
	private UKuroAnimInstanceChar AnimInstance;

	// Token: 0x0400C942 RID: 51522
	[Nullable(2)]
	private UAnimMontage SwingMontage;

	// Token: 0x0400C943 RID: 51523
	[Nullable(2)]
	private UAnimInstance SwingAnimInstance;

	// Token: 0x0400C944 RID: 51524
	public bool IsSwinging;

	// Token: 0x0400C945 RID: 51525
	public bool IsStartSwing;

	// Token: 0x0400C946 RID: 51526
	public ESwingStateType SwingState;

	// Token: 0x0400C947 RID: 51527
	private bool Immediately;

	// Token: 0x0400C948 RID: 51528
	public double LastEndSwingTime;
}
