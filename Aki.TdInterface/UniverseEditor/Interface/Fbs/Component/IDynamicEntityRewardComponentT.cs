using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005641 RID: 22081
	public class IDynamicEntityRewardComponentT
	{
		// Token: 0x17009EA1 RID: 40609
		// (get) Token: 0x0602347D RID: 144509 RVA: 0x004DACC4 File Offset: 0x004D8EC4
		// (set) Token: 0x0602347E RID: 144510 RVA: 0x004DACCC File Offset: 0x004D8ECC
		public bool Disabled { get; set; }

		// Token: 0x17009EA2 RID: 40610
		// (get) Token: 0x0602347F RID: 144511 RVA: 0x004DACD5 File Offset: 0x004D8ED5
		// (set) Token: 0x06023480 RID: 144512 RVA: 0x004DACDD File Offset: 0x004D8EDD
		public IDynamicTrafficRewardT RewardType { get; set; }

		// Token: 0x17009EA3 RID: 40611
		// (get) Token: 0x06023481 RID: 144513 RVA: 0x004DACE6 File Offset: 0x004D8EE6
		// (set) Token: 0x06023482 RID: 144514 RVA: 0x004DACEE File Offset: 0x004D8EEE
		public List<EClaimDynamicEntityRewardType> ClaimTypes { get; set; }

		// Token: 0x17009EA4 RID: 40612
		// (get) Token: 0x06023483 RID: 144515 RVA: 0x004DACF7 File Offset: 0x004D8EF7
		// (set) Token: 0x06023484 RID: 144516 RVA: 0x004DACFF File Offset: 0x004D8EFF
		public List<IActionInfoT> RewardActions { get; set; }

		// Token: 0x17009EA5 RID: 40613
		// (get) Token: 0x06023485 RID: 144517 RVA: 0x004DAD08 File Offset: 0x004D8F08
		// (set) Token: 0x06023486 RID: 144518 RVA: 0x004DAD10 File Offset: 0x004D8F10
		public byte NullMask { get; set; }

		// Token: 0x06023487 RID: 144519 RVA: 0x004DAD19 File Offset: 0x004D8F19
		public IDynamicEntityRewardComponentT()
		{
			this.Disabled = false;
			this.RewardType = null;
			this.ClaimTypes = null;
			this.RewardActions = null;
			this.NullMask = 0;
		}
	}
}
