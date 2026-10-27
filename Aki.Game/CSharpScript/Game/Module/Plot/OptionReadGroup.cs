using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FFD RID: 20477
	[NullableContext(1)]
	[Nullable(0)]
	internal class OptionReadGroup
	{
		// Token: 0x0603460C RID: 214540 RVA: 0x00C4F3F0 File Offset: 0x00C4D5F0
		public OptionReadGroup(ITalkItem talkItem, int talkItemIndex)
		{
			this.TalkItem = talkItem;
			this.TalkItemIndex = talkItemIndex;
		}

		// Token: 0x0401BE1C RID: 114204
		public readonly List<int> OptionNodeIndices = new List<int>();

		// Token: 0x0401BE1D RID: 114205
		public readonly ITalkItem TalkItem;

		// Token: 0x0401BE1E RID: 114206
		public readonly int TalkItemIndex;
	}
}
