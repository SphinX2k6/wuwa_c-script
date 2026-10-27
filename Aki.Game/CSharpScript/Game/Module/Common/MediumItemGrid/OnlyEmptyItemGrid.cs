using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B56 RID: 23382
	public class OnlyEmptyItemGrid : IMediumItemGridBase
	{
		// Token: 0x17008CAC RID: 36012
		// (get) Token: 0x0603B37A RID: 242554 RVA: 0x00E1ECD5 File Offset: 0x00E1CED5
		public EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.OnlyEmpty;
			}
		}

		// Token: 0x0401ED8F RID: 126351
		[Nullable(2)]
		public Action OnClickedCallback;

		// Token: 0x0401ED90 RID: 126352
		public bool? IsClickable;

		// Token: 0x0401ED91 RID: 126353
		[Nullable(2)]
		public object Data;
	}
}
