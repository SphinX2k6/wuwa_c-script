using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E60 RID: 7776
public class RoleVisionIdentifyAttribute : UiPanelBase
{
	// Token: 0x060133D8 RID: 78808 RVA: 0x0059F6D0 File Offset: 0x0059D8D0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060133D9 RID: 78809 RVA: 0x0059F739 File Offset: 0x0059D939
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<VisionIdentifyItem, VisionSubPropViewData>(base.GetVerticalLayout(0), new Func<VisionIdentifyItem>(this.InitItem), null, false, true);
	}

	// Token: 0x060133DA RID: 78810 RVA: 0x0059F75C File Offset: 0x0059D95C
	[NullableContext(1)]
	private VisionIdentifyItem InitItem()
	{
		return new VisionIdentifyItem();
	}

	// Token: 0x060133DB RID: 78811 RVA: 0x0059F764 File Offset: 0x0059D964
	[NullableContext(2)]
	public void Refresh([Nullable(1)] List<VisionSubPropData> data, PhantomBattleData dataBase, VisionDetailInfoComponentData detailData)
	{
		VisionAttrRecommendInfo roleCostAttrRecommendInfo = VisionRecommendModel.Instance.GetRoleCostAttrRecommendInfo(detailData.RoleId, detailData.Cost);
		List<AttrRecommendInfo> list = (roleCostAttrRecommendInfo != null) ? roleCostAttrRecommendInfo.GetSubAttrRecommendInfo() : null;
		int num = (list != null) ? list.Count : 0;
		List<VisionSubPropViewData> list2 = new List<VisionSubPropViewData>();
		foreach (VisionSubPropData visionSubPropData in data)
		{
			VisionSubPropViewData visionSubPropViewData = new VisionSubPropViewData();
			visionSubPropViewData.Data = visionSubPropData;
			visionSubPropViewData.SourceView = "VisionEquipmentView";
			visionSubPropViewData.CurrentVisionData = dataBase;
			if (visionSubPropData.PhantomSubProp != null)
			{
				PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(visionSubPropData.PhantomSubProp.PhantomPropId);
				if (roleCostAttrRecommendInfo != null)
				{
					for (int i = 0; i < num; i++)
					{
						if (phantomSubPropertyById.AddType == list[i].GetAddType() && phantomSubPropertyById.PropId == list[i].GetAttrId())
						{
							visionSubPropViewData.NeedHighLight = true;
						}
					}
				}
			}
			list2.Add(visionSubPropViewData);
		}
		this.AttributeScroller.RefreshByData(list2, null, false);
	}

	// Token: 0x0400A4B6 RID: 42166
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	public GenericLayout<VisionIdentifyItem, VisionSubPropViewData> AttributeScroller;

	// Token: 0x02008141 RID: 33089
	private enum EComponent
	{
		// Token: 0x04029CB9 RID: 171193
		VerticalLayout,
		// Token: 0x04029CBA RID: 171194
		LayoutItem
	}
}
