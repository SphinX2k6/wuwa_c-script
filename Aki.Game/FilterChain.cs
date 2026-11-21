using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002A2E RID: 10798
[NullableContext(1)]
[Nullable(0)]
public class FilterChain<[Nullable(2)] T>
{
	// Token: 0x0601B353 RID: 111443 RVA: 0x0085A830 File Offset: 0x00858A30
	protected FilterChain()
	{
	}

	// Token: 0x0601B354 RID: 111444 RVA: 0x0085A8A4 File Offset: 0x00858AA4
	protected void Init()
	{
		foreach (EFilterType key in FilterTypeHelper.FilterTypePriority)
		{
			this.AllTypeFilters[key] = new HashSet<Filter<T>>();
		}
		EventSystem.Instance.Add<object>(EEventName.FilterCriteriaChanged, new Action<object>(this.OnFilterCriteriaChanged));
		FilterTypeHelper.TryCatchWrapper<bool>(new Func<bool>(this.OnInit), "[FilterChain] OnInit执行出错", base.GetType().Name);
	}

	// Token: 0x0601B355 RID: 111445 RVA: 0x0085A919 File Offset: 0x00858B19
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x0601B356 RID: 111446 RVA: 0x0085A91C File Offset: 0x00858B1C
	public void Cleanup()
	{
		foreach (HashSet<Filter<T>> hashSet in this.AllTypeFilters.Values)
		{
			foreach (Filter<T> filter in hashSet)
			{
				filter.Cleanup();
			}
			hashSet.Clear();
		}
		this.AllTypeFilters.Clear();
		this.TargetsWithFilter.Clear();
		this.FilterHoldTargets.Clear();
		this.TargetsPassed.Clear();
		EventSystem.Instance.Remove<object>(EEventName.FilterCriteriaChanged, new Action<object>(this.OnFilterCriteriaChanged));
		FilterTypeHelper.TryCatchWrapper<bool>(new Func<bool>(this.OnCleanup), "[FilterChain] OnCleanup执行出错", base.GetType().Name);
	}

	// Token: 0x0601B357 RID: 111447 RVA: 0x0085AA18 File Offset: 0x00858C18
	protected virtual bool OnCleanup()
	{
		return true;
	}

	// Token: 0x0601B358 RID: 111448 RVA: 0x0085AA1C File Offset: 0x00858C1C
	public virtual void AddFilter(Filter<T> filter)
	{
		if (this.FilterHoldTargets.ContainsKey(filter))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FilterWithState;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "FilterChain中已经有了这个Filter，不需要重复添加";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Filter", filter);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AllTypeFilters[filter.FilterType].Add(filter);
		this.FilterHoldTargets[filter] = new HashSet<T>();
		for (int i = (int)(filter.FilterType + 1); i < FilterTypeHelper.FilterTypePriority.Length; i++)
		{
			foreach (Filter<T> key in this.AllTypeFilters[FilterTypeHelper.FilterTypePriority[i]])
			{
				HashSet<T> hashSet = this.FilterHoldTargets[key];
				foreach (T t in new List<T>(hashSet))
				{
					bool flag = filter.ExecuteCriteria(t);
					if (flag == FilterTypeHelper.FilterResult[filter.FilterType])
					{
						hashSet.Remove(t);
						this.TargetsWithFilter[t] = filter;
						this.FilterHoldTargets[filter].Add(t);
						this.TryModifyPassedTarget(t, flag);
					}
				}
			}
		}
	}

