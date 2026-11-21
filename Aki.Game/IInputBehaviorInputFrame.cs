using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

// Token: 0x020026B6 RID: 9910
[NullableContext(1)]
[Nullable(0)]
public class IInputBehaviorInputFrame
{
	// Token: 0x17002780 RID: 10112
	// (get) Token: 0x06018D66 RID: 101734 RVA: 0x0078A634 File Offset: 0x00788834
	// (set) Token: 0x06018D67 RID: 101735 RVA: 0x0078A63C File Offset: 0x0078883C
	public HashSet<EInputAction> PressedActions { get; set; } = new HashSet<EInputAction>();

	// Token: 0x17002781 RID: 10113
	// (get) Token: 0x06018D68 RID: 101736 RVA: 0x0078A645 File Offset: 0x00788845
	// (set) Token: 0x06018D69 RID: 101737 RVA: 0x0078A64D File Offset: 0x0078884D
	public List<IInputBehaviorReleaseEvent> ReleaseEvents { get; set; } = new List<IInputBehaviorReleaseEvent>();

	// Token: 0x17002782 RID: 10114
	// (get) Token: 0x06018D6A RID: 101738 RVA: 0x0078A656 File Offset: 0x00788856
	// (set) Token: 0x06018D6B RID: 101739 RVA: 0x0078A65E File Offset: 0x0078885E
	public List<IInputBehaviorHoldState> HoldStates { get; set; } = new List<IInputBehaviorHoldState>();
}
