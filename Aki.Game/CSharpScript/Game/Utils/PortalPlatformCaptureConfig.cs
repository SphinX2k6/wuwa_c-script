using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02003479 RID: 13433
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalPlatformCaptureConfig
	{
		// Token: 0x0602246E RID: 140398 RVA: 0x009B5C71 File Offset: 0x009B3E71
		public PortalPlatformCaptureConfig(Dictionary<EPortalCaptureLevel, FSceneCaptureComponent2DParams> captureParams, Dictionary<EPortalCaptureLevel, double> levelMinDist)
		{
		}

		// Token: 0x04012DED RID: 77293
		public Dictionary<EPortalCaptureLevel, FSceneCaptureComponent2DParams> CaptureParams = captureParams;

		// Token: 0x04012DEE RID: 77294
		public Dictionary<EPortalCaptureLevel, double> LevelMinDist = levelMinDist;
	}
}
