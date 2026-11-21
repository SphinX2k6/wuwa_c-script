using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CCD RID: 15565
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopSettlementJumpData : IRoleDevelopSettlementJumpData
	{
		// Token: 0x170051A3 RID: 20899
		// (get) Token: 0x06027DD3 RID: 163283 RVA: 0x00B2746B File Offset: 0x00B2566B
		// (set) Token: 0x06027DD4 RID: 163284 RVA: 0x00B27473 File Offset: 0x00B25673
		public bool CanShow { get; set; }

		// Token: 0x170051A4 RID: 20900
		// (get) Token: 0x06027DD5 RID: 163285 RVA: 0x00B2747C File Offset: 0x00B2567C
		// (set) Token: 0x06027DD6 RID: 163286 RVA: 0x00B27484 File Offset: 0x00B25684
		public int RoleId { get; set; }

		// Token: 0x170051A5 RID: 20901
		// (get) Token: 0x06027DD7 RID: 163287 RVA: 0x00B2748D File Offset: 0x00B2568D
		// (set) Token: 0x06027DD8 RID: 163288 RVA: 0x00B27495 File Offset: 0x00B25695
		public string RoleIconPath { get; set; }

		// Token: 0x170051A6 RID: 20902
		// (get) Token: 0x06027DD9 RID: 163289 RVA: 0x00B2749E File Offset: 0x00B2569E
		// (set) Token: 0x06027DDA RID: 163290 RVA: 0x00B274A6 File Offset: 0x00B256A6
		public List<int> MatchedItemIds { get; set; }

		// Token: 0x170051A7 RID: 20903
		// (get) Token: 0x06027DDB RID: 163291 RVA: 0x00B274AF File Offset: 0x00B256AF
		// (set) Token: 0x06027DDC RID: 163292 RVA: 0x00B274B7 File Offset: 0x00B256B7
		public List<int> NeedCheckItemIds { get; set; }

		// Token: 0x170051A8 RID: 20904
		// (get) Token: 0x06027DDD RID: 163293 RVA: 0x00B274C0 File Offset: 0x00B256C0
		// (set) Token: 0x06027DDE RID: 163294 RVA: 0x00B274C8 File Offset: 0x00B256C8
		public ERoleDevelopSettlementSourceDungeonType SourceDungeonType { get; set; }
	}
}
