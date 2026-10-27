using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004551 RID: 17745
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalPlatformCaptureConfig
	{
		// Token: 0x0602DD8C RID: 187788 RVA: 0x00A8A741 File Offset: 0x00A88941
		public PortalPlatformCaptureConfig(Dictionary<EPortalCaptureLevel, FSceneCaptureComponent2DParams> captureParams, Dictionary<EPortalCaptureLevel, double> levelMinDist)
		{
		}

		// Token: 0x040187B3 RID: 100275
		public Dictionary<EPortalCaptureLevel, FSceneCaptureComponent2DParams> CaptureParams = captureParams;

		// Token: 0x040187B4 RID: 100276
		public Dictionary<EPortalCaptureLevel, double> LevelMinDist = levelMinDist;
	}
}
