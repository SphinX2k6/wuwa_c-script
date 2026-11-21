using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001347 RID: 4935
[NullableContext(1)]
public interface IHonamiStoryGridItemData
{
	// Token: 0x0600C239 RID: 49721
	int GetIncId();

	// Token: 0x0600C23A RID: 49722
	int GetPosition();

	// Token: 0x0600C23B RID: 49723
	int GetGridHeight();

	// Token: 0x0600C23C RID: 49724
	int GetGridWidth();

	// Token: 0x0600C23D RID: 49725
	int GetRow();

	// Token: 0x0600C23E RID: 49726
	int GetColumn();

	// Token: 0x0600C23F RID: 49727
	List<int> GetGridFillPositionList();
}
