using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x020068FC RID: 26876
	internal class BuffScrollItemData
	{
		// Token: 0x04022E45 RID: 142917
		public int BuffId;

		// Token: 0x04022E46 RID: 142918
		public bool ChangeAble = true;

		// Token: 0x04022E47 RID: 142919
		public BossRushBuffSelectionStatus State;

		// Token: 0x04022E48 RID: 142920
		public bool Selected;

		// Token: 0x04022E49 RID: 142921
		public bool SelectedAtStart;

		// Token: 0x04022E4A RID: 142922
		[Nullable(1)]
		public Action<BuffScrollItemData> OnClickToggle = delegate(BuffScrollItemData data)
		{
		};

		// Token: 0x04022E4B RID: 142923
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<BuffScrollItemData, bool> CheckClickAble;
	}
}
