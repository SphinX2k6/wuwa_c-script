using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02000007 RID: 7
[NullableContext(1)]
[Nullable(0)]
public class ActorSystem : Singleton
{
	// Token: 0x06000010 RID: 16 RVA: 0x00002358 File Offset: 0x00000558
	public void Initialize()
	{
		UKuroActorManager.InitActorManager();
		this.SetBudget(AEffectSystemActor.StaticClass(), 100);
		TickSystem.Instance.Add(new Action<float>(this.Tick), "ActorSystem.Tick", ETickingGroup.TG_DuringPhysics, true, 0, false);
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000011 RID: 17 RVA: 0x0000238D File Offset: 0x0000058D
	public int Size
	{
		get
		{
			return this.SizeInternal;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000012 RID: 18 RVA: 0x00002395 File Offset: 0x00000595
	// (set) Token: 0x06000013 RID: 19 RVA: 0x000023A0 File Offset: 0x000005A0
	public int Capacity
	{
		get
		{
			return this.CapacityInternal;
		}
		set
		{
			if (value < 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Core;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "容量错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("capacity", value);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.DecayRate = 1f - 1f / (float)value;
			this.HitCount = this.HitCount / (float)this.CapacityInternal * (float)value;
			this.MissCount = this.MissCount / (float)this.CapacityInternal * (float)value;
			this.CapacityInternal = value;
			while (this.SizeInternal > value || this.Queue.Size > value)
			{
				this.Evict();
			}
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000014 RID: 20 RVA: 0x00002445 File Offset: 0x00000645
	public float HitRate
	{
		get
		{
			if (this.HitCount <= 0f)
			{
				return 0f;
			}
			return this.HitCount / (this.HitCount + this.MissCount);
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000246E File Offset: 0x0000066E
	[NullableContext(2)]
	public AActor Get(UClassStackOnlyPtr ueClassPtr, FTransformDouble transform, AActor owner = null, bool bForceReset = true)
	{
		return this.Get<AActor>(ueClassPtr, transform, owner, bForceReset);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000247C File Offset: 0x0000067C
	[NullableContext(2)]
	public unsafe T Get<[Nullable(0)] T>(UClassStackOnlyPtr ueClassPtr, FTransformDouble transform, AActor owner = null, bool bForceReset = true) where T : AActor
	{
		if (!this.CheckClass(ueClassPtr))
		{
			return default(T);
		}
		TWeakObjectPtr<UClass> tweakObjectPtr = ueClassPtr.ToWeakClass();
		this.CreateStat(this.GetStatMap, tweakObjectPtr, "ActorSystem.Get.");
		if (!this.Enable || this.State != EActorSystemState.Ready)
		{
			return this.Spawn<T>(ueClassPtr, transform, owner);
		}
		Entry entry;
		if (!this.Cache.TryGetValue(tweakObjectPtr, out entry))
		{
			entry = new Entry(tweakObjectPtr, this.Budget.GetValueOrDefault(tweakObjectPtr, 0));
			double milliseconds = KuroTime.GetMilliseconds64();
			T result = this.SpawnAsPoolActor<T>(ueClassPtr, tweakObjectPtr, transform, owner);
			entry.Touch(new double?(KuroTime.GetMilliseconds64() - milliseconds));
			this.Queue.Push(entry);
			this.Cache[tweakObjectPtr] = entry;
			this.HitCount *= this.DecayRate;
			this.MissCount = this.MissCount * this.DecayRate + 1f;
			if (Info.Instance.IsBuildDevelopmentOrDebug)
			{
				ActorSystemDebugger.Instance.RecordGetPut(new GetPutRecord
				{
					ClassName = tweakObjectPtr.GetName(),
					GetOrPut = "Get",
					Hit = false,
					TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
					ThisTypeTotal = 0,
					HitRate = this.HitRate,
					CurrentTotal = this.Size,
					PendingKillNum = this.Pending.Count
				});
			}
			return result;
		}
		Dictionary<AActor, int> values = entry.Values;
		AActor aactor = null;
		while (values.Count > 0)
		{
			int num = 0;
			using (Dictionary<AActor, int>.Enumerator enumerator = values.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<AActor, int> keyValuePair = enumerator.Current;
					aactor = keyValuePair.Key;
					num = keyValuePair.Value;
				}
			}
			values.Remove(aactor);
			this.SizeInternal--;
			string valueOrDefault = this.Reason.GetValueOrDefault(num);
			if (aactor == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActorSystem;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "对象不存在";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Target", aactor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ueClass", tweakObjectPtr.GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", valueOrDefault);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				aactor = null;
			}
			else if (!aactor.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.ActorSystem;
				ELogAuthor author2 = ELogAuthor.LCC;
				string message2 = "对象无效";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Target", aactor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ueClass", tweakObjectPtr.GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Reason", valueOrDefault);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				aactor = null;
			}
			else
			{
				aactor.OnEndPlay.Remove(new Action<AActor, TEnumAsByte<EEndPlayReason>>(this.OnEndPlay));
				UWorld world = aactor.GetWorld();
				if (world == null || !world.IsValid())
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.ActorSystem;
					ELogAuthor author3 = ELogAuthor.LCC;
					string message3 = "Actor所属World无效";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("ueClass", tweakObjectPtr.GetName());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", valueOrDefault);
					instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					this.Pending.Add(new PendingActor
					{
						Actor = aactor,
						Klass = aactor.GetClass().GetName(),
						ReasonId = num
					});
					aactor = null;
				}
				else
				{
					if (bForceReset)
					{
						if (!ActorPoolGuard.PrepareActorBeforeDePool(aactor))
						{
							Log instance4 = Log.Instance;
							ELogModule module4 = ELogModule.ActorSystem;
							ELogAuthor author4 = ELogAuthor.LCC;
							string message4 = "Actor出池重置失败";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("ueClass", tweakObjectPtr.GetName());
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Reason", valueOrDefault);
							instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
							this.Pending.Add(new PendingActor
							{
								Actor = aactor,
								Klass = aactor.GetClass().GetName(),
								ReasonId = num
							});
							aactor = null;
							continue;
						}
						aactor.OnDestroyed.Remove(new Action<AActor>(this.SubReference));
						aactor.OnDestroyed.Add(new Action<AActor>(this.SubReference));
					}
					this.ActorReason.Remove(aactor);
					this.Reason.Remove(num);
					aactor.D_K2_SetActorTransform(transform, false, null, true);
					if (owner != null)
					{
						aactor.SetOwner(owner);
						break;
					}
					break;
				}
			}
		}
		if (aactor != null)
		{
			entry.Touch(null);
			this.Queue.Update(entry);
			this.HitCount = this.HitCount * this.DecayRate + 1f;
			this.MissCount *= this.DecayRate;
			if (Info.Instance.IsBuildDevelopmentOrDebug)
			{
				ActorSystemDebugger.Instance.RecordGetPut(new GetPutRecord
				{
					ClassName = tweakObjectPtr.GetName(),
					GetOrPut = "Get",
					Hit = true,
					TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
					ThisTypeTotal = entry.Values.Count,
					HitRate = this.HitRate,
					CurrentTotal = this.Size,
					PendingKillNum = this.Pending.Count
				});
			}
			return aactor as T;
		}
		double milliseconds2 = KuroTime.GetMilliseconds64();
		T result2 = this.SpawnAsPoolActor<T>(ueClassPtr, tweakObjectPtr, transform, owner);
		entry.Touch(new double?(KuroTime.GetMilliseconds64() - milliseconds2));
		this.Queue.Update(entry);
		this.HitCount *= this.DecayRate;
		this.MissCount = this.MissCount * this.DecayRate + 1f;
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			ActorSystemDebugger.Instance.RecordGetPut(new GetPutRecord
			{
				ClassName = tweakObjectPtr.GetName(),
				GetOrPut = "Get",
				Hit = false,
				TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
				ThisTypeTotal = entry.Values.Count,
				HitRate = this.HitRate,
				CurrentTotal = this.Size,
				PendingKillNum = this.Pending.Count
			});
		}
		return result2;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002B04 File Offset: 0x00000D04
	[NullableContext(2)]
	public unsafe bool Put([Nullable(1)] string reason, AActor actor, TClearFunction clearFunc = null)
	{
		if (actor == null || !actor.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActorSystem;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "对象不存在";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Target", actor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (!this.Enable || this.State != EActorSystemState.Ready)
		{
			UKuroActorManager.DestroyActor(actor);
			return true;
		}
		if (!UKuroActorManager.IsPooledActor(actor))
		{
			UKuroActorManager.DestroyActor(actor);
			return false;
		}
		UClassStackOnlyPtr @class = actor.GetClass();
		TWeakObjectPtr<UClass> tweakObjectPtr = @class.ToWeakClass();
		if (actor.GetWorld() == null || !actor.GetWorld().IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.ActorSystem;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "World无效或者World发生改变";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ueClass", @class.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			UKuroActorManager.DestroyActor(actor);
			return false;
		}
		this.CreateStat(this.PutStatMap, tweakObjectPtr, "ActorSystem.Put.");
		actor.OnDestroyed.Remove(new Action<AActor>(this.SubReference));
		if (!ActorPoolGuard.CleanActorBeforeEnPool(actor, clearFunc))
		{
			UKuroActorManager.DestroyActor(actor);
			return false;
		}
		actor.OnDestroyed.Add(new Action<AActor>(this.SubReference));
		actor.OnEndPlay.Add(new Action<AActor, TEnumAsByte<EEndPlayReason>>(this.OnEndPlay));
		int num;
		if (this.ActorReason.TryGetValue(actor, out num))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.ActorSystem;
			ELogAuthor author3 = ELogAuthor.LW;
			string message3 = "Actor被重复入池！";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("ueClass", @class.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("OldReason", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("Reason", reason);
			instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return false;
		}
		int num2 = this.ReasonId + 1;
		this.ReasonId = num2;
		int num3 = num2;
		this.Reason[num3] = reason;
		this.ActorReason[actor] = num3;
		Entry entry;
		if (this.Cache.TryGetValue(tweakObjectPtr, out entry))
		{
			int key;
			if (entry.Values.TryGetValue(actor, out key))
			{
				string valueOrDefault = this.Reason.GetValueOrDefault(key);
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.ActorSystem;
				ELogAuthor author4 = ELogAuthor.LW;
				string message4 = "Actor被重复入池！";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("ueClass", @class.GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("OldReason", valueOrDefault);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("Reason", reason);
				instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
				return false;
			}
			entry.Values[actor] = num3;
			entry.Touch(null);
			this.Queue.Update(entry);
		}
		else
		{
			entry = new Entry(tweakObjectPtr, this.Budget.GetValueOrDefault(tweakObjectPtr, 0));
			entry.Values[actor] = num3;
			entry.Touch(null);
			this.Queue.Push(entry);
			this.Cache[tweakObjectPtr] = entry;
		}
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			ActorSystemDebugger.Instance.RecordGetPut(new GetPutRecord
			{
				ClassName = tweakObjectPtr.GetName(),
				GetOrPut = "Put",
				Hit = false,
				HitRate = this.HitRate,
				TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
				ThisTypeTotal = ((entry != null) ? entry.Values.Count : 0),
				CurrentTotal = this.Size,
				PendingKillNum = this.Pending.Count
			});
		}
		this.SizeInternal++;
		while (this.SizeInternal > this.CapacityInternal || this.Queue.Size > this.CapacityInternal)
		{
			this.Evict();
		}
		return true;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002F3C File Offset: 0x0000113C
	public void Clear()
	{
		this.SizeInternal = 0;
		this.Queue.Clear();
		this.Cache.Clear();
		this.Budget.Clear();
		this.HitCount = 0f;
		this.MissCount = 0f;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002F7C File Offset: 0x0000117C
	public bool SetBudget(UClassStackOnlyPtr ueClassPtr, int budget)
	{
		if (!this.CheckClass(ueClassPtr))
		{
			return false;
		}
		TWeakObjectPtr<UClass> tweakObjectPtr = ueClassPtr.ToWeakClass();
		this.CreateStat(this.SetBudgetStatMap, tweakObjectPtr, "ActorSystem.SetBudget.");
		if (budget < 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActorSystem;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "预算必须大于等于 0";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ueClass", tweakObjectPtr.GetFName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.Budget[tweakObjectPtr] = budget;
		Entry entry;
		if (this.Cache.TryGetValue(tweakObjectPtr, out entry))
		{
			entry.Budget = budget;
			this.Queue.Update(entry);
		}
		return true;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000301C File Offset: 0x0000121C
	private bool CheckClass(UClassStackOnlyPtr ueClass)
	{
		if (!ueClass.IsValid())
		{
			Log.Instance.Error(ELogModule.ActorSystem, ELogAuthor.LCC, "类无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return true;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00003054 File Offset: 0x00001254
	private bool Evict()
	{
		Entry top = this.Queue.Top;
		if (top == null)
		{
			Log.Instance.Error(ELogModule.ActorSystem, ELogAuthor.LCC, "队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		Dictionary<AActor, int> values = top.Values;
		if (values.Count == 0)
		{
			this.Queue.Pop();
			this.Cache.Remove(top.Class);
			return true;
		}
		AActor aactor = null;
		int num = 0;
		using (Dictionary<AActor, int>.Enumerator enumerator = values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				KeyValuePair<AActor, int> keyValuePair = enumerator.Current;
				aactor = keyValuePair.Key;
				num = keyValuePair.Value;
			}
		}
		values.Remove(aactor);
		this.SizeInternal--;
		top.Touch(null);
		this.Queue.Update(top);
		if (aactor != null && aactor.IsValid())
		{
			aactor.OnEndPlay.Remove(new Action<AActor, TEnumAsByte<EEndPlayReason>>(this.OnEndPlay));
			this.Pending.Add(new PendingActor
			{
				Actor = aactor,
				Klass = aactor.GetClass().GetName(),
				ReasonId = num
			});
		}
		else
		{
			this.Reason.Remove(num);
			if (aactor != null)
			{
				this.ActorReason.Remove(aactor);
			}
		}
		if (!Info.Instance.IsBuildShipping)
		{
			string className = (aactor != null && aactor.IsValid()) ? aactor.GetClass().GetName() : "InvalidClass";
			ActorSystemDebugger.Instance.RecordGetPut(new GetPutRecord
			{
				ClassName = className,
				GetOrPut = "Evict",
				Hit = false,
				TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
				ThisTypeTotal = 0,
				HitRate = this.HitRate,
				CurrentTotal = this.Size,
				PendingKillNum = this.Pending.Count
			});
		}
		return true;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00003258 File Offset: 0x00001458
	private unsafe void Tick(float delta)
	{
		while (this.Pending.Count > 0)
		{
			PendingActor pendingActor = this.Pending[this.Pending.Count - 1];
			this.Pending.RemoveAt(this.Pending.Count - 1);
			AActor actor = pendingActor.Actor;
			string valueOrDefault = this.Reason.GetValueOrDefault(pendingActor.ReasonId);
			this.Reason.Remove(pendingActor.ReasonId);
			if (actor != null)
			{
				this.ActorReason.Remove(actor);
			}
			if (actor == null || !actor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActorSystem;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "Tick删除对象时对象非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("className", pendingActor.Klass);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", valueOrDefault);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				this.CreateStat(this.DestroyStatMap, actor.GetClass().ToWeakClass(), "ActorSystem.Destroy.");
				UKuroActorManager.DestroyActor(actor);
				if (!Info.Instance.IsBuildShipping)
				{
					ActorSystemDebugger.Instance.RecordGetPut(new GetPutRecord
					{
						ClassName = pendingActor.Klass,
						GetOrPut = "Destroy",
						Hit = false,
						TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
						ThisTypeTotal = 0,
						HitRate = this.HitRate,
						CurrentTotal = this.Size,
						PendingKillNum = this.Pending.Count
					});
					return;
				}
				break;
			}
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000033F5 File Offset: 0x000015F5
	[NullableContext(2)]
	public AActor Spawn(UClassStackOnlyPtr ueClassPtr, FTransformDouble transform, AActor owner)
	{
		return this.Spawn<AActor>(ueClassPtr, transform, owner);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00003400 File Offset: 0x00001600
	[NullableContext(2)]
	public T Spawn<[Nullable(0)] T>(UClassStackOnlyPtr ueClassPtr, FTransformDouble transform, AActor owner) where T : AActor
	{
		if (!ueClassPtr.IsValid())
		{
			return default(T);
		}
		this.CreateStat(this.SpawnStatMap, ueClassPtr.ToWeakClass(), "ActorSystem.Spawn.");
		AActor aactor = UKuroActorManager.D_SpawnActor(Info.Instance.World, ueClassPtr, transform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, owner, null, false);
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			ActorSystemDebugger.Instance.RecordGetPut(new GetPutRecord
			{
				ClassName = ueClassPtr.GetName(),
				GetOrPut = "Spawn",
				Hit = false,
				TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
				ThisTypeTotal = 0,
				HitRate = this.HitRate,
				CurrentTotal = this.Size,
				PendingKillNum = this.Pending.Count
			});
		}
		return aactor as T;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000034DC File Offset: 0x000016DC
	private T SpawnAsPoolActor<[Nullable(0)] T>(UClassStackOnlyPtr ueClassPtr, [Nullable(new byte[]
	{
		0,
		1
	})] TWeakObjectPtr<UClass> ueClass, FTransformDouble transform, [Nullable(2)] AActor owner) where T : AActor
	{
		this.CreateStat(this.SpawnStatMap, ueClass, "ActorSystem.SpawnAsPoolActor.");
		AActor aactor = UKuroActorManager.D_SpawnActor(Info.Instance.World, ueClassPtr, transform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, owner, null, true);
		this.AddReference(aactor);
		return aactor as T;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000352C File Offset: 0x0000172C
	[return: Nullable(2)]
	private Stat CreateStat([Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})] Dictionary<TWeakObjectPtr<UClass>, Stat> map, [Nullable(new byte[]
	{
		0,
		1
	})] TWeakObjectPtr<UClass> ueClass, string prefix)
	{
		if (!Stat.Enable)
		{
			return null;
		}
		Stat stat;
		if (!map.TryGetValue(ueClass, out stat))
		{
			stat = Stat.CreateNoFlameGraph(prefix + ueClass.GetName(), "", "");
			map[ueClass] = stat;
		}
		return stat;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00003574 File Offset: 0x00001774
	[NullableContext(2)]
	private void AddReference(AActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			Log.Instance.Error(ELogModule.ActorSystem, ELogAuthor.TL, "增加类型引用计数 时错误, Actor非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		actor.OnDestroyed.Add(new Action<AActor>(this.SubReference));
		TWeakObjectPtr<UClass> key = actor.GetClass().ToWeakClass();
		int num;
		if (this.References.TryGetValue(key, out num))
		{
			num++;
		}
		else
		{
			num = 1;
		}
		this.References[key] = num;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000035F4 File Offset: 0x000017F4
	[NullableContext(0)]
	private unsafe void OnEndPlay([Nullable(2)] AActor actor, TEnumAsByte<EEndPlayReason> inReason)
	{
		EEndPlayReason eendPlayReason = inReason;
		string item = null;
		int key;
		if (actor != null && this.ActorReason.TryGetValue(actor, out key))
		{
			item = this.Reason.GetValueOrDefault(key);
			this.Reason.Remove(key);
			this.ActorReason.Remove(actor);
		}
		if (eendPlayReason - EEndPlayReason.LevelTransition <= 1 || eendPlayReason == EEndPlayReason.Quit)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RenderEffect;
		ELogAuthor author = ELogAuthor.LFJW;
		string message = "ActorSystem的Actor意外删除";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActorName", actor);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EEndPlayReason", eendPlayReason);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", item);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000036C0 File Offset: 0x000018C0
	[NullableContext(2)]
	private void SubReference(AActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			Log.Instance.Error(ELogModule.ActorSystem, ELogAuthor.TL, "减少类型引用计数 时错误, Actor非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		actor.OnDestroyed.Remove(new Action<AActor>(this.SubReference));
		UClassStackOnlyPtr @class = actor.GetClass();
		TWeakObjectPtr<UClass> tweakObjectPtr = @class.ToWeakClass();
		int num;
		if (!this.References.TryGetValue(tweakObjectPtr, out num))
		{
			return;
		}
		int num2 = num - 1;
		if (num2 <= 0)
		{
			this.References.Remove(tweakObjectPtr);
			this.TryReleaseClass(@class, tweakObjectPtr);
			return;
		}
		this.References[tweakObjectPtr] = num2;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x0000375C File Offset: 0x0000195C
	private void TryReleaseClass(UClassStackOnlyPtr ueClassPtr, [Nullable(new byte[]
	{
		0,
		1
	})] TWeakObjectPtr<UClass> ueClass)
	{
		Entry entry;
		if (this.Cache.TryGetValue(ueClass, out entry) && entry != null && entry.Values.Count > 0)
		{
			return;
		}
		int num;
		if (this.References.TryGetValue(ueClass, out num) && num > 0)
		{
			return;
		}
		UKuroActorManager.ResetClassPropertyCache(ueClassPtr);
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000025 RID: 37 RVA: 0x000037A6 File Offset: 0x000019A6
	public static ActorSystem Instance
	{
		get
		{
			if (ActorSystem._instance == null)
			{
				ActorSystem._instance = new ActorSystem();
				ActorSystem._instance.OnInit();
			}
			return ActorSystem._instance;
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000037C9 File Offset: 0x000019C9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000037CB File Offset: 0x000019CB
	public static void ResetStaticDefaultValue()
	{
		ActorSystem instance = ActorSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ActorSystem._instance = null;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000037E4 File Offset: 0x000019E4
	static ActorSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActorSystem.CreateStaticDefaultValue), new Action(ActorSystem.ResetStaticDefaultValue));
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00003804 File Offset: 0x00001A04
	public ActorSystem()
	{
		Comparison<Entry> compare;
		if ((compare = ActorSystem.<>O.<0>__Compare) == null)
		{
			compare = (ActorSystem.<>O.<0>__Compare = new Comparison<Entry>(Entry.Compare));
		}
		this.Queue = new PriorityQueue<Entry>(compare);
		this.Cache = new Dictionary<TWeakObjectPtr<UClass>, Entry>();
		this.References = new Dictionary<TWeakObjectPtr<UClass>, int>();
		this.Budget = new Dictionary<TWeakObjectPtr<UClass>, int>();
		this.Pending = new List<PendingActor>();
		this.Reason = new Dictionary<int, string>();
		this.ActorReason = new Dictionary<AActor, int>();
		this.DecayRate = 0.99666667f;
		this.GetStat = Stat.Create("ActorSystem.Get", "", "");
		this.PutStat = Stat.Create("ActorSystem.Put", "", "");
		this.SpawnStat = Stat.Create("ActorSystem.Spawn", "", "");
		this.DestroyStat = Stat.Create("ActorSystem.Destroy", "", "");
		this.SetBudgetStat = Stat.Create("ActorSystem.SetBudget", "", "");
		this.GetStatMap = new Dictionary<TWeakObjectPtr<UClass>, Stat>();
		this.PutStatMap = new Dictionary<TWeakObjectPtr<UClass>, Stat>();
		this.SpawnStatMap = new Dictionary<TWeakObjectPtr<UClass>, Stat>();
		this.DestroyStatMap = new Dictionary<TWeakObjectPtr<UClass>, Stat>();
		this.SetBudgetStatMap = new Dictionary<TWeakObjectPtr<UClass>, Stat>();
		base..ctor();
	}

	// Token: 0x0400000E RID: 14
	public const int DEFAULT_CAPACITY = 300;

	// Token: 0x0400000F RID: 15
	public const int ACCESS_WEIGHT = 1;

	// Token: 0x04000010 RID: 16
	public const int FRESHNESS_WIGHT = 1;

	// Token: 0x04000011 RID: 17
	public const int COST_WIGHT = 10;

	// Token: 0x04000012 RID: 18
	public const int INDEX_WIGHT = 5;

	// Token: 0x04000013 RID: 19
	public const float COST_DECAY_RATE = 0.5f;

	// Token: 0x04000014 RID: 20
	public bool Enable = true;

	// Token: 0x04000015 RID: 21
	public EActorSystemState State;

	// Token: 0x04000016 RID: 22
	private int CapacityInternal = 300;

	// Token: 0x04000017 RID: 23
	private int SizeInternal;

	// Token: 0x04000018 RID: 24
	private readonly PriorityQueue<Entry> Queue;

	// Token: 0x04000019 RID: 25
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private readonly Dictionary<TWeakObjectPtr<UClass>, Entry> Cache;

	// Token: 0x0400001A RID: 26
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly Dictionary<TWeakObjectPtr<UClass>, int> References;

	// Token: 0x0400001B RID: 27
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly Dictionary<TWeakObjectPtr<UClass>, int> Budget;

	// Token: 0x0400001C RID: 28
	private readonly List<PendingActor> Pending;

	// Token: 0x0400001D RID: 29
	private readonly Dictionary<int, string> Reason;

	// Token: 0x0400001E RID: 30
	private readonly Dictionary<AActor, int> ActorReason;

	// Token: 0x0400001F RID: 31
	private float DecayRate;

	// Token: 0x04000020 RID: 32
	private float HitCount;

	// Token: 0x04000021 RID: 33
	private float MissCount;

	// Token: 0x04000022 RID: 34
	private int ReasonId;

	// Token: 0x04000023 RID: 35
	private readonly Stat GetStat;

	// Token: 0x04000024 RID: 36
	private readonly Stat PutStat;

	// Token: 0x04000025 RID: 37
	private readonly Stat SpawnStat;

	// Token: 0x04000026 RID: 38
	private readonly Stat DestroyStat;

	// Token: 0x04000027 RID: 39
	private readonly Stat SetBudgetStat;

	// Token: 0x04000028 RID: 40
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private readonly Dictionary<TWeakObjectPtr<UClass>, Stat> GetStatMap;

	// Token: 0x04000029 RID: 41
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private readonly Dictionary<TWeakObjectPtr<UClass>, Stat> PutStatMap;

	// Token: 0x0400002A RID: 42
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private readonly Dictionary<TWeakObjectPtr<UClass>, Stat> SpawnStatMap;

	// Token: 0x0400002B RID: 43
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private readonly Dictionary<TWeakObjectPtr<UClass>, Stat> DestroyStatMap;

	// Token: 0x0400002C RID: 44
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private readonly Dictionary<TWeakObjectPtr<UClass>, Stat> SetBudgetStatMap;

	// Token: 0x0400002D RID: 45
	[Nullable(2)]
	private static ActorSystem _instance;

	// Token: 0x02000178 RID: 376
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400074E RID: 1870
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<Entry> <0>__Compare;
	}
}
