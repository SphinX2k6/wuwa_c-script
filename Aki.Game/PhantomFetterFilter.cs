using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using FilterDefine;

// Token: 0x02001840 RID: 6208
public class PhantomFetterFilter : CommonFilter
{
	// Token: 0x0600B5F9 RID: 46585 RVA: 0x002926B0 File Offset: 0x002908B0
	[NullableContext(1)]
	protected object GetPhantomItemIdList(object data, Dictionary<int, string> currentSelectMap)
	{
		PhantomFetterGroup phantomFetterGroup = (PhantomFetterGroup)data;
		return PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(phantomFetterGroup.Id).ToArray<int>();
	}

	// Token: 0x0600B5FA RID: 46586 RVA: 0x002926DC File Offset: 0x002908DC
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity1, new TFilterConfig(this.GetPhantomItemIdList));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity2, new TFilterConfig(this.GetPhantomItemIdList));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity3, new TFilterConfig(this.GetPhantomItemIdList));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity4, new TFilterConfig(this.GetPhantomItemIdList));
	}
}
