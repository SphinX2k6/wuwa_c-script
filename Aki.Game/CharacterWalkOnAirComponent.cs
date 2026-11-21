using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using UnrealEngine;

// Token: 0x020025ED RID: 9709
[NullableContext(2)]
[Nullable(0)]
public class CharacterWalkOnAirComponent : EntityComponent
{
	// Token: 0x06018341 RID: 99137 RVA: 0x00748024 File Offset: 0x00746224
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

	// Token: 0x06018342 RID: 99138 RVA: 0x007480B0 File Offset: 0x007462B0
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

	// Token: 0x06018343 RID: 99139 RVA: 0x007481D5 File Offset: 0x007463D5
	private void OnDoSkill(int tagId, bool tagExists)
	{
		if (tagExists && this.IsWalkOnAir)
		{
			this.SetIsWalkOnAir(false);
		}
	}

	// Token: 0x06018344 RID: 99140 RVA: 0x007481EC File Offset: 0x007463EC
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

	// Token: 0x06018345 RID: 99141 RVA: 0x007482AE File Offset: 0x007464AE
	private void OnStateTagsChanged(int tagId, bool tagExists)
	{
		this.IsActive = tagExists;
		if (!this.IsActive)
		{
			this.SetIsWalkOnAir(false);
		}
	}

	// Token: 0x06018346 RID: 99142 RVA: 0x007482C6 File Offset: 0x007464C6
	private void OnForegroundTagsChanged(int tagId, bool tagExists)
	{
		if (!tagExists)
		{
			this.SetIsWalkOnAir(false);
		}
	}

	// Token: 0x06018347 RID: 99143 RVA: 0x007482D2 File Offset: 0x007464D2
	private void OnPositionStateChanged(ECharPositionState oldPositionState, ECharPositionState newPositionState)
	{
		if (newPositionState == ECharPositionState.Ground && this.IsWalkOnAir)
		{
			this.StateComp.SetPositionSubState(ECharPositionSubState.WalkOnAir, false);
		}
	}

	// Token: 0x06018348 RID: 99144 RVA: 0x007482EC File Offset: 0x007464EC
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

	// Token: 0x06018349 RID: 99145 RVA: 0x0074833A File Offset: 0x0074653A
	private void OnTeleportComplete(TeleportContext teleportContext)
	{
		if (!this.IsActive || !this.IsWalkOnAir)
		{
			return;
		}
		this.StateComp.SetPositionSubState(ECharPositionSubState.WalkOnAir, false);
	}

	// Token: 0x0601834A RID: 99146 RVA: 0x0074835C File Offset: 0x0074655C
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

	// Token: 0x0601834B RID: 99147 RVA: 0x00748450 File Offset: 0x00746650
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

	// Token: 0x0601834C RID: 99148 RVA: 0x00748544 File Offset: 0x00746744
	private void CreateAirFloor()
	{
		if (this.AirFloor.Count > 0)
		{
			return;
		}
		this.ValidAirFloorIndex = 0;
		this.CreateOneAirFloor(0);
		if (this.BoxComp.Count > 0)
		{
			UBoxComponent uboxComponent = this.BoxComp[0];
			if (uboxComponent != null)
			{
				uboxComponent.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
			}
		}
		this.CreateOneAirFloor(1);
		if (this.BoxComp.Count > 1)
		{
			UBoxComponent uboxComponent2 = this.BoxComp[1];
			if (uboxComponent2 == null)
			{
				return;
			}
			uboxComponent2.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		}
	}

