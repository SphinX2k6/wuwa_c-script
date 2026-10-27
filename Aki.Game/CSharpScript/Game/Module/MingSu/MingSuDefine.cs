using System;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053CE RID: 21454
	public static class MingSuDefine
	{
		// Token: 0x0401CF0E RID: 118542
		public const int EXP_BAR_ANIMATION_TIME = 1200;

		// Token: 0x0401CF0F RID: 118543
		public const int MING_SU_ITEM_CONFIG_ID = 40040001;

		// Token: 0x0401CF10 RID: 118544
		public const int MING_SU_POOL_CONFIG_ID = 1;

		// Token: 0x0401CF11 RID: 118545
		public const int CHENG_XIAO_SHAN_POOL_CONFIG_ID = 2;

		// Token: 0x0401CF12 RID: 118546
		public const int DARK_COAST_POOL_CONFIG_ID = 3;

		// Token: 0x0401CF13 RID: 118547
		public const int PUPU_VILLAGE_POOL_CONFIG_ID = 4;

		// Token: 0x0401CF14 RID: 118548
		public const int PUPU_VILLAGE_QIQIU_POOL_CONFIG_ID = 5;

		// Token: 0x0401CF15 RID: 118549
		public const int LAHAILUOSHENGXIA_POOL_CONFIG_ID = 6;

		// Token: 0x0401CF16 RID: 118550
		public const int RILINGCOLLECT_POOL_CONFIG_ID = 7;

		// Token: 0x0401CF17 RID: 118551
		public const int MENGZHOU_POOL_CONFIG_ID = 8;

		// Token: 0x0401CF18 RID: 118552
		public const int PLOTPARAM_NUM = 3;

		// Token: 0x0401CF19 RID: 118553
		public const int DARK_COAST_HELP_ID = 113;

		// Token: 0x0200B677 RID: 46711
		public enum EMingSuShowState
		{
			// Token: 0x04037453 RID: 226387
			Done,
			// Token: 0x04037454 RID: 226388
			OnGoing,
			// Token: 0x04037455 RID: 226389
			NoStart,
			// Token: 0x04037456 RID: 226390
			Finish
		}

		// Token: 0x0200B678 RID: 46712
		public enum EDragonPoolStatus
		{
			// Token: 0x04037458 RID: 226392
			UnActive,
			// Token: 0x04037459 RID: 226393
			OnGoing,
			// Token: 0x0403745A RID: 226394
			Finish
		}

		// Token: 0x0200B679 RID: 46713
		public enum EDarkCoastDeliveryLevelDataState
		{
			// Token: 0x0403745C RID: 226396
			Lock,
			// Token: 0x0403745D RID: 226397
			UnLock,
			// Token: 0x0403745E RID: 226398
			Passed = 3,
			// Token: 0x0403745F RID: 226399
			Received
		}
	}
}
