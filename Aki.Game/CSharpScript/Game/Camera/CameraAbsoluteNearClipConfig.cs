using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072BE RID: 29374
	public class CameraAbsoluteNearClipConfig : CameraBaseNearClipConfig
	{
		// Token: 0x0604810C RID: 295180 RVA: 0x0127A6E8 File Offset: 0x012788E8
		public CameraAbsoluteNearClipConfig(float distance) : base(ECameraNearClipType.Absolute)
		{
		}

		// Token: 0x0402605B RID: 155739
		public readonly float Distance = distance;
	}
}
