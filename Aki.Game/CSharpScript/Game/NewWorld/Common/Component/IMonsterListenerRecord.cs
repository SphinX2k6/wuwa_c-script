using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x020061FD RID: 25085
	internal class IMonsterListenerRecord
	{
		// Token: 0x0401FE7F RID: 130687
		public int EmotionId;

		// Token: 0x0401FE80 RID: 130688
		public bool Once;

		// Token: 0x0401FE81 RID: 130689
		[Nullable(1)]
		public HashSet<int> TagIds = new HashSet<int>();
	}
}
