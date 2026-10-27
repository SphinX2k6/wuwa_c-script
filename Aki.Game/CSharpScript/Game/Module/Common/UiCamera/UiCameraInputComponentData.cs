using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.UiCamera
{
	// Token: 0x02005B49 RID: 23369
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraInputComponentData : IUiCameraInputComponentData
	{
		// Token: 0x17008CA0 RID: 36000
		// (get) Token: 0x0603B294 RID: 242324 RVA: 0x00E1B354 File Offset: 0x00E19554
		// (set) Token: 0x0603B295 RID: 242325 RVA: 0x00E1B35C File Offset: 0x00E1955C
		public UUIDraggableComponent DragComponent { get; set; }

		// Token: 0x17008CA1 RID: 36001
		// (get) Token: 0x0603B296 RID: 242326 RVA: 0x00E1B365 File Offset: 0x00E19565
		// (set) Token: 0x0603B297 RID: 242327 RVA: 0x00E1B36D File Offset: 0x00E1956D
		public SUiRoleCameraSetting CameraSettingConfig { get; set; }

		// Token: 0x17008CA2 RID: 36002
		// (get) Token: 0x0603B298 RID: 242328 RVA: 0x00E1B376 File Offset: 0x00E19576
		// (set) Token: 0x0603B299 RID: 242329 RVA: 0x00E1B37E File Offset: 0x00E1957E
		public SUiRoleCameraOffsetSetting? CameraOffsetConfig { get; set; }

		// Token: 0x17008CA3 RID: 36003
		// (get) Token: 0x0603B29A RID: 242330 RVA: 0x00E1B387 File Offset: 0x00E19587
		// (set) Token: 0x0603B29B RID: 242331 RVA: 0x00E1B38F File Offset: 0x00E1958F
		public FVector SourceLocation { get; set; }
	}
}
