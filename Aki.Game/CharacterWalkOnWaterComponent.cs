using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Capability;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

// Token: 0x0200309A RID: 12442
[NullableContext(1)]
[Nullable(0)]
public class CharacterWalkOnWaterComponent : EntityComponent, IComponentDependency
{
	// Token: 0x0601A963 RID: 108899 RVA: 0x00722C2C File Offset: 0x00720E2C
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

	// Token: 0x0601A964 RID: 108900 RVA: 0x00722D14 File Offset: 0x00720F14
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

	// Token: 0x0601A965 RID: 108901 RVA: 0x00722D7C File Offset: 0x00720F7C
	protected override void OnEnable()
	{
		this.PrePlayerLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
	}

	// Token: 0x0601A966 RID: 108902 RVA: 0x00722D94 File Offset: 0x00720F94
	protected override void OnDisable(string reason)
	{
		this.SetWalkOnWaterStage(EWalkOnWaterStage.None);
	}

	// Token: 0x0601A967 RID: 108903 RVA: 0x00722DA0 File Offset: 0x00720FA0
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

	// Token: 0x0601A968 RID: 108904 RVA: 0x00722F18 File Offset: 0x00721118
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

	// Token: 0x0601A969 RID: 108905 RVA: 0x00722FF4 File Offset: 0x007211F4
	private void CreateTempVector()
	{
		this.TempVector = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempVector2 = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempStartPoint = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempEndPoint = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempNormalPoint = global::Vector.Create(0.0, 0.0, 0.0);
	}

	// Token: 0x0601A96A RID: 108906 RVA: 0x007230BF File Offset: 0x007212BF
	private void ClearTempVector()
	{
		this.TempVector = null;
		this.TempVector2 = null;
		this.TempStartPoint = null;
		this.TempEndPoint = null;
		this.TempNormalPoint = null;
	}

	// Token: 0x1700248F RID: 9359
	// (get) Token: 0x0601A96B RID: 108907 RVA: 0x007230E4 File Offset: 0x007212E4
	public static Type[] Dependencies
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

	// Token: 0x0601A96C RID: 108908 RVA: 0x00723114 File Offset: 0x00721314
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

	// Token: 0x0601A96D RID: 108909 RVA: 0x00723388 File Offset: 0x00721588
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

	// Token: 0x0601A96E RID: 108910 RVA: 0x007234A8 File Offset: 0x007216A8
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

	// Token: 0x0601A96F RID: 108911 RVA: 0x007234FC File Offset: 0x007216FC
	private void OnMoveStateChange(ECharMoveState oldMoveState, ECharMoveState newMoveState)
	{
		if (this.WalkOnWaterStage == EWalkOnWaterStage.UpToWaterSurface && this.GetMaxSpeed(newMoveState) > 0f)
		{
			this.MoveComp.CharacterMovement.MaxCustomMovementSpeed = this.GetMaxSpeed(newMoveState);
		}
	}

	// Token: 0x0601A970 RID: 108912 RVA: 0x0072352C File Offset: 0x0072172C
	private void ReceiveWalkOnWaterEvent(float deltaTime)
	{
		this.MoveComp.CharacterMovement.KuroFlying(deltaTime, 0f, 0f, 0f, this.MoveComp.CurrentMovementSettings.Acceleration, this.GetMaxSpeed(this.StateComp.MoveState), 1f);
	}

	// Token: 0x0601A971 RID: 108913 RVA: 0x00723580 File Offset: 0x00721780
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

	// Token: 0x0601A972 RID: 108914 RVA: 0x007235CE File Offset: 0x007217CE
	private void OnFreezeWaterTagChanged(int tagId, bool tagExists)
	{
		if (tagExists)
		{
			this.AddFreezeWaterCapabilities();
			return;
		}
		this.BroadcastWaterDetectedEnd();
	}

	// Token: 0x0601A973 RID: 108915 RVA: 0x007235E0 File Offset: 0x007217E0
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

	// Token: 0x0601A974 RID: 108916 RVA: 0x00723644 File Offset: 0x00721844
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

	// Token: 0x0601A975 RID: 108917 RVA: 0x00723690 File Offset: 0x00721890
	private void OnCharacterCapsuleChanged(Entity entity, float radius, float halfHeight, bool bUpdateOverlaps)
	{
		this.CharacterHalfHeight = halfHeight + 3f;
	}

	// Token: 0x0601A976 RID: 108918 RVA: 0x007236A0 File Offset: 0x007218A0
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

