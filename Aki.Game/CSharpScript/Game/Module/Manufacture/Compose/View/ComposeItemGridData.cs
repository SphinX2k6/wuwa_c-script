using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x0200463F RID: 17983
	public class ComposeItemGridData
	{
		// Token: 0x040183ED RID: 99309
		[Nullable(1)]
		public IBaseItemData ItemData;

		// Token: 0x040183EE RID: 99310
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MediumItemGridExtendCallback> OnToggleStateChanged;

		// Token: 0x040183EF RID: 99311
		[Nullable(2)]
		public Func<int, bool> IsSelectedProvider;
	}
}
