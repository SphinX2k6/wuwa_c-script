using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006691 RID: 26257
	public class IEnableSubLevelTransitionWithSceneCaptureT
	{
		// Token: 0x1700C322 RID: 49954
		// (get) Token: 0x0602DA31 RID: 186929 RVA: 0x0063F19A File Offset: 0x0063D39A
		// (set) Token: 0x0602DA32 RID: 186930 RVA: 0x0063F1A2 File Offset: 0x0063D3A2
		public EEnableSubLevelTransitionType Type { get; set; }

		// Token: 0x1700C323 RID: 49955
		// (get) Token: 0x0602DA33 RID: 186931 RVA: 0x0063F1AB File Offset: 0x0063D3AB
		// (set) Token: 0x0602DA34 RID: 186932 RVA: 0x0063F1B3 File Offset: 0x0063D3B3
		public string SceneCaptureEffect { get; set; }

		// Token: 0x1700C324 RID: 49956
		// (get) Token: 0x0602DA35 RID: 186933 RVA: 0x0063F1BC File Offset: 0x0063D3BC
		// (set) Token: 0x0602DA36 RID: 186934 RVA: 0x0063F1C4 File Offset: 0x0063D3C4
		public string ScreenEffect { get; set; }

		// Token: 0x1700C325 RID: 49957
		// (get) Token: 0x0602DA37 RID: 186935 RVA: 0x0063F1CD File Offset: 0x0063D3CD
		// (set) Token: 0x0602DA38 RID: 186936 RVA: 0x0063F1D5 File Offset: 0x0063D3D5
		public string ScreenEffectLoop { get; set; }

		// Token: 0x1700C326 RID: 49958
		// (get) Token: 0x0602DA39 RID: 186937 RVA: 0x0063F1DE File Offset: 0x0063D3DE
		// (set) Token: 0x0602DA3A RID: 186938 RVA: 0x0063F1E6 File Offset: 0x0063D3E6
		public float DelayTime { get; set; }

		// Token: 0x1700C327 RID: 49959
		// (get) Token: 0x0602DA3B RID: 186939 RVA: 0x0063F1EF File Offset: 0x0063D3EF
		// (set) Token: 0x0602DA3C RID: 186940 RVA: 0x0063F1F7 File Offset: 0x0063D3F7
		public bool IsAllowInput { get; set; }

		// Token: 0x1700C328 RID: 49960
		// (get) Token: 0x0602DA3D RID: 186941 RVA: 0x0063F200 File Offset: 0x0063D400
		// (set) Token: 0x0602DA3E RID: 186942 RVA: 0x0063F208 File Offset: 0x0063D408
		public byte NullMask { get; set; }

		// Token: 0x0602DA3F RID: 186943 RVA: 0x0063F211 File Offset: 0x0063D411
		public IEnableSubLevelTransitionWithSceneCaptureT()
		{
			this.Type = EEnableSubLevelTransitionType.SceneCapture;
			this.SceneCaptureEffect = null;
			this.ScreenEffect = null;
			this.ScreenEffectLoop = null;
			this.DelayTime = 0f;
			this.IsAllowInput = false;
			this.NullMask = 0;
		}
	}
}
