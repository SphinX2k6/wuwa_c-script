using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CCC RID: 15564
	[NullableContext(1)]
	public interface IRoleDevelopSettlementJumpData
	{
		// Token: 0x1700519D RID: 20893
		// (get) Token: 0x06027DC7 RID: 163271
		// (set) Token: 0x06027DC8 RID: 163272
		bool CanShow { get; set; }

		// Token: 0x1700519E RID: 20894
		// (get) Token: 0x06027DC9 RID: 163273
		// (set) Token: 0x06027DCA RID: 163274
		int RoleId { get; set; }

		// Token: 0x1700519F RID: 20895
		// (get) Token: 0x06027DCB RID: 163275
		// (set) Token: 0x06027DCC RID: 163276
		string RoleIconPath { get; set; }

		// Token: 0x170051A0 RID: 20896
		// (get) Token: 0x06027DCD RID: 163277
		// (set) Token: 0x06027DCE RID: 163278
		List<int> MatchedItemIds { get; set; }

		// Token: 0x170051A1 RID: 20897
		// (get) Token: 0x06027DCF RID: 163279
		// (set) Token: 0x06027DD0 RID: 163280
		List<int> NeedCheckItemIds { get; set; }

		// Token: 0x170051A2 RID: 20898
		// (get) Token: 0x06027DD1 RID: 163281
		// (set) Token: 0x06027DD2 RID: 163282
		ERoleDevelopSettlementSourceDungeonType SourceDungeonType { get; set; }
	}
}
