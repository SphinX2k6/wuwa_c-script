using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001346 RID: 4934
[NullableContext(1)]
public interface IHonamiStoryBackpackData
{
	// Token: 0x0600C231 RID: 49713
	int GetCapacity();

	// Token: 0x0600C232 RID: 49714
	int GetWidthCount();

	// Token: 0x0600C233 RID: 49715
	int GetHeightCount();

	// Token: 0x0600C234 RID: 49716
	int GetCellWidth();

	// Token: 0x0600C235 RID: 49717
	int GetCellHeight();

	// Token: 0x0600C236 RID: 49718
	int GetCellHorizontalInterval();

	// Token: 0x0600C237 RID: 49719
	int GetCellVerticalInterval();

	// Token: 0x0600C238 RID: 49720
	List<HonamiStoryItemDataBase> GetItemDataList();
}
