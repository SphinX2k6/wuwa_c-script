using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FC7 RID: 16327
	[NullableContext(1)]
	[Nullable(0)]
	internal class OptionReadGroup
	{
		// Token: 0x06029497 RID: 169111 RVA: 0x00B99464 File Offset: 0x00B97664
		public OptionReadGroup(ITalkItem talkItem, int talkItemIndex)
		{
			this.TalkItem = talkItem;
			this.TalkItemIndex = talkItemIndex;
		}

		// Token: 0x040167F9 RID: 92153
		public readonly List<int> OptionNodeIndices = new List<int>();

		// Token: 0x040167FA RID: 92154
		public readonly ITalkItem TalkItem;

		// Token: 0x040167FB RID: 92155
		public readonly int TalkItemIndex;
	}
}
