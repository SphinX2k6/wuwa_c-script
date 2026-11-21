using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FC6 RID: 16326
	internal class OptionReadNode
	{
		// Token: 0x06029496 RID: 169110 RVA: 0x00B99443 File Offset: 0x00B97643
		public OptionReadNode(int talkItemId, int optionIndex)
		{
			this.TalkItemId = talkItemId;
			this.OptionIndex = optionIndex;
		}

		// Token: 0x040167F6 RID: 92150
		[Nullable(1)]
		public readonly List<int> DependencyGroupIndices = new List<int>();

		// Token: 0x040167F7 RID: 92151
		public readonly int TalkItemId;

		// Token: 0x040167F8 RID: 92152
		public readonly int OptionIndex;
	}
}
