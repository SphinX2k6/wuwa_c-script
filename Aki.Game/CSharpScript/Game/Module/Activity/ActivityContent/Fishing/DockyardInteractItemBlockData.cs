using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065A8 RID: 26024
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractItemBlockData
	{
		// Token: 0x060413FF RID: 267263 RVA: 0x00FCFA70 File Offset: 0x00FCDC70
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

		// Token: 0x04021F7E RID: 139134
		public int Rotate;

		// Token: 0x04021F7F RID: 139135
		public IPanelPos Pos;

		// Token: 0x04021F80 RID: 139136
		public DockyardItemBlockOriginalData Data;
	}
}
