using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001B5C RID: 7004
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewTreeData
{
	// Token: 0x0601178F RID: 71567 RVA: 0x00526728 File Offset: 0x00524928
	public QuestReviewTreeData(QuestReviewTree config)
	{
	}

	// Token: 0x17001A22 RID: 6690
	// (get) Token: 0x06011790 RID: 71568 RVA: 0x00526737 File Offset: 0x00524937
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17001A23 RID: 6691
	// (get) Token: 0x06011791 RID: 71569 RVA: 0x00526744 File Offset: 0x00524944
	public List<int> QuestLines
	{
		get
		{
			return new List<int>(this.Config.QuestLines());
		}
	}

	// Token: 0x04009930 RID: 39216
	private QuestReviewTree Config = config;
}
