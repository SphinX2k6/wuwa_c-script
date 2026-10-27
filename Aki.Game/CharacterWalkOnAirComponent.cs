using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using UnrealEngine;

// Token: 0x02003096 RID: 12438
[NullableContext(2)]
[Nullable(0)]
public class CharacterWalkOnAirComponent : EntityComponent
{
	// Token: 0x0601A94C RID: 108876 RVA: 0x00722008 File Offset: 0x00720208
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		this.BaseCharacter = this.ActorComp.Actor;
		this.TagComp = component;
		CharacterMoveComponent component2 = base.Entity.GetComponent<CharacterMoveComponent>();
		if (component2 == null || !component2.Valid)
		{
			return false;
		}
		this.RegisterEvent();
		this.StateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		return true;
	}

	// Token: 0x0601A94D RID: 108877 RVA: 0x00722094 File Offset: 0x00720294
	private void RegisterEvent()
	{
		this.OnWalkOnAirTagNewOrRemove = this.TagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.空中行走"]), new BaseTagComponent.TTagSwitchedCallback(this.OnStateTagsChanged), null);
		this.OnForegroundTagNewOrRemove = this.TagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"]), new BaseTagComponent.TTagSwitchedCallback(this.OnForegroundTagsChanged), null);
		this.OnSkillTagNewOrRemove = this.TagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]), new BaseTagComponent.TTagSwitchedCallback(this.OnDoSkill), null);
		EventSystem.Instance.AddWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChanged));
		EventSystem.Instance.AddWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnCharacterMovementModeChanged));
		EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
	}

	// Token: 0x0601A94E RID: 108878 RVA: 0x007221B9 File Offset: 0x007203B9
	private void OnDoSkill(int tagId, bool tagExists)
	{
		if (tagExists && this.IsWalkOnAir)
		{
			this.SetIsWalkOnAir(false);
		}
	}

	// Token: 0x0601A94F RID: 108879 RVA: 0x007221D0 File Offset: 0x007203D0
	private void UnregisterEvent()
	{
		ITagTask onWalkOnAirTagNewOrRemove = this.OnWalkOnAirTagNewOrRemove;
		if (onWalkOnAirTagNewOrRemove != null)
		{
			onWalkOnAirTagNewOrRemove.EndTask();
		}
		ITagTask onForegroundTagNewOrRemove = this.OnForegroundTagNewOrRemove;
		if (onForegroundTagNewOrRemove != null)
		{
			onForegroundTagNewOrRemove.EndTask();
		}
		ITagTask onSkillTagNewOrRemove = this.OnSkillTagNewOrRemove;
		if (onSkillTagNewOrRemove != null)
		{
			onSkillTagNewOrRemove.EndTask();
		}
		EventSystem.Instance.RemoveWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChanged));
		EventSystem.Instance.RemoveWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnCharacterMovementModeChanged));
		EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
	}

	// Token: 0x0601A950 RID: 108880 RVA: 0x00722292 File Offset: 0x00720492
	private void OnStateTagsChanged(int tagId, bool tagExists)
	{
		this.IsActive = tagExists;
		if (!this.IsActive)
		{
			this.SetIsWalkOnAir(false);
		}
	}

	// Token: 0x0601A951 RID: 108881 RVA: 0x007222AA File Offset: 0x007204AA
	private void OnForegroundTagsChanged(int tagId, bool tagExists)
	{
		if (!tagExists)
		{
			this.SetIsWalkOnAir(false);
		}
	}

	// Token: 0x0601A952 RID: 108882 RVA: 0x007222B6 File Offset: 0x007204B6
	private void OnPositionStateChanged(ECharPositionState oldPositionState, ECharPositionState newPositionState)
	{
		if (newPositionState == ECharPositionState.Ground && this.IsWalkOnAir)
		{
			this.StateComp.SetPositionSubState(ECharPositionSubState.WalkOnAir, false);
		}
	}

	// Token: 0x0601A953 RID: 108883 RVA: 0x007222D0 File Offset: 0x007204D0
	[NullableContext(1)]
	private void OnStateInherit(Entity other, bool notInheritMoveAndAnim)
	{
		if (other == null || !other.Valid)
		{
			return;
		}
		this.IsActive = this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.空中行走"]);
		if (!this.IsActive)
		{
			this.SetIsWalkOnAir(false);
		}
	}

	// Token: 0x0601A954 RID: 108884 RVA: 0x0072231E File Offset: 0x0072051E
	private void OnTeleportComplete(TeleportContext teleportContext)
	{
		if (!this.IsActive || !this.IsWalkOnAir)
		{
			return;
		}
		this.StateComp.SetPositionSubState(ECharPositionSubState.WalkOnAir, false);
	}

	// Token: 0x0601A955 RID: 108885 RVA: 0x00722340 File Offset: 0x00720540
	private void OnCharacterMovementModeChanged(int charId, EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
	{
		if (!this.IsActive || this.ChangeStateFrame >= Time.Instance.Frame)
		{
			return;
		}
		if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"]) && prevMovementMode == EMovementMode.MOVE_Walking && newMovementMode == EMovementMode.MOVE_Falling && !this.ActorComp.InputDirectProxy.IsNearlyZero(9.999999747378752E-05))
		{
			TsBaseCharacter baseCharacter = this.BaseCharacter;
			if ((baseCharacter == null || !baseCharacter.IsKuroForceFlying()) && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]) && FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength) > 10f)
			{
				CharacterUnifiedStateComponent stateComp = this.StateComp;
				if (stateComp != null && stateComp.IsWalkMode)
				{
					this.CreateAirFloor();
					this.SetIsWalkOnAir(true);
					this.ChangeStateFrame = Time.Instance.Frame + 2;
					return;
				}
			}
		}
		if (newMovementMode != EMovementMode.MOVE_Walking)
		{
			this.SetIsWalkOnAir(false);
		}
	}

	// Token: 0x0601A956 RID: 108886 RVA: 0x00722434 File Offset: 0x00720634
	private void CreateOneAirFloor(int index)
	{
		AActor aactor = ActorSystem.Instance.Get(AActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
		if (aactor == null)
		{
			CombatLog.Instance.Warn(CombatLog.EDebugModule.Move, base.Entity, "空中行走创建地面失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UBoxComponent uboxComponent = aactor.AddComponentByClass(UBoxComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UBoxComponent;
		uboxComponent.D_SetBoxExtent(CharacterWalkOnAirComponent.DefaultBoxExtent, true);
		uboxComponent.SetCollisionObjectType(KuroCollisionChannel.WorldStaticIgnoreBullet);
		uboxComponent.SetCollisionResponseToAllChannels(ECollisionResponse.ECR_Ignore);
		uboxComponent.SetCollisionResponseToChannel(KuroCollisionChannel.PawnPlayer, ECollisionResponse.ECR_Block);
		while (this.AirFloor.Count <= index)
		{
			this.AirFloor.Add(null);
		}
		this.AirFloor[index] = aactor;
		while (this.BoxComp.Count <= index)
		{
			this.BoxComp.Add(null);
		}
		this.BoxComp[index] = uboxComponent;
	}

	// Token: 0x0601A957 RID: 108887 RVA: 0x00722528 File Offset: 0x00720728
	private void CreateAirFloor()
	{
		if (this.AirFloor.Count > 0)
		{
			return;
		}
		this.ValidAirFloorIndex = 0;
		this.CreateOneAirFloor(0);
		UBoxComponent uboxComponent = this.BoxComp.ElementAtOrDefault(0);
		if (uboxComponent != null)
		{
			uboxComponent.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
		}
		this.CreateOneAirFloor(1);
		UBoxComponent uboxComponent2 = this.BoxComp.ElementAtOrDefault(1);
		if (uboxComponent2 == null)
		{
			return;
		}
		uboxComponent2.SetCollisionEnabled(ECollisionEnabled.NoCollision);
	}

	// Token: 0x0601A958 RID: 108888 RVA: 0x00722588 File Offset: 0x00720788
	private void SetIsWalkOnAir(bool bStart)
	{
		if (bStart == this.IsWalkOnAir)
		{
			if (bStart)
			{
				this.UpdateAirFloorPos(false);
			}
			return;
		}
		this.IsWalkOnAir = bStart;
		if (bStart)
		{
			this.UpdateAirFloorPos(false);
			UBoxComponent uboxComponent = this.BoxComp.ElementAtOrDefault(this.ValidAirFloorIndex);
			if (uboxComponent != null)
			{
				uboxComponent.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
			}
			this.StateComp.SetPositionSubState(ECharPositionSubState.WalkOnAir, false);
			return;
		}
		UBoxComponent uboxComponent2 = this.BoxComp.ElementAtOrDefault(this.ValidAirFloorIndex);
		if (uboxComponent2 != null)
		{
			uboxComponent2.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		}
		this.StateComp.SetPositionSubState(ECharPositionSubState.None, false);
	}

	// Token: 0x0601A959 RID: 108889 RVA: 0x00722610 File Offset: 0x00720810
	private void UpdateAirFloorPos(bool bUseRecordHeight = false)
	{
		Vector floorLocation = this.ActorComp.FloorLocation;
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, floorLocation, -CharacterWalkOnAirComponent.DefaultBoxExtent.Z);
		this.AirFloorPos.DeepCopy(floorLocation);
		Vector gravityDirectForActor = GravityUtils.Instance.GetGravityDirectForActor(this.ActorComp);
		if (bUseRecordHeight)
		{
			double num = floorLocation.DotProduct(gravityDirectForActor);
			floorLocation.AdditionEqual(gravityDirectForActor.Multiply(this.AirFloorHeight - num, MathUtils.Instance.CommonTempVector));
		}
		else
		{
			this.AirFloorHeight = floorLocation.DotProduct(gravityDirectForActor);
		}
		FHitResult fhitResult = new FHitResult();
		AActor aactor = this.AirFloor.ElementAtOrDefault(this.ValidAirFloorIndex);
		if (aactor == null)
		{
			return;
		}
		aactor.D_K2_SetActorLocationAndRotation(floorLocation.ToUeVector(false), this.ActorComp.ActorRotation, false, ref fhitResult, false);
	}

	// Token: 0x0601A95A RID: 108890 RVA: 0x007226D4 File Offset: 0x007208D4
	private void SwitchAirFloor()
	{
		UBoxComponent uboxComponent = this.BoxComp.ElementAtOrDefault(this.ValidAirFloorIndex);
		if (uboxComponent != null)
		{
			uboxComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		}
		this.ValidAirFloorIndex ^= 1;
		UBoxComponent uboxComponent2 = this.BoxComp.ElementAtOrDefault(this.ValidAirFloorIndex);
		if (uboxComponent2 == null)
		{
			return;
		}
		uboxComponent2.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
	}

	// Token: 0x0601A95B RID: 108891 RVA: 0x00722728 File Offset: 0x00720928
	protected override void OnTick(float delta)
	{
		if (!this.IsWalkOnAir)
		{
			return;
		}
		if (Vector.DistSquared(this.AirFloorPos, this.ActorComp.FloorLocation) > 22500.0)
		{
			this.SwitchAirFloor();
			this.UpdateAirFloorPos(true);
		}
		if (this.ChangeStateFrame >= Time.Instance.Frame)
		{
			return;
		}
		if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.行走"]) || FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength) <= 0f)
		{
			this.SetIsWalkOnAir(false);
			this.ChangeStateFrame = Time.Instance.Frame + 2;
		}
	}

	// Token: 0x0601A95C RID: 108892 RVA: 0x007227C6 File Offset: 0x007209C6
	protected override bool OnEnd()
	{
		this.UnregisterEvent();
		return true;
	}

	// Token: 0x0601A95D RID: 108893 RVA: 0x007227D0 File Offset: 0x007209D0
	protected override bool OnClear()
	{
		foreach (AActor actor in this.AirFloor)
		{
			ActorSystem.Instance.Put("OnClearWalkOnAir", actor, null);
		}
		this.AirFloor.Clear();
		this.BoxComp.Clear();
		return true;
	}

	// Token: 0x0601A95E RID: 108894 RVA: 0x00722848 File Offset: 0x00720A48
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterWalkOnAirComponent characterWalkOnAirComponent = (CharacterWalkOnAirComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterWalkOnAirComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterWalkOnAirComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OnWalkOnAirTagNewOrRemove"))
		{
			if (characterWalkOnAirComponent.OnWalkOnAirTagNewOrRemove == null)
			{
				this.OnWalkOnAirTagNewOrRemove = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.OnWalkOnAirTagNewOrRemove), "OnWalkOnAirTagNewOrRemove"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OnForegroundTagNewOrRemove"))
		{
			if (characterWalkOnAirComponent.OnForegroundTagNewOrRemove == null)
			{
				this.OnForegroundTagNewOrRemove = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.OnForegroundTagNewOrRemove), "OnForegroundTagNewOrRemove"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OnSkillTagNewOrRemove"))
		{
			if (characterWalkOnAirComponent.OnSkillTagNewOrRemove == null)
			{
				this.OnSkillTagNewOrRemove = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.OnSkillTagNewOrRemove), "OnSkillTagNewOrRemove"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsActive"))
		{
			this.IsActive = characterWalkOnAirComponent.IsActive;
		}
		if (base.CanResetComponentProperty("IsWalkOnAir"))
		{
			this.IsWalkOnAir = characterWalkOnAirComponent.IsWalkOnAir;
		}
		if (base.CanResetComponentProperty("AirFloor"))
		{
			if (characterWalkOnAirComponent.AirFloor == null)
			{
				this.AirFloor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<AActor>>(this.AirFloor), "AirFloor"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BoxComp"))
		{
			if (characterWalkOnAirComponent.BoxComp == null)
			{
				this.BoxComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<UBoxComponent>>(this.BoxComp), "BoxComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ValidAirFloorIndex"))
		{
			this.ValidAirFloorIndex = characterWalkOnAirComponent.ValidAirFloorIndex;
		}
		if (base.CanResetComponentProperty("AirFloorPos") && characterWalkOnAirComponent.AirFloorPos != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.AirFloorPos), "AirFloorPos"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("AirFloorHeight"))
		{
			this.AirFloorHeight = characterWalkOnAirComponent.AirFloorHeight;
		}
		if (base.CanResetComponentProperty("BaseCharacter"))
		{
			if (characterWalkOnAirComponent.BaseCharacter == null)
			{
				this.BaseCharacter = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.BaseCharacter), "BaseCharacter"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StateComp"))
		{
			if (characterWalkOnAirComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.StateComp), "StateComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ChangeStateFrame"))
		{
			this.ChangeStateFrame = characterWalkOnAirComponent.ChangeStateFrame;
		}
		return true;
	}

	// Token: 0x0400CC82 RID: 52354
	private const int STRENGTH_THREADHOLD = 10;

	// Token: 0x0400CC83 RID: 52355
	private const int FRAME_INTERNAL = 2;

	// Token: 0x0400CC84 RID: 52356
	private const int BOX_LENGTH = 200;

	// Token: 0x0400CC85 RID: 52357
	private const int SWITCH_DISTANCE_SQUARE = 22500;

	// Token: 0x0400CC86 RID: 52358
	private static readonly FVectorDouble DefaultBoxExtent = new FVectorDouble(200.0, 200.0, 1.0);

	// Token: 0x0400CC87 RID: 52359
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CC88 RID: 52360
	private BaseTagComponent TagComp;

	// Token: 0x0400CC89 RID: 52361
	private ITagTask OnWalkOnAirTagNewOrRemove;

	// Token: 0x0400CC8A RID: 52362
	private ITagTask OnForegroundTagNewOrRemove;

	// Token: 0x0400CC8B RID: 52363
	private ITagTask OnSkillTagNewOrRemove;

	// Token: 0x0400CC8C RID: 52364
	private bool IsActive;

	// Token: 0x0400CC8D RID: 52365
	private bool IsWalkOnAir;

	// Token: 0x0400CC8E RID: 52366
	[Nullable(1)]
	private List<AActor> AirFloor = new List<AActor>();

	// Token: 0x0400CC8F RID: 52367
	[Nullable(1)]
	private List<UBoxComponent> BoxComp = new List<UBoxComponent>();

	// Token: 0x0400CC90 RID: 52368
	private int ValidAirFloorIndex;

	// Token: 0x0400CC91 RID: 52369
	[Nullable(1)]
	private readonly Vector AirFloorPos = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400CC92 RID: 52370
	private double AirFloorHeight;

	// Token: 0x0400CC93 RID: 52371
	private TsBaseCharacter BaseCharacter;

	// Token: 0x0400CC94 RID: 52372
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400CC95 RID: 52373
	private int ChangeStateFrame;
}
