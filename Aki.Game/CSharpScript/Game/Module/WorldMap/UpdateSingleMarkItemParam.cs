using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036C8 RID: 14024
	[NullableContext(1)]
	[Nullable(0)]
	public class UpdateSingleMarkItemParam
	{
		// Token: 0x04014493 RID: 83091
		public Vector2D MapUiPosition;

		// Token: 0x04014494 RID: 83092
		public float MapScale;

		// Token: 0x04014495 RID: 83093
		public Vector PlayerWorldPosition;

		// Token: 0x04014496 RID: 83094
		public bool IsDragging;

		// Token: 0x04014497 RID: 83095
		public bool IsScaleDirty;

		// Token: 0x04014498 RID: 83096
		public bool ForceViewUpdate;
	}
}
