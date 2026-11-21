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

// Token: 0x02002642 RID: 9794
[NullableContext(1)]
[Nullable(0)]
public class BaseMoveCharacter
{
	// Token: 0x1700267B RID: 9851
	// (get) Token: 0x0601877B RID: 100219 RVA: 0x0076468F File Offset: 0x0076288F
	public global::Vector CurrentToLocation
	{
		get
		{
			return this.PointsLogic.TargetPoint.Position;
		}
	}

	// Token: 0x0601877C RID: 100220 RVA: 0x007646A4 File Offset: 0x007628A4
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

	// Token: 0x0601877D RID: 100221 RVA: 0x0076477C File Offset: 0x0076297C
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

	// Token: 0x0601877E RID: 100222 RVA: 0x00764878 File Offset: 0x00762A78
	private unsafe void UpdateMoveInternal(float deltaSeconds)
	{
		if (this.CheckEndDistanceAllPoints())
		{
			return;
		}
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

	// Token: 0x0601877F RID: 100223 RVA: 0x007649F8 File Offset: 0x00762BF8
	private bool CheckEndDistanceAllPoints()
	{
		MoveCharacterConfig moveConfig = this.MoveConfig;
		if (moveConfig == null || !moveConfig.EndDistanceAllPoints.GetValueOrDefault())
		{
			return false;
		}
		IList<MoveCharacterPoint> movePoint = this.PointsLogic.MovePoint;
		if (movePoint == null || movePoint.Count == 0)
		{
			return false;
		}
		MoveCharacterPoint moveCharacterPoint = movePoint[movePoint.Count - 1];
		if (moveCharacterPoint == null)
		{
			return false;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (((!this.IsFly) ? GravityUtils.Instance.GetDistSquared2dForActor(actorComp, actorComp.ActorLocationProxy, moveCharacterPoint.Position) : global::Vector.DistSquared(actorComp.ActorLocationProxy, moveCharacterPoint.Position)) <= (double)(this.Distance * this.Distance))
		{
			this.PointsLogic.OnArriveMovePoint(moveCharacterPoint);
			this.SyncToController();
			this.MoveEnd(ELevelEventState.Success);
			return true;
		}
		return false;
	}

	// Token: 0x06018780 RID: 100224 RVA: 0x00764AB8 File Offset: 0x00762CB8
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

	// Token: 0x06018781 RID: 100225 RVA: 0x00764B90 File Offset: 0x00762D90
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
			actorComp2.SetInputDirect(this.CacheVector, false, EInputDirectSpace.World);
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

	// Token: 0x06018782 RID: 100226 RVA: 0x00764C9C File Offset: 0x00762E9C
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

	// Token: 0x06018783 RID: 100227 RVA: 0x00764DC4 File Offset: 0x00762FC4
	private bool ChangeNextPoint()
	{
		if (this.UsePreLocation)
		{
			this.UsePreLocation = false;
		}
		return this.PointsLogic.ChangeToNextPoint() && this.GenerateMovePoint(this.PointsLogic.GetPreviousLocation(), this.PointsLogic.TargetPoint.Position, this.Navigation, false);
	}

	// Token: 0x06018784 RID: 100228 RVA: 0x00764E18 File Offset: 0x00763018
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

	// Token: 0x06018785 RID: 100229 RVA: 0x00764F74 File Offset: 0x00763174
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

	// Token: 0x06018786 RID: 100230 RVA: 0x00764F9E File Offset: 0x0076319E
	public void Dispose()
	{
		this.StopMoveInternal();
	}

	// Token: 0x06018787 RID: 100231 RVA: 0x00764FA8 File Offset: 0x007631A8
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

	// Token: 0x06018788 RID: 100232 RVA: 0x0076503C File Offset: 0x0076323C
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

	// Token: 0x06018789 RID: 100233 RVA: 0x00765394 File Offset: 0x00763594
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

	// Token: 0x0601878A RID: 100234 RVA: 0x007653D8 File Offset: 0x007635D8
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

	// Token: 0x0601878B RID: 100235 RVA: 0x007655C4 File Offset: 0x007637C4
	private bool AddNavigationPath(global::Vector start, global::Vector end, List<global::Vector> outPath)
	{
		UObject world = this.ActorComp.Owner.GetWorld();
		FVectorDouble from = start.ToUeVector(false);
		FVectorDouble to = end.ToUeVector(false);
		bool? ignoreZ = new bool?(false);
		MoveCharacterConfig moveConfig = this.MoveConfig;
		return AiControllerLibrary.NavigationFindPath(world, from, to, outPath, ignoreZ, (moveConfig != null) ? moveConfig.StrictNavigation : null) && outPath.Count > 0;
	}

	// Token: 0x0601878C RID: 100236 RVA: 0x00765622 File Offset: 0x00763822
	private void OnMoveActionEnd(ELevelEventState result)
	{
		if (this.OnMoveEndCallback != null)
		{
			this.OnMoveEndCallback(result);
		}
	}

	// Token: 0x0601878D RID: 100237 RVA: 0x00765638 File Offset: 0x00763838
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

	// Token: 0x0601878E RID: 100238 RVA: 0x007656F4 File Offset: 0x007638F4
	private void OnArriveMovePoint()
	{
		this.UpdateMoveStateAndSpeed();
		this.PointsLogic.OnArriveMovePoint(null);
		MoveCharacterPoint targetPoint = this.PointsLogic.TargetPoint;
		if (targetPoint != null && targetPoint.PosState != null)
		{
			MoveCharacterPoint targetPoint2 = this.PointsLogic.TargetPoint;
			this.IsFly = (targetPoint2 != null && targetPoint2.PosState.GetValueOrDefault() == global::ECharPositionState.Air);
		}
	}

	// Token: 0x0601878F RID: 100239 RVA: 0x00765756 File Offset: 0x00763956
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

	// Token: 0x06018790 RID: 100240 RVA: 0x0076578C File Offset: 0x0076398C
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

	// Token: 0x06018791 RID: 100241 RVA: 0x007657F4 File Offset: 0x007639F4
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

	// Token: 0x06018792 RID: 100242 RVA: 0x00765924 File Offset: 0x00763B24
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

	// Token: 0x06018793 RID: 100243 RVA: 0x00765980 File Offset: 0x00763B80
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

	// Token: 0x06018794 RID: 100244 RVA: 0x00765A74 File Offset: 0x00763C74
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

	// Token: 0x1700267C RID: 9852
	// (get) Token: 0x06018795 RID: 100245 RVA: 0x00765B12 File Offset: 0x00763D12
	public bool IsRunning
	{
		get
		{
			return this.Moving;
		}
	}

	// Token: 0x0400D344 RID: 54084
	private const int DEFAULT_TURN_SPEED = 360;

	// Token: 0x0400D345 RID: 54085
	private const int END_DISTANCE = 30;

	// Token: 0x0400D346 RID: 54086
	private const int NAV_DISTANCE = 200;

	// Token: 0x0400D347 RID: 54087
	private const int NO_RESET_ANGLE = 20;

	// Token: 0x0400D348 RID: 54088
	private const int NO_RESET_DISTANCE = 50;

	// Token: 0x0400D349 RID: 54089
	private const int PER_TICK_MIN_MOVE_SPEED = 30;

	// Token: 0x0400D34A RID: 54090
	private const int WHILE_UPDATE_MOVE_POINT_COUNT = 2;

	// Token: 0x0400D34B RID: 54091
	private int PbDataId;

	// Token: 0x0400D34C RID: 54092
	[Nullable(2)]
	private Entity Entity;

	// Token: 0x0400D34D RID: 54093
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D34E RID: 54094
	[Nullable(2)]
	private BaseUnifiedStateComponent UnifiedComp;

	// Token: 0x0400D34F RID: 54095
	[Nullable(2)]
	private CharacterAiComponent AiComp;

	// Token: 0x0400D350 RID: 54096
	private List<CharacterAiComponent> FollowerAiComps = new List<CharacterAiComponent>();

	// Token: 0x0400D351 RID: 54097
	[Nullable(2)]
	private MoveCharacterConfig MoveConfig;

	// Token: 0x0400D352 RID: 54098
	private float Distance;

	// Token: 0x0400D353 RID: 54099
	private bool IsFly;

	// Token: 0x0400D354 RID: 54100
	private bool Navigation;

	// Token: 0x0400D355 RID: 54101
	private float TurnSpeed;

	// Token: 0x0400D356 RID: 54102
	private bool UsePreLocation;

	// Token: 0x0400D357 RID: 54103
	private readonly global::Vector PreLocation = global::Vector.Create();

	// Token: 0x0400D358 RID: 54104
	private bool ReturnTimeoutFailed;

	// Token: 0x0400D359 RID: 54105
	private double TimeoutTime;

	// Token: 0x0400D35A RID: 54106
	private double CurTimeoutTime;

	// Token: 0x0400D35B RID: 54107
	private double LastFrameDistance;

	// Token: 0x0400D35C RID: 54108
	private readonly global::Vector CacheVector = global::Vector.Create();

	// Token: 0x0400D35D RID: 54109
	private readonly global::Vector CacheVector2 = global::Vector.Create();

	// Token: 0x0400D35E RID: 54110
	private readonly global::Vector CacheMovePoint = global::Vector.Create();

	// Token: 0x0400D35F RID: 54111
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> CachePath;

	// Token: 0x0400D360 RID: 54112
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> MovePath;

	// Token: 0x0400D361 RID: 54113
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> NavigationPath;

	// Token: 0x0400D362 RID: 54114
	private double DeltaTime;

	// Token: 0x0400D363 RID: 54115
	private bool Moving;

	// Token: 0x0400D364 RID: 54116
	[Nullable(2)]
	private Action<ELevelEventState> OnMoveEndCallback;

	// Token: 0x0400D365 RID: 54117
	private readonly PatrolMovePointsLogic PointsLogic = new PatrolMovePointsLogic();

	// Token: 0x0400D366 RID: 54118
	private readonly PatrolMoveLogic MoveLogic = new PatrolMoveLogic();

	// Token: 0x0400D367 RID: 54119
	private bool PlayerWalkState;
}
