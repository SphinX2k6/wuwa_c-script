using System;
using System.Runtime.CompilerServices;

// Token: 0x02002B85 RID: 11141
public abstract class SurvivorsRogueCommandView : ISurvivorsRogueCommandView
{
	// Token: 0x17001ED7 RID: 7895
	// (get) Token: 0x0601717C RID: 94588
	[Nullable(1)]
	public abstract SurvivorsRogueCommandBase Command { [NullableContext(1)] get; }

	// Token: 0x17001ED8 RID: 7896
	// (get) Token: 0x0601717D RID: 94589
	public abstract int CommandIncId { get; }

	// Token: 0x0601717E RID: 94590
	public abstract void Refresh();

	// Token: 0x0601717F RID: 94591
	public abstract void CloseView();
}
