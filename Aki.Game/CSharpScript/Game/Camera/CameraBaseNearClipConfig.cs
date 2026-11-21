using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200643D RID: 25661
	public abstract class CameraBaseNearClipConfig
	{
		// Token: 0x0603E4FE RID: 255230 RVA: 0x0121CA5A File Offset: 0x0121AC5A
		protected CameraBaseNearClipConfig(ECameraNearClipType nearClipType)
		{
		}

		// Token: 0x04021336 RID: 135990
		public readonly ECameraNearClipType NearClipType = nearClipType;
	}
}
