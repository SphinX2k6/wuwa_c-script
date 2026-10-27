using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02001848 RID: 6216
public class VisionAssembleFilter : CommonFilter
{
	// Token: 0x0600B618 RID: 46616 RVA: 0x00292BC0 File Offset: 0x00290DC0
	[NullableContext(1)]
	private object GetVisionAssembleGroupAttribute(object data, Dictionary<int, string> currentSelectMap)
	{
		List<int> list = new List<int>();
		foreach (VisionAssembleAttrData visionAssembleAttrData in VisionEquipGroupModel.Instance.GetVisionAssembleViewAttrData((int)data, false, 0))
		{
			int attrId = visionAssembleAttrData.AttrId;
			int num = (!visionAssembleAttrData.IfPercentage) ? 1 : 2;
			int item = attrId * 10 + num;
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600B619 RID: 46617 RVA: 0x00292C50 File Offset: 0x00290E50
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Attribute, new TFilterConfig(this.GetVisionAssembleGroupAttribute));
	}
}
