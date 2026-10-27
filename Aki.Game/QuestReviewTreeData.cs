using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002671 RID: 9841
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewTreeData
{
	// Token: 0x060142AD RID: 82605 RVA: 0x005179D0 File Offset: 0x00515BD0
	public QuestReviewTreeData(QuestReviewTree config)
	{
	}

	// Token: 0x170019EA RID: 6634
	// (get) Token: 0x060142AE RID: 82606 RVA: 0x005179DF File Offset: 0x00515BDF
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170019EB RID: 6635
	// (get) Token: 0x060142AF RID: 82607 RVA: 0x005179EC File Offset: 0x00515BEC
	public List<int> QuestLines
	{
		get
		{
			return this.Config.QuestLines().ToList<int>();
		}
	}

	// Token: 0x040097D8 RID: 38872
	private QuestReviewTree Config = config;
}