	// Token: 0x0601834D RID: 99149 RVA: 0x007485C0 File Offset: 0x007467C0
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
			if (this.ValidAirFloorIndex >= 0 && this.ValidAirFloorIndex < this.BoxComp.Count)
			{
				UBoxComponent uboxComponent = this.BoxComp[this.ValidAirFloorIndex];
				if (uboxComponent != null)
				{
					uboxComponent.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
				}
			}
			this.StateComp.SetPositionSubState(ECharPositionSubState.WalkOnAir, false);
			return;
		}
		if (this.ValidAirFloorIndex >= 0 && this.ValidAirFloorIndex < this.BoxComp.Count)
		{
			UBoxComponent uboxComponent2 = this.BoxComp[this.ValidAirFloorIndex];
			if (uboxComponent2 != null)
			{
				uboxComponent2.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			}
		}
		this.StateComp.SetPositionSubState(ECharPositionSubState.None, false);
	}

	// Token: 0x0601834E RID: 99150 RVA: 0x00748680 File Offset: 0x00746880
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
		if (this.ValidAirFloorIndex >= 0 && this.ValidAirFloorIndex < this.AirFloor.Count)
		{
			AActor aactor = this.AirFloor[this.ValidAirFloorIndex];
			if (aactor == null)
			{
				return;
			}
			aactor.D_K2_SetActorLocationAndRotation(floorLocation.ToUeVector(false), this.ActorComp.ActorRotation, false, ref fhitResult, false);
		}
	}

	// Token: 0x0601834F RID: 99151 RVA: 0x00748760 File Offset: 0x00746960
	private void SwitchAirFloor()
	{
		if (this.ValidAirFloorIndex >= 0 && this.ValidAirFloorIndex < this.BoxComp.Count)
		{
			UBoxComponent uboxComponent = this.BoxComp[this.ValidAirFloorIndex];
			if (uboxComponent != null)
			{
				uboxComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			}
		}
		this.ValidAirFloorIndex ^= 1;
		if (this.ValidAirFloorIndex >= 0 && this.ValidAirFloorIndex < this.BoxComp.Count)
		{
			UBoxComponent uboxComponent2 = this.BoxComp[this.ValidAirFloorIndex];
			if (uboxComponent2 == null)
			{
				return;
			}
			uboxComponent2.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
		}
	}

	// Token: 0x06018350 RID: 99152 RVA: 0x007487EC File Offset: 0x007469EC
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

	// Token: 0x06018351 RID: 99153 RVA: 0x0074888A File Offset: 0x00746A8A
	protected override bool OnEnd()
	{
		this.UnregisterEvent();
		return true;
	}

	// Token: 0x06018352 RID: 99154 RVA: 0x00748894 File Offset: 0x00746A94
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

	// Token: 0x06018353 RID: 99155 RVA: 0x0074890C File Offset: 0x00746B0C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterWalkOnAirComponent characterWalkOnAirComponent = (CharacterWalkOnAirComponent)componentTemplate;
		if (characterWalkOnAirComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterWalkOnAirComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (characterWalkOnAirComponent.OnWalkOnAirTagNewOrRemove == null)
		{
			this.OnWalkOnAirTagNewOrRemove = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnWalkOnAirTagNewOrRemove), "OnWalkOnAirTagNewOrRemove"))
		{
			return false;
		}
		if (characterWalkOnAirComponent.OnForegroundTagNewOrRemove == null)
		{
			this.OnForegroundTagNewOrRemove = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnForegroundTagNewOrRemove), "OnForegroundTagNewOrRemove"))
		{
			return false;
		}
		if (characterWalkOnAirComponent.OnSkillTagNewOrRemove == null)
		{
			this.OnSkillTagNewOrRemove = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnSkillTagNewOrRemove), "OnSkillTagNewOrRemove"))
		{
			return false;
		}
		this.IsActive = characterWalkOnAirComponent.IsActive;
		this.IsWalkOnAir = characterWalkOnAirComponent.IsWalkOnAir;
		if (characterWalkOnAirComponent.AirFloor == null)
		{
			this.AirFloor = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AirFloor), "AirFloor"))
		{
			return false;
		}
		if (characterWalkOnAirComponent.BoxComp == null)
		{
			this.BoxComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BoxComp), "BoxComp"))
		{
			return false;
		}
		this.ValidAirFloorIndex = characterWalkOnAirComponent.ValidAirFloorIndex;
		if (characterWalkOnAirComponent.AirFloorPos != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.AirFloorPos), "AirFloorPos"))
		{
			return false;
		}
		this.AirFloorHeight = characterWalkOnAirComponent.AirFloorHeight;
		if (characterWalkOnAirComponent.BaseCharacter == null)
		{
			this.BaseCharacter = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BaseCharacter), "BaseCharacter"))
		{
			return false;
		}
		if (characterWalkOnAirComponent.StateComp == null)
		{
			this.StateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
		{
			return false;
		}
		this.ChangeStateFrame = characterWalkOnAirComponent.ChangeStateFrame;
		return true;
	}

	// Token: 0x170025F8 RID: 9720
	// (get) Token: 0x06018354 RID: 99156 RVA: 0x00748B0D File Offset: 0x00746D0D
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025F9 RID: 9721
	// (get) Token: 0x06018355 RID: 99157 RVA: 0x00748B10 File Offset: 0x00746D10
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025FA RID: 9722
	// (get) Token: 0x06018356 RID: 99158 RVA: 0x00748B13 File Offset: 0x00746D13
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025FB RID: 9723
	// (get) Token: 0x06018357 RID: 99159 RVA: 0x00748B16 File Offset: 0x00746D16
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D065 RID: 53349
	private const int STRENGTH_THREADHOLD = 10;

	// Token: 0x0400D066 RID: 53350
	private const int FRAME_INTERNAL = 2;

	// Token: 0x0400D067 RID: 53351
	private const int BOX_LENGTH = 200;

	// Token: 0x0400D068 RID: 53352
	private const int SWITCH_DISTANCE_SQUARE = 22500;

	// Token: 0x0400D069 RID: 53353
	private static readonly FVectorDouble DefaultBoxExtent = new FVectorDouble(200.0, 200.0, 1.0);

	// Token: 0x0400D06A RID: 53354
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D06B RID: 53355
	private BaseTagComponent TagComp;

	// Token: 0x0400D06C RID: 53356
	private ITagTask OnWalkOnAirTagNewOrRemove;

	// Token: 0x0400D06D RID: 53357
	private ITagTask OnForegroundTagNewOrRemove;

	// Token: 0x0400D06E RID: 53358
	private ITagTask OnSkillTagNewOrRemove;

	// Token: 0x0400D06F RID: 53359
	private bool IsActive;

	// Token: 0x0400D070 RID: 53360
	private bool IsWalkOnAir;

	// Token: 0x0400D071 RID: 53361
	[Nullable(1)]
	private List<AActor> AirFloor = new List<AActor>();

	// Token: 0x0400D072 RID: 53362
	[Nullable(1)]
	private List<UBoxComponent> BoxComp = new List<UBoxComponent>();

	// Token: 0x0400D073 RID: 53363
	private int ValidAirFloorIndex;

	// Token: 0x0400D074 RID: 53364
	[Nullable(1)]
	private readonly Vector AirFloorPos = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400D075 RID: 53365
	private double AirFloorHeight;

	// Token: 0x0400D076 RID: 53366
	private TsBaseCharacter BaseCharacter;

	// Token: 0x0400D077 RID: 53367
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400D078 RID: 53368
	private int ChangeStateFrame;
}
