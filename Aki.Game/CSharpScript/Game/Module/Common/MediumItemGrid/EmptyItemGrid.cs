using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B55 RID: 23381
	[NullableContext(2)]
	[Nullable(0)]
	public class EmptyItemGrid : IMediumItemGridBase
	{
		// Token: 0x17008CAB RID: 36011
		// (get) Token: 0x0603B378 RID: 242552 RVA: 0x00E1ECCA File Offset: 0x00E1CECA
		public EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.Empty;
			}
		}

		// Token: 0x0401ED8B RID: 126347
		public object Data;

		// Token: 0x0401ED8C RID: 126348
		public string BottomTextId;

		// Token: 0x0401ED8D RID: 126349
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] BottomTextParameter;

		// Token: 0x0401ED8E RID: 126350
		public string BottomText;
	}
}
