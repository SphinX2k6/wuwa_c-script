using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200421B RID: 16923
	public class ITrackTargetT
	{
		// Token: 0x17007838 RID: 30776
		// (get) Token: 0x0601903C RID: 102460 RVA: 0x003999A8 File Offset: 0x00397BA8
		// (set) Token: 0x0601903D RID: 102461 RVA: 0x003999B0 File Offset: 0x00397BB0
		public TTrackTypeUnion TrackType { get; set; }

		// Token: 0x17007839 RID: 30777
		// (get) Token: 0x0601903E RID: 102462 RVA: 0x003999B9 File Offset: 0x00397BB9
		// (set) Token: 0x0601903F RID: 102463 RVA: 0x003999C1 File Offset: 0x00397BC1
		public ETrackViewMode TrackViewMode { get; set; }

		// Token: 0x1700783A RID: 30778
		// (get) Token: 0x06019040 RID: 102464 RVA: 0x003999CA File Offset: 0x00397BCA
		// (set) Token: 0x06019041 RID: 102465 RVA: 0x003999D2 File Offset: 0x00397BD2
		public float Range { get; set; }

		// Token: 0x1700783B RID: 30779
		// (get) Token: 0x06019042 RID: 102466 RVA: 0x003999DB File Offset: 0x00397BDB
		// (set) Token: 0x06019043 RID: 102467 RVA: 0x003999E3 File Offset: 0x00397BE3
		public float ViewRange { get; set; }

		// Token: 0x1700783C RID: 30780
		// (get) Token: 0x06019044 RID: 102468 RVA: 0x003999EC File Offset: 0x00397BEC
		// (set) Token: 0x06019045 RID: 102469 RVA: 0x003999F4 File Offset: 0x00397BF4
		public IZaxisViewRangeT ZaxisViewRange { get; set; }

		// Token: 0x1700783D RID: 30781
		// (get) Token: 0x06019046 RID: 102470 RVA: 0x003999FD File Offset: 0x00397BFD
		// (set) Token: 0x06019047 RID: 102471 RVA: 0x00399A05 File Offset: 0x00397C05
		public ETrackEffect Effect { get; set; }

		// Token: 0x1700783E RID: 30782
		// (get) Token: 0x06019048 RID: 102472 RVA: 0x00399A0E File Offset: 0x00397C0E
		// (set) Token: 0x06019049 RID: 102473 RVA: 0x00399A16 File Offset: 0x00397C16
		public ITrackEffectAutoChangeT EffectOption { get; set; }

		// Token: 0x1700783F RID: 30783
		// (get) Token: 0x0601904A RID: 102474 RVA: 0x00399A1F File Offset: 0x00397C1F
		// (set) Token: 0x0601904B RID: 102475 RVA: 0x00399A27 File Offset: 0x00397C27
		public byte NullMask { get; set; }

		// Token: 0x0601904C RID: 102476 RVA: 0x00399A30 File Offset: 0x00397C30
		public ITrackTargetT()
		{
			this.TrackType = null;
			this.TrackViewMode = ETrackViewMode.All;
			this.Range = 0f;
			this.ViewRange = 0f;
			this.ZaxisViewRange = null;
			this.Effect = ETrackEffect.LongLightBeam;
			this.EffectOption = null;
			this.NullMask = 0;
		}
	}
}
