using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x020030A7 RID: 12455
[NullableContext(2)]
[Nullable(0)]
public class CharacterDynamicFlowData
{
	// Token: 0x0400CDF2 RID: 52722
	public DynamicFlowActorInfo MasterInfo;

	// Token: 0x0400CDF3 RID: 52723
	public AddPlayBubble BubbleData;

	// Token: 0x0400CDF4 RID: 52724
	public EDynamicFlowType? Type;

	// Token: 0x0400CDF5 RID: 52725
	public Action Callback;
}
