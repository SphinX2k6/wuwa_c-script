using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C78 RID: 15480
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevRoleViewItemData : IRoleDevRoleViewItemData
	{
		// Token: 0x170050FC RID: 20732
		// (get) Token: 0x060279A1 RID: 162209 RVA: 0x00B19FEB File Offset: 0x00B181EB
		// (set) Token: 0x060279A2 RID: 162210 RVA: 0x00B19FF3 File Offset: 0x00B181F3
		public int RoleId { get; set; }

		// Token: 0x170050FD RID: 20733
		// (get) Token: 0x060279A3 RID: 162211 RVA: 0x00B19FFC File Offset: 0x00B181FC
		// (set) Token: 0x060279A4 RID: 162212 RVA: 0x00B1A004 File Offset: 0x00B18204
		public int RoleLevel { get; set; }

		// Token: 0x170050FE RID: 20734
		// (get) Token: 0x060279A5 RID: 162213 RVA: 0x00B1A00D File Offset: 0x00B1820D
		// (set) Token: 0x060279A6 RID: 162214 RVA: 0x00B1A015 File Offset: 0x00B18215
		public bool RoleLevelIsMax { get; set; }

		// Token: 0x170050FF RID: 20735
		// (get) Token: 0x060279A7 RID: 162215 RVA: 0x00B1A01E File Offset: 0x00B1821E
		// (set) Token: 0x060279A8 RID: 162216 RVA: 0x00B1A026 File Offset: 0x00B18226
		public int BreachLevel { get; set; }

		// Token: 0x17005100 RID: 20736
		// (get) Token: 0x060279A9 RID: 162217 RVA: 0x00B1A02F File Offset: 0x00B1822F
		// (set) Token: 0x060279AA RID: 162218 RVA: 0x00B1A037 File Offset: 0x00B18237
		public int RoleGoalUpgradeLevel { get; set; }

		// Token: 0x17005101 RID: 20737
		// (get) Token: 0x060279AB RID: 162219 RVA: 0x00B1A040 File Offset: 0x00B18240
		// (set) Token: 0x060279AC RID: 162220 RVA: 0x00B1A048 File Offset: 0x00B18248
		public int RoleGoalBreakLevel { get; set; }

		// Token: 0x17005102 RID: 20738
		// (get) Token: 0x060279AD RID: 162221 RVA: 0x00B1A051 File Offset: 0x00B18251
		// (set) Token: 0x060279AE RID: 162222 RVA: 0x00B1A059 File Offset: 0x00B18259
		public string RoleName { get; set; }

		// Token: 0x17005103 RID: 20739
		// (get) Token: 0x060279AF RID: 162223 RVA: 0x00B1A062 File Offset: 0x00B18262
		// (set) Token: 0x060279B0 RID: 162224 RVA: 0x00B1A06A File Offset: 0x00B1826A
		public int GachaId { get; set; }

		// Token: 0x17005104 RID: 20740
		// (get) Token: 0x060279B1 RID: 162225 RVA: 0x00B1A073 File Offset: 0x00B18273
		// (set) Token: 0x060279B2 RID: 162226 RVA: 0x00B1A07B File Offset: 0x00B1827B
		public bool IsForecast { get; set; }

		// Token: 0x17005105 RID: 20741
		// (get) Token: 0x060279B3 RID: 162227 RVA: 0x00B1A084 File Offset: 0x00B18284
		// (set) Token: 0x060279B4 RID: 162228 RVA: 0x00B1A08C File Offset: 0x00B1828C
		public bool IsCall { get; set; }

		// Token: 0x17005106 RID: 20742
		// (get) Token: 0x060279B5 RID: 162229 RVA: 0x00B1A095 File Offset: 0x00B18295
		// (set) Token: 0x060279B6 RID: 162230 RVA: 0x00B1A09D File Offset: 0x00B1829D
		public bool IsCanUpgrade { get; set; }

		// Token: 0x17005107 RID: 20743
		// (get) Token: 0x060279B7 RID: 162231 RVA: 0x00B1A0A6 File Offset: 0x00B182A6
		// (set) Token: 0x060279B8 RID: 162232 RVA: 0x00B1A0AE File Offset: 0x00B182AE
		public bool IsCanBreach { get; set; }

		// Token: 0x17005108 RID: 20744
		// (get) Token: 0x060279B9 RID: 162233 RVA: 0x00B1A0B7 File Offset: 0x00B182B7
		// (set) Token: 0x060279BA RID: 162234 RVA: 0x00B1A0BF File Offset: 0x00B182BF
		public bool IsCanShowUpgradeItem { get; set; }

		// Token: 0x17005109 RID: 20745
		// (get) Token: 0x060279BB RID: 162235 RVA: 0x00B1A0C8 File Offset: 0x00B182C8
		// (set) Token: 0x060279BC RID: 162236 RVA: 0x00B1A0D0 File Offset: 0x00B182D0
		public bool IsCanShowBreachItem { get; set; }

		// Token: 0x1700510A RID: 20746
		// (get) Token: 0x060279BD RID: 162237 RVA: 0x00B1A0D9 File Offset: 0x00B182D9
		// (set) Token: 0x060279BE RID: 162238 RVA: 0x00B1A0E1 File Offset: 0x00B182E1
		public bool IsFinish { get; set; }

		// Token: 0x1700510B RID: 20747
		// (get) Token: 0x060279BF RID: 162239 RVA: 0x00B1A0EA File Offset: 0x00B182EA
		// (set) Token: 0x060279C0 RID: 162240 RVA: 0x00B1A0F2 File Offset: 0x00B182F2
		public bool IsAllMaterialEnough { get; set; }

		// Token: 0x1700510C RID: 20748
		// (get) Token: 0x060279C1 RID: 162241 RVA: 0x00B1A0FB File Offset: 0x00B182FB
		// (set) Token: 0x060279C2 RID: 162242 RVA: 0x00B1A103 File Offset: 0x00B18303
		public List<IRoleDevDetailItemData> DetailItems { get; set; }
	}
}
