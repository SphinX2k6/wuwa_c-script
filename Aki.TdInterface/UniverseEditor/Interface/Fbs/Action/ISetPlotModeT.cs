using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007825 RID: 30757
	public class ISetPlotModeT
	{
		// Token: 0x1700E19E RID: 57758
		// (get) Token: 0x06036155 RID: 221525 RVA: 0x0073F319 File Offset: 0x0073D519
		// (set) Token: 0x06036156 RID: 221526 RVA: 0x0073F321 File Offset: 0x0073D521
		public string Mode { get; set; }

		// Token: 0x1700E19F RID: 57759
		// (get) Token: 0x06036157 RID: 221527 RVA: 0x0073F32A File Offset: 0x0073D52A
		// (set) Token: 0x06036158 RID: 221528 RVA: 0x0073F332 File Offset: 0x0073D532
		public bool IsSwitchMainRole { get; set; }

		// Token: 0x1700E1A0 RID: 57760
		// (get) Token: 0x06036159 RID: 221529 RVA: 0x0073F33B File Offset: 0x0073D53B
		// (set) Token: 0x0603615A RID: 221530 RVA: 0x0073F343 File Offset: 0x0073D543
		public bool UseFlowCamera { get; set; }

		// Token: 0x1700E1A1 RID: 57761
		// (get) Token: 0x0603615B RID: 221531 RVA: 0x0073F34C File Offset: 0x0073D54C
		// (set) Token: 0x0603615C RID: 221532 RVA: 0x0073F354 File Offset: 0x0073D554
		public bool Interruptible { get; set; }

		// Token: 0x1700E1A2 RID: 57762
		// (get) Token: 0x0603615D RID: 221533 RVA: 0x0073F35D File Offset: 0x0073D55D
		// (set) Token: 0x0603615E RID: 221534 RVA: 0x0073F365 File Offset: 0x0073D565
		public bool NoSkip { get; set; }

		// Token: 0x1700E1A3 RID: 57763
		// (get) Token: 0x0603615F RID: 221535 RVA: 0x0073F36E File Offset: 0x0073D56E
		// (set) Token: 0x06036160 RID: 221536 RVA: 0x0073F376 File Offset: 0x0073D576
		public bool DisableAutoFadeOut { get; set; }

		// Token: 0x1700E1A4 RID: 57764
		// (get) Token: 0x06036161 RID: 221537 RVA: 0x0073F37F File Offset: 0x0073D57F
		// (set) Token: 0x06036162 RID: 221538 RVA: 0x0073F387 File Offset: 0x0073D587
		public bool WaitForPlayerMotionEnd { get; set; }

		// Token: 0x1700E1A5 RID: 57765
		// (get) Token: 0x06036163 RID: 221539 RVA: 0x0073F390 File Offset: 0x0073D590
		// (set) Token: 0x06036164 RID: 221540 RVA: 0x0073F398 File Offset: 0x0073D598
		public bool NoUiEnterAnimation { get; set; }

		// Token: 0x1700E1A6 RID: 57766
		// (get) Token: 0x06036165 RID: 221541 RVA: 0x0073F3A1 File Offset: 0x0073D5A1
		// (set) Token: 0x06036166 RID: 221542 RVA: 0x0073F3A9 File Offset: 0x0073D5A9
		public IFadeInScreenT FastFadeIn { get; set; }

		// Token: 0x1700E1A7 RID: 57767
		// (get) Token: 0x06036167 RID: 221543 RVA: 0x0073F3B2 File Offset: 0x0073D5B2
		// (set) Token: 0x06036168 RID: 221544 RVA: 0x0073F3BA File Offset: 0x0073D5BA
		public bool KeepMainRolePose { get; set; }

		// Token: 0x1700E1A8 RID: 57768
		// (get) Token: 0x06036169 RID: 221545 RVA: 0x0073F3C3 File Offset: 0x0073D5C3
		// (set) Token: 0x0603616A RID: 221546 RVA: 0x0073F3CB File Offset: 0x0073D5CB
		public TPromptStyleUnion PromptStyle { get; set; }

		// Token: 0x1700E1A9 RID: 57769
		// (get) Token: 0x0603616B RID: 221547 RVA: 0x0073F3D4 File Offset: 0x0073D5D4
		// (set) Token: 0x0603616C RID: 221548 RVA: 0x0073F3DC File Offset: 0x0073D5DC
		public TSubtitleStyleUnion SubtitleStyle { get; set; }

		// Token: 0x1700E1AA RID: 57770
		// (get) Token: 0x0603616D RID: 221549 RVA: 0x0073F3E5 File Offset: 0x0073D5E5
		// (set) Token: 0x0603616E RID: 221550 RVA: 0x0073F3ED File Offset: 0x0073D5ED
		public IPhoneMessageConfigT PhoneMessageConfig { get; set; }

		// Token: 0x1700E1AB RID: 57771
		// (get) Token: 0x0603616F RID: 221551 RVA: 0x0073F3F6 File Offset: 0x0073D5F6
		// (set) Token: 0x06036170 RID: 221552 RVA: 0x0073F3FE File Offset: 0x0073D5FE
		public int SystemGameDialogConfigId { get; set; }

		// Token: 0x1700E1AC RID: 57772
		// (get) Token: 0x06036171 RID: 221553 RVA: 0x0073F407 File Offset: 0x0073D607
		// (set) Token: 0x06036172 RID: 221554 RVA: 0x0073F40F File Offset: 0x0073D60F
		public EMainCharacterSkin MainCharacterSkin { get; set; }

		// Token: 0x1700E1AD RID: 57773
		// (get) Token: 0x06036173 RID: 221555 RVA: 0x0073F418 File Offset: 0x0073D618
		// (set) Token: 0x06036174 RID: 221556 RVA: 0x0073F420 File Offset: 0x0073D620
		public IPlotFilmModeConfigT FilmModeConfig { get; set; }

		// Token: 0x1700E1AE RID: 57774
		// (get) Token: 0x06036175 RID: 221557 RVA: 0x0073F429 File Offset: 0x0073D629
		// (set) Token: 0x06036176 RID: 221558 RVA: 0x0073F431 File Offset: 0x0073D631
		public EOverrideAudioLevel OverrideAudioLevel { get; set; }

		// Token: 0x1700E1AF RID: 57775
		// (get) Token: 0x06036177 RID: 221559 RVA: 0x0073F43A File Offset: 0x0073D63A
		// (set) Token: 0x06036178 RID: 221560 RVA: 0x0073F442 File Offset: 0x0073D642
		public bool Mp4Mode { get; set; }

		// Token: 0x1700E1B0 RID: 57776
		// (get) Token: 0x06036179 RID: 221561 RVA: 0x0073F44B File Offset: 0x0073D64B
		// (set) Token: 0x0603617A RID: 221562 RVA: 0x0073F453 File Offset: 0x0073D653
		public IEntityControlConfigT EntityControlConfig { get; set; }

		// Token: 0x1700E1B1 RID: 57777
		// (get) Token: 0x0603617B RID: 221563 RVA: 0x0073F45C File Offset: 0x0073D65C
		// (set) Token: 0x0603617C RID: 221564 RVA: 0x0073F464 File Offset: 0x0073D664
		public IVisualNovelConfigT VisualNovelConfig { get; set; }

		// Token: 0x1700E1B2 RID: 57778
		// (get) Token: 0x0603617D RID: 221565 RVA: 0x0073F46D File Offset: 0x0073D66D
		// (set) Token: 0x0603617E RID: 221566 RVA: 0x0073F475 File Offset: 0x0073D675
		public IPlotModeUiStyleLevelDT UiStyle { get; set; }

		// Token: 0x1700E1B3 RID: 57779
		// (get) Token: 0x0603617F RID: 221567 RVA: 0x0073F47E File Offset: 0x0073D67E
		// (set) Token: 0x06036180 RID: 221568 RVA: 0x0073F486 File Offset: 0x0073D686
		public IPlotAudioConfigT AudioConfig { get; set; }

		// Token: 0x1700E1B4 RID: 57780
		// (get) Token: 0x06036181 RID: 221569 RVA: 0x0073F48F File Offset: 0x0073D68F
		// (set) Token: 0x06036182 RID: 221570 RVA: 0x0073F497 File Offset: 0x0073D697
		public ushort NullMask { get; set; }

		// Token: 0x06036183 RID: 221571 RVA: 0x0073F4A0 File Offset: 0x0073D6A0
		public ISetPlotModeT()
		{
			this.Mode = null;
			this.IsSwitchMainRole = false;
			this.UseFlowCamera = false;
			this.Interruptible = false;
			this.NoSkip = false;
			this.DisableAutoFadeOut = false;
			this.WaitForPlayerMotionEnd = false;
			this.NoUiEnterAnimation = false;
			this.FastFadeIn = null;
			this.KeepMainRolePose = false;
			this.PromptStyle = null;
			this.SubtitleStyle = null;
			this.PhoneMessageConfig = null;
			this.SystemGameDialogConfigId = 0;
			this.MainCharacterSkin = EMainCharacterSkin.Uniform;
			this.FilmModeConfig = null;
			this.OverrideAudioLevel = EOverrideAudioLevel.LevelA;
			this.Mp4Mode = false;
			this.EntityControlConfig = null;
			this.VisualNovelConfig = null;
			this.UiStyle = null;
			this.AudioConfig = null;
			this.NullMask = 0;
		}
	}
}
