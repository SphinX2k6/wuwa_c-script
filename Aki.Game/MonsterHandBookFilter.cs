using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using FilterDefine;

// Token: 0x0200183F RID: 6207
[NullableContext(1)]
[Nullable(0)]
public class MonsterHandBookFilter : CommonFilter
{
	// Token: 0x0600B5F5 RID: 46581 RVA: 0x002925D4 File Offset: 0x002907D4
	private object GetMonsterDetectConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		HandBookConfig instance = HandBookConfig.Instance;
		MonsterHandBook? monsterHandBook = (instance != null) ? instance.GetMonsterHandBookConfigById(id) : null;
		return (monsterHandBook != null) ? monsterHandBook.GetValueOrDefault().Type : 0;
	}

	// Token: 0x0600B5F6 RID: 46582 RVA: 0x00292624 File Offset: 0x00290824
	private object GetMonsterTypeConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		HandBookConfig instance = HandBookConfig.Instance;
		MonsterHandBook? monsterHandBook = (instance != null) ? instance.GetMonsterHandBookConfigById(id) : null;
		return (monsterHandBook != null) ? monsterHandBook.GetValueOrDefault().Classification : 0;
	}

	// Token: 0x0600B5F7 RID: 46583 RVA: 0x00292673 File Offset: 0x00290873
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.MonsterDetect, new TFilterConfig(this.GetMonsterDetectConfig));
		this.FilterMap.Add(FilterDefine.EFilterType.MonsterType, new TFilterConfig(this.GetMonsterTypeConfig));
	}
}
