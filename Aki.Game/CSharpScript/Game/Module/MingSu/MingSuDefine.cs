using System;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020043B1 RID: 17329
	public static class MingSuDefine
	{
		// Token: 0x040179A6 RID: 96678
		public const int EXP_BAR_ANIMATION_TIME = 1200;

		// Token: 0x040179A7 RID: 96679
		public const int MING_SU_ITEM_CONFIG_ID = 40040001;

		// Token: 0x040179A8 RID: 96680
		public const int MING_SU_POOL_CONFIG_ID = 1;

		// Token: 0x040179A9 RID: 96681
		public const int CHENG_XIAO_SHAN_POOL_CONFIG_ID = 2;

		// Token: 0x040179AA RID: 96682
		public const int DARK_COAST_POOL_CONFIG_ID = 3;

		// Token: 0x040179AB RID: 96683
		public const int PUPU_VILLAGE_POOL_CONFIG_ID = 4;

		// Token: 0x040179AC RID: 96684
		public const int PUPU_VILLAGE_QIQIU_POOL_CONFIG_ID = 5;

		// Token: 0x040179AD RID: 96685
		public const int LAHAILUOSHENGXIA_POOL_CONFIG_ID = 6;

		// Token: 0x040179AE RID: 96686
		public const int RILINGCOLLECT_POOL_CONFIG_ID = 7;

		// Token: 0x040179AF RID: 96687
		public const int MENGZHOU_POOL_CONFIG_ID = 8;

		// Token: 0x040179B0 RID: 96688
		public const int PLOTPARAM_NUM = 3;

		// Token: 0x040179B1 RID: 96689
		public const int DARK_COAST_HELP_ID = 113;

		// Token: 0x0200A0AF RID: 41135
		public enum EMingSuShowState
		{
			// Token: 0x04031EA8 RID: 204456
			Done,
			// Token: 0x04031EA9 RID: 204457
			OnGoing,
			// Token: 0x04031EAA RID: 204458
			NoStart,
			// Token: 0x04031EAB RID: 204459
			Finish
		}

		// Token: 0x0200A0B0 RID: 41136
		public enum EDragonPoolStatus
		{
			// Token: 0x04031EAD RID: 204461
			UnActive,
			// Token: 0x04031EAE RID: 204462
			OnGoing,
			// Token: 0x04031EAF RID: 204463
			Finish
		}

		// Token: 0x0200A0B1 RID: 41137
		public enum EDarkCoastDeliveryLevelDataState
		{
			// Token: 0x04031EB1 RID: 204465
			Lock,
			// Token: 0x04031EB2 RID: 204466
			UnLock,
			// Token: 0x04031EB3 RID: 204467
			Passed = 3,
			// Token: 0x04031EB4 RID: 204468
			Received
		}
	}
}
