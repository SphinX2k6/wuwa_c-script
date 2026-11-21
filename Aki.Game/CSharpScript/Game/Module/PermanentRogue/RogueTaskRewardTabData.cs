using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042CA RID: 17098
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueTaskRewardTabData
	{
		// Token: 0x04017595 RID: 95637
		public string NameTextId;

		// Token: 0x04017596 RID: 95638
		public int Index = -1;

		// Token: 0x04017597 RID: 95639
		public Action<int> ClickedCallback;

		// Token: 0x04017598 RID: 95640
		public Func<int, bool> RefreshRedDot;
	}
}
