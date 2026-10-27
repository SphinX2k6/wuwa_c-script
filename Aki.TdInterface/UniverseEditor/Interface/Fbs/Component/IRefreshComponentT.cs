using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005818 RID: 22552
	public class IRefreshComponentT
	{
		// Token: 0x1700A878 RID: 43128
		// (get) Token: 0x06025EC2 RID: 155330 RVA: 0x0053ABCD File Offset: 0x00538DCD
		// (set) Token: 0x06025EC3 RID: 155331 RVA: 0x0053ABD5 File Offset: 0x00538DD5
		public bool Disabled { get; set; }

		// Token: 0x1700A879 RID: 43129
		// (get) Token: 0x06025EC4 RID: 155332 RVA: 0x0053ABDE File Offset: 0x00538DDE
		// (set) Token: 0x06025EC5 RID: 155333 RVA: 0x0053ABE6 File Offset: 0x00538DE6
		public TRefreshRuleUnion RefreshRule { get; set; }

		// Token: 0x1700A87A RID: 43130
		// (get) Token: 0x06025EC6 RID: 155334 RVA: 0x0053ABEF File Offset: 0x00538DEF
		// (set) Token: 0x06025EC7 RID: 155335 RVA: 0x0053ABF7 File Offset: 0x00538DF7
		public bool IsDisableRefreshAfterDroppingReward { get; set; }

		// Token: 0x1700A87B RID: 43131
		// (get) Token: 0x06025EC8 RID: 155336 RVA: 0x0053AC00 File Offset: 0x00538E00
		// (set) Token: 0x06025EC9 RID: 155337 RVA: 0x0053AC08 File Offset: 0x00538E08
		public bool IsResetOnDungeonRestart { get; set; }

		// Token: 0x1700A87C RID: 43132
		// (get) Token: 0x06025ECA RID: 155338 RVA: 0x0053AC11 File Offset: 0x00538E11
		// (set) Token: 0x06025ECB RID: 155339 RVA: 0x0053AC19 File Offset: 0x00538E19
		public byte NullMask { get; set; }

		// Token: 0x06025ECC RID: 155340 RVA: 0x0053AC22 File Offset: 0x00538E22
		public IRefreshComponentT()
		{
			this.Disabled = false;
			this.RefreshRule = null;
			this.IsDisableRefreshAfterDroppingReward = false;
			this.IsResetOnDungeonRestart = false;
			this.NullMask = 0;
		}
	}
}
