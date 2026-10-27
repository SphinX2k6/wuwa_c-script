using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200223E RID: 8766
	public class TetrisThrowBlock_SetValue
	{
		// Token: 0x040072B5 RID: 29365
		[Nullable(1)]
		public string ShapeName;

		// Token: 0x040072B6 RID: 29366
		public int PosIndex;

		// Token: 0x040072B7 RID: 29367
		public int HeightIndex;

		// Token: 0x040072B8 RID: 29368
		public ETetrisRotation Rotation;

		// Token: 0x040072B9 RID: 29369
		public bool? IsDelayFall;

		// Token: 0x040072BA RID: 29370
		public int? FallSpeed;

		// Token: 0x040072BB RID: 29371
		public int? FallAcceleration;
	}
}
