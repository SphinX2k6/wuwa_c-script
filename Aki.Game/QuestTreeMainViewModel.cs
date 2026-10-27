using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026A7 RID: 9895
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeMainViewModel
{
	// Token: 0x06014456 RID: 83030 RVA: 0x0051F733 File Offset: 0x0051D933
	protected QuestTreeMainViewModel()
	{
	}

	// Token: 0x06014457 RID: 83031 RVA: 0x0051F74D File Offset: 0x0051D94D
	public static QuestTreeMainViewModel Create()
	{
		return new QuestTreeMainViewModel();
	}

	// Token: 0x06014458 RID: 83032 RVA: 0x0051F754 File Offset: 0x0051D954
	public void InitLocatingHelper(UUIScrollViewComponent scroll)
	{
		if (this.LocatingHelper == null)
		{
			this.LocatingHelper = new QuestTreeNodeLocatingHelper(scroll);
		}
	}

	// Token: 0x06014459 RID: 83033 RVA: 0x0051F76A File Offset: 0x0051D96A
	public void OnViewClose()
	{
		this.Clear();
	}

	// Token: 0x0601445A RID: 83034 RVA: 0x0051F772 File Offset: 0x0051D972
	public void Clear()
	{
		this.DelegatesOnLocatingNode.Clear();
		if (this.LocatingHelper != null)
		{
			this.LocatingHelper.Clear();
			this.LocatingHelper = null;
		}
	}

	// Token: 0x0601445B RID: 83035 RVA: 0x0051F79C File Offset: 0x0051D99C
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

	// Token: 0x0601445C RID: 83036 RVA: 0x0051F7ED File Offset: 0x0051D9ED
	public void AddOnLocatingNode([Nullable(new byte[]
	{
		1,
		2
	})] Action<QuestTreeChapterData, bool> action)
	{
		this.DelegatesOnLocatingNode.Add(action);
	}

	// Token: 0x0601445D RID: 83037 RVA: 0x0051F7FB File Offset: 0x0051D9FB
	public void RemoveOnLocatingNode([Nullable(new byte[]
	{
		1,
		2
	})] Action<QuestTreeChapterData, bool> action)
	{
		this.DelegatesOnLocatingNode.Remove(action);
	}

	// Token: 0x0601445E RID: 83038 RVA: 0x0051F80C File Offset: 0x0051DA0C
	[NullableContext(2)]
	public void LocateNode(QuestTreeChapterData data, bool tween = true)
	{
		foreach (Action<QuestTreeChapterData, bool> action in this.DelegatesOnLocatingNode)
		{
			action(data, tween);
		}
	}

	// Token: 0x0601445F RID: 83039 RVA: 0x0051F860 File Offset: 0x0051DA60
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

	// Token: 0x06014460 RID: 83040 RVA: 0x0051F8EC File Offset: 0x0051DAEC
	public void SetShouldLocateToDefaultNode(bool should)
	{
		this.ShouldLocateToDefaultNode = should;
	}

	// Token: 0x04009886 RID: 39046
	[Nullable(2)]
	public QuestTreeNodeLocatingHelper LocatingHelper;

	// Token: 0x04009887 RID: 39047
	public bool ShouldLocateToDefaultNode = true;

	// Token: 0x04009888 RID: 39048
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private List<Action<QuestTreeChapterData, bool>> DelegatesOnLocatingNode = new List<Action<QuestTreeChapterData, bool>>();
}
