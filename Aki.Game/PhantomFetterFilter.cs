using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using FilterDefine;

// Token: 0x02000CF9 RID: 3321
public class PhantomFetterFilter : CommonFilter
{
	// Token: 0x060089E4 RID: 35300 RVA: 0x0029CDD0 File Offset: 0x0029AFD0
	[NullableContext(1)]
	protected object GetPhantomItemIdList(object data, Dictionary<int, string> currentSelectMap)
	{
		PhantomFetterGroup phantomFetterGroup = (PhantomFetterGroup)data;
		int[] fetterGroupMonsterIdArray = PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(phantomFetterGroup.Id);
		int[] array = new int[fetterGroupMonsterIdArray.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = fetterGroupMonsterIdArray[i];
		}
		return array;
	}

	// Token: 0x060089E5 RID: 35301 RVA: 0x0029CE14 File Offset: 0x0029B014
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity1, new TFilterConfig(this.GetPhantomItemIdList));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity2, new TFilterConfig(this.GetPhantomItemIdList));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity3, new TFilterConfig(this.GetPhantomItemIdList));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity4, new TFilterConfig(this.GetPhantomItemIdList));
	}
}
