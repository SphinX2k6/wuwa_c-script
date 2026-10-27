using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02006699 RID: 26265
	public class IShowLeftMsgCommandParams
	{
		// Token: 0x040223C0 RID: 140224
		public EDropCatchGameplayLeftMsgType Type;

		// Token: 0x040223C1 RID: 140225
		[Nullable(2)]
		public string Icon;

		// Token: 0x040223C2 RID: 140226
		[Nullable(1)]
		public string TextId;

		// Token: 0x040223C3 RID: 140227
		public float? Duration;
	}
}
