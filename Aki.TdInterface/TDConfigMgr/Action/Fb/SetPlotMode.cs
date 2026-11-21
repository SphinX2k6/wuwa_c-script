using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002891 RID: 10385
	[NullableContext(2)]
	[Nullable(0)]
	public class SetPlotMode : ActionParams
	{
		// Token: 0x0600E762 RID: 59234 RVA: 0x0022391D File Offset: 0x00221B1D
		[NullableContext(0)]
		public static SetPlotMode Create(ISetPlotMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPlotMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042EE RID: 17134
		// (get) Token: 0x0600E763 RID: 59235 RVA: 0x0022393C File Offset: 0x00221B3C
		[Nullable(0)]
		public virtual string Mode
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Mode;
			}
		}

		// Token: 0x170042EF RID: 17135
		// (get) Token: 0x0600E764 RID: 59236 RVA: 0x0022394C File Offset: 0x00221B4C
		public virtual bool? IsSwitchMainRole
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSwitchMainRole);
			}
		}

		// Token: 0x170042F0 RID: 17136
		// (get) Token: 0x0600E765 RID: 59237 RVA: 0x00223984 File Offset: 0x00221B84
		public virtual bool? UseFlowCamera
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseFlowCamera);
			}
		}

		// Token: 0x170042F1 RID: 17137
		// (get) Token: 0x0600E766 RID: 59238 RVA: 0x002239BC File Offset: 0x00221BBC
		public virtual bool? Interruptible
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Interruptible);
			}
		}

		// Token: 0x170042F2 RID: 17138
		// (get) Token: 0x0600E767 RID: 59239 RVA: 0x002239F4 File Offset: 0x00221BF4
		public virtual bool? NoSkip
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.NoSkip);
			}
		}

		// Token: 0x170042F3 RID: 17139
		// (get) Token: 0x0600E768 RID: 59240 RVA: 0x00223A2C File Offset: 0x00221C2C
		public virtual bool? DisableAutoFadeOut
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableAutoFadeOut);
			}
		}

		// Token: 0x170042F4 RID: 17140
		// (get) Token: 0x0600E769 RID: 59241 RVA: 0x00223A64 File Offset: 0x00221C64
		public virtual bool? WaitForPlayerMotionEnd
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.WaitForPlayerMotionEnd);
			}
		}

		// Token: 0x170042F5 RID: 17141
		// (get) Token: 0x0600E76A RID: 59242 RVA: 0x00223A9C File Offset: 0x00221C9C
		public virtual bool? NoUiEnterAnimation
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.NoUiEnterAnimation);
			}
		}

		// Token: 0x170042F6 RID: 17142
		// (get) Token: 0x0600E76B RID: 59243 RVA: 0x00223AD3 File Offset: 0x00221CD3
		public virtual FadeInScreen FastFadeIn
		{
			get
			{
				if (this._FastFadeInInited)
				{
					return this._FastFadeInCache;
				}
				this._FastFadeInInited = true;
				this._FastFadeInCache = FadeInScreen.Create(this.Instance.FastFadeIn);
				return this._FastFadeInCache;
			}
		}

		// Token: 0x170042F7 RID: 17143
		// (get) Token: 0x0600E76C RID: 59244 RVA: 0x00223B08 File Offset: 0x00221D08
		public virtual bool? KeepMainRolePose
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepMainRolePose);
			}
		}

		// Token: 0x170042F8 RID: 17144
		// (get) Token: 0x0600E76D RID: 59245 RVA: 0x00223B42 File Offset: 0x00221D42
		[Nullable(0)]
		public virtual IPromptStyleBase PromptStyle
		{
			[NullableContext(0)]
			get
			{
				if (this._PromptStyleInited)
				{
					return this._PromptStyleCache;
				}
				this._PromptStyleInited = true;
				this._PromptStyleCache = ActionReadHelper.ReadSetPlotMode_PromptStyle(this.Instance);
				return this._PromptStyleCache;
			}
		}

		// Token: 0x170042F9 RID: 17145
		// (get) Token: 0x0600E76E RID: 59246 RVA: 0x00223B71 File Offset: 0x00221D71
		[Nullable(0)]
		public virtual ISubtitleStyleBase SubtitleStyle
		{
			[NullableContext(0)]
			get
			{
				if (this._SubtitleStyleInited)
				{
					return this._SubtitleStyleCache;
				}
				this._SubtitleStyleInited = true;
				this._SubtitleStyleCache = ActionReadHelper.ReadSetPlotMode_SubtitleStyle(this.Instance);
				return this._SubtitleStyleCache;
			}
		}

		// Token: 0x170042FA RID: 17146
		// (get) Token: 0x0600E76F RID: 59247 RVA: 0x00223BA0 File Offset: 0x00221DA0
		public virtual IPhoneMessageConfig PhoneMessageConfig
		{
			get
			{
				if (this._PhoneMessageConfigInited)
				{
					return this._PhoneMessageConfigCache;
				}
				this._PhoneMessageConfigInited = true;
				this._PhoneMessageConfigCache = IPhoneMessageConfig.Create(this.Instance.PhoneMessageConfig);
				return this._PhoneMessageConfigCache;
			}
		}

		// Token: 0x170042FB RID: 17147
		// (get) Token: 0x0600E770 RID: 59248 RVA: 0x00223BD4 File Offset: 0x00221DD4
		public virtual int? SystemGameDialogConfigId
		{
			get
			{
				if ((this.Instance.NullMask & 256) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SystemGameDialogConfigId);
			}
		}

		// Token: 0x170042FC RID: 17148
		// (get) Token: 0x0600E771 RID: 59249 RVA: 0x00223C10 File Offset: 0x00221E10
		public virtual EMainCharacterSkin? MainCharacterSkin
		{
			get
			{
				if ((this.Instance.NullMask & 512) == 0)
				{
					return null;
				}
				return new EMainCharacterSkin?((EMainCharacterSkin)this.Instance.MainCharacterSkin);
			}
		}

		// Token: 0x170042FD RID: 17149
		// (get) Token: 0x0600E772 RID: 59250 RVA: 0x00223C4A File Offset: 0x00221E4A
		public virtual IPlotFilmModeConfig FilmModeConfig
		{
			get
			{
				if (this._FilmModeConfigInited)
				{
					return this._FilmModeConfigCache;
				}
				this._FilmModeConfigInited = true;
				this._FilmModeConfigCache = IPlotFilmModeConfig.Create(this.Instance.FilmModeConfig);
				return this._FilmModeConfigCache;
			}
		}

		// Token: 0x170042FE RID: 17150
		// (get) Token: 0x0600E773 RID: 59251 RVA: 0x00223C80 File Offset: 0x00221E80
		public virtual EOverrideAudioLevel? OverrideAudioLevel
		{
			get
			{
				if ((this.Instance.NullMask & 1024) == 0)
				{
					return null;
				}
				return new EOverrideAudioLevel?((EOverrideAudioLevel)this.Instance.OverrideAudioLevel);
			}
		}

		// Token: 0x170042FF RID: 17151
		// (get) Token: 0x0600E774 RID: 59252 RVA: 0x00223CBC File Offset: 0x00221EBC
		public virtual bool? Mp4Mode
		{
			get
			{
				if ((this.Instance.NullMask & 2048) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Mp4Mode);
			}
		}

		// Token: 0x17004300 RID: 17152
		// (get) Token: 0x0600E775 RID: 59253 RVA: 0x00223CF6 File Offset: 0x00221EF6
		public virtual IEntityControlConfig EntityControlConfig
		{
			get
			{
				if (this._EntityControlConfigInited)
				{
					return this._EntityControlConfigCache;
				}
				this._EntityControlConfigInited = true;
				this._EntityControlConfigCache = IEntityControlConfig.Create(this.Instance.EntityControlConfig);
				return this._EntityControlConfigCache;
			}
		}

		// Token: 0x17004301 RID: 17153
		// (get) Token: 0x0600E776 RID: 59254 RVA: 0x00223D2A File Offset: 0x00221F2A
		public virtual IVisualNovelConfig VisualNovelConfig
		{
			get
			{
				if (this._VisualNovelConfigInited)
				{
					return this._VisualNovelConfigCache;
				}
				this._VisualNovelConfigInited = true;
				this._VisualNovelConfigCache = IVisualNovelConfig.Create(this.Instance.VisualNovelConfig);
				return this._VisualNovelConfigCache;
			}
		}

		// Token: 0x17004302 RID: 17154
		// (get) Token: 0x0600E777 RID: 59255 RVA: 0x00223D5E File Offset: 0x00221F5E
		public virtual IPlotModeUiStyleLevelD UiStyle
		{
			get
			{
				if (this._UiStyleInited)
				{
					return this._UiStyleCache;
				}
				this._UiStyleInited = true;
				this._UiStyleCache = IPlotModeUiStyleLevelD.Create(this.Instance.UiStyle);
				return this._UiStyleCache;
			}
		}

		// Token: 0x17004303 RID: 17155
		// (get) Token: 0x0600E778 RID: 59256 RVA: 0x00223D92 File Offset: 0x00221F92
		public virtual IPlotAudioConfig AudioConfig
		{
			get
			{
				if (this._AudioConfigInited)
				{
					return this._AudioConfigCache;
				}
				this._AudioConfigInited = true;
				this._AudioConfigCache = IPlotAudioConfig.Create(this.Instance.AudioConfig);
				return this._AudioConfigCache;
			}
		}

		// Token: 0x04007F6B RID: 32619
		private ISetPlotMode Instance;

		// Token: 0x04007F6C RID: 32620
		private FadeInScreen _FastFadeInCache;

		// Token: 0x04007F6D RID: 32621
		private bool _FastFadeInInited;

		// Token: 0x04007F6E RID: 32622
		[Nullable(0)]
		private IPromptStyleBase _PromptStyleCache;

		// Token: 0x04007F6F RID: 32623
		private bool _PromptStyleInited;

		// Token: 0x04007F70 RID: 32624
		[Nullable(0)]
		private ISubtitleStyleBase _SubtitleStyleCache;

		// Token: 0x04007F71 RID: 32625
		private bool _SubtitleStyleInited;

		// Token: 0x04007F72 RID: 32626
		private IPhoneMessageConfig _PhoneMessageConfigCache;

		// Token: 0x04007F73 RID: 32627
		private bool _PhoneMessageConfigInited;

		// Token: 0x04007F74 RID: 32628
		private IPlotFilmModeConfig _FilmModeConfigCache;

		// Token: 0x04007F75 RID: 32629
		private bool _FilmModeConfigInited;

		// Token: 0x04007F76 RID: 32630
		private IEntityControlConfig _EntityControlConfigCache;

		// Token: 0x04007F77 RID: 32631
		private bool _EntityControlConfigInited;

		// Token: 0x04007F78 RID: 32632
		private IVisualNovelConfig _VisualNovelConfigCache;

		// Token: 0x04007F79 RID: 32633
		private bool _VisualNovelConfigInited;

		// Token: 0x04007F7A RID: 32634
		private IPlotModeUiStyleLevelD _UiStyleCache;

		// Token: 0x04007F7B RID: 32635
		private bool _UiStyleInited;

		// Token: 0x04007F7C RID: 32636
		private IPlotAudioConfig _AudioConfigCache;

		// Token: 0x04007F7D RID: 32637
		private bool _AudioConfigInited;
	}
}
