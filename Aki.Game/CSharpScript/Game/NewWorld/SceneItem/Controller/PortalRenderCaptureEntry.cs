using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x020062EB RID: 25323
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalRenderCaptureEntry
	{
		// Token: 0x0603D3D0 RID: 250832 RVA: 0x011AE2B0 File Offset: 0x011AC4B0
		public PortalRenderCaptureEntry(PortalRenderCaptureParams @params, int handle, int ownerEntityId, UTextureRenderTarget2D rt, bool isDynamicRt, EPortalCaptureLevel? currentLevel, float maxViewDistance, bool enabled)
		{
		}

		// Token: 0x0402079F RID: 133023
		public PortalRenderCaptureParams Params = @params;

		// Token: 0x040207A0 RID: 133024
		public int Handle = handle;

		// Token: 0x040207A1 RID: 133025
		public int OwnerEntityId = ownerEntityId;

		// Token: 0x040207A2 RID: 133026
		[Nullable(2)]
		public UTextureRenderTarget2D Rt = rt;

		// Token: 0x040207A3 RID: 133027
		public bool IsDynamicRt = isDynamicRt;

		// Token: 0x040207A4 RID: 133028
		public EPortalCaptureLevel? CurrentLevel = currentLevel;

		// Token: 0x040207A5 RID: 133029
		public float MaxViewDistance = maxViewDistance;

		// Token: 0x040207A6 RID: 133030
		public bool Enabled = enabled;
	}
}
