using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using FilterDefine;

// Token: 0x02000CF7 RID: 3319
[NullableContext(1)]
[Nullable(0)]
public class MonsterDetectFilter : CommonFilter
{
	// Token: 0x060089DC RID: 35292 RVA: 0x0029CC6C File Offset: 0x0029AE6C
	private object GetMonsterDetectConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((MonsterDetectionRecord)data).Conf.DangerType;
	}

	// Token: 0x060089DD RID: 35293 RVA: 0x0029CC94 File Offset: 0x0029AE94
	private object GetMonsterTypeConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((MonsterDetectionRecord)data).Conf.TypeDescription2;
	}

	// Token: 0x060089DE RID: 35294 RVA: 0x0029CCB9 File Offset: 0x0029AEB9
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.MonsterDetect, new TFilterConfig(this.GetMonsterDetectConfig));
		this.FilterMap.Add(FilterDefine.EFilterType.MonsterType, new TFilterConfig(this.GetMonsterTypeConfig));
	}
}
