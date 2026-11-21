using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243C RID: 9276
	[NullableContext(2)]
	[Nullable(0)]
	public class SetPlotMode_SetValue
	{
		// Token: 0x040077C6 RID: 30662
		[Nullable(0)]
		public string Mode;

		// Token: 0x040077C7 RID: 30663
		public bool? IsSwitchMainRole;

		// Token: 0x040077C8 RID: 30664
		public bool? UseFlowCamera;

		// Token: 0x040077C9 RID: 30665
		public bool? Interruptible;

		// Token: 0x040077CA RID: 30666
		public bool? NoSkip;

		// Token: 0x040077CB RID: 30667
		public bool? DisableAutoFadeOut;

		// Token: 0x040077CC RID: 30668
		public bool? WaitForPlayerMotionEnd;

		// Token: 0x040077CD RID: 30669
		public bool? NoUiEnterAnimation;

		// Token: 0x040077CE RID: 30670
		public FadeInScreen FastFadeIn;

		// Token: 0x040077CF RID: 30671
		public bool? KeepMainRolePose;

		// Token: 0x040077D0 RID: 30672
		public IPromptStyleBase PromptStyle;

		// Token: 0x040077D1 RID: 30673
		public ISubtitleStyleBase SubtitleStyle;

		// Token: 0x040077D2 RID: 30674
		public IPhoneMessageConfig PhoneMessageConfig;

		// Token: 0x040077D3 RID: 30675
		public int? SystemGameDialogConfigId;

		// Token: 0x040077D4 RID: 30676
		public EMainCharacterSkin? MainCharacterSkin;

		// Token: 0x040077D5 RID: 30677
		public IPlotFilmModeConfig FilmModeConfig;

		// Token: 0x040077D6 RID: 30678
		public EOverrideAudioLevel? OverrideAudioLevel;

		// Token: 0x040077D7 RID: 30679
		public bool? Mp4Mode;

		// Token: 0x040077D8 RID: 30680
		public IEntityControlConfig EntityControlConfig;

		// Token: 0x040077D9 RID: 30681
		public IVisualNovelConfig VisualNovelConfig;

		// Token: 0x040077DA RID: 30682
		public IPlotModeUiStyleLevelD UiStyle;

		// Token: 0x040077DB RID: 30683
		public IPlotAudioConfig AudioConfig;
	}
}
