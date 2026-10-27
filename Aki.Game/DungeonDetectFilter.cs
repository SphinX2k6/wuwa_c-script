using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using FilterDefine;

// Token: 0x0200183A RID: 6202
public class DungeonDetectFilter : CommonFilter
{
	// Token: 0x0600B5DE RID: 46558 RVA: 0x0029209C File Offset: 0x0029029C
	[NullableContext(1)]
	private object GetDungeonDetectConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((DungeonDetectionRecord)data).Conf.Secondary;
	}

	// Token: 0x0600B5DF RID: 46559 RVA: 0x002920C1 File Offset: 0x002902C1
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.DungeonDetect, new TFilterConfig(this.GetDungeonDetectConfig));
	}
}
