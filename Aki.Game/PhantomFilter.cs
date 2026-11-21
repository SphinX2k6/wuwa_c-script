using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000CFA RID: 3322
[NullableContext(1)]
[Nullable(0)]
public class PhantomFilter : CommonFilter
{
	// Token: 0x060089E7 RID: 35303 RVA: 0x0029CE8D File Offset: 0x0029B08D
	protected object GetPhantomItemId(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IPhantomItemData)data).MonsterId;
	}

	// Token: 0x060089E8 RID: 35304 RVA: 0x0029CE9F File Offset: 0x0029B09F
	protected object GetPhantomRarity(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IPhantomItemData)data).Rarity;
	}

	// Token: 0x060089E9 RID: 35305 RVA: 0x0029CEB4 File Offset: 0x0029B0B4
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Phantom, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.PhantomRarity, new TFilterConfig(this.GetPhantomRarity));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity1, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity2, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity3, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity4, new TFilterConfig(this.GetPhantomItemId));
	}
}
