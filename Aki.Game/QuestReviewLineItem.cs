using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200267D RID: 9853
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestReviewLineItem : GridProxyAbstract<QuestReviewLineData>
{
	// Token: 0x06014315 RID: 82709 RVA: 0x0051935C File Offset: 0x0051755C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014316 RID: 82710 RVA: 0x005193C5 File Offset: 0x005175C5
	protected override void OnStart()
	{
		this.LayoutLine = new GenericLayout<QuestReviewNodeItem, QuestReviewNodeParam>(base.GetHorizontalLayout(0), new Func<QuestReviewNodeItem>(this.CreateNodeItem), null, false, true);
	}

	// Token: 0x06014317 RID: 82711 RVA: 0x005193E8 File Offset: 0x005175E8
	public override void Refresh(QuestReviewLineData data, bool isSelected, int gridIndex)
	{
		if (!QuestReviewModel.Instance.IsQuestLineHasAnyVisibleNode(data.Id))
		{
			base.GetRootItem().SetUIActive(false);
			return;
		}
		base.GetRootItem().SetUIActive(true);
		if (data.IsTempLine)
		{
			this.LayoutLine.RefreshByData(new List<QuestReviewNodeParam>(), null, false);
			return;
		}
		List<int> nodeIdListByQuestLineId = QuestReviewModel.Instance.GetNodeIdListByQuestLineId(data.Id);
		List<QuestReviewNodeParam> list = new List<QuestReviewNodeParam>();
		bool flag = QuestReviewModel.Instance.HasQuestLineFused();
		for (int i = 0; i < nodeIdListByQuestLineId.Count; i++)
		{
			int num = nodeIdListByQuestLineId[i];
			QuestReviewNodeData questReviewNodeDataById = QuestReviewModel.Instance.GetQuestReviewNodeDataById(num);
			bool isLastSlotEmpty = i > 0 && (nodeIdListByQuestLineId[i - 1] == 0 || !QuestReviewModel.Instance.IsNodeVisible(nodeIdListByQuestLineId[i - 1]));
			bool isDestroy = data.IsDestroy;
			bool flag2 = QuestReviewModel.Instance.IsNodeVisible(num);
			bool shouldHide = questReviewNodeDataById == null || !flag2;
			for (int j = i + 1; j < nodeIdListByQuestLineId.Count; j++)
			{
				int num2 = nodeIdListByQuestLineId[j];
				if (num2 != 0 && QuestReviewModel.Instance.IsNodeVisible(num2))
				{
					shouldHide = false;
					break;
				}
			}
			if (num == 3604 && !flag)
			{
				shouldHide = true;
			}
			QuestReviewNodeParam item = new QuestReviewNodeParam
			{
				Data = questReviewNodeDataById,
				IsLastSlotEmpty = isLastSlotEmpty,
				IsDestroy = isDestroy,
				IsLastSlot = (i == nodeIdListByQuestLineId.Count - 1),
				LineColorHex = data.LineColorHex,
				StarIcon = data.StarIcon,
				RoundIcon = data.RoundIcon,
				LineId = data.Id,
				ShouldHide = shouldHide,
				SlotIndex = i
			};
			list.Add(item);
		}
		this.LayoutLine.RefreshByData(list, null, false);
		TimerSystem.Instance.Next(delegate(float _)
		{
			if (data.IsShow)
			{
				data.IsFirstTimeShow = false;
			}
			if (data.IsDestroy)
			{
				data.IsFirstTimeDestroy = false;
			}
			if (data.SkipAnim)
			{
				data.SkipAnim = false;
			}
		}, null, null);
	}

	// Token: 0x06014318 RID: 82712 RVA: 0x00519601 File Offset: 0x00517801
	private QuestReviewNodeItem CreateNodeItem()
	{
		return new QuestReviewNodeItem();
	}

	// Token: 0x04009801 RID: 38913
	private GenericLayout<QuestReviewNodeItem, QuestReviewNodeParam> LayoutLine;

	// Token: 0x02008CC8 RID: 36040
	[NullableContext(0)]
	private class EQuestLineComponentDefine
	{
		// Token: 0x0402DAFD RID: 187133
		public const int LayoutSelf = 0;

		// Token: 0x0402DAFE RID: 187134
		public const int ItemNode = 1;
	}
}
