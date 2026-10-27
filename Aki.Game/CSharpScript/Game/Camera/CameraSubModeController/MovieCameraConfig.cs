using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;

namespace CSharpScript.Game.Camera.CameraSubModeController
{
	// Token: 0x0200730D RID: 29453
	public class MovieCameraConfig
	{
		// Token: 0x0604847D RID: 296061 RVA: 0x012938BB File Offset: 0x01291ABB
		[NullableContext(1)]
		public void Init(BP_MovieCameraConfig_C asset)
		{
			this.SmoothFactor = asset.ZSmoothFactor;
			this.SmoothDelta = asset.ZSmoothDelta;
		}

		// Token: 0x04026334 RID: 156468
		public float SmoothFactor = 10f;

		// Token: 0x04026335 RID: 156469
		public float SmoothDelta;
	}
}
