using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FFA RID: 20474
	public sealed class EntityControlRuntimeOptions
	{
		// Token: 0x17007FDF RID: 32735
		// (get) Token: 0x060345F3 RID: 214515 RVA: 0x00C4EA94 File Offset: 0x00C4CC94
		// (set) Token: 0x060345F4 RID: 214516 RVA: 0x00C4EA9C File Offset: 0x00C4CC9C
		public bool IsEnabled { get; set; }

		// Token: 0x17007FE0 RID: 32736
		// (get) Token: 0x060345F5 RID: 214517 RVA: 0x00C4EAA5 File Offset: 0x00C4CCA5
		// (set) Token: 0x060345F6 RID: 214518 RVA: 0x00C4EAAD File Offset: 0x00C4CCAD
		public EEntityControlCameraMode? CameraMode { get; set; }

		// Token: 0x17007FE1 RID: 32737
		// (get) Token: 0x060345F7 RID: 214519 RVA: 0x00C4EAB6 File Offset: 0x00C4CCB6
		// (set) Token: 0x060345F8 RID: 214520 RVA: 0x00C4EABE File Offset: 0x00C4CCBE
		public bool HandlePlayer { get; set; }

		// Token: 0x17007FE2 RID: 32738
		// (get) Token: 0x060345F9 RID: 214521 RVA: 0x00C4EAC7 File Offset: 0x00C4CCC7
		// (set) Token: 0x060345FA RID: 214522 RVA: 0x00C4EACF File Offset: 0x00C4CCCF
		public bool HideSkipButton { get; set; }

		// Token: 0x17007FE3 RID: 32739
		// (get) Token: 0x060345FB RID: 214523 RVA: 0x00C4EAD8 File Offset: 0x00C4CCD8
		public bool UseSequenceCamera
		{
			get
			{
				EEntityControlCameraMode? cameraMode = this.CameraMode;
				EEntityControlCameraMode eentityControlCameraMode = EEntityControlCameraMode.UseSequenceCamera;
				return cameraMode.GetValueOrDefault() == eentityControlCameraMode & cameraMode != null;
			}
		}

		// Token: 0x17007FE4 RID: 32740
		// (get) Token: 0x060345FC RID: 214524 RVA: 0x00C4EB00 File Offset: 0x00C4CD00
		public bool FollowSequencePlayer
		{
			get
			{
				return this.CameraMode.GetValueOrDefault() == EEntityControlCameraMode.FollowSequencePlayer;
			}
		}
	}
}
