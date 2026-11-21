using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x0200584C RID: 22604
	internal class BuffScrollItemData
	{
		// Token: 0x0401D6A1 RID: 120481
		public int BuffId;

		// Token: 0x0401D6A2 RID: 120482
		public bool ChangeAble = true;

		// Token: 0x0401D6A3 RID: 120483
		public BossRushBuffSelectionStatus State;

		// Token: 0x0401D6A4 RID: 120484
		public bool Selected;

		// Token: 0x0401D6A5 RID: 120485
		public bool SelectedAtStart;

		// Token: 0x0401D6A6 RID: 120486
		[Nullable(1)]
		public Action<BuffScrollItemData> OnClickToggle = delegate(BuffScrollItemData data)
		{
		};

		// Token: 0x0401D6A7 RID: 120487
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<BuffScrollItemData, bool> CheckClickAble;
	}
}
