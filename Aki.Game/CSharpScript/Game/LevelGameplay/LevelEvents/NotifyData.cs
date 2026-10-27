using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B70 RID: 27504
	internal class NotifyData
	{
		// Token: 0x0402394A RID: 145738
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AiController> Entities;

		// Token: 0x0402394B RID: 145739
		[Nullable(2)]
		public BaseActorComponent Target;
	}
}
