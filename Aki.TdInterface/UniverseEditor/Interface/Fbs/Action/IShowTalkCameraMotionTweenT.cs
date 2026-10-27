using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F5 RID: 28917
	public class IShowTalkCameraMotionTweenT
	{
		// Token: 0x1700D6F8 RID: 55032
		// (get) Token: 0x06033425 RID: 209957 RVA: 0x006E9656 File Offset: 0x006E7856
		// (set) Token: 0x06033426 RID: 209958 RVA: 0x006E965E File Offset: 0x006E785E
		public EShowTalkCameraMotionType Type { get; set; }

		// Token: 0x1700D6F9 RID: 55033
		// (get) Token: 0x06033427 RID: 209959 RVA: 0x006E9667 File Offset: 0x006E7867
		// (set) Token: 0x06033428 RID: 209960 RVA: 0x006E966F File Offset: 0x006E786F
		public ICameraParamsT Start { get; set; }

		// Token: 0x1700D6FA RID: 55034
		// (get) Token: 0x06033429 RID: 209961 RVA: 0x006E9678 File Offset: 0x006E7878
		// (set) Token: 0x0603342A RID: 209962 RVA: 0x006E9680 File Offset: 0x006E7880
		public ICameraParamsT End { get; set; }

		// Token: 0x1700D6FB RID: 55035
		// (get) Token: 0x0603342B RID: 209963 RVA: 0x006E9689 File Offset: 0x006E7889
		// (set) Token: 0x0603342C RID: 209964 RVA: 0x006E9691 File Offset: 0x006E7891
		public float Duration { get; set; }

		// Token: 0x1700D6FC RID: 55036
		// (get) Token: 0x0603342D RID: 209965 RVA: 0x006E969A File Offset: 0x006E789A
		// (set) Token: 0x0603342E RID: 209966 RVA: 0x006E96A2 File Offset: 0x006E78A2
		public EEaseType EaseType { get; set; }

		// Token: 0x1700D6FD RID: 55037
		// (get) Token: 0x0603342F RID: 209967 RVA: 0x006E96AB File Offset: 0x006E78AB
		// (set) Token: 0x06033430 RID: 209968 RVA: 0x006E96B3 File Offset: 0x006E78B3
		public IFlowCameraShakeT CamShake { get; set; }

		// Token: 0x1700D6FE RID: 55038
		// (get) Token: 0x06033431 RID: 209969 RVA: 0x006E96BC File Offset: 0x006E78BC
		// (set) Token: 0x06033432 RID: 209970 RVA: 0x006E96C4 File Offset: 0x006E78C4
		public byte NullMask { get; set; }

		// Token: 0x06033433 RID: 209971 RVA: 0x006E96CD File Offset: 0x006E78CD
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
