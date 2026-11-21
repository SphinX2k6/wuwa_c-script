using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002A8A RID: 10890
[NullableContext(1)]
[Nullable(0)]
public class WaitEntityToLoadTask : IStaticVariableResetter
{
	// Token: 0x0601B9AE RID: 113070 RVA: 0x008810A7 File Offset: 0x0087F2A7
	static WaitEntityToLoadTask()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WaitEntityToLoadTask.CreateStaticDefaultValue), new Action(WaitEntityToLoadTask.ResetStaticDefaultValue));
	}

	// Token: 0x0601B9AF RID: 113071 RVA: 0x008810C8 File Offset: 0x0087F2C8
	public WaitEntityToLoadTask([Nullable(new byte[]
	{
		1,
		2,
		1
	})] Func<EntityHandle, Action<ELoadResultType>, ELoadResultType> loadEntityCallback, Action<EntityHandle, Action<ELoadResultType>> addEntityToAwake)
	{
		this.LoadEntityCallback = loadEntityCallback;
		this.AddEntityToAwake = addEntityToAwake;
	}

	// Token: 0x0601B9B0 RID: 113072 RVA: 0x00881149 File Offset: 0x0087F349
	public void OnInit()
	{
		this.RegisterEvents();
		this.InLoadingEntityCount = 0L;
	}

	// Token: 0x0601B9B1 RID: 113073 RVA: 0x00881159 File Offset: 0x0087F359
	public void OnClear()
	{
		this.UnregisterEvents();
		this.QueuedAwakeEntities.Clear();
		if (this.DelayTickTimerId != null)
		{
			TimerSystem.Instance.Remove(this.DelayTickTimerId);
			this.DelayTickTimerId = null;
		}
		this.FilterChain.Cleanup();
	}

	// Token: 0x0601B9B2 RID: 113074 RVA: 0x00881198 File Offset: 0x0087F398
	private void RegisterEvents()
	{
		EventSystem.Instance.Add(EEventName.EntityToLoadFilterCreated, new Action<EntityToLoadFilter>(this.OnEntityToLoadFilterCreated));
		EventSystem.Instance.Add(EEventName.EntityToLoadFilterDestroyed, new Action<EntityToLoadFilter>(this.OnEntityToLoadFilterDestroyed));
		EventSystem.Instance.Add<IEntityToLoadParam>(EEventName.EntityToLoadParamUpdated, new Action<IEntityToLoadParam>(this.DelayInvoke));
	}

	// Token: 0x0601B9B3 RID: 113075 RVA: 0x008811FC File Offset: 0x0087F3FC
	private void UnregisterEvents()
	{
		EventSystem.Instance.Remove(EEventName.EntityToLoadFilterCreated, new Action<EntityToLoadFilter>(this.OnEntityToLoadFilterCreated));
		EventSystem.Instance.Remove(EEventName.EntityToLoadFilterDestroyed, new Action<EntityToLoadFilter>(this.OnEntityToLoadFilterDestroyed));
		EventSystem.Instance.Remove(EEventName.EntityToLoadParamUpdated, new <>f__AnonymousDelegate11<IEntityToLoadParam>(this.DelayInvoke));
	}

	// Token: 0x0601B9B4 RID: 113076 RVA: 0x0088125D File Offset: 0x0087F45D
	private void OnEntityToLoadFilterCreated(EntityToLoadFilter filter)
	{
		this.FilterChain.AddFilter(filter);
		this.DelayInvoke(null);
	}

	// Token: 0x0601B9B5 RID: 113077 RVA: 0x00881272 File Offset: 0x0087F472
	private void OnEntityToLoadFilterDestroyed(EntityToLoadFilter filter)
	{
		this.FilterChain.RemoveFilter(filter);
		this.DelayInvoke(null);
	}

	// Token: 0x0601B9B6 RID: 113078 RVA: 0x00881288 File Offset: 0x0087F488
	private static EntityHandleCallbackPair GetOrCreatePair(EntityHandle handle, [Nullable(2)] Action<ELoadResultType> callback, long creatureDataId, int pbDataId)
	{
		EntityHandleCallbackPair entityHandleCallbackPair = WaitEntityToLoadTask.EntityHandleCallbackPairPool.Get();
		if (entityHandleCallbackPair == null)
		{
			entityHandleCallbackPair = WaitEntityToLoadTask.EntityHandleCallbackPairPool.Create();
		}
		entityHandleCallbackPair.Handle = handle;
		entityHandleCallbackPair.CreatureDataId = creatureDataId;
		entityHandleCallbackPair.PbDataId = pbDataId;
		entityHandleCallbackPair.Priority = (float)handle.Priority;
		entityHandleCallbackPair.AngleRatio = 0f;
		entityHandleCallbackPair.Order = 0;
		entityHandleCallbackPair.AddCallback(callback);
		EntityHandleCallbackPair entityHandleCallbackPair2 = entityHandleCallbackPair;
		int version = entityHandleCallbackPair2.Version;
		entityHandleCallbackPair2.Version = version + 1;
		return entityHandleCallbackPair;
	}

	// Token: 0x0601B9B7 RID: 113079 RVA: 0x008812FC File Offset: 0x0087F4FC
	[return: Nullable(2)]
	private EntityHandleCallbackPair FindEntity(EntityHandle handle)
	{
		EntityHandleCallbackPair entityHandleCallbackPair = null;
		EntityHandleCallbackPair entityHandleCallbackPair2;
		if (this.QueuedAwakeEntities.TryGetValue(handle, out entityHandleCallbackPair2))
		{
			entityHandleCallbackPair = entityHandleCallbackPair2;
		}
		EntityHandleCallbackPair entityHandleCallbackPair3;
		if (entityHandleCallbackPair == null && this.FilterChain.QueuedEntitiesLookup.TryGetValue(handle, out entityHandleCallbackPair3))
		{
			entityHandleCallbackPair = entityHandleCallbackPair3;
		}
		return entityHandleCallbackPair;
	}

	// Token: 0x0601B9B8 RID: 113080 RVA: 0x00881338 File Offset: 0x0087F538
	private static bool ShouldPreloadEntity(EntityHandle handle)
	{
		CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
		if (PreloadSetting.UseNewPreload && component.GetPreloadFinished())
		{
			return false;
		}
		EEntityType entityType = component.GetEntityType();
		if (entityType == EEntityType.Custom || entityType == EEntityType.PlayerEntity)
		{
			if (entityType == EEntityType.PlayerEntity)
			{
				handle.Priority = ResourceSystem.EResourceLoadPriority.Max;
			}
			return false;
		}
		return true;
	}

	// Token: 0x0601B9B9 RID: 113081 RVA: 0x00881384 File Offset: 0x0087F584
	public unsafe void QueueToInvoke(EntityHandle handle, [Nullable(2)] Action<ELoadResultType> callback, long creatureDataId, int pbDataId)
	{
		EntityHandleCallbackPair entityHandleCallbackPair = this.FindEntity(handle);
		if (entityHandleCallbackPair != null)
		{
			entityHandleCallbackPair.AddCallback(callback);
			return;
		}
		entityHandleCallbackPair = WaitEntityToLoadTask.GetOrCreatePair(handle, callback, creatureDataId, pbDataId);
		if (!WaitEntityToLoadTask.ShouldPreloadEntity(handle))
		{
			if (CreatureModel.Instance.EnableEntityLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Preload;
				ELogAuthor author = ELogAuthor.XY;
				string message = "预加载实体:不需要预加载，直接唤醒";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", handle.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureDataId", entityHandleCallbackPair.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PbDataId", entityHandleCallbackPair.PbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Priority", entityHandleCallbackPair.Priority);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Order", entityHandleCallbackPair.Order);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Version", entityHandleCallbackPair.Version);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			}
			this.PushToAwake(entityHandleCallbackPair);
			return;
		}
		this.FilterChain.AddPair(entityHandleCallbackPair);
		this.DelayInvoke(null);
	}

	// Token: 0x0601B9BA RID: 113082 RVA: 0x008814D3 File Offset: 0x0087F6D3
	public void DelayInvoke(IEntityToLoadParam _ = null)
	{
		if (this.DelayTickTimerId == null && this.FilterChain.QueuedHeap.Size > 0)
		{
			this.DelayTickTimerId = TimerSystem.Instance.Next(delegate(float _)
			{
				this.DelayTickTimerId = null;
				this.ValidateToInvoke();
			}, null, null);
		}
	}

	// Token: 0x0601B9BB RID: 113083 RVA: 0x0088150E File Offset: 0x0087F70E
	public void Flush()
	{
		if (this.DelayTickTimerId != null)
		{
			TimerSystem.Instance.Remove(this.DelayTickTimerId);
			this.DelayTickTimerId = null;
		}
		while (!this.FilterChain.QueuedHeap.Empty)
		{
			this.InvokeTop();
		}
	}

	// Token: 0x0601B9BC RID: 113084 RVA: 0x0088154C File Offset: 0x0087F74C
	public unsafe void RemoveEntity(EntityHandle entityHandle)
	{
		EntityHandleCallbackPair entityHandleCallbackPair = this.FindEntity(entityHandle);
		if (entityHandleCallbackPair == null)
		{
			return;
		}
		this.FilterChain.RemovePair(entityHandleCallbackPair);
		this.InvokeAwakeCallback(entityHandleCallbackPair, ELoadResultType.Destroy);
		if (CreatureModel.Instance.EnableEntityLog)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Preload;
			ELogAuthor author = ELogAuthor.XY;
			string message = "预加载实体:移除加载队列";
			<>y__InlineArray9<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray9<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RemoveType", "Outside");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", entityHandle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CreatureDataId", entityHandleCallbackPair.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("PbDataId", entityHandleCallbackPair.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AngleRatio", entityHandleCallbackPair.AngleRatio);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Priority", entityHandleCallbackPair.Priority);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("Order", entityHandleCallbackPair.Order);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("Version", entityHandleCallbackPair.Version);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("Remain", this.FilterChain.QueuedHeap.Size);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 9));
		}
	}

	// Token: 0x0601B9BD RID: 113085 RVA: 0x008816E4 File Offset: 0x0087F8E4
	private unsafe void InvokeAwakeCallback(EntityHandleCallbackPair pair, ELoadResultType result)
	{
		if (CreatureModel.Instance.EnableEntityLog)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Preload;
			ELogAuthor author = ELogAuthor.XY;
			string message = "预加载实体:执行加载回调";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", pair.Handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureDataId", pair.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PbDataId", pair.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Priority", pair.Priority);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Order", pair.Order);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Version", pair.Version);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("Result", result);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		}
		this.QueuedAwakeEntities.Remove(pair.Handle);
		pair.InvokeCallbacks(result);
		pair.ClearCallbacks();
		WaitEntityToLoadTask.EntityHandleCallbackPairPool.Put(pair);
	}

	// Token: 0x0601B9BE RID: 113086 RVA: 0x0088183C File Offset: 0x0087FA3C
	private void ValidateToAwake(EntityHandleCallbackPair pair, ELoadResultType result, long? version = null)
	{
		long pairVersion = version ?? ((long)pair.Version);
		if (!this.QueuedAwakeEntities.ContainsKey(pair.Handle) || pairVersion != (long)pair.Version)
		{
			return;
		}
		if (result2 == ELoadResultType.Done || result2 == ELoadResultType.Fail)
		{
			this.AddEntityToAwake(pair.Handle, delegate(ELoadResultType result)
			{
				if (!this.QueuedAwakeEntities.ContainsKey(pair.Handle) || pairVersion != (long)pair.Version)
				{
					return;
				}
				this.InvokeAwakeCallback(pair, result);
			});
			return;
		}
		this.InvokeAwakeCallback(pair, result2);
	}

	// Token: 0x0601B9BF RID: 113087 RVA: 0x008818E8 File Offset: 0x0087FAE8
	private void PushToAwake(EntityHandleCallbackPair pair)
	{
		this.QueuedAwakeEntities[pair.Handle] = pair;
		this.ValidateToAwake(pair, ELoadResultType.Done, null);
	}

	// Token: 0x0601B9C0 RID: 113088 RVA: 0x00881918 File Offset: 0x0087FB18
	private void Invoke(EntityHandleCallbackPair pair)
	{
		WaitEntityToLoadTask.<>c__DisplayClass28_0 CS$<>8__locals1 = new WaitEntityToLoadTask.<>c__DisplayClass28_0();
		CS$<>8__locals1.pair = pair;
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.loadDone = false;
		CS$<>8__locals1.timeoutCheckTimerId = null;
		CS$<>8__locals1.isTimeout = false;
		CS$<>8__locals1.pairVersion = CS$<>8__locals1.pair.Version;
		this.InLoadingEntityCount += 1L;
		this.QueuedAwakeEntities[CS$<>8__locals1.pair.Handle] = CS$<>8__locals1.pair;
		ELoadResultType eloadResultType = this.LoadEntityCallback(CS$<>8__locals1.pair.Handle, new Action<ELoadResultType>(CS$<>8__locals1.<Invoke>g__callback|2));
		if (eloadResultType != ELoadResultType.Loading)
		{
			CS$<>8__locals1.<Invoke>g__callback|2(eloadResultType);
			return;
		}
		CS$<>8__locals1.<Invoke>g__beginTimeoutCheck|1();
	}

	// Token: 0x0601B9C1 RID: 113089 RVA: 0x008819C0 File Offset: 0x0087FBC0
	private bool HasEntityForLoading()
	{
		return this.FilterChain.QueuedHeap.Size > 0 && this.InLoadingEntityCount < this.FilterChain.EntityToLoadParam.MaxLoadingCount && this.CurrentEntityFrameInterval >= this.FilterChain.EntityToLoadParam.LoadingInterval;
	}

	// Token: 0x0601B9C2 RID: 113090 RVA: 0x00881A18 File Offset: 0x0087FC18
	private unsafe void InvokeTop()
	{
		EntityHandleCallbackPair entityHandleCallbackPair = this.FilterChain.PopTopPair();
		if (entityHandleCallbackPair != null)
		{
			if (CreatureModel.Instance.EnableEntityLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Preload;
				ELogAuthor author = ELogAuthor.XY;
				string message = "预加载实体:移除加载队列";
				<>y__InlineArray9<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray9<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RemoveType", "InvokeTop");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", entityHandleCallbackPair.Handle.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CreatureDataId", entityHandleCallbackPair.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("PbDataId", entityHandleCallbackPair.PbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AngleRatio", entityHandleCallbackPair.AngleRatio);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Priority", entityHandleCallbackPair.Priority);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("Order", entityHandleCallbackPair.Order);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("Version", entityHandleCallbackPair.Version);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("Remain", this.FilterChain.QueuedHeap.Size);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 9));
			}
			this.Invoke(entityHandleCallbackPair);
			return;
		}
		Log.Instance.Error(ELogModule.Preload, ELogAuthor.XDW, "预加载实体:调用InvokeTop之前需要确保优先队列不为空", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601B9C3 RID: 113091 RVA: 0x00881BCC File Offset: 0x0087FDCC
	private void StartUpdateFrameInterval()
	{
		int frame = Time.Instance.Frame;
		if ((long)frame > this.CachedFrame)
		{
			this.CurrentEntityFrameInterval += (long)frame - this.CachedFrame;
			this.CachedFrame = (long)frame;
		}
	}

	// Token: 0x0601B9C4 RID: 113092 RVA: 0x00881C0C File Offset: 0x0087FE0C
	private void EndUpdateFrameInternal()
	{
		if (this.FilterChain.QueuedHeap.Size == 0 || this.InLoadingEntityCount >= this.FilterChain.EntityToLoadParam.MaxLoadingCount || this.CurrentEntityFrameInterval >= this.FilterChain.EntityToLoadParam.LoadingInterval)
		{
			this.CurrentEntityFrameInterval = 0L;
		}
	}

	// Token: 0x0601B9C5 RID: 113093 RVA: 0x00881C64 File Offset: 0x0087FE64
	private void ValidateToInvoke()
	{
		this.StartUpdateFrameInterval();
		while (this.HasEntityForLoading())
		{
			this.Sort();
			this.InvokeTop();
		}
		this.EndUpdateFrameInternal();
		if (this.FilterChain.QueuedHeap.Size > 0 && this.InLoadingEntityCount < this.FilterChain.EntityToLoadParam.MaxLoadingCount)
		{
			this.DelayInvoke(null);
		}
	}

	// Token: 0x0601B9C6 RID: 113094 RVA: 0x00881CC5 File Offset: 0x0087FEC5
	private void Sort()
	{
		if ((long)this.FilterChain.QueuedHeap.Size > this.FilterChain.EntityToLoadParam.MaxLoadingCount - this.InLoadingEntityCount)
		{
			this.FilterChain.UpdatePriority(this.GetPlayerVelocity());
		}
	}

	// Token: 0x0601B9C7 RID: 113095 RVA: 0x00881D02 File Offset: 0x0087FF02
	private global::Vector GetPlayerVelocity()
	{
		if (WaitEntityToLoadTask.GetPlayerVelocityOverride != null)
		{
			return WaitEntityToLoadTask.GetPlayerVelocityOverride();
		}
		return global::Vector.ZeroVectorProxy;
	}

	// Token: 0x0601B9C8 RID: 113096 RVA: 0x00881D1B File Offset: 0x0087FF1B
	public static void CreateStaticDefaultValue()
	{
		WaitEntityToLoadTask.EntityHandleCallbackPairPool = new Pool<EntityHandleCallbackPair>(200, () => new EntityHandleCallbackPair(), null);
	}

	// Token: 0x0601B9C9 RID: 113097 RVA: 0x00881D4C File Offset: 0x0087FF4C
	public static void ResetStaticDefaultValue()
	{
		WaitEntityToLoadTask.GetPlayerVelocityOverride = null;
		WaitEntityToLoadTask.EntityHandleCallbackPairPool = null;
	}

	// Token: 0x0400EE84 RID: 61060
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Func<global::Vector> GetPlayerVelocityOverride;

	// Token: 0x0400EE85 RID: 61061
	[Nullable(new byte[]
	{
		1,
		2,
		1
	})]
	private readonly Func<EntityHandle, Action<ELoadResultType>, ELoadResultType> LoadEntityCallback = ([Nullable(2)] EntityHandle _, Action<ELoadResultType> _) => ELoadResultType.None;

	// Token: 0x0400EE86 RID: 61062
	private readonly Action<EntityHandle, Action<ELoadResultType>> AddEntityToAwake = delegate(EntityHandle _, Action<ELoadResultType> _)
	{
	};

	// Token: 0x0400EE87 RID: 61063
	private static Pool<EntityHandleCallbackPair> EntityHandleCallbackPairPool;

	// Token: 0x0400EE88 RID: 61064
	private readonly Dictionary<EntityHandle, EntityHandleCallbackPair> QueuedAwakeEntities = new Dictionary<EntityHandle, EntityHandleCallbackPair>();

	// Token: 0x0400EE89 RID: 61065
	private readonly EntityToLoadFilterChain FilterChain = EntityToLoadFilterChain.Create();

	// Token: 0x0400EE8A RID: 61066
	private long InLoadingEntityCount;

	// Token: 0x0400EE8B RID: 61067
	private long CurrentEntityFrameInterval;

	// Token: 0x0400EE8C RID: 61068
	[Nullable(2)]
	private TimerHandle DelayTickTimerId;

	// Token: 0x0400EE8D RID: 61069
	private long CachedFrame;
}
