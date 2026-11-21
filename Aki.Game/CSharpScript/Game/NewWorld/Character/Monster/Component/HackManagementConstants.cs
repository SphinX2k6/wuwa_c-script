using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Monster.Component
{
	// Token: 0x02006306 RID: 25350
	public static class HackManagementConstants
	{
		// Token: 0x04020856 RID: 133206
		public static readonly int NUM_TAG_ID = GameplayTagDefine.EGameplayTagId["辅助机.骇入型.骇入可用次数"];

		// Token: 0x04020857 RID: 133207
		public static readonly int NUM_IS_EMPTY_TAG_ID = GameplayTagDefine.EGameplayTagId["辅助机.骇入型.骇入已满"];

		// Token: 0x04020858 RID: 133208
		public static readonly int HACKING_TAG_ID = GameplayTagDefine.EGameplayTagId["辅助机.骇入型.骇入中"];

		// Token: 0x04020859 RID: 133209
		[Nullable(1)]
		public const string TIP_TEXT_ID = "ClientErrorCode_0_Text";

		// Token: 0x0402085A RID: 133210
		public const int SHOW_TIP_INTERVAL = 1000;
	}
}
