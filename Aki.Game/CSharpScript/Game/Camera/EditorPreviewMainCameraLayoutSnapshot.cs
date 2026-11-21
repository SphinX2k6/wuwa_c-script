using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200642E RID: 25646
	[NullableContext(1)]
	[Nullable(0)]
	internal class EditorPreviewMainCameraLayoutSnapshot
	{
		// Token: 0x0603E474 RID: 255092 RVA: 0x01219815 File Offset: 0x01217A15
		public EditorPreviewMainCameraLayoutSnapshot(Vector2D viewLocation, Vector2D viewSize, bool enableScissorOffset)
		{
			this.ViewLocation = viewLocation;
			this.ViewSize = viewSize;
			this.EnableScissorOffset = enableScissorOffset;
		}

		// Token: 0x04021288 RID: 135816
		public readonly Vector2D ViewLocation;

		// Token: 0x04021289 RID: 135817
		public readonly Vector2D ViewSize;

		// Token: 0x0402128A RID: 135818
		public readonly bool EnableScissorOffset;
	}
}
