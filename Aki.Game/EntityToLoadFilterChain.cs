using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002A33 RID: 10803
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class EntityToLoadFilterChain : FilterChain<EntityHandle>
{
	// Token: 0x17002C6A RID: 11370
	// (get) Token: 0x0601B383 RID: 111491 RVA: 0x0085B58D File Offset: 0x0085978D
	public EntityToLoadParam EntityToLoadParam { get; } = new EntityToLoadParam();

	// Token: 0x17002C6B RID: 11371
	// (get) Token: 0x0601B384 RID: 111492 RVA: 0x0085B595 File Offset: 0x00859795
	public PriorityQueue<EntityHandleCallbackPair> QueuedHeap
	{
		get
		{
			return this.QueuedHeapInternal;
		}
	}

	// Token: 0x17002C6C RID: 11372
	// (get) Token: 0x0601B385 RID: 111493 RVA: 0x0085B59D File Offset: 0x0085979D
	public IReadOnlyDictionary<EntityHandle, EntityHandleCallbackPair> QueuedEntitiesLookup
	{
		get
		{
			return this.QueuedEntitiesLookupInternal;
		}
	}

	// Token: 0x0601B386 RID: 111494 RVA: 0x0085B5A8 File Offset: 0x008597A8
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

	// Token: 0x0601B387 RID: 111495 RVA: 0x0085B666 File Offset: 0x00859866
	public static EntityToLoadFilterChain Create()
	{
		EntityToLoadFilterChain entityToLoadFilterChain = new EntityToLoadFilterChain();
		entityToLoadFilterChain.Init();
		return entityToLoadFilterChain;
	}

	// Token: 0x0601B388 RID: 111496 RVA: 0x0085B673 File Offset: 0x00859873
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<IEntityToLoadParam>(EEventName.EntityToLoadParamUpdated, new Action<IEntityToLoadParam>(this.OnEntityToLoadParamUpdated));
		return true;
	}

	// Token: 0x0601B389 RID: 111497 RVA: 0x0085B692 File Offset: 0x00859892
	protected override bool OnCleanup()
	{
		this.QueuedHeapInternal.Clear();
		this.QueuedEntitiesPriorityDirty.Clear();
		this.QueuedEntitiesLookupInternal.Clear();
		EventSystem.Instance.Remove<IEntityToLoadParam>(EEventName.EntityToLoadParamUpdated, new Action<IEntityToLoadParam>(this.OnEntityToLoadParamUpdated));
		return true;
	}

	// Token: 0x0601B38A RID: 111498 RVA: 0x0085B6D4 File Offset: 0x008598D4
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

	// Token: 0x0601B38B RID: 111499 RVA: 0x0085B838 File Offset: 0x00859A38
	private void RefreshEntityToLoadParam()
	{
		foreach (Filter<EntityHandle> filter in base.GetAllFilters())
		{
			this.OnEntityToLoadParamUpdated(filter as EntityToLoadFilter);
		}
	}

	// Token: 0x0601B38C RID: 111500 RVA: 0x0085B86C File Offset: 0x00859A6C
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

	// Token: 0x0601B38D RID: 111501 RVA: 0x0085B8A4 File Offset: 0x00859AA4
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

	// Token: 0x0601B38E RID: 111502 RVA: 0x0085B978 File Offset: 0x00859B78
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

	// Token: 0x0601B38F RID: 111503 RVA: 0x0085B9BE File Offset: 0x00859BBE
	public override void AddFilter(Filter<EntityHandle> filter)
	{
		base.AddFilter(filter);
		this.OnEntityToLoadParamUpdated(filter);
	}

	// Token: 0x0601B390 RID: 111504 RVA: 0x0085B9CE File Offset: 0x00859BCE
	public override bool RemoveFilter(Filter<EntityHandle> filter)
	{
		this.RefreshEntityToLoadParam();
		return base.RemoveFilter(filter);
	}

	// Token: 0x0601B391 RID: 111505 RVA: 0x0085B9E0 File Offset: 0x00859BE0
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

	// Token: 0x0601B392 RID: 111506 RVA: 0x0085BB4F File Offset: 0x00859D4F
	public void RemovePair(EntityHandleCallbackPair pair)
	{
		if (this.QueuedEntitiesLookupInternal.Remove(pair.Handle))
		{
			this.QueuedHeapInternal.Remove(pair);
			base.RemoveTarget(pair.Handle);
		}
	}

	// Token: 0x0601B393 RID: 111507 RVA: 0x0085BB80 File Offset: 0x00859D80
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

	// Token: 0x0601B394 RID: 111508 RVA: 0x0085BBCC File Offset: 0x00859DCC
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

	// Token: 0x0400EC67 RID: 60519
	private readonly PriorityQueue<EntityHandleCallbackPair> QueuedHeapInternal;

	// Token: 0x0400EC68 RID: 60520
	private readonly Dictionary<EntityHandle, EntityHandleCallbackPair> QueuedEntitiesLookupInternal = new Dictionary<EntityHandle, EntityHandleCallbackPair>();

	// Token: 0x0400EC69 RID: 60521
	private readonly List<EntityHandle> QueuedEntitiesPriorityDirty = new List<EntityHandle>();

	// Token: 0x0400EC6A RID: 60522
	private readonly Vector CachedCharacterLocation = Vector.Create();

	// Token: 0x0400EC6B RID: 60523
	private readonly Vector CachedCharacterForward = Vector.Create();

	// Token: 0x0400EC6C RID: 60524
	private readonly Vector CharacterVelocityForward = Vector.Create();

	// Token: 0x0400EC6D RID: 60525
	private readonly Vector TempEntityForward = Vector.Create();

	// Token: 0x0400EC6E RID: 60526
	private readonly Stat UpdatePriorityStat = Stat.Create("WaitEntityToLoadTask.UpdatePriority", "", "");

	// Token: 0x0400EC6F RID: 60527
	private readonly Stat RefreshEntityToLoadParamStat = Stat.Create("EntityToLoadFilterChain.RefreshEntityToLoadParamStat", "", "");

	// Token: 0x0400EC70 RID: 60528
	private int QueueOrder;
}
