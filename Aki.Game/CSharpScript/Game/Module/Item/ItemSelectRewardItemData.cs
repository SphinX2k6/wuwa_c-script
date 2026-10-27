using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x0200581F RID: 22559
	internal class ItemSelectRewardItemData
	{
		// Token: 0x0401DFA5 RID: 122789
		public int Index;

		// Token: 0x0401DFA6 RID: 122790
		public int ItemId;

		// Token: 0x0401DFA7 RID: 122791
		public bool SelectState;

		// Token: 0x0401DFA8 RID: 122792
		[Nullable(2)]
		public ResonantChainOptionLimitInfo LimitInfo;

		// Token: 0x0401DFA9 RID: 122793
		[Nullable(1)]
		public Action<int> OnClickToggleCallBack = delegate(int _)
		{
		};
	}
}
