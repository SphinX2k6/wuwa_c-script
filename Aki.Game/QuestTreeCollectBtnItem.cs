using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020026B1 RID: 9905
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeCollectBtnItem : UiPanelBase
{
	// Token: 0x060144B9 RID: 83129 RVA: 0x00521179 File Offset: 0x0051F379
	public QuestTreeCollectBtnItem(QuestTreeChapterData data)
	{
		this.Data = data;
	}

	// Token: 0x060144BA RID: 83130 RVA: 0x00521188 File Offset: 0x0051F388
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

	// Token: 0x060144BB RID: 83131 RVA: 0x0052124F File Offset: 0x0051F44F
	protected override void OnStart()
	{
		this.Refresh();
	}

	// Token: 0x060144BC RID: 83132 RVA: 0x00521258 File Offset: 0x0051F458
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

	// Token: 0x060144BD RID: 83133 RVA: 0x005212C4 File Offset: 0x0051F4C4
	public void RefreshByData(QuestTreeChapterData data)
	{
		this.Data = data;
		this.Refresh();
	}

	// Token: 0x060144BE RID: 83134 RVA: 0x005212D4 File Offset: 0x0051F4D4
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

	// Token: 0x040098A9 RID: 39081
	private QuestTreeChapterData Data;

	// Token: 0x02008CF8 RID: 36088
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DBCD RID: 187341
		public const int BtnCollect = 0;

		// Token: 0x0402DBCE RID: 187342
		public const int ItemRedDot = 1;

		// Token: 0x0402DBCF RID: 187343
		public const int ItemNew = 2;
	}
}
