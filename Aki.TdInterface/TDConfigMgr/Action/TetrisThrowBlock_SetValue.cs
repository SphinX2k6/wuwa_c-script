using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A9 RID: 9385
	public class TetrisThrowBlock_SetValue
	{
		// Token: 0x040078FF RID: 30975
		public string ShapeName;

		// Token: 0x04007900 RID: 30976
		public int PosIndex;

		// Token: 0x04007901 RID: 30977
		public int HeightIndex;

		// Token: 0x04007902 RID: 30978
		public ETetrisRotation Rotation;

		// Token: 0x04007903 RID: 30979
		public bool? IsDelayFall;

		// Token: 0x04007904 RID: 30980
		public int? FallSpeed;

		// Token: 0x04007905 RID: 30981
		public int? FallAcceleration;
	}
}
