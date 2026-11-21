using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;

namespace CSharpScript.Game.Camera.CameraSubModeController
{
	// Token: 0x02006490 RID: 25744
	public class MovieCameraConfig
	{
		// Token: 0x0603E8CA RID: 256202 RVA: 0x0123633B File Offset: 0x0123453B
		[NullableContext(1)]
		public void Init(BP_MovieCameraConfig_C asset)
		{
			this.SmoothFactor = asset.ZSmoothFactor;
			this.SmoothDelta = asset.ZSmoothDelta;
		}

		// Token: 0x04021621 RID: 136737
		public float SmoothFactor = 10f;

		// Token: 0x04021622 RID: 136738
		public float SmoothDelta;
	}
}
