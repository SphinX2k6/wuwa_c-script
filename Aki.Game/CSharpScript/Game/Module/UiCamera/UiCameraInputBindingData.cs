using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039B4 RID: 14772
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraInputBindingData
	{
		// Token: 0x17004D9A RID: 19866
		// (get) Token: 0x0602608E RID: 155790 RVA: 0x00AAC26E File Offset: 0x00AAA46E
		// (set) Token: 0x0602608F RID: 155791 RVA: 0x00AAC276 File Offset: 0x00AAA476
		public UUIDraggableComponent DragComponent { get; set; }

		// Token: 0x17004D9B RID: 19867
		// (get) Token: 0x06026090 RID: 155792 RVA: 0x00AAC27F File Offset: 0x00AAA47F
		// (set) Token: 0x06026091 RID: 155793 RVA: 0x00AAC287 File Offset: 0x00AAA487
		public SUiRoleCameraSetting CameraSettingConfig { get; set; }

		// Token: 0x17004D9C RID: 19868
		// (get) Token: 0x06026092 RID: 155794 RVA: 0x00AAC290 File Offset: 0x00AAA490
		// (set) Token: 0x06026093 RID: 155795 RVA: 0x00AAC298 File Offset: 0x00AAA498
		public SUiRoleCameraOffsetSetting? CameraOffsetConfig { get; set; }

		// Token: 0x17004D9D RID: 19869
		// (get) Token: 0x06026094 RID: 155796 RVA: 0x00AAC2A1 File Offset: 0x00AAA4A1
		// (set) Token: 0x06026095 RID: 155797 RVA: 0x00AAC2A9 File Offset: 0x00AAA4A9
		public FVector SourceLocation { get; set; }
	}
}
