using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CC6 RID: 19654
	[NullableContext(1)]
	public interface IRoleDevRoleViewItemData
	{
		// Token: 0x17007D41 RID: 32065
		// (get) Token: 0x06032BCB RID: 207819
		// (set) Token: 0x06032BCC RID: 207820
		int RoleId { get; set; }

		// Token: 0x17007D42 RID: 32066
		// (get) Token: 0x06032BCD RID: 207821
		// (set) Token: 0x06032BCE RID: 207822
		int RoleLevel { get; set; }

		// Token: 0x17007D43 RID: 32067
		// (get) Token: 0x06032BCF RID: 207823
		// (set) Token: 0x06032BD0 RID: 207824
		bool RoleLevelIsMax { get; set; }

		// Token: 0x17007D44 RID: 32068
		// (get) Token: 0x06032BD1 RID: 207825
		// (set) Token: 0x06032BD2 RID: 207826
		int BreachLevel { get; set; }

		// Token: 0x17007D45 RID: 32069
		// (get) Token: 0x06032BD3 RID: 207827
		// (set) Token: 0x06032BD4 RID: 207828
		int RoleGoalUpgradeLevel { get; set; }

		// Token: 0x17007D46 RID: 32070
		// (get) Token: 0x06032BD5 RID: 207829
		// (set) Token: 0x06032BD6 RID: 207830
		int RoleGoalBreakLevel { get; set; }

		// Token: 0x17007D47 RID: 32071
		// (get) Token: 0x06032BD7 RID: 207831
		// (set) Token: 0x06032BD8 RID: 207832
		string RoleName { get; set; }

		// Token: 0x17007D48 RID: 32072
		// (get) Token: 0x06032BD9 RID: 207833
		// (set) Token: 0x06032BDA RID: 207834
		int GachaId { get; set; }

		// Token: 0x17007D49 RID: 32073
		// (get) Token: 0x06032BDB RID: 207835
		// (set) Token: 0x06032BDC RID: 207836
		bool IsForecast { get; set; }

		// Token: 0x17007D4A RID: 32074
		// (get) Token: 0x06032BDD RID: 207837
		// (set) Token: 0x06032BDE RID: 207838
		bool IsCall { get; set; }

		// Token: 0x17007D4B RID: 32075
		// (get) Token: 0x06032BDF RID: 207839
		// (set) Token: 0x06032BE0 RID: 207840
		bool IsCanUpgrade { get; set; }

		// Token: 0x17007D4C RID: 32076
		// (get) Token: 0x06032BE1 RID: 207841
		// (set) Token: 0x06032BE2 RID: 207842
		bool IsCanBreach { get; set; }

		// Token: 0x17007D4D RID: 32077
		// (get) Token: 0x06032BE3 RID: 207843
		// (set) Token: 0x06032BE4 RID: 207844
		bool IsCanShowUpgradeItem { get; set; }

		// Token: 0x17007D4E RID: 32078
		// (get) Token: 0x06032BE5 RID: 207845
		// (set) Token: 0x06032BE6 RID: 207846
		bool IsCanShowBreachItem { get; set; }

		// Token: 0x17007D4F RID: 32079
		// (get) Token: 0x06032BE7 RID: 207847
		// (set) Token: 0x06032BE8 RID: 207848
		bool IsFinish { get; set; }

		// Token: 0x17007D50 RID: 32080
		// (get) Token: 0x06032BE9 RID: 207849
		// (set) Token: 0x06032BEA RID: 207850
		bool IsAllMaterialEnough { get; set; }

		// Token: 0x17007D51 RID: 32081
		// (get) Token: 0x06032BEB RID: 207851
		// (set) Token: 0x06032BEC RID: 207852
		List<IRoleDevDetailItemData> DetailItems { get; set; }
	}
}
