using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using FilterDefine;

// Token: 0x02000CF8 RID: 3320
[NullableContext(1)]
[Nullable(0)]
public class MonsterHandBookFilter : CommonFilter
{
	// Token: 0x060089E0 RID: 35296 RVA: 0x0029CCF4 File Offset: 0x0029AEF4
	private object GetMonsterDetectConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		HandBookConfig instance = HandBookConfig.Instance;
		MonsterHandBook? monsterHandBook = (instance != null) ? instance.GetMonsterHandBookConfigById(id) : null;
		return (monsterHandBook != null) ? monsterHandBook.GetValueOrDefault().Type : 0;
	}

	// Token: 0x060089E1 RID: 35297 RVA: 0x0029CD44 File Offset: 0x0029AF44
	private object GetMonsterTypeConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		HandBookConfig instance = HandBookConfig.Instance;
		MonsterHandBook? monsterHandBook = (instance != null) ? instance.GetMonsterHandBookConfigById(id) : null;
		return (monsterHandBook != null) ? monsterHandBook.GetValueOrDefault().Classification : 0;
	}

	// Token: 0x060089E2 RID: 35298 RVA: 0x0029CD93 File Offset: 0x0029AF93
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.MonsterDetect, new TFilterConfig(this.GetMonsterDetectConfig));
		this.FilterMap.Add(FilterDefine.EFilterType.MonsterType, new TFilterConfig(this.GetMonsterTypeConfig));
	}
}
