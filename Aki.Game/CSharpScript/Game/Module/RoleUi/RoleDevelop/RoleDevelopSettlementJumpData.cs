using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D16 RID: 19734
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopSettlementJumpData : IRoleDevelopSettlementJumpData
	{
		// Token: 0x17007DF9 RID: 32249
		// (get) Token: 0x06032FF5 RID: 208885 RVA: 0x00BE1B35 File Offset: 0x00BDFD35
		// (set) Token: 0x06032FF6 RID: 208886 RVA: 0x00BE1B3D File Offset: 0x00BDFD3D
		public bool CanShow { get; set; }

		// Token: 0x17007DFA RID: 32250
		// (get) Token: 0x06032FF7 RID: 208887 RVA: 0x00BE1B46 File Offset: 0x00BDFD46
		// (set) Token: 0x06032FF8 RID: 208888 RVA: 0x00BE1B4E File Offset: 0x00BDFD4E
		public int RoleId { get; set; }

		// Token: 0x17007DFB RID: 32251
		// (get) Token: 0x06032FF9 RID: 208889 RVA: 0x00BE1B57 File Offset: 0x00BDFD57
		// (set) Token: 0x06032FFA RID: 208890 RVA: 0x00BE1B5F File Offset: 0x00BDFD5F
		public string RoleIconPath { get; set; }

		// Token: 0x17007DFC RID: 32252
		// (get) Token: 0x06032FFB RID: 208891 RVA: 0x00BE1B68 File Offset: 0x00BDFD68
		// (set) Token: 0x06032FFC RID: 208892 RVA: 0x00BE1B70 File Offset: 0x00BDFD70
		public List<int> MatchedItemIds { get; set; }

		// Token: 0x17007DFD RID: 32253
		// (get) Token: 0x06032FFD RID: 208893 RVA: 0x00BE1B79 File Offset: 0x00BDFD79
		// (set) Token: 0x06032FFE RID: 208894 RVA: 0x00BE1B81 File Offset: 0x00BDFD81
		public List<int> NeedCheckItemIds { get; set; }

		// Token: 0x17007DFE RID: 32254
		// (get) Token: 0x06032FFF RID: 208895 RVA: 0x00BE1B8A File Offset: 0x00BDFD8A
		// (set) Token: 0x06033000 RID: 208896 RVA: 0x00BE1B92 File Offset: 0x00BDFD92
		public ERoleDevelopSettlementSourceDungeonType SourceDungeonType { get; set; }
	}
}
