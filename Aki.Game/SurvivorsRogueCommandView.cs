using System;
using System.Runtime.CompilerServices;

// Token: 0x02002101 RID: 8449
public abstract class SurvivorsRogueCommandView : ISurvivorsRogueCommandView
{
	// Token: 0x17001F2F RID: 7983
	// (get) Token: 0x06014BAD RID: 84909
	[Nullable(1)]
	public abstract SurvivorsRogueCommandBase Command { [NullableContext(1)] get; }

	// Token: 0x17001F30 RID: 7984
	// (get) Token: 0x06014BAE RID: 84910
	public abstract int CommandIncId { get; }

	// Token: 0x06014BAF RID: 84911
	public abstract void Refresh();

	// Token: 0x06014BB0 RID: 84912
	public abstract void CloseView();
}
