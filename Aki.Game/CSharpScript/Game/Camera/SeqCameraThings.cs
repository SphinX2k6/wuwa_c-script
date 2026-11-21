using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006431 RID: 25649
	[NullableContext(2)]
	[Nullable(0)]
	public class SeqCameraThings
	{
		// Token: 0x04021290 RID: 135824
		public FVectorDouble CameraLocation = Vector.Create().ToUeVector(false);

		// Token: 0x04021291 RID: 135825
		public FRotator CameraRotation = Rotator.Create().ToUeRotator();

		// Token: 0x04021292 RID: 135826
		public FVectorDouble CameraScale = Vector.Create().ToUeVector(false);

		// Token: 0x04021293 RID: 135827
		public FTransformDouble? OriginRootTransform;

		// Token: 0x04021294 RID: 135828
		public bool ConstrainAspectRatio;

		// Token: 0x04021295 RID: 135829
		public float CurrentAperture;

		// Token: 0x04021296 RID: 135830
		public float CurrentFocalLength;

		// Token: 0x04021297 RID: 135831
		public FCameraFocusSettings FocusSettings;

		// Token: 0x04021298 RID: 135832
		public FCameraLensSettings LensSettings;

		// Token: 0x04021299 RID: 135833
		public float FieldOfView;
	}
}