	// Token: 0x0601A977 RID: 108919 RVA: 0x007236F2 File Offset: 0x007218F2
	public bool BlockMoveModeInherit(UCharacterMovementComponent otherCharacterMovement)
	{
		return !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不会入水"]) && otherCharacterMovement.MovementMode == EMovementMode.MOVE_Custom && otherCharacterMovement.CustomMovementMode == 5;
	}

	// Token: 0x0601A978 RID: 108920 RVA: 0x0072372F File Offset: 0x0072192F
	private bool IsNormalAccepted(global::Vector normal)
	{
		return Math.Abs(MathUtils.Instance.DotProduct(normal, this.ActorComp.ActorUpProxy)) > 0.17299999296665192;
	}

	// Token: 0x0601A979 RID: 108921 RVA: 0x00723758 File Offset: 0x00721958
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

	// Token: 0x0601A97A RID: 108922 RVA: 0x007238CC File Offset: 0x00721ACC
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

	// Token: 0x0601A97B RID: 108923 RVA: 0x00723A50 File Offset: 0x00721C50
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

	// Token: 0x0601A97C RID: 108924 RVA: 0x00723ABC File Offset: 0x00721CBC
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

	// Token: 0x0601A97D RID: 108925 RVA: 0x00723B14 File Offset: 0x00721D14
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

	// Token: 0x0601A97E RID: 108926 RVA: 0x00723BAC File Offset: 0x00721DAC
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

	// Token: 0x0601A97F RID: 108927 RVA: 0x00723C8C File Offset: 0x00721E8C
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

	// Token: 0x0601A980 RID: 108928 RVA: 0x00723D52 File Offset: 0x00721F52
	private void ExitUpToWalkOnWater()
	{
		this.MoveComp.CharacterMovement.MaxCustomMovementSpeed = this.OriginMaxSpeed;
	}

	// Token: 0x0601A981 RID: 108929 RVA: 0x00723D6C File Offset: 0x00721F6C
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

	// Token: 0x0601A982 RID: 108930 RVA: 0x00723DF0 File Offset: 0x00721FF0
	private void ExitWalkOnWater(bool isBuffEnd = false)
	{
		if (isBuffEnd && this.CheckUpWaterSurface())
		{
			this.FixedEnterWaterDepth((float)TimeUtil.Instance.InverseMillisecond);
		}
		this.EnableOrDisableWalkOnWater(false, "CharWalkOnWaterComp", false);
	}

	// Token: 0x0601A983 RID: 108931 RVA: 0x00723E1C File Offset: 0x0072201C
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

	// Token: 0x0601A984 RID: 108932 RVA: 0x00723ECC File Offset: 0x007220CC
	private bool SimpleWaterEdgeTrace(global::Vector start, global::Vector end)
	{
		TraceElementCommon.Instance.SetStartLocation(this.WaterEdgeTrace, start);
		TraceElementCommon.Instance.SetEndLocation(this.WaterEdgeTrace, end);
		return TraceElementCommon.Instance.SphereTrace(this.WaterEdgeTrace, "CharacterWalkOnWaterComponent_DetectWaterDepth") && this.WaterEdgeTrace.HitResult.bBlockingHit;
	}

	// Token: 0x0601A985 RID: 108933 RVA: 0x00723F24 File Offset: 0x00722124
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

	// Token: 0x0601A986 RID: 108934 RVA: 0x00723FC4 File Offset: 0x007221C4
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

	// Token: 0x0601A987 RID: 108935 RVA: 0x007240B5 File Offset: 0x007222B5
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

	// Token: 0x0601A988 RID: 108936 RVA: 0x007240F0 File Offset: 0x007222F0
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

	// Token: 0x0601A989 RID: 108937 RVA: 0x00724120 File Offset: 0x00722320
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

	// Token: 0x0601A98A RID: 108938 RVA: 0x00724204 File Offset: 0x00722404
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

	// Token: 0x0601A98B RID: 108939 RVA: 0x00724470 File Offset: 0x00722670
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

	// Token: 0x0601A98C RID: 108940 RVA: 0x007244E4 File Offset: 0x007226E4
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

	// Token: 0x0601A98D RID: 108941 RVA: 0x00724564 File Offset: 0x00722764
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

	// Token: 0x0601A98E RID: 108942 RVA: 0x007245E4 File Offset: 0x007227E4
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

	// Token: 0x0601A98F RID: 108943 RVA: 0x00724668 File Offset: 0x00722868
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

	// Token: 0x0601A990 RID: 108944 RVA: 0x007246E4 File Offset: 0x007228E4
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

	// Token: 0x0601A991 RID: 108945 RVA: 0x0072470C File Offset: 0x0072290C
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

