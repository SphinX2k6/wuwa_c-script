using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005526 RID: 21798
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractItemBlockData
	{
		// Token: 0x060360C4 RID: 221380 RVA: 0x00F16A74 File Offset: 0x00F14C74
		public DockyardInteractItemBlockData(DockyardItemBlockOriginalData data)
		{
			this.Rotate = 0;
			this.Pos = new PanelPos
			{
				RowIndex = -1,
				ColIndex = -1
			};
			this.Data = data;
		}

		// Token: 0x0401C8AF RID: 116911
		public int Rotate;

		// Token: 0x0401C8B0 RID: 116912
		public IPanelPos Pos;

		// Token: 0x0401C8B1 RID: 116913
		public DockyardItemBlockOriginalData Data;
	}
}
