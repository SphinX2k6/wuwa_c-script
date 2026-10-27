using System;
using System.Runtime.CompilerServices;

// Token: 0x02002B84 RID: 11140
[NullableContext(1)]
public interface ISurvivorsRogueCommandView
{
	// Token: 0x17001ED5 RID: 7893
	// (get) Token: 0x06017178 RID: 94584
	SurvivorsRogueCommandBase Command { get; }

	// Token: 0x17001ED6 RID: 7894
	// (get) Token: 0x06017179 RID: 94585
	int CommandIncId { get; }

	// Token: 0x0601717A RID: 94586
	void Refresh();

	// Token: 0x0601717B RID: 94587
	void CloseView();
}
