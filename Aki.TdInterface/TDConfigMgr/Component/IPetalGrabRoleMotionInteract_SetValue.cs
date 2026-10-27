using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F7 RID: 1527
	public class IPetalGrabRoleMotionInteract_SetValue
	{
		// Token: 0x040016C0 RID: 5824
		public ERoleMotionInteractType Type;

		// Token: 0x040016C1 RID: 5825
		public EPetalGrabHandType HandOption;

		// Token: 0x040016C2 RID: 5826
		[Nullable(2)]
		public PosAndRot GrabPointOffset;

		// Token: 0x040016C3 RID: 5827
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IPetalGrabEvent> GrabEvents;

		// Token: 0x040016C4 RID: 5828
		public int? NextPointEntityId;
	}
}
