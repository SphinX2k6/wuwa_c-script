using System;
using System.Runtime.CompilerServices;

// Token: 0x02002672 RID: 9842
[NullableContext(2)]
[Nullable(0)]
public class SwitchState : ISwitchState, IActionParamMap
{
	// Token: 0x1700270D RID: 9997
	// (get) Token: 0x06018A8A RID: 101002 RVA: 0x0077AEC7 File Offset: 0x007790C7
	// (set) Token: 0x06018A8B RID: 101003 RVA: 0x0077AECF File Offset: 0x007790CF
	public string TargetStateName { get; set; }

	// Token: 0x1700270E RID: 9998
	// (get) Token: 0x06018A8C RID: 101004 RVA: 0x0077AED8 File Offset: 0x007790D8
	// (set) Token: 0x06018A8D RID: 101005 RVA: 0x0077AEE0 File Offset: 0x007790E0
	public bool? IsNoTransition { get; set; }

	// Token: 0x1700270F RID: 9999
	// (get) Token: 0x06018A8E RID: 101006 RVA: 0x0077AEE9 File Offset: 0x007790E9
	// (set) Token: 0x06018A8F RID: 101007 RVA: 0x0077AEF1 File Offset: 0x007790F1
	public string Context { get; set; }
}
