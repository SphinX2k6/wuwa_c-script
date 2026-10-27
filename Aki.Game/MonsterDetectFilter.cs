using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using FilterDefine;

// Token: 0x0200183E RID: 6206
[NullableContext(1)]
[Nullable(0)]
public class MonsterDetectFilter : CommonFilter
{
	// Token: 0x0600B5F1 RID: 46577 RVA: 0x0029254C File Offset: 0x0029074C
	private object GetMonsterDetectConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((MonsterDetectionRecord)data).Conf.DangerType;
	}

	// Token: 0x0600B5F2 RID: 46578 RVA: 0x00292574 File Offset: 0x00290774
	private object GetMonsterTypeConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((MonsterDetectionRecord)data).Conf.TypeDescription2;
	}

	// Token: 0x0600B5F3 RID: 46579 RVA: 0x00292599 File Offset: 0x00290799
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.MonsterDetect, new TFilterConfig(this.GetMonsterDetectConfig));
		this.FilterMap.Add(FilterDefine.EFilterType.MonsterType, new TFilterConfig(this.GetMonsterTypeConfig));
	}
}
