using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243B RID: 9275
	[NullableContext(2)]
	[Nullable(0)]
	public class SetPlotMode : ActionParams
	{
		// Token: 0x0600C9D3 RID: 51667 RVA: 0x001CD09C File Offset: 0x001CB29C
		[NullableContext(0)]
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

		// Token: 0x0600C9D4 RID: 51668 RVA: 0x001CD0D4 File Offset: 0x001CB2D4
		[NullableContext(0)]
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

		// Token: 0x0600C9D5 RID: 51669 RVA: 0x001CD0E7 File Offset: 0x001CB2E7
		[NullableContext(0)]
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

		// Token: 0x0600C9D6 RID: 51670 RVA: 0x001CD0FC File Offset: 0x001CB2FC
		[NullableContext(0)]
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

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x0600C9D7 RID: 51671 RVA: 0x001CD216 File Offset: 0x001CB416
		// (set) Token: 0x0600C9D8 RID: 51672 RVA: 0x001CD241 File Offset: 0x001CB441
		[Nullable(0)]
		public virtual string Mode
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().Mode = value;
			}
		}

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x0600C9D9 RID: 51673 RVA: 0x001CD250 File Offset: 0x001CB450
		// (set) Token: 0x0600C9DA RID: 51674 RVA: 0x001CD28A File Offset: 0x001CB48A
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

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x0600C9DB RID: 51675 RVA: 0x001CD298 File Offset: 0x001CB498
		// (set) Token: 0x0600C9DC RID: 51676 RVA: 0x001CD2D2 File Offset: 0x001CB4D2
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

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x0600C9DD RID: 51677 RVA: 0x001CD2E0 File Offset: 0x001CB4E0
		// (set) Token: 0x0600C9DE RID: 51678 RVA: 0x001CD31A File Offset: 0x001CB51A
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

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x0600C9DF RID: 51679 RVA: 0x001CD328 File Offset: 0x001CB528
		// (set) Token: 0x0600C9E0 RID: 51680 RVA: 0x001CD362 File Offset: 0x001CB562
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

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x0600C9E1 RID: 51681 RVA: 0x001CD370 File Offset: 0x001CB570
		// (set) Token: 0x0600C9E2 RID: 51682 RVA: 0x001CD3AA File Offset: 0x001CB5AA
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

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x0600C9E3 RID: 51683 RVA: 0x001CD3B8 File Offset: 0x001CB5B8
		// (set) Token: 0x0600C9E4 RID: 51684 RVA: 0x001CD3F2 File Offset: 0x001CB5F2
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

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x0600C9E5 RID: 51685 RVA: 0x001CD400 File Offset: 0x001CB600
		// (set) Token: 0x0600C9E6 RID: 51686 RVA: 0x001CD43A File Offset: 0x001CB63A
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

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x0600C9E7 RID: 51687 RVA: 0x001CD448 File Offset: 0x001CB648
		// (set) Token: 0x0600C9E8 RID: 51688 RVA: 0x001CD4A9 File Offset: 0x001CB6A9
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

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x0600C9E9 RID: 51689 RVA: 0x001CD4C0 File Offset: 0x001CB6C0
		// (set) Token: 0x0600C9EA RID: 51690 RVA: 0x001CD4FA File Offset: 0x001CB6FA
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

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x0600C9EB RID: 51691 RVA: 0x001CD508 File Offset: 0x001CB708
		// (set) Token: 0x0600C9EC RID: 51692 RVA: 0x001CD52F File Offset: 0x001CB72F
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

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x0600C9ED RID: 51693 RVA: 0x001CD53D File Offset: 0x001CB73D
		// (set) Token: 0x0600C9EE RID: 51694 RVA: 0x001CD564 File Offset: 0x001CB764
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

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x0600C9EF RID: 51695 RVA: 0x001CD574 File Offset: 0x001CB774
		// (set) Token: 0x0600C9F0 RID: 51696 RVA: 0x001CD5D5 File Offset: 0x001CB7D5
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

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x0600C9F1 RID: 51697 RVA: 0x001CD5EC File Offset: 0x001CB7EC
		// (set) Token: 0x0600C9F2 RID: 51698 RVA: 0x001CD626 File Offset: 0x001CB826
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

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x0600C9F3 RID: 51699 RVA: 0x001CD634 File Offset: 0x001CB834
		// (set) Token: 0x0600C9F4 RID: 51700 RVA: 0x001CD66E File Offset: 0x001CB86E
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

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x0600C9F5 RID: 51701 RVA: 0x001CD67C File Offset: 0x001CB87C
		// (set) Token: 0x0600C9F6 RID: 51702 RVA: 0x001CD6DD File Offset: 0x001CB8DD
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

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x0600C9F7 RID: 51703 RVA: 0x001CD6F4 File Offset: 0x001CB8F4
		// (set) Token: 0x0600C9F8 RID: 51704 RVA: 0x001CD72E File Offset: 0x001CB92E
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

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x0600C9F9 RID: 51705 RVA: 0x001CD73C File Offset: 0x001CB93C
		// (set) Token: 0x0600C9FA RID: 51706 RVA: 0x001CD776 File Offset: 0x001CB976
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

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x0600C9FB RID: 51707 RVA: 0x001CD784 File Offset: 0x001CB984
		// (set) Token: 0x0600C9FC RID: 51708 RVA: 0x001CD7E5 File Offset: 0x001CB9E5
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

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x0600C9FD RID: 51709 RVA: 0x001CD7FC File Offset: 0x001CB9FC
		// (set) Token: 0x0600C9FE RID: 51710 RVA: 0x001CD85D File Offset: 0x001CBA5D
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

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x0600C9FF RID: 51711 RVA: 0x001CD874 File Offset: 0x001CBA74
		// (set) Token: 0x0600CA00 RID: 51712 RVA: 0x001CD8D5 File Offset: 0x001CBAD5
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

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x0600CA01 RID: 51713 RVA: 0x001CD8EC File Offset: 0x001CBAEC
		// (set) Token: 0x0600CA02 RID: 51714 RVA: 0x001CD94D File Offset: 0x001CBB4D
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

		// Token: 0x040077B6 RID: 30646
		protected new SetPlotMode FbInstance;

		// Token: 0x040077B7 RID: 30647
		protected SetPlotMode_SetValue PocoInterface;

		// Token: 0x040077B8 RID: 30648
		[Nullable(0)]
		private FadeInScreen _FastFadeInCache;

		// Token: 0x040077B9 RID: 30649
		private bool _FastFadeInInited;

		// Token: 0x040077BA RID: 30650
		[Nullable(0)]
		private IPhoneMessageConfig _PhoneMessageConfigCache;

		// Token: 0x040077BB RID: 30651
		private bool _PhoneMessageConfigInited;

		// Token: 0x040077BC RID: 30652
		[Nullable(0)]
		private IPlotFilmModeConfig _FilmModeConfigCache;

		// Token: 0x040077BD RID: 30653
		private bool _FilmModeConfigInited;

		// Token: 0x040077BE RID: 30654
		[Nullable(0)]
		private IEntityControlConfig _EntityControlConfigCache;

		// Token: 0x040077BF RID: 30655
		private bool _EntityControlConfigInited;

		// Token: 0x040077C0 RID: 30656
		[Nullable(0)]
		private IVisualNovelConfig _VisualNovelConfigCache;

		// Token: 0x040077C1 RID: 30657
		private bool _VisualNovelConfigInited;

		// Token: 0x040077C2 RID: 30658
		[Nullable(0)]
		private IPlotModeUiStyleLevelD _UiStyleCache;

		// Token: 0x040077C3 RID: 30659
		private bool _UiStyleInited;

		// Token: 0x040077C4 RID: 30660
		[Nullable(0)]
		private IPlotAudioConfig _AudioConfigCache;

		// Token: 0x040077C5 RID: 30661
		private bool _AudioConfigInited;
	}
}
