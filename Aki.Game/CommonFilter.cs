using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000CEF RID: 3311
[NullableContext(1)]
[Nullable(0)]
public abstract class CommonFilter
{
	// Token: 0x060089B5 RID: 35253 RVA: 0x0029C49A File Offset: 0x0029A69A
	public CommonFilter()
	{
		this.FilterMap = new Dictionary<FilterDefine.EFilterType, TFilterConfig>();
	}

	// Token: 0x060089B6 RID: 35254 RVA: 0x0029C4AD File Offset: 0x0029A6AD
	public void InitFilterMap()
	{
		if (this.IsInit)
		{
			return;
		}
		this.IsInit = true;
		this.OnInitFilterMap();
	}

	// Token: 0x060089B7 RID: 35255 RVA: 0x0029C4C8 File Offset: 0x0029A6C8
	[NullableContext(2)]
	public TFilterConfig GetFilterFunction(FilterDefine.EFilterType filterType)
	{
		TFilterConfig result;
		if (this.FilterMap.TryGetValue(filterType, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060089B8 RID: 35256
	protected abstract void OnInitFilterMap();

	// Token: 0x060089B9 RID: 35257 RVA: 0x0029C4E8 File Offset: 0x0029A6E8
	public virtual TDefaultFilter[] DefaultFilterList()
	{
		return Array.Empty<TDefaultFilter>();
	}

	// Token: 0x04005301 RID: 21249
	protected Dictionary<FilterDefine.EFilterType, TFilterConfig> FilterMap;

	// Token: 0x04005302 RID: 21250
	private bool IsInit;
}
