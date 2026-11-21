using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E13 RID: 28179
	public class IFadeInScreenT
	{
		// Token: 0x1700CE85 RID: 52869
		// (get) Token: 0x06030A70 RID: 199280 RVA: 0x0069ABFB File Offset: 0x00698DFB
		// (set) Token: 0x06030A71 RID: 199281 RVA: 0x0069AC03 File Offset: 0x00698E03
		public EFadeUiOverride TypeOverride { get; set; }

		// Token: 0x1700CE86 RID: 52870
		// (get) Token: 0x06030A72 RID: 199282 RVA: 0x0069AC0C File Offset: 0x00698E0C
		// (set) Token: 0x06030A73 RID: 199283 RVA: 0x0069AC14 File Offset: 0x00698E14
		public IEaseDataT Ease { get; set; }

		// Token: 0x1700CE87 RID: 52871
		// (get) Token: 0x06030A74 RID: 199284 RVA: 0x0069AC1D File Offset: 0x00698E1D
		// (set) Token: 0x06030A75 RID: 199285 RVA: 0x0069AC25 File Offset: 0x00698E25
		public EFadeInScreenShowType ScreenType { get; set; }

		// Token: 0x1700CE88 RID: 52872
		// (get) Token: 0x06030A76 RID: 199286 RVA: 0x0069AC2E File Offset: 0x00698E2E
		// (set) Token: 0x06030A77 RID: 199287 RVA: 0x0069AC36 File Offset: 0x00698E36
		public bool KeepFadeAfterTreeEnd { get; set; }

		// Token: 0x1700CE89 RID: 52873
		// (get) Token: 0x06030A78 RID: 199288 RVA: 0x0069AC3F File Offset: 0x00698E3F
		// (set) Token: 0x06030A79 RID: 199289 RVA: 0x0069AC47 File Offset: 0x00698E47
		public bool KeepFadeAfterTreeRollBack { get; set; }

		// Token: 0x1700CE8A RID: 52874
		// (get) Token: 0x06030A7A RID: 199290 RVA: 0x0069AC50 File Offset: 0x00698E50
		// (set) Token: 0x06030A7B RID: 199291 RVA: 0x0069AC58 File Offset: 0x00698E58
		public TFadeBackgroundUnion FadeBackground { get; set; }

		// Token: 0x1700CE8B RID: 52875
		// (get) Token: 0x06030A7C RID: 199292 RVA: 0x0069AC61 File Offset: 0x00698E61
		// (set) Token: 0x06030A7D RID: 199293 RVA: 0x0069AC69 File Offset: 0x00698E69
		public bool OnlyLowMemoryDeviceExecute { get; set; }

		// Token: 0x1700CE8C RID: 52876
		// (get) Token: 0x06030A7E RID: 199294 RVA: 0x0069AC72 File Offset: 0x00698E72
		// (set) Token: 0x06030A7F RID: 199295 RVA: 0x0069AC7A File Offset: 0x00698E7A
		public byte NullMask { get; set; }

		// Token: 0x06030A80 RID: 199296 RVA: 0x0069AC83 File Offset: 0x00698E83
		public IFadeInScreenT()
		{
			this.TypeOverride = EFadeUiOverride.ShowTalkDialog;
			this.Ease = null;
			this.ScreenType = EFadeInScreenShowType.White;
			this.KeepFadeAfterTreeEnd = false;
			this.KeepFadeAfterTreeRollBack = false;
			this.FadeBackground = null;
			this.OnlyLowMemoryDeviceExecute = false;
			this.NullMask = 0;
		}
	}
}
