using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D1 RID: 8657
	[NullableContext(2)]
	[Nullable(0)]
	public class SetPlotMode_SetValue
	{
		// Token: 0x0400717D RID: 29053
		[Nullable(1)]
		public string Mode;

		// Token: 0x0400717E RID: 29054
		public bool? IsSwitchMainRole;

		// Token: 0x0400717F RID: 29055
		public bool? UseFlowCamera;

		// Token: 0x04007180 RID: 29056
		public bool? Interruptible;

		// Token: 0x04007181 RID: 29057
		public bool? NoSkip;

		// Token: 0x04007182 RID: 29058
		public bool? DisableAutoFadeOut;

		// Token: 0x04007183 RID: 29059
		public bool? WaitForPlayerMotionEnd;

		// Token: 0x04007184 RID: 29060
		public bool? NoUiEnterAnimation;

		// Token: 0x04007185 RID: 29061
		public FadeInScreen FastFadeIn;

		// Token: 0x04007186 RID: 29062
		public bool? KeepMainRolePose;

		// Token: 0x04007187 RID: 29063
		public IPromptStyleBase PromptStyle;

		// Token: 0x04007188 RID: 29064
		public ISubtitleStyleBase SubtitleStyle;

		// Token: 0x04007189 RID: 29065
		public IPhoneMessageConfig PhoneMessageConfig;

		// Token: 0x0400718A RID: 29066
		public int? SystemGameDialogConfigId;

		// Token: 0x0400718B RID: 29067
		public EMainCharacterSkin? MainCharacterSkin;

		// Token: 0x0400718C RID: 29068
		public IPlotFilmModeConfig FilmModeConfig;

		// Token: 0x0400718D RID: 29069
		public EOverrideAudioLevel? OverrideAudioLevel;

		// Token: 0x0400718E RID: 29070
		public bool? Mp4Mode;

		// Token: 0x0400718F RID: 29071
		public IEntityControlConfig EntityControlConfig;

		// Token: 0x04007190 RID: 29072
		public IVisualNovelConfig VisualNovelConfig;

		// Token: 0x04007191 RID: 29073
		public IPlotModeUiStyleLevelD UiStyle;

		// Token: 0x04007192 RID: 29074
		public IPlotAudioConfig AudioConfig;
	}
}
