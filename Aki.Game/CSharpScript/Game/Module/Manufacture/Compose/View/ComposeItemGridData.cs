using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02005669 RID: 22121
	public class ComposeItemGridData
	{
		// Token: 0x0401D962 RID: 121186
		[Nullable(1)]
		public IBaseItemData ItemData;

		// Token: 0x0401D963 RID: 121187
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MediumItemGridExtendCallback> OnToggleStateChanged;

		// Token: 0x0401D964 RID: 121188
		[Nullable(2)]
		public Func<int, bool> IsSelectedProvider;
	}
}
