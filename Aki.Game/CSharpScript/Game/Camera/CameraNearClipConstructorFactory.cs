using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006444 RID: 25668
	public static class CameraNearClipConstructorFactory
	{
		// Token: 0x0603E517 RID: 255255 RVA: 0x0121D1C1 File Offset: 0x0121B3C1
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
