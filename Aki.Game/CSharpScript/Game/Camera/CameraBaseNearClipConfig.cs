using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072BB RID: 29371
	public abstract class CameraBaseNearClipConfig
	{
		// Token: 0x0604810A RID: 295178 RVA: 0x0127A6C2 File Offset: 0x012788C2
		protected CameraBaseNearClipConfig(ECameraNearClipType nearClipType)
		{
		}

		// Token: 0x04026056 RID: 155734
		public readonly ECameraNearClipType NearClipType = nearClipType;
	}
}
