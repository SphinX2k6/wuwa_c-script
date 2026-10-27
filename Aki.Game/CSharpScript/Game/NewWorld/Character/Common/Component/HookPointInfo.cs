using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070BE RID: 28862
	[NullableContext(1)]
	[Nullable(0)]
	public class HookPointInfo
	{
		// Token: 0x0604661D RID: 288285 RVA: 0x011A5B94 File Offset: 0x011A3D94
		public HookPointInfo(GrapplingHookPointComponent point, long portalPairId = 0L, bool portalA2B = true)
		{
			this.Point = point;
			this.PortalPairId = portalPairId;
			this.PortalA2B = portalA2B;
		}

		// Token: 0x04024E23 RID: 151075
		public GrapplingHookPointComponent Point;

		// Token: 0x04024E24 RID: 151076
		public long PortalPairId;

		// Token: 0x04024E25 RID: 151077
		public bool PortalA2B = true;
	}
}
