using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

// Token: 0x020027E1 RID: 10209
[NullableContext(1)]
[Nullable(0)]
public class BaseSplineMoveComponent : EntityComponent
{
	// Token: 0x17002924 RID: 10532
	// (get) Token: 0x06019AC7 RID: 105159 RVA: 0x007E7B17 File Offset: 0x007E5D17
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

	// Token: 0x17002925 RID: 10533
	// (get) Token: 0x06019AC8 RID: 105160 RVA: 0x007E7B2E File Offset: 0x007E5D2E
	[Nullable(2)]
	public SplineMoveParams CurrentSplineMoveParams
	{
		[NullableContext(2)]
		get
		{
			return this.CurrentSplineMoveParamsInternal;
		}
	}

	// Token: 0x17002926 RID: 10534
	// (get) Token: 0x06019AC9 RID: 105161 RVA: 0x007E7B36 File Offset: 0x007E5D36
	// (set) Token: 0x06019ACA RID: 105162 RVA: 0x007E7B3E File Offset: 0x007E5D3E
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

	// Token: 0x06019ACB RID: 105163 RVA: 0x007E7B57 File Offset: 0x007E5D57
	protected virtual void OnPositiveMovingChanged()
	{
	}

	// Token: 0x06019ACC RID: 105164 RVA: 0x007E7B5C File Offset: 0x007E5D5C
	protected override bool OnStart()
	{
		this.DisableKey = new int?(base.Disable("[SplineMoveComponent.OnStart] 默认Disable"));
		this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.TeleportChangeLocation, new Action(this.OnTeleportWrapper));
		return true;
	}

	// Token: 0x06019ACD RID: 105165 RVA: 0x007E7BC4 File Offset: 0x007E5DC4
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

	// Token: 0x06019ACE RID: 105166 RVA: 0x007E7C9B File Offset: 0x007E5E9B
	protected override bool OnEnd()
	{
		this.ClearSplineMoveParams();
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.TeleportChangeLocation, new Action(this.OnTeleportWrapper));
		return true;
	}

	// Token: 0x06019ACF RID: 105167 RVA: 0x007E7CC8 File Offset: 0x007E5EC8
	protected virtual void PositionAdjust(float timeKey, float deltaSeconds)
	{
		ESplineMovePattern currentSplineMoveType = this.CurrentSplineMoveType;
		if (currentSplineMoveType <= ESplineMovePattern.SlideTrack)
		{
			this.PositionAdjustCommon(timeKey, deltaSeconds);
		}
	}

	// Token: 0x06019AD0 RID: 105168 RVA: 0x007E7CE8 File Offset: 0x007E5EE8
	protected virtual void PositionAdjustCommon(float timeKey, float deltaSeconds)
	{
		this.TargetLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.CheckAndLimitOnlyForwardMove();
		this.LimitMaxMove();
		this.MoveToTargetLocation(deltaSeconds);
	}

	// Token: 0x06019AD1 RID: 105169 RVA: 0x007E7D14 File Offset: 0x007E5F14
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

	// Token: 0x06019AD2 RID: 105170 RVA: 0x007E7E94 File Offset: 0x007E6094
	protected virtual void MoveToTargetLocation(float deltaSeconds)
	{
		if (Vector.DistSquared(this.ActorComp.ActorLocationProxy, this.TargetLocation) <= 1E-08)
		{
			return;
		}
		this.ActorComp.SetActorLocation(this.TargetLocation.ToUeVector(false), "样条移动", false);
	}

	// Token: 0x06019AD3 RID: 105171 RVA: 0x007E7EE4 File Offset: 0x007E60E4
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

	// Token: 0x06019AD4 RID: 105172 RVA: 0x007E7F8F File Offset: 0x007E618F
	protected virtual void InputAdjust()
	{
	}

	// Token: 0x06019AD5 RID: 105173 RVA: 0x007E7F94 File Offset: 0x007E6194
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

	// Token: 0x06019AD6 RID: 105174 RVA: 0x007E7FD0 File Offset: 0x007E61D0
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

	// Token: 0x06019AD7 RID: 105175 RVA: 0x007E8050 File Offset: 0x007E6250
	public void StartSplineMoveWithAutoPilotRoute(UAutopilotRoute autoPilotRoute)
	{
		SplineMoveParams splineMoveParams = new SplineMoveParams();
		splineMoveParams.InitByAutoPilotRoute(autoPilotRoute, base.Entity);
		this.StartSplineMoveInternal(splineMoveParams);
	}

	// Token: 0x06019AD8 RID: 105176 RVA: 0x007E8078 File Offset: 0x007E6278
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

	// Token: 0x06019AD9 RID: 105177 RVA: 0x007E8160 File Offset: 0x007E6360
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

	// Token: 0x06019ADA RID: 105178 RVA: 0x007E822A File Offset: 0x007E642A
	public void EndSplineMoveForAutoPilot()
	{
		this.EndSplineMove(-1);
	}

	// Token: 0x06019ADB RID: 105179 RVA: 0x007E8233 File Offset: 0x007E6433
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

	// Token: 0x06019ADC RID: 105180 RVA: 0x007E826B File Offset: 0x007E646B
	public virtual bool IsPlannerMove()
	{
		return true;
	}

	// Token: 0x06019ADD RID: 105181 RVA: 0x007E826E File Offset: 0x007E646E
	protected virtual bool StartMoveConditionCheck(int id, ISplineMovePattern config)
	{
		return this.SplineStack.Count <= 0 || this.SplineStack[this.SplineStack.Count - 1] != id;
	}

	// Token: 0x06019ADE RID: 105182 RVA: 0x007E829C File Offset: 0x007E649C
	protected virtual bool EndMoveConditionCheck(int id)
	{
		return this.SplineMoveParamsMap.ContainsKey(id);
	}

	// Token: 0x06019ADF RID: 105183 RVA: 0x007E82B0 File Offset: 0x007E64B0
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

	// Token: 0x06019AE0 RID: 105184 RVA: 0x007E8343 File Offset: 0x007E6543
	protected void AddSplineMoveParams(int id, SplineMoveParams config)
	{
		if (!this.SplineMoveParamsMap.ContainsKey(id))
		{
			config.EnableParams(true);
			this.SplineMoveParamsMap[id] = config;
		}
		this.SplineStack.Add(id);
	}

	// Token: 0x06019AE1 RID: 105185 RVA: 0x007E8374 File Offset: 0x007E6574
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

	// Token: 0x06019AE2 RID: 105186 RVA: 0x007E83FC File Offset: 0x007E65FC
	protected void ClearSplineMoveParams()
	{
		foreach (int splineId in this.SplineMoveParamsMap.Keys)
		{
			GameSplineModel.Instance.ReleaseSpline(splineId, (long)base.Entity.Id, EIdType.EntityId);
		}
		this.SplineMoveParamsMap.Clear();
		this.SplineStack.Clear();
	}

	// Token: 0x06019AE3 RID: 105187 RVA: 0x007E847C File Offset: 0x007E667C
	protected virtual void OnSplineMoveEnable(int id, SplineMoveParams config)
	{
	}

	// Token: 0x06019AE4 RID: 105188 RVA: 0x007E847E File Offset: 0x007E667E
	protected virtual void OnSplineMoveDisable()
	{
	}

	// Token: 0x06019AE5 RID: 105189 RVA: 0x007E8480 File Offset: 0x007E6680
	protected virtual void OnSelectNextSplineMoveBegin()
	{
		SplineMoveParams currentSplineMoveParams = this.CurrentSplineMoveParams;
		this.CacheNeedUpdateSplineGravityLeave = (currentSplineMoveParams != null && currentSplineMoveParams.UseSplineGravity);
	}

	// Token: 0x06019AE6 RID: 105190 RVA: 0x007E849C File Offset: 0x007E669C
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

	// Token: 0x06019AE7 RID: 105191 RVA: 0x007E8518 File Offset: 0x007E6718
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

	// Token: 0x06019AE8 RID: 105192 RVA: 0x007E86E8 File Offset: 0x007E68E8
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

	// Token: 0x06019AE9 RID: 105193 RVA: 0x007E8779 File Offset: 0x007E6979
	protected void OnTeleportWrapper()
	{
		if (this.SplineMoveParamsMap.Count == 0 && this.SplineStack.Count == 0)
		{
			return;
		}
		this.OnTeleportChangeLocation();
	}

	// Token: 0x06019AEA RID: 105194 RVA: 0x007E879C File Offset: 0x007E699C
	protected void OnTeleportChangeLocation()
	{
		this.LastLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.LastSplineDirection.DeepCopy(this.SplineDirection);
		this.LastSplineLocation.DeepCopy(this.SplineLocation);
		this.LastTimeKey = -1f;
	}

	// Token: 0x06019AEB RID: 105195 RVA: 0x007E87EC File Offset: 0x007E69EC
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

	// Token: 0x06019AEC RID: 105196 RVA: 0x007E89AC File Offset: 0x007E6BAC
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

	// Token: 0x06019AED RID: 105197 RVA: 0x007E8ACC File Offset: 0x007E6CCC
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

	// Token: 0x06019AEE RID: 105198 RVA: 0x007E8B5C File Offset: 0x007E6D5C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseSplineMoveComponent baseSplineMoveComponent = (BaseSplineMoveComponent)componentTemplate;
		if (baseSplineMoveComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (baseSplineMoveComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		this.DisableKey = baseSplineMoveComponent.DisableKey;
		if (baseSplineMoveComponent.SplineMoveParamsMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplineMoveParamsMap), "SplineMoveParamsMap"))
		{
			return false;
		}
		if (baseSplineMoveComponent.SplineStack != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplineStack), "SplineStack"))
		{
			return false;
		}
		if (baseSplineMoveComponent.CurrentSplineMoveParamsInternal == null)
		{
			this.CurrentSplineMoveParamsInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentSplineMoveParamsInternal), "CurrentSplineMoveParamsInternal"))
		{
			return false;
		}
		this.IsPositiveMovingInternal = baseSplineMoveComponent.IsPositiveMovingInternal;
		this.SplineTimeKey = baseSplineMoveComponent.SplineTimeKey;
		if (baseSplineMoveComponent.SplineDirection == null)
		{
			this.SplineDirection = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplineDirection), "SplineDirection"))
		{
			return false;
		}
		if (baseSplineMoveComponent.SplineLocation == null)
		{
			this.SplineLocation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplineLocation), "SplineLocation"))
		{
			return false;
		}
		if (baseSplineMoveComponent.SplineQuat == null)
		{
			this.SplineQuat = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplineQuat), "SplineQuat"))
		{
			return false;
		}
		this.LastTimeKey = baseSplineMoveComponent.LastTimeKey;
		if (baseSplineMoveComponent.LastSplineLocation == null)
		{
			this.LastSplineLocation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastSplineLocation), "LastSplineLocation"))
		{
			return false;
		}
		if (baseSplineMoveComponent.LastSplineDirection == null)
		{
			this.LastSplineDirection = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastSplineDirection), "LastSplineDirection"))
		{
			return false;
		}
		this.Using3d = baseSplineMoveComponent.Using3d;
		this.AllowInherit = baseSplineMoveComponent.AllowInherit;
		this.InheritThisFrame = baseSplineMoveComponent.InheritThisFrame;
		if (baseSplineMoveComponent.LastLocation == null)
		{
			this.LastLocation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastLocation), "LastLocation"))
		{
			return false;
		}
		if (baseSplineMoveComponent.TargetLocation == null)
		{
			this.TargetLocation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetLocation), "TargetLocation"))
		{
			return false;
		}
		if (baseSplineMoveComponent.OffsetVector == null)
		{
			this.OffsetVector = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OffsetVector), "OffsetVector"))
		{
			return false;
		}
		if (baseSplineMoveComponent.TmpVector == null)
		{
			this.TmpVector = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector), "TmpVector"))
		{
			return false;
		}
		if (baseSplineMoveComponent.TmpVector1 == null)
		{
			this.TmpVector1 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector1), "TmpVector1"))
		{
			return false;
		}
		if (baseSplineMoveComponent.TmpVector2 == null)
		{
			this.TmpVector2 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector2), "TmpVector2"))
		{
			return false;
		}
		if (baseSplineMoveComponent.TmpQuat == null)
		{
			this.TmpQuat = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpQuat), "TmpQuat"))
		{
			return false;
		}
		if (baseSplineMoveComponent.TmpQuat1 == null)
		{
			this.TmpQuat1 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpQuat1), "TmpQuat1"))
		{
			return false;
		}
		if (baseSplineMoveComponent.TmpRotator == null)
		{
			this.TmpRotator = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpRotator), "TmpRotator"))
		{
			return false;
		}
		this.CacheNeedUpdateSplineGravityLeave = baseSplineMoveComponent.CacheNeedUpdateSplineGravityLeave;
		return true;
	}

	// Token: 0x17002927 RID: 10535
	// (get) Token: 0x06019AEF RID: 105199 RVA: 0x007E8EFB File Offset: 0x007E70FB
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002928 RID: 10536
	// (get) Token: 0x06019AF0 RID: 105200 RVA: 0x007E8EFE File Offset: 0x007E70FE
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002929 RID: 10537
	// (get) Token: 0x06019AF1 RID: 105201 RVA: 0x007E8F01 File Offset: 0x007E7101
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E141 RID: 57665
	public const int INVALID_TIME_KEY = -1;

	// Token: 0x0400E142 RID: 57666
	public const int AUTO_PILOT_ROUTE_ID = -1;

	// Token: 0x0400E143 RID: 57667
	[Nullable(2)]
	protected BaseActorComponent ActorComp;

	// Token: 0x0400E144 RID: 57668
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x0400E145 RID: 57669
	protected int? DisableKey;

	// Token: 0x0400E146 RID: 57670
	protected readonly Dictionary<int, SplineMoveParams> SplineMoveParamsMap = new Dictionary<int, SplineMoveParams>();

	// Token: 0x0400E147 RID: 57671
	protected readonly List<int> SplineStack = new List<int>();

	// Token: 0x0400E148 RID: 57672
	[Nullable(2)]
	protected SplineMoveParams CurrentSplineMoveParamsInternal;

	// Token: 0x0400E149 RID: 57673
	private bool IsPositiveMovingInternal = true;

	// Token: 0x0400E14A RID: 57674
	public float SplineTimeKey;

	// Token: 0x0400E14B RID: 57675
	public Vector SplineDirection = Vector.Create();

	// Token: 0x0400E14C RID: 57676
	public Vector SplineLocation = Vector.Create();

	// Token: 0x0400E14D RID: 57677
	protected Quat SplineQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E14E RID: 57678
	protected float LastTimeKey = -1f;

	// Token: 0x0400E14F RID: 57679
	protected Vector LastSplineLocation = Vector.Create();

	// Token: 0x0400E150 RID: 57680
	protected Vector LastSplineDirection = Vector.Create();

	// Token: 0x0400E151 RID: 57681
	protected bool Using3d;

	// Token: 0x0400E152 RID: 57682
	protected bool AllowInherit;

	// Token: 0x0400E153 RID: 57683
	protected bool InheritThisFrame;

	// Token: 0x0400E154 RID: 57684
	protected Vector LastLocation = Vector.Create();

	// Token: 0x0400E155 RID: 57685
	protected Vector TargetLocation = Vector.Create();

	// Token: 0x0400E156 RID: 57686
	protected Vector OffsetVector = Vector.Create();

	// Token: 0x0400E157 RID: 57687
	protected Vector TmpVector = Vector.Create();

	// Token: 0x0400E158 RID: 57688
	protected Vector TmpVector1 = Vector.Create();

	// Token: 0x0400E159 RID: 57689
	protected Vector TmpVector2 = Vector.Create();

	// Token: 0x0400E15A RID: 57690
	protected Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E15B RID: 57691
	protected Quat TmpQuat1 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E15C RID: 57692
	protected Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400E15D RID: 57693
	private bool CacheNeedUpdateSplineGravityLeave;
}
