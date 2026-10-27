using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025D2 RID: 9682
	[NullableContext(2)]
	[Nullable(0)]
	public class SetPlotMode : ActionParams
	{
		// Token: 0x0600D99A RID: 55706 RVA: 0x00207269 File Offset: 0x00205469
		[NullableContext(1)]
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

		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x0600D99B RID: 55707 RVA: 0x00207288 File Offset: 0x00205488
		[Nullable(1)]
		public virtual string Mode
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Mode;
			}
		}

		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x0600D99C RID: 55708 RVA: 0x00207298 File Offset: 0x00205498
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

		// Token: 0x17003FBA RID: 16314
		// (get) Token: 0x0600D99D RID: 55709 RVA: 0x002072D0 File Offset: 0x002054D0
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

		// Token: 0x17003FBB RID: 16315
		// (get) Token: 0x0600D99E RID: 55710 RVA: 0x00207308 File Offset: 0x00205508
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

		// Token: 0x17003FBC RID: 16316
		// (get) Token: 0x0600D99F RID: 55711 RVA: 0x00207340 File Offset: 0x00205540
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

		// Token: 0x17003FBD RID: 16317
		// (get) Token: 0x0600D9A0 RID: 55712 RVA: 0x00207378 File Offset: 0x00205578
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

		// Token: 0x17003FBE RID: 16318
		// (get) Token: 0x0600D9A1 RID: 55713 RVA: 0x002073B0 File Offset: 0x002055B0
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

		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x0600D9A2 RID: 55714 RVA: 0x002073E8 File Offset: 0x002055E8
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

		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x0600D9A3 RID: 55715 RVA: 0x0020741F File Offset: 0x0020561F
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

		// Token: 0x17003FC1 RID: 16321
		// (get) Token: 0x0600D9A4 RID: 55716 RVA: 0x00207454 File Offset: 0x00205654
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

		// Token: 0x17003FC2 RID: 16322
		// (get) Token: 0x0600D9A5 RID: 55717 RVA: 0x0020748E File Offset: 0x0020568E
		[Nullable(1)]
		public virtual IPromptStyleBase PromptStyle
		{
			[NullableContext(1)]
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

		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x0600D9A6 RID: 55718 RVA: 0x002074BD File Offset: 0x002056BD
		[Nullable(1)]
		public virtual ISubtitleStyleBase SubtitleStyle
		{
			[NullableContext(1)]
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

		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x0600D9A7 RID: 55719 RVA: 0x002074EC File Offset: 0x002056EC
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

		// Token: 0x17003FC5 RID: 16325
		// (get) Token: 0x0600D9A8 RID: 55720 RVA: 0x00207520 File Offset: 0x00205720
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

		// Token: 0x17003FC6 RID: 16326
		// (get) Token: 0x0600D9A9 RID: 55721 RVA: 0x0020755C File Offset: 0x0020575C
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

		// Token: 0x17003FC7 RID: 16327
		// (get) Token: 0x0600D9AA RID: 55722 RVA: 0x00207596 File Offset: 0x00205796
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

		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x0600D9AB RID: 55723 RVA: 0x002075CC File Offset: 0x002057CC
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

		// Token: 0x17003FC9 RID: 16329
		// (get) Token: 0x0600D9AC RID: 55724 RVA: 0x00207608 File Offset: 0x00205808
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

		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x0600D9AD RID: 55725 RVA: 0x00207642 File Offset: 0x00205842
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

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x0600D9AE RID: 55726 RVA: 0x00207676 File Offset: 0x00205876
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

		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x0600D9AF RID: 55727 RVA: 0x002076AA File Offset: 0x002058AA
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

		// Token: 0x17003FCD RID: 16333
		// (get) Token: 0x0600D9B0 RID: 55728 RVA: 0x002076DE File Offset: 0x002058DE
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

		// Token: 0x040078D4 RID: 30932
		private ISetPlotMode Instance;

		// Token: 0x040078D5 RID: 30933
		private FadeInScreen _FastFadeInCache;

		// Token: 0x040078D6 RID: 30934
		private bool _FastFadeInInited;

		// Token: 0x040078D7 RID: 30935
		[Nullable(1)]
		private IPromptStyleBase _PromptStyleCache;

		// Token: 0x040078D8 RID: 30936
		private bool _PromptStyleInited;

		// Token: 0x040078D9 RID: 30937
		[Nullable(1)]
		private ISubtitleStyleBase _SubtitleStyleCache;

		// Token: 0x040078DA RID: 30938
		private bool _SubtitleStyleInited;

		// Token: 0x040078DB RID: 30939
		private IPhoneMessageConfig _PhoneMessageConfigCache;

		// Token: 0x040078DC RID: 30940
		private bool _PhoneMessageConfigInited;

		// Token: 0x040078DD RID: 30941
		private IPlotFilmModeConfig _FilmModeConfigCache;

		// Token: 0x040078DE RID: 30942
		private bool _FilmModeConfigInited;

		// Token: 0x040078DF RID: 30943
		private IEntityControlConfig _EntityControlConfigCache;

		// Token: 0x040078E0 RID: 30944
		private bool _EntityControlConfigInited;

		// Token: 0x040078E1 RID: 30945
		private IVisualNovelConfig _VisualNovelConfigCache;

		// Token: 0x040078E2 RID: 30946
		private bool _VisualNovelConfigInited;

		// Token: 0x040078E3 RID: 30947
		private IPlotModeUiStyleLevelD _UiStyleCache;

		// Token: 0x040078E4 RID: 30948
		private bool _UiStyleInited;

		// Token: 0x040078E5 RID: 30949
		private IPlotAudioConfig _AudioConfigCache;

		// Token: 0x040078E6 RID: 30950
		private bool _AudioConfigInited;
	}
}
