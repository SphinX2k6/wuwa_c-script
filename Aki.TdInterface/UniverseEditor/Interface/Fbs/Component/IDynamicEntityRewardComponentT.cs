using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050DC RID: 20700
	public class IDynamicEntityRewardComponentT
	{
		// Token: 0x170096B4 RID: 38580
		// (get) Token: 0x06021529 RID: 136489 RVA: 0x004A0D38 File Offset: 0x0049EF38
		// (set) Token: 0x0602152A RID: 136490 RVA: 0x004A0D40 File Offset: 0x0049EF40
		public bool Disabled { get; set; }

		// Token: 0x170096B5 RID: 38581
		// (get) Token: 0x0602152B RID: 136491 RVA: 0x004A0D49 File Offset: 0x0049EF49
		// (set) Token: 0x0602152C RID: 136492 RVA: 0x004A0D51 File Offset: 0x0049EF51
		public IDynamicTrafficRewardT RewardType { get; set; }

		// Token: 0x170096B6 RID: 38582
		// (get) Token: 0x0602152D RID: 136493 RVA: 0x004A0D5A File Offset: 0x0049EF5A
		// (set) Token: 0x0602152E RID: 136494 RVA: 0x004A0D62 File Offset: 0x0049EF62
		public List<EClaimDynamicEntityRewardType> ClaimTypes { get; set; }

		// Token: 0x170096B7 RID: 38583
		// (get) Token: 0x0602152F RID: 136495 RVA: 0x004A0D6B File Offset: 0x0049EF6B
		// (set) Token: 0x06021530 RID: 136496 RVA: 0x004A0D73 File Offset: 0x0049EF73
		public List<IActionInfoT> RewardActions { get; set; }

		// Token: 0x170096B8 RID: 38584
		// (get) Token: 0x06021531 RID: 136497 RVA: 0x004A0D7C File Offset: 0x0049EF7C
		// (set) Token: 0x06021532 RID: 136498 RVA: 0x004A0D84 File Offset: 0x0049EF84
		public byte NullMask { get; set; }

		// Token: 0x06021533 RID: 136499 RVA: 0x004A0D8D File Offset: 0x0049EF8D
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
