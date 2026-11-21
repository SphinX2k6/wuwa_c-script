using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x020047F6 RID: 18422
	internal class ItemSelectRewardItemData
	{
		// Token: 0x04018A3C RID: 100924
		public int Index;

		// Token: 0x04018A3D RID: 100925
		public int ItemId;

		// Token: 0x04018A3E RID: 100926
		public bool SelectState;

		// Token: 0x04018A3F RID: 100927
		[Nullable(2)]
		public ResonantChainOptionLimitInfo LimitInfo;

		// Token: 0x04018A40 RID: 100928
		[Nullable(1)]
		public Action<int> OnClickToggleCallBack = delegate(int _)
		{
		};
	}
}
