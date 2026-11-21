using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using FilterDefine;

// Token: 0x02000D00 RID: 3328
public class SilentAreaDetectFilter : CommonFilter
{
	// Token: 0x06008A00 RID: 35328 RVA: 0x0029D290 File Offset: 0x0029B490
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

	// Token: 0x06008A01 RID: 35329 RVA: 0x0029D2D5 File Offset: 0x0029B4D5
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.SilentAreaDetect, new TFilterConfig(this.GetSilentAreaDetectConfig));
	}
}
