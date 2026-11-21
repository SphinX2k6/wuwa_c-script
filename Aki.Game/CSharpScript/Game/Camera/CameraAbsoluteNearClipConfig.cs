using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006440 RID: 25664
	public class CameraAbsoluteNearClipConfig : CameraBaseNearClipConfig
	{
		// Token: 0x0603E500 RID: 255232 RVA: 0x0121CA80 File Offset: 0x0121AC80
		public CameraAbsoluteNearClipConfig(float distance) : base(ECameraNearClipType.Absolute)
		{
		}

		// Token: 0x0402133B RID: 135995
		public readonly float Distance = distance;
	}
}
