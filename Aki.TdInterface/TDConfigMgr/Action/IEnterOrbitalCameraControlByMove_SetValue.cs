using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A01 RID: 6657
	public class IEnterOrbitalCameraControlByMove_SetValue
	{
		// Token: 0x0400585C RID: 22620
		public EEnterOrbitalCameraType Type;

		// Token: 0x0400585D RID: 22621
		[Nullable(1)]
		public string LevelSequence;

		// Token: 0x0400585E RID: 22622
		public float BlendInTime;

		// Token: 0x0400585F RID: 22623
		public float BlendOutTime;

		// Token: 0x04005860 RID: 22624
		public int BegEntity;

		// Token: 0x04005861 RID: 22625
		public int EndEntity;
	}
}
