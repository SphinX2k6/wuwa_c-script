using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008E9 RID: 2281
	public class NoiseRemovalComponent_SetValue
	{
		// Token: 0x040020BA RID: 8378
		public bool? Disabled;

		// Token: 0x040020BB RID: 8379
		public bool? EdIsLocked;

		// Token: 0x040020BC RID: 8380
		public List<INoiseRemovalNode> Nodes;

		// Token: 0x040020BD RID: 8381
		public string CompleteState;

		// Token: 0x040020BE RID: 8382
		[Nullable(2)]
		public INoiseRemovalBoarderBase NoiseRemovalBoarder;

		// Token: 0x040020BF RID: 8383
		public int? RotationAngle;
	}
}
