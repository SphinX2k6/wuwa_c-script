using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200642D RID: 25645
	[NullableContext(2)]
	[Nullable(0)]
	internal class EditorPreviewOwnedCamera
	{
		// Token: 0x0603E473 RID: 255091 RVA: 0x012197FF File Offset: 0x012179FF
		[NullableContext(1)]
		public EditorPreviewOwnedCamera(string cameraName, CameraModelInstance cameraModel)
		{
			this.CameraName = cameraName;
			this.CameraModel = cameraModel;
		}

		// Token: 0x04021286 RID: 135814
		public string CameraName;

		// Token: 0x04021287 RID: 135815
		public CameraModelInstance CameraModel;
	}
}
