using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006322 RID: 25378
	[NullableContext(1)]
	[Nullable(0)]
	public class HookPointInfo
	{
		// Token: 0x0603D6FB RID: 251643 RVA: 0x011C5324 File Offset: 0x011C3524
		public HookPointInfo(GrapplingHookPointComponent point, long portalPairId = 0L, bool portalA2B = true)
		{
			this.Point = point;
			this.PortalPairId = portalPairId;
			this.PortalA2B = portalA2B;
		}

		// Token: 0x04020961 RID: 133473
		public GrapplingHookPointComponent Point;

		// Token: 0x04020962 RID: 133474
		public long PortalPairId;

		// Token: 0x04020963 RID: 133475
		public bool PortalA2B = true;
	}
}
