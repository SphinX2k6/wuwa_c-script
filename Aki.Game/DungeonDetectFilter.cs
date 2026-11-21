using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using FilterDefine;

// Token: 0x02000CF3 RID: 3315
public class DungeonDetectFilter : CommonFilter
{
	// Token: 0x060089C9 RID: 35273 RVA: 0x0029C7BC File Offset: 0x0029A9BC
	[NullableContext(1)]
	private object GetDungeonDetectConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((DungeonDetectionRecord)data).Conf.Secondary;
	}

	// Token: 0x060089CA RID: 35274 RVA: 0x0029C7E1 File Offset: 0x0029A9E1
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.DungeonDetect, new TFilterConfig(this.GetDungeonDetectConfig));
	}
}
