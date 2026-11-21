using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200642C RID: 25644
	[NullableContext(2)]
	[Nullable(0)]
	internal class EditorPreviewCameraOwnership
	{
		// Token: 0x0603E472 RID: 255090 RVA: 0x012197E9 File Offset: 0x012179E9
		[NullableContext(1)]
		public EditorPreviewCameraOwnership(string ownerId, CameraModelInstance cameraModel)
		{
			this.OwnerId = ownerId;
			this.CameraModel = cameraModel;
		}

		// Token: 0x04021284 RID: 135812
		public string OwnerId;

		// Token: 0x04021285 RID: 135813
		public CameraModelInstance CameraModel;
	}
}
