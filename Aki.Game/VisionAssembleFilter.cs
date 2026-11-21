using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000D01 RID: 3329
public class VisionAssembleFilter : CommonFilter
{
	// Token: 0x06008A03 RID: 35331 RVA: 0x0029D2F8 File Offset: 0x0029B4F8
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

	// Token: 0x06008A04 RID: 35332 RVA: 0x0029D388 File Offset: 0x0029B588
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Attribute, new TFilterConfig(this.GetVisionAssembleGroupAttribute));
	}
}
