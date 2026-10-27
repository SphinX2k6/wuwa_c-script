using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.NewWorld.Character.Npc.Controller;
using UnrealEngine;

// Token: 0x020030F5 RID: 12533
[NullableContext(1)]
[Nullable(0)]
public class CharacterPatrolComponent : EntityComponent
{
	// Token: 0x0601ADD0 RID: 110032 RVA: 0x00741074 File Offset: 0x0073F274
	protected override bool OnStart()
	{
		this.CreatureData = base.Entity.GetComponent<CreatureDataComponent>();
		this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
		this.MoveComp = base.Entity.GetComponent<BaseMoveComponent>();
		this.RecordList = new Dictionary<long, PatrolRecord>();
		this.SplineInfoList = new Dictionary<long, SplineInfo>();
		this.CacheVector = global::Vector.Create();
		this.CacheVector2 = global::Vector.Create();
		return true;
	}

	// Token: 0x0601ADD1 RID: 110033 RVA: 0x007410E1 File Offset: 0x0073F2E1
	protected override void OnActivate()
	{
	}

	// Token: 0x0601ADD2 RID: 110034 RVA: 0x007410E3 File Offset: 0x0073F2E3
	protected override bool OnEnd()
	{
		if (this.CurrentPatrol != null && this.CurrentSplineInfo != null)
		{
			this.StopPatrol(this.CurrentSplineInfo.SplineId, true);
		}
		return true;
	}

