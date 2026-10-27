using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007059 RID: 28761
	public class ISetPlotModeT
	{
		// Token: 0x1700D5BB RID: 54715
		// (get) Token: 0x06032EB4 RID: 208564 RVA: 0x006DED65 File Offset: 0x006DCF65
		// (set) Token: 0x06032EB5 RID: 208565 RVA: 0x006DED6D File Offset: 0x006DCF6D
		public string Mode { get; set; }

		// Token: 0x1700D5BC RID: 54716
		// (get) Token: 0x06032EB6 RID: 208566 RVA: 0x006DED76 File Offset: 0x006DCF76
		// (set) Token: 0x06032EB7 RID: 208567 RVA: 0x006DED7E File Offset: 0x006DCF7E
		public bool IsSwitchMainRole { get; set; }

		// Token: 0x1700D5BD RID: 54717
		// (get) Token: 0x06032EB8 RID: 208568 RVA: 0x006DED87 File Offset: 0x006DCF87
		// (set) Token: 0x06032EB9 RID: 208569 RVA: 0x006DED8F File Offset: 0x006DCF8F
		public bool UseFlowCamera { get; set; }

		// Token: 0x1700D5BE RID: 54718
		// (get) Token: 0x06032EBA RID: 208570 RVA: 0x006DED98 File Offset: 0x006DCF98
		// (set) Token: 0x06032EBB RID: 208571 RVA: 0x006DEDA0 File Offset: 0x006DCFA0
		public bool Interruptible { get; set; }

		// Token: 0x1700D5BF RID: 54719
		// (get) Token: 0x06032EBC RID: 208572 RVA: 0x006DEDA9 File Offset: 0x006DCFA9
		// (set) Token: 0x06032EBD RID: 208573 RVA: 0x006DEDB1 File Offset: 0x006DCFB1
		public bool NoSkip { get; set; }

		// Token: 0x1700D5C0 RID: 54720
		// (get) Token: 0x06032EBE RID: 208574 RVA: 0x006DEDBA File Offset: 0x006DCFBA
		// (set) Token: 0x06032EBF RID: 208575 RVA: 0x006DEDC2 File Offset: 0x006DCFC2
		public bool DisableAutoFadeOut { get; set; }

		// Token: 0x1700D5C1 RID: 54721
		// (get) Token: 0x06032EC0 RID: 208576 RVA: 0x006DEDCB File Offset: 0x006DCFCB
		// (set) Token: 0x06032EC1 RID: 208577 RVA: 0x006DEDD3 File Offset: 0x006DCFD3
		public bool WaitForPlayerMotionEnd { get; set; }

		// Token: 0x1700D5C2 RID: 54722
		// (get) Token: 0x06032EC2 RID: 208578 RVA: 0x006DEDDC File Offset: 0x006DCFDC
		// (set) Token: 0x06032EC3 RID: 208579 RVA: 0x006DEDE4 File Offset: 0x006DCFE4
		public bool NoUiEnterAnimation { get; set; }

		// Token: 0x1700D5C3 RID: 54723
		// (get) Token: 0x06032EC4 RID: 208580 RVA: 0x006DEDED File Offset: 0x006DCFED
		// (set) Token: 0x06032EC5 RID: 208581 RVA: 0x006DEDF5 File Offset: 0x006DCFF5
		public IFadeInScreenT FastFadeIn { get; set; }

		// Token: 0x1700D5C4 RID: 54724
		// (get) Token: 0x06032EC6 RID: 208582 RVA: 0x006DEDFE File Offset: 0x006DCFFE
		// (set) Token: 0x06032EC7 RID: 208583 RVA: 0x006DEE06 File Offset: 0x006DD006
		public bool KeepMainRolePose { get; set; }

		// Token: 0x1700D5C5 RID: 54725
		// (get) Token: 0x06032EC8 RID: 208584 RVA: 0x006DEE0F File Offset: 0x006DD00F
		// (set) Token: 0x06032EC9 RID: 208585 RVA: 0x006DEE17 File Offset: 0x006DD017
		public TPromptStyleUnion PromptStyle { get; set; }

		// Token: 0x1700D5C6 RID: 54726
		// (get) Token: 0x06032ECA RID: 208586 RVA: 0x006DEE20 File Offset: 0x006DD020
		// (set) Token: 0x06032ECB RID: 208587 RVA: 0x006DEE28 File Offset: 0x006DD028
		public TSubtitleStyleUnion SubtitleStyle { get; set; }

		// Token: 0x1700D5C7 RID: 54727
		// (get) Token: 0x06032ECC RID: 208588 RVA: 0x006DEE31 File Offset: 0x006DD031
		// (set) Token: 0x06032ECD RID: 208589 RVA: 0x006DEE39 File Offset: 0x006DD039
		public IPhoneMessageConfigT PhoneMessageConfig { get; set; }

		// Token: 0x1700D5C8 RID: 54728
		// (get) Token: 0x06032ECE RID: 208590 RVA: 0x006DEE42 File Offset: 0x006DD042
		// (set) Token: 0x06032ECF RID: 208591 RVA: 0x006DEE4A File Offset: 0x006DD04A
		public int SystemGameDialogConfigId { get; set; }

		// Token: 0x1700D5C9 RID: 54729
		// (get) Token: 0x06032ED0 RID: 208592 RVA: 0x006DEE53 File Offset: 0x006DD053
		// (set) Token: 0x06032ED1 RID: 208593 RVA: 0x006DEE5B File Offset: 0x006DD05B
		public EMainCharacterSkin MainCharacterSkin { get; set; }

		// Token: 0x1700D5CA RID: 54730
		// (get) Token: 0x06032ED2 RID: 208594 RVA: 0x006DEE64 File Offset: 0x006DD064
		// (set) Token: 0x06032ED3 RID: 208595 RVA: 0x006DEE6C File Offset: 0x006DD06C
		public IPlotFilmModeConfigT FilmModeConfig { get; set; }

		// Token: 0x1700D5CB RID: 54731
		// (get) Token: 0x06032ED4 RID: 208596 RVA: 0x006DEE75 File Offset: 0x006DD075
		// (set) Token: 0x06032ED5 RID: 208597 RVA: 0x006DEE7D File Offset: 0x006DD07D
		public EOverrideAudioLevel OverrideAudioLevel { get; set; }

		// Token: 0x1700D5CC RID: 54732
		// (get) Token: 0x06032ED6 RID: 208598 RVA: 0x006DEE86 File Offset: 0x006DD086
		// (set) Token: 0x06032ED7 RID: 208599 RVA: 0x006DEE8E File Offset: 0x006DD08E
		public bool Mp4Mode { get; set; }

		// Token: 0x1700D5CD RID: 54733
		// (get) Token: 0x06032ED8 RID: 208600 RVA: 0x006DEE97 File Offset: 0x006DD097
		// (set) Token: 0x06032ED9 RID: 208601 RVA: 0x006DEE9F File Offset: 0x006DD09F
		public IEntityControlConfigT EntityControlConfig { get; set; }

		// Token: 0x1700D5CE RID: 54734
		// (get) Token: 0x06032EDA RID: 208602 RVA: 0x006DEEA8 File Offset: 0x006DD0A8
		// (set) Token: 0x06032EDB RID: 208603 RVA: 0x006DEEB0 File Offset: 0x006DD0B0
		public IVisualNovelConfigT VisualNovelConfig { get; set; }

		// Token: 0x1700D5CF RID: 54735
		// (get) Token: 0x06032EDC RID: 208604 RVA: 0x006DEEB9 File Offset: 0x006DD0B9
		// (set) Token: 0x06032EDD RID: 208605 RVA: 0x006DEEC1 File Offset: 0x006DD0C1
		public IPlotModeUiStyleLevelDT UiStyle { get; set; }

		// Token: 0x1700D5D0 RID: 54736
		// (get) Token: 0x06032EDE RID: 208606 RVA: 0x006DEECA File Offset: 0x006DD0CA
		// (set) Token: 0x06032EDF RID: 208607 RVA: 0x006DEED2 File Offset: 0x006DD0D2
		public IPlotAudioConfigT AudioConfig { get; set; }

		// Token: 0x1700D5D1 RID: 54737
		// (get) Token: 0x06032EE0 RID: 208608 RVA: 0x006DEEDB File Offset: 0x006DD0DB
		// (set) Token: 0x06032EE1 RID: 208609 RVA: 0x006DEEE3 File Offset: 0x006DD0E3
		public ushort NullMask { get; set; }

		// Token: 0x06032EE2 RID: 208610 RVA: 0x006DEEEC File Offset: 0x006DD0EC
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
