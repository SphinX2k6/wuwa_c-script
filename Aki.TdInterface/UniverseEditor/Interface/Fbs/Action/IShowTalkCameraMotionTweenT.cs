using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078C1 RID: 30913
	public class IShowTalkCameraMotionTweenT
	{
		// Token: 0x1700E2DB RID: 58075
		// (get) Token: 0x060366C7 RID: 222919 RVA: 0x00749C62 File Offset: 0x00747E62
		// (set) Token: 0x060366C8 RID: 222920 RVA: 0x00749C6A File Offset: 0x00747E6A
		public EShowTalkCameraMotionType Type { get; set; }

		// Token: 0x1700E2DC RID: 58076
		// (get) Token: 0x060366C9 RID: 222921 RVA: 0x00749C73 File Offset: 0x00747E73
		// (set) Token: 0x060366CA RID: 222922 RVA: 0x00749C7B File Offset: 0x00747E7B
		public ICameraParamsT Start { get; set; }

		// Token: 0x1700E2DD RID: 58077
		// (get) Token: 0x060366CB RID: 222923 RVA: 0x00749C84 File Offset: 0x00747E84
		// (set) Token: 0x060366CC RID: 222924 RVA: 0x00749C8C File Offset: 0x00747E8C
		public ICameraParamsT End { get; set; }

		// Token: 0x1700E2DE RID: 58078
		// (get) Token: 0x060366CD RID: 222925 RVA: 0x00749C95 File Offset: 0x00747E95
		// (set) Token: 0x060366CE RID: 222926 RVA: 0x00749C9D File Offset: 0x00747E9D
		public float Duration { get; set; }

		// Token: 0x1700E2DF RID: 58079
		// (get) Token: 0x060366CF RID: 222927 RVA: 0x00749CA6 File Offset: 0x00747EA6
		// (set) Token: 0x060366D0 RID: 222928 RVA: 0x00749CAE File Offset: 0x00747EAE
		public EEaseType EaseType { get; set; }

		// Token: 0x1700E2E0 RID: 58080
		// (get) Token: 0x060366D1 RID: 222929 RVA: 0x00749CB7 File Offset: 0x00747EB7
		// (set) Token: 0x060366D2 RID: 222930 RVA: 0x00749CBF File Offset: 0x00747EBF
		public IFlowCameraShakeT CamShake { get; set; }

		// Token: 0x1700E2E1 RID: 58081
		// (get) Token: 0x060366D3 RID: 222931 RVA: 0x00749CC8 File Offset: 0x00747EC8
		// (set) Token: 0x060366D4 RID: 222932 RVA: 0x00749CD0 File Offset: 0x00747ED0
		public byte NullMask { get; set; }

		// Token: 0x060366D5 RID: 222933 RVA: 0x00749CD9 File Offset: 0x00747ED9
		public IShowTalkCameraMotionTweenT()
		{
			this.Type = EShowTalkCameraMotionType.Preset;
			this.Start = null;
			this.End = null;
			this.Duration = 0f;
			this.EaseType = EEaseType.Linear;
			this.CamShake = null;
			this.NullMask = 0;
		}
	}
}
