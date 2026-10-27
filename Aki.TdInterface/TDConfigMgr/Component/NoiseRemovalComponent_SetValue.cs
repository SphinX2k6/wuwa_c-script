using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000846 RID: 2118
	[NullableContext(1)]
	[Nullable(0)]
	public class NoiseRemovalComponent_SetValue
	{
		// Token: 0x04001EAB RID: 7851
		public bool? Disabled;

		// Token: 0x04001EAC RID: 7852
		public bool? EdIsLocked;

		// Token: 0x04001EAD RID: 7853
		public List<INoiseRemovalNode> Nodes;

		// Token: 0x04001EAE RID: 7854
		public string CompleteState;

		// Token: 0x04001EAF RID: 7855
		[Nullable(2)]
		public INoiseRemovalBoarderBase NoiseRemovalBoarder;

		// Token: 0x04001EB0 RID: 7856
		public int? RotationAngle;
	}
}
