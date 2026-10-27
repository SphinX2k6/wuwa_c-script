using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D0 RID: 8656
	[NullableContext(2)]
	[Nullable(0)]
	public class SetPlotMode : ActionParams
	{
		// Token: 0x0600BE17 RID: 48663 RVA: 0x001B5A10 File Offset: 0x001B3C10
		[NullableContext(1)]
		private SetPlotMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetPlotMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetPlotMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetPlotMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE18 RID: 48664 RVA: 0x001B5A48 File Offset: 0x001B3C48
		[NullableContext(1)]
		public static SetPlotMode Create([Nullable(2)] SetPlotMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPlotMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE19 RID: 48665 RVA: 0x001B5A5B File Offset: 0x001B3C5B
		[NullableContext(1)]
		public static SetPlotMode CreateFromSetValue([Nullable(2)] SetPlotMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetPlotMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE1A RID: 48666 RVA: 0x001B5A70 File Offset: 0x001B3C70
		[NullableContext(1)]
		public SetPlotMode_SetValue ToSetValue()
		{
			return new SetPlotMode_SetValue
			{
				Mode = this.Mode,
				IsSwitchMainRole = this.IsSwitchMainRole,
				UseFlowCamera = this.UseFlowCamera,
				Interruptible = this.Interruptible,
				NoSkip = this.NoSkip,
				DisableAutoFadeOut = this.DisableAutoFadeOut,
				WaitForPlayerMotionEnd = this.WaitForPlayerMotionEnd,
				NoUiEnterAnimation = this.NoUiEnterAnimation,
				FastFadeIn = this.FastFadeIn,
				KeepMainRolePose = this.KeepMainRolePose,
				PromptStyle = this.PromptStyle,
				SubtitleStyle = this.SubtitleStyle,
				PhoneMessageConfig = this.PhoneMessageConfig,
				SystemGameDialogConfigId = this.SystemGameDialogConfigId,
				MainCharacterSkin = this.MainCharacterSkin,
				FilmModeConfig = this.FilmModeConfig,
				OverrideAudioLevel = this.OverrideAudioLevel,
				Mp4Mode = this.Mp4Mode,
				EntityControlConfig = this.EntityControlConfig,
				VisualNovelConfig = this.VisualNovelConfig,
				UiStyle = this.UiStyle,
				AudioConfig = this.AudioConfig
			};
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x0600BE1B RID: 48667 RVA: 0x001B5B8A File Offset: 0x001B3D8A
		// (set) Token: 0x0600BE1C RID: 48668 RVA: 0x001B5BB5 File Offset: 0x001B3DB5
		[Nullable(1)]
		public virtual string Mode
		{
			[NullableContext(1)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mode;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mode;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().Mode = value;
			}
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x0600BE1D RID: 48669 RVA: 0x001B5BC4 File Offset: 0x001B3DC4
		// (set) Token: 0x0600BE1E RID: 48670 RVA: 0x001B5BFE File Offset: 0x001B3DFE
		public virtual bool? IsSwitchMainRole
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSwitchMainRole;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSwitchMainRole;
			}
			set
			{
				this.GetOrCreatePoco().IsSwitchMainRole = value;
			}
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x0600BE1F RID: 48671 RVA: 0x001B5C0C File Offset: 0x001B3E0C
		// (set) Token: 0x0600BE20 RID: 48672 RVA: 0x001B5C46 File Offset: 0x001B3E46
		public virtual bool? UseFlowCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseFlowCamera;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseFlowCamera;
			}
			set
			{
				this.GetOrCreatePoco().UseFlowCamera = value;
			}
		}

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x0600BE21 RID: 48673 RVA: 0x001B5C54 File Offset: 0x001B3E54
		// (set) Token: 0x0600BE22 RID: 48674 RVA: 0x001B5C8E File Offset: 0x001B3E8E
		public virtual bool? Interruptible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Interruptible;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Interruptible;
			}
			set
			{
				this.GetOrCreatePoco().Interruptible = value;
			}
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x0600BE23 RID: 48675 RVA: 0x001B5C9C File Offset: 0x001B3E9C
		// (set) Token: 0x0600BE24 RID: 48676 RVA: 0x001B5CD6 File Offset: 0x001B3ED6
		public virtual bool? NoSkip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NoSkip;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NoSkip;
			}
			set
			{
				this.GetOrCreatePoco().NoSkip = value;
			}
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x0600BE25 RID: 48677 RVA: 0x001B5CE4 File Offset: 0x001B3EE4
		// (set) Token: 0x0600BE26 RID: 48678 RVA: 0x001B5D1E File Offset: 0x001B3F1E
		public virtual bool? DisableAutoFadeOut
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableAutoFadeOut;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableAutoFadeOut;
			}
			set
			{
				this.GetOrCreatePoco().DisableAutoFadeOut = value;
			}
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x0600BE27 RID: 48679 RVA: 0x001B5D2C File Offset: 0x001B3F2C
		// (set) Token: 0x0600BE28 RID: 48680 RVA: 0x001B5D66 File Offset: 0x001B3F66
		public virtual bool? WaitForPlayerMotionEnd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WaitForPlayerMotionEnd;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WaitForPlayerMotionEnd;
			}
			set
			{
				this.GetOrCreatePoco().WaitForPlayerMotionEnd = value;
			}
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x0600BE29 RID: 48681 RVA: 0x001B5D74 File Offset: 0x001B3F74
		// (set) Token: 0x0600BE2A RID: 48682 RVA: 0x001B5DAE File Offset: 0x001B3FAE
		public virtual bool? NoUiEnterAnimation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NoUiEnterAnimation;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NoUiEnterAnimation;
			}
			set
			{
				this.GetOrCreatePoco().NoUiEnterAnimation = value;
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x0600BE2B RID: 48683 RVA: 0x001B5DBC File Offset: 0x001B3FBC
		// (set) Token: 0x0600BE2C RID: 48684 RVA: 0x001B5E1D File Offset: 0x001B401D
		public virtual FadeInScreen FastFadeIn
		{
			get
			{
				if (this._FastFadeInInited)
				{
					return this._FastFadeInCache;
				}
				this._FastFadeInInited = true;
				if (this.FbInstance != null)
				{
					this._FastFadeInCache = FadeInScreen.Create(this.FbInstance.FastFadeIn);
				}
				else
				{
					SetPlotMode_SetValue pocoInterface = this.PocoInterface;
					this._FastFadeInCache = ((pocoInterface != null) ? pocoInterface.FastFadeIn : null);
				}
				return this._FastFadeInCache;
			}
			set
			{
				this.GetOrCreatePoco().FastFadeIn = value;
				this._FastFadeInInited = false;
			}
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x0600BE2D RID: 48685 RVA: 0x001B5E34 File Offset: 0x001B4034
		// (set) Token: 0x0600BE2E RID: 48686 RVA: 0x001B5E6E File Offset: 0x001B406E
		public virtual bool? KeepMainRolePose
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepMainRolePose;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepMainRolePose;
			}
			set
			{
				this.GetOrCreatePoco().KeepMainRolePose = value;
			}
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x0600BE2F RID: 48687 RVA: 0x001B5E7C File Offset: 0x001B407C
		// (set) Token: 0x0600BE30 RID: 48688 RVA: 0x001B5EA3 File Offset: 0x001B40A3
		public virtual IPromptStyleBase PromptStyle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PromptStyle;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PromptStyle;
			}
			set
			{
				this.GetOrCreatePoco().PromptStyle = value;
			}
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x0600BE31 RID: 48689 RVA: 0x001B5EB1 File Offset: 0x001B40B1
		// (set) Token: 0x0600BE32 RID: 48690 RVA: 0x001B5ED8 File Offset: 0x001B40D8
		public virtual ISubtitleStyleBase SubtitleStyle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubtitleStyle;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SubtitleStyle;
			}
			set
			{
				this.GetOrCreatePoco().SubtitleStyle = value;
			}
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0600BE33 RID: 48691 RVA: 0x001B5EE8 File Offset: 0x001B40E8
		// (set) Token: 0x0600BE34 RID: 48692 RVA: 0x001B5F49 File Offset: 0x001B4149
		public virtual IPhoneMessageConfig PhoneMessageConfig
		{
			get
			{
				if (this._PhoneMessageConfigInited)
				{
					return this._PhoneMessageConfigCache;
				}
				this._PhoneMessageConfigInited = true;
				if (this.FbInstance != null)
				{
					this._PhoneMessageConfigCache = IPhoneMessageConfig.Create(this.FbInstance.PhoneMessageConfig);
				}
				else
				{
					SetPlotMode_SetValue pocoInterface = this.PocoInterface;
					this._PhoneMessageConfigCache = ((pocoInterface != null) ? pocoInterface.PhoneMessageConfig : null);
				}
				return this._PhoneMessageConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().PhoneMessageConfig = value;
				this._PhoneMessageConfigInited = false;
			}
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0600BE35 RID: 48693 RVA: 0x001B5F60 File Offset: 0x001B4160
		// (set) Token: 0x0600BE36 RID: 48694 RVA: 0x001B5F9A File Offset: 0x001B419A
		public virtual int? SystemGameDialogConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SystemGameDialogConfigId;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SystemGameDialogConfigId;
			}
			set
			{
				this.GetOrCreatePoco().SystemGameDialogConfigId = value;
			}
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0600BE37 RID: 48695 RVA: 0x001B5FA8 File Offset: 0x001B41A8
		// (set) Token: 0x0600BE38 RID: 48696 RVA: 0x001B5FE2 File Offset: 0x001B41E2
		public virtual EMainCharacterSkin? MainCharacterSkin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MainCharacterSkin;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MainCharacterSkin;
			}
			set
			{
				this.GetOrCreatePoco().MainCharacterSkin = value;
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0600BE39 RID: 48697 RVA: 0x001B5FF0 File Offset: 0x001B41F0
		// (set) Token: 0x0600BE3A RID: 48698 RVA: 0x001B6051 File Offset: 0x001B4251
		public virtual IPlotFilmModeConfig FilmModeConfig
		{
			get
			{
				if (this._FilmModeConfigInited)
				{
					return this._FilmModeConfigCache;
				}
				this._FilmModeConfigInited = true;
				if (this.FbInstance != null)
				{
					this._FilmModeConfigCache = IPlotFilmModeConfig.Create(this.FbInstance.FilmModeConfig);
				}
				else
				{
					SetPlotMode_SetValue pocoInterface = this.PocoInterface;
					this._FilmModeConfigCache = ((pocoInterface != null) ? pocoInterface.FilmModeConfig : null);
				}
				return this._FilmModeConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().FilmModeConfig = value;
				this._FilmModeConfigInited = false;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0600BE3B RID: 48699 RVA: 0x001B6068 File Offset: 0x001B4268
		// (set) Token: 0x0600BE3C RID: 48700 RVA: 0x001B60A2 File Offset: 0x001B42A2
		public virtual EOverrideAudioLevel? OverrideAudioLevel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OverrideAudioLevel;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OverrideAudioLevel;
			}
			set
			{
				this.GetOrCreatePoco().OverrideAudioLevel = value;
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0600BE3D RID: 48701 RVA: 0x001B60B0 File Offset: 0x001B42B0
		// (set) Token: 0x0600BE3E RID: 48702 RVA: 0x001B60EA File Offset: 0x001B42EA
		public virtual bool? Mp4Mode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mp4Mode;
				}
				SetPlotMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Mp4Mode;
			}
			set
			{
				this.GetOrCreatePoco().Mp4Mode = value;
			}
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0600BE3F RID: 48703 RVA: 0x001B60F8 File Offset: 0x001B42F8
		// (set) Token: 0x0600BE40 RID: 48704 RVA: 0x001B6159 File Offset: 0x001B4359
		public virtual IEntityControlConfig EntityControlConfig
		{
			get
			{
				if (this._EntityControlConfigInited)
				{
					return this._EntityControlConfigCache;
				}
				this._EntityControlConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EntityControlConfigCache = IEntityControlConfig.Create(this.FbInstance.EntityControlConfig);
				}
				else
				{
					SetPlotMode_SetValue pocoInterface = this.PocoInterface;
					this._EntityControlConfigCache = ((pocoInterface != null) ? pocoInterface.EntityControlConfig : null);
				}
				return this._EntityControlConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().EntityControlConfig = value;
				this._EntityControlConfigInited = false;
			}
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x0600BE41 RID: 48705 RVA: 0x001B6170 File Offset: 0x001B4370
		// (set) Token: 0x0600BE42 RID: 48706 RVA: 0x001B61D1 File Offset: 0x001B43D1
		public virtual IVisualNovelConfig VisualNovelConfig
		{
			get
			{
				if (this._VisualNovelConfigInited)
				{
					return this._VisualNovelConfigCache;
				}
				this._VisualNovelConfigInited = true;
				if (this.FbInstance != null)
				{
					this._VisualNovelConfigCache = IVisualNovelConfig.Create(this.FbInstance.VisualNovelConfig);
				}
				else
				{
					SetPlotMode_SetValue pocoInterface = this.PocoInterface;
					this._VisualNovelConfigCache = ((pocoInterface != null) ? pocoInterface.VisualNovelConfig : null);
				}
				return this._VisualNovelConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().VisualNovelConfig = value;
				this._VisualNovelConfigInited = false;
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x0600BE43 RID: 48707 RVA: 0x001B61E8 File Offset: 0x001B43E8
		// (set) Token: 0x0600BE44 RID: 48708 RVA: 0x001B6249 File Offset: 0x001B4449
		public virtual IPlotModeUiStyleLevelD UiStyle
		{
			get
			{
				if (this._UiStyleInited)
				{
					return this._UiStyleCache;
				}
				this._UiStyleInited = true;
				if (this.FbInstance != null)
				{
					this._UiStyleCache = IPlotModeUiStyleLevelD.Create(this.FbInstance.UiStyle);
				}
				else
				{
					SetPlotMode_SetValue pocoInterface = this.PocoInterface;
					this._UiStyleCache = ((pocoInterface != null) ? pocoInterface.UiStyle : null);
				}
				return this._UiStyleCache;
			}
			set
			{
				this.GetOrCreatePoco().UiStyle = value;
				this._UiStyleInited = false;
			}
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x0600BE45 RID: 48709 RVA: 0x001B6260 File Offset: 0x001B4460
		// (set) Token: 0x0600BE46 RID: 48710 RVA: 0x001B62C1 File Offset: 0x001B44C1
		public virtual IPlotAudioConfig AudioConfig
		{
			get
			{
				if (this._AudioConfigInited)
				{
					return this._AudioConfigCache;
				}
				this._AudioConfigInited = true;
				if (this.FbInstance != null)
				{
					this._AudioConfigCache = IPlotAudioConfig.Create(this.FbInstance.AudioConfig);
				}
				else
				{
					SetPlotMode_SetValue pocoInterface = this.PocoInterface;
					this._AudioConfigCache = ((pocoInterface != null) ? pocoInterface.AudioConfig : null);
				}
				return this._AudioConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().AudioConfig = value;
				this._AudioConfigInited = false;
			}
		}

		// Token: 0x0400716D RID: 29037
		protected new SetPlotMode FbInstance;

		// Token: 0x0400716E RID: 29038
		protected SetPlotMode_SetValue PocoInterface;

		// Token: 0x0400716F RID: 29039
		[Nullable(1)]
		private FadeInScreen _FastFadeInCache;

		// Token: 0x04007170 RID: 29040
		private bool _FastFadeInInited;

		// Token: 0x04007171 RID: 29041
		[Nullable(1)]
		private IPhoneMessageConfig _PhoneMessageConfigCache;

		// Token: 0x04007172 RID: 29042
		private bool _PhoneMessageConfigInited;

		// Token: 0x04007173 RID: 29043
		[Nullable(1)]
		private IPlotFilmModeConfig _FilmModeConfigCache;

		// Token: 0x04007174 RID: 29044
		private bool _FilmModeConfigInited;

		// Token: 0x04007175 RID: 29045
		[Nullable(1)]
		private IEntityControlConfig _EntityControlConfigCache;

		// Token: 0x04007176 RID: 29046
		private bool _EntityControlConfigInited;

		// Token: 0x04007177 RID: 29047
		[Nullable(1)]
		private IVisualNovelConfig _VisualNovelConfigCache;

		// Token: 0x04007178 RID: 29048
		private bool _VisualNovelConfigInited;

		// Token: 0x04007179 RID: 29049
		[Nullable(1)]
		private IPlotModeUiStyleLevelD _UiStyleCache;

		// Token: 0x0400717A RID: 29050
		private bool _UiStyleInited;

		// Token: 0x0400717B RID: 29051
		[Nullable(1)]
		private IPlotAudioConfig _AudioConfigCache;

		// Token: 0x0400717C RID: 29052
		private bool _AudioConfigInited;
	}
}
