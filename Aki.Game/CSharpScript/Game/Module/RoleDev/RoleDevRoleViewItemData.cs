using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CC7 RID: 19655
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevRoleViewItemData : IRoleDevRoleViewItemData
	{
		// Token: 0x17007D52 RID: 32082
		// (get) Token: 0x06032BED RID: 207853 RVA: 0x00BD5253 File Offset: 0x00BD3453
		// (set) Token: 0x06032BEE RID: 207854 RVA: 0x00BD525B File Offset: 0x00BD345B
		public int RoleId { get; set; }

		// Token: 0x17007D53 RID: 32083
		// (get) Token: 0x06032BEF RID: 207855 RVA: 0x00BD5264 File Offset: 0x00BD3464
		// (set) Token: 0x06032BF0 RID: 207856 RVA: 0x00BD526C File Offset: 0x00BD346C
		public int RoleLevel { get; set; }

		// Token: 0x17007D54 RID: 32084
		// (get) Token: 0x06032BF1 RID: 207857 RVA: 0x00BD5275 File Offset: 0x00BD3475
		// (set) Token: 0x06032BF2 RID: 207858 RVA: 0x00BD527D File Offset: 0x00BD347D
		public bool RoleLevelIsMax { get; set; }

		// Token: 0x17007D55 RID: 32085
		// (get) Token: 0x06032BF3 RID: 207859 RVA: 0x00BD5286 File Offset: 0x00BD3486
		// (set) Token: 0x06032BF4 RID: 207860 RVA: 0x00BD528E File Offset: 0x00BD348E
		public int BreachLevel { get; set; }

		// Token: 0x17007D56 RID: 32086
		// (get) Token: 0x06032BF5 RID: 207861 RVA: 0x00BD5297 File Offset: 0x00BD3497
		// (set) Token: 0x06032BF6 RID: 207862 RVA: 0x00BD529F File Offset: 0x00BD349F
		public int RoleGoalUpgradeLevel { get; set; }

		// Token: 0x17007D57 RID: 32087
		// (get) Token: 0x06032BF7 RID: 207863 RVA: 0x00BD52A8 File Offset: 0x00BD34A8
		// (set) Token: 0x06032BF8 RID: 207864 RVA: 0x00BD52B0 File Offset: 0x00BD34B0
		public int RoleGoalBreakLevel { get; set; }

		// Token: 0x17007D58 RID: 32088
		// (get) Token: 0x06032BF9 RID: 207865 RVA: 0x00BD52B9 File Offset: 0x00BD34B9
		// (set) Token: 0x06032BFA RID: 207866 RVA: 0x00BD52C1 File Offset: 0x00BD34C1
		public string RoleName { get; set; }

		// Token: 0x17007D59 RID: 32089
		// (get) Token: 0x06032BFB RID: 207867 RVA: 0x00BD52CA File Offset: 0x00BD34CA
		// (set) Token: 0x06032BFC RID: 207868 RVA: 0x00BD52D2 File Offset: 0x00BD34D2
		public int GachaId { get; set; }

		// Token: 0x17007D5A RID: 32090
		// (get) Token: 0x06032BFD RID: 207869 RVA: 0x00BD52DB File Offset: 0x00BD34DB
		// (set) Token: 0x06032BFE RID: 207870 RVA: 0x00BD52E3 File Offset: 0x00BD34E3
		public bool IsForecast { get; set; }

		// Token: 0x17007D5B RID: 32091
		// (get) Token: 0x06032BFF RID: 207871 RVA: 0x00BD52EC File Offset: 0x00BD34EC
		// (set) Token: 0x06032C00 RID: 207872 RVA: 0x00BD52F4 File Offset: 0x00BD34F4
		public bool IsCall { get; set; }

		// Token: 0x17007D5C RID: 32092
		// (get) Token: 0x06032C01 RID: 207873 RVA: 0x00BD52FD File Offset: 0x00BD34FD
		// (set) Token: 0x06032C02 RID: 207874 RVA: 0x00BD5305 File Offset: 0x00BD3505
		public bool IsCanUpgrade { get; set; }

		// Token: 0x17007D5D RID: 32093
		// (get) Token: 0x06032C03 RID: 207875 RVA: 0x00BD530E File Offset: 0x00BD350E
		// (set) Token: 0x06032C04 RID: 207876 RVA: 0x00BD5316 File Offset: 0x00BD3516
		public bool IsCanBreach { get; set; }

		// Token: 0x17007D5E RID: 32094
		// (get) Token: 0x06032C05 RID: 207877 RVA: 0x00BD531F File Offset: 0x00BD351F
		// (set) Token: 0x06032C06 RID: 207878 RVA: 0x00BD5327 File Offset: 0x00BD3527
		public bool IsCanShowUpgradeItem { get; set; }

		// Token: 0x17007D5F RID: 32095
		// (get) Token: 0x06032C07 RID: 207879 RVA: 0x00BD5330 File Offset: 0x00BD3530
		// (set) Token: 0x06032C08 RID: 207880 RVA: 0x00BD5338 File Offset: 0x00BD3538
		public bool IsCanShowBreachItem { get; set; }

		// Token: 0x17007D60 RID: 32096
		// (get) Token: 0x06032C09 RID: 207881 RVA: 0x00BD5341 File Offset: 0x00BD3541
		// (set) Token: 0x06032C0A RID: 207882 RVA: 0x00BD5349 File Offset: 0x00BD3549
		public bool IsFinish { get; set; }

		// Token: 0x17007D61 RID: 32097
		// (get) Token: 0x06032C0B RID: 207883 RVA: 0x00BD5352 File Offset: 0x00BD3552
		// (set) Token: 0x06032C0C RID: 207884 RVA: 0x00BD535A File Offset: 0x00BD355A
		public bool IsAllMaterialEnough { get; set; }

		// Token: 0x17007D62 RID: 32098
		// (get) Token: 0x06032C0D RID: 207885 RVA: 0x00BD5363 File Offset: 0x00BD3563
		// (set) Token: 0x06032C0E RID: 207886 RVA: 0x00BD536B File Offset: 0x00BD356B
		public List<IRoleDevDetailItemData> DetailItems { get; set; }
	}
}
