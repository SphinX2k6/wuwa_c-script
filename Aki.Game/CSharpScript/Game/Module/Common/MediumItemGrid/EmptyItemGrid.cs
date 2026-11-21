using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B34 RID: 19252
	[NullableContext(2)]
	[Nullable(0)]
	public class EmptyItemGrid : IMediumItemGridBase
	{
		// Token: 0x1700607D RID: 24701
		// (get) Token: 0x060302C4 RID: 197316 RVA: 0x00D6F236 File Offset: 0x00D6D436
		public EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.Empty;
			}
		}

		// Token: 0x04019837 RID: 104503
		public object Data;

		// Token: 0x04019838 RID: 104504
		public string BottomTextId;

		// Token: 0x04019839 RID: 104505
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] BottomTextParameter;

		// Token: 0x0401983A RID: 104506
		public string BottomText;
	}
}
