using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200061B RID: 1563
	[NullableContext(2)]
	[Nullable(0)]
	public class IPrefabCompTransform_SetValue
	{
		// Token: 0x04001751 RID: 5969
		[Nullable(1)]
		public string ReferenceActorKey;

		// Token: 0x04001752 RID: 5970
		public IPrefabCompTransformItem Location;

		// Token: 0x04001753 RID: 5971
		public IPrefabCompTransformItem Rotation;

		// Token: 0x04001754 RID: 5972
		public IPrefabCompTransformItem Scale;
	}
}
