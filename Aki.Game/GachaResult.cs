using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001151 RID: 4433
[NullableContext(1)]
[Nullable(0)]
public class GachaResult
{
	// Token: 0x04006616 RID: 26134
	[Nullable(2)]
	public GachaReward Proto_GachaReward;

	// Token: 0x04006617 RID: 26135
	public IReadOnlyList<GachaReward> Proto_ExtraRewards = Array.Empty<GachaReward>();

	// Token: 0x04006618 RID: 26136
	public bool IsNew = true;

	// Token: 0x04006619 RID: 26137
	public IReadOnlyList<GachaReward> Proto_TransformRewards = Array.Empty<GachaReward>();

	// Token: 0x0400661A RID: 26138
	[Nullable(2)]
	public GachaReward Proto_BottomExtraReward;
}
