using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.ActivityCondition
{
	// Token: 0x02005A7D RID: 23165
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityConditionCenter : Singleton
	{
		// Token: 0x060391AC RID: 233900 RVA: 0x00FFE9D8 File Offset: 0x00FFCBD8
		public ActivityConditionCenter()
		{
			int capacity = 100;
			Func<EActivityConditionType, ActivityConditionBase> creator = new Func<EActivityConditionType, ActivityConditionBase>(this.CreateConditionInstance);
			Action<ActivityConditionBase> clearer;
			if ((clearer = ActivityConditionCenter.<>O.<0>__OnConditionEvicted) == null)
			{
				clearer = (ActivityConditionCenter.<>O.<0>__OnConditionEvicted = new Action<ActivityConditionBase>(ActivityConditionCenter.OnConditionEvicted));
			}
			this.ConditionPool = new Lru<EActivityConditionType, ActivityConditionBase>(capacity, creator, clearer);
			this.ConditionParamsPool = new Pool<ConditionParams>(32, () => new ConditionParams(), delegate(ConditionParams conditionParams)
			{
				conditionParams.Clear();
			});
		}

		// Token: 0x060391AD RID: 233901 RVA: 0x00FFEA8C File Offset: 0x00FFCC8C
		public void RegisterFactory(EActivityConditionType type, Func<ActivityConditionBase> factory)
		{
			if (type == EActivityConditionType.None)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] RegisterFactory 参数非法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.ConditionFactories[type] = factory;
		}

		// Token: 0x060391AE RID: 233902 RVA: 0x00FFEAD6 File Offset: 0x00FFCCD6
		public void ClearIdlePools()
		{
			this.ConditionPool.Clear();
			this.ConditionParamsPool.Clear();
		}

		// Token: 0x060391AF RID: 233903 RVA: 0x00FFEAF0 File Offset: 0x00FFCCF0
		internal void ClearAll()
		{
			if (this.ClearingAll)
			{
				return;
			}
			this.ClearingAll = true;
			try
			{
				foreach (long uniqueId in new List<long>(this.ConditionMap.Keys))
				{
					this.Unregister(uniqueId);
				}
				this.ClearIdlePools();
				this.GmForcedIds.Clear();
				this.ConditionFactories.Clear();
			}
			finally
			{
				this.ClearingAll = false;
			}
		}

		// Token: 0x060391B0 RID: 233904 RVA: 0x00FFEB90 File Offset: 0x00FFCD90
		[NullableContext(2)]
		internal ActivityConditionBase CreateGroup(int groupId)
		{
			ActivityConditionBase result;
			try
			{
				ActivityConditionConfig instance = ActivityConditionConfig.Instance;
				ActivityConditionGroup? activityConditionGroup = (instance != null) ? instance.GetConditionGroupConfig(groupId) : null;
				if (activityConditionGroup == null)
				{
					result = null;
				}
				else
				{
					result = this.CreateGroup(groupId, activityConditionGroup.Value);
				}
			}
			catch (Exception ex)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] 创建条件组异常，已回滚子条件";
				Exception error = ex;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("groupId", groupId);
				instance2.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				result = null;
			}
			return result;
		}

		// Token: 0x060391B1 RID: 233905 RVA: 0x00FFEC1C File Offset: 0x00FFCE1C
		[NullableContext(2)]
		internal void Release(ActivityConditionBase condition)
		{
			if (condition == null)
			{
				return;
			}
			if (condition is ActivityConditionGroup)
			{
				condition.Clear();
				return;
			}
			EActivityConditionState state = condition.State;
			if (!condition.Clear() || state == EActivityConditionState.Faulted)
			{
				if (state != EActivityConditionState.Idle)
				{
					this.ConditionPool.RemoveExternal(condition);
				}
				return;
			}
			this.ReturnToPool(condition);
		}

		// Token: 0x060391B2 RID: 233906 RVA: 0x00FFEC68 File Offset: 0x00FFCE68
		[NullableContext(2)]
		internal unsafe ActivityConditionBase GetOrCreateCondition(int conditionId)
		{
			ActivityConditionBase result;
			try
			{
				ActivityConditionConfig instance = ActivityConditionConfig.Instance;
				ActivityCondition? activityCondition = (instance != null) ? instance.GetConditionConfig(conditionId) : null;
				if (activityCondition == null)
				{
					result = null;
				}
				else
				{
					int type = activityCondition.Value.Type;
					if (type == 0 || !Enum.IsDefined(typeof(EActivityConditionType), type))
					{
						Log instance2 = Log.Instance;
						ELogModule module = ELogModule.ActivityCondition;
						ELogAuthor author = ELogAuthor.BB;
						string message = "[ActivityCondition] 条件类型非法，检查类型表 Id 是否与 EActivityConditionType 对齐";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("conditionId", conditionId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("rawType", type);
						instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						result = null;
					}
					else
					{
						result = this.GetOrCreateCondition(conditionId, (EActivityConditionType)type, activityCondition.Value);
					}
				}
			}
			catch (Exception ex)
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.ActivityCondition;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[ActivityCondition] 创建条件异常";
				Exception error = ex;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("conditionId", conditionId);
				instance3.ErrorWithStack(module2, author2, message2, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				result = null;
			}
			return result;
		}

		// Token: 0x060391B3 RID: 233907 RVA: 0x00FFED8C File Offset: 0x00FFCF8C
		[NullableContext(2)]
		private ActivityConditionBase GetOrCreateCondition(int conditionId, EActivityConditionType type, ActivityCondition config)
		{
			ConditionParams conditionParams = this.ConditionParamsPool.Get() ?? this.ConditionParamsPool.Create();
			if (conditionParams == null)
			{
				return null;
			}
			ActivityConditionBase result;
			try
			{
				conditionParams.Initialize(config);
				ActivityConditionBase activityConditionBase = this.ConditionPool.Get(type) ?? this.ConditionPool.Create(type);
				if (activityConditionBase == null)
				{
					result = null;
				}
				else if (activityConditionBase.Initialize(conditionId, conditionParams))
				{
					result = activityConditionBase;
				}
				else
				{
					this.ReturnToPool(activityConditionBase);
					result = null;
				}
			}
			finally
			{
				conditionParams.Clear();
				this.ConditionParamsPool.Put(conditionParams);
			}
			return result;
		}

		// Token: 0x060391B4 RID: 233908 RVA: 0x00FFEE24 File Offset: 0x00FFD024
		[NullableContext(2)]
		private unsafe ActivityConditionGroup CreateGroup(int groupId, ActivityConditionGroup config)
		{
			IReadOnlyList<int> groupIdArray = config.GetGroupIdArray();
			if (groupIdArray.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] 条件组没有子条件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("groupId", groupId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			EActivityConditionLogic logic = (EActivityConditionLogic)config.Logic;
			if (logic != EActivityConditionLogic.And && logic != EActivityConditionLogic.Or)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.ActivityCondition;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[ActivityCondition] 条件组逻辑类型非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("groupId", groupId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("logic", logic);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			ActivityConditionGroup activityConditionGroup = new ActivityConditionGroup();
			List<ActivityConditionBase> list = new List<ActivityConditionBase>(groupIdArray.Count);
			bool flag = false;
			ActivityConditionGroup result;
			try
			{
				foreach (int conditionId in groupIdArray)
				{
					ActivityConditionBase orCreateCondition = this.GetOrCreateCondition(conditionId);
					if (orCreateCondition == null)
					{
						return null;
					}
					list.Add(orCreateCondition);
				}
				flag = activityConditionGroup.Initialize(groupId, logic, list);
				if (!flag)
				{
					result = null;
				}
				else
				{
					result = activityConditionGroup;
				}
			}
			finally
			{
				if (!flag)
				{
					for (int i = list.Count - 1; i >= 0; i--)
					{
						this.Release(list[i]);
					}
					list.Clear();
				}
			}
			return result;
		}

		// Token: 0x060391B5 RID: 233909 RVA: 0x00FFEFA0 File Offset: 0x00FFD1A0
		public long RegisterCondition(int conditionId, Action callback, [Nullable(new byte[]
		{
			2,
			1
		})] Func<ActivityConditionBase, bool> prepareCondition = null)
		{
			if (this.ClearingAll)
			{
				return 0L;
			}
			ActivityConditionBase orCreateCondition = this.GetOrCreateCondition(conditionId);
			return this.Register(orCreateCondition, callback, prepareCondition);
		}

		// Token: 0x060391B6 RID: 233910 RVA: 0x00FFEFCC File Offset: 0x00FFD1CC
		public long RegisterGroup(int groupId, Action callback)
		{
			if (this.ClearingAll || callback == null)
			{
				return 0L;
			}
			ActivityConditionBase condition = this.CreateGroup(groupId);
			return this.Register(condition, callback, null);
		}

		// Token: 0x060391B7 RID: 233911 RVA: 0x00FFEFF8 File Offset: 0x00FFD1F8
		private unsafe long Register([Nullable(2)] ActivityConditionBase condition, Action callback, [Nullable(new byte[]
		{
			2,
			1
		})] Func<ActivityConditionBase, bool> prepareCondition = null)
		{
			if (condition == null)
			{
				return 0L;
			}
			bool flag = false;
			long result;
			try
			{
				if ((prepareCondition != null && !prepareCondition(condition)) || this.ClearingAll)
				{
					result = 0L;
				}
				else
				{
					bool flag2 = condition.Check();
					if (condition.State == EActivityConditionState.Faulted)
					{
						result = 0L;
					}
					else if (flag2)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.ActivityCondition;
						ELogAuthor author = ELogAuthor.BB;
						string message = "[ActivityCondition] 注册失败：Condition 已达成，业务应先检查条件，仅对未达成条件注册监听";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("conditionId", condition.ConditionId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("conditionType", condition.GetType().Name);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						result = 0L;
					}
					else if (condition.State != EActivityConditionState.Active || !condition.CanListen)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.ActivityCondition;
						ELogAuthor author2 = ELogAuthor.BB;
						string message2 = "[ActivityCondition] 注册失败：Condition 不支持事件监听";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("conditionId", condition.ConditionId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("state", condition.State);
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						result = 0L;
					}
					else if (!condition.SetFinishCallback(callback))
					{
						result = 0L;
					}
					else
					{
						this.ConditionMap.Add(condition.UniqueId, condition);
						flag = true;
						result = condition.UniqueId;
					}
				}
			}
			finally
			{
				if (!flag)
				{
					this.Release(condition);
				}
			}
			return result;
		}

		// Token: 0x060391B8 RID: 233912 RVA: 0x00FFF190 File Offset: 0x00FFD390
		public bool TryGetCondition(long uniqueId, out ActivityConditionBase condition)
		{
			return this.ConditionMap.TryGetValue(uniqueId, out condition);
		}

		// Token: 0x060391B9 RID: 233913 RVA: 0x00FFF1A0 File Offset: 0x00FFD3A0
		public void Unregister(long uniqueId)
		{
			ActivityConditionBase condition;
			if (this.ConditionMap.Remove(uniqueId, out condition))
			{
				this.Release(condition);
			}
		}

		// Token: 0x060391BA RID: 233914 RVA: 0x00FFF1C4 File Offset: 0x00FFD3C4
		public bool CheckCondition(int conditionId, [Nullable(new byte[]
		{
			2,
			1
		})] Func<ActivityConditionBase, bool> prepareCondition = null)
		{
			return this.IsGmForced(conditionId) || this.CheckAndRelease(this.GetOrCreateCondition(conditionId), prepareCondition);
		}

		// Token: 0x060391BB RID: 233915 RVA: 0x00FFF1DF File Offset: 0x00FFD3DF
		public bool CheckGroup(int groupId)
		{
			return this.IsGmForced(groupId) || this.CheckAndRelease(this.CreateGroup(groupId), null);
		}

		// Token: 0x060391BC RID: 233916 RVA: 0x00FFF1FC File Offset: 0x00FFD3FC
		public unsafe bool TryGetConditionTarget(int conditionId, out int target)
		{
			target = 1;
			if (conditionId == 0)
			{
				return true;
			}
			ActivityConditionBase orCreateCondition = this.GetOrCreateCondition(conditionId);
			if (orCreateCondition == null)
			{
				return false;
			}
			bool result;
			try
			{
				target = this.GetConditionTarget(orCreateCondition);
				result = true;
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] 读取条件目标进度异常";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("conditionId", conditionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("conditionType", orCreateCondition.GetType().Name);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				result = false;
			}
			finally
			{
				this.Release(orCreateCondition);
			}
			return result;
		}

		// Token: 0x060391BD RID: 233917 RVA: 0x00FFF2BC File Offset: 0x00FFD4BC
		public int GetConditionTarget(ActivityConditionBase condition)
		{
			ActivityConditionProgressBase activityConditionProgressBase = condition as ActivityConditionProgressBase;
			if (activityConditionProgressBase == null)
			{
				return 1;
			}
			return activityConditionProgressBase.GetTarget();
		}

		// Token: 0x060391BE RID: 233918 RVA: 0x00FFF2DC File Offset: 0x00FFD4DC
		public int GetConditionCurrent(ActivityConditionBase condition)
		{
			ActivityConditionProgressBase activityConditionProgressBase = condition as ActivityConditionProgressBase;
			if (activityConditionProgressBase == null)
			{
				return (this.Check(condition) > false) ? 1 : 0;
			}
			return activityConditionProgressBase.GetCurrent();
		}

		// Token: 0x060391BF RID: 233919 RVA: 0x00FFF304 File Offset: 0x00FFD504
		public bool Check(ActivityConditionBase condition)
		{
			bool result = condition.Check();
			if (condition.State == EActivityConditionState.Faulted)
			{
				this.Unregister(condition.UniqueId);
			}
			return result;
		}

		// Token: 0x060391C0 RID: 233920 RVA: 0x00FFF324 File Offset: 0x00FFD524
		public bool TryGetGroupConditionIds(int groupId, out IReadOnlyList<int> conditionIds)
		{
			ActivityConditionConfig instance = ActivityConditionConfig.Instance;
			ActivityConditionGroup? activityConditionGroup = (instance != null) ? instance.GetConditionGroupConfig(groupId) : null;
			if (activityConditionGroup == null)
			{
				conditionIds = Array.Empty<int>();
				return false;
			}
			conditionIds = activityConditionGroup.Value.GetGroupIdArray();
			return true;
		}

		// Token: 0x060391C1 RID: 233921 RVA: 0x00FFF370 File Offset: 0x00FFD570
		[NullableContext(2)]
		private bool CheckAndRelease(ActivityConditionBase condition, [Nullable(new byte[]
		{
			2,
			1
		})] Func<ActivityConditionBase, bool> prepareCondition = null)
		{
			if (condition == null)
			{
				return false;
			}
			bool result;
			try
			{
				if (prepareCondition != null && !prepareCondition(condition))
				{
					result = false;
				}
				else
				{
					result = this.Check(condition);
				}
			}
			finally
			{
				this.Release(condition);
			}
			return result;
		}

		// Token: 0x060391C2 RID: 233922 RVA: 0x00FFF3BC File Offset: 0x00FFD5BC
		private ActivityConditionBase CreateConditionInstance(EActivityConditionType type)
		{
			Func<ActivityConditionBase> func;
			if (!this.ConditionFactories.TryGetValue(type, out func))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] 条件类型未注册工厂";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			ActivityConditionBase activityConditionBase = func();
			if (activityConditionBase is ActivityConditionGroup)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.ActivityCondition;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[ActivityCondition] 工厂创建的 Condition 类型非法";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("conditionType", type);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			return activityConditionBase;
		}

		// Token: 0x060391C3 RID: 233923 RVA: 0x00FFF448 File Offset: 0x00FFD648
		private unsafe void ReturnToPool(ActivityConditionBase condition)
		{
			if (condition.State != EActivityConditionState.Idle)
			{
				this.ConditionPool.RemoveExternal(condition);
				return;
			}
			bool flag = this.ConditionPool.Size >= this.ConditionPool.Capacity;
			if (!this.ConditionPool.Put(condition))
			{
				this.ConditionPool.RemoveExternal(condition);
				return;
			}
			if (flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] Condition 空闲池达到容量上限，淘汰最久未使用实例";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("capacity", this.ConditionPool.Capacity);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("conditionType", condition.GetType().Name);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x060391C4 RID: 233924 RVA: 0x00FFF514 File Offset: 0x00FFD714
		private unsafe static void OnConditionEvicted(ActivityConditionBase condition)
		{
			if (condition.State != EActivityConditionState.Idle)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[ActivityCondition] 淘汰了非 Idle Condition";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("conditionType", condition.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", condition.State);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x060391C5 RID: 233925 RVA: 0x00FFF590 File Offset: 0x00FFD790
		public void GmRecheckAll()
		{
			foreach (long key in new List<long>(this.ConditionMap.Keys))
			{
				ActivityConditionBase activityConditionBase;
				if (this.ConditionMap.TryGetValue(key, out activityConditionBase))
				{
					activityConditionBase.Recheck();
				}
			}
		}

		// Token: 0x060391C6 RID: 233926 RVA: 0x00FFF5FC File Offset: 0x00FFD7FC
		public void GmForceSatisfy(int id)
		{
			this.GmForcedIds.Add(id);
			this.GmRecheckAll();
		}

		// Token: 0x060391C7 RID: 233927 RVA: 0x00FFF611 File Offset: 0x00FFD811
		public void GmClearForced()
		{
			this.GmForcedIds.Clear();
			this.GmRecheckAll();
		}

		// Token: 0x060391C8 RID: 233928 RVA: 0x00FFF624 File Offset: 0x00FFD824
		public IReadOnlyCollection<int> GetGmForcedIds()
		{
			return this.GmForcedIds;
		}

		// Token: 0x060391C9 RID: 233929 RVA: 0x00FFF62C File Offset: 0x00FFD82C
		internal bool IsGmForced(int id)
		{
			return this.GmForcedIds.Contains(id);
		}

		// Token: 0x17006CC7 RID: 27847
		// (get) Token: 0x060391CA RID: 233930 RVA: 0x00FFF63A File Offset: 0x00FFD83A
		public static ActivityConditionCenter Instance
		{
			get
			{
				if (ActivityConditionCenter._instance == null)
				{
					ActivityConditionCenter._instance = new ActivityConditionCenter();
					ActivityConditionCenter._instance.OnInit();
				}
				return ActivityConditionCenter._instance;
			}
		}

		// Token: 0x060391CB RID: 233931 RVA: 0x00FFF65D File Offset: 0x00FFD85D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060391CC RID: 233932 RVA: 0x00FFF65F File Offset: 0x00FFD85F
		public static void ResetStaticDefaultValue()
		{
			ActivityConditionCenter instance = ActivityConditionCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			ActivityConditionCenter._instance = null;
		}

		// Token: 0x060391CD RID: 233933 RVA: 0x00FFF678 File Offset: 0x00FFD878
		static ActivityConditionCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityConditionCenter.CreateStaticDefaultValue), new Action(ActivityConditionCenter.ResetStaticDefaultValue));
		}

		// Token: 0x0401E0B5 RID: 123061
		private readonly Dictionary<EActivityConditionType, Func<ActivityConditionBase>> ConditionFactories = new Dictionary<EActivityConditionType, Func<ActivityConditionBase>>();

		// Token: 0x0401E0B6 RID: 123062
		private readonly Lru<EActivityConditionType, ActivityConditionBase> ConditionPool;

		// Token: 0x0401E0B7 RID: 123063
		private readonly Pool<ConditionParams> ConditionParamsPool;

		// Token: 0x0401E0B8 RID: 123064
		private readonly HashSet<int> GmForcedIds = new HashSet<int>();

		// Token: 0x0401E0B9 RID: 123065
		private readonly Dictionary<long, ActivityConditionBase> ConditionMap = new Dictionary<long, ActivityConditionBase>();

		// Token: 0x0401E0BA RID: 123066
		private bool ClearingAll;

		// Token: 0x0401E0BB RID: 123067
		[Nullable(2)]
		private static ActivityConditionCenter _instance;

		// Token: 0x0200B69B RID: 46747
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040387F2 RID: 231410
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<ActivityConditionBase> <0>__OnConditionEvicted;
		}
	}
}
