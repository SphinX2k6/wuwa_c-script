using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020034BF RID: 13503
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class EntityToLoadFilterChain : FilterChain<EntityHandle>
{
	// Token: 0x170028D2 RID: 10450
	// (get) Token: 0x0601D684 RID: 120452 RVA: 0x008340E5 File Offset: 0x008322E5
	public EntityToLoadParam EntityToLoadParam { get; } = new EntityToLoadParam();

	// Token: 0x170028D3 RID: 10451
	// (get) Token: 0x0601D685 RID: 120453 RVA: 0x008340ED File Offset: 0x008322ED
	public PriorityQueue<EntityHandleCallbackPair> QueuedHeap
	{
		get
		{
			return this.QueuedHeapInternal;
		}
	}

	// Token: 0x170028D4 RID: 10452
	// (get) Token: 0x0601D686 RID: 120454 RVA: 0x008340F5 File Offset: 0x008322F5
	public IReadOnlyDictionary<EntityHandle, EntityHandleCallbackPair> QueuedEntitiesLookup
	{
		get
		{
			return this.QueuedEntitiesLookupInternal;
		}
	}

	// Token: 0x0601D687 RID: 120455 RVA: 0x00834100 File Offset: 0x00832300
	public EntityToLoadFilterChain()
	{
		this.QueuedHeapInternal = new PriorityQueue<EntityHandleCallbackPair>(delegate(EntityHandleCallbackPair a, EntityHandleCallbackPair b)
		{
			if (Math.Abs(a.Priority - b.Priority) < 0.0001f)
			{
				return a.Order.CompareTo(b.Order);
			}
			return a.Priority.CompareTo(b.Priority);
		});
	}

	// Token: 0x0601D688 RID: 120456 RVA: 0x008341BE File Offset: 0x008323BE
	public static EntityToLoadFilterChain Create()
	{
		EntityToLoadFilterChain entityToLoadFilterChain = new EntityToLoadFilterChain();
		entityToLoadFilterChain.Init();
		return entityToLoadFilterChain;
	}

	// Token: 0x0601D689 RID: 120457 RVA: 0x008341CB File Offset: 0x008323CB
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<IEntityToLoadParam>(EEventName.EntityToLoadParamUpdated, new Action<IEntityToLoadParam>(this.OnEntityToLoadParamUpdated));
		return true;
	}

	// Token: 0x0601D68A RID: 120458 RVA: 0x008341EA File Offset: 0x008323EA
	protected override bool OnCleanup()
	{
		this.QueuedHeapInternal.Clear();
		this.QueuedEntitiesPriorityDirty.Clear();
		this.QueuedEntitiesLookupInternal.Clear();
		EventSystem.Instance.Remove<IEntityToLoadParam>(EEventName.EntityToLoadParamUpdated, new Action<IEntityToLoadParam>(this.OnEntityToLoadParamUpdated));
		return true;
	}

	// Token: 0x0601D68B RID: 120459 RVA: 0x0083422C File Offset: 0x0083242C
	private unsafe void OnEntityToLoadParamUpdated(object param)
	{
		EntityToLoadParam entityToLoadParam = param as EntityToLoadParam;
		if (entityToLoadParam == null)
		{
			return;
		}
		if (entityToLoadParam.MaxLoadingCount < this.EntityToLoadParam.MaxLoadingCount)
		{
			this.EntityToLoadParam.MaxLoadingCount = entityToLoadParam.MaxLoadingCount;
			this.EntityToLoadParam.MaxLoadingDebugName = entityToLoadParam.MaxLoadingDebugName;
			if (CreatureModel.Instance.EnableEntityLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Preload;
				ELogAuthor author = ELogAuthor.XY;
				string message = "预加载实体:更新最大加载数量";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MaxLoadingCount", entityToLoadParam.MaxLoadingCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DebugName", entityToLoadParam.MaxLoadingDebugName);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		if (entityToLoadParam.LoadingInterval > this.EntityToLoadParam.LoadingInterval)
		{
			this.EntityToLoadParam.LoadingInterval = entityToLoadParam.LoadingInterval;
			this.EntityToLoadParam.LoadingIntervalDebugName = entityToLoadParam.LoadingIntervalDebugName;
			if (CreatureModel.Instance.EnableEntityLog)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Preload;
				ELogAuthor author2 = ELogAuthor.XY;
				string message2 = "预加载实体:更新帧间隔";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("FrameInterval", entityToLoadParam.LoadingInterval);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("DebugName", entityToLoadParam.LoadingIntervalDebugName);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
		}
	}

	// Token: 0x0601D68C RID: 120460 RVA: 0x00834390 File Offset: 0x00832590
	private void RefreshEntityToLoadParam()
	{
		foreach (Filter<EntityHandle> filter in base.GetAllFilters())
		{
			this.OnEntityToLoadParamUpdated(filter as EntityToLoadFilter);
		}
	}

	// Token: 0x0601D68D RID: 120461 RVA: 0x008343C4 File Offset: 0x008325C4
	private void UpdateOrder(EntityHandleCallbackPair pair)
	{
		if (this.QueuedHeapInternal.Size == 0)
		{
			this.QueueOrder = 0;
		}
		int queueOrder = this.QueueOrder;
		this.QueueOrder = queueOrder + 1;
		pair.Order = queueOrder;
	}

	// Token: 0x0601D68E RID: 120462 RVA: 0x008343FC File Offset: 0x008325FC
	private void UpdateEntityPriority(EntityHandleCallbackPair pair)
	{
		EntityHandle handle = pair.Handle;
		CreatureDataComponent creatureDataComponent;
		if (handle == null)
		{
			creatureDataComponent = null;
		}
		else
		{
			WorldEntity entity = handle.Entity;
			creatureDataComponent = ((entity != null) ? entity.GetComponent<CreatureDataComponent>() : null);
		}
		CreatureDataComponent creatureDataComponent2 = creatureDataComponent;
		if (creatureDataComponent2 == null)
		{
			return;
		}
		FVectorDouble location = creatureDataComponent2.GetLocation();
		MathUtils.Instance.CommonTempVector.DeepCopy(location);
		double num = Vector.DistSquared(MathUtils.Instance.CommonTempVector, this.CachedCharacterLocation);
		this.CachedCharacterLocation.Subtraction(MathUtils.Instance.CommonTempVector, this.TempEntityForward);
		float num2 = (float)((this.TempEntityForward.Normalize(9.99999993922529E-09) ? Vector.DotProduct(this.TempEntityForward, this.CharacterVelocityForward) : -1.0) * 0.5 + 0.5);
		pair.AngleRatio = num2;
		pair.Priority = (float)(num * (double)num2);
	}

	// Token: 0x0601D68F RID: 120463 RVA: 0x008344D0 File Offset: 0x008326D0
	protected override void OnPassedTargetModified(EntityHandle target, bool isAdd)
	{
		if (!this.QueuedEntitiesLookupInternal.ContainsKey(target))
		{
			return;
		}
		EntityHandleCallbackPair item = this.QueuedEntitiesLookupInternal[target];
		if (isAdd)
		{
			this.QueuedHeapInternal.Push(item);
			return;
		}
		this.QueuedHeapInternal.Remove(item);
	}

	// Token: 0x0601D690 RID: 120464 RVA: 0x00834516 File Offset: 0x00832716
	public override void AddFilter(Filter<EntityHandle> filter)
	{
		base.AddFilter(filter);
		this.OnEntityToLoadParamUpdated(filter);
	}

	// Token: 0x0601D691 RID: 120465 RVA: 0x00834526 File Offset: 0x00832726
	public override bool RemoveFilter(Filter<EntityHandle> filter)
	{
		this.RefreshEntityToLoadParam();
		return base.RemoveFilter(filter);
	}

	// Token: 0x0601D692 RID: 120466 RVA: 0x00834538 File Offset: 0x00832738
	public unsafe void AddPair(EntityHandleCallbackPair pair)
	{
		this.UpdateOrder(pair);
		this.QueuedEntitiesLookupInternal[pair.Handle] = pair;
		this.QueuedEntitiesPriorityDirty.Add(pair.Handle);
		base.AddTarget(pair.Handle, EFilterType.Top);
		if (CreatureModel.Instance.EnableEntityLog)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Preload;
			ELogAuthor author = ELogAuthor.XY;
			string message = "预加载实体:进入加载队列";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", pair.Handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureDataId", pair.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PbDataId", pair.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Priority", pair.Priority);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Order", pair.Order);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Version", pair.Version);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("Remain", this.QueuedHeapInternal.Size);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		}
	}

	// Token: 0x0601D693 RID: 120467 RVA: 0x008346A7 File Offset: 0x008328A7
	public void RemovePair(EntityHandleCallbackPair pair)
	{
		if (this.QueuedEntitiesLookupInternal.Remove(pair.Handle))
		{
			this.QueuedHeapInternal.Remove(pair);
			base.RemoveTarget(pair.Handle);
		}
	}

	// Token: 0x0601D694 RID: 120468 RVA: 0x008346D8 File Offset: 0x008328D8
	[NullableContext(2)]
	public EntityHandleCallbackPair PopTopPair()
	{
		if (this.QueuedHeapInternal.Size > 0)
		{
			EntityHandleCallbackPair entityHandleCallbackPair = this.QueuedHeapInternal.Pop();
			if (this.QueuedEntitiesLookupInternal.Remove(entityHandleCallbackPair.Handle))
			{
				base.RemoveTarget(entityHandleCallbackPair.Handle);
			}
			return entityHandleCallbackPair;
		}
		return null;
	}

	// Token: 0x0601D695 RID: 120469 RVA: 0x00834724 File Offset: 0x00832924
	public void UpdatePriority(Vector playerVelocity)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		CharacterActorComponent characterActorComponent;
		if (getCurrentEntity == null)
		{
			characterActorComponent = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
		}
		CharacterActorComponent characterActorComponent2 = characterActorComponent;
		if (characterActorComponent2 == null)
		{
			return;
		}
		if (!Vector.PointsAreSame(this.CachedCharacterLocation, characterActorComponent2.ActorLocationProxy) || !Vector.PointsAreSame(this.CachedCharacterForward, characterActorComponent2.ActorForwardProxy))
		{
			this.CachedCharacterLocation.DeepCopy(characterActorComponent2.ActorLocationProxy);
			this.CachedCharacterForward.DeepCopy(characterActorComponent2.ActorForwardProxy);
			this.CachedCharacterForward.AdditionEqual(playerVelocity).GetSafeNormal(this.CharacterVelocityForward, 9.99999993922529E-09);
			this.QueuedEntitiesPriorityDirty.Clear();
			foreach (EntityHandleCallbackPair pair in this.QueuedEntitiesLookupInternal.Values)
			{
				this.UpdateEntityPriority(pair);
			}
			this.QueuedHeapInternal.Heapify();
			return;
		}
		if (this.QueuedEntitiesPriorityDirty.Count > 0)
		{
			foreach (EntityHandle key in this.QueuedEntitiesPriorityDirty)
			{
				EntityHandleCallbackPair pair2;
				if (this.QueuedEntitiesLookupInternal.TryGetValue(key, out pair2))
				{
					this.UpdateEntityPriority(pair2);
				}
			}
			this.QueuedEntitiesPriorityDirty.Clear();
			this.QueuedHeapInternal.Heapify();
		}
	}

	// Token: 0x0400E7B3 RID: 59315
	private readonly PriorityQueue<EntityHandleCallbackPair> QueuedHeapInternal;

	// Token: 0x0400E7B4 RID: 59316
	private readonly Dictionary<EntityHandle, EntityHandleCallbackPair> QueuedEntitiesLookupInternal = new Dictionary<EntityHandle, EntityHandleCallbackPair>();

	// Token: 0x0400E7B5 RID: 59317
	private readonly List<EntityHandle> QueuedEntitiesPriorityDirty = new List<EntityHandle>();

	// Token: 0x0400E7B6 RID: 59318
	private readonly Vector CachedCharacterLocation = Vector.Create();

	// Token: 0x0400E7B7 RID: 59319
	private readonly Vector CachedCharacterForward = Vector.Create();

	// Token: 0x0400E7B8 RID: 59320
	private readonly Vector CharacterVelocityForward = Vector.Create();

	// Token: 0x0400E7B9 RID: 59321
	private readonly Vector TempEntityForward = Vector.Create();

	// Token: 0x0400E7BA RID: 59322
	private readonly Stat UpdatePriorityStat = Stat.Create("WaitEntityToLoadTask.UpdatePriority", "", "");

	// Token: 0x0400E7BB RID: 59323
	private readonly Stat RefreshEntityToLoadParamStat = Stat.Create("EntityToLoadFilterChain.RefreshEntityToLoadParamStat", "", "");

	// Token: 0x0400E7BC RID: 59324
	private int QueueOrder;
}
