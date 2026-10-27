using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001C92 RID: 7314
[NullableContext(1)]
[Nullable(0)]
public class GachaResult
{
	// Token: 0x04006544 RID: 25924
	[Nullable(2)]
	public GachaReward Proto_GachaReward;

	// Token: 0x04006545 RID: 25925
	public IReadOnlyList<GachaReward> Proto_ExtraRewards = Array.Empty<GachaReward>();

	// Token: 0x04006546 RID: 25926
	public bool IsNew = true;

	// Token: 0x04006547 RID: 25927
	public IReadOnlyList<GachaReward> Proto_TransformRewards = Array.Empty<GachaReward>();

	// Token: 0x04006548 RID: 25928
	[Nullable(2)]
	public GachaReward Proto_BottomExtraReward;
}
