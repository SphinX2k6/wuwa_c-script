using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D21 RID: 19745
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopPhantomVisionSuitItemData : IRoleDevelopPhantomVisionSuitItemData
	{
		// Token: 0x17007E25 RID: 32293
		// (get) Token: 0x06033052 RID: 208978 RVA: 0x00BE1CA0 File Offset: 0x00BDFEA0
		// (set) Token: 0x06033053 RID: 208979 RVA: 0x00BE1CA8 File Offset: 0x00BDFEA8
		public string Name { get; set; }

		// Token: 0x17007E26 RID: 32294
		// (get) Token: 0x06033054 RID: 208980 RVA: 0x00BE1CB1 File Offset: 0x00BDFEB1
		// (set) Token: 0x06033055 RID: 208981 RVA: 0x00BE1CB9 File Offset: 0x00BDFEB9
		public string ButtonName { get; set; }

		// Token: 0x17007E27 RID: 32295
		// (get) Token: 0x06033056 RID: 208982 RVA: 0x00BE1CC2 File Offset: 0x00BDFEC2
		// (set) Token: 0x06033057 RID: 208983 RVA: 0x00BE1CCA File Offset: 0x00BDFECA
		public EPhantomSuitItemType ItemType { get; set; }

		// Token: 0x17007E28 RID: 32296
		// (get) Token: 0x06033058 RID: 208984 RVA: 0x00BE1CD3 File Offset: 0x00BDFED3
		// (set) Token: 0x06033059 RID: 208985 RVA: 0x00BE1CDB File Offset: 0x00BDFEDB
		public string TypeIcon { get; set; }

		// Token: 0x17007E29 RID: 32297
		// (get) Token: 0x0603305A RID: 208986 RVA: 0x00BE1CE4 File Offset: 0x00BDFEE4
		// (set) Token: 0x0603305B RID: 208987 RVA: 0x00BE1CEC File Offset: 0x00BDFEEC
		public List<PhantomMonsterItemData> MonsterDataList { get; set; }

		// Token: 0x17007E2A RID: 32298
		// (get) Token: 0x0603305C RID: 208988 RVA: 0x00BE1CF5 File Offset: 0x00BDFEF5
		// (set) Token: 0x0603305D RID: 208989 RVA: 0x00BE1CFD File Offset: 0x00BDFEFD
		public List<DropRewardItemData> RewardDataList { get; set; }

		// Token: 0x17007E2B RID: 32299
		// (get) Token: 0x0603305E RID: 208990 RVA: 0x00BE1D06 File Offset: 0x00BDFF06
		// (set) Token: 0x0603305F RID: 208991 RVA: 0x00BE1D0E File Offset: 0x00BDFF0E
		public int DungeonId { get; set; }

		// Token: 0x17007E2C RID: 32300
		// (get) Token: 0x06033060 RID: 208992 RVA: 0x00BE1D17 File Offset: 0x00BDFF17
		// (set) Token: 0x06033061 RID: 208993 RVA: 0x00BE1D1F File Offset: 0x00BDFF1F
		public int FetterGroupId { get; set; }

		// Token: 0x17007E2D RID: 32301
		// (get) Token: 0x06033062 RID: 208994 RVA: 0x00BE1D28 File Offset: 0x00BDFF28
		// (set) Token: 0x06033063 RID: 208995 RVA: 0x00BE1D30 File Offset: 0x00BDFF30
		public int RoleId { get; set; }

		// Token: 0x17007E2E RID: 32302
		// (get) Token: 0x06033064 RID: 208996 RVA: 0x00BE1D39 File Offset: 0x00BDFF39
		// (set) Token: 0x06033065 RID: 208997 RVA: 0x00BE1D41 File Offset: 0x00BDFF41
		public int? LogRoleId { get; set; }

		// Token: 0x17007E2F RID: 32303
		// (get) Token: 0x06033066 RID: 208998 RVA: 0x00BE1D4A File Offset: 0x00BDFF4A
		// (set) Token: 0x06033067 RID: 208999 RVA: 0x00BE1D52 File Offset: 0x00BDFF52
		public ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x17007E30 RID: 32304
		// (get) Token: 0x06033068 RID: 209000 RVA: 0x00BE1D5B File Offset: 0x00BDFF5B
		// (set) Token: 0x06033069 RID: 209001 RVA: 0x00BE1D63 File Offset: 0x00BDFF63
		public ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}
