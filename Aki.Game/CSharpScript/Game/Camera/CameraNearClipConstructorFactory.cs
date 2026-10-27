using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072C2 RID: 29378
	public static class CameraNearClipConstructorFactory
	{
		// Token: 0x06048123 RID: 295203 RVA: 0x0127AE29 File Offset: 0x01279029
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static ICameraNearClipAction<CameraBaseNearClipConfig> Create(ECameraNearClipType type, int id, CameraBaseNearClipConfig config)
		{
			if (type == ECameraNearClipType.Relative)
			{
				return new CameraRelativeNearClipAction(id, (CameraRelativeNearClipConfig)config);
			}
			if (type == ECameraNearClipType.Absolute)
			{
				return new CameraAbsoluteNearClipAction(id, (CameraAbsoluteNearClipConfig)config);
			}
			return null;
		}
	}
}
