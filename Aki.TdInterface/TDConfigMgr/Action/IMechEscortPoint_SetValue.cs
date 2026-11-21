using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB2 RID: 7602
	public class IMechEscortPoint_SetValue
	{
		// Token: 0x0400620F RID: 25103
		public int SplinePointIndex;

		// Token: 0x04006210 RID: 25104
		public float ForwardOffset;

		// Token: 0x04006211 RID: 25105
		public float Radius;

		// Token: 0x04006212 RID: 25106
		public float Angle;

		// Token: 0x04006213 RID: 25107
		[Nullable(2)]
		public IEnterMovieCameraType MovieCamera;
	}
}
