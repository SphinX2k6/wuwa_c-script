using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CE8 RID: 23784
	internal class NotifyData
	{
		// Token: 0x0401EBEC RID: 125932
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AiController> Entities;

		// Token: 0x0401EBED RID: 125933
		[Nullable(2)]
		public BaseActorComponent Target;
	}
}
