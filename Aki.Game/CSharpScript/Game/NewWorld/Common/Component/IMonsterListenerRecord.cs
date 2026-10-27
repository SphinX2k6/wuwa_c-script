using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x0200707C RID: 28796
	internal class IMonsterListenerRecord
	{
		// Token: 0x04024BC4 RID: 150468
		public int EmotionId;

		// Token: 0x04024BC5 RID: 150469
		public bool Once;

		// Token: 0x04024BC6 RID: 150470
		[Nullable(1)]
		public HashSet<int> TagIds = new HashSet<int>();
	}
}
