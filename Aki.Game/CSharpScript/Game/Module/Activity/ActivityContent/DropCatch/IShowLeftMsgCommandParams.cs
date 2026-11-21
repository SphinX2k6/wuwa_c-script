using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055E9 RID: 21993
	public class IShowLeftMsgCommandParams
	{
		// Token: 0x0401CC19 RID: 117785
		public EDropCatchGameplayLeftMsgType Type;

		// Token: 0x0401CC1A RID: 117786
		[Nullable(2)]
		public string Icon;

		// Token: 0x0401CC1B RID: 117787
		[Nullable(1)]
		public string TextId;

		// Token: 0x0401CC1C RID: 117788
		public float? Duration;
	}
}
