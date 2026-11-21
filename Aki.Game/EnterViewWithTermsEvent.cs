using System;
using System.Runtime.CompilerServices;

// Token: 0x020015E5 RID: 5605
[NullableContext(1)]
[Nullable(0)]
public class EnterViewWithTermsEvent : PlayerCommonLogData
{
	// Token: 0x170014E1 RID: 5345
	// (get) Token: 0x0600DDD6 RID: 56790 RVA: 0x00417B4D File Offset: 0x00415D4D
	// (set) Token: 0x0600DDD7 RID: 56791 RVA: 0x00417B55 File Offset: 0x00415D55
	public override string event_id { get; set; } = "1067";

	// Token: 0x04007D93 RID: 32147
	public int i_scene;
}
