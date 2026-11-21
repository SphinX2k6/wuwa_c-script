using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F87 RID: 20359
	public interface ITotalTopUpPickRoleRewardItemData
	{
		// Token: 0x170063C6 RID: 25542
		// (get) Token: 0x060330FF RID: 209151
		// (set) Token: 0x06033100 RID: 209152
		int Index { get; set; }

		// Token: 0x170063C7 RID: 25543
		// (get) Token: 0x06033101 RID: 209153
		// (set) Token: 0x06033102 RID: 209154
		int RoleId { get; set; }

		// Token: 0x170063C8 RID: 25544
		// (get) Token: 0x06033103 RID: 209155
		// (set) Token: 0x06033104 RID: 209156
		int RoleChain { get; set; }

		// Token: 0x170063C9 RID: 25545
		// (get) Token: 0x06033105 RID: 209157
		// (set) Token: 0x06033106 RID: 209158
		bool RoleOwned { get; set; }

		// Token: 0x170063CA RID: 25546
		// (get) Token: 0x06033107 RID: 209159
		// (set) Token: 0x06033108 RID: 209160
		int ItemId { get; set; }

		// Token: 0x170063CB RID: 25547
		// (get) Token: 0x06033109 RID: 209161
		// (set) Token: 0x0603310A RID: 209162
		int ItemCount { get; set; }

		// Token: 0x170063CC RID: 25548
		// (get) Token: 0x0603310B RID: 209163
		// (set) Token: 0x0603310C RID: 209164
		bool CanClaim { get; set; }
	}
}
