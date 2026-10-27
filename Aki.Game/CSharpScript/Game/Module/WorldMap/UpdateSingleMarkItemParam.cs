using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x02004797 RID: 18327
	[NullableContext(1)]
	[Nullable(0)]
	public class UpdateSingleMarkItemParam
	{
		// Token: 0x04019DE3 RID: 105955
		public Vector2D MapUiPosition;

		// Token: 0x04019DE4 RID: 105956
		public float MapScale;

		// Token: 0x04019DE5 RID: 105957
		public Vector PlayerWorldPosition;

		// Token: 0x04019DE6 RID: 105958
		public bool IsDragging;

		// Token: 0x04019DE7 RID: 105959
		public bool IsScaleDirty;

		// Token: 0x04019DE8 RID: 105960
		public bool ForceViewUpdate;
	}
}
