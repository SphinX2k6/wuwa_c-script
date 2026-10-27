using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FA0 RID: 24480
	public interface ITotalTopUpPickRoleRewardItemData
	{
		// Token: 0x17008FF4 RID: 36852
		// (get) Token: 0x0603E165 RID: 254309
		// (set) Token: 0x0603E166 RID: 254310
		int Index { get; set; }

		// Token: 0x17008FF5 RID: 36853
		// (get) Token: 0x0603E167 RID: 254311
		// (set) Token: 0x0603E168 RID: 254312
		int RoleId { get; set; }

		// Token: 0x17008FF6 RID: 36854
		// (get) Token: 0x0603E169 RID: 254313
		// (set) Token: 0x0603E16A RID: 254314
		int RoleChain { get; set; }

		// Token: 0x17008FF7 RID: 36855
		// (get) Token: 0x0603E16B RID: 254315
		// (set) Token: 0x0603E16C RID: 254316
		bool RoleOwned { get; set; }

		// Token: 0x17008FF8 RID: 36856
		// (get) Token: 0x0603E16D RID: 254317
		// (set) Token: 0x0603E16E RID: 254318
		int ItemId { get; set; }

		// Token: 0x17008FF9 RID: 36857
		// (get) Token: 0x0603E16F RID: 254319
		// (set) Token: 0x0603E170 RID: 254320
		int ItemCount { get; set; }

		// Token: 0x17008FFA RID: 36858
		// (get) Token: 0x0603E171 RID: 254321
		// (set) Token: 0x0603E172 RID: 254322
		bool CanClaim { get; set; }
	}
}
