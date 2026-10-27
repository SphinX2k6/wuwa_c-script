using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

// Token: 0x02003272 RID: 12914
[NullableContext(1)]
[Nullable(0)]
public class BaseSplineMoveComponent : EntityComponent
{
	// Token: 0x1700268C RID: 9868
	// (get) Token: 0x0601BEE7 RID: 114407 RVA: 0x007C0587 File Offset: 0x007BE787
	public ESplineMovePattern CurrentSplineMoveType
	{
		get
		{
			if (this.CurrentSplineMoveParamsInternal == null)
			{
				return ESplineMovePattern.PathLine;
			}
			return this.CurrentSplineMoveParamsInternal.Type;
		}
	}

	// Token: 0x1700268D RID: 9869
	// (get) Token: 0x0601BEE8 RID: 114408 RVA: 0x007C059E File Offset: 0x007BE79E
	[Nullable(2)]
	public SplineMoveParams CurrentSplineMoveParams
	{
		[NullableContext(2)]
		get
		{
			return this.CurrentSplineMoveParamsInternal;
		}
	}

	// Token: 0x1700268E RID: 9870
	// (get) Token: 0x0601BEE9 RID: 114409 RVA: 0x007C05A6 File Offset: 0x007BE7A6
	// (set) Token: 0x0601BEEA RID: 114410 RVA: 0x007C05AE File Offset: 0x007BE7AE
	public bool IsPositiveMoving
	{
		get
		{
			return this.IsPositiveMovingInternal;
		}
		protected set
		{
			if (this.IsPositiveMovingInternal == value)
			{
				return;
			}
			this.IsPositiveMovingInternal = value;
			this.OnPositiveMovingChanged();
		}
	}

	// Token: 0x0601BEEB RID: 114411 RVA: 0x007C05C7 File Offset: 0x007BE7C7
	protected virtual void OnPositiveMovingChanged()
	{
	}

