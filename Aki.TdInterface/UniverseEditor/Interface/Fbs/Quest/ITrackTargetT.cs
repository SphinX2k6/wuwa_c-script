using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004677 RID: 18039
	public class ITrackTargetT
	{
		// Token: 0x17007E69 RID: 32361
		// (get) Token: 0x0601A7A8 RID: 108456 RVA: 0x003C5080 File Offset: 0x003C3280
		// (set) Token: 0x0601A7A9 RID: 108457 RVA: 0x003C5088 File Offset: 0x003C3288
		public TTrackTypeUnion TrackType { get; set; }

		// Token: 0x17007E6A RID: 32362
		// (get) Token: 0x0601A7AA RID: 108458 RVA: 0x003C5091 File Offset: 0x003C3291
		// (set) Token: 0x0601A7AB RID: 108459 RVA: 0x003C5099 File Offset: 0x003C3299
		public ETrackViewMode TrackViewMode { get; set; }

		// Token: 0x17007E6B RID: 32363
		// (get) Token: 0x0601A7AC RID: 108460 RVA: 0x003C50A2 File Offset: 0x003C32A2
		// (set) Token: 0x0601A7AD RID: 108461 RVA: 0x003C50AA File Offset: 0x003C32AA
		public float Range { get; set; }

		// Token: 0x17007E6C RID: 32364
		// (get) Token: 0x0601A7AE RID: 108462 RVA: 0x003C50B3 File Offset: 0x003C32B3
		// (set) Token: 0x0601A7AF RID: 108463 RVA: 0x003C50BB File Offset: 0x003C32BB
		public float ViewRange { get; set; }

		// Token: 0x17007E6D RID: 32365
		// (get) Token: 0x0601A7B0 RID: 108464 RVA: 0x003C50C4 File Offset: 0x003C32C4
		// (set) Token: 0x0601A7B1 RID: 108465 RVA: 0x003C50CC File Offset: 0x003C32CC
		public IZaxisViewRangeT ZaxisViewRange { get; set; }

		// Token: 0x17007E6E RID: 32366
		// (get) Token: 0x0601A7B2 RID: 108466 RVA: 0x003C50D5 File Offset: 0x003C32D5
		// (set) Token: 0x0601A7B3 RID: 108467 RVA: 0x003C50DD File Offset: 0x003C32DD
		public ETrackEffect Effect { get; set; }

		// Token: 0x17007E6F RID: 32367
		// (get) Token: 0x0601A7B4 RID: 108468 RVA: 0x003C50E6 File Offset: 0x003C32E6
		// (set) Token: 0x0601A7B5 RID: 108469 RVA: 0x003C50EE File Offset: 0x003C32EE
		public ITrackEffectAutoChangeT EffectOption { get; set; }

		// Token: 0x17007E70 RID: 32368
		// (get) Token: 0x0601A7B6 RID: 108470 RVA: 0x003C50F7 File Offset: 0x003C32F7
		// (set) Token: 0x0601A7B7 RID: 108471 RVA: 0x003C50FF File Offset: 0x003C32FF
		public byte NullMask { get; set; }

		// Token: 0x0601A7B8 RID: 108472 RVA: 0x003C5108 File Offset: 0x003C3308
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
