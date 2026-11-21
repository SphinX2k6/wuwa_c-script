using System;
using System.Runtime.CompilerServices;

// Token: 0x02002100 RID: 8448
[NullableContext(1)]
public interface ISurvivorsRogueCommandView
{
	// Token: 0x17001F2D RID: 7981
	// (get) Token: 0x06014BA9 RID: 84905
	SurvivorsRogueCommandBase Command { get; }

	// Token: 0x17001F2E RID: 7982
	// (get) Token: 0x06014BAA RID: 84906
	int CommandIncId { get; }

	// Token: 0x06014BAB RID: 84907
	void Refresh();

	// Token: 0x06014BAC RID: 84908
	void CloseView();
}
