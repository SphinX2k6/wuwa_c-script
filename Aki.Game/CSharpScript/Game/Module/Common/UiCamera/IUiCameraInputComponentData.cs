using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.UiCamera
{
	// Token: 0x02005B48 RID: 23368
	[NullableContext(1)]
	public interface IUiCameraInputComponentData
	{
		// Token: 0x17008C9C RID: 35996
		// (get) Token: 0x0603B28C RID: 242316
		// (set) Token: 0x0603B28D RID: 242317
		UUIDraggableComponent DragComponent { get; set; }

		// Token: 0x17008C9D RID: 35997
		// (get) Token: 0x0603B28E RID: 242318
		// (set) Token: 0x0603B28F RID: 242319
		SUiRoleCameraSetting CameraSettingConfig { get; set; }

		// Token: 0x17008C9E RID: 35998
		// (get) Token: 0x0603B290 RID: 242320
		// (set) Token: 0x0603B291 RID: 242321
		SUiRoleCameraOffsetSetting? CameraOffsetConfig { get; set; }

		// Token: 0x17008C9F RID: 35999
		// (get) Token: 0x0603B292 RID: 242322
		// (set) Token: 0x0603B293 RID: 242323
		FVector SourceLocation { get; set; }
	}
}