	// Token: 0x0601B359 RID: 111449 RVA: 0x0085AB9C File Offset: 0x00858D9C
	public unsafe virtual bool RemoveFilter(Filter<T> filter)
	{
		if (!this.AllTypeFilters[filter.FilterType].Remove(filter))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FilterWithState;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "RemoveFilter失败";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Filter", filter);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FilterType", filter.FilterType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("AllTypeFilters", this.AllTypeFilters);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("FilterChain", this);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return false;
		}
		HashSet<T> hashSet = this.FilterHoldTargets[filter];
		this.FilterHoldTargets.Remove(filter);
		foreach (T t in hashSet)
		{
			if (FilterTypeHelper.FilterResult[filter.FilterType])
			{
				this.TryModifyPassedTarget(t, false);
			}
			this.TargetsWithFilter.Remove(t);
			this.AddTarget(t, filter.FilterType);
		}
		return true;
	}

	// Token: 0x0601B35A RID: 111450 RVA: 0x0085ACE8 File Offset: 0x00858EE8
	public unsafe bool AddTarget(T target, EFilterType priority = EFilterType.Top)
	{
		bool flag = true;
		for (int i = (int)priority; i < FilterTypeHelper.FilterTypePriority.Length; i++)
		{
			foreach (Filter<T> filter in this.AllTypeFilters[FilterTypeHelper.FilterTypePriority[i]])
			{
				flag = filter.ExecuteCriteria(target);
				if (flag == FilterTypeHelper.FilterResult[filter.FilterType])
				{
					this.TargetsWithFilter[target] = filter;
					this.FilterHoldTargets[filter].Add(target);
				}
			}
			if (this.TargetsWithFilter.ContainsKey(target))
			{
				break;
			}
		}
		if (!flag)
		{
			if (CreatureModel.Instance.EnableEntityLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FilterWithState;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "FilterChain中的某个Normal Filter没有通过target筛选";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Filter", this.TargetsWithFilter.GetValueOrDefault(target));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Target", target);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return false;
		}
		this.TryModifyPassedTarget(target, true);
		return true;
	}

	// Token: 0x0601B35B RID: 111451 RVA: 0x0085AE2C File Offset: 0x0085902C
	public Filter<T>[] GetAllFilters()
	{
		int num = 0;
		Filter<T>[] array;
		int num2;
		checked
		{
			foreach (HashSet<Filter<T>> hashSet in this.AllTypeFilters.Values)
			{
				num += hashSet.Count;
			}
			if (num == 0)
			{
				return Array.Empty<Filter<T>>();
			}
			array = new Filter<T>[num];
			num2 = 0;
		}
		foreach (HashSet<Filter<T>> hashSet2 in this.AllTypeFilters.Values)
		{
			hashSet2.CopyTo(array, num2);
			num2 += hashSet2.Count;
		}
		return array;
	}

	// Token: 0x0601B35C RID: 111452 RVA: 0x0085AEF4 File Offset: 0x008590F4
	public unsafe bool RemoveTarget(T target)
	{
		bool flag = false;
		Filter<T> filter;
		if (this.TargetsWithFilter.TryGetValue(target, out filter))
		{
			if (!this.FilterHoldTargets[filter].Remove(target))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FilterWithState;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[FilterChain] RemoveTarget，FilterHoldTargets和TargetsWithFilter不匹配";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Filter", filter);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Target", target);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetsPassed", this.TargetsPassed);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TargetsWithFilter", this.TargetsWithFilter);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			flag = (flag || this.TargetsWithFilter.Remove(target));
		}
		flag = (flag || this.TryModifyPassedTarget(target, false));
		if (flag)
		{
			return true;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.FilterWithState;
		ELogAuthor author2 = ELogAuthor.XDW;
		string message2 = "[FilterChain] RemoveTarget失败，没有这个Target";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Target", target);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TargetsPassed", this.TargetsPassed);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TargetsWithFilter", this.TargetsWithFilter);
		instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		return false;
	}

	// Token: 0x0601B35D RID: 111453 RVA: 0x0085B067 File Offset: 0x00859267
	protected virtual void OnPassedTargetModified(T target, bool isAdd)
	{
	}

	// Token: 0x0601B35E RID: 111454 RVA: 0x0085B06C File Offset: 0x0085926C
	private void OnFilterCriteriaChanged(object filterUnknown)
	{
		Filter<T> filter = filterUnknown as Filter<T>;
		if (filter == null)
		{
			return;
		}
		HashSet<T> hashSet = this.FilterHoldTargets[filter];
		this.FilterHoldTargets[filter] = new HashSet<T>();
		foreach (T t in hashSet)
		{
			this.TargetsWithFilter.Remove(t);
			this.AddTarget(t, filter.FilterType);
		}
	}

	// Token: 0x0601B35F RID: 111455 RVA: 0x0085B0F8 File Offset: 0x008592F8
	private bool TryModifyPassedTarget(T target, bool isAdd)
	{
		if (isAdd)
		{
			if (!this.TargetsPassed.Contains(target))
			{
				this.TargetsPassed.Add(target);
				this.OnPassedTargetModified(target, true);
				return true;
			}
		}
		else if (this.TargetsPassed.Remove(target))
		{
			this.OnPassedTargetModified(target, false);
			return true;
		}
		return false;
	}

	// Token: 0x0400EC58 RID: 60504
	protected readonly Dictionary<EFilterType, HashSet<Filter<T>>> AllTypeFilters = new Dictionary<EFilterType, HashSet<Filter<T>>>();

	// Token: 0x0400EC59 RID: 60505
	private readonly Dictionary<T, Filter<T>> TargetsWithFilter = new Dictionary<T, Filter<T>>();

	// Token: 0x0400EC5A RID: 60506
	private readonly Dictionary<Filter<T>, HashSet<T>> FilterHoldTargets = new Dictionary<Filter<T>, HashSet<T>>();

	// Token: 0x0400EC5B RID: 60507
	private readonly HashSet<T> TargetsPassed = new HashSet<T>();

	// Token: 0x0400EC5C RID: 60508
	private readonly Stat AddTargetStat = Stat.Create("FilterChain.AddTarget", "", "");

	// Token: 0x0400EC5D RID: 60509
	private readonly Stat AddFilterStat = Stat.Create("FilterChain.AddFilter", "", "");
}
