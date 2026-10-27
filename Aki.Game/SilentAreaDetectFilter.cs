using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using FilterDefine;

// Token: 0x02001847 RID: 6215
public class SilentAreaDetectFilter : CommonFilter
{
	// Token: 0x0600B615 RID: 46613 RVA: 0x00292B58 File Offset: 0x00290D58
	[NullableContext(1)]
	private object GetSilentAreaDetectConfig(object data, Dictionary<int, string> currentSelectMap)
	{
		ISilentAreaDetectionDynamicData silentAreaDetectionDynamicData = (ISilentAreaDetectionDynamicData)data;
		if (silentAreaDetectionDynamicData.SilentAreaDetectionData != null)
		{
			return silentAreaDetectionDynamicData.SilentAreaDetectionData.Conf.Secondary;
		}
		return silentAreaDetectionDynamicData.SilentAreaTitleData.TypeDescription;
	}

	// Token: 0x0600B616 RID: 46614 RVA: 0x00292B9D File Offset: 0x00290D9D
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.SilentAreaDetect, new TFilterConfig(this.GetSilentAreaDetectConfig));
	}
}
