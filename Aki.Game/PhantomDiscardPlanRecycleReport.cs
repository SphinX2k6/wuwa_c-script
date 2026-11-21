using System;
using System.Runtime.CompilerServices;

// Token: 0x02001632 RID: 5682
[NullableContext(1)]
[Nullable(0)]
public class PhantomDiscardPlanRecycleReport : PlayerCommonLogData
{
	// Token: 0x1700152A RID: 5418
	// (get) Token: 0x0600DEB5 RID: 57013 RVA: 0x0041889E File Offset: 0x00416A9E
	// (set) Token: 0x0600DEB6 RID: 57014 RVA: 0x004188A6 File Offset: 0x00416AA6
	public override string event_id { get; set; } = "1842";

	// Token: 0x04007F1F RID: 32543
	public int i_type;

	// Token: 0x04007F20 RID: 32544
	public int i_operation;
}
