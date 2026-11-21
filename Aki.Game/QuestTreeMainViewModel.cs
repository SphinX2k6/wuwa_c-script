using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001B92 RID: 7058
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeMainViewModel
{
	// Token: 0x06011938 RID: 71992 RVA: 0x0052E46B File Offset: 0x0052C66B
	protected QuestTreeMainViewModel()
	{
	}

	// Token: 0x06011939 RID: 71993 RVA: 0x0052E485 File Offset: 0x0052C685
	public static QuestTreeMainViewModel Create()
	{
		return new QuestTreeMainViewModel();
	}

	// Token: 0x0601193A RID: 71994 RVA: 0x0052E48C File Offset: 0x0052C68C
	public void InitLocatingHelper(UUIScrollViewComponent scroll)
	{
		if (this.LocatingHelper == null)
		{
			this.LocatingHelper = new QuestTreeNodeLocatingHelper(scroll);
		}
	}

	// Token: 0x0601193B RID: 71995 RVA: 0x0052E4A2 File Offset: 0x0052C6A2
	public void OnViewClose()
	{
		this.Clear();
	}

	// Token: 0x0601193C RID: 71996 RVA: 0x0052E4AA File Offset: 0x0052C6AA
	public void Clear()
	{
		this.DelegatesOnLocatingNode.Clear();
		if (this.LocatingHelper != null)
		{
			this.LocatingHelper.Clear();
			this.LocatingHelper = null;
		}
	}

	// Token: 0x0601193D RID: 71997 RVA: 0x0052E4D4 File Offset: 0x0052C6D4
	public List<List<QuestTreeChapterData>> GetViewDataList()
	{
		List<List<QuestTreeChapterData>> list = new List<List<QuestTreeChapterData>>();
		List<QuestTreeChapterData> visibleChapterDataList = QuestTreeModel.Instance.GetVisibleChapterDataList();
		for (int i = 0; i < visibleChapterDataList.Count; i += 5)
		{
			int count = Math.Min(5, visibleChapterDataList.Count - i);
			List<QuestTreeChapterData> range = visibleChapterDataList.GetRange(i, count);
			list.Add(range);
		}
		return list;
	}

	// Token: 0x0601193E RID: 71998 RVA: 0x0052E525 File Offset: 0x0052C725
	public void AddOnLocatingNode([Nullable(new byte[]
	{
		1,
		2
	})] Action<QuestTreeChapterData, bool> action)
	{
		this.DelegatesOnLocatingNode.Add(action);
	}

	// Token: 0x0601193F RID: 71999 RVA: 0x0052E533 File Offset: 0x0052C733
	public void RemoveOnLocatingNode([Nullable(new byte[]
	{
		1,
		2
	})] Action<QuestTreeChapterData, bool> action)
	{
		this.DelegatesOnLocatingNode.Remove(action);
	}

	// Token: 0x06011940 RID: 72000 RVA: 0x0052E544 File Offset: 0x0052C744
	[NullableContext(2)]
	public void LocateNode(QuestTreeChapterData data, bool tween = true)
	{
		foreach (Action<QuestTreeChapterData, bool> action in this.DelegatesOnLocatingNode)
		{
			action(data, tween);
		}
	}

	// Token: 0x06011941 RID: 72001 RVA: 0x0052E598 File Offset: 0x0052C798
	[NullableContext(2)]
	public QuestTreeChapterData GetDefaultLocatingNode()
	{
		List<QuestTreeChapterData> visibleChapterDataList = QuestTreeModel.Instance.GetVisibleChapterDataList();
		QuestTreeChapterData questTreeChapterData = null;
		foreach (QuestTreeChapterData questTreeChapterData2 in visibleChapterDataList)
		{
			if (questTreeChapterData2.IsTracking)
			{
				return questTreeChapterData2;
			}
			if (questTreeChapterData2.IsUnlock)
			{
				questTreeChapterData = questTreeChapterData2;
			}
		}
		QuestTreeChapterData result;
		if ((result = questTreeChapterData) == null)
		{
			if (visibleChapterDataList.Count <= 0)
			{
				return null;
			}
			List<QuestTreeChapterData> list = visibleChapterDataList;
			result = list[list.Count - 1];
		}
		return result;
	}

	// Token: 0x06011942 RID: 72002 RVA: 0x0052E624 File Offset: 0x0052C824
	public void SetShouldLocateToDefaultNode(bool should)
	{
		this.ShouldLocateToDefaultNode = should;
	}

	// Token: 0x040099DE RID: 39390
	[Nullable(2)]
	public QuestTreeNodeLocatingHelper LocatingHelper;

	// Token: 0x040099DF RID: 39391
	public bool ShouldLocateToDefaultNode = true;

	// Token: 0x040099E0 RID: 39392
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private List<Action<QuestTreeChapterData, bool>> DelegatesOnLocatingNode = new List<Action<QuestTreeChapterData, bool>>();
}
