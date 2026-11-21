using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B35 RID: 19253
	public class OnlyEmptyItemGrid : IMediumItemGridBase
	{
		// Token: 0x1700607E RID: 24702
		// (get) Token: 0x060302C6 RID: 197318 RVA: 0x00D6F241 File Offset: 0x00D6D441
		public EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.OnlyEmpty;
			}
		}

		// Token: 0x0401983B RID: 104507
		[Nullable(2)]
		public Action OnClickedCallback;

		// Token: 0x0401983C RID: 104508
		public bool? IsClickable;

		// Token: 0x0401983D RID: 104509
		[Nullable(2)]
		public object Data;
	}
}
