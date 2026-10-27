using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E84 RID: 7812
[NullableContext(1)]
public interface IHonamiStoryBackpackData
{
	// Token: 0x0600EE12 RID: 60946
	int GetCapacity();

	// Token: 0x0600EE13 RID: 60947
	int GetWidthCount();

	// Token: 0x0600EE14 RID: 60948
	int GetHeightCount();

	// Token: 0x0600EE15 RID: 60949
	int GetCellWidth();

	// Token: 0x0600EE16 RID: 60950
	int GetCellHeight();

	// Token: 0x0600EE17 RID: 60951
	int GetCellHorizontalInterval();

	// Token: 0x0600EE18 RID: 60952
	int GetCellVerticalInterval();

	// Token: 0x0600EE19 RID: 60953
	List<HonamiStoryItemDataBase> GetItemDataList();
}
