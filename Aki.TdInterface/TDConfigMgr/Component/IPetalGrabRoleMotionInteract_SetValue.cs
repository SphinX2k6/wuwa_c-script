using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000694 RID: 1684
	[NullableContext(2)]
	[Nullable(0)]
	public class IPetalGrabRoleMotionInteract_SetValue
	{
		// Token: 0x040018B0 RID: 6320
		public ERoleMotionInteractType Type;

		// Token: 0x040018B1 RID: 6321
		public EPetalGrabHandType HandOption;

		// Token: 0x040018B2 RID: 6322
		public PosAndRot GrabPointOffset;

		// Token: 0x040018B3 RID: 6323
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IPetalGrabEvent> GrabEvents;

		// Token: 0x040018B4 RID: 6324
		public int? NextPointEntityId;

		// Token: 0x040018B5 RID: 6325
		public int? FlightSplineId;

		// Token: 0x040018B6 RID: 6326
		public ISplineMovePattern FlightSplineMovePattern;
	}
}
