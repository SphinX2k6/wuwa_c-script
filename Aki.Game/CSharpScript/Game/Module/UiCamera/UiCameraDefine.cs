using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039B3 RID: 14771
	[NullableContext(1)]
	[Nullable(0)]
	public static class UiCameraDefine
	{
		// Token: 0x04014E57 RID: 85591
		public const string DEFAULT_BLEND_NAME = "1001";

		// Token: 0x020095E1 RID: 38369
		public interface IFinishData
		{
			// Token: 0x170078F7 RID: 30967
			// (get) Token: 0x0604412F RID: 278831
			ECameraAnimationFinishType FinishType { get; }

			// Token: 0x170078F8 RID: 30968
			// (get) Token: 0x06044130 RID: 278832
			UiCameraHandleData FromHandleData { get; }

			// Token: 0x170078F9 RID: 30969
			// (get) Token: 0x06044131 RID: 278833
			UiCameraHandleData ToHandleData { get; }
		}

		// Token: 0x020095E2 RID: 38370
		[Nullable(0)]
		public class FinishData : UiCameraDefine.IFinishData
		{
			// Token: 0x170078FA RID: 30970
			// (get) Token: 0x06044132 RID: 278834 RVA: 0x01439A24 File Offset: 0x01437C24
			// (set) Token: 0x06044133 RID: 278835 RVA: 0x01439A2C File Offset: 0x01437C2C
			public ECameraAnimationFinishType FinishType { get; set; }

			// Token: 0x170078FB RID: 30971
			// (get) Token: 0x06044134 RID: 278836 RVA: 0x01439A35 File Offset: 0x01437C35
			// (set) Token: 0x06044135 RID: 278837 RVA: 0x01439A3D File Offset: 0x01437C3D
			public UiCameraHandleData FromHandleData { get; set; }

			// Token: 0x170078FC RID: 30972
			// (get) Token: 0x06044136 RID: 278838 RVA: 0x01439A46 File Offset: 0x01437C46
			// (set) Token: 0x06044137 RID: 278839 RVA: 0x01439A4E File Offset: 0x01437C4E
			public UiCameraHandleData ToHandleData { get; set; }
		}
	}
}
