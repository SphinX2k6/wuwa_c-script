using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x02007236 RID: 29238
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalRenderCaptureEntry
	{
		// Token: 0x06047A6F RID: 293487 RVA: 0x01255718 File Offset: 0x01253918
		public PortalRenderCaptureEntry(PortalRenderCaptureParams @params, int handle, int ownerEntityId, UTextureRenderTarget2D rt, bool isDynamicRt, EPortalCaptureLevel? currentLevel, float maxViewDistance, bool enabled)
		{
		}

		// Token: 0x04025B30 RID: 154416
		public PortalRenderCaptureParams Params = @params;

		// Token: 0x04025B31 RID: 154417
		public int Handle = handle;

		// Token: 0x04025B32 RID: 154418
		public int OwnerEntityId = ownerEntityId;

		// Token: 0x04025B33 RID: 154419
		[Nullable(2)]
		public UTextureRenderTarget2D Rt = rt;

		// Token: 0x04025B34 RID: 154420
		public bool IsDynamicRt = isDynamicRt;

		// Token: 0x04025B35 RID: 154421
		public EPortalCaptureLevel? CurrentLevel = currentLevel;

		// Token: 0x04025B36 RID: 154422
		public float MaxViewDistance = maxViewDistance;

		// Token: 0x04025B37 RID: 154423
		public bool Enabled = enabled;
	}
}
