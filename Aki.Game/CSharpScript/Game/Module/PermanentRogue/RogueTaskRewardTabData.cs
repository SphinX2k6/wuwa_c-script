using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052FA RID: 21242
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueTaskRewardTabData
	{
		// Token: 0x0401CB5F RID: 117599
		public string NameTextId;

		// Token: 0x0401CB60 RID: 117600
		public int Index = -1;

		// Token: 0x0401CB61 RID: 117601
		public Action<int> ClickedCallback;

		// Token: 0x0401CB62 RID: 117602
		public Func<int, bool> RefreshRedDot;
	}
}
