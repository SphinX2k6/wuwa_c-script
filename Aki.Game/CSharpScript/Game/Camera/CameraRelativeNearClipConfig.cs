using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072BD RID: 29373
	public class CameraRelativeNearClipConfig : CameraBaseNearClipConfig
	{
		// Token: 0x0604810B RID: 295179 RVA: 0x0127A6D1 File Offset: 0x012788D1
		public CameraRelativeNearClipConfig(ECameraRelativeNearClipTargetType targetType, float distance) : base(ECameraNearClipType.Relative)
		{
		}

		// Token: 0x04026059 RID: 155737
		public readonly ECameraRelativeNearClipTargetType TargetType = targetType;

		// Token: 0x0402605A RID: 155738
		public readonly float Distance = distance;
	}
}
