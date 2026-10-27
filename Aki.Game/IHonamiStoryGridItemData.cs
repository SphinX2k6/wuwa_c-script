using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E85 RID: 7813
[NullableContext(1)]
public interface IHonamiStoryGridItemData
{
	// Token: 0x0600EE1A RID: 60954
	int GetIncId();

	// Token: 0x0600EE1B RID: 60955
	int GetPosition();

	// Token: 0x0600EE1C RID: 60956
	int GetGridHeight();

	// Token: 0x0600EE1D RID: 60957
	int GetGridWidth();

	// Token: 0x0600EE1E RID: 60958
	int GetRow();

	// Token: 0x0600EE1F RID: 60959
	int GetColumn();

	// Token: 0x0600EE20 RID: 60960
	List<int> GetGridFillPositionList();
}
