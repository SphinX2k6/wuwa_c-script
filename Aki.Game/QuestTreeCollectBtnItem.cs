using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B9C RID: 7068
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeCollectBtnItem : UiPanelBase
{
	// Token: 0x0601199B RID: 72091 RVA: 0x0052FEB1 File Offset: 0x0052E0B1
	public QuestTreeCollectBtnItem(QuestTreeChapterData data)
	{
		this.Data = data;
	}

	// Token: 0x0601199C RID: 72092 RVA: 0x0052FEC0 File Offset: 0x0052E0C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCollectClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601199D RID: 72093 RVA: 0x0052FF87 File Offset: 0x0052E187
	protected override void OnStart()
	{
		this.Refresh();
	}

	// Token: 0x0601199E RID: 72094 RVA: 0x0052FF90 File Offset: 0x0052E190
	public void Refresh()
	{
		List<QuestTreeNodeData> acceptableNodeList = this.Data.GetAcceptableNodeList();
		bool uiactive = false;
		using (List<QuestTreeNodeData>.Enumerator enumerator = acceptableNodeList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.HasNewTag())
				{
					uiactive = true;
					break;
				}
			}
		}
		base.GetItem(2).SetUIActive(uiactive);
	}

	// Token: 0x0601199F RID: 72095 RVA: 0x0052FFFC File Offset: 0x0052E1FC
	public void RefreshByData(QuestTreeChapterData data)
	{
		this.Data = data;
		this.Refresh();
	}

	// Token: 0x060119A0 RID: 72096 RVA: 0x0053000C File Offset: 0x0052E20C
	private void OnCollectClick()
	{
		List<QuestTreeNodeData> acceptableNodeList = this.Data.GetAcceptableNodeList();
		if (acceptableNodeList.Count == 0)
		{
			return;
		}
		QuestTreeController.Instance.OpenAvailableListView(acceptableNodeList);
		base.GetItem(2).SetUIActive(false);
		QuestTreeClickAcceptableLogEvent questTreeClickAcceptableLogEvent = new QuestTreeClickAcceptableLogEvent();
		questTreeClickAcceptableLogEvent.i_chapter_id = this.Data.Id;
		LogReportController.Instance.LogReport(questTreeClickAcceptableLogEvent);
	}

	// Token: 0x04009A01 RID: 39425
	private QuestTreeChapterData Data;

	// Token: 0x02007E81 RID: 32385
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028EE4 RID: 167652
		public const int BtnCollect = 0;

		// Token: 0x04028EE5 RID: 167653
		public const int ItemRedDot = 1;

		// Token: 0x04028EE6 RID: 167654
		public const int ItemNew = 2;
	}
}
