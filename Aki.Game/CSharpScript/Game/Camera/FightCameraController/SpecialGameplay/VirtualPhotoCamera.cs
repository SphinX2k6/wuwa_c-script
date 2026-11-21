using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x0200648C RID: 25740
	[NullableContext(1)]
	[Nullable(0)]
	public class VirtualPhotoCamera
	{
		// Token: 0x040215F5 RID: 136693
		public readonly Vector Pivot = Vector.Create();

		// Token: 0x040215F6 RID: 136694
		public readonly Vector CameraCenter = Vector.Create();

		// Token: 0x040215F7 RID: 136695
		public readonly Vector MoveOffset = Vector.Create();

		// Token: 0x040215F8 RID: 136696
		public readonly Rotator PivotRotation = Rotator.Create();

		// Token: 0x040215F9 RID: 136697
		public readonly Vector PivotToCameraOffset = Vector.Create();

		// Token: 0x040215FA RID: 136698
		public float Fov;

		// Token: 0x040215FB RID: 136699
		public readonly Vector DesiredWorldLocation = Vector.Create();

		// Token: 0x040215FC RID: 136700
		public readonly Rotator DesiredWorldRotation = Rotator.Create();

		// Token: 0x040215FD RID: 136701
		public readonly Vector WorldLocation = Vector.Create();

		// Token: 0x040215FE RID: 136702
		public readonly Rotator WorldRotation = Rotator.Create();
	}
}
