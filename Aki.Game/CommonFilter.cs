using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02001836 RID: 6198
[NullableContext(1)]
[Nullable(0)]
public abstract class CommonFilter
{
	// Token: 0x0600B5CA RID: 46538 RVA: 0x00291D7A File Offset: 0x0028FF7A
	public CommonFilter()
	{
		this.FilterMap = new Dictionary<FilterDefine.EFilterType, TFilterConfig>();
	}

	// Token: 0x0600B5CB RID: 46539 RVA: 0x00291D8D File Offset: 0x0028FF8D
	public void InitFilterMap()
	{
		if (this.IsInit)
		{
			return;
		}
		this.IsInit = true;
		this.OnInitFilterMap();
	}

	// Token: 0x0600B5CC RID: 46540 RVA: 0x00291DA8 File Offset: 0x0028FFA8
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

	// Token: 0x0600B5CD RID: 46541
	protected abstract void OnInitFilterMap();

	// Token: 0x0600B5CE RID: 46542 RVA: 0x00291DC8 File Offset: 0x0028FFC8
	public virtual TDefaultFilter[] DefaultFilterList()
	{
		return Array.Empty<TDefaultFilter>();
	}

	// Token: 0x04005256 RID: 21078
	protected Dictionary<FilterDefine.EFilterType, TFilterConfig> FilterMap;

	// Token: 0x04005257 RID: 21079
	private bool IsInit;
}