	// Token: 0x0601BEEC RID: 114412 RVA: 0x007C05CC File Offset: 0x007BE7CC
	protected override bool OnStart()
	{
		this.DisableKey = new int?(base.Disable("[SplineMoveComponent.OnStart] 默认Disable"));
		this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.TeleportChangeLocation, new Action(this.OnTeleportWrapper));
		return true;
	}

	// Token: 0x0601BEED RID: 114413 RVA: 0x007C0634 File Offset: 0x007BE834
	protected override void OnTick(float delta)
	{
		SplineMoveParams currentSplineMoveParams = this.CurrentSplineMoveParams;
		if (currentSplineMoveParams == null)
		{
			global::Log.Instance.Error(ELogModule.Movement, ELogAuthor.LCZ, "Tick in No SplineMove!", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.DisableKey = new int?(base.Disable("[SplineMoveComponent.OnTick] this.CurrentSplineMoveParams为false"));
			return;
		}
		if (!this.SplineMoveParamsMap.ContainsKey(currentSplineMoveParams.Id) && currentSplineMoveParams.EarliestLeaveTime <= Time.Instance.NowSeconds)
		{
			if (currentSplineMoveParams.IsDelayClear)
			{
				currentSplineMoveParams.EnableParams(false);
			}
			if (!this.SelectNextSplineMove())
			{
				return;
			}
		}
		this.UpdateSplineLocationAndDirection();
		this.UpdateLastSplineLocationAndDirection();
		float deltaSeconds = delta * 0.001f;
		this.PositionAdjust(this.SplineTimeKey, deltaSeconds);
		this.InputAdjust();
		this.CheckAutoExitCurrentSpline();
		this.LastLocation.DeepCopy(this.TargetLocation);
		this.LastTimeKey = this.SplineTimeKey;
		this.UpdateSplineGravity(ESplineGravityUpdateType.Update);
	}

	// Token: 0x0601BEEE RID: 114414 RVA: 0x007C070B File Offset: 0x007BE90B
	protected override bool OnEnd()
	{
		this.ClearSplineMoveParams();
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.TeleportChangeLocation, new Action(this.OnTeleportWrapper));
		return true;
	}

	// Token: 0x0601BEEF RID: 114415 RVA: 0x007C0738 File Offset: 0x007BE938
	protected virtual void PositionAdjust(float timeKey, float deltaSeconds)
	{
		ESplineMovePattern currentSplineMoveType = this.CurrentSplineMoveType;
		if (currentSplineMoveType <= ESplineMovePattern.SlideTrack)
		{
			this.PositionAdjustCommon(timeKey, deltaSeconds);
		}
	}

	// Token: 0x0601BEF0 RID: 114416 RVA: 0x007C0758 File Offset: 0x007BE958
	protected virtual void PositionAdjustCommon(float timeKey, float deltaSeconds)
	{
		this.TargetLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.CheckAndLimitOnlyForwardMove();
		this.LimitMaxMove();
		this.MoveToTargetLocation(deltaSeconds);
	}

	// Token: 0x0601BEF1 RID: 114417 RVA: 0x007C0784 File Offset: 0x007BE984
	protected void LimitMaxMove()
	{
		SplineMoveParams currentSplineMoveParamsInternal = this.CurrentSplineMoveParamsInternal;
		this.SplineLocation.Subtraction(this.TargetLocation, this.OffsetVector);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.OffsetVector);
		this.SplineQuat.UnRotateVector(this.OffsetVector, this.OffsetVector);
		this.OffsetVector.X = 0.0;
		float currentMaxOffset = this.CurrentSplineMoveParamsInternal.CurrentMaxOffset;
		if (currentMaxOffset < 0f)
		{
			return;
		}
		double num;
		if (this.Using3d)
		{
			num = this.OffsetVector.Size();
			if (num > (double)currentMaxOffset)
			{
				this.OffsetVector.Multiply((num - (double)currentMaxOffset) / num, this.TmpVector);
				this.SplineQuat.RotateVector(this.TmpVector, this.TmpVector);
				this.TargetLocation.AdditionEqual(this.TmpVector);
			}
		}
		else
		{
			num = Math.Abs(this.OffsetVector.Y);
			if (num > (double)currentMaxOffset)
			{
				this.TmpVector.Set(0.0, (double)Math.Sign(this.OffsetVector.Y) * (num - (double)currentMaxOffset), 0.0);
				this.SplineQuat.RotateVector(this.TmpVector, this.TmpVector);
				this.TargetLocation.AdditionEqual(this.TmpVector);
			}
		}
		currentSplineMoveParamsInternal.CurrentMaxOffset = (float)Math.Max((double)currentSplineMoveParamsInternal.MaxOffsetDist, Math.Min((double)currentSplineMoveParamsInternal.CurrentMaxOffset, num));
	}

	// Token: 0x0601BEF2 RID: 114418 RVA: 0x007C0904 File Offset: 0x007BEB04
	protected virtual void MoveToTargetLocation(float deltaSeconds)
	{
		if (Vector.DistSquared(this.ActorComp.ActorLocationProxy, this.TargetLocation) <= 1E-08)
		{
			return;
		}
		this.ActorComp.SetActorLocation(this.TargetLocation.ToUeVector(false), "样条移动", false);
	}

	// Token: 0x0601BEF3 RID: 114419 RVA: 0x007C0954 File Offset: 0x007BEB54
	protected bool CheckAndLimitOnlyForwardMove()
	{
		this.ActorComp.ActorLocationProxy.Subtraction(this.LastLocation, this.TmpVector);
		bool flag = this.TmpVector.DotProduct(this.SplineDirection) > 0.0;
		if (!this.CurrentSplineMoveParamsInternal.OnlyForward || flag)
		{
			return false;
		}
		this.LastLocation.Subtraction(this.TargetLocation, this.OffsetVector);
		double inB = this.SplineDirection.DotProduct(this.OffsetVector);
		this.SplineDirection.Multiply(inB, this.TmpVector);
		this.TargetLocation.AdditionEqual(this.TmpVector);
		return true;
	}

	// Token: 0x0601BEF4 RID: 114420 RVA: 0x007C09FF File Offset: 0x007BEBFF
	protected virtual void InputAdjust()
	{
	}

	// Token: 0x0601BEF5 RID: 114421 RVA: 0x007C0A04 File Offset: 0x007BEC04
	public void StartSplineMove(int id, ISplineMovePattern config, bool allowInherit = false)
	{
		if (!this.StartMoveConditionCheck(id, config))
		{
			return;
		}
		SplineMoveParams splineMoveParams = new SplineMoveParams();
		splineMoveParams.InitBase(id, config, base.Entity);
		splineMoveParams.AllowInherit = allowInherit;
		this.StartSplineMoveInternal(splineMoveParams);
	}

	// Token: 0x0601BEF6 RID: 114422 RVA: 0x007C0A40 File Offset: 0x007BEC40
	public void InheritStartSplineMove(SplineMoveParams splineMoveParams)
	{
		if (!this.StartMoveConditionCheck(splineMoveParams.Id, splineMoveParams.Config))
		{
			return;
		}
		SplineMoveParams splineMoveParams2 = new SplineMoveParams();
		if (splineMoveParams.Id == -1 && splineMoveParams.Type == ESplineMovePattern.MotorcycleTrack)
		{
			splineMoveParams2.InitByAutoPilotRoute(splineMoveParams.AutopilotRoute, base.Entity);
		}
		else
		{
			splineMoveParams2.InitBase(splineMoveParams.Id, splineMoveParams.Config, base.Entity);
		}
		splineMoveParams.MarkInherited = true;
		splineMoveParams2.AllowInherit = true;
		this.StartSplineMoveInternal(splineMoveParams2);
	}

	// Token: 0x0601BEF7 RID: 114423 RVA: 0x007C0AC0 File Offset: 0x007BECC0
	public void StartSplineMoveWithAutoPilotRoute(UAutopilotRoute autoPilotRoute)
	{
		SplineMoveParams splineMoveParams = new SplineMoveParams();
		splineMoveParams.InitByAutoPilotRoute(autoPilotRoute, base.Entity);
		this.StartSplineMoveInternal(splineMoveParams);
	}

	// Token: 0x0601BEF8 RID: 114424 RVA: 0x007C0AE8 File Offset: 0x007BECE8
	public unsafe virtual void StartSplineMoveInternal(SplineMoveParams config)
	{
		int id = config.Id;
		if (this.DisableKey != null)
		{
			base.Enable(new int?(this.DisableKey.Value), "SplineMoveComponent.StartSplineMoveInternal");
			this.DisableKey = null;
			this.OnSplineMoveEnable(id, config);
		}
		this.AddSplineMoveParams(id, config);
		this.SelectNextSplineMove();
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Movement;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "StartSplineMove";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Spline Id", id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorComp.Owner);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StackCount", this.SplineStack.Count);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0601BEF9 RID: 114425 RVA: 0x007C0BD0 File Offset: 0x007BEDD0
	public unsafe void EndSplineMove(int id)
	{
		if (!this.EndMoveConditionCheck(id))
		{
			return;
		}
		bool flag = this.CurrentSplineMoveParamsInternal.EarliestLeaveTime > Time.Instance.NowSeconds;
		this.RemoveSplineMoveParams(id, flag);
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Movement;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "EndSplineMove";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Spline Id", id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorComp.Owner);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StackCount", this.SplineStack.Count);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		if (flag)
		{
			return;
		}
		this.SelectNextSplineMove();
	}

	// Token: 0x0601BEFA RID: 114426 RVA: 0x007C0C9A File Offset: 0x007BEE9A
	public void EndSplineMoveForAutoPilot()
	{
		this.EndSplineMove(-1);
	}

	// Token: 0x0601BEFB RID: 114427 RVA: 0x007C0CA3 File Offset: 0x007BEEA3
	public void ForceStopSplineMove()
	{
		if (this.DisableKey == null)
		{
			this.DisableKey = new int?(base.Disable("SplineMoveComponent.ForceStopSplineMove"));
			this.OnSplineMoveDisable();
		}
		this.CurrentSplineMoveParamsInternal = null;
		this.ClearSplineMoveParams();
	}

	// Token: 0x0601BEFC RID: 114428 RVA: 0x007C0CDB File Offset: 0x007BEEDB
	public virtual bool IsPlannerMove()
	{
		return true;
	}

	// Token: 0x0601BEFD RID: 114429 RVA: 0x007C0CDE File Offset: 0x007BEEDE
	protected virtual bool StartMoveConditionCheck(int id, ISplineMovePattern config)
	{
		return this.SplineStack.Count <= 0 || this.SplineStack[this.SplineStack.Count - 1] != id;
	}

	// Token: 0x0601BEFE RID: 114430 RVA: 0x007C0D0C File Offset: 0x007BEF0C
	protected virtual bool EndMoveConditionCheck(int id)
	{
		return this.SplineMoveParamsMap.ContainsKey(id);
	}

	// Token: 0x0601BEFF RID: 114431 RVA: 0x007C0D20 File Offset: 0x007BEF20
	protected bool SelectNextSplineMove()
	{
		this.OnSelectNextSplineMoveBegin();
		if (this.SplineStack.Count > 0)
		{
			SplineMoveParams currentSplineMoveParamsInternal = this.SplineMoveParamsMap[this.SplineStack[this.SplineStack.Count - 1]];
			this.CurrentSplineMoveParamsInternal = currentSplineMoveParamsInternal;
			this.UpdateSplineLocationAndDirection();
		}
		else
		{
			if (this.DisableKey == null)
			{
				this.DisableKey = new int?(base.Disable("[SplineMoveComponent.EndSplineMove] 没有下一个SplineMove"));
				this.OnSplineMoveDisable();
			}
			this.CurrentSplineMoveParamsInternal = null;
		}
		this.OnSelectNextSplineMoveEnd();
		return this.CurrentSplineMoveParams != null;
	}

	// Token: 0x0601BF00 RID: 114432 RVA: 0x007C0DB3 File Offset: 0x007BEFB3
	protected void AddSplineMoveParams(int id, SplineMoveParams config)
	{
		if (!this.SplineMoveParamsMap.ContainsKey(id))
		{
			config.EnableParams(true);
			this.SplineMoveParamsMap[id] = config;
		}
		this.SplineStack.Add(id);
	}

	// Token: 0x0601BF01 RID: 114433 RVA: 0x007C0DE4 File Offset: 0x007BEFE4
	protected void RemoveSplineMoveParams(int id, bool bDelayClear)
	{
		SplineMoveParams splineMoveParams;
		if (this.SplineMoveParamsMap.TryGetValue(id, out splineMoveParams))
		{
			if (!bDelayClear)
			{
				splineMoveParams.EnableParams(false);
			}
			splineMoveParams.IsDelayClear = bDelayClear;
		}
		this.SplineMoveParamsMap.Remove(id);
		while (this.SplineStack.Count > 0 && !this.SplineMoveParamsMap.ContainsKey(this.SplineStack[this.SplineStack.Count - 1]))
		{
			this.SplineStack.RemoveAt(this.SplineStack.Count - 1);
		}
	}

	// Token: 0x0601BF02 RID: 114434 RVA: 0x007C0E6C File Offset: 0x007BF06C
	protected void ClearSplineMoveParams()
	{
		foreach (int splineId in this.SplineMoveParamsMap.Keys)
		{
			GameSplineModel.Instance.ReleaseSpline(splineId, (long)base.Entity.Id, EIdType.EntityId);
		}
		this.SplineMoveParamsMap.Clear();
		this.SplineStack.Clear();
	}

	// Token: 0x0601BF03 RID: 114435 RVA: 0x007C0EEC File Offset: 0x007BF0EC
	protected virtual void OnSplineMoveEnable(int id, SplineMoveParams config)
	{
	}

	// Token: 0x0601BF04 RID: 114436 RVA: 0x007C0EEE File Offset: 0x007BF0EE
	protected virtual void OnSplineMoveDisable()
	{
	}

	// Token: 0x0601BF05 RID: 114437 RVA: 0x007C0EF0 File Offset: 0x007BF0F0
	protected virtual void OnSelectNextSplineMoveBegin()
	{
		SplineMoveParams currentSplineMoveParams = this.CurrentSplineMoveParams;
		this.CacheNeedUpdateSplineGravityLeave = (currentSplineMoveParams != null && currentSplineMoveParams.UseSplineGravity);
	}

	// Token: 0x0601BF06 RID: 114438 RVA: 0x007C0F0C File Offset: 0x007BF10C
	protected virtual void OnSelectNextSplineMoveEnd()
	{
		this.LastLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.LastSplineDirection.DeepCopy(this.SplineDirection);
		this.LastSplineLocation.DeepCopy(this.SplineLocation);
		this.LastTimeKey = -1f;
		SplineMoveParams currentSplineMoveParams = this.CurrentSplineMoveParams;
		if (currentSplineMoveParams != null && currentSplineMoveParams.UseSplineGravity)
		{
			this.UpdateSplineGravity(ESplineGravityUpdateType.Enter);
			return;
		}
		if (this.CacheNeedUpdateSplineGravityLeave)
		{
			this.UpdateSplineGravity(ESplineGravityUpdateType.Leave);
		}
	}

	// Token: 0x0601BF07 RID: 114439 RVA: 0x007C0F88 File Offset: 0x007BF188
	protected virtual void UpdateSplineLocationAndDirection()
	{
		USplineComponent spline = this.CurrentSplineMoveParams.Spline;
		FVectorDouble fvectorDouble;
		float num;
		if (this.CurrentSplineMoveParams.UseSplineGravity || this.Using3d)
		{
			USplineComponent usplineComponent = spline;
			fvectorDouble = this.ActorComp.ActorLocationProxy.ToUeVector(false);
			num = usplineComponent.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
		}
		else
		{
			USplineComponent usplineComponent2 = spline;
			fvectorDouble = this.ActorComp.ActorLocationProxy.ToUeVector(false);
			num = usplineComponent2.D_FindInputKeyClosestToWorldLocationInGravity(fvectorDouble, this.ActorComp.ActorGravityDirectProxy.ToUeVectorOld(), this.CurrentSplineMoveParams.LayerVerticalLimit);
		}
		this.SplineTimeKey = num;
		Vector splineLocation = this.SplineLocation;
		fvectorDouble = spline.D_GetLocationAtSplineInputKey(num, ESplineCoordinateSpace.World);
		splineLocation.FromUeVector(fvectorDouble);
		Vector splineDirection = this.SplineDirection;
		FVector directionAtSplineInputKey = spline.GetDirectionAtSplineInputKey(num, ESplineCoordinateSpace.World);
		fvectorDouble = directionAtSplineInputKey;
		splineDirection.DeepCopy(fvectorDouble);
		if (this.CurrentSplineMoveParams.OnlyForward || this.CurrentSplineMoveParams.OnlyPositiveMove)
		{
			this.IsPositiveMoving = true;
		}
		else
		{
			Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
			double num2 = this.SplineDirection.DotProduct(actorForwardProxy);
			this.IsPositiveMoving = (num2 >= 0.0);
		}
		if (this.IsPlannerMove())
		{
			GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.SplineDirection);
		}
		this.SplineDirection.Normalize(9.99999993922529E-09);
		this.ActorComp.ActorGravityDirectProxy.UnaryNegation(this.TmpVector);
		if (this.IsPositiveMoving)
		{
			this.TmpVector1.DeepCopy(this.SplineDirection);
		}
		else
		{
			this.SplineDirection.UnaryNegation(this.TmpVector1);
		}
		if (this.Using3d)
		{
			MathUtils.Instance.LookRotationForwardFirst(this.TmpVector1, this.TmpVector, this.SplineQuat);
			return;
		}
		MathUtils.Instance.LookRotationUpFirst(this.TmpVector1, this.TmpVector, this.SplineQuat);
	}

	// Token: 0x0601BF08 RID: 114440 RVA: 0x007C1158 File Offset: 0x007BF358
	protected void UpdateLastSplineLocationAndDirection()
	{
		if (this.LastTimeKey == -1f)
		{
			return;
		}
		USplineComponent spline = this.CurrentSplineMoveParamsInternal.Spline;
		Vector lastSplineLocation = this.LastSplineLocation;
		FVectorDouble fvectorDouble = spline.D_GetLocationAtSplineInputKey(this.LastTimeKey, ESplineCoordinateSpace.World);
		lastSplineLocation.FromUeVector(fvectorDouble);
		Vector lastSplineDirection = this.LastSplineDirection;
		FVector directionAtSplineInputKey = spline.GetDirectionAtSplineInputKey(this.LastTimeKey, ESplineCoordinateSpace.World);
		lastSplineDirection.FromUeVector(directionAtSplineInputKey);
		if (this.IsPlannerMove())
		{
			GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.LastSplineDirection);
		}
		this.LastSplineDirection.Normalize(9.99999993922529E-09);
	}

	// Token: 0x0601BF09 RID: 114441 RVA: 0x007C11E9 File Offset: 0x007BF3E9
	protected void OnTeleportWrapper()
	{
		if (this.SplineMoveParamsMap.Count == 0 && this.SplineStack.Count == 0)
		{
			return;
		}
		this.OnTeleportChangeLocation();
	}

	// Token: 0x0601BF0A RID: 114442 RVA: 0x007C120C File Offset: 0x007BF40C
	protected void OnTeleportChangeLocation()
	{
		this.LastLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.LastSplineDirection.DeepCopy(this.SplineDirection);
		this.LastSplineLocation.DeepCopy(this.SplineLocation);
		this.LastTimeKey = -1f;
	}

	// Token: 0x0601BF0B RID: 114443 RVA: 0x007C125C File Offset: 0x007BF45C
	protected unsafe virtual void UpdateSplineGravity(ESplineGravityUpdateType type)
	{
		BaseGravityComponent component = base.Entity.GetComponent<BaseGravityComponent>();
		FVector upVectorAtSplineInputKey;
		FVectorDouble fvectorDouble;
		switch (type)
		{
		case ESplineGravityUpdateType.Enter:
		{
			SplineMoveParams currentSplineMoveParams = this.CurrentSplineMoveParams;
			if (currentSplineMoveParams == null || !currentSplineMoveParams.UseSplineGravity)
			{
				return;
			}
			Vector tmpVector = this.TmpVector;
			upVectorAtSplineInputKey = this.CurrentSplineMoveParams.Spline.GetUpVectorAtSplineInputKey(this.SplineTimeKey, ESplineCoordinateSpace.World);
			fvectorDouble = upVectorAtSplineInputKey;
			tmpVector.DeepCopy(fvectorDouble);
			this.TmpVector.UnaryNegation(this.TmpVector);
			if (component != null)
			{
				component.SetGravityByPriority(1, this.TmpVector, true, this.CalcGravitySwitchSmoothTime(component.GetActiveGravityDirect(), this.TmpVector), false);
				return;
			}
			return;
		}
		case ESplineGravityUpdateType.Leave:
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "ResetSpline MoveGravity";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Spline Id";
			SplineMoveParams currentSplineMoveParams2 = this.CurrentSplineMoveParams;
			ptr = new ValueTuple<string, object>(item, (currentSplineMoveParams2 != null) ? new int?(currentSplineMoveParams2.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorComp.Owner);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (component != null)
			{
				component.StopGravityByPriority(1, true, this.CalcGravitySwitchSmoothTime(component.GetActiveGravityDirect(), component.GetDefaultGravityDirect()), false);
				return;
			}
			return;
		}
		}
		SplineMoveParams currentSplineMoveParams3 = this.CurrentSplineMoveParams;
		if (currentSplineMoveParams3 == null || !currentSplineMoveParams3.UseSplineGravity)
		{
			return;
		}
		Vector tmpVector2 = this.TmpVector;
		upVectorAtSplineInputKey = this.CurrentSplineMoveParams.Spline.GetUpVectorAtSplineInputKey(this.SplineTimeKey, ESplineCoordinateSpace.World);
		fvectorDouble = upVectorAtSplineInputKey;
		tmpVector2.DeepCopy(fvectorDouble);
		this.TmpVector.UnaryNegation(this.TmpVector);
		if (component != null)
		{
			component.SetGravityByPriority(1, this.TmpVector, true, -1f, false);
		}
	}

	// Token: 0x0601BF0C RID: 114444 RVA: 0x007C141C File Offset: 0x007BF61C
	protected float CalcGravitySwitchSmoothTime(Vector from, Vector to)
	{
		SplineMoveParams currentSplineMoveParams = this.CurrentSplineMoveParams;
		float? num;
		if (currentSplineMoveParams == null)
		{
			num = null;
		}
		else
		{
			ISplineMovePattern config = currentSplineMoveParams.Config;
			num = ((config != null) ? config.GravitySwitchAngularVelocity : null);
		}
		float? num2 = num;
		if (num2 != null)
		{
			float? num3 = num2;
			float num4 = 0f;
			if (!(num3.GetValueOrDefault() <= num4 & num3 != null))
			{
				double num5 = Math.Acos(MathUtils.Instance.Clamp(from.DotProduct(to), -1.0, 1.0)) * 57.295780181884766;
				num3 = num2;
				return (float)(num5 / ((num3 != null) ? new double?((double)num3.GetValueOrDefault()) : null) * (double)1000).Value;
			}
		}
		return -1f;
	}

	// Token: 0x0601BF0D RID: 114445 RVA: 0x007C153C File Offset: 0x007BF73C
	protected void CheckAutoExitCurrentSpline()
	{
		if (this.CurrentSplineMoveParams.AutoExitSplineDist <= 0f)
		{
			return;
		}
		USplineComponent spline = this.CurrentSplineMoveParams.Spline;
		float distanceAlongSplineAtSplineInputKey = spline.GetDistanceAlongSplineAtSplineInputKey(this.SplineTimeKey);
		if (this.IsPositiveMoving)
		{
			float distanceAlongSplineAtSplineInputKey2 = spline.GetDistanceAlongSplineAtSplineInputKey((float)spline.GetNumberOfSplinePoints());
			if (distanceAlongSplineAtSplineInputKey > distanceAlongSplineAtSplineInputKey2 - this.CurrentSplineMoveParams.AutoExitSplineDist)
			{
				this.EndSplineMove(this.CurrentSplineMoveParams.Id);
				return;
			}
		}
		else if (distanceAlongSplineAtSplineInputKey < this.CurrentSplineMoveParams.AutoExitSplineDist)
		{
			this.EndSplineMove(this.CurrentSplineMoveParams.Id);
		}
	}

	// Token: 0x0601BF0E RID: 114446 RVA: 0x007C15CC File Offset: 0x007BF7CC
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseSplineMoveComponent baseSplineMoveComponent = (BaseSplineMoveComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (baseSplineMoveComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (baseSplineMoveComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DisableKey"))
		{
			this.DisableKey = baseSplineMoveComponent.DisableKey;
		}
		if (base.CanResetComponentProperty("SplineMoveParamsMap") && baseSplineMoveComponent.SplineMoveParamsMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, SplineMoveParams>>(this.SplineMoveParamsMap), "SplineMoveParamsMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SplineStack") && baseSplineMoveComponent.SplineStack != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<int>>(this.SplineStack), "SplineStack"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CurrentSplineMoveParamsInternal"))
		{
			if (baseSplineMoveComponent.CurrentSplineMoveParamsInternal == null)
			{
				this.CurrentSplineMoveParamsInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SplineMoveParams>(this.CurrentSplineMoveParamsInternal), "CurrentSplineMoveParamsInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsPositiveMovingInternal"))
		{
			this.IsPositiveMovingInternal = baseSplineMoveComponent.IsPositiveMovingInternal;
		}
		if (base.CanResetComponentProperty("SplineTimeKey"))
		{
			this.SplineTimeKey = baseSplineMoveComponent.SplineTimeKey;
		}
		if (base.CanResetComponentProperty("SplineDirection"))
		{
			if (baseSplineMoveComponent.SplineDirection == null)
			{
				this.SplineDirection = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.SplineDirection), "SplineDirection"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SplineLocation"))
		{
			if (baseSplineMoveComponent.SplineLocation == null)
			{
				this.SplineLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.SplineLocation), "SplineLocation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SplineQuat"))
		{
			if (baseSplineMoveComponent.SplineQuat == null)
			{
				this.SplineQuat = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.SplineQuat), "SplineQuat"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LastTimeKey"))
		{
			this.LastTimeKey = baseSplineMoveComponent.LastTimeKey;
		}
		if (base.CanResetComponentProperty("LastSplineLocation"))
		{
			if (baseSplineMoveComponent.LastSplineLocation == null)
			{
				this.LastSplineLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.LastSplineLocation), "LastSplineLocation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LastSplineDirection"))
		{
			if (baseSplineMoveComponent.LastSplineDirection == null)
			{
				this.LastSplineDirection = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.LastSplineDirection), "LastSplineDirection"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("Using3d"))
		{
			this.Using3d = baseSplineMoveComponent.Using3d;
		}
		if (base.CanResetComponentProperty("AllowInherit"))
		{
			this.AllowInherit = baseSplineMoveComponent.AllowInherit;
		}
		if (base.CanResetComponentProperty("InheritThisFrame"))
		{
			this.InheritThisFrame = baseSplineMoveComponent.InheritThisFrame;
		}
		if (base.CanResetComponentProperty("LastLocation"))
		{
			if (baseSplineMoveComponent.LastLocation == null)
			{
				this.LastLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.LastLocation), "LastLocation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TargetLocation"))
		{
			if (baseSplineMoveComponent.TargetLocation == null)
			{
				this.TargetLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TargetLocation), "TargetLocation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OffsetVector"))
		{
			if (baseSplineMoveComponent.OffsetVector == null)
			{
				this.OffsetVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.OffsetVector), "OffsetVector"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TmpVector"))
		{
			if (baseSplineMoveComponent.TmpVector == null)
			{
				this.TmpVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector), "TmpVector"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TmpVector1"))
		{
			if (baseSplineMoveComponent.TmpVector1 == null)
			{
				this.TmpVector1 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector1), "TmpVector1"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TmpVector2"))
		{
			if (baseSplineMoveComponent.TmpVector2 == null)
			{
				this.TmpVector2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector2), "TmpVector2"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TmpQuat"))
		{
			if (baseSplineMoveComponent.TmpQuat == null)
			{
				this.TmpQuat = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat), "TmpQuat"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TmpQuat1"))
		{
			if (baseSplineMoveComponent.TmpQuat1 == null)
			{
				this.TmpQuat1 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat1), "TmpQuat1"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TmpRotator"))
		{
			if (baseSplineMoveComponent.TmpRotator == null)
			{
				this.TmpRotator = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TmpRotator), "TmpRotator"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CacheNeedUpdateSplineGravityLeave"))
		{
			this.CacheNeedUpdateSplineGravityLeave = baseSplineMoveComponent.CacheNeedUpdateSplineGravityLeave;
		}
		return true;
	}

	// Token: 0x0400DCA2 RID: 56482
	public const int INVALID_TIME_KEY = -1;

	// Token: 0x0400DCA3 RID: 56483
	public const int AUTO_PILOT_ROUTE_ID = -1;

	// Token: 0x0400DCA4 RID: 56484
	[Nullable(2)]
	protected BaseActorComponent ActorComp;

	// Token: 0x0400DCA5 RID: 56485
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x0400DCA6 RID: 56486
	protected int? DisableKey;

	// Token: 0x0400DCA7 RID: 56487
	protected readonly Dictionary<int, SplineMoveParams> SplineMoveParamsMap = new Dictionary<int, SplineMoveParams>();

	// Token: 0x0400DCA8 RID: 56488
	protected readonly List<int> SplineStack = new List<int>();

	// Token: 0x0400DCA9 RID: 56489
	[Nullable(2)]
	protected SplineMoveParams CurrentSplineMoveParamsInternal;

	// Token: 0x0400DCAA RID: 56490
	private bool IsPositiveMovingInternal = true;

	// Token: 0x0400DCAB RID: 56491
	public float SplineTimeKey;

	// Token: 0x0400DCAC RID: 56492
	public Vector SplineDirection = Vector.Create();

	// Token: 0x0400DCAD RID: 56493
	public Vector SplineLocation = Vector.Create();

	// Token: 0x0400DCAE RID: 56494
	protected Quat SplineQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400DCAF RID: 56495
	protected float LastTimeKey = -1f;

	// Token: 0x0400DCB0 RID: 56496
	protected Vector LastSplineLocation = Vector.Create();

	// Token: 0x0400DCB1 RID: 56497
	protected Vector LastSplineDirection = Vector.Create();

	// Token: 0x0400DCB2 RID: 56498
	protected bool Using3d;

	// Token: 0x0400DCB3 RID: 56499
	protected bool AllowInherit;

	// Token: 0x0400DCB4 RID: 56500
	protected bool InheritThisFrame;

	// Token: 0x0400DCB5 RID: 56501
	protected Vector LastLocation = Vector.Create();

	// Token: 0x0400DCB6 RID: 56502
	protected Vector TargetLocation = Vector.Create();

	// Token: 0x0400DCB7 RID: 56503
	protected Vector OffsetVector = Vector.Create();

	// Token: 0x0400DCB8 RID: 56504
	protected Vector TmpVector = Vector.Create();

	// Token: 0x0400DCB9 RID: 56505
	protected Vector TmpVector1 = Vector.Create();

	// Token: 0x0400DCBA RID: 56506
	protected Vector TmpVector2 = Vector.Create();

	// Token: 0x0400DCBB RID: 56507
	protected Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400DCBC RID: 56508
	protected Quat TmpQuat1 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400DCBD RID: 56509
	protected Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400DCBE RID: 56510
	private bool CacheNeedUpdateSplineGravityLeave;
}