	// Token: 0x0601A992 RID: 108946 RVA: 0x00724838 File Offset: 0x00722A38
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterWalkOnWaterComponent characterWalkOnWaterComponent = (CharacterWalkOnWaterComponent)componentTemplate;
		if (base.CanResetComponentProperty("freeWaterStateTag"))
		{
			this.freeWaterStateTag = characterWalkOnWaterComponent.freeWaterStateTag;
		}
		if (base.CanResetComponentProperty("IsDebug"))
		{
			this.IsDebug = characterWalkOnWaterComponent.IsDebug;
		}
		if (base.CanResetComponentProperty("WaterUpTrace"))
		{
			if (characterWalkOnWaterComponent.WaterUpTrace == null)
			{
				this.WaterUpTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceLineElement>(this.WaterUpTrace), "WaterUpTrace"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("GroundTrace"))
		{
			if (characterWalkOnWaterComponent.GroundTrace == null)
			{
				this.GroundTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.GroundTrace), "GroundTrace"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("WaterTrace"))
		{
			if (characterWalkOnWaterComponent.WaterTrace == null)
			{
				this.WaterTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.WaterTrace), "WaterTrace"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("WaterEdgeTrace"))
		{
			if (characterWalkOnWaterComponent.WaterEdgeTrace == null)
			{
				this.WaterEdgeTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.WaterEdgeTrace), "WaterEdgeTrace"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterWalkOnWaterComponent.ActorComp == null)
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
			if (characterWalkOnWaterComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterWalkOnWaterComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StateComp"))
		{
			if (characterWalkOnWaterComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.StateComp), "StateComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("FloatingComp"))
		{
			if (characterWalkOnWaterComponent.FloatingComp == null)
			{
				this.FloatingComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterFloatingComponent>(this.FloatingComp), "FloatingComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OnGameplayTagNewOrRemove"))
		{
			if (characterWalkOnWaterComponent.OnGameplayTagNewOrRemove == null)
			{
				this.OnGameplayTagNewOrRemove = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.OnGameplayTagNewOrRemove), "OnGameplayTagNewOrRemove"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OnFreezeWaterTagAddOrRemove"))
		{
			if (characterWalkOnWaterComponent.OnFreezeWaterTagAddOrRemove == null)
			{
				this.OnFreezeWaterTagAddOrRemove = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.OnFreezeWaterTagAddOrRemove), "OnFreezeWaterTagAddOrRemove"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsActive"))
		{
			this.IsActive = characterWalkOnWaterComponent.IsActive;
		}
		if (base.CanResetComponentProperty("CharacterHalfHeight"))
		{
			this.CharacterHalfHeight = characterWalkOnWaterComponent.CharacterHalfHeight;
		}
		if (base.CanResetComponentProperty("TempVector"))
		{
			if (characterWalkOnWaterComponent.TempVector == null)
			{
				this.TempVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector), "TempVector"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempVector2"))
		{
			if (characterWalkOnWaterComponent.TempVector2 == null)
			{
				this.TempVector2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector2), "TempVector2"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempStartPoint"))
		{
			if (characterWalkOnWaterComponent.TempStartPoint == null)
			{
				this.TempStartPoint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempStartPoint), "TempStartPoint"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempEndPoint"))
		{
			if (characterWalkOnWaterComponent.TempEndPoint == null)
			{
				this.TempEndPoint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempEndPoint), "TempEndPoint"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("Depth"))
		{
			this.Depth = characterWalkOnWaterComponent.Depth;
		}
		if (base.CanResetComponentProperty("OriginMaxSpeed"))
		{
			this.OriginMaxSpeed = characterWalkOnWaterComponent.OriginMaxSpeed;
		}
		if (base.CanResetComponentProperty("PrePlayerLocation") && characterWalkOnWaterComponent.PrePlayerLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.PrePlayerLocation), "PrePlayerLocation"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempNormalPoint"))
		{
			if (characterWalkOnWaterComponent.TempNormalPoint == null)
			{
				this.TempNormalPoint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempNormalPoint), "TempNormalPoint"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("WalkOnWaterStage"))
		{
			this.WalkOnWaterStage = characterWalkOnWaterComponent.WalkOnWaterStage;
		}
		if (base.CanResetComponentProperty("WaterDepthType"))
		{
			this.WaterDepthType = characterWalkOnWaterComponent.WaterDepthType;
		}
		if (base.CanResetComponentProperty("OriginChannelResponse"))
		{
			this.OriginChannelResponse = characterWalkOnWaterComponent.OriginChannelResponse;
		}
		if (base.CanResetComponentProperty("InChangeStateProcess"))
		{
			this.InChangeStateProcess = characterWalkOnWaterComponent.InChangeStateProcess;
		}
		if (base.CanResetComponentProperty("CacheWalkOnWaterStage"))
		{
			this.CacheWalkOnWaterStage = characterWalkOnWaterComponent.CacheWalkOnWaterStage;
		}
		if (base.CanResetComponentProperty("WaterHeight"))
		{
			this.WaterHeight = characterWalkOnWaterComponent.WaterHeight;
		}
		if (base.CanResetComponentProperty("WalkOnWaterSet") && characterWalkOnWaterComponent.WalkOnWaterSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<string>(this.WalkOnWaterSet), "WalkOnWaterSet"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("DisableKey"))
		{
			this.DisableKey = characterWalkOnWaterComponent.DisableKey;
		}
		if (base.CanResetComponentProperty("FreezeWaterRenderCapability"))
		{
			if (characterWalkOnWaterComponent.FreezeWaterRenderCapability == null)
			{
				this.FreezeWaterRenderCapability = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<WaterDetectedCapability>(this.FreezeWaterRenderCapability), "FreezeWaterRenderCapability"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MovementTrailCollisionCapability"))
		{
			if (characterWalkOnWaterComponent.MovementTrailCollisionCapability == null)
			{
				this.MovementTrailCollisionCapability = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<WaterDetectedCapability>(this.MovementTrailCollisionCapability), "MovementTrailCollisionCapability"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("GameCapabilities") && characterWalkOnWaterComponent.GameCapabilities != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<WaterDetectedCapability>>(this.GameCapabilities), "GameCapabilities"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("InteractionComp"))
		{
			if (characterWalkOnWaterComponent.InteractionComp == null)
			{
				this.InteractionComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroEnviInteractionComponent>(this.InteractionComp), "InteractionComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("WaterDetected"))
		{
			this.WaterDetected = characterWalkOnWaterComponent.WaterDetected;
		}
		if (base.CanResetComponentProperty("WaterNormal") && characterWalkOnWaterComponent.WaterNormal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.WaterNormal), "WaterNormal"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("WaterImpactPoint") && characterWalkOnWaterComponent.WaterImpactPoint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.WaterImpactPoint), "WaterImpactPoint"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("StartUpZ"))
		{
			this.StartUpZ = characterWalkOnWaterComponent.StartUpZ;
		}
		if (base.CanResetComponentProperty("UpTime"))
		{
			this.UpTime = characterWalkOnWaterComponent.UpTime;
		}
		if (base.CanResetComponentProperty("CheckInGroundTime"))
		{
			this.CheckInGroundTime = characterWalkOnWaterComponent.CheckInGroundTime;
		}
		return true;
	}

	// Token: 0x0400CCA5 RID: 52389
	private const float COS_EIGHTY = 0.173f;

	// Token: 0x0400CCA6 RID: 52390
	private const string PROFILE_DETECT_WATER_DEPTH = "CharacterWalkOnWaterComponent_DetectWaterDepth";

	// Token: 0x0400CCA7 RID: 52391
	private const string PROFILE_DETECT_WATER_UP_BLOCK = "CharacterWalkOnWaterComponent_WaterUpBlock";

	// Token: 0x0400CCA8 RID: 52392
	private const int ENTER_WALK_ON_WATER_DEPTH = 4;

	// Token: 0x0400CCA9 RID: 52393
	private const int PRE_FRAME_POSITION_MAX_DISTANCE = 1000;

	// Token: 0x0400CCAA RID: 52394
	private const int PRE_FRAME_POSITION_MAX_DISTANCE_SQUARED = 1000000;

	// Token: 0x0400CCAB RID: 52395
	private const int UP_TO_WATER_SURFACE_SPEED = 500;

	// Token: 0x0400CCAC RID: 52396
	private const int CHECK_IN_GROUND_INTERVAL = 1000;

	// Token: 0x0400CCAD RID: 52397
	private const int FIVE_HUNDRED_TO_FIND_SURFACE = 1000;

	// Token: 0x0400CCAE RID: 52398
	private const int WALK_ON_WATER_HALF_HEIGHT_OFFSET = 3;

	// Token: 0x0400CCAF RID: 52399
	private const int WALK_ON_WATER_RADIUS_OFFSET = 20;

	// Token: 0x0400CCB0 RID: 52400
	private const int WALK_ON_WATER_MOVEDIR_OFFSET = 3;

	// Token: 0x0400CCB1 RID: 52401
	private const int MODEL_BUFFER_TIME_LENGTH = 300;

	// Token: 0x0400CCB2 RID: 52402
	private const float SHALLOW_WATER_THRESOLD = 1.5f;

	// Token: 0x0400CCB3 RID: 52403
	private int freeWaterStateTag = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冻结水面"];

	// Token: 0x0400CCB4 RID: 52404
	public bool IsDebug;

	// Token: 0x0400CCB5 RID: 52405
	[Nullable(2)]
	private UTraceLineElement WaterUpTrace;

	// Token: 0x0400CCB6 RID: 52406
	[Nullable(2)]
	private UTraceSphereElement GroundTrace;

	// Token: 0x0400CCB7 RID: 52407
	[Nullable(2)]
	private UTraceSphereElement WaterTrace;

	// Token: 0x0400CCB8 RID: 52408
	[Nullable(2)]
	private UTraceSphereElement WaterEdgeTrace;

	// Token: 0x0400CCB9 RID: 52409
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CCBA RID: 52410
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400CCBB RID: 52411
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400CCBC RID: 52412
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400CCBD RID: 52413
	[Nullable(2)]
	private CharacterFloatingComponent FloatingComp;

	// Token: 0x0400CCBE RID: 52414
	[Nullable(2)]
	private ITagTask OnGameplayTagNewOrRemove;

	// Token: 0x0400CCBF RID: 52415
	[Nullable(2)]
	private ITagTask OnFreezeWaterTagAddOrRemove;

	// Token: 0x0400CCC0 RID: 52416
	public bool IsActive;

	// Token: 0x0400CCC1 RID: 52417
	private float CharacterHalfHeight;

	// Token: 0x0400CCC2 RID: 52418
	[Nullable(2)]
	private global::Vector TempVector;

	// Token: 0x0400CCC3 RID: 52419
	[Nullable(2)]
	private global::Vector TempVector2;

	// Token: 0x0400CCC4 RID: 52420
	[Nullable(2)]
	private global::Vector TempStartPoint;

	// Token: 0x0400CCC5 RID: 52421
	[Nullable(2)]
	private global::Vector TempEndPoint;

	// Token: 0x0400CCC6 RID: 52422
	private float Depth;

	// Token: 0x0400CCC7 RID: 52423
	private float OriginMaxSpeed;

	// Token: 0x0400CCC8 RID: 52424
	private readonly global::Vector PrePlayerLocation = global::Vector.Create();

	// Token: 0x0400CCC9 RID: 52425
	[Nullable(2)]
	private global::Vector TempNormalPoint;

	// Token: 0x0400CCCA RID: 52426
	public EWalkOnWaterStage WalkOnWaterStage;

	// Token: 0x0400CCCB RID: 52427
	public EWaterDepthType WaterDepthType;

	// Token: 0x0400CCCC RID: 52428
	private ECollisionResponse? OriginChannelResponse;

	// Token: 0x0400CCCD RID: 52429
	private bool InChangeStateProcess;

	// Token: 0x0400CCCE RID: 52430
	private EWalkOnWaterStage? CacheWalkOnWaterStage;

	// Token: 0x0400CCCF RID: 52431
	private float WaterHeight;

	// Token: 0x0400CCD0 RID: 52432
	private readonly HashSet<string> WalkOnWaterSet = new HashSet<string>();

	// Token: 0x0400CCD1 RID: 52433
	private int DisableKey;

	// Token: 0x0400CCD2 RID: 52434
	[Nullable(2)]
	private WaterDetectedCapability FreezeWaterRenderCapability;

	// Token: 0x0400CCD3 RID: 52435
	[Nullable(2)]
	private WaterDetectedCapability MovementTrailCollisionCapability;

	// Token: 0x0400CCD4 RID: 52436
	private readonly List<WaterDetectedCapability> GameCapabilities = new List<WaterDetectedCapability>();

	// Token: 0x0400CCD5 RID: 52437
	[Nullable(2)]
	private UKuroEnviInteractionComponent InteractionComp;

	// Token: 0x0400CCD6 RID: 52438
	private bool WaterDetected;

	// Token: 0x0400CCD7 RID: 52439
	private readonly global::Vector WaterNormal = global::Vector.Create();

	// Token: 0x0400CCD8 RID: 52440
	private readonly global::Vector WaterImpactPoint = global::Vector.Create();

	// Token: 0x0400CCD9 RID: 52441
	private float StartUpZ;

	// Token: 0x0400CCDA RID: 52442
	private double UpTime;

	// Token: 0x0400CCDB RID: 52443
	private float CheckInGroundTime = 1000f;
}
