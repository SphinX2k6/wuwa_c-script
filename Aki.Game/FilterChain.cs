using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020034BA RID: 13498
[NullableContext(1)]
[Nullable(0)]
public class FilterChain<[Nullable(2)] T>
{
	// Token: 0x0601D654 RID: 120404 RVA: 0x00833410 File Offset: 0x00831610
	protected FilterChain()
	{
	}

	// Token: 0x0601D655 RID: 120405 RVA: 0x00833484 File Offset: 0x00831684
	protected void Init()
	{
		foreach (EFilterType key in FilterTypeHelper.FilterTypePriority)
		{
			this.AllTypeFilters[key] = new HashSet<Filter<T>>();
		}
		EventSystem.Instance.Add<object>(EEventName.FilterCriteriaChanged, new Action<object>(this.OnFilterCriteriaChanged));
		FilterTypeHelper.TryCatchWrapper<bool>(new Func<bool>(this.OnInit), "[FilterChain] OnInit执行出错", base.GetType().Name);
	}

	// Token: 0x0601D656 RID: 120406 RVA: 0x008334F9 File Offset: 0x008316F9
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x0601D657 RID: 120407 RVA: 0x008334FC File Offset: 0x008316FC
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

	// Token: 0x0601D658 RID: 120408 RVA: 0x008335F8 File Offset: 0x008317F8
	protected virtual bool OnCleanup()
	{
		return true;
	}

	// Token: 0x0601D659 RID: 120409 RVA: 0x008335FC File Offset: 0x008317FC
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
				foreach (T t in hashSet.ToList<T>())
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

	// Token: 0x0601D65A RID: 120410 RVA: 0x0083377C File Offset: 0x0083197C
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
		IEnumerable<T> source = this.FilterHoldTargets[filter];
		this.FilterHoldTargets.Remove(filter);
		foreach (T t in source.ToList<T>())
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

	// Token: 0x0601D65B RID: 120411 RVA: 0x008338CC File Offset: 0x00831ACC
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

	// Token: 0x0601D65C RID: 120412 RVA: 0x00833A10 File Offset: 0x00831C10
	public Filter<T>[] GetAllFilters()
	{
		return this.AllTypeFilters.Values.SelectMany((HashSet<Filter<T>> filters) => filters).ToArray<Filter<T>>();
	}

	// Token: 0x0601D65D RID: 120413 RVA: 0x00833A48 File Offset: 0x00831C48
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

	// Token: 0x0601D65E RID: 120414 RVA: 0x00833BBB File Offset: 0x00831DBB
	protected virtual void OnPassedTargetModified(T target, bool isAdd)
	{
	}

	// Token: 0x0601D65F RID: 120415 RVA: 0x00833BC0 File Offset: 0x00831DC0
	private void OnFilterCriteriaChanged(object filterUnknown)
	{
		Filter<T> filter = filterUnknown as Filter<T>;
		if (filter == null)
		{
			return;
		}
		IEnumerable<T> source = this.FilterHoldTargets[filter];
		this.FilterHoldTargets[filter] = new HashSet<T>();
		foreach (T t in source.ToList<T>())
		{
			this.TargetsWithFilter.Remove(t);
			this.AddTarget(t, filter.FilterType);
		}
	}

	// Token: 0x0601D660 RID: 120416 RVA: 0x00833C50 File Offset: 0x00831E50
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

	// Token: 0x0400E7A4 RID: 59300
	protected readonly Dictionary<EFilterType, HashSet<Filter<T>>> AllTypeFilters = new Dictionary<EFilterType, HashSet<Filter<T>>>();

	// Token: 0x0400E7A5 RID: 59301
	private readonly Dictionary<T, Filter<T>> TargetsWithFilter = new Dictionary<T, Filter<T>>();

	// Token: 0x0400E7A6 RID: 59302
	private readonly Dictionary<Filter<T>, HashSet<T>> FilterHoldTargets = new Dictionary<Filter<T>, HashSet<T>>();

	// Token: 0x0400E7A7 RID: 59303
	private readonly HashSet<T> TargetsPassed = new HashSet<T>();

	// Token: 0x0400E7A8 RID: 59304
	private readonly Stat AddTargetStat = Stat.Create("FilterChain.AddTarget", "", "");

	// Token: 0x0400E7A9 RID: 59305
	private readonly Stat AddFilterStat = Stat.Create("FilterChain.AddFilter", "", "");
}