	// Token: 0x0601ADD3 RID: 110035 RVA: 0x00741108 File Offset: 0x0073F308
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0601ADD4 RID: 110036 RVA: 0x0074110C File Offset: 0x0073F30C
	public unsafe void StartPatrol(int splineId, IPatrolParams config)
	{
		PatrolRecord currentPatrol = this.CurrentPatrol;
		if (currentPatrol != null && currentPatrol.IsActive)
		{
			return;
		}
		if (this.SplineInfoList == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[CharPatrolComp] SplineInfoList未初始化，组件OnStart可能尚未执行";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			BaseActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineId", splineId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		SplineInfo splineInfo2;
		SplineInfo splineInfo = this.SplineInfoList.TryGetValue((long)splineId, out splineInfo2) ? splineInfo2 : this.InitSplineInfo(splineId, config);
		if (splineInfo == null || !this.PartitionSplineAndCreateMoveConfig(splineInfo, config))
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.YJX;
			string message2 = "初始化样条失败，无法开始巡逻";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item2 = "PbDataId";
			BaseActorComponent actorComp2 = this.ActorComp;
			int? num;
			if (actorComp2 == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent creatureData = actorComp2.CreatureData;
				num = ((creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
			}
			ptr2 = new ValueTuple<string, object>(item2, num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SplineId", splineId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		this.SetStartPatrol(splineInfo, config);
	}

	// Token: 0x0601ADD5 RID: 110037 RVA: 0x00741284 File Offset: 0x0073F484
	public unsafe void StartSplineCurvePatrol(int splineId, SplineCurve splineCurve, SplineComponent splineData, IPatrolParams config)
	{
		PatrolRecord currentPatrol = this.CurrentPatrol;
		if (currentPatrol != null && currentPatrol.IsActive)
		{
			if (splineId == this.CurrentSplineInfo.SplineId)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[CharPatrolComp] 开启新巡逻时存在未完成的巡逻，停止未完成巡逻";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			BaseActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewSplineId", splineId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("OldSplineId", this.CurrentSplineInfo.SplineId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.StopPatrol(this.CurrentSplineInfo.SplineId, false);
		}
		if (this.SplineInfoList == null)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.YJX;
			string message2 = "[CharPatrolComp] SplineInfoList未初始化，组件OnStart可能尚未执行";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item2 = "PbDataId";
			BaseActorComponent actorComp2 = this.ActorComp;
			ptr2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? new int?(actorComp2.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SplineId", splineId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		SplineInfo splineInfo2;
		SplineInfo splineInfo = this.SplineInfoList.TryGetValue((long)splineId, out splineInfo2) ? splineInfo2 : this.InitSplineInfoWithCurve(splineId, splineCurve, splineData, config, true);
		if (splineInfo == null || !this.PartitionSplineAndCreateMoveConfig(splineInfo, config))
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.AI;
			ELogAuthor author3 = ELogAuthor.YJX;
			string message3 = "初始化样条失败，无法开始巡逻";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0);
			string item3 = "PbDataId";
			BaseActorComponent actorComp3 = this.ActorComp;
			int? num;
			if (actorComp3 == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent creatureData = actorComp3.CreatureData;
				num = ((creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
			}
			ptr3 = new ValueTuple<string, object>(item3, num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("SplineId", splineId);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return;
		}
		this.SetStartPatrol(splineInfo, config);
	}

	// Token: 0x0601ADD6 RID: 110038 RVA: 0x007414CC File Offset: 0x0073F6CC
	private unsafe void SetStartPatrol(SplineInfo splineInfo, IPatrolParams config)
	{
		int splineId = splineInfo.SplineId;
		PatrolRecord patrolRecord = new PatrolRecord(config);
		patrolRecord.IsActive = true;
		patrolRecord.PatrolState = EPatrolState.PatrolMove;
		this.CurrentPatrol = patrolRecord;
		this.CurrentSplineInfo = splineInfo;
		if (this.RecordList != null)
		{
			this.RecordList[(long)splineId] = patrolRecord;
		}
		if (this.SplineInfoList != null)
		{
			this.SplineInfoList[(long)splineId] = splineInfo;
		}
		this.NoRequestServer = config.NoRequestServer.GetValueOrDefault();
		if (this.ExternalData != null)
		{
			int splineId2 = this.ExternalData.SplineId;
			int pointId = this.ExternalData.PointId;
			EPatrolState state = this.ExternalData.State;
			if (splineId2 == splineId && state == EPatrolState.WaitSyncEvents)
			{
				this.CurrentPatrol.LastPointIndex = pointId;
			}
			this.ExternalData = null;
		}
		int num = this.GetNextPointIndex(null);
		EPatrolStartMode? startMode = config.StartMode;
		if (startMode != null)
		{
			switch (startMode.GetValueOrDefault())
			{
			case EPatrolStartMode.NearestPoint:
				num = this.GetNearestPatrolPointIndex();
				break;
			case EPatrolStartMode.NearestDistance:
				num = this.GetNearestDistancePointIndex();
				break;
			case EPatrolStartMode.RandomPoint:
				num = this.StartPatrolFromRandomPoint(config);
				break;
			}
		}
		this.CurrentPatrol.LastPointIndex = num - 1;
		ValueTuple<int, int, bool> segmentInfo = this.GetSegmentInfo(num);
		MoveCharacterConfig moveCharacterConfig = this.CurrentSplineInfo.SegmentsMoveConfig[segmentInfo.Item1];
		if (moveCharacterConfig == null)
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.AI;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[CharacterPatrolComp.StartPatrol] 开始样条巡逻";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "PbDataId";
		BaseActorComponent actorComp = this.ActorComp;
		int? num2;
		if (actorComp == null)
		{
			num2 = null;
		}
		else
		{
			CreatureDataComponent creatureData = actorComp.CreatureData;
			num2 = ((creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
		}
		ptr = new ValueTuple<string, object>(item, num2);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item2 = "Actor";
		BaseActorComponent actorComp2 = this.ActorComp;
		ptr2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? actorComp2.Owner : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SplineId", splineId);
		ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item3 = "LastPoint";
		PatrolRecord currentPatrol = this.CurrentPatrol;
		ptr3 = new ValueTuple<string, object>(item3, (currentPatrol != null) ? new int?(currentPatrol.LastPointIndex) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		moveCharacterConfig.StartIndex = new int?(segmentInfo.Item2);
		moveCharacterConfig.NavigateToStartPos = new bool?(true);
		this.MoveComp.MoveAlongPath(moveCharacterConfig, "CharacterPatrolComponent.SetStartPatrol");
		this.PatrolBeginRequest();
		EventSystem.Instance.EmitWithTarget<int>(base.Entity, EEventName.OnPatrolStart, splineId);
	}

	// Token: 0x0601ADD7 RID: 110039 RVA: 0x00741764 File Offset: 0x0073F964
	public unsafe void PausePatrol(int splineId, string key)
	{
		Dictionary<long, PatrolRecord> recordList = this.RecordList;
		PatrolRecord patrolRecord2;
		PatrolRecord patrolRecord = (recordList != null && recordList.TryGetValue((long)splineId, out patrolRecord2)) ? patrolRecord2 : null;
		if (patrolRecord == null)
		{
			return;
		}
		HashSet<string> hashSet2;
		HashSet<string> hashSet = this.PauseKeyMap.TryGetValue((long)splineId, out hashSet2) ? hashSet2 : null;
		if (hashSet == null)
		{
			hashSet = new HashSet<string>();
			this.PauseKeyMap[(long)splineId] = hashSet;
		}
		if (hashSet.Contains(key))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[CharacterPlanComponent] 重复使用暂停巡逻的Key";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			CreatureDataComponent creatureData = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineId", splineId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("context", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Key", key);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		hashSet.Add(key);
		if (hashSet.Count != 1)
		{
			return;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.AI;
		ELogAuthor author2 = ELogAuthor.YJX;
		string message2 = "[CharacterPatrolComp.PausePatrol] 暂停样条巡逻";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
		string item2 = "PbDataId";
		BaseActorComponent actorComp = this.ActorComp;
		int? num;
		if (actorComp == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent creatureData2 = actorComp.CreatureData;
			num = ((creatureData2 != null) ? new int?(creatureData2.GetPbDataId()) : null);
		}
		ptr2 = new ValueTuple<string, object>(item2, num);
		ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
		string item3 = "Actor";
		BaseActorComponent actorComp2 = this.ActorComp;
		ptr3 = new ValueTuple<string, object>(item3, (actorComp2 != null) ? actorComp2.Owner : null);
		ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
		string item4 = "SplineId";
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		ptr4 = new ValueTuple<string, object>(item4, (currentSplineInfo != null) ? new int?(currentSplineInfo.SplineId) : null);
		ref ValueTuple<string, object> ptr5 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3);
		string item5 = "LastPoint";
		PatrolRecord currentPatrol = this.CurrentPatrol;
		ptr5 = new ValueTuple<string, object>(item5, (currentPatrol != null) ? new int?(currentPatrol.LastPointIndex) : null);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		patrolRecord.IsActive = false;
		SplineInfo currentSplineInfo2 = this.CurrentSplineInfo;
		if (currentSplineInfo2 != null && currentSplineInfo2.SplineId == splineId)
		{
			this.MoveComp.StopMoveNew("CharacterPatrolComponent.PausePatrol");
			this.PatrolEndRequest();
		}
		EventSystem.Instance.EmitWithTarget<int>(base.Entity, EEventName.OnPatrolPause, splineId);
	}

	// Token: 0x0601ADD8 RID: 110040 RVA: 0x007419F4 File Offset: 0x0073FBF4
	public unsafe void ResumePatrol(int splineId, string key)
	{
		PatrolRecord currentPatrol = this.CurrentPatrol;
		if (currentPatrol != null && currentPatrol.IsActive)
		{
			return;
		}
		Dictionary<long, PatrolRecord> recordList = this.RecordList;
		PatrolRecord patrolRecord = (recordList != null) ? recordList.GetValueOrDefault((long)splineId) : null;
		if (patrolRecord == null)
		{
			return;
		}
		HashSet<string> valueOrDefault = this.PauseKeyMap.GetValueOrDefault((long)splineId);
		if (valueOrDefault == null || !valueOrDefault.Remove(key))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[CharacterPatrolComp] 继续巡逻使用了未定义的Key";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			CreatureDataComponent creatureData = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineId", splineId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("context", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Key", key);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		if (valueOrDefault.Count > 0)
		{
			return;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.AI;
		ELogAuthor author2 = ELogAuthor.YJX;
		string message2 = "[CharacterPatrolComp.ResumePatrol] 继续样条巡逻";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
		string item2 = "PbDataId";
		BaseActorComponent actorComp = this.ActorComp;
		int? num;
		if (actorComp == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent creatureData2 = actorComp.CreatureData;
			num = ((creatureData2 != null) ? new int?(creatureData2.GetPbDataId()) : null);
		}
		ptr2 = new ValueTuple<string, object>(item2, num);
		ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
		string item3 = "Actor";
		BaseActorComponent actorComp2 = this.ActorComp;
		ptr3 = new ValueTuple<string, object>(item3, (actorComp2 != null) ? actorComp2.Owner : null);
		ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
		string item4 = "SplineId";
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		ptr4 = new ValueTuple<string, object>(item4, (currentSplineInfo != null) ? new int?(currentSplineInfo.SplineId) : null);
		ref ValueTuple<string, object> ptr5 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3);
		string item5 = "LastPoint";
		PatrolRecord currentPatrol2 = this.CurrentPatrol;
		ptr5 = new ValueTuple<string, object>(item5, (currentPatrol2 != null) ? new int?(currentPatrol2.LastPointIndex) : null);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		patrolRecord.IsActive = true;
		patrolRecord.PatrolState = EPatrolState.PatrolMove;
		this.RestoreState((long)splineId);
		this.MoveAlongPathWithRecord();
		this.PatrolBeginRequest();
		EventSystem.Instance.EmitWithTarget<int>(base.Entity, EEventName.OnPatrolResume, splineId);
	}

	// Token: 0x0601ADD9 RID: 110041 RVA: 0x00741C64 File Offset: 0x0073FE64
	public void StopPatrol(int splineId, bool noSync = false)
	{
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		if (currentSplineInfo == null || currentSplineInfo.SplineId != splineId)
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.AI;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[CharacterPatrolComp.StopPatrol] 停止样条巡逻";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "PbDataId";
		BaseActorComponent actorComp = this.ActorComp;
		int? num;
		if (actorComp == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent creatureData = actorComp.CreatureData;
			num = ((creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
		}
		ptr = new ValueTuple<string, object>(item, num);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item2 = "Actor";
		BaseActorComponent actorComp2 = this.ActorComp;
		ptr2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? actorComp2.Owner : null);
		ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
		string item3 = "SplineId";
		SplineInfo currentSplineInfo2 = this.CurrentSplineInfo;
		ptr3 = new ValueTuple<string, object>(item3, (currentSplineInfo2 != null) ? new int?(currentSplineInfo2.SplineId) : null);
		ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item4 = "LastPoint";
		PatrolRecord currentPatrol = this.CurrentPatrol;
		ptr4 = new ValueTuple<string, object>(item4, (currentPatrol != null) ? new int?(currentPatrol.LastPointIndex) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		EventSystem.Instance.EmitWithTarget<int>(base.Entity, EEventName.OnPatrolStop, splineId);
		this.MoveComp.StopMoveNew("CharacterPatrolComponent.StopPatrol");
		if (!noSync)
		{
			this.PatrolEndRequest();
		}
		this.ResetState((long)splineId);
	}

	// Token: 0x0601ADDA RID: 110042 RVA: 0x00741DD8 File Offset: 0x0073FFD8
	[NullableContext(2)]
	public PatrolSavedData SavePatrolData()
	{
		if (this.ExternalData != null)
		{
			return this.ExternalData.DeepCopy();
		}
		if (this.CurrentPatrol != null)
		{
			SplineInfo currentSplineInfo = this.CurrentSplineInfo;
			bool flag;
			if (currentSplineInfo == null)
			{
				flag = true;
			}
			else
			{
				int splineId = currentSplineInfo.SplineId;
				flag = false;
			}
			if (!flag)
			{
				return new PatrolSavedData
				{
					SplineId = this.CurrentSplineInfo.SplineId,
					PointId = this.GetLastPointRawIndex(),
					State = this.CurrentPatrol.PatrolState,
					Direction = this.IsPositiveDirection(),
					PatrolState = (BlackboardController.Instance.GetStringValueByEntity(base.Entity.Id, "PATROL_STATE") ?? ""),
					ActionIndex = BlackboardController.Instance.GetIntValueByEntity(base.Entity.Id, "PATROL_ACTION_INDEX").GetValueOrDefault(),
					ActionType = BlackboardController.Instance.GetIntValueByEntity(base.Entity.Id, "PATROL_ACTION_TYPE").GetValueOrDefault()
				};
			}
		}
		return null;
	}

	// Token: 0x0601ADDB RID: 110043 RVA: 0x00741ED4 File Offset: 0x007400D4
	[NullableContext(2)]
	public void LoadPatrolData(PatrolSavedData savedData = null)
	{
		if (savedData == null || savedData.PatrolState == null || savedData.PatrolState == "")
		{
			return;
		}
		this.ExternalData = savedData.DeepCopy();
		BlackboardController.Instance.SetStringValueByEntity(base.Entity.Id, "PATROL_STATE", savedData.PatrolState);
		BlackboardController.Instance.SetIntValueByEntity(base.Entity.Id, "PATROL_POINT_INDEX", savedData.PointId);
		BlackboardController.Instance.SetIntValueByEntity(base.Entity.Id, "PATROL_ACTION_INDEX", savedData.ActionIndex);
		BlackboardController.Instance.SetIntValueByEntity(base.Entity.Id, "PATROL_ACTION_TYPE", savedData.ActionType);
	}

	// Token: 0x0601ADDC RID: 110044 RVA: 0x00741F8B File Offset: 0x0074018B
	public int GetLastPointRawIndex()
	{
		if (this.CurrentPatrol == null)
		{
			return -1;
		}
		return this.GetRawIndexInSpline(this.CurrentPatrol.LastPointIndex);
	}

	// Token: 0x0601ADDD RID: 110045 RVA: 0x00741FA8 File Offset: 0x007401A8
	[NullableContext(2)]
	public global::Vector GetLastPointLocation()
	{
		if (this.CurrentPatrol == null || this.CurrentSplineInfo == null)
		{
			return null;
		}
		return this.CurrentSplineInfo.VirtualSplinePoints[this.CurrentPatrol.LastPointIndex].Point;
	}

	// Token: 0x0601ADDE RID: 110046 RVA: 0x00741FDC File Offset: 0x007401DC
	public int GetCurrentPatrolSplineId()
	{
		if (this.CurrentPatrol == null || this.CurrentSplineInfo == null)
		{
			return 0;
		}
		return this.CurrentSplineInfo.SplineId;
	}

	// Token: 0x0601ADDF RID: 110047 RVA: 0x00741FFB File Offset: 0x007401FB
	public bool HasPatrolRecord(long? splineId = null)
	{
		if (splineId == null)
		{
			return this.CurrentPatrol != null;
		}
		Dictionary<long, PatrolRecord> recordList = this.RecordList;
		return recordList != null && recordList.ContainsKey(splineId.Value);
	}

	// Token: 0x0601ADE0 RID: 110048 RVA: 0x00742028 File Offset: 0x00740228
	public bool GetIsPauseState(long splineId)
	{
		HashSet<string> hashSet;
		return this.PauseKeyMap.TryGetValue(splineId, out hashSet) && hashSet.Count > 0;
	}

	// Token: 0x0601ADE1 RID: 110049 RVA: 0x00742050 File Offset: 0x00740250
	[NullableContext(2)]
	public global::Vector GetLastPatrolLocation(long splineId)
	{
		PatrolRecord patrolRecord = null;
		Dictionary<long, PatrolRecord> recordList = this.RecordList;
		if (recordList != null)
		{
			recordList.TryGetValue(splineId, out patrolRecord);
		}
		if (patrolRecord == null || patrolRecord.LastPointIndex < 0)
		{
			return null;
		}
		SplineInfo splineInfo = null;
		Dictionary<long, SplineInfo> splineInfoList = this.SplineInfoList;
		if (splineInfoList != null)
		{
			splineInfoList.TryGetValue(splineId, out splineInfo);
		}
		if (splineInfo == null)
		{
			return null;
		}
		return splineInfo.VirtualSplinePoints[patrolRecord.LastPointIndex].Point;
	}

	// Token: 0x0601ADE2 RID: 110050 RVA: 0x007420B4 File Offset: 0x007402B4
	public bool IsInPatrol()
	{
		PatrolRecord currentPatrol = this.CurrentPatrol;
		return currentPatrol != null && currentPatrol.IsActive;
	}

	// Token: 0x0601ADE3 RID: 110051 RVA: 0x007420C8 File Offset: 0x007402C8
	public bool IsPositiveDirection()
	{
		return this.CurrentSplineInfo == null || this.CurrentPatrol == null || !this.CurrentSplineInfo.IsLoop || !this.CurrentSplineInfo.IsCircle || this.CurrentPatrol.LastPointIndex < this.CurrentSplineInfo.SplineComp.PathPoint.Count - 1;
	}

	// Token: 0x0601ADE4 RID: 110052 RVA: 0x00742128 File Offset: 0x00740328
	protected void SplineActionRunner(int splineId, int pointIndex, IList<ActionInfo> actions)
	{
		Action<ELevelEventState> finishCallback = delegate(ELevelEventState result)
		{
			this.ResumePatrol(splineId, "ExecuteSplineAction");
		};
		LevelGeneralController.Instance.ExecuteActionsNew(actions, EntityContext.Create(this.ActorComp.Entity.Id, null), finishCallback);
	}

	// Token: 0x0601ADE5 RID: 110053 RVA: 0x00742180 File Offset: 0x00740380
	[return: Nullable(2)]
	protected unsafe SplineInfo InitSplineInfo(int splineId, IPatrolParams config)
	{
		GameSplineComponent gameSplineComponent = new GameSplineComponent(splineId);
		if (!this.TryInitSplineFromAiPatrol(gameSplineComponent) && !gameSplineComponent.InitializeWithSubPoints(splineId) && !gameSplineComponent.Initialize())
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelAi;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[CharacterPatrolComp.InitSpline] GameSplineComponent初始化失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			BaseActorComponent actorComp = this.ActorComp;
			int? num;
			if (actorComp == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent creatureData = actorComp.CreatureData;
				num = ((creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
			}
			ptr = new ValueTuple<string, object>(item, num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplinePbDataId", splineId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return this.InitSplineInfoFromSplineComp(gameSplineComponent, config);
	}

	// Token: 0x0601ADE6 RID: 110054 RVA: 0x00742250 File Offset: 0x00740450
	[return: Nullable(2)]
	protected SplineInfo InitSplineInfoWithCurve(int splineId, SplineCurve spline, SplineComponent splineData, IPatrolParams config, bool sampling)
	{
		GameSplineComponent gameSplineComponent = new GameSplineComponent(splineId);
		gameSplineComponent.InitializeWithSplineCurve(spline, splineData, sampling);
		return this.InitSplineInfoFromSplineComp(gameSplineComponent, config);
	}

	// Token: 0x0601ADE7 RID: 110055 RVA: 0x00742278 File Offset: 0x00740478
	[return: Nullable(2)]
	protected unsafe SplineInfo InitSplineInfoFromSplineComp(GameSplineComponent splineComp, IPatrolParams config)
	{
		if (splineComp.Option.Type != ESplineType.LevelAI && splineComp.Option.Type != ESplineType.Patrol)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelAi;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[CharacterPatrolComp.InitSpline] 非巡逻样条或关卡Ai样条，无法初始化";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			BaseActorComponent actorComp = this.ActorComp;
			int? num;
			if (actorComp == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent creatureData = actorComp.CreatureData;
				num = ((creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
			}
			ptr = new ValueTuple<string, object>(item, num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplinePbDataId", splineComp.SplineId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		int splineId = splineComp.SplineId;
		SplineInfo splineInfo = new SplineInfo();
		splineInfo.SplineId = splineId;
		ESplineType type = splineComp.Option.Type;
		if (type != ESplineType.Patrol)
		{
			if (type == ESplineType.LevelAI)
			{
				splineInfo.IsLoop = false;
				splineInfo.IsCircle = false;
				ILevelAISpline levelAISpline = splineComp.Option as ILevelAISpline;
				if (levelAISpline.CycleOption != null && levelAISpline.CycleOption.Type == ELevelAiCycleMode.Loop)
				{
					splineInfo.IsLoop = true;
					splineInfo.IsCircle = levelAISpline.CycleOption.IsCircle;
				}
			}
		}
		else
		{
			splineInfo.IsLoop = false;
			splineInfo.IsCircle = false;
			IPatrolSpline patrolSpline = splineComp.Option as IPatrolSpline;
			if (patrolSpline.CycleOption != null && patrolSpline.CycleOption.Type == EPatrolCycleMode.Loop)
			{
				splineInfo.IsLoop = true;
				splineInfo.IsCircle = (patrolSpline.CycleOption as IPatrolCycleLooply).IsCircle;
			}
		}
		if (config.StartPointIndex != null || config.EndPointIndex != null)
		{
			int count = splineComp.PathPoint.Count;
			int num2 = (config.StartPointIndex != null) ? MathUtils.Instance.Clamp(config.StartPointIndex.Value, 0, count - 1) : 0;
			int count2 = ((config.EndPointIndex != null) ? MathUtils.Instance.Clamp(config.EndPointIndex.Value, 0, count - 1) : (count - 1)) - num2 + 1;
			splineComp.PathPoint = splineComp.PathPoint.GetRange(num2, count2);
		}
		splineInfo.SplineComp = splineComp;
		splineInfo.VirtualSplinePoints = splineComp.PathPoint.ToList<PatrolPoint>();
		if (splineInfo.IsCircle && splineInfo.VirtualSplinePoints.Count > 2)
		{
			for (int i = splineComp.PathPoint.Count - 2; i > 0; i--)
			{
				splineInfo.VirtualSplinePoints.Add(splineComp.PathPoint[i]);
			}
		}
		float num3 = float.MaxValue;
		int count3 = splineInfo.VirtualSplinePoints.Count;
		for (int j = 0; j < count3; j++)
		{
			PatrolPoint patrolPoint = splineInfo.VirtualSplinePoints[j];
			double num4 = (j < count3 - 1) ? global::Vector.Dist(patrolPoint.Point, splineInfo.VirtualSplinePoints[j + 1].Point) : 3.4028234663852886E+38;
			num3 = (float)Math.Min((double)num3, Math.Min(num4, (double)patrolPoint.OffsetRadius));
			if (MathUtils.Instance.IsNearlyZero((double)num3, null))
			{
				num3 = (float)num4;
			}
			else
			{
				float randomFloatNumber = MathUtils.Instance.GetRandomFloatNumber(0f, num3);
				global::Vector vector = splineInfo.VirtualSplinePoints[j].OffsetNormal ?? global::Vector.UpVectorProxy;
				if (vector.IsNearlyZero(9.999999747378752E-05))
				{
					num3 = (float)num4;
				}
				else
				{
					this.GetRandomVectorWithNormal(vector, MathUtils.Instance.CommonTempVector);
					MathUtils.Instance.CommonTempVector.Normalize(9.99999993922529E-09);
					MathUtils.Instance.CommonTempVector.MultiplyEqual((double)randomFloatNumber);
					patrolPoint.Point.AdditionEqual(MathUtils.Instance.CommonTempVector);
					num3 = (float)num4;
				}
			}
		}
		return splineInfo;
	}

	// Token: 0x0601ADE8 RID: 110056 RVA: 0x0074266C File Offset: 0x0074086C
	protected bool PartitionSplineAndCreateMoveConfig(SplineInfo info, IPatrolParams config)
	{
		if (info.VirtualSplinePoints.Count == 0)
		{
			return false;
		}
		if (info.SegmentsMoveConfig != null)
		{
			return true;
		}
		info.SegmentsMoveConfig = new List<MoveCharacterConfig>();
		int count = info.VirtualSplinePoints.Count;
		List<PatrolPoint> list = new List<PatrolPoint>(count);
		int num = 0;
		for (int i = 0; i < count; i++)
		{
			PatrolPoint patrolPoint = info.VirtualSplinePoints[i];
			list.Add(patrolPoint);
			if (i == count - 1 || (patrolPoint.Actions != null && patrolPoint.Actions.Count != 0))
			{
				this.CreateMoveConfig(info, list, num, config);
				num += list.Count;
				list.Clear();
			}
		}
		return true;
	}

	// Token: 0x0601ADE9 RID: 110057 RVA: 0x0074270C File Offset: 0x0074090C
	protected unsafe void CreateMoveConfig(SplineInfo info, List<PatrolPoint> path, int offset, IPatrolParams config)
	{
		CharacterPatrolComponent.<>c__DisplayClass39_0 CS$<>8__locals1 = new CharacterPatrolComponent.<>c__DisplayClass39_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.offset = offset;
		if (info.SplineComp == null)
		{
			return;
		}
		if (path.Count == 0)
		{
			return;
		}
		MoveCharacterPoint[] array = new MoveCharacterPoint[path.Count];
		for (int i = 0; i < path.Count; i++)
		{
			CharacterPatrolComponent.<>c__DisplayClass39_1 CS$<>8__locals2 = new CharacterPatrolComponent.<>c__DisplayClass39_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			CS$<>8__locals2.pathIndex = i;
			CS$<>8__locals2.point = path[CS$<>8__locals2.pathIndex];
			MoveCharacterPoint moveCharacterPoint = new MoveCharacterPoint
			{
				Index = CS$<>8__locals2.pathIndex,
				Position = CS$<>8__locals2.point.Point,
				Actions = new List<ActionInfo>(),
				MoveState = ((CS$<>8__locals2.point.MoveState != 0) ? new EPatrolMoveState?((EPatrolMoveState)CS$<>8__locals2.point.MoveState) : null),
				MoveSpeed = new float?(CS$<>8__locals2.point.MoveSpeed),
				PosState = ((CS$<>8__locals2.point.CharPositionState != null) ? new global::ECharPositionState?(this.GetPosStateType((ECharPositionStateType)CS$<>8__locals2.point.CharPositionState.Value)) : null),
				Callback = new Action(CS$<>8__locals2.<CreateMoveConfig>g__OnArrivePatrolPoint|0)
			};
			BaseActorComponent actorComp = this.ActorComp;
			bool flag;
			if (actorComp == null)
			{
				flag = true;
			}
			else
			{
				CreatureDataComponent creatureData = actorComp.CreatureData;
				flag = !((creatureData != null) ? new bool?(creatureData.IsRole()) : null).GetValueOrDefault();
			}
			if (flag && moveCharacterPoint.MoveState.GetValueOrDefault() == EPatrolMoveState.Sprint)
			{
				moveCharacterPoint.MoveState = new EPatrolMoveState?(EPatrolMoveState.Run);
			}
			array[CS$<>8__locals2.pathIndex] = moveCharacterPoint;
		}
		IPatrolSpline patrolSpline = info.SplineComp.Option as IPatrolSpline;
		bool? flag2 = (patrolSpline != null) ? patrolSpline.IsNavigation : new bool?(false);
		IPatrolSpline patrolSpline2 = info.SplineComp.Option as IPatrolSpline;
		bool? flag3 = (patrolSpline2 != null) ? patrolSpline2.IsFloating : new bool?(false);
		MoveCharacterConfig moveCharacterConfig = new MoveCharacterConfig();
		moveCharacterConfig.Points = new OneOf<MoveCharacterPoint, IList<MoveCharacterPoint>>(array);
		moveCharacterConfig.Navigation = flag2.GetValueOrDefault();
		moveCharacterConfig.IsFly = (config.IsFollowStrictly ?? flag3.GetValueOrDefault());
		moveCharacterConfig.DebugMode = config.DebugMode.GetValueOrDefault();
		moveCharacterConfig.Loop = false;
		moveCharacterConfig.CircleMove = new bool?(false);
		moveCharacterConfig.UsePreviousIndex = new bool?(false);
		moveCharacterConfig.UseNearestPoint = new bool?(false);
		moveCharacterConfig.ReturnFalseWhenNavigationFailed = false;
		moveCharacterConfig.NoAsyncPoint = config.NoSyncPoint;
		float? turnSpeed = config.TurnSpeed;
		float? turnSpeed2;
		if (turnSpeed == null)
		{
			IPatrolSpline patrolSpline3 = info.SplineComp.Option as IPatrolSpline;
			turnSpeed2 = ((patrolSpline3 != null) ? patrolSpline3.TurnSpeed : null);
		}
		else
		{
			turnSpeed2 = turnSpeed;
		}
		moveCharacterConfig.TurnSpeed = turnSpeed2;
		moveCharacterConfig.OnResetLocationCallback = config.OnResetLocationCallback;
		MoveCharacterConfig moveCharacterConfig2 = moveCharacterConfig;
		moveCharacterConfig2.Callback = new Action<ELevelEventState>(this.OnSegmentPatrolFinished);
		if (info.SegmentsMoveConfig == null)
		{
			int num = 1;
			List<MoveCharacterConfig> list = new List<MoveCharacterConfig>(num);
			CollectionsMarshal.SetCount<MoveCharacterConfig>(list, num);
			Span<MoveCharacterConfig> span = CollectionsMarshal.AsSpan<MoveCharacterConfig>(list);
			int index = 0;
			*span[index] = moveCharacterConfig2;
			info.SegmentsMoveConfig = list;
			return;
		}
		info.SegmentsMoveConfig.Add(moveCharacterConfig2);
	}

	// Token: 0x0601ADEA RID: 110058 RVA: 0x00742A50 File Offset: 0x00740C50
	protected unsafe void UpdatePatrolRecord(int pointIndex)
	{
		PatrolRecord currentPatrol = this.CurrentPatrol;
		if (currentPatrol == null || !currentPatrol.IsActive)
		{
			return;
		}
		this.PatrolPointReachedRequest(pointIndex);
		if (this.CurrentSplineInfo.IsLoop && this.CurrentSplineInfo.IsCircle)
		{
			this.DirectionChangeRequest(pointIndex);
		}
		this.CurrentPatrol.LastPointIndex = pointIndex;
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.AI;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "到达点巡逻点";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "PbDataId";
		BaseActorComponent actorComp = this.ActorComp;
		int? num;
		if (actorComp == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent creatureData = actorComp.CreatureData;
			num = ((creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
		}
		ptr = new ValueTuple<string, object>(item, num);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item2 = "Actor";
		BaseActorComponent actorComp2 = this.ActorComp;
		ptr2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? actorComp2.Owner : null);
		ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
		string item3 = "SplineId";
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		ptr3 = new ValueTuple<string, object>(item3, (currentSplineInfo != null) ? new int?(currentSplineInfo.SplineId) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("PointIndex", this.CurrentPatrol.LastPointIndex);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
	}

	// Token: 0x0601ADEB RID: 110059 RVA: 0x00742BA8 File Offset: 0x00740DA8
	protected void OnSegmentPatrolFinished(ELevelEventState result)
	{
		if (result != ELevelEventState.Success)
		{
			if (result == ELevelEventState.Failure)
			{
				this.OnPatrolFinished(ELevelEventState.Failure);
				return;
			}
		}
		else
		{
			IList<ActionInfo> pointActionsInternal = this.GetPointActionsInternal(this.CurrentPatrol.LastPointIndex);
			if (pointActionsInternal == null || pointActionsInternal.Count == 0)
			{
				MoveCharacterConfig nextPointMoveConfig = this.GetNextPointMoveConfig();
				if (nextPointMoveConfig == null)
				{
					this.OnPatrolFinished(ELevelEventState.Success);
					return;
				}
				nextPointMoveConfig.StartIndex = new int?(0);
				nextPointMoveConfig.NavigateToStartPos = new bool?(false);
				this.MoveComp.MoveAlongPath(nextPointMoveConfig, "CharacterPatrolComponent.OnSegmentPatrolFinished");
				return;
			}
			else
			{
				this.OnTriggerSplineActions(pointActionsInternal);
			}
		}
	}

	// Token: 0x0601ADEC RID: 110060 RVA: 0x00742C26 File Offset: 0x00740E26
	protected void OnPatrolFinished(ELevelEventState result)
	{
		Action<ELevelEventState> onPatrolEndHandle = this.CurrentPatrol.OnPatrolEndHandle;
		this.StopPatrol(this.CurrentSplineInfo.SplineId, false);
		if (onPatrolEndHandle == null)
		{
			return;
		}
		onPatrolEndHandle(result);
	}

	// Token: 0x0601ADED RID: 110061 RVA: 0x00742C50 File Offset: 0x00740E50
	protected void OnTriggerSplineActions(IList<ActionInfo> actions)
	{
		int splineId = this.CurrentSplineInfo.SplineId;
		int rawIndexInSpline = this.GetRawIndexInSpline(this.CurrentPatrol.LastPointIndex);
		Action<IList<ActionInfo>> onTriggerActionsHandle = this.CurrentPatrol.OnTriggerActionsHandle;
		this.CurrentPatrol.PatrolState = EPatrolState.WaitSyncEvents;
		ESplineType type = this.CurrentSplineInfo.SplineComp.Option.Type;
		if (type != ESplineType.Patrol)
		{
			if (type == ESplineType.LevelAI && onTriggerActionsHandle != null)
			{
				onTriggerActionsHandle(actions);
				return;
			}
		}
		else
		{
			this.PausePatrol(splineId, "ExecuteSplineAction");
			if (onTriggerActionsHandle != null)
			{
				onTriggerActionsHandle(actions);
			}
			this.SplineActionRunner(splineId, rawIndexInSpline, actions);
		}
	}

	// Token: 0x0601ADEE RID: 110062 RVA: 0x00742CDC File Offset: 0x00740EDC
	protected unsafe void MoveAlongPathWithRecord()
	{
		PatrolRecord currentPatrol = this.CurrentPatrol;
		if (currentPatrol == null || !currentPatrol.IsActive)
		{
			return;
		}
		if (this.CurrentSplineInfo == null)
		{
			return;
		}
		bool flag = this.CurrentPatrol.PatrolState == EPatrolState.WaitSyncEvents;
		int num = flag ? this.CurrentPatrol.LastPointIndex : this.GetNextPointIndex(null);
		ValueTuple<int, int, bool> segmentInfo = this.GetSegmentInfo(num);
		if (!flag && segmentInfo.Item1 == -1)
		{
			ValueTuple<int, int, bool> segmentInfo2 = this.GetSegmentInfo(this.CurrentPatrol.LastPointIndex);
			if (segmentInfo2.Item1 != -1 && segmentInfo2.Item3)
			{
				this.OnPatrolFinished(ELevelEventState.Success);
			}
			return;
		}
		MoveCharacterConfig moveCharacterConfig = this.CurrentSplineInfo.SegmentsMoveConfig[segmentInfo.Item1];
		moveCharacterConfig.StartIndex = new int?(segmentInfo.Item2);
		moveCharacterConfig.NavigateToStartPos = new bool?(true);
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.AI;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[CharacterPatrolComp.MoveAlongPathWithRecord] 依据历史选择下个目标点";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "PbDataId";
		BaseActorComponent actorComp = this.ActorComp;
		int? num2;
		if (actorComp == null)
		{
			num2 = null;
		}
		else
		{
			CreatureDataComponent creatureData = actorComp.CreatureData;
			num2 = ((creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
		}
		ptr = new ValueTuple<string, object>(item, num2);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item2 = "Actor";
		BaseActorComponent actorComp2 = this.ActorComp;
		ptr2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? actorComp2.Owner : null);
		ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
		string item3 = "SplineId";
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		ptr3 = new ValueTuple<string, object>(item3, (currentSplineInfo != null) ? new int?(currentSplineInfo.SplineId) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("StartIndex", num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		this.MoveComp.MoveAlongPath(moveCharacterConfig, "CharacterPatrolComponent.MoveAlongPathWithRecord");
	}

	// Token: 0x0601ADEF RID: 110063 RVA: 0x00742EB8 File Offset: 0x007410B8
	protected void ResetState(long splineId)
	{
		Dictionary<long, PatrolRecord> recordList = this.RecordList;
		if (recordList != null)
		{
			recordList.Remove(splineId);
		}
		this.PauseKeyMap.Remove(splineId);
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		int? num = (currentSplineInfo != null) ? new int?(currentSplineInfo.SplineId) : null;
		long? num2 = (num != null) ? new long?((long)num.GetValueOrDefault()) : null;
		if (splineId == num2.GetValueOrDefault() & num2 != null)
		{
			this.CurrentPatrol = null;
			this.CurrentSplineInfo = null;
		}
	}

	// Token: 0x0601ADF0 RID: 110064 RVA: 0x00742F49 File Offset: 0x00741149
	protected bool RestoreState(long splineId)
	{
		return this.RestorePatrolState(splineId) && this.RestoreSplineState(splineId);
	}

	// Token: 0x0601ADF1 RID: 110065 RVA: 0x00742F60 File Offset: 0x00741160
	protected bool RestorePatrolState(long splineId)
	{
		Dictionary<long, PatrolRecord> recordList = this.RecordList;
		PatrolRecord patrolRecord2;
		PatrolRecord patrolRecord = (recordList != null && recordList.TryGetValue(splineId, out patrolRecord2)) ? patrolRecord2 : null;
		if (patrolRecord == null)
		{
			return false;
		}
		this.CurrentPatrol = patrolRecord;
		return true;
	}

	// Token: 0x0601ADF2 RID: 110066 RVA: 0x00742F98 File Offset: 0x00741198
	protected bool RestoreSplineState(long splineId)
	{
		Dictionary<long, SplineInfo> splineInfoList = this.SplineInfoList;
		SplineInfo splineInfo2;
		SplineInfo splineInfo = (splineInfoList != null && splineInfoList.TryGetValue(splineId, out splineInfo2)) ? splineInfo2 : null;
		if (splineInfo == null)
		{
			return false;
		}
		this.CurrentSplineInfo = splineInfo;
		return true;
	}

	// Token: 0x0601ADF3 RID: 110067 RVA: 0x00742FD0 File Offset: 0x007411D0
	protected void PatrolBeginRequest()
	{
		if (!this.CreatureData.IsMonster() || this.NoRequestServer)
		{
			return;
		}
		EntityPatrolStartRequest entityPatrolStartRequest = EntityPatrolStartRequest.Create();
		entityPatrolStartRequest.EntityId = MathUtils.Instance.NumberToLong(this.CreatureData.GetCreatureDataId());
		entityPatrolStartRequest.Dir = (this.CurrentPatrol.LastPointIndex < this.CurrentSplineInfo.SplineComp.PathPoint.Count - 1);
		Net.Instance.Call(ERequestMessageId.EntityPatrolStartRequest, entityPatrolStartRequest, null, 0);
	}

	// Token: 0x0601ADF4 RID: 110068 RVA: 0x00743050 File Offset: 0x00741250
	protected void PatrolEndRequest()
	{
		if (!this.CreatureData.IsMonster() || this.NoRequestServer)
		{
			return;
		}
		EntityPatrolStopRequest entityPatrolStopRequest = EntityPatrolStopRequest.Create();
		entityPatrolStopRequest.EntityId = MathUtils.Instance.NumberToLong(this.CreatureData.GetCreatureDataId());
		Net.Instance.Call(ERequestMessageId.EntityPatrolStopRequest, entityPatrolStopRequest, null, 0);
	}

	// Token: 0x0601ADF5 RID: 110069 RVA: 0x007430A8 File Offset: 0x007412A8
	protected void DirectionChangeRequest(int pointIndex)
	{
		if (!this.CreatureData.IsMonster() || this.NoRequestServer)
		{
			return;
		}
		if (pointIndex == 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "往返式巡逻：回到起点";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataID", this.ActorComp.CreatureData.GetPbDataId());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EntityPatrolChangeDirRequest entityPatrolChangeDirRequest = EntityPatrolChangeDirRequest.Create();
			entityPatrolChangeDirRequest.EntityId = MathUtils.Instance.NumberToLong(this.CreatureData.GetCreatureDataId());
			entityPatrolChangeDirRequest.Dir = true;
			Net.Instance.Call(ERequestMessageId.EntityPatrolChangeDirRequest, entityPatrolChangeDirRequest, null, 0);
			return;
		}
		if (pointIndex == this.CurrentSplineInfo.SplineComp.PathPoint.Count - 1)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.YJX;
			string message2 = "往返式巡逻：走到终点";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PbDataID", this.ActorComp.CreatureData.GetPbDataId());
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			EntityPatrolChangeDirRequest entityPatrolChangeDirRequest2 = EntityPatrolChangeDirRequest.Create();
			entityPatrolChangeDirRequest2.EntityId = MathUtils.Instance.NumberToLong(this.ActorComp.CreatureData.GetCreatureDataId());
			entityPatrolChangeDirRequest2.Dir = false;
			Net.Instance.Call(ERequestMessageId.EntityPatrolChangeDirRequest, entityPatrolChangeDirRequest2, null, 0);
		}
	}

	// Token: 0x0601ADF6 RID: 110070 RVA: 0x007431D8 File Offset: 0x007413D8
	protected void PatrolPointReachedRequest(int pointIndex)
	{
		if (!this.CreatureData.IsMonster() || this.NoRequestServer)
		{
			return;
		}
		if (!this.IsPatrolWithAiConfig())
		{
			return;
		}
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		if (((currentSplineInfo != null) ? currentSplineInfo.VirtualSplinePoints : null) == null || this.CurrentPatrol == null)
		{
			return;
		}
		if (pointIndex < 0 || pointIndex >= this.CurrentSplineInfo.VirtualSplinePoints.Count)
		{
			return;
		}
		if (!this.CurrentSplineInfo.VirtualSplinePoints[pointIndex].IsMain)
		{
			return;
		}
		MonsterPatrolPointReachedRequest monsterPatrolPointReachedRequest = MonsterPatrolPointReachedRequest.Create();
		monsterPatrolPointReachedRequest.EntityId = MathUtils.Instance.NumberToLong(this.CreatureData.GetCreatureDataId());
		monsterPatrolPointReachedRequest.SplineEntityConfigId = this.CurrentSplineInfo.SplineId;
		monsterPatrolPointReachedRequest.Index = this.GetRawIndexInSpline(pointIndex);
		Net.Instance.Call(ERequestMessageId.MonsterPatrolPointReachedRequest, monsterPatrolPointReachedRequest, null, 0);
	}

	// Token: 0x0601ADF7 RID: 110071 RVA: 0x007432A4 File Offset: 0x007414A4
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"SegmentIndex",
		"IndexInSegment",
		"IsEnd"
	})]
	protected ValueTuple<int, int, bool> GetSegmentInfo(int pointIndex)
	{
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		if (((currentSplineInfo != null) ? currentSplineInfo.SegmentsMoveConfig : null) == null || pointIndex < 0 || pointIndex >= this.CurrentSplineInfo.VirtualSplinePoints.Count)
		{
			return new ValueTuple<int, int, bool>(-1, -1, false);
		}
		int num = 0;
		int count = this.CurrentSplineInfo.SegmentsMoveConfig.Count;
		for (int i = 0; i < count; i++)
		{
			int num2 = ((MoveCharacterPoint[])((T2)this.CurrentSplineInfo.SegmentsMoveConfig[i].Points)).Length;
			if (pointIndex >= num && pointIndex < num + num2)
			{
				return new ValueTuple<int, int, bool>(i, pointIndex - num, pointIndex - num == num2 - 1);
			}
			num += num2;
		}
		return new ValueTuple<int, int, bool>(-1, -1, false);
	}

	// Token: 0x0601ADF8 RID: 110072 RVA: 0x00743350 File Offset: 0x00741550
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<ActionInfo> GetPointActions(int pointIndex)
	{
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		bool flag;
		if (currentSplineInfo == null)
		{
			flag = (null != null);
		}
		else
		{
			GameSplineComponent splineComp = currentSplineInfo.SplineComp;
			flag = (((splineComp != null) ? splineComp.MainPointIndexArray : null) != null);
		}
		if (!flag || pointIndex < 0 || pointIndex >= this.CurrentSplineInfo.SplineComp.MainPointIndexArray.Count)
		{
			return null;
		}
		int pointIndex2 = this.CurrentSplineInfo.SplineComp.MainPointIndexArray[pointIndex];
		return this.GetPointActionsInternal(pointIndex2);
	}

	// Token: 0x0601ADF9 RID: 110073 RVA: 0x007433BC File Offset: 0x007415BC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected IList<ActionInfo> GetPointActionsInternal(int pointIndex)
	{
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		if (((currentSplineInfo != null) ? currentSplineInfo.VirtualSplinePoints : null) == null || pointIndex < 0 || pointIndex >= this.CurrentSplineInfo.VirtualSplinePoints.Count)
		{
			return null;
		}
		return this.CurrentSplineInfo.VirtualSplinePoints[pointIndex].Actions;
	}

	// Token: 0x0601ADFA RID: 110074 RVA: 0x0074340C File Offset: 0x0074160C
	protected int GetNearestPatrolPointIndex()
	{
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		bool flag;
		if (currentSplineInfo == null)
		{
			flag = false;
		}
		else
		{
			List<PatrolPoint> virtualSplinePoints = currentSplineInfo.VirtualSplinePoints;
			int? num = (virtualSplinePoints != null) ? new int?(virtualSplinePoints.Count) : null;
			int num2 = 0;
			flag = (num.GetValueOrDefault() == num2 & num != null);
		}
		if (flag)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "获取最近点失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		List<PatrolPoint> virtualSplinePoints2 = this.CurrentSplineInfo.VirtualSplinePoints;
		int result = 0;
		double num3 = double.MaxValue;
		global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		global::Vector vector = global::Vector.Create();
		global::Vector vector2 = global::Vector.Create();
		for (int i = 0; i < virtualSplinePoints2.Count - 1; i++)
		{
			vector.DeepCopy(virtualSplinePoints2[i].Point);
			vector2.DeepCopy(virtualSplinePoints2[i + 1].Point);
			this.CacheVector.Set(vector2.X, vector2.Y, vector2.Z);
			this.CacheVector.Subtraction(vector, this.CacheVector);
			double num4 = this.CacheVector.Size();
			this.CacheVector2.Set(actorLocationProxy.X, actorLocationProxy.Y, actorLocationProxy.Z);
			this.CacheVector2.Subtraction(vector2, this.CacheVector2);
			if (this.CacheVector.DotProduct(this.CacheVector2) <= 0.0)
			{
				this.CacheVector2.Set(actorLocationProxy.X, actorLocationProxy.Y, actorLocationProxy.Z);
				this.CacheVector2.Subtraction(vector, this.CacheVector2);
				bool flag2 = false;
				if (this.CacheVector.DotProduct(this.CacheVector2) < 0.0)
				{
					if (i != 0)
					{
						goto IL_22C;
					}
					flag2 = true;
				}
				if (this.CacheVector.DotProduct(this.ActorComp.ActorForwardProxy) >= 0.0)
				{
					this.CacheVector.CrossProduct(this.CacheVector2, this.CacheVector);
					double num5 = this.CacheVector.Size() / num4;
					if (num5 < num3)
					{
						num3 = num5;
						result = (flag2 ? i : (i + 1));
					}
				}
			}
			IL_22C:;
		}
		if (num3 == 1.7976931348623157E+308)
		{
			for (int j = 0; j < virtualSplinePoints2.Count; j++)
			{
				double num6 = global::Vector.DistSquared(actorLocationProxy, virtualSplinePoints2[j].Point);
				if (num6 < num3)
				{
					result = j;
					num3 = num6;
				}
			}
		}
		return result;
	}

	// Token: 0x0601ADFB RID: 110075 RVA: 0x0074369C File Offset: 0x0074189C
	protected int GetNearestDistancePointIndex()
	{
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		bool flag;
		if (currentSplineInfo == null)
		{
			flag = false;
		}
		else
		{
			List<PatrolPoint> virtualSplinePoints = currentSplineInfo.VirtualSplinePoints;
			int? num = (virtualSplinePoints != null) ? new int?(virtualSplinePoints.Count) : null;
			int num2 = 0;
			flag = (num.GetValueOrDefault() == num2 & num != null);
		}
		if (flag)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "获取最近点失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		List<PatrolPoint> virtualSplinePoints2 = this.CurrentSplineInfo.VirtualSplinePoints;
		int result = 0;
		double num3 = double.MaxValue;
		global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		for (int i = 0; i < virtualSplinePoints2.Count; i++)
		{
			double num4 = global::Vector.DistSquared(actorLocationProxy, virtualSplinePoints2[i].Point);
			if (num4 < num3)
			{
				result = i;
				num3 = num4;
			}
		}
		return result;
	}

	// Token: 0x0601ADFC RID: 110076 RVA: 0x00743788 File Offset: 0x00741988
	protected unsafe int StartPatrolFromRandomPoint(IPatrolParams config)
	{
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		List<PatrolPoint> list = (currentSplineInfo != null) ? currentSplineInfo.VirtualSplinePoints : null;
		if (list == null || list.Count == 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "随机起始点失败，无样条点";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		double num = (config.RandomDistanceRange != null && config.RandomDistanceRange.Count > 0) ? config.RandomDistanceRange[0] : 3000.0;
		double num2 = (config.RandomDistanceRange != null && config.RandomDistanceRange.Count > 1) ? config.RandomDistanceRange[1] : 7000.0;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		global::Vector vector;
		if (baseCharacter == null)
		{
			vector = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
		}
		global::Vector vector2 = vector;
		if (vector2 == null)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.YJX;
			string message2 = "随机起始点失败，无法获取玩家位置";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return 0;
		}
		List<ValueTuple<int, double>> list2 = new List<ValueTuple<int, double>>();
		for (int i = 0; i < list.Count; i++)
		{
			double num3 = global::Vector.Dist(vector2, list[i].Point);
			if (num3 <= num2 && (num3 >= num || !this.IsPointInCameraFrustum(list[i].Point)))
			{
				double num4 = 0.0;
				if (i > 0)
				{
					num4 += global::Vector.Dist(list[i - 1].Point, list[i].Point);
				}
				if (i < list.Count - 1)
				{
					num4 += global::Vector.Dist(list[i].Point, list[i + 1].Point);
				}
				if (num4 <= 0.0)
				{
					num4 = 1.0;
				}
				list2.Add(new ValueTuple<int, double>(i, num4));
			}
		}
		if (list2.Count == 0)
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.AI;
			ELogAuthor author3 = ELogAuthor.YJX;
			string message3 = "随机起始点：无符合条件的候选点，回退到第0个点";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return 0;
		}
		double num5 = 0.0;
		foreach (ValueTuple<int, double> valueTuple4 in list2)
		{
			num5 += valueTuple4.Item2;
		}
		double num6 = (double)MathUtils.Instance.GetRandomFloatNumber(0f, 1f) * num5;
		int item = list2[0].Item1;
		foreach (ValueTuple<int, double> valueTuple5 in list2)
		{
			num6 -= valueTuple5.Item2;
			if (num6 <= 0.0)
			{
				item = valueTuple5.Item1;
				break;
			}
		}
		this.ActorComp.SetActorLocation(list[item].Point.ToUeVector(false), "CharacterPatrolComponent.StartPatrolFromRandomPoint", true);
		global::Log instance4 = global::Log.Instance;
		ELogModule module4 = ELogModule.AI;
		ELogAuthor author4 = ELogAuthor.YJX;
		string message4 = "[CharacterPatrolComp] 随机起始点巡逻";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item2 = "PbDataId";
		BaseActorComponent actorComp = this.ActorComp;
		ptr = new ValueTuple<string, object>(item2, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item3 = "SplineId";
		SplineInfo currentSplineInfo2 = this.CurrentSplineInfo;
		ptr2 = new ValueTuple<string, object>(item3, (currentSplineInfo2 != null) ? new int?(currentSplineInfo2.SplineId) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PointIndex", item);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("CandidateCount", list2.Count);
		instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		if (this.CurrentSplineInfo.IsCircle && this.CurrentSplineInfo.IsLoop && MathUtils.Instance.GetRandomFloatNumber(0f, 1f) < 0.5f)
		{
			return this.GetSymmetryPointIndex(item);
		}
		return item;
	}

	// Token: 0x0601ADFD RID: 110077 RVA: 0x00743C00 File Offset: 0x00741E00
	protected bool IsPointInCameraFrustum(global::Vector point)
	{
		TsCharacterController characterController = Global.CharacterController;
		if (characterController == null)
		{
			return false;
		}
		APlayerController player = characterController;
		FVectorDouble fvectorDouble = point.ToUeVector(false);
		return UGameplayStatics.D_ProjectWorldToScreen(player, fvectorDouble, ref this.ScreenPositionRef, false);
	}

	// Token: 0x0601ADFE RID: 110078 RVA: 0x00743C30 File Offset: 0x00741E30
	protected int GetRawIndexInSpline(int index)
	{
		if (this.CurrentSplineInfo == null)
		{
			return -1;
		}
		int count = this.CurrentSplineInfo.SplineComp.PathPoint.Count;
		int count2 = this.CurrentSplineInfo.VirtualSplinePoints.Count;
		if (index < 0 || index >= count2 || count == 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelAi;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[CharacterPatrolComp.GetRawIndexInSpline] 索引越界";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			BaseActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "SplineId";
			SplineInfo currentSplineInfo = this.CurrentSplineInfo;
			ptr2 = new ValueTuple<string, object>(item2, (currentSplineInfo != null) ? new int?(currentSplineInfo.SplineId) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return -1;
		}
		int num = (index < count) ? index : (2 * count - 2 - index);
		num = Math.Clamp(num, 0, count - 1);
		return this.CurrentSplineInfo.SplineComp.GetLastMainPointIndex(num);
	}

	// Token: 0x0601ADFF RID: 110079 RVA: 0x00743D4C File Offset: 0x00741F4C
	protected int GetNextPointIndex(int? pointIndex = null)
	{
		if (this.CurrentPatrol == null || this.CurrentSplineInfo == null)
		{
			return -1;
		}
		int num = pointIndex ?? this.CurrentPatrol.LastPointIndex;
		if (num == this.CurrentSplineInfo.VirtualSplinePoints.Count - 1 && !this.CurrentSplineInfo.IsLoop)
		{
			return -1;
		}
		return (num + 1) % this.CurrentSplineInfo.VirtualSplinePoints.Count;
	}

	// Token: 0x0601AE00 RID: 110080 RVA: 0x00743DC4 File Offset: 0x00741FC4
	[NullableContext(2)]
	protected MoveCharacterConfig GetNextPointMoveConfig()
	{
		if (this.CurrentPatrol == null)
		{
			return null;
		}
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		if (((currentSplineInfo != null) ? currentSplineInfo.SegmentsMoveConfig : null) == null)
		{
			return null;
		}
		int nextPointIndex = this.GetNextPointIndex(null);
		ValueTuple<int, int, bool> segmentInfo = this.GetSegmentInfo(nextPointIndex);
		if (segmentInfo.Item1 == -1)
		{
			return null;
		}
		return this.CurrentSplineInfo.SegmentsMoveConfig[segmentInfo.Item1];
	}

	// Token: 0x0601AE01 RID: 110081 RVA: 0x00743E2C File Offset: 0x0074202C
	protected int GetSymmetryPointIndex(int pointIndex)
	{
		SplineInfo currentSplineInfo = this.CurrentSplineInfo;
		if (currentSplineInfo != null && currentSplineInfo.IsLoop)
		{
			SplineInfo currentSplineInfo2 = this.CurrentSplineInfo;
			if (currentSplineInfo2 != null && currentSplineInfo2.IsCircle)
			{
				if (pointIndex == 0)
				{
					return pointIndex;
				}
				return this.CurrentSplineInfo.VirtualSplinePoints.Count - pointIndex;
			}
		}
		return -1;
	}

	// Token: 0x0601AE02 RID: 110082 RVA: 0x00743E80 File Offset: 0x00742080
	protected global::ECharPositionState GetPosStateType(ECharPositionStateType type)
	{
		if (type == ECharPositionStateType.Ground)
		{
			return global::ECharPositionState.Ground;
		}
		if (type != ECharPositionStateType.Air)
		{
			return global::ECharPositionState.Ground;
		}
		return global::ECharPositionState.Air;
	}

	// Token: 0x0601AE03 RID: 110083 RVA: 0x00743E90 File Offset: 0x00742090
	protected void GetRandomVectorWithNormal(global::Vector normal, global::Vector outVector)
	{
		if (normal.IsNearlyZero(9.999999747378752E-05))
		{
			return;
		}
		double num = Math.Abs(normal.X);
		double num2 = Math.Abs(normal.Y);
		double num3 = Math.Abs(normal.Z);
		if (num <= num2 && num <= num3)
		{
			this.CacheVector.Set(1.0, 0.0, 0.0);
		}
		else if (num2 <= num3)
		{
			this.CacheVector.Set(0.0, 1.0, 0.0);
		}
		else
		{
			this.CacheVector.Set(0.0, 0.0, 1.0);
		}
		this.CacheVector.CrossProduct(normal, this.CacheVector);
		this.CacheVector.Normalize(9.99999993922529E-09);
		this.CacheVector2.CrossProduct(normal, this.CacheVector);
		this.CacheVector2.Normalize(9.99999993922529E-09);
		double num4 = (double)(MathUtils.Instance.GetRandomFloatNumber(0f, 1f) * 2f) * 3.141592653589793;
		double num5 = Math.Cos(num4);
		double num6 = Math.Sin(num4);
		outVector.Set(num5 * this.CacheVector.X + num6 * this.CacheVector2.X, num5 * this.CacheVector.Y + num6 * this.CacheVector2.Y, num5 * this.CacheVector.Z + num6 * this.CacheVector2.Z);
	}

	// Token: 0x0601AE04 RID: 110084 RVA: 0x00744030 File Offset: 0x00742230
	protected bool TryInitSplineFromAiPatrol(GameSplineComponent splineComp)
	{
		CharacterAiComponent component = base.Entity.GetComponent<CharacterAiComponent>();
		AiPatrolController aiPatrolController = (component != null) ? component.AiController.AiPatrol : null;
		if (((aiPatrolController != null) ? aiPatrolController.AllPatrolPoints : null) == null || aiPatrolController.AllPatrolPoints.Count == 0)
		{
			return false;
		}
		if (!splineComp.InitializeWithSubPoints(this.CreatureData.GetPbDataId()))
		{
			return false;
		}
		splineComp.PathPoint.Clear();
		foreach (PatrolPoint item in aiPatrolController.AllPatrolPoints)
		{
			splineComp.PathPoint.Add(item);
		}
		splineComp.MainPointIndexArray = new List<int>();
		for (int i = 0; i < splineComp.PathPoint.Count; i++)
		{
			if (splineComp.PathPoint[i].IsMain)
			{
				splineComp.MainPointIndexArray.Add(i);
			}
		}
		return true;
	}

	// Token: 0x0601AE05 RID: 110085 RVA: 0x00744124 File Offset: 0x00742324
	protected bool IsPatrolWithAiConfig()
	{
		CharacterAiComponent component = base.Entity.GetComponent<CharacterAiComponent>();
		AiPatrolController aiPatrolController = (component != null) ? component.AiController.AiPatrol : null;
		return ((aiPatrolController != null) ? aiPatrolController.AllPatrolPoints : null) != null && aiPatrolController.AllPatrolPoints.Count != 0;
	}

	// Token: 0x0601AE06 RID: 110086 RVA: 0x0074416C File Offset: 0x0074236C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterPatrolComponent characterPatrolComponent = (CharacterPatrolComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterPatrolComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterPatrolComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CreatureData"))
		{
			if (characterPatrolComponent.CreatureData == null)
			{
				this.CreatureData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureData), "CreatureData"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("RecordList"))
		{
			if (characterPatrolComponent.RecordList == null)
			{
				this.RecordList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<long, PatrolRecord>>(this.RecordList), "RecordList"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SplineInfoList"))
		{
			if (characterPatrolComponent.SplineInfoList == null)
			{
				this.SplineInfoList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<long, SplineInfo>>(this.SplineInfoList), "SplineInfoList"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurrentPatrol"))
		{
			if (characterPatrolComponent.CurrentPatrol == null)
			{
				this.CurrentPatrol = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PatrolRecord>(this.CurrentPatrol), "CurrentPatrol"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurrentSplineInfo"))
		{
			if (characterPatrolComponent.CurrentSplineInfo == null)
			{
				this.CurrentSplineInfo = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SplineInfo>(this.CurrentSplineInfo), "CurrentSplineInfo"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PauseKeyMap") && characterPatrolComponent.PauseKeyMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<long, HashSet<string>>>(this.PauseKeyMap), "PauseKeyMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ExternalData"))
		{
			if (characterPatrolComponent.ExternalData == null)
			{
				this.ExternalData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PatrolSavedData>(this.ExternalData), "ExternalData"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CacheVector"))
		{
			if (characterPatrolComponent.CacheVector == null)
			{
				this.CacheVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CacheVector), "CacheVector"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CacheVector2"))
		{
			if (characterPatrolComponent.CacheVector2 == null)
			{
				this.CacheVector2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CacheVector2), "CacheVector2"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DebugMode"))
		{
			this.DebugMode = characterPatrolComponent.DebugMode;
		}
		if (base.CanResetComponentProperty("NoRequestServer"))
		{
			this.NoRequestServer = characterPatrolComponent.NoRequestServer;
		}
		if (base.CanResetComponentProperty("ScreenPositionRef"))
		{
			this.ScreenPositionRef = characterPatrolComponent.ScreenPositionRef;
		}
		return true;
	}

	// Token: 0x0400CFD8 RID: 53208
	private const double DEFAULT_RANDOM_DISTANCE_MIN = 3000.0;

	// Token: 0x0400CFD9 RID: 53209
	private const double DEFAULT_RANDOM_DISTANCE_MAX = 7000.0;

	// Token: 0x0400CFDA RID: 53210
	[Nullable(2)]
	protected BaseActorComponent ActorComp;

	// Token: 0x0400CFDB RID: 53211
	[Nullable(2)]
	protected BaseMoveComponent MoveComp;

	// Token: 0x0400CFDC RID: 53212
	[Nullable(2)]
	protected CreatureDataComponent CreatureData;

	// Token: 0x0400CFDD RID: 53213
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<long, PatrolRecord> RecordList;

	// Token: 0x0400CFDE RID: 53214
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<long, SplineInfo> SplineInfoList;

	// Token: 0x0400CFDF RID: 53215
	[Nullable(2)]
	protected PatrolRecord CurrentPatrol;

	// Token: 0x0400CFE0 RID: 53216
	[Nullable(2)]
	protected SplineInfo CurrentSplineInfo;

	// Token: 0x0400CFE1 RID: 53217
	protected readonly Dictionary<long, HashSet<string>> PauseKeyMap = new Dictionary<long, HashSet<string>>();

	// Token: 0x0400CFE2 RID: 53218
	[Nullable(2)]
	protected PatrolSavedData ExternalData;

	// Token: 0x0400CFE3 RID: 53219
	[Nullable(2)]
	protected global::Vector CacheVector;

	// Token: 0x0400CFE4 RID: 53220
	[Nullable(2)]
	protected global::Vector CacheVector2;

	// Token: 0x0400CFE5 RID: 53221
	protected bool DebugMode;

	// Token: 0x0400CFE6 RID: 53222
	private bool NoRequestServer;

	// Token: 0x0400CFE7 RID: 53223
	private FVector2D ScreenPositionRef = new FVector2D(0f, 0f);
}
