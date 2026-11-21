using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02003FE1 RID: 16353
	public sealed class SequencePlayOptions
	{
		// Token: 0x170053B1 RID: 21425
		// (get) Token: 0x06029629 RID: 169513 RVA: 0x00BA73D0 File Offset: 0x00BA55D0
		public EPlotCameraMode? CameraMode { get; }

		// Token: 0x170053B2 RID: 21426
		// (get) Token: 0x0602962A RID: 169514 RVA: 0x00BA73D8 File Offset: 0x00BA55D8
		public bool IsSubtitleUiUse { get; }

		// Token: 0x170053B3 RID: 21427
		// (get) Token: 0x0602962B RID: 169515 RVA: 0x00BA73E0 File Offset: 0x00BA55E0
		public bool IsWaitRenderData { get; }

		// Token: 0x170053B4 RID: 21428
		// (get) Token: 0x0602962C RID: 169516 RVA: 0x00BA73E8 File Offset: 0x00BA55E8
		public float PlayRate { get; }

		// Token: 0x170053B5 RID: 21429
		// (get) Token: 0x0602962D RID: 169517 RVA: 0x00BA73F0 File Offset: 0x00BA55F0
		public bool IsControlEntity { get; }

		// Token: 0x170053B6 RID: 21430
		// (get) Token: 0x0602962E RID: 169518 RVA: 0x00BA73F8 File Offset: 0x00BA55F8
		public bool HandlePlayer { get; }

		// Token: 0x170053B7 RID: 21431
		// (get) Token: 0x0602962F RID: 169519 RVA: 0x00BA7400 File Offset: 0x00BA5600
		public bool UseSequenceCamera { get; }

		// Token: 0x170053B8 RID: 21432
		// (get) Token: 0x06029630 RID: 169520 RVA: 0x00BA7408 File Offset: 0x00BA5608
		public bool FollowSequencePlayer { get; }

		// Token: 0x170053B9 RID: 21433
		// (get) Token: 0x06029631 RID: 169521 RVA: 0x00BA7410 File Offset: 0x00BA5610
		public bool IsViewTargetControl
		{
			get
			{
				return !this.IsControlEntity || this.UseSequenceCamera;
			}
		}

		// Token: 0x170053BA RID: 21434
		// (get) Token: 0x06029632 RID: 169522 RVA: 0x00BA7422 File Offset: 0x00BA5622
		public bool DoNotHandlePlayerForControlEntityMode
		{
			get
			{
				return this.IsControlEntity && !this.HandlePlayer;
			}
		}

		// Token: 0x06029633 RID: 169523 RVA: 0x00BA7438 File Offset: 0x00BA5638
		[NullableContext(2)]
		public SequencePlayOptions(EPlotCameraMode? cameraMode, EntityControlRuntimeOptions entityControlOptions, bool isSubtitleUiUse, bool isWaitRenderData, float playRate)
		{
			this.CameraMode = cameraMode;
			this.IsSubtitleUiUse = isSubtitleUiUse;
			this.IsWaitRenderData = isWaitRenderData;
			this.PlayRate = playRate;
			this.IsControlEntity = (entityControlOptions != null && entityControlOptions.IsEnabled);
			this.HandlePlayer = (entityControlOptions != null && entityControlOptions.HandlePlayer);
			this.UseSequenceCamera = (entityControlOptions != null && entityControlOptions.UseSequenceCamera);
			this.FollowSequencePlayer = (entityControlOptions != null && entityControlOptions.FollowSequencePlayer);
		}
	}
}
