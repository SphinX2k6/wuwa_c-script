using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x020025FE RID: 9726
[NullableContext(2)]
[Nullable(0)]
public class CharacterDynamicFlowData
{
	// Token: 0x0400D1D6 RID: 53718
	public DynamicFlowActorInfo MasterInfo;

	// Token: 0x0400D1D7 RID: 53719
	public AddPlayBubble BubbleData;

	// Token: 0x0400D1D8 RID: 53720
	public EDynamicFlowType? Type;

	// Token: 0x0400D1D9 RID: 53721
	public Action Callback;
}
