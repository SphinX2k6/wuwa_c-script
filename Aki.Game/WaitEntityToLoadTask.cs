using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02003515 RID: 13589
[NullableContext(1)]
[Nullable(0)]
public class WaitEntityToLoadTask : IStaticVariableResetter
{
	// Token: 0x0601DC94 RID: 122004 RVA: 0x00858AFF File Offset: 0x00856CFF
	static WaitEntityToLoadTask()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WaitEntityToLoadTask.CreateStaticDefaultValue), new Action(WaitEntityToLoadTask.ResetStaticDefaultValue));
	}

	// Token: 0x0601DC95 RID: 122005 RVA: 0x00858B20 File Offset: 0x00856D20
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

	// Token: 0x0601DC96 RID: 122006 RVA: 0x00858BA1 File Offset: 0x00856DA1
	public void OnInit()
	{
		this.RegisterEvents();
		this.InLoadingEntityCount = 0L;
	}

	// Token: 0x0601DC97 RID: 122007 RVA: 0x00858BB1 File Offset: 0x00856DB1
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

	// Token: 0x0601DC98 RID: 122008 RVA: 0x00858BF0 File Offset: 0x00856DF0
	private void RegisterEvents()
	{
		EventSystem.Instance.Add(EEventName.EntityToLoadFilterCreated, new Action<EntityToLoadFilter>(this.OnEntityToLoadFilterCreated));
		EventSystem.Instance.Add(EEventName.EntityToLoadFilterDestroyed, new Action<EntityToLoadFilter>(this.OnEntityToLoadFilterDestroyed));
		EventSystem.Instance.Add<IEntityToLoadParam>(EEventName.EntityToLoadParamUpdated, new Action<IEntityToLoadParam>(this.DelayInvoke));
	}

	// Token: 0x0601DC99 RID: 122009 RVA: 0x00858C54 File Offset: 0x00856E54
	private void UnregisterEvents()
	{
		EventSystem.Instance.Remove(EEventName.EntityToLoadFilterCreated, new Action<EntityToLoadFilter>(this.OnEntityToLoadFilterCreated));
		EventSystem.Instance.Remove(EEventName.EntityToLoadFilterDestroyed, new Action<EntityToLoadFilter>(this.OnEntityToLoadFilterDestroyed));
		EventSystem.Instance.Remove(EEventName.EntityToLoadParamUpdated, new <>f__AnonymousDelegate11<IEntityToLoadParam>(this.DelayInvoke));
	}

	// Token: 0x0601DC9A RID: 122010 RVA: 0x00858CB5 File Offset: 0x00856EB5
	private void OnEntityToLoadFilterCreated(EntityToLoadFilter filter)
	{
		this.FilterChain.AddFilter(filter);
		this.DelayInvoke(null);
	}

	// Token: 0x0601DC9B RID: 122011 RVA: 0x00858CCA File Offset: 0x00856ECA
	private void OnEntityToLoadFilterDestroyed(EntityToLoadFilter filter)
	{
		this.FilterChain.RemoveFilter(filter);
		this.DelayInvoke(null);
	}

	// Token: 0x0601DC9C RID: 122012 RVA: 0x00858CE0 File Offset: 0x00856EE0
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

	// Token: 0x0601DC9D RID: 122013 RVA: 0x00858D54 File Offset: 0x00856F54
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

	// Token: 0x0601DC9E RID: 122014 RVA: 0x00858D90 File Offset: 0x00856F90
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

	// Token: 0x0601DC9F RID: 122015 RVA: 0x00858DDC File Offset: 0x00856FDC
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

	// Token: 0x0601DCA0 RID: 122016 RVA: 0x00858F2B File Offset: 0x0085712B
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

	// Token: 0x0601DCA1 RID: 122017 RVA: 0x00858F66 File Offset: 0x00857166
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

	// Token: 0x0601DCA2 RID: 122018 RVA: 0x00858FA4 File Offset: 0x008571A4
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

	// Token: 0x0601DCA3 RID: 122019 RVA: 0x0085913C File Offset: 0x0085733C
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

	// Token: 0x0601DCA4 RID: 122020 RVA: 0x00859294 File Offset: 0x00857494
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

	// Token: 0x0601DCA5 RID: 122021 RVA: 0x00859340 File Offset: 0x00857540
	private void PushToAwake(EntityHandleCallbackPair pair)
	{
		this.QueuedAwakeEntities[pair.Handle] = pair;
		this.ValidateToAwake(pair, ELoadResultType.Done, null);
	}

	// Token: 0x0601DCA6 RID: 122022 RVA: 0x00859370 File Offset: 0x00857570
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

	// Token: 0x0601DCA7 RID: 122023 RVA: 0x00859418 File Offset: 0x00857618
	private bool HasEntityForLoading()
	{
		return this.FilterChain.QueuedHeap.Size > 0 && this.InLoadingEntityCount < this.FilterChain.EntityToLoadParam.MaxLoadingCount && this.CurrentEntityFrameInterval >= this.FilterChain.EntityToLoadParam.LoadingInterval;
	}

	// Token: 0x0601DCA8 RID: 122024 RVA: 0x00859470 File Offset: 0x00857670
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

	// Token: 0x0601DCA9 RID: 122025 RVA: 0x00859624 File Offset: 0x00857824
	private void StartUpdateFrameInterval()
	{
		int frame = Time.Instance.Frame;
		if ((long)frame > this.CachedFrame)
		{
			this.CurrentEntityFrameInterval += (long)frame - this.CachedFrame;
			this.CachedFrame = (long)frame;
		}
	}

	// Token: 0x0601DCAA RID: 122026 RVA: 0x00859664 File Offset: 0x00857864
	private void EndUpdateFrameInternal()
	{
		if (this.FilterChain.QueuedHeap.Size == 0 || this.InLoadingEntityCount >= this.FilterChain.EntityToLoadParam.MaxLoadingCount || this.CurrentEntityFrameInterval >= this.FilterChain.EntityToLoadParam.LoadingInterval)
		{
			this.CurrentEntityFrameInterval = 0L;
		}
	}

	// Token: 0x0601DCAB RID: 122027 RVA: 0x008596BC File Offset: 0x008578BC
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

	// Token: 0x0601DCAC RID: 122028 RVA: 0x0085971D File Offset: 0x0085791D
	private void Sort()
	{
		if ((long)this.FilterChain.QueuedHeap.Size > this.FilterChain.EntityToLoadParam.MaxLoadingCount - this.InLoadingEntityCount)
		{
			this.FilterChain.UpdatePriority(this.GetPlayerVelocity());
		}
	}

	// Token: 0x0601DCAD RID: 122029 RVA: 0x0085975A File Offset: 0x0085795A
	private global::Vector GetPlayerVelocity()
	{
		if (WaitEntityToLoadTask.GetPlayerVelocityOverride != null)
		{
			return WaitEntityToLoadTask.GetPlayerVelocityOverride();
		}
		return global::Vector.ZeroVectorProxy;
	}

	// Token: 0x0601DCAE RID: 122030 RVA: 0x00859773 File Offset: 0x00857973
	public static void CreateStaticDefaultValue()
	{
		WaitEntityToLoadTask.EntityHandleCallbackPairPool = new Pool<EntityHandleCallbackPair>(200, () => new EntityHandleCallbackPair(), null);
	}

	// Token: 0x0601DCAF RID: 122031 RVA: 0x008597A4 File Offset: 0x008579A4
	public static void ResetStaticDefaultValue()
	{
		WaitEntityToLoadTask.GetPlayerVelocityOverride = null;
		WaitEntityToLoadTask.EntityHandleCallbackPairPool = null;
	}

	// Token: 0x0400E9C9 RID: 59849
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Func<global::Vector> GetPlayerVelocityOverride;

	// Token: 0x0400E9CA RID: 59850
	[Nullable(new byte[]
	{
		1,
		2,
		1
	})]
	private readonly Func<EntityHandle, Action<ELoadResultType>, ELoadResultType> LoadEntityCallback = ([Nullable(2)] EntityHandle _, Action<ELoadResultType> _) => ELoadResultType.None;

	// Token: 0x0400E9CB RID: 59851
	private readonly Action<EntityHandle, Action<ELoadResultType>> AddEntityToAwake = delegate(EntityHandle _, Action<ELoadResultType> _)
	{
	};

	// Token: 0x0400E9CC RID: 59852
	private static Pool<EntityHandleCallbackPair> EntityHandleCallbackPairPool;

	// Token: 0x0400E9CD RID: 59853
	private readonly Dictionary<EntityHandle, EntityHandleCallbackPair> QueuedAwakeEntities = new Dictionary<EntityHandle, EntityHandleCallbackPair>();

	// Token: 0x0400E9CE RID: 59854
	private readonly EntityToLoadFilterChain FilterChain = EntityToLoadFilterChain.Create();

	// Token: 0x0400E9CF RID: 59855
	private long InLoadingEntityCount;

	// Token: 0x0400E9D0 RID: 59856
	private long CurrentEntityFrameInterval;

	// Token: 0x0400E9D1 RID: 59857
	[Nullable(2)]
	private TimerHandle DelayTickTimerId;

	// Token: 0x0400E9D2 RID: 59858
	private long CachedFrame;
}
