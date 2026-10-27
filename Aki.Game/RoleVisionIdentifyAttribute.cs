using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028E5 RID: 10469
public class RoleVisionIdentifyAttribute : UiPanelBase
{
	// Token: 0x060159D4 RID: 88532 RVA: 0x00574808 File Offset: 0x00572A08
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

	// Token: 0x060159D5 RID: 88533 RVA: 0x00574871 File Offset: 0x00572A71
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<VisionIdentifyItem, VisionSubPropViewData>(base.GetVerticalLayout(0), new Func<VisionIdentifyItem>(this.InitItem), null, false, true);
	}

	// Token: 0x060159D6 RID: 88534 RVA: 0x00574894 File Offset: 0x00572A94
	[NullableContext(1)]
	private VisionIdentifyItem InitItem()
	{
		return new VisionIdentifyItem();
	}

	// Token: 0x060159D7 RID: 88535 RVA: 0x0057489C File Offset: 0x00572A9C
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

	// Token: 0x0400A0CC RID: 41164
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	public GenericLayout<VisionIdentifyItem, VisionSubPropViewData> AttributeScroller;

	// Token: 0x02008EF9 RID: 36601
	private enum EComponent
	{
		// Token: 0x0402E5BE RID: 189886
		VerticalLayout,
		// Token: 0x0402E5BF RID: 189887
		LayoutItem
	}
}
