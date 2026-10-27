using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BCB RID: 7115
	public class IMechEscortPoint_SetValue
	{
		// Token: 0x04005CFA RID: 23802
		public int SplinePointIndex;

		// Token: 0x04005CFB RID: 23803
		public float ForwardOffset;

		// Token: 0x04005CFC RID: 23804
		public float Radius;

		// Token: 0x04005CFD RID: 23805
		public float Angle;

		// Token: 0x04005CFE RID: 23806
		[Nullable(2)]
		public IEnterMovieCameraType MovieCamera;
	}
}
