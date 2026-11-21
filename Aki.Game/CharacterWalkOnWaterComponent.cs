using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Capability;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

// Token: 0x020025F1 RID: 9713
[NullableContext(1)]
[Nullable(0)]
public class CharacterWalkOnWaterComponent : EntityComponent
{
	// Token: 0x0601835C RID: 99164 RVA: 0x00748C3C File Offset: 0x00746E3C
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		this.TagComp = component;
		CharacterMoveComponent component2 = base.Entity.GetComponent<CharacterMoveComponent>();
		if (component2 == null || !component2.Valid)
		{
			return false;
		}
		this.WalkOnWaterStage = EWalkOnWaterStage.None;
		this.MoveComp = component2;
		this.StateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.FloatingComp = base.Entity.GetComponent<CharacterFloatingComponent>();
		this.CharacterHalfHeight = this.ActorComp.HalfHeight + 3f;
		this.CreateTempVector();
		this.RegisterEvent();
		this.InitTraceElements();
		this.OriginChannelResponse = new ECollisionResponse?(this.ActorComp.Actor.CapsuleComponent.GetCollisionResponseToChannel(KuroCollisionChannel.KuroWater));
		return true;
	}

	// Token: 0x0601835D RID: 99165 RVA: 0x00748D24 File Offset: 0x00746F24
	protected override bool OnEnd()
	{
		this.UnregisterEvent();
		this.ClearTempVector();
		foreach (WaterDetectedCapability waterDetectedCapability in this.GameCapabilities)
		{
			waterDetectedCapability.Deactivate();
		}
		this.GameCapabilities.Clear();
		return true;
	}

	// Token: 0x0601835E RID: 99166 RVA: 0x00748D8C File Offset: 0x00746F8C
	protected override void OnEnable()
	{
		this.PrePlayerLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
	}

	// Token: 0x0601835F RID: 99167 RVA: 0x00748DA4 File Offset: 0x00746FA4
	protected override void OnDisable(string reason)
	{
		this.SetWalkOnWaterStage(EWalkOnWaterStage.None);
	}

	// Token: 0x06018360 RID: 99168 RVA: 0x00748DB0 File Offset: 0x00746FB0
	private void RegisterEvent()
	{
		this.OnStateTagsChanged(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不会入水"], this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不会入水"]));
		this.OnGameplayTagNewOrRemove = this.TagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不会入水"]), new BaseTagComponent.TTagSwitchedCallback(this.OnStateTagsChanged), null);
		this.OnFreezeWaterTagChanged(this.freeWaterStateTag, this.TagComp.HasTag(this.freeWaterStateTag));
		this.OnFreezeWaterTagAddOrRemove = this.TagComp.ListenForTagAddOrRemove(new int?(this.freeWaterStateTag), new BaseTagComponent.TTagSwitchedCallback(this.OnFreezeWaterTagChanged), null);
		EventSystem.Instance.AddWithTarget<ECharMoveState, ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<ECharMoveState, ECharMoveState>(this.OnMoveStateChange));
		EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		EventSystem.Instance.AddWithTarget<float>(base.Entity, EEventName.CustomMoveWalkOnWater, new Action<float>(this.ReceiveWalkOnWaterEvent));
		EventSystem.Instance.AddWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChanged));
		EventSystem.Instance.AddWithTarget<Entity, float, float, bool>(base.Entity, EEventName.OnCharacterCapsuleChanged, new Action<Entity, float, float, bool>(this.OnCharacterCapsuleChanged));
		EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
	}

	// Token: 0x06018361 RID: 99169 RVA: 0x00748F28 File Offset: 0x00747128
	private void UnregisterEvent()
	{
		this.OnGameplayTagNewOrRemove.EndTask();
		EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		EventSystem.Instance.RemoveWithTarget<float>(base.Entity, EEventName.CustomMoveWalkOnWater, new Action<float>(this.ReceiveWalkOnWaterEvent));
		EventSystem.Instance.RemoveWithTarget<ECharMoveState, ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<ECharMoveState, ECharMoveState>(this.OnMoveStateChange));
		EventSystem.Instance.RemoveWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChanged));
		EventSystem.Instance.RemoveWithTarget<Entity, float, float, bool>(base.Entity, EEventName.OnCharacterCapsuleChanged, new Action<Entity, float, float, bool>(this.OnCharacterCapsuleChanged));
		EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
	}

	// Token: 0x06018362 RID: 99170 RVA: 0x00749004 File Offset: 0x00747204
	private void CreateTempVector()
	{
		this.TempVector = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempVector2 = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempStartPoint = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempEndPoint = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempNormalPoint = global::Vector.Create(0.0, 0.0, 0.0);
	}

	// Token: 0x06018363 RID: 99171 RVA: 0x007490CF File Offset: 0x007472CF
	private void ClearTempVector()
	{
		this.TempVector = null;
		this.TempVector2 = null;
		this.TempStartPoint = null;
		this.TempEndPoint = null;
		this.TempNormalPoint = null;
	}

	// Token: 0x170025FC RID: 9724
	// (get) Token: 0x06018364 RID: 99172 RVA: 0x007490F4 File Offset: 0x007472F4
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent),
				typeof(CharacterMoveComponent),
				typeof(BaseTagComponent)
			};
		}
	}

	// Token: 0x06018365 RID: 99173 RVA: 0x00749124 File Offset: 0x00747324
	private void InitTraceElements()
	{
		this.WaterTrace = new UTraceSphereElement();
		this.WaterTrace.WorldContextObject = this.ActorComp.Actor;
		this.WaterTrace.Radius = 3f;
		this.WaterTrace.bIgnoreSelf = true;
		this.WaterTrace.bIsSingle = true;
		this.WaterTrace.SetDrawDebugTrace(this.IsDebug ? EDrawDebugTrace.ForOneFrame : EDrawDebugTrace.None);
		this.WaterTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
		TraceElementCommon.Instance.SetTraceColor(this.WaterTrace, <CharacterWalkOnWaterComponent>FF096F69A2837D2CDA7523166AE83A46BA9B4E363B82D7E806D54E74C1F5B702F__CharacterSwimUtils.DebugColor3);
		TraceElementCommon.Instance.SetTraceHitColor(this.WaterTrace, <CharacterWalkOnWaterComponent>FF096F69A2837D2CDA7523166AE83A46BA9B4E363B82D7E806D54E74C1F5B702F__CharacterSwimUtils.DebugColor4);
		this.WaterEdgeTrace = new UTraceSphereElement();
		this.WaterEdgeTrace.WorldContextObject = this.ActorComp.Actor;
		this.WaterEdgeTrace.Radius = this.ActorComp.Radius + 20f;
		this.WaterEdgeTrace.bIgnoreSelf = true;
		this.WaterEdgeTrace.bIsSingle = true;
		this.WaterEdgeTrace.SetDrawDebugTrace(this.IsDebug ? EDrawDebugTrace.ForOneFrame : EDrawDebugTrace.None);
		this.WaterEdgeTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
		TraceElementCommon.Instance.SetTraceColor(this.WaterEdgeTrace, <CharacterWalkOnWaterComponent>FF096F69A2837D2CDA7523166AE83A46BA9B4E363B82D7E806D54E74C1F5B702F__CharacterSwimUtils.DebugColor1);
		TraceElementCommon.Instance.SetTraceHitColor(this.WaterEdgeTrace, <CharacterWalkOnWaterComponent>FF096F69A2837D2CDA7523166AE83A46BA9B4E363B82D7E806D54E74C1F5B702F__CharacterSwimUtils.DebugColor2);
		this.WaterUpTrace = new UTraceLineElement();
		this.WaterUpTrace.WorldContextObject = this.ActorComp.Actor;
		this.WaterUpTrace.bIgnoreSelf = true;
		this.WaterUpTrace.bIsSingle = true;
		this.WaterUpTrace.SetDrawDebugTrace(this.IsDebug ? EDrawDebugTrace.ForOneFrame : EDrawDebugTrace.None);
		this.WaterUpTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
		TraceElementCommon.Instance.SetTraceColor(this.WaterUpTrace, <CharacterWalkOnWaterComponent>FF096F69A2837D2CDA7523166AE83A46BA9B4E363B82D7E806D54E74C1F5B702F__CharacterSwimUtils.DebugColor3);
		TraceElementCommon.Instance.SetTraceHitColor(this.WaterUpTrace, <CharacterWalkOnWaterComponent>FF096F69A2837D2CDA7523166AE83A46BA9B4E363B82D7E806D54E74C1F5B702F__CharacterSwimUtils.DebugColor4);
		this.GroundTrace = new UTraceSphereElement();
		this.GroundTrace.WorldContextObject = this.ActorComp.Actor;
		this.GroundTrace.Radius = 3f;
		this.GroundTrace.bIgnoreSelf = true;
		this.GroundTrace.bIsSingle = false;
		this.GroundTrace.SetDrawDebugTrace(this.IsDebug ? EDrawDebugTrace.ForOneFrame : EDrawDebugTrace.None);
		this.GroundTrace.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		TraceElementCommon.Instance.SetTraceColor(this.GroundTrace, <CharacterWalkOnWaterComponent>FF096F69A2837D2CDA7523166AE83A46BA9B4E363B82D7E806D54E74C1F5B702F__CharacterSwimUtils.DebugColor1);
		TraceElementCommon.Instance.SetTraceHitColor(this.GroundTrace, <CharacterWalkOnWaterComponent>FF096F69A2837D2CDA7523166AE83A46BA9B4E363B82D7E806D54E74C1F5B702F__CharacterSwimUtils.DebugColor2);
	}

	// Token: 0x06018366 RID: 99174 RVA: 0x00749398 File Offset: 0x00747598
	private void AddFreezeWaterCapabilities()
	{
		if (this.GameCapabilities.Count > 0)
		{
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		bool flag;
		if (actorComp == null)
		{
			flag = true;
		}
		else
		{
			AActor owner = actorComp.Owner;
			flag = !((owner != null) ? new bool?(owner.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return;
		}
		string text = ConfigCommonParamById.GetStringConfig("FeixueTrailCollisionAsset") ?? string.Empty;
		UKuroTrailCollisionAsset ukuroTrailCollisionAsset = ResourceSystem.Instance.Load<UKuroTrailCollisionAsset>(text, "js_undefined");
		if (ukuroTrailCollisionAsset == null || !ukuroTrailCollisionAsset.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "CharacterWalkOnWaterComponent: kuroTrailCollisionAsset is invalid";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", text);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.FreezeWaterRenderCapability = new FreezeWaterRenderCapability(this.ActorComp.Owner, ukuroTrailCollisionAsset);
		this.GameCapabilities.Add(this.FreezeWaterRenderCapability);
		foreach (WaterDetectedCapability waterDetectedCapability in this.GameCapabilities)
		{
			waterDetectedCapability.Activate();
		}
	}

	// Token: 0x06018367 RID: 99175 RVA: 0x007494B8 File Offset: 0x007476B8
	private float GetMaxSpeed(ECharMoveState state)
	{
		switch (state)
		{
		case ECharMoveState.Walk:
			return this.MoveComp.WalkSpeed;
		case ECharMoveState.Run:
			return this.MoveComp.RunSpeed;
		case ECharMoveState.Sprint:
			return this.MoveComp.SprintSpeed;
		}
		return 0f;
	}

	// Token: 0x06018368 RID: 99176 RVA: 0x0074950C File Offset: 0x0074770C
	private void OnMoveStateChange(ECharMoveState oldMoveState, ECharMoveState newMoveState)
	{
		if (this.WalkOnWaterStage == EWalkOnWaterStage.UpToWaterSurface && this.GetMaxSpeed(newMoveState) > 0f)
		{
			this.MoveComp.CharacterMovement.MaxCustomMovementSpeed = this.GetMaxSpeed(newMoveState);
		}
	}

	// Token: 0x06018369 RID: 99177 RVA: 0x0074953C File Offset: 0x0074773C
	private void ReceiveWalkOnWaterEvent(float deltaTime)
	{
		this.MoveComp.CharacterMovement.KuroFlying(deltaTime, 0f, 0f, 0f, this.MoveComp.CurrentMovementSettings.Acceleration, this.GetMaxSpeed(this.StateComp.MoveState), 1f);
	}

	// Token: 0x0601836A RID: 99178 RVA: 0x00749590 File Offset: 0x00747790
	private void OnStateInherit(Entity other, bool notInheritMoveAndAnim)
	{
		if (other == null || !other.Valid)
		{
			return;
		}
		this.IsActive = this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不会入水"]);
		if (!this.IsActive)
		{
			this.SetWalkOnWaterStage(EWalkOnWaterStage.None);
		}
	}

	// Token: 0x0601836B RID: 99179 RVA: 0x007495DE File Offset: 0x007477DE
	private void OnFreezeWaterTagChanged(int tagId, bool tagExists)
	{
		if (tagExists)
		{
			this.AddFreezeWaterCapabilities();
			return;
		}
		this.BroadcastWaterDetectedEnd();
	}

	// Token: 0x0601836C RID: 99180 RVA: 0x007495F0 File Offset: 0x007477F0
	private void OnStateTagsChanged(int tagId, bool tagExists)
	{
		if (tagExists)
		{
			if (this.DisableKey != 0)
			{
				base.Enable(new int?(this.DisableKey), "不会入水Tag");
				this.DisableKey = 0;
			}
		}
		else if (this.DisableKey == 0)
		{
			this.DisableKey = base.Disable("不会入水Tag");
		}
		this.IsActive = tagExists;
		if (!tagExists)
		{
			this.SetWalkOnWaterStage(EWalkOnWaterStage.None);
		}
	}

	// Token: 0x0601836D RID: 99181 RVA: 0x00749654 File Offset: 0x00747854
	private void OnPositionStateChanged(ECharPositionState oldPositionState, ECharPositionState newPositionState)
	{
		if (!this.IsActive)
		{
			return;
		}
		if (newPositionState == ECharPositionState.Ground)
		{
			if (this.CheckEnterWater() || this.CheckWaterEdge() || this.CheckUpWaterSurface())
			{
				this.StateComp.SetPositionSubState(ECharPositionSubState.WaterSurface, false);
				return;
			}
			this.StateComp.SetPositionSubState(ECharPositionSubState.None, false);
		}
	}

	// Token: 0x0601836E RID: 99182 RVA: 0x007496A0 File Offset: 0x007478A0
	private void OnCharacterCapsuleChanged(Entity entity, float radius, float halfHeight, bool bUpdateOverlaps)
	{
		this.CharacterHalfHeight = halfHeight + 3f;
	}

	// Token: 0x0601836F RID: 99183 RVA: 0x007496B0 File Offset: 0x007478B0
	[NullableContext(2)]
	private void OnTeleportComplete(TeleportContext teleportContext)
	{
		if (!this.IsActive)
		{
			return;
		}
		CharacterUnifiedStateComponent stateComp = this.StateComp;
		if (stateComp != null && stateComp.PositionState == ECharPositionState.Ground && (this.CheckEnterWater() || this.CheckWaterEdge() || this.CheckUpWaterSurface()))
		{
			this.StateComp.SetPositionSubState(ECharPositionSubState.WaterSurface, false);
		}
	}

	// Token: 0x06018370 RID: 99184 RVA: 0x00749702 File Offset: 0x00747902
	public bool BlockMoveModeInherit(UCharacterMovementComponent otherCharacterMovement)
	{
		return !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不会入水"]) && otherCharacterMovement.MovementMode == EMovementMode.MOVE_Custom && otherCharacterMovement.CustomMovementMode == 5;
	}

	// Token: 0x06018371 RID: 99185 RVA: 0x0074973F File Offset: 0x0074793F
	private bool IsNormalAccepted(global::Vector normal)
	{
		return Math.Abs(MathUtils.Instance.DotProduct(normal, this.ActorComp.ActorUpProxy)) > 0.17299999296665192;
	}

	// Token: 0x06018372 RID: 99186 RVA: 0x00749768 File Offset: 0x00747968
	private bool CheckUpWaterSurface()
	{
		global::Vector tempStartPoint = this.TempStartPoint;
		this.ActorComp.ActorUpProxy.Multiply(1000.0, tempStartPoint);
		this.ActorComp.ActorLocationProxy.Addition(tempStartPoint, tempStartPoint);
		global::Vector tempEndPoint = this.TempEndPoint;
		this.ActorComp.ActorUpProxy.Multiply((double)(-(double)this.CharacterHalfHeight), tempEndPoint);
		this.ActorComp.ActorLocationProxy.Subtraction(tempEndPoint, tempEndPoint);
		bool flag = this.CheckIntoWater(tempStartPoint, tempEndPoint);
		if (flag)
		{
			TraceElementCommon.Instance.SetStartLocation(this.WaterUpTrace, tempEndPoint);
			TraceElementCommon.Instance.SetEndLocation(this.WaterUpTrace, tempStartPoint);
			global::Vector tempVector = this.TempVector;
			if (TraceElementCommon.Instance.LineTrace(this.WaterUpTrace, "CharacterWalkOnWaterComponent_WaterUpBlock") && this.WaterUpTrace.HitResult.bBlockingHit)
			{
				TraceElementCommon.Instance.GetHitLocation(this.WaterUpTrace.HitResult, 0, tempVector);
				this.WaterHeight = (float)GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, tempVector);
				TraceElementCommon.Instance.GetImpactNormal(this.WaterTrace.HitResult, 0, this.WaterNormal);
				TraceElementCommon.Instance.GetImpactPoint(this.WaterTrace.HitResult, 0, this.WaterImpactPoint);
				if ((double)this.WaterHeight - GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.FloorLocation) < (double)this.Depth)
				{
					return false;
				}
			}
		}
		return flag;
	}

	// Token: 0x06018373 RID: 99187 RVA: 0x007498DC File Offset: 0x00747ADC
	private bool CheckEnterWater()
	{
		global::Vector tempStartPoint = this.TempStartPoint;
		global::Vector tempEndPoint = this.TempEndPoint;
		if (this.WalkOnWaterStage == EWalkOnWaterStage.None)
		{
			global::Vector tempVector = this.TempVector2;
			this.ActorComp.ActorLocationProxy.Subtraction(this.PrePlayerLocation, tempVector);
			if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, tempVector) < 0.0 && global::Vector.DistSquared(this.PrePlayerLocation, this.ActorComp.ActorLocationProxy) < 1000000.0)
			{
				global::Vector tempVector2 = this.TempVector;
				this.ActorComp.ActorUpProxy.Multiply((double)(this.CharacterHalfHeight - 3f), tempVector2);
				global::Vector tempVector3 = this.TempVector2;
				this.ActorComp.ActorLocationProxy.Subtraction(this.PrePlayerLocation, tempVector3);
				tempVector3.Normalize(9.99999993922529E-09);
				tempVector3.Multiply(3.0, tempVector3);
				this.PrePlayerLocation.Addition(tempVector2, tempStartPoint);
				tempStartPoint.SubtractionEqual(tempVector3);
				this.ActorComp.ActorLocationProxy.Subtraction(tempVector2, tempEndPoint);
				tempEndPoint.AdditionEqual(tempVector3);
				return this.CheckIntoWater(tempStartPoint, tempEndPoint);
			}
		}
		global::Vector tempVector4 = this.TempVector;
		this.ActorComp.ActorUpProxy.Multiply((double)this.CharacterHalfHeight, tempVector4);
		this.ActorComp.ActorLocationProxy.Addition(tempVector4, tempStartPoint);
		this.ActorComp.ActorLocationProxy.Subtraction(tempVector4, tempEndPoint);
		return this.CheckIntoWater(tempStartPoint, tempEndPoint);
	}

	// Token: 0x06018374 RID: 99188 RVA: 0x00749A60 File Offset: 0x00747C60
	private bool CheckWaterEdge()
	{
		global::Vector tempVector = this.TempVector;
		this.ActorComp.ActorUpProxy.Multiply((double)this.CharacterHalfHeight, tempVector);
		global::Vector tempStartPoint = this.TempStartPoint;
		this.ActorComp.ActorLocationProxy.Addition(tempVector, tempStartPoint);
		global::Vector tempEndPoint = this.TempEndPoint;
		this.ActorComp.ActorLocationProxy.Subtraction(tempVector, tempEndPoint);
		return this.SimpleWaterEdgeTrace(tempStartPoint, tempEndPoint);
	}

	// Token: 0x06018375 RID: 99189 RVA: 0x00749ACC File Offset: 0x00747CCC
	private bool CheckIntoWater(global::Vector start, global::Vector end)
	{
		this.Depth = this.DetectWaterDepth(start, end);
		if (this.Depth == 0f)
		{
			return false;
		}
		TraceElementCommon.Instance.GetImpactNormal(this.WaterTrace.HitResult, 0, this.TempNormalPoint);
		return this.IsNormalAccepted(this.TempNormalPoint);
	}

	// Token: 0x06018376 RID: 99190 RVA: 0x00749B24 File Offset: 0x00747D24
	private float DetectWaterDepth(global::Vector start, global::Vector end)
	{
		bool flag = this.SimpleWaterTrace(start, end);
		global::Vector tempVector = this.TempVector;
		if (flag && this.WaterTrace.HitResult.bBlockingHit)
		{
			TraceElementCommon.Instance.GetHitLocation(this.WaterTrace.HitResult, 0, tempVector);
			this.WaterHeight = (float)GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, tempVector);
			double num = (double)this.WaterHeight - GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.FloorLocation);
			if (num > 0.0)
			{
				return (float)num;
			}
		}
		return 0f;
	}

	// Token: 0x06018377 RID: 99191 RVA: 0x00749BBC File Offset: 0x00747DBC
	private void FixedEnterWaterDepth(float deltaTime)
	{
		if (this.Depth < 4f)
		{
			return;
		}
		this.UpTime += (double)deltaTime * TimeUtil.Instance.Millisecond;
		global::Vector tempVector = this.TempVector;
		tempVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorLocationProxy);
		double num = MathUtils.Instance.Clamp((double)this.StartUpZ + this.UpTime * 500.0, (double)this.StartUpZ, znInGravityForActor + (double)this.Depth - 1.0);
		tempVector.AdditionEqual(this.ActorComp.ActorUpProxy.Multiply(num - znInGravityForActor, this.TempVector2));
		this.ActorComp.SetActorLocation(tempVector.ToUeVector(false), "修正在水中的Z轴", true);
	}

	// Token: 0x06018378 RID: 99192 RVA: 0x00749C9C File Offset: 0x00747E9C
	private void EnterUpToWalkOnWater()
	{
		this.TempVector.DeepCopy(this.ActorComp.ActorVelocityProxy);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TempVector);
		this.ActorComp.SetActorVelocity(this.TempVector);
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Custom,
				CustomMode = 5,
				Context = "[CharacterWalkOnWaterComponent.EnterUpToWalkOnWater]"
			});
		}
		this.UpTime = 0.0;
		this.StartUpZ = (float)GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorLocationProxy);
		this.OriginMaxSpeed = this.MoveComp.CharacterMovement.MaxCustomMovementSpeed;
	}

	// Token: 0x06018379 RID: 99193 RVA: 0x00749D62 File Offset: 0x00747F62
	private void ExitUpToWalkOnWater()
	{
		this.MoveComp.CharacterMovement.MaxCustomMovementSpeed = this.OriginMaxSpeed;
	}

	// Token: 0x0601837A RID: 99194 RVA: 0x00749D7C File Offset: 0x00747F7C
	private void EnterWalkOnWater()
	{
		this.TempVector.DeepCopy(this.ActorComp.ActorVelocityProxy);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TempVector);
		this.ActorComp.SetActorVelocity(this.TempVector);
		this.EnableOrDisableWalkOnWater(true, "CharWalkOnWaterComp", false);
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null)
		{
			return;
		}
		actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Walking,
			Context = "[CharacterWalkOnWaterComponent.EnterWalkOnWater]"
		});
	}

	// Token: 0x0601837B RID: 99195 RVA: 0x00749E00 File Offset: 0x00748000
	private void ExitWalkOnWater(bool isBuffEnd = false)
	{
		if (isBuffEnd && this.CheckUpWaterSurface())
		{
			this.FixedEnterWaterDepth((float)TimeUtil.Instance.InverseMillisecond);
		}
		this.EnableOrDisableWalkOnWater(false, "CharWalkOnWaterComp", false);
	}

	// Token: 0x0601837C RID: 99196 RVA: 0x00749E2C File Offset: 0x0074802C
	private bool SimpleWaterTrace(global::Vector start, global::Vector end)
	{
		TraceElementCommon.Instance.SetStartLocation(this.WaterTrace, start);
		TraceElementCommon.Instance.SetEndLocation(this.WaterTrace, end);
		if (TraceElementCommon.Instance.SphereTrace(this.WaterTrace, "CharacterWalkOnWaterComponent_DetectWaterDepth") && this.WaterTrace.HitResult.bBlockingHit)
		{
			TWeakObjectPtr<UPrimitiveComponent> weak = this.WaterTrace.HitResult.Components.Get(0);
			int instanceIndex = this.WaterTrace.HitResult.ItemArray.Get(0);
			UKuroCollisionLibrary.GetCollisionResponseToChannel(weak, this.ActorComp.Actor.CapsuleComponent.GetCollisionObjectType(), instanceIndex);
			return true;
		}
		return false;
	}

	// Token: 0x0601837D RID: 99197 RVA: 0x00749EDC File Offset: 0x007480DC
	private bool SimpleWaterEdgeTrace(global::Vector start, global::Vector end)
	{
		TraceElementCommon.Instance.SetStartLocation(this.WaterEdgeTrace, start);
		TraceElementCommon.Instance.SetEndLocation(this.WaterEdgeTrace, end);
		return TraceElementCommon.Instance.SphereTrace(this.WaterEdgeTrace, "CharacterWalkOnWaterComponent_DetectWaterDepth") && this.WaterEdgeTrace.HitResult.bBlockingHit;
	}

	// Token: 0x0601837E RID: 99198 RVA: 0x00749F34 File Offset: 0x00748134
	private void SetWalkOnWaterStage(EWalkOnWaterStage stage)
	{
		if (this.InChangeStateProcess)
		{
			this.CacheWalkOnWaterStage = new EWalkOnWaterStage?(stage);
			return;
		}
		if (this.WalkOnWaterStage == stage)
		{
			return;
		}
		this.InChangeStateProcess = true;
		this.ExitStage(this.WalkOnWaterStage);
		this.EnterStage(stage);
		this.InChangeStateProcess = false;
		if (this.CacheWalkOnWaterStage != null)
		{
			EWalkOnWaterStage? cacheWalkOnWaterStage = this.CacheWalkOnWaterStage;
			EWalkOnWaterStage walkOnWaterStage = this.WalkOnWaterStage;
			if (!(cacheWalkOnWaterStage.GetValueOrDefault() == walkOnWaterStage & cacheWalkOnWaterStage != null))
			{
				this.ExitStage(stage);
				this.EnterStage(this.CacheWalkOnWaterStage.Value);
				this.CacheWalkOnWaterStage = null;
			}
		}
	}

	// Token: 0x0601837F RID: 99199 RVA: 0x00749FD4 File Offset: 0x007481D4
	private void EnterStage(EWalkOnWaterStage newStage)
	{
		this.WalkOnWaterStage = newStage;
		switch (newStage)
		{
		case EWalkOnWaterStage.None:
		{
			this.SetWaterDepthType(EWaterDepthType.None);
			CharacterFloatingComponent floatingComp = this.FloatingComp;
			if (floatingComp != null && floatingComp.IsFloating)
			{
				this.FloatingComp.ExternalEnterFloatingState();
				return;
			}
			if (this.MoveComp.CharacterMovement.MovementMode != EMovementMode.MOVE_Flying && (!(this.MoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Custom) || this.MoveComp.CharacterMovement.CustomMovementMode != 6))
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp == null || !actorComp.Actor.OnMovementModeChanged)
				{
					CharacterActorComponent actorComp2 = this.ActorComp;
					if (actorComp2 == null)
					{
						return;
					}
					actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Falling,
						Context = "[CharacterWalkOnWaterComponent.EnterStage]"
					});
				}
			}
			return;
		}
		case EWalkOnWaterStage.UpToWaterSurface:
			this.EnterUpToWalkOnWater();
			return;
		case EWalkOnWaterStage.WalkOnWaterSurface:
			this.EnterWalkOnWater();
			return;
		default:
			return;
		}
	}

	// Token: 0x06018380 RID: 99200 RVA: 0x0074A0C5 File Offset: 0x007482C5
	private void ExitStage(EWalkOnWaterStage oldStage)
	{
		switch (oldStage)
		{
		case EWalkOnWaterStage.None:
			this.StateComp.SetPositionSubState(ECharPositionSubState.WaterSurface, false);
			return;
		case EWalkOnWaterStage.UpToWaterSurface:
			this.ExitUpToWalkOnWater();
			return;
		case EWalkOnWaterStage.WalkOnWaterSurface:
			this.ExitWalkOnWater(!this.IsActive);
			return;
		default:
			return;
		}
	}

	// Token: 0x06018381 RID: 99201 RVA: 0x0074A100 File Offset: 0x00748300
	private void TickWalkOnWaterStage(float deltaTime)
	{
		switch (this.WalkOnWaterStage)
		{
		case EWalkOnWaterStage.None:
		case EWalkOnWaterStage.WalkOnWaterSurface:
			break;
		case EWalkOnWaterStage.UpToWaterSurface:
			this.FixedEnterWaterDepth(deltaTime);
			break;
		default:
			return;
		}
	}

	// Token: 0x06018382 RID: 99202 RVA: 0x0074A130 File Offset: 0x00748330
	protected override void OnTick(float deltaTime)
	{
		EWalkOnWaterStage walkOnWaterStage = EWalkOnWaterStage.None;
		if (this.CheckEnterWater())
		{
			if (this.Depth < 4f)
			{
				walkOnWaterStage = EWalkOnWaterStage.WalkOnWaterSurface;
			}
			else
			{
				walkOnWaterStage = EWalkOnWaterStage.UpToWaterSurface;
			}
		}
		else if (this.CheckUpWaterSurface())
		{
			walkOnWaterStage = EWalkOnWaterStage.UpToWaterSurface;
		}
		else if (this.WalkOnWaterStage != EWalkOnWaterStage.None)
		{
			if (!this.CheckWaterEdge())
			{
				walkOnWaterStage = EWalkOnWaterStage.None;
			}
			else
			{
				walkOnWaterStage = EWalkOnWaterStage.WalkOnWaterSurface;
			}
		}
		this.SetWalkOnWaterStage(walkOnWaterStage);
		this.TickWalkOnWaterStage(deltaTime);
		if (this.WalkOnWaterStage == EWalkOnWaterStage.None)
		{
			this.CheckInGroundTime -= deltaTime;
			if (this.CheckInGroundTime < 0f)
			{
				this.CheckInGroundTime = 1000f;
				CharacterUnifiedStateComponent stateComp = this.StateComp;
				if (stateComp != null && stateComp.PositionState == ECharPositionState.Ground)
				{
					CharacterUnifiedStateComponent stateComp2 = this.StateComp;
					if (stateComp2 != null && stateComp2.PositionSubState == ECharPositionSubState.WaterSurface)
					{
						this.StateComp.SetPositionSubState(ECharPositionSubState.None, false);
					}
				}
			}
		}
		else
		{
			this.CheckWaterDepthType(deltaTime);
		}
		this.PrePlayerLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
	}

	// Token: 0x06018383 RID: 99203 RVA: 0x0074A214 File Offset: 0x00748414
	private void CheckWaterDepthType(float deltaTime)
	{
		global::Vector tempStartPoint = this.TempStartPoint;
		tempStartPoint.DeepCopy(this.ActorComp.ActorLocationProxy);
		if ((double)this.WaterHeight > GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, tempStartPoint) - (double)this.ActorComp.HalfHeight)
		{
			double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorLocationProxy);
			tempStartPoint.AdditionEqual(this.ActorComp.ActorUpProxy.Multiply((double)this.WaterHeight - znInGravityForActor, this.TempVector2));
		}
		else
		{
			tempStartPoint.AdditionEqual(this.ActorComp.ActorUpProxy.Multiply((double)(-(double)this.ActorComp.HalfHeight), this.TempVector2));
		}
		global::Vector tempEndPoint = this.TempEndPoint;
		global::Vector tempVector = this.TempVector;
		this.ActorComp.ActorUpProxy.Multiply((double)(this.CharacterHalfHeight * 1.5f), tempVector);
		tempStartPoint.Subtraction(tempVector, tempEndPoint);
		TraceElementCommon.Instance.SetStartLocation(this.GroundTrace, tempStartPoint);
		TraceElementCommon.Instance.SetEndLocation(this.GroundTrace, tempEndPoint);
		bool flag = TraceElementCommon.Instance.SphereTrace(this.GroundTrace, "CharacterWalkOnWaterComponent_DetectWaterDepth");
		global::Vector tempVector2 = this.TempVector2;
		if (!flag || !this.GroundTrace.HitResult.bBlockingHit)
		{
			this.CheckWaterNormal(deltaTime);
			this.SetWaterDepthType(EWaterDepthType.Deep);
			return;
		}
		int hitCount = this.GroundTrace.HitResult.GetHitCount();
		bool flag2 = false;
		float num = float.NegativeInfinity;
		TArray<TWeakObjectPtr<AActor>> actors = this.GroundTrace.HitResult.Actors;
		TArray<TWeakObjectPtr<UPrimitiveComponent>> components = this.GroundTrace.HitResult.Components;
		for (int i = 0; i < hitCount; i++)
		{
			TWeakObjectPtr<AActor> tweakObjectPtr = actors.Get(i);
			TWeakObjectPtr<UPrimitiveComponent> tweakObjectPtr2 = components.Get(i);
			if (tweakObjectPtr.Get() != null)
			{
				if (tweakObjectPtr.Get().bHidden)
				{
					UPrimitiveComponent uprimitiveComponent = tweakObjectPtr2.Get();
					if (uprimitiveComponent == null || !uprimitiveComponent.bCanCharacterStandOn)
					{
						goto IL_204;
					}
				}
				flag2 = true;
				TraceElementCommon.Instance.GetHitLocation(this.GroundTrace.HitResult, i, tempVector2);
				double znInGravityForActor2 = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, tempVector2);
				if (znInGravityForActor2 > (double)num)
				{
					num = (float)znInGravityForActor2;
				}
			}
			IL_204:;
		}
		if (!flag2)
		{
			this.CheckWaterNormal(deltaTime);
			this.SetWaterDepthType(EWaterDepthType.Deep);
			return;
		}
		if (num <= this.WaterHeight)
		{
			this.CheckWaterNormal(deltaTime);
			this.SetWaterDepthType(EWaterDepthType.Shallow);
			return;
		}
		this.BroadcastWaterDetectedEnd();
		this.SetWaterDepthType(EWaterDepthType.None);
	}

	// Token: 0x06018384 RID: 99204 RVA: 0x0074A480 File Offset: 0x00748680
	private void ChangeWaterDepthTypeTag(EWaterDepthType type, bool isAdd)
	{
		int? tagId = null;
		if (type == EWaterDepthType.Shallow)
		{
			tagId = new int?(GameplayTagUtils.GetTagIdByName("行为状态.水域状态.浅水区"));
		}
		else if (type == EWaterDepthType.Deep)
		{
			tagId = new int?(GameplayTagUtils.GetTagIdByName("行为状态.水域状态.深水区"));
		}
		if (tagId == null)
		{
			return;
		}
		if (isAdd)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp == null)
			{
				return;
			}
			tagComp.AddTag(tagId);
			return;
		}
		else
		{
			BaseTagComponent tagComp2 = this.TagComp;
			if (tagComp2 == null)
			{
				return;
			}
			tagComp2.RemoveTag(tagId);
			return;
		}
	}

	// Token: 0x06018385 RID: 99205 RVA: 0x0074A4F4 File Offset: 0x007486F4
	private void BroadcastWaterDetectedStart()
	{
		if (this.WaterDetected)
		{
			return;
		}
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp == null || !tagComp.HasTag(this.freeWaterStateTag))
		{
			return;
		}
		foreach (WaterDetectedCapability waterDetectedCapability in this.GameCapabilities)
		{
			waterDetectedCapability.OnWaterDetectedStart();
		}
		this.WaterDetected = true;
	}

	// Token: 0x06018386 RID: 99206 RVA: 0x0074A574 File Offset: 0x00748774
	private void BroadcastWaterDetectedEnd()
	{
		if (!this.WaterDetected)
		{
			return;
		}
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp == null || !tagComp.HasTag(this.freeWaterStateTag))
		{
			return;
		}
		foreach (WaterDetectedCapability waterDetectedCapability in this.GameCapabilities)
		{
			waterDetectedCapability.OnWaterDetectedEnd();
		}
		this.WaterDetected = false;
	}

	// Token: 0x06018387 RID: 99207 RVA: 0x0074A5F4 File Offset: 0x007487F4
	private void BroadcastWaterDetectedTick(float deltaTime, global::Vector hitWaterPoint)
	{
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp == null || !tagComp.HasTag(this.freeWaterStateTag) || this.ActorComp == null)
		{
			return;
		}
		foreach (WaterDetectedCapability waterDetectedCapability in this.GameCapabilities)
		{
			waterDetectedCapability.OnWaterDetectedTick(deltaTime, hitWaterPoint, this.ActorComp.ActorUpProxy);
		}
	}

	// Token: 0x06018388 RID: 99208 RVA: 0x0074A678 File Offset: 0x00748878
	private bool CheckWaterNormal(float deltaTime)
	{
		if (!this.ActorComp)
		{
			this.BroadcastWaterDetectedEnd();
			return false;
		}
		global::Vector gravityDirectForActor = GravityUtils.Instance.GetGravityDirectForActor(this.ActorComp);
		if (!this.WaterNormal.Normalize(9.99999993922529E-09) || !global::Vector.Parallel(this.WaterNormal, gravityDirectForActor, 0.999845027923584))
		{
			this.BroadcastWaterDetectedEnd();
			return false;
		}
		this.BroadcastWaterDetectedStart();
		this.BroadcastWaterDetectedTick(deltaTime, this.WaterImpactPoint);
		return true;
	}

	// Token: 0x06018389 RID: 99209 RVA: 0x0074A6F4 File Offset: 0x007488F4
	private void SetWaterDepthType(EWaterDepthType newType)
	{
		if (this.WaterDepthType == newType)
		{
			return;
		}
		this.ChangeWaterDepthTypeTag(this.WaterDepthType, false);
		this.WaterDepthType = newType;
		this.ChangeWaterDepthTypeTag(newType, true);
	}

	// Token: 0x0601838A RID: 99210 RVA: 0x0074A71C File Offset: 0x0074891C
	public void EnableOrDisableWalkOnWater(bool enable, string key, bool fixLocation = false)
	{
		if (enable)
		{
			if (!this.WalkOnWaterSet.Contains(key))
			{
				if (this.WalkOnWaterSet.Count == 0)
				{
					UCapsuleComponent capsuleComponent = this.ActorComp.Actor.CapsuleComponent;
					if (capsuleComponent != null)
					{
						capsuleComponent.SetCollisionResponseToChannel(KuroCollisionChannel.KuroWater, ECollisionResponse.ECR_Block);
					}
					if (fixLocation)
					{
						ValueTuple<bool, global::Vector> valueTuple = this.ActorComp.FixActorLocation(0f, true, this.ActorComp.ActorLocationProxy, "WalkOnWater", true, false);
						bool item = valueTuple.Item1;
						global::Vector item2 = valueTuple.Item2;
						if (item)
						{
							CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
							if (component != null)
							{
								component.SetLocationAndRotatorWithModelBuffer(item2.ToUeVector(false), this.ActorComp.ActorRotation, 300f, "WalkOnWater.FixLocation", ESetRotationPriority.Anim, false);
							}
							else
							{
								this.ActorComp.SetActorLocation(item2.ToUeVector(false), "WalkOnWater.FixLocation", false);
							}
						}
					}
				}
				this.WalkOnWaterSet.Add(key);
				return;
			}
		}
		else
		{
			this.WalkOnWaterSet.Remove(key);
			if (this.WalkOnWaterSet.Count == 0)
			{
				this.ActorComp.Actor.CapsuleComponent.SetCollisionResponseToChannel(KuroCollisionChannel.KuroWater, this.OriginChannelResponse.GetValueOrDefault(ECollisionResponse.ECR_Overlap));
			}
		}
	}

	// Token: 0x0601838B RID: 99211 RVA: 0x0074A848 File Offset: 0x00748A48
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterWalkOnWaterComponent characterWalkOnWaterComponent = (CharacterWalkOnWaterComponent)componentTemplate;
		this.freeWaterStateTag = characterWalkOnWaterComponent.freeWaterStateTag;
		this.IsDebug = characterWalkOnWaterComponent.IsDebug;
		if (characterWalkOnWaterComponent.WaterUpTrace == null)
		{
			this.WaterUpTrace = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaterUpTrace), "WaterUpTrace"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.GroundTrace == null)
		{
			this.GroundTrace = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GroundTrace), "GroundTrace"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.WaterTrace == null)
		{
			this.WaterTrace = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaterTrace), "WaterTrace"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.WaterEdgeTrace == null)
		{
			this.WaterEdgeTrace = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaterEdgeTrace), "WaterEdgeTrace"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.StateComp == null)
		{
			this.StateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.FloatingComp == null)
		{
			this.FloatingComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FloatingComp), "FloatingComp"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.OnGameplayTagNewOrRemove == null)
		{
			this.OnGameplayTagNewOrRemove = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnGameplayTagNewOrRemove), "OnGameplayTagNewOrRemove"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.OnFreezeWaterTagAddOrRemove == null)
		{
			this.OnFreezeWaterTagAddOrRemove = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnFreezeWaterTagAddOrRemove), "OnFreezeWaterTagAddOrRemove"))
		{
			return false;
		}
		this.IsActive = characterWalkOnWaterComponent.IsActive;
		this.CharacterHalfHeight = characterWalkOnWaterComponent.CharacterHalfHeight;
		if (characterWalkOnWaterComponent.TempVector == null)
		{
			this.TempVector = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.TempVector2 == null)
		{
			this.TempVector2 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.TempStartPoint == null)
		{
			this.TempStartPoint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempStartPoint), "TempStartPoint"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.TempEndPoint == null)
		{
			this.TempEndPoint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempEndPoint), "TempEndPoint"))
		{
			return false;
		}
		this.Depth = characterWalkOnWaterComponent.Depth;
		this.OriginMaxSpeed = characterWalkOnWaterComponent.OriginMaxSpeed;
		if (characterWalkOnWaterComponent.PrePlayerLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PrePlayerLocation), "PrePlayerLocation"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.TempNormalPoint == null)
		{
			this.TempNormalPoint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempNormalPoint), "TempNormalPoint"))
		{
			return false;
		}
		this.WalkOnWaterStage = characterWalkOnWaterComponent.WalkOnWaterStage;
		this.WaterDepthType = characterWalkOnWaterComponent.WaterDepthType;
		this.OriginChannelResponse = characterWalkOnWaterComponent.OriginChannelResponse;
		this.InChangeStateProcess = characterWalkOnWaterComponent.InChangeStateProcess;
		this.CacheWalkOnWaterStage = characterWalkOnWaterComponent.CacheWalkOnWaterStage;
		this.WaterHeight = characterWalkOnWaterComponent.WaterHeight;
		if (characterWalkOnWaterComponent.WalkOnWaterSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<string>(this.WalkOnWaterSet), "WalkOnWaterSet"))
		{
			return false;
		}
		this.DisableKey = characterWalkOnWaterComponent.DisableKey;
		if (characterWalkOnWaterComponent.FreezeWaterRenderCapability == null)
		{
			this.FreezeWaterRenderCapability = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FreezeWaterRenderCapability), "FreezeWaterRenderCapability"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.MovementTrailCollisionCapability == null)
		{
			this.MovementTrailCollisionCapability = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MovementTrailCollisionCapability), "MovementTrailCollisionCapability"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.GameCapabilities != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.GameCapabilities), "GameCapabilities"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.InteractionComp == null)
		{
			this.InteractionComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InteractionComp), "InteractionComp"))
		{
			return false;
		}
		this.WaterDetected = characterWalkOnWaterComponent.WaterDetected;
		if (characterWalkOnWaterComponent.WaterNormal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaterNormal), "WaterNormal"))
		{
			return false;
		}
		if (characterWalkOnWaterComponent.WaterImpactPoint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaterImpactPoint), "WaterImpactPoint"))
		{
			return false;
		}
		this.StartUpZ = characterWalkOnWaterComponent.StartUpZ;
		this.UpTime = characterWalkOnWaterComponent.UpTime;
		this.CheckInGroundTime = characterWalkOnWaterComponent.CheckInGroundTime;
		return true;
	}

	// Token: 0x170025FD RID: 9725
	// (get) Token: 0x0601838C RID: 99212 RVA: 0x0074AD0F File Offset: 0x00748F0F
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025FE RID: 9726
	// (get) Token: 0x0601838D RID: 99213 RVA: 0x0074AD12 File Offset: 0x00748F12
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025FF RID: 9727
	// (get) Token: 0x0601838E RID: 99214 RVA: 0x0074AD15 File Offset: 0x00748F15
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002600 RID: 9728
	// (get) Token: 0x0601838F RID: 99215 RVA: 0x0074AD18 File Offset: 0x00748F18
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002601 RID: 9729
	// (get) Token: 0x06018390 RID: 99216 RVA: 0x0074AD1B File Offset: 0x00748F1B
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D088 RID: 53384
	private const float COS_EIGHTY = 0.173f;

	// Token: 0x0400D089 RID: 53385
	private const string PROFILE_DETECT_WATER_DEPTH = "CharacterWalkOnWaterComponent_DetectWaterDepth";

	// Token: 0x0400D08A RID: 53386
	private const string PROFILE_DETECT_WATER_UP_BLOCK = "CharacterWalkOnWaterComponent_WaterUpBlock";

	// Token: 0x0400D08B RID: 53387
	private const int ENTER_WALK_ON_WATER_DEPTH = 4;

	// Token: 0x0400D08C RID: 53388
	private const int PRE_FRAME_POSITION_MAX_DISTANCE = 1000;

	// Token: 0x0400D08D RID: 53389
	private const int PRE_FRAME_POSITION_MAX_DISTANCE_SQUARED = 1000000;

	// Token: 0x0400D08E RID: 53390
	private const int UP_TO_WATER_SURFACE_SPEED = 500;

	// Token: 0x0400D08F RID: 53391
	private const int CHECK_IN_GROUND_INTERVAL = 1000;

	// Token: 0x0400D090 RID: 53392
	private const int FIVE_HUNDRED_TO_FIND_SURFACE = 1000;

	// Token: 0x0400D091 RID: 53393
	private const int WALK_ON_WATER_HALF_HEIGHT_OFFSET = 3;

	// Token: 0x0400D092 RID: 53394
	private const int WALK_ON_WATER_RADIUS_OFFSET = 20;

	// Token: 0x0400D093 RID: 53395
	private const int WALK_ON_WATER_MOVEDIR_OFFSET = 3;

	// Token: 0x0400D094 RID: 53396
	private const int MODEL_BUFFER_TIME_LENGTH = 300;

	// Token: 0x0400D095 RID: 53397
	private const float SHALLOW_WATER_THRESOLD = 1.5f;

	// Token: 0x0400D096 RID: 53398
	private int freeWaterStateTag = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冻结水面"];

	// Token: 0x0400D097 RID: 53399
	public bool IsDebug;

	// Token: 0x0400D098 RID: 53400
	[Nullable(2)]
	private UTraceLineElement WaterUpTrace;

	// Token: 0x0400D099 RID: 53401
	[Nullable(2)]
	private UTraceSphereElement GroundTrace;

	// Token: 0x0400D09A RID: 53402
	[Nullable(2)]
	private UTraceSphereElement WaterTrace;

	// Token: 0x0400D09B RID: 53403
	[Nullable(2)]
	private UTraceSphereElement WaterEdgeTrace;

	// Token: 0x0400D09C RID: 53404
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D09D RID: 53405
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400D09E RID: 53406
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D09F RID: 53407
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400D0A0 RID: 53408
	[Nullable(2)]
	private CharacterFloatingComponent FloatingComp;

	// Token: 0x0400D0A1 RID: 53409
	[Nullable(2)]
	private ITagTask OnGameplayTagNewOrRemove;

	// Token: 0x0400D0A2 RID: 53410
	[Nullable(2)]
	private ITagTask OnFreezeWaterTagAddOrRemove;

	// Token: 0x0400D0A3 RID: 53411
	public bool IsActive;

	// Token: 0x0400D0A4 RID: 53412
	private float CharacterHalfHeight;

	// Token: 0x0400D0A5 RID: 53413
	[Nullable(2)]
	private global::Vector TempVector;

	// Token: 0x0400D0A6 RID: 53414
	[Nullable(2)]
	private global::Vector TempVector2;

	// Token: 0x0400D0A7 RID: 53415
	[Nullable(2)]
	private global::Vector TempStartPoint;

	// Token: 0x0400D0A8 RID: 53416
	[Nullable(2)]
	private global::Vector TempEndPoint;

	// Token: 0x0400D0A9 RID: 53417
	private float Depth;

	// Token: 0x0400D0AA RID: 53418
	private float OriginMaxSpeed;

	// Token: 0x0400D0AB RID: 53419
	private readonly global::Vector PrePlayerLocation = global::Vector.Create();

	// Token: 0x0400D0AC RID: 53420
	[Nullable(2)]
	private global::Vector TempNormalPoint;

	// Token: 0x0400D0AD RID: 53421
	public EWalkOnWaterStage WalkOnWaterStage;

	// Token: 0x0400D0AE RID: 53422
	public EWaterDepthType WaterDepthType;

	// Token: 0x0400D0AF RID: 53423
	private ECollisionResponse? OriginChannelResponse;

	// Token: 0x0400D0B0 RID: 53424
	private bool InChangeStateProcess;

	// Token: 0x0400D0B1 RID: 53425
	private EWalkOnWaterStage? CacheWalkOnWaterStage;

	// Token: 0x0400D0B2 RID: 53426
	private float WaterHeight;

	// Token: 0x0400D0B3 RID: 53427
	private readonly HashSet<string> WalkOnWaterSet = new HashSet<string>();

	// Token: 0x0400D0B4 RID: 53428
	private int DisableKey;

	// Token: 0x0400D0B5 RID: 53429
	[Nullable(2)]
	private WaterDetectedCapability FreezeWaterRenderCapability;

	// Token: 0x0400D0B6 RID: 53430
	[Nullable(2)]
	private WaterDetectedCapability MovementTrailCollisionCapability;

	// Token: 0x0400D0B7 RID: 53431
	private readonly List<WaterDetectedCapability> GameCapabilities = new List<WaterDetectedCapability>();

	// Token: 0x0400D0B8 RID: 53432
	[Nullable(2)]
	private UKuroEnviInteractionComponent InteractionComp;

	// Token: 0x0400D0B9 RID: 53433
	private bool WaterDetected;

	// Token: 0x0400D0BA RID: 53434
	private readonly global::Vector WaterNormal = global::Vector.Create();

	// Token: 0x0400D0BB RID: 53435
	private readonly global::Vector WaterImpactPoint = global::Vector.Create();

	// Token: 0x0400D0BC RID: 53436
	private float StartUpZ;

	// Token: 0x0400D0BD RID: 53437
	private double UpTime;

	// Token: 0x0400D0BE RID: 53438
	private float CheckInGroundTime = 1000f;
}
