using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006B8 RID: 1720
	[NullableContext(2)]
	[Nullable(0)]
	public class IPrefabCompTransform_SetValue
	{
		// Token: 0x04001943 RID: 6467
		[Nullable(0)]
		public string ReferenceActorKey;

		// Token: 0x04001944 RID: 6468
		public IPrefabCompTransformItem Location;

		// Token: 0x04001945 RID: 6469
		public IPrefabCompTransformItem Rotation;

		// Token: 0x04001946 RID: 6470
		public IPrefabCompTransformItem Scale;
	}
}
