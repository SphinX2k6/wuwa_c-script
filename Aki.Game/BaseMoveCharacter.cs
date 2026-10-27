using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.MonsterGroup;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x020030EA RID: 12522
[NullableContext(1)]
[Nullable(0)]
public class BaseMoveCharacter
{
	// Token: 0x170024EF RID: 9455
	// (get) Token: 0x0601AD5D RID: 109917 RVA: 0x0073ED6F File Offset: 0x0073CF6F
	public global::Vector CurrentToLocation
	{
		get
		{
			return this.PointsLogic.TargetPoint.Position;
		}
	}

	// Token: 0x0601AD5E RID: 109918 RVA: 0x0073ED84 File Offset: 0x0073CF84
	public void Init(Entity entity)
	{
		this.Entity = entity;
		this.ActorComp = this.Entity.GetComponent<CharacterActorComponent>();
		this.UnifiedComp = this.Entity.GetComponent<BaseUnifiedStateComponent>();
		this.AiComp = this.Entity.GetComponent<CharacterAiComponent>();
		this.PbDataId = this.ActorComp.CreatureData.GetPbDataId();
		this.CachePath = new List<global::Vector>();
		this.Moving = false;
		this.PointsLogic.Init(this.ActorComp);
		this.MoveLogic.Init(this.Entity);
		if (!EventSystem.Instance.HasWithTarget<global::ECharPositionState, global::ECharPositionState>(this.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChange)))
		{
			EventSystem.Instance.AddWithTarget<global::ECharPositionState, global::ECharPositionState>(this.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChange));
		}
	}

	// Token: 0x0601AD5F RID: 109919 RVA: 0x0073EE5C File Offset: 0x0073D05C
	public void UpdateMove(float deltaSeconds)
	{
		if (!this.IsRunning)
		{
			return;
		}
		if (this.PointsLogic.TargetPoint == null)
		{
			this.MoveEnd(ELevelEventState.Failure);
			return;
		}
		this.DeltaTime += (double)deltaSeconds;
		if (this.DeltaTime > 1.0)
		{
			this.DeltaTime = 0.0;
			this.UpdateMoveStateAndSpeed();
		}
		if (GlobalData.IsPlayInEditor && MoveToLocationController.DebugDraw)
		{
			this.DrawDebug();
		}
		this.UpdateMoveInternal(deltaSeconds);
		if (this.AiComp != null && this.PointsLogic.FindNearestPointOnPath(this.CacheVector))
		{
			this.AiComp.HatredInitLocation.DeepCopy(this.CacheVector);
			foreach (CharacterAiComponent characterAiComponent in this.FollowerAiComps)
			{
				characterAiComponent.HatredInitLocation.DeepCopy(this.CacheVector);
			}
		}
	}

	// Token: 0x0601AD60 RID: 109920 RVA: 0x0073EF58 File Offset: 0x0073D158
	private unsafe void UpdateMoveInternal(float deltaSeconds)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3;
		if (!this.IsFly)
		{
			BaseUnifiedStateComponent unifiedComp = this.UnifiedComp;
			flag3 = (unifiedComp != null && unifiedComp.PositionState == global::ECharPositionState.Climb);
		}
		else
		{
			flag3 = true;
		}
		bool flag4 = flag3;
		bool flag5 = this.MoveLogic.UpdateMove(deltaSeconds);
		int num = 0;
		while (!flag5 && this.IsRunning && num < 2)
		{
			num++;
			flag2 = (flag2 || this.PointsLogic.TargetPoint.Index >= 0);
			this.OnArriveMovePoint();
			if (this.HandleArriveLastPoint(flag4, deltaSeconds))
			{
				return;
			}
			flag = true;
			if (!this.ChangeNextPoint())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "未能正常获取下个移动点，巡逻失败结束";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.MoveEnd(ELevelEventState.Failure);
				return;
			}
			MoveCharacterConfig moveConfig = this.MoveConfig;
			if (moveConfig != null && moveConfig.ResetAllPoints.GetValueOrDefault())
			{
				break;
			}
			flag5 = this.MoveLogic.UpdateMove(deltaSeconds);
		}
		if (!flag4 && this.MoveLogic.ResetLastPointCondition() && this.CheckResetCondition())
		{
			this.ResetLastPatrolPoint(deltaSeconds);
		}
		if (flag && flag2)
		{
			this.SyncToController();
		}
		if (this.ReturnTimeoutFailed && deltaSeconds > 0.0001f)
		{
			this.CheckTimeout(deltaSeconds, flag);
		}
	}

	// Token: 0x0601AD61 RID: 109921 RVA: 0x0073F0CC File Offset: 0x0073D2CC
	private bool HandleArriveLastPoint(bool climbOrFly, float deltaSeconds)
	{
		if (!this.PointsLogic.CheckMoveLastPoint())
		{
			return false;
		}
		bool flag = this.MoveLogic.ResetLastPointCondition();
		if (!climbOrFly && flag)
		{
			this.ResetLastPatrolPoint(deltaSeconds);
		}
		MoveCharacterConfig moveConfig = this.MoveConfig;
		if (moveConfig != null && moveConfig.EnablePlayerAccurateMoveToTarget.GetValueOrDefault())
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.ClearInput(false, true);
			}
			this.MoveLogic.ForceSetToLastPatrolPoint(this.CurrentToLocation, deltaSeconds);
			if (this.UnifiedComp.Valid && CharacterUnifiedStateTypes.LegalMoveStates.GetValueOrDefault(this.UnifiedComp.PositionState).Contains(global::ECharMoveState.Stand))
			{
				this.UnifiedComp.SetMoveState(global::ECharMoveState.Stand);
			}
		}
		MoveCharacterConfig moveConfig2 = this.MoveConfig;
		if (moveConfig2 == null || !moveConfig2.NoAsyncPoint.GetValueOrDefault())
		{
			this.SyncToController();
		}
		this.MoveEnd(ELevelEventState.Success);
		return true;
	}

	// Token: 0x0601AD62 RID: 109922 RVA: 0x0073F1A4 File Offset: 0x0073D3A4
	private void ResetLastPatrolPoint(float deltaSeconds)
	{
		this.MoveLogic.ResetLastPatrolPoint(deltaSeconds);
		this.CacheVector.DeepCopy(this.CurrentToLocation);
		this.CacheVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		if (!this.IsFly)
		{
			this.CacheVector.Z = 0.0;
		}
		this.CacheVector.Normalize(9.99999993922529E-09);
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.ClearInput(false, true);
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		if (actorComp2 != null)
		{
			actorComp2.SetInputDirect(this.CacheVector, false);
		}
		double inB = this.ActorComp.ActorVelocityProxy.Size();
		this.CacheVector.MultiplyEqual(inB);
		this.ActorComp.ActorVelocityProxy.Set(this.CacheVector.X, this.CacheVector.Y, this.CacheVector.Z);
		MoveCharacterConfig moveConfig = this.MoveConfig;
		if (moveConfig == null)
		{
			return;
		}
		Action onResetLocationCallback = moveConfig.OnResetLocationCallback;
		if (onResetLocationCallback == null)
		{
			return;
		}
		onResetLocationCallback();
	}

	// Token: 0x0601AD63 RID: 109923 RVA: 0x0073F2B0 File Offset: 0x0073D4B0
	private unsafe void CheckTimeout(float deltaSeconds, bool changePoint)
	{
		double num = global::Vector.Dist(this.ActorComp.ActorLocationProxy, this.CurrentToLocation);
		if (Math.Abs(this.LastFrameDistance - num) / (double)deltaSeconds > 30.0 || this.LastFrameDistance == 0.0 || changePoint)
		{
			this.CurTimeoutTime = this.TimeoutTime;
		}
		else
		{
			this.CurTimeoutTime -= (double)deltaSeconds;
			if (this.CurTimeoutTime <= 0.0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "检测到移动行为不符合预期,持续卡住超时,返回移动失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("超时时限", this.TimeoutTime);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.MoveEnd(ELevelEventState.Failure);
				return;
			}
		}
		this.LastFrameDistance = num;
	}

	// Token: 0x0601AD64 RID: 109924 RVA: 0x0073F3D8 File Offset: 0x0073D5D8
	private bool ChangeNextPoint()
	{
		if (this.UsePreLocation)
		{
			this.UsePreLocation = false;
		}
		return this.PointsLogic.ChangeToNextPoint() && this.GenerateMovePoint(this.PointsLogic.GetPreviousLocation(), this.PointsLogic.TargetPoint.Position, this.Navigation, false);
	}

	// Token: 0x0601AD65 RID: 109925 RVA: 0x0073F42C File Offset: 0x0073D62C
	private bool CheckResetCondition()
	{
		MoveCharacterConfig moveConfig = this.MoveConfig;
		if (moveConfig != null && moveConfig.ResetAllPoints.GetValueOrDefault())
		{
			return true;
		}
		global::Vector previousLocation = this.PointsLogic.GetPreviousLocation();
		if (previousLocation == null)
		{
			return false;
		}
		this.CacheVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.CacheVector.SubtractionEqual(previousLocation);
		if (!this.IsFly)
		{
			this.CacheVector.Z = 0.0;
		}
		double num = this.CacheVector.Size();
		this.CacheVector2.DeepCopy(this.CurrentToLocation);
		this.CacheVector2.SubtractionEqual(previousLocation);
		if (!this.IsFly)
		{
			this.CacheVector2.Z = 0.0;
		}
		double num2 = this.CacheVector2.Size();
		if (num == 0.0 || num2 == 0.0)
		{
			return false;
		}
		double d = this.CacheVector.DotProduct(this.CacheVector2) / (num * num2);
		double num3 = 57.295780181884766 * Math.Acos(d);
		this.CacheVector.CrossProduct(this.CacheVector2, this.CacheVector);
		double num4 = this.CacheVector.Size() / num2;
		return num3 <= 0.0 || num3 >= 20.0 || num4 >= 50.0;
	}

	// Token: 0x0601AD66 RID: 109926 RVA: 0x0073F588 File Offset: 0x0073D788
	public void StopMove()
	{
		if (!this.IsRunning)
		{
			return;
		}
		this.ActorComp.ClearInput(false, true);
		this.PointsLogic.UpdatePreIndex();
		this.StopMoveInternal();
	}

	// Token: 0x0601AD67 RID: 109927 RVA: 0x0073F5B2 File Offset: 0x0073D7B2
	public void Dispose()
	{
		this.StopMoveInternal();
	}

	// Token: 0x0601AD68 RID: 109928 RVA: 0x0073F5BC File Offset: 0x0073D7BC
	private void StopMoveInternal()
	{
		this.MoveLogic.StopMove();
		this.CachePath = new List<global::Vector>();
		this.Moving = false;
		this.UsePreLocation = true;
		this.PreLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		if (this.Entity != null && EventSystem.Instance.HasWithTarget<global::ECharPositionState, global::ECharPositionState>(this.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChange)))
		{
			EventSystem.Instance.RemoveWithTarget<global::ECharPositionState, global::ECharPositionState>(this.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChange));
		}
	}

	// Token: 0x0601AD69 RID: 109929 RVA: 0x0073F650 File Offset: 0x0073D850
	public unsafe void MoveAlongPath(MoveCharacterConfig config)
	{
		if (this.ActorComp == null)
		{
			Entity entity = this.Entity;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[BaseMoveCharacter.MoveAlongPath]获取ActorComp失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.Moving = true;
		this.MoveConfig = config;
		this.TurnSpeed = config.TurnSpeed.GetValueOrDefault(360f);
		this.Navigation = (config.Navigation && !config.IsFly);
		this.Distance = config.Distance.GetValueOrDefault(30f);
		this.OnMoveEndCallback = config.Callback;
		if (config.ReturnTimeoutFailed != null && config.ReturnTimeoutFailed.Value != 0f)
		{
			this.ReturnTimeoutFailed = true;
			this.TimeoutTime = (double)config.ReturnTimeoutFailed.Value;
			this.CurTimeoutTime = (double)config.ReturnTimeoutFailed.Value;
		}
		else
		{
			this.ReturnTimeoutFailed = false;
		}
		this.PointsLogic.UpdateMovePoints(config);
		CharacterAiComponent aiComp = this.AiComp;
		if (aiComp != null)
		{
			aiComp.InitPathMovePoints(config);
		}
		MonsterPatrolInfo monsterInfoByEntityId = MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.Entity.Id);
		this.FollowerAiComps.Clear();
		if (((monsterInfoByEntityId != null) ? monsterInfoByEntityId.Group : null) != null && monsterInfoByEntityId.Group.GroupInfo.Count > 0)
		{
			foreach (MonsterPatrolInfo monsterPatrolInfo in monsterInfoByEntityId.Group.GroupInfo.Values)
			{
				if (!monsterPatrolInfo.IsCaptain)
				{
					CharacterAiComponent component = EntitySystem.Instance.GetComponent<CharacterAiComponent>(monsterPatrolInfo.EntityId);
					if (component != null)
					{
						component.InitPathMovePoints(config);
						this.FollowerAiComps.Add(component);
					}
				}
			}
		}
		MoveCharacterPoint targetPoint = this.PointsLogic.TargetPoint;
		this.IsFly = ((targetPoint != null && targetPoint.PosState.GetValueOrDefault() == global::ECharPositionState.Air) || config.IsFly);
		this.UpdateMoveStateAndSpeed();
		double num = global::Vector.Dist2D(this.PreLocation, this.ActorComp.ActorLocationProxy);
		bool flag;
		if (config.UsePreviousIndex.GetValueOrDefault() && this.UsePreLocation && num > (double)this.Distance)
		{
			flag = this.GenerateMovePoint(this.PreLocation, this.PointsLogic.TargetPoint.Position, num > 200.0 || this.Navigation, true);
		}
		else
		{
			this.UsePreLocation = false;
			flag = this.GenerateMovePoint(null, this.PointsLogic.TargetPoint.Position, this.Navigation || config.NavigateToStartPos.GetValueOrDefault(), true);
		}
		if (!flag)
		{
			this.MoveEnd(ELevelEventState.Failure);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "未正常生成寻路路径，巡逻失败结束";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0601AD6A RID: 109930 RVA: 0x0073F9A8 File Offset: 0x0073DBA8
	public void MoveEnd(ELevelEventState endState)
	{
		this.UsePreLocation = false;
		this.StopMove();
		this.PointsLogic.Reset();
		this.OnMoveActionEnd(endState);
		if (this.PlayerWalkState)
		{
			this.SetPlayerWalkOrRun(global::ECharMoveState.Run);
			this.PlayerWalkState = false;
		}
	}

	// Token: 0x0601AD6B RID: 109931 RVA: 0x0073F9EC File Offset: 0x0073DBEC
	private bool GenerateMovePoint([Nullable(2)] global::Vector start, global::Vector end, bool navigation, bool selfPos)
	{
		this.MovePath = new List<global::Vector>();
		if (selfPos || start == null)
		{
			this.CacheMovePoint.DeepCopy(this.ActorComp.LastActorLocation);
			if (!this.IsFly)
			{
				this.CacheMovePoint.Z -= (double)this.ActorComp.HalfHeight;
			}
			this.MovePath.Add(this.CacheMovePoint);
		}
		if (start != null)
		{
			this.MovePath.Add(start);
		}
		this.MovePath.Add(end);
		if (!navigation)
		{
			this.MoveLogic.UpdateMovePath(this.MovePath, this.IsFly, this.TurnSpeed, this.Distance);
			return true;
		}
		this.NavigationPath = new List<global::Vector>();
		this.NavigationPath.Add(this.MovePath[0]);
		for (int i = 0; i < this.MovePath.Count - 1; i++)
		{
			this.CachePath = new List<global::Vector>();
			if (global::Vector.Dist2D(this.MovePath[i], this.MovePath[i + 1]) < (double)this.Distance)
			{
				this.NavigationPath.Add(this.MovePath[i + 1]);
			}
			else if (this.AddNavigationPath(this.MovePath[i], this.MovePath[i + 1], this.CachePath))
			{
				for (int j = 1; j < this.CachePath.Count; j++)
				{
					this.NavigationPath.Add(this.CachePath[j]);
				}
			}
			else
			{
				MoveCharacterConfig moveConfig = this.MoveConfig;
				if (moveConfig != null && moveConfig.ReturnFalseWhenNavigationFailed)
				{
					return false;
				}
				this.NavigationPath.Add(this.MovePath[i + 1]);
			}
		}
		this.MoveLogic.UpdateMovePath(this.NavigationPath, this.IsFly, this.TurnSpeed, this.Distance);
		return true;
	}

	// Token: 0x0601AD6C RID: 109932 RVA: 0x0073FBD8 File Offset: 0x0073DDD8
	private bool AddNavigationPath(global::Vector start, global::Vector end, List<global::Vector> outPath)
	{
		UObject world = this.ActorComp.Owner.GetWorld();
		FVectorDouble from = start.ToUeVector(false);
		FVectorDouble to = end.ToUeVector(false);
		bool? ignoreZ = new bool?(false);
		MoveCharacterConfig moveConfig = this.MoveConfig;
		return AiControllerLibrary.NavigationFindPath(world, from, to, outPath, ignoreZ, (moveConfig != null) ? moveConfig.StrictNavigation : null) && outPath.Count > 0;
	}

	// Token: 0x0601AD6D RID: 109933 RVA: 0x0073FC36 File Offset: 0x0073DE36
	private void OnMoveActionEnd(ELevelEventState result)
	{
		if (this.OnMoveEndCallback != null)
		{
			this.OnMoveEndCallback(result);
		}
	}

	// Token: 0x0601AD6E RID: 109934 RVA: 0x0073FC4C File Offset: 0x0073DE4C
	public void PushMoveInfo()
	{
		EntitySimplyMoveInfoPackagePush entitySimplyMoveInfoPackagePush = EntitySimplyMoveInfoPackagePush.Create();
		EntitySimplyMoveInfo entitySimplyMoveInfo = EntitySimplyMoveInfo.Create();
		entitySimplyMoveInfo.EntityId = MathUtils.Instance.NumberToLong(this.ActorComp.CreatureData.GetCreatureDataId());
		entitySimplyMoveInfo.Location = Aki.Protocol.Vector.Create();
		entitySimplyMoveInfo.Location.X = (float)this.ActorComp.ActorLocationProxy.X;
		entitySimplyMoveInfo.Location.Y = (float)this.ActorComp.ActorLocationProxy.Y;
		entitySimplyMoveInfo.Location.Z = (float)this.ActorComp.ActorLocationProxy.Z;
		entitySimplyMoveInfo.Rotation = null;
		entitySimplyMoveInfoPackagePush.MoveInfos.Add(entitySimplyMoveInfo);
		Net.Instance.Send(EPushMessageId.EntitySimplyMoveInfoPackagePush, entitySimplyMoveInfoPackagePush);
	}

	// Token: 0x0601AD6F RID: 109935 RVA: 0x0073FD08 File Offset: 0x0073DF08
	private void OnArriveMovePoint()
	{
		this.UpdateMoveStateAndSpeed();
		this.PointsLogic.OnArriveMovePoint();
		MoveCharacterPoint targetPoint = this.PointsLogic.TargetPoint;
		if (targetPoint != null && targetPoint.PosState != null)
		{
			MoveCharacterPoint targetPoint2 = this.PointsLogic.TargetPoint;
			this.IsFly = (targetPoint2 != null && targetPoint2.PosState.GetValueOrDefault() == global::ECharPositionState.Air);
		}
	}

	// Token: 0x0601AD70 RID: 109936 RVA: 0x0073FD69 File Offset: 0x0073DF69
	private void SyncToController()
	{
		MoveCharacterConfig moveConfig = this.MoveConfig;
		if (moveConfig != null && moveConfig.NoAsyncPoint.GetValueOrDefault())
		{
			return;
		}
		BaseMoveComponent component = this.Entity.GetComponent<BaseMoveComponent>();
		if (component == null)
		{
			return;
		}
		component.MoveController.PushMoveInfo();
	}

	// Token: 0x0601AD71 RID: 109937 RVA: 0x0073FDA0 File Offset: 0x0073DFA0
	private void OnPositionStateChange(global::ECharPositionState oldPositionState, global::ECharPositionState newPositionState)
	{
		if (this.PointsLogic.TargetPoint == null)
		{
			return;
		}
		global::ECharMoveState? moveState = this.GetMoveState(this.PointsLogic.TargetPoint.MoveState);
		if (moveState != null && CharacterUnifiedStateTypes.LegalMoveStates.GetValueOrDefault(newPositionState).Contains(moveState.Value))
		{
			this.UnifiedComp.SetMoveState(moveState.Value);
		}
	}

	// Token: 0x0601AD72 RID: 109938 RVA: 0x0073FE08 File Offset: 0x0073E008
	private void UpdateMoveStateAndSpeed()
	{
		if (this.PointsLogic.TargetPoint == null)
		{
			return;
		}
		BaseMoveComponent component = this.Entity.GetComponent<BaseMoveComponent>();
		if (component == null)
		{
			return;
		}
		float? moveSpeed = this.PointsLogic.TargetPoint.MoveSpeed;
		if (this.IsFly)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Flying,
					Context = "[BaseMoveCharacter.UpdateMoveStateAndSpeed]"
				});
			}
			if (moveSpeed != null && moveSpeed.Value != 0f)
			{
				component.SetMaxSpeed(moveSpeed.Value);
			}
			return;
		}
		if (moveSpeed != null && moveSpeed.Value != 0f)
		{
			component.SetMaxSpeed(moveSpeed.Value);
		}
		global::ECharMoveState? moveState = this.GetMoveState(this.PointsLogic.TargetPoint.MoveState);
		if (moveState != null && CharacterUnifiedStateTypes.LegalMoveStates.GetValueOrDefault(this.UnifiedComp.PositionState).Contains(moveState.Value))
		{
			if (moveState.Value == global::ECharMoveState.Walk || moveState.Value == global::ECharMoveState.Run)
			{
				this.SetPlayerWalkOrRun(moveState.Value);
			}
			this.UnifiedComp.SetMoveState(moveState.Value);
		}
	}

	// Token: 0x0601AD73 RID: 109939 RVA: 0x0073FF38 File Offset: 0x0073E138
	private void SetPlayerWalkOrRun(global::ECharMoveState state)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.IsRoleAndCtrlByMe)
		{
			return;
		}
		if (this.UnifiedComp is CharacterUnifiedStateComponent)
		{
			(this.UnifiedComp as CharacterUnifiedStateComponent).MarkWalkOrRun(state == global::ECharMoveState.Walk, true, null);
			this.PlayerWalkState = (state == global::ECharMoveState.Walk);
		}
	}

	// Token: 0x0601AD74 RID: 109940 RVA: 0x0073FF94 File Offset: 0x0073E194
	private global::ECharMoveState? GetMoveState(EPatrolMoveState? state)
	{
		if (state != null)
		{
			BaseUnifiedStateComponent unifiedComp = this.UnifiedComp;
			if (unifiedComp != null && unifiedComp.Valid)
			{
				switch (state.Value)
				{
				case EPatrolMoveState.Walk:
					if (this.UnifiedComp.PositionState == global::ECharPositionState.Water)
					{
						return new global::ECharMoveState?(global::ECharMoveState.NormalSwim);
					}
					if (this.UnifiedComp.PositionState == global::ECharPositionState.Climb)
					{
						return new global::ECharMoveState?(global::ECharMoveState.NormalClimb);
					}
					return new global::ECharMoveState?(global::ECharMoveState.Walk);
				case EPatrolMoveState.Run:
					if (this.UnifiedComp.PositionState == global::ECharPositionState.Water)
					{
						return new global::ECharMoveState?(global::ECharMoveState.FastSwim);
					}
					if (this.UnifiedComp.PositionState == global::ECharPositionState.Climb)
					{
						return new global::ECharMoveState?(global::ECharMoveState.FastClimb);
					}
					return new global::ECharMoveState?(global::ECharMoveState.Run);
				case EPatrolMoveState.Sprint:
					if (this.UnifiedComp.PositionState == global::ECharPositionState.Water)
					{
						return new global::ECharMoveState?(global::ECharMoveState.FastSwim);
					}
					if (this.UnifiedComp.PositionState == global::ECharPositionState.Climb)
					{
						return new global::ECharMoveState?(global::ECharMoveState.FastClimb);
					}
					return new global::ECharMoveState?(global::ECharMoveState.Sprint);
				}
			}
		}
		return null;
	}

	// Token: 0x0601AD75 RID: 109941 RVA: 0x00740088 File Offset: 0x0073E288
	private void DrawDebug()
	{
		if (this.PointsLogic.MovePoint.Count == 0 || !GlobalData.IsPlayInEditor)
		{
			return;
		}
		int segments = 10;
		int num = 30;
		for (int i = this.PointsLogic.MovePoint.Count - 1; i > -1; i--)
		{
			global::Vector position = this.PointsLogic.MovePoint[i].Position;
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, position.ToUeVector(false), (float)num, segments, new FLinearColor?((i == this.PointsLogic.TargetIndex) ? ColorUtils.LinearYellow : ColorUtils.LinearWhite), 1f, 0f);
		}
	}

	// Token: 0x170024F0 RID: 9456
	// (get) Token: 0x0601AD76 RID: 109942 RVA: 0x00740126 File Offset: 0x0073E326
	public bool IsRunning
	{
		get
		{
			return this.Moving;
		}
	}

	// Token: 0x0400CF54 RID: 53076
	private const int DEFAULT_TURN_SPEED = 360;

	// Token: 0x0400CF55 RID: 53077
	private const int END_DISTANCE = 30;

	// Token: 0x0400CF56 RID: 53078
	private const int NAV_DISTANCE = 200;

	// Token: 0x0400CF57 RID: 53079
	private const int NO_RESET_ANGLE = 20;

	// Token: 0x0400CF58 RID: 53080
	private const int NO_RESET_DISTANCE = 50;

	// Token: 0x0400CF59 RID: 53081
	private const int PER_TICK_MIN_MOVE_SPEED = 30;

	// Token: 0x0400CF5A RID: 53082
	private const int WHILE_UPDATE_MOVE_POINT_COUNT = 2;

	// Token: 0x0400CF5B RID: 53083
	private int PbDataId;

	// Token: 0x0400CF5C RID: 53084
	[Nullable(2)]
	private Entity Entity;

	// Token: 0x0400CF5D RID: 53085
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CF5E RID: 53086
	[Nullable(2)]
	private BaseUnifiedStateComponent UnifiedComp;

	// Token: 0x0400CF5F RID: 53087
	[Nullable(2)]
	private CharacterAiComponent AiComp;

	// Token: 0x0400CF60 RID: 53088
	private List<CharacterAiComponent> FollowerAiComps = new List<CharacterAiComponent>();

	// Token: 0x0400CF61 RID: 53089
	[Nullable(2)]
	private MoveCharacterConfig MoveConfig;

	// Token: 0x0400CF62 RID: 53090
	private float Distance;

	// Token: 0x0400CF63 RID: 53091
	private bool IsFly;

	// Token: 0x0400CF64 RID: 53092
	private bool Navigation;

	// Token: 0x0400CF65 RID: 53093
	private float TurnSpeed;

	// Token: 0x0400CF66 RID: 53094
	private bool UsePreLocation;

	// Token: 0x0400CF67 RID: 53095
	private readonly global::Vector PreLocation = global::Vector.Create();

	// Token: 0x0400CF68 RID: 53096
	private bool ReturnTimeoutFailed;

	// Token: 0x0400CF69 RID: 53097
	private double TimeoutTime;

	// Token: 0x0400CF6A RID: 53098
	private double CurTimeoutTime;

	// Token: 0x0400CF6B RID: 53099
	private double LastFrameDistance;

	// Token: 0x0400CF6C RID: 53100
	private readonly global::Vector CacheVector = global::Vector.Create();

	// Token: 0x0400CF6D RID: 53101
	private readonly global::Vector CacheVector2 = global::Vector.Create();

	// Token: 0x0400CF6E RID: 53102
	private readonly global::Vector CacheMovePoint = global::Vector.Create();

	// Token: 0x0400CF6F RID: 53103
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> CachePath;

	// Token: 0x0400CF70 RID: 53104
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> MovePath;

	// Token: 0x0400CF71 RID: 53105
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> NavigationPath;

	// Token: 0x0400CF72 RID: 53106
	private double DeltaTime;

	// Token: 0x0400CF73 RID: 53107
	private bool Moving;

	// Token: 0x0400CF74 RID: 53108
	[Nullable(2)]
	private Action<ELevelEventState> OnMoveEndCallback;

	// Token: 0x0400CF75 RID: 53109
	private readonly PatrolMovePointsLogic PointsLogic = new PatrolMovePointsLogic();

	// Token: 0x0400CF76 RID: 53110
	private readonly PatrolMoveLogic MoveLogic = new PatrolMoveLogic();

	// Token: 0x0400CF77 RID: 53111
	private bool PlayerWalkState;
}
