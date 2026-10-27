using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02005017 RID: 20503
	public sealed class SequencePlayOptions
	{
		// Token: 0x17007FFC RID: 32764
		// (get) Token: 0x06034786 RID: 214918 RVA: 0x00C5BE90 File Offset: 0x00C5A090
		public EPlotCameraMode? CameraMode { get; }

		// Token: 0x17007FFD RID: 32765
		// (get) Token: 0x06034787 RID: 214919 RVA: 0x00C5BE98 File Offset: 0x00C5A098
		public bool IsSubtitleUiUse { get; }

		// Token: 0x17007FFE RID: 32766
		// (get) Token: 0x06034788 RID: 214920 RVA: 0x00C5BEA0 File Offset: 0x00C5A0A0
		public bool IsWaitRenderData { get; }

		// Token: 0x17007FFF RID: 32767
		// (get) Token: 0x06034789 RID: 214921 RVA: 0x00C5BEA8 File Offset: 0x00C5A0A8
		public float PlayRate { get; }

		// Token: 0x17008000 RID: 32768
		// (get) Token: 0x0603478A RID: 214922 RVA: 0x00C5BEB0 File Offset: 0x00C5A0B0
		public bool IsControlEntity { get; }

		// Token: 0x17008001 RID: 32769
		// (get) Token: 0x0603478B RID: 214923 RVA: 0x00C5BEB8 File Offset: 0x00C5A0B8
		public bool HandlePlayer { get; }

		// Token: 0x17008002 RID: 32770
		// (get) Token: 0x0603478C RID: 214924 RVA: 0x00C5BEC0 File Offset: 0x00C5A0C0
		public bool UseSequenceCamera { get; }

		// Token: 0x17008003 RID: 32771
		// (get) Token: 0x0603478D RID: 214925 RVA: 0x00C5BEC8 File Offset: 0x00C5A0C8
		public bool FollowSequencePlayer { get; }

		// Token: 0x17008004 RID: 32772
		// (get) Token: 0x0603478E RID: 214926 RVA: 0x00C5BED0 File Offset: 0x00C5A0D0
		public bool IsViewTargetControl
		{
			get
			{
				return !this.IsControlEntity || this.UseSequenceCamera;
			}
		}

		// Token: 0x17008005 RID: 32773
		// (get) Token: 0x0603478F RID: 214927 RVA: 0x00C5BEE2 File Offset: 0x00C5A0E2
		public bool DoNotHandlePlayerForControlEntityMode
		{
			get
			{
				return this.IsControlEntity && !this.HandlePlayer;
			}
		}

		// Token: 0x06034790 RID: 214928 RVA: 0x00C5BEF8 File Offset: 0x00C5A0F8
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
