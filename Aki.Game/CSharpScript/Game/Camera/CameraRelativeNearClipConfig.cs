using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200643F RID: 25663
	public class CameraRelativeNearClipConfig : CameraBaseNearClipConfig
	{
		// Token: 0x0603E4FF RID: 255231 RVA: 0x0121CA69 File Offset: 0x0121AC69
		public CameraRelativeNearClipConfig(ECameraRelativeNearClipTargetType targetType, float distance) : base(ECameraNearClipType.Relative)
		{
		}

		// Token: 0x04021339 RID: 135993
		public readonly ECameraRelativeNearClipTargetType TargetType = targetType;

		// Token: 0x0402133A RID: 135994
		public readonly float Distance = distance;
	}
}
