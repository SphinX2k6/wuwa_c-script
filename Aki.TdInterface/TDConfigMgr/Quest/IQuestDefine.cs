using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001070 RID: 4208
	[NullableContext(1)]
	[Nullable(0)]
	public static class IQuestDefine
	{
		// Token: 0x06005E9F RID: 24223 RVA: 0x000E4F54 File Offset: 0x000E3154
		// Note: this type is marked as 'beforefieldinit'.
		static IQuestDefine()
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
			string key = "无冠者";
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2["濒死"] = "怪物.MB1Wuguanzhe00601.濒死触发";
			dictionary2["二阶段"] = "怪物.MB1Wuguanzhe00601.转二阶段镜头";
			dictionary2["三阶段"] = "怪物.MB1Wuguanzhe00601.转三阶段镜头";
			dictionary[key] = dictionary2;
			string key2 = "路迟";
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3["半血演出"] = "怪物.common.状态标识.可以表演";
			dictionary[key2] = dictionary3;
			string key3 = "控物";
			Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
			dictionary4["被控中"] = "关卡.Common.属性.被控中";
			dictionary[key3] = dictionary4;
			IQuestDefine.combatStateConfig = dictionary;
			Dictionary<string, string> dictionary5 = new Dictionary<string, string>();
			dictionary5["[EQuestSubType.DangoActivity]"] = "2.3团子活动任务";
			IQuestDefine.questSubTypeCnMapper = dictionary5;
			Dictionary<string, string> dictionary6 = new Dictionary<string, string>();
			dictionary6["[EQuest.Test]"] = "测试";
			dictionary6["[EQuest.Main]"] = "主线";
			dictionary6["[EQuest.Branch]"] = "支线";
			dictionary6["[EQuest.Role]"] = "角色";
			dictionary6["[EQuest.Daily]"] = "日常";
			dictionary6["[EQuest.Guide]"] = "引导";
			dictionary6["[EQuest.POI]"] = "POI";
			dictionary6["[EQuest.Activity]"] = "活动";
			dictionary6["[EQuest.Hidden]"] = "隐藏任务";
			dictionary6["[EQuest.DangoActivity]"] = "2.3团子活动";
			dictionary6["[EQuest.SpringFestivalInvitation]"] = "3.1春节邀约";
			dictionary6["[EQuest.Recall]"] = "回顾";
			dictionary6["[EQuest.Linkage]"] = "联动任务";
			dictionary6["[EQuest.POI2]"] = "奇谭任务";
			IQuestDefine.questTypeCNMapper = dictionary6;
			Dictionary<string, string> dictionary7 = new Dictionary<string, string>();
			dictionary7["[EQuestRegion.RegionTest]"] = "测试";
			dictionary7["[EQuestRegion.Region1]"] = "云陵谷";
			dictionary7["[EQuestRegion.Region2]"] = "中曲台地";
			dictionary7["[EQuestRegion.Region3]"] = "荒石高地";
			dictionary7["[EQuestRegion.Region4]"] = "遗落原乡";
			dictionary7["[EQuestRegion.Region5]"] = "无光之森";
			dictionary7["[EQuestRegion.Region6]"] = "天城城区";
			dictionary7["[EQuestRegion.Region7]"] = "旧城遗址";
			dictionary7["[EQuestRegion.Region8]"] = "虎口山脉";
			dictionary7["[EQuestRegion.Region9]"] = "怨鸟泽";
			dictionary7["[EQuestRegion.Region10]"] = "北落野";
			dictionary7["[EQuestRegion.Region11]"] = "黑海岸";
			dictionary7["[EQuestRegion.Region12]"] = "乘霄山";
			dictionary7["[EQuestRegion.Region13]"] = "帕尔米罗墓岛";
			dictionary7["[EQuestRegion.Region14]"] = "拉古那城";
			dictionary7["[EQuestRegion.Region15]"] = "扶风水畔";
			dictionary7["[EQuestRegion.Region16]"] = "声骸猎场";
			dictionary7["[EQuestRegion.Region17]"] = "槲生半岛";
			dictionary7["[EQuestRegion.Region18]"] = "氤柔水境";
			dictionary7["[EQuestRegion.Region19]"] = "狄萨莱海脊";
			dictionary7["[EQuestRegion.Region20]"] = "埃弗拉德金库";
			dictionary7["[EQuestRegion.Region21]"] = "黎乔利群岛";
			dictionary7["[EQuestRegion.Region22]"] = "归墟港市";
			dictionary7["[EQuestRegion.Region23]"] = "阿维纽林";
			dictionary7["[EQuestRegion.Region24]"] = "七丘";
			dictionary7["[EQuestRegion.Region25]"] = "隐海试验场";
			dictionary7["[EQuestRegion.Region26]"] = "拉海洛";
			dictionary7["[EQuestRegion.Region27]"] = "无尽宴会";
			dictionary7["[EQuestRegion.Region28]"] = "玄方地界";
			IQuestDefine.questRegionCNMapper = dictionary7;
		}

		// Token: 0x04003905 RID: 14597
		public static readonly IReadOnlyDictionary<string, Dictionary<string, string>> combatStateConfig;

		// Token: 0x04003906 RID: 14598
		public static readonly IReadOnlyDictionary<string, string> questSubTypeCnMapper;

		// Token: 0x04003907 RID: 14599
		public static readonly IReadOnlyDictionary<string, string> questTypeCNMapper;

		// Token: 0x04003908 RID: 14600
		public static readonly IReadOnlyDictionary<string, string> questRegionCNMapper;
	}
}
