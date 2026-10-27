using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02007309 RID: 29449
	[NullableContext(1)]
	[Nullable(0)]
	public class VirtualPhotoCamera
	{
		// Token: 0x04026308 RID: 156424
		public readonly Vector Pivot = Vector.Create();

		// Token: 0x04026309 RID: 156425
		public readonly Vector CameraCenter = Vector.Create();

		// Token: 0x0402630A RID: 156426
		public readonly Vector MoveOffset = Vector.Create();

		// Token: 0x0402630B RID: 156427
		public readonly Rotator PivotRotation = Rotator.Create();

		// Token: 0x0402630C RID: 156428
		public readonly Vector PivotToCameraOffset = Vector.Create();

		// Token: 0x0402630D RID: 156429
		public float Fov;

		// Token: 0x0402630E RID: 156430
		public readonly Vector DesiredWorldLocation = Vector.Create();

		// Token: 0x0402630F RID: 156431
		public readonly Rotator DesiredWorldRotation = Rotator.Create();

		// Token: 0x04026310 RID: 156432
		public readonly Vector WorldLocation = Vector.Create();

		// Token: 0x04026311 RID: 156433
		public readonly Rotator WorldRotation = Rotator.Create();
	}
}
