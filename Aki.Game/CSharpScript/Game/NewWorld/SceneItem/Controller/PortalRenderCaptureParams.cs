using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x020062EA RID: 25322
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalRenderCaptureParams
	{
		// Token: 0x0603D3CF RID: 250831 RVA: 0x011AE289 File Offset: 0x011AC489
		public PortalRenderCaptureParams(USceneCaptureComponent2D capture, FTransformDouble sourcePortalWorld, FTransformDouble targetPortalWorld, FVector sourcePortalBounds)
		{
		}

		// Token: 0x0402079B RID: 133019
		public USceneCaptureComponent2D Capture = capture;

		// Token: 0x0402079C RID: 133020
		public FTransformDouble SourcePortalWorld = sourcePortalWorld;

		// Token: 0x0402079D RID: 133021
		public FTransformDouble TargetPortalWorld = targetPortalWorld;

		// Token: 0x0402079E RID: 133022
		public FVector SourcePortalBounds = sourcePortalBounds;
	}
}
