using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C77 RID: 15479
	[NullableContext(1)]
	public interface IRoleDevRoleViewItemData
	{
		// Token: 0x170050EB RID: 20715
		// (get) Token: 0x0602797F RID: 162175
		// (set) Token: 0x06027980 RID: 162176
		int RoleId { get; set; }

		// Token: 0x170050EC RID: 20716
		// (get) Token: 0x06027981 RID: 162177
		// (set) Token: 0x06027982 RID: 162178
		int RoleLevel { get; set; }

		// Token: 0x170050ED RID: 20717
		// (get) Token: 0x06027983 RID: 162179
		// (set) Token: 0x06027984 RID: 162180
		bool RoleLevelIsMax { get; set; }

		// Token: 0x170050EE RID: 20718
		// (get) Token: 0x06027985 RID: 162181
		// (set) Token: 0x06027986 RID: 162182
		int BreachLevel { get; set; }

		// Token: 0x170050EF RID: 20719
		// (get) Token: 0x06027987 RID: 162183
		// (set) Token: 0x06027988 RID: 162184
		int RoleGoalUpgradeLevel { get; set; }

		// Token: 0x170050F0 RID: 20720
		// (get) Token: 0x06027989 RID: 162185
		// (set) Token: 0x0602798A RID: 162186
		int RoleGoalBreakLevel { get; set; }

		// Token: 0x170050F1 RID: 20721
		// (get) Token: 0x0602798B RID: 162187
		// (set) Token: 0x0602798C RID: 162188
		string RoleName { get; set; }

		// Token: 0x170050F2 RID: 20722
		// (get) Token: 0x0602798D RID: 162189
		// (set) Token: 0x0602798E RID: 162190
		int GachaId { get; set; }

		// Token: 0x170050F3 RID: 20723
		// (get) Token: 0x0602798F RID: 162191
		// (set) Token: 0x06027990 RID: 162192
		bool IsForecast { get; set; }

		// Token: 0x170050F4 RID: 20724
		// (get) Token: 0x06027991 RID: 162193
		// (set) Token: 0x06027992 RID: 162194
		bool IsCall { get; set; }

		// Token: 0x170050F5 RID: 20725
		// (get) Token: 0x06027993 RID: 162195
		// (set) Token: 0x06027994 RID: 162196
		bool IsCanUpgrade { get; set; }

		// Token: 0x170050F6 RID: 20726
		// (get) Token: 0x06027995 RID: 162197
		// (set) Token: 0x06027996 RID: 162198
		bool IsCanBreach { get; set; }

		// Token: 0x170050F7 RID: 20727
		// (get) Token: 0x06027997 RID: 162199
		// (set) Token: 0x06027998 RID: 162200
		bool IsCanShowUpgradeItem { get; set; }

		// Token: 0x170050F8 RID: 20728
		// (get) Token: 0x06027999 RID: 162201
		// (set) Token: 0x0602799A RID: 162202
		bool IsCanShowBreachItem { get; set; }

		// Token: 0x170050F9 RID: 20729
		// (get) Token: 0x0602799B RID: 162203
		// (set) Token: 0x0602799C RID: 162204
		bool IsFinish { get; set; }

		// Token: 0x170050FA RID: 20730
		// (get) Token: 0x0602799D RID: 162205
		// (set) Token: 0x0602799E RID: 162206
		bool IsAllMaterialEnough { get; set; }

		// Token: 0x170050FB RID: 20731
		// (get) Token: 0x0602799F RID: 162207
		// (set) Token: 0x060279A0 RID: 162208
		List<IRoleDevDetailItemData> DetailItems { get; set; }
	}
}
