using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FFC RID: 20476
	internal class OptionReadNode
	{
		// Token: 0x0603460B RID: 214539 RVA: 0x00C4F3CF File Offset: 0x00C4D5CF
		public OptionReadNode(int talkItemId, int optionIndex)
		{
			this.TalkItemId = talkItemId;
			this.OptionIndex = optionIndex;
		}

		// Token: 0x0401BE19 RID: 114201
		[Nullable(1)]
		public readonly List<int> DependencyGroupIndices = new List<int>();

		// Token: 0x0401BE1A RID: 114202
		public readonly int TalkItemId;

		// Token: 0x0401BE1B RID: 114203
		public readonly int OptionIndex;
	}
}
