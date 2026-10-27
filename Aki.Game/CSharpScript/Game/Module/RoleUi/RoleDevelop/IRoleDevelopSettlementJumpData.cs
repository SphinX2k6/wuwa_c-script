using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D15 RID: 19733
	[NullableContext(1)]
	public interface IRoleDevelopSettlementJumpData
	{
		// Token: 0x17007DF3 RID: 32243
		// (get) Token: 0x06032FE9 RID: 208873
		// (set) Token: 0x06032FEA RID: 208874
		bool CanShow { get; set; }

		// Token: 0x17007DF4 RID: 32244
		// (get) Token: 0x06032FEB RID: 208875
		// (set) Token: 0x06032FEC RID: 208876
		int RoleId { get; set; }

		// Token: 0x17007DF5 RID: 32245
		// (get) Token: 0x06032FED RID: 208877
		// (set) Token: 0x06032FEE RID: 208878
		string RoleIconPath { get; set; }

		// Token: 0x17007DF6 RID: 32246
		// (get) Token: 0x06032FEF RID: 208879
		// (set) Token: 0x06032FF0 RID: 208880
		List<int> MatchedItemIds { get; set; }

		// Token: 0x17007DF7 RID: 32247
		// (get) Token: 0x06032FF1 RID: 208881
		// (set) Token: 0x06032FF2 RID: 208882
		List<int> NeedCheckItemIds { get; set; }

		// Token: 0x17007DF8 RID: 32248
		// (get) Token: 0x06032FF3 RID: 208883
		// (set) Token: 0x06032FF4 RID: 208884
		ERoleDevelopSettlementSourceDungeonType SourceDungeonType { get; set; }
	}
}
