using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x02007235 RID: 29237
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalRenderCaptureParams
	{
		// Token: 0x06047A6E RID: 293486 RVA: 0x012556F1 File Offset: 0x012538F1
		public PortalRenderCaptureParams(USceneCaptureComponent2D capture, FTransformDouble sourcePortalWorld, FTransformDouble targetPortalWorld, FVector sourcePortalBounds)
		{
		}

		// Token: 0x04025B2C RID: 154412
		public USceneCaptureComponent2D Capture = capture;

		// Token: 0x04025B2D RID: 154413
		public FTransformDouble SourcePortalWorld = sourcePortalWorld;

		// Token: 0x04025B2E RID: 154414
		public FTransformDouble TargetPortalWorld = targetPortalWorld;

		// Token: 0x04025B2F RID: 154415
		public FVector SourcePortalBounds = sourcePortalBounds;
	}
}
