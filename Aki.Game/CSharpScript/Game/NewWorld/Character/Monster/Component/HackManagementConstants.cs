using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Monster.Component
{
	// Token: 0x020070A1 RID: 28833
	public static class HackManagementConstants
	{
		// Token: 0x04024D04 RID: 150788
		public static readonly int NUM_TAG_ID = GameplayTagDefine.EGameplayTagId["辅助机.骇入型.骇入可用次数"];

		// Token: 0x04024D05 RID: 150789
		public static readonly int NUM_IS_EMPTY_TAG_ID = GameplayTagDefine.EGameplayTagId["辅助机.骇入型.骇入已满"];

		// Token: 0x04024D06 RID: 150790
		public static readonly int HACKING_TAG_ID = GameplayTagDefine.EGameplayTagId["辅助机.骇入型.骇入中"];

		// Token: 0x04024D07 RID: 150791
		[Nullable(1)]
		public const string TIP_TEXT_ID = "ClientErrorCode_0_Text";

		// Token: 0x04024D08 RID: 150792
		public const int SHOW_TIP_INTERVAL = 1000;
	}
}
