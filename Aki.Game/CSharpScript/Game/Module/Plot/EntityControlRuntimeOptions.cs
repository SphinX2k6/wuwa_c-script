using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FC4 RID: 16324
	public sealed class EntityControlRuntimeOptions
	{
		// Token: 0x17005394 RID: 21396
		// (get) Token: 0x0602947E RID: 169086 RVA: 0x00B98AF4 File Offset: 0x00B96CF4
		// (set) Token: 0x0602947F RID: 169087 RVA: 0x00B98AFC File Offset: 0x00B96CFC
		public bool IsEnabled { get; set; }

		// Token: 0x17005395 RID: 21397
		// (get) Token: 0x06029480 RID: 169088 RVA: 0x00B98B05 File Offset: 0x00B96D05
		// (set) Token: 0x06029481 RID: 169089 RVA: 0x00B98B0D File Offset: 0x00B96D0D
		public EEntityControlCameraMode? CameraMode { get; set; }

		// Token: 0x17005396 RID: 21398
		// (get) Token: 0x06029482 RID: 169090 RVA: 0x00B98B16 File Offset: 0x00B96D16
		// (set) Token: 0x06029483 RID: 169091 RVA: 0x00B98B1E File Offset: 0x00B96D1E
		public bool HandlePlayer { get; set; }

		// Token: 0x17005397 RID: 21399
		// (get) Token: 0x06029484 RID: 169092 RVA: 0x00B98B27 File Offset: 0x00B96D27
		// (set) Token: 0x06029485 RID: 169093 RVA: 0x00B98B2F File Offset: 0x00B96D2F
		public bool HideSkipButton { get; set; }

		// Token: 0x17005398 RID: 21400
		// (get) Token: 0x06029486 RID: 169094 RVA: 0x00B98B38 File Offset: 0x00B96D38
		public bool UseSequenceCamera
		{
			get
			{
				EEntityControlCameraMode? cameraMode = this.CameraMode;
				EEntityControlCameraMode eentityControlCameraMode = EEntityControlCameraMode.UseSequenceCamera;
				return cameraMode.GetValueOrDefault() == eentityControlCameraMode & cameraMode != null;
			}
		}

		// Token: 0x17005399 RID: 21401
		// (get) Token: 0x06029487 RID: 169095 RVA: 0x00B98B60 File Offset: 0x00B96D60
		public bool FollowSequencePlayer
		{
			get
			{
				return this.CameraMode.GetValueOrDefault() == EEntityControlCameraMode.FollowSequencePlayer;
			}
		}
	}
}
