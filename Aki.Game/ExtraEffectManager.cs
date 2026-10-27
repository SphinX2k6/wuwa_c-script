using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002F3F RID: 12095
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectManager
{
	// Token: 0x06019BFB RID: 105467 RVA: 0x006B5919 File Offset: 0x006B3B19
	public ExtraEffectManager(BaseBuffComponent buffComponent)
	{
		this.BuffComponent = buffComponent;
	}

	// Token: 0x06019BFC RID: 105468 RVA: 0x006B594C File Offset: 0x006B3B4C
	public unsafe void OnBuffAdded(ActiveBuffInternal buff)
	{
		if (!this.CheckBuffEffectExistence(buff))
		{
			return;
		}
		if (((buff != null) ? buff.Config : null) == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			BaseBuffComponent buffComponent = this.BuffComponent;
			Entity entity = (buffComponent != null) ? buffComponent.Entity : null;
			string message = "正在添加的buff额外效果未加载对应的buffRef";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", (buff != null) ? new long?(buff.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", (buff != null) ? new int?(buff.Handle) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("持有者", (buff != null) ? buff.GetOwnerDebugName() : null);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		if (buff.IsActive())
		{
			this.CreateBuffEffects(buff);
		}
	}

	// Token: 0x06019BFD RID: 105469 RVA: 0x006B5A44 File Offset: 0x006B3C44
	public void OnBuffRemoved(ActiveBuffInternal buff, bool isPrematureRemoval)
	{
		int handle = buff.Handle;
		if (!this.CheckBuffEffectExistence(buff))
		{
			return;
		}
		if (buff.IsActive())
		{
			this.RemoveBuffEffects(handle, isPrematureRemoval);
		}
	}

	// Token: 0x06019BFE RID: 105470 RVA: 0x006B5A74 File Offset: 0x006B3C74
	public void OnStackIncreased(ActiveBuffInternal buff, int newCount, int oldCount, long? instigatorId)
	{
		if (!this.CheckBuffEffectExistence(buff))
		{
			return;
		}
		foreach (BuffEffect buffEffect in this.GetEffectsByHandle(buff.Handle))
		{
			buffEffect.OnStackIncreased(newCount, oldCount, instigatorId);
		}
	}

	// Token: 0x06019BFF RID: 105471 RVA: 0x006B5AD4 File Offset: 0x006B3CD4
	public void OnStackDecreased(ActiveBuffInternal buff, int newCount, int oldCount, bool bPremature)
	{
		if (!this.CheckBuffEffectExistence(buff))
		{
			return;
		}
		foreach (BuffEffect buffEffect in this.GetEffectsByHandle(buff.Handle))
		{
			buffEffect.OnStackDecreased(newCount, oldCount, bPremature);
		}
	}

	// Token: 0x06019C00 RID: 105472 RVA: 0x006B5B34 File Offset: 0x006B3D34
	public void OnBuffStackOverflow(ActiveBuffInternal buff, int oldStack, int newStack, int stackLimitMax)
	{
		ExtraEffectParameters[] effectInfos = buff.Config.EffectInfos;
		for (int i = 0; i < effectInfos.Length; i++)
		{
			BuffExecution executionEffect = effectInfos[i].ExecutionEffect;
			if (executionEffect != null)
			{
				executionEffect.OnBuffStackOverflow(buff, oldStack, newStack, stackLimitMax);
			}
		}
		if (!this.CheckBuffEffectExistence(buff))
		{
			return;
		}
		foreach (BuffEffect buffEffect in this.GetEffectsByHandle(buff.Handle))
		{
			buffEffect.OnBuffStackOverflow(buff, oldStack, newStack, stackLimitMax);
		}
	}

	// Token: 0x06019C01 RID: 105473 RVA: 0x006B5BC8 File Offset: 0x006B3DC8
	public void OnBuffInhibitedChanged(ActiveBuffInternal buff, bool isInhibited)
	{
		int handle = buff.Handle;
		if (!this.CheckBuffEffectExistence(buff))
		{
			return;
		}
		if (!isInhibited)
		{
			this.CreateBuffEffects(buff);
			return;
		}
		this.RemoveBuffEffects(handle, true);
	}

	// Token: 0x06019C02 RID: 105474 RVA: 0x006B5BFC File Offset: 0x006B3DFC
	private unsafe bool CheckBuffEffectExistence(ActiveBuffInternal buff)
	{
		BuffDefinition buffDefinition = (buff != null) ? buff.Config : null;
		if (buffDefinition == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			BaseBuffComponent buffComponent = this.BuffComponent;
			Entity entity = (buffComponent != null) ? buffComponent.Entity : null;
			string message = "处理buff额外效果逻辑时找不到对应的buffRef";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", (buff != null) ? new long?(buff.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handleId", (buff != null) ? new int?(buff.Handle) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("持有者", (buff != null) ? buff.GetOwnerDebugName() : null);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		return buffDefinition.HasBuffEffect;
	}

	// Token: 0x06019C03 RID: 105475 RVA: 0x006B5CE8 File Offset: 0x006B3EE8
	private unsafe void CreateBuffEffects(ActiveBuffInternal buff)
	{
		int handle = buff.Handle;
		long id = buff.Id;
		if (this.ActivatedHandles.Contains(handle))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			BaseBuffComponent buffComponent = this.BuffComponent;
			Entity entity = (buffComponent != null) ? buffComponent.Entity : null;
			string message = "重复创建Buff额外效果";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", handle);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		CharacterBuffComponent instigatorBuffComponent = buff.GetInstigatorBuffComponent();
		this.ActivatedHandles.Add(handle);
		List<ValueTuple<ExtraEffectParameters, RequireAndLimits>> list = new List<ValueTuple<ExtraEffectParameters, RequireAndLimits>>();
		if (buff.Config.EffectInfos != null)
		{
			foreach (ExtraEffectParameters extraEffectParameters in buff.Config.EffectInfos)
			{
				list.Add(new ValueTuple<ExtraEffectParameters, RequireAndLimits>(extraEffectParameters, ExtraEffectLibrary.BuffExtraEffectLibrary.ResolveRequireAndLimits(id, extraEffectParameters, buff.Level)));
			}
		}
		BaseBuffComponent buffComponent2 = this.BuffComponent;
		if (list == null || (buffComponent2 == null || !buffComponent2.Valid))
		{
			return;
		}
		for (int j = 0; j < list.Count; j++)
		{
			ExtraEffectParameters item = list[j].Item1;
			RequireAndLimits item2 = list[j].Item2;
			EExtraEffectId extraEffectId = item.ExtraEffectId;
			Type buffEffectClass = ExtraEffectDefine.GetBuffEffectClass(extraEffectId);
			if (buffEffectClass != null)
			{
				BuffEffect buffEffect = BuffEffect.Create(buffEffectClass, handle, j, item2, this.BuffComponent, instigatorBuffComponent, item);
				this.Add(buffEffect);
				try
				{
					buffEffect.OnCreated();
				}
				catch (Exception ex)
				{
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
					BaseBuffComponent buffComponent3 = this.BuffComponent;
					Entity entity2 = (buffComponent3 != null) ? buffComponent3.Entity : null;
					string message2 = "Buff额外效果 OnCreated 异常，已隔离该效果";
					Exception e = ex;
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("buffId", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("handle", handle);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("effectId", extraEffectId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("effectClass", buffEffectClass.Name);
					instance2.ErrorWithStack(flag2, entity2, message2, e, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				}
			}
		}
	}

	// Token: 0x06019C04 RID: 105476 RVA: 0x006B5F48 File Offset: 0x006B4148
	private unsafe void RemoveBuffEffects(int handleId, bool isPrematureRemoval)
	{
		if (!this.ActivatedHandles.Contains(handleId))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			BaseBuffComponent buffComponent = this.BuffComponent;
			Entity entity = (buffComponent != null) ? buffComponent.Entity : null;
			string message = "尝试移除不存在的buff额外效果实例";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handleId", handleId);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "entity";
			BaseBuffComponent buffComponent2 = this.BuffComponent;
			int? num;
			if (buffComponent2 == null)
			{
				num = null;
			}
			else
			{
				Entity entity2 = buffComponent2.Entity;
				num = ((entity2 != null) ? new int?(entity2.Id) : null);
			}
			ptr = new ValueTuple<string, object>(item, num);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.ActivatedHandles.Remove(handleId);
		IEnumerable<BuffEffect> effectsByHandle = this.GetEffectsByHandle(handleId);
		foreach (BuffEffect buffEffect in effectsByHandle)
		{
			buffEffect.OnRemoved(isPrematureRemoval);
		}
		foreach (BuffEffect effect in effectsByHandle)
		{
			this.RemoveFromTypeIndex(effect);
		}
		this.EffectHolder.Remove(handleId);
	}

	// Token: 0x06019C05 RID: 105477 RVA: 0x006B6098 File Offset: 0x006B4298
	private void Add(BuffEffect effect)
	{
		int activeHandleId = effect.ActiveHandleId;
		if (activeHandleId < 0)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			BaseBuffComponent buffComponent = this.BuffComponent;
			Entity entity = (buffComponent != null) ? buffComponent.Entity : null;
			string message = "invalid handleId when trying to add effect in holder.";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", activeHandleId);
			instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (!this.EffectHolder.ContainsKey(activeHandleId))
		{
			this.EffectHolder[activeHandleId] = new List<BuffEffect>();
		}
		List<BuffEffect> list = this.EffectHolder[activeHandleId];
		using (List<BuffEffect>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == effect)
				{
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
					BaseBuffComponent buffComponent2 = this.BuffComponent;
					Entity entity2 = (buffComponent2 != null) ? buffComponent2.Entity : null;
					string message2 = "duplicated handle when trying to add ExtraEffect.";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("handle", activeHandleId);
					instance2.Warn(flag2, entity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
			}
		}
		list.Add(effect);
		this.AddToTypeIndex(effect);
	}

	// Token: 0x06019C06 RID: 105478 RVA: 0x006B61A0 File Offset: 0x006B43A0
	private void AddToTypeIndex(BuffEffect effect)
	{
		Type type = effect.GetType();
		List<BuffEffect> list;
		if (!this.EffectsByType.TryGetValue(type, out list))
		{
			list = new List<BuffEffect>();
			this.EffectsByType[type] = list;
		}
		list.Add(effect);
	}

	// Token: 0x06019C07 RID: 105479 RVA: 0x006B61E0 File Offset: 0x006B43E0
	private void RemoveFromTypeIndex(BuffEffect effect)
	{
		List<BuffEffect> list;
		if (this.EffectsByType.TryGetValue(effect.GetType(), out list))
		{
			list.Remove(effect);
		}
	}

	// Token: 0x06019C08 RID: 105480 RVA: 0x006B620A File Offset: 0x006B440A
	public void Clear()
	{
		this.EffectHolder.Clear();
		this.EffectsByType.Clear();
		this.ActivatedHandles.Clear();
	}

	// Token: 0x06019C09 RID: 105481 RVA: 0x006B622D File Offset: 0x006B442D
	public IEnumerable<T> FilterById<[Nullable(0)] T>(EExtraEffectId effectId, [Nullable(new byte[]
	{
		2,
		1
	})] Func<T, bool> filterFunction = null) where T : BuffEffect
	{
		ExtraEffectManager.<FilterById>d__18<T> <FilterById>d__ = new ExtraEffectManager.<FilterById>d__18<T>(-2);
		<FilterById>d__.<>4__this = this;
		<FilterById>d__.<>3__effectId = effectId;
		<FilterById>d__.<>3__filterFunction = filterFunction;
		return <FilterById>d__;
	}

	// Token: 0x06019C0A RID: 105482 RVA: 0x006B624B File Offset: 0x006B444B
	public IEnumerable<T> FilterById<[Nullable(0)] T>(EExtraEffectId[] effectIds, [Nullable(new byte[]
	{
		2,
		1
	})] Func<T, bool> filterFunction = null) where T : BuffEffect
	{
		ExtraEffectManager.<FilterById>d__19<T> <FilterById>d__ = new ExtraEffectManager.<FilterById>d__19<T>(-2);
		<FilterById>d__.<>4__this = this;
		<FilterById>d__.<>3__effectIds = effectIds;
		<FilterById>d__.<>3__filterFunction = filterFunction;
		return <FilterById>d__;
	}

	// Token: 0x06019C0B RID: 105483 RVA: 0x006B626C File Offset: 0x006B446C
	public bool HasAnyById(EExtraEffectId[] effectIds)
	{
		if (this.EffectsByType.Count == 0)
		{
			return false;
		}
		foreach (KeyValuePair<Type, List<BuffEffect>> keyValuePair in this.EffectsByType)
		{
			if (keyValuePair.Value.Count > 0 && ExtraEffectManager.MatchAnyId(keyValuePair.Key, effectIds))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06019C0C RID: 105484 RVA: 0x006B62EC File Offset: 0x006B44EC
	public void CollectById<[Nullable(0)] T>(EExtraEffectId[] effectIds, List<T> results) where T : BuffEffect
	{
		foreach (KeyValuePair<Type, List<BuffEffect>> keyValuePair in this.EffectsByType)
		{
			if (keyValuePair.Value.Count != 0 && ExtraEffectManager.MatchAnyId(keyValuePair.Key, effectIds))
			{
				foreach (BuffEffect buffEffect in keyValuePair.Value)
				{
					results.Add((T)((object)buffEffect));
				}
			}
		}
	}

	// Token: 0x06019C0D RID: 105485 RVA: 0x006B63A0 File Offset: 0x006B45A0
	private static bool MatchAnyId(Type effectType, EExtraEffectId[] effectIds)
	{
		for (int i = 0; i < effectIds.Length; i++)
		{
			Type buffEffectClass = ExtraEffectDefine.GetBuffEffectClass(effectIds[i]);
			if (buffEffectClass != null && buffEffectClass.IsAssignableFrom(effectType))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06019C0E RID: 105486 RVA: 0x006B63DC File Offset: 0x006B45DC
	[NullableContext(0)]
	[return: Nullable(2)]
	public T FilterFirstById<T>(EExtraEffectId effectId, [Nullable(new byte[]
	{
		2,
		1
	})] Func<T, bool> filterFunction = null) where T : BuffEffect
	{
		Type buffEffectClass = ExtraEffectDefine.GetBuffEffectClass(effectId);
		if (buffEffectClass == null)
		{
			return default(T);
		}
		foreach (KeyValuePair<Type, List<BuffEffect>> keyValuePair in this.EffectsByType)
		{
			if (keyValuePair.Value.Count != 0 && buffEffectClass.IsAssignableFrom(keyValuePair.Key))
			{
				foreach (BuffEffect buffEffect in keyValuePair.Value)
				{
					T t = (T)((object)buffEffect);
					if (filterFunction == null || filterFunction(t))
					{
						return t;
					}
				}
			}
		}
		return default(T);
	}

	// Token: 0x06019C0F RID: 105487 RVA: 0x006B64C0 File Offset: 0x006B46C0
	[return: Nullable(2)]
	public T FilterFirstById<[Nullable(0)] T>(EExtraEffectId[] effectIds, [Nullable(new byte[]
	{
		2,
		1
	})] Func<T, bool> filterFunction = null) where T : BuffEffect
	{
		foreach (KeyValuePair<Type, List<BuffEffect>> keyValuePair in this.EffectsByType)
		{
			if (keyValuePair.Value.Count != 0 && ExtraEffectManager.MatchAnyId(keyValuePair.Key, effectIds))
			{
				foreach (BuffEffect buffEffect in keyValuePair.Value)
				{
					T t = (T)((object)buffEffect);
					if (filterFunction == null || filterFunction(t))
					{
						return t;
					}
				}
			}
		}
		return default(T);
	}

	// Token: 0x06019C10 RID: 105488 RVA: 0x006B6588 File Offset: 0x006B4788
	public IEnumerable<BuffEffect> GetAllEffects()
	{
		ExtraEffectManager.<GetAllEffects>d__25 <GetAllEffects>d__ = new ExtraEffectManager.<GetAllEffects>d__25(-2);
		<GetAllEffects>d__.<>4__this = this;
		return <GetAllEffects>d__;
	}

	// Token: 0x06019C11 RID: 105489 RVA: 0x006B6598 File Offset: 0x006B4798
	public IEnumerable<BuffEffect> GetEffectsByHandle(int handleId)
	{
		List<BuffEffect> result;
		if (this.EffectHolder.TryGetValue(handleId, out result))
		{
			return result;
		}
		return Array.Empty<BuffEffect>();
	}

	// Token: 0x0400C222 RID: 49698
	public Dictionary<int, List<BuffEffect>> EffectHolder = new Dictionary<int, List<BuffEffect>>();

	// Token: 0x0400C223 RID: 49699
	private readonly Dictionary<Type, List<BuffEffect>> EffectsByType = new Dictionary<Type, List<BuffEffect>>();

	// Token: 0x0400C224 RID: 49700
	protected readonly BaseBuffComponent BuffComponent;

	// Token: 0x0400C225 RID: 49701
	public HashSet<int> ActivatedHandles = new HashSet<int>();
}
