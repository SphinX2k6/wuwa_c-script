using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072AF RID: 29359
	[NullableContext(2)]
	[Nullable(0)]
	public class SeqCameraThings
	{
		// Token: 0x04025FB0 RID: 155568
		public FVectorDouble CameraLocation = Vector.Create().ToUeVector(false);

		// Token: 0x04025FB1 RID: 155569
		public FRotator CameraRotation = Rotator.Create().ToUeRotator();

		// Token: 0x04025FB2 RID: 155570
		public FVectorDouble CameraScale = Vector.Create().ToUeVector(false);

		// Token: 0x04025FB3 RID: 155571
		public FTransformDouble? OriginRootTransform;

		// Token: 0x04025FB4 RID: 155572
		public bool ConstrainAspectRatio;

		// Token: 0x04025FB5 RID: 155573
		public float CurrentAperture;

		// Token: 0x04025FB6 RID: 155574
		public float CurrentFocalLength;

		// Token: 0x04025FB7 RID: 155575
		public FCameraFocusSettings FocusSettings;

		// Token: 0x04025FB8 RID: 155576
		public FCameraLensSettings LensSettings;

		// Token: 0x04025FB9 RID: 155577
		public float FieldOfView;
	}
}
