using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D0B RID: 27915
	public class IEnableSubLevelTransitionWithSceneCaptureT
	{
		// Token: 0x1700CCD3 RID: 52435
		// (get) Token: 0x0603024E RID: 197198 RVA: 0x0068C44E File Offset: 0x0068A64E
		// (set) Token: 0x0603024F RID: 197199 RVA: 0x0068C456 File Offset: 0x0068A656
		public EEnableSubLevelTransitionType Type { get; set; }

		// Token: 0x1700CCD4 RID: 52436
		// (get) Token: 0x06030250 RID: 197200 RVA: 0x0068C45F File Offset: 0x0068A65F
		// (set) Token: 0x06030251 RID: 197201 RVA: 0x0068C467 File Offset: 0x0068A667
		public string SceneCaptureEffect { get; set; }

		// Token: 0x1700CCD5 RID: 52437
		// (get) Token: 0x06030252 RID: 197202 RVA: 0x0068C470 File Offset: 0x0068A670
		// (set) Token: 0x06030253 RID: 197203 RVA: 0x0068C478 File Offset: 0x0068A678
		public string ScreenEffect { get; set; }

		// Token: 0x1700CCD6 RID: 52438
		// (get) Token: 0x06030254 RID: 197204 RVA: 0x0068C481 File Offset: 0x0068A681
		// (set) Token: 0x06030255 RID: 197205 RVA: 0x0068C489 File Offset: 0x0068A689
		public string ScreenEffectLoop { get; set; }

		// Token: 0x1700CCD7 RID: 52439
		// (get) Token: 0x06030256 RID: 197206 RVA: 0x0068C492 File Offset: 0x0068A692
		// (set) Token: 0x06030257 RID: 197207 RVA: 0x0068C49A File Offset: 0x0068A69A
		public float DelayTime { get; set; }

		// Token: 0x1700CCD8 RID: 52440
		// (get) Token: 0x06030258 RID: 197208 RVA: 0x0068C4A3 File Offset: 0x0068A6A3
		// (set) Token: 0x06030259 RID: 197209 RVA: 0x0068C4AB File Offset: 0x0068A6AB
		public bool IsAllowInput { get; set; }

		// Token: 0x1700CCD9 RID: 52441
		// (get) Token: 0x0603025A RID: 197210 RVA: 0x0068C4B4 File Offset: 0x0068A6B4
		// (set) Token: 0x0603025B RID: 197211 RVA: 0x0068C4BC File Offset: 0x0068A6BC
		public byte NullMask { get; set; }

		// Token: 0x0603025C RID: 197212 RVA: 0x0068C4C5 File Offset: 0x0068A6C5
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
