using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002378 RID: 9080
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayLevelSequence : ActionParams
	{
		// Token: 0x0600C5E2 RID: 50658 RVA: 0x001C5984 File Offset: 0x001C3B84
		[NullableContext(0)]
		private PlayLevelSequence_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayLevelSequence 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayLevelSequence_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayLevelSequence_SetValue());
			}
			return result;
		}

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x001C59BC File Offset: 0x001C3BBC
		[NullableContext(0)]
		public static PlayLevelSequence Create([Nullable(2)] PlayLevelSequence instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayLevelSequence
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C5E4 RID: 50660 RVA: 0x001C59CF File Offset: 0x001C3BCF
		[NullableContext(0)]
		public static PlayLevelSequence CreateFromSetValue([Nullable(2)] PlayLevelSequence_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayLevelSequence
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C5E5 RID: 50661 RVA: 0x001C59E4 File Offset: 0x001C3BE4
		[NullableContext(0)]
		public PlayLevelSequence_SetValue ToSetValue()
		{
			return new PlayLevelSequence_SetValue
			{
				LevelSequencePath = this.LevelSequencePath,
				IsEnableCenterOffset = this.IsEnableCenterOffset,
				KeepUI = this.KeepUI,
				Mark = this.Mark,
				PlayMode = this.PlayMode,
				LoopRange = this.LoopRange,
				Intro = this.Intro,
				Outro = this.Outro,
				Rate = this.Rate,
				RateEase = this.RateEase,
				IsPlayOnTeleport = this.IsPlayOnTeleport,
				IsCarryCharacter = this.IsCarryCharacter,
				PreprocessOperation = this.PreprocessOperation
			};
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x0600C5E6 RID: 50662 RVA: 0x001C5A92 File Offset: 0x001C3C92
		// (set) Token: 0x0600C5E7 RID: 50663 RVA: 0x001C5ABD File Offset: 0x001C3CBD
		[Nullable(0)]
		public virtual string LevelSequencePath
		{
			[NullableContext(0)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelSequencePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.LevelSequencePath;
			}
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().LevelSequencePath = value;
			}
		}

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x0600C5E8 RID: 50664 RVA: 0x001C5ACC File Offset: 0x001C3CCC
		// (set) Token: 0x0600C5E9 RID: 50665 RVA: 0x001C5B06 File Offset: 0x001C3D06
		public virtual bool? IsEnableCenterOffset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnableCenterOffset;
				}
				PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsEnableCenterOffset;
			}
			set
			{
				this.GetOrCreatePoco().IsEnableCenterOffset = value;
			}
		}

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x0600C5EA RID: 50666 RVA: 0x001C5B14 File Offset: 0x001C3D14
		// (set) Token: 0x0600C5EB RID: 50667 RVA: 0x001C5B4E File Offset: 0x001C3D4E
		public virtual bool? KeepUI
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepUI;
				}
				PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepUI;
			}
			set
			{
				this.GetOrCreatePoco().KeepUI = value;
			}
		}

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x0600C5EC RID: 50668 RVA: 0x001C5B5C File Offset: 0x001C3D5C
		// (set) Token: 0x0600C5ED RID: 50669 RVA: 0x001C5B83 File Offset: 0x001C3D83
		public virtual string Mark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mark;
				}
				PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Mark;
			}
			set
			{
				this.GetOrCreatePoco().Mark = value;
			}
		}

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x0600C5EE RID: 50670 RVA: 0x001C5B94 File Offset: 0x001C3D94
		// (set) Token: 0x0600C5EF RID: 50671 RVA: 0x001C5BCE File Offset: 0x001C3DCE
		public virtual TPlayMode? PlayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayMode;
				}
				PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayMode;
			}
			set
			{
				this.GetOrCreatePoco().PlayMode = value;
			}
		}

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x0600C5F0 RID: 50672 RVA: 0x001C5BDC File Offset: 0x001C3DDC
		// (set) Token: 0x0600C5F1 RID: 50673 RVA: 0x001C5C3D File Offset: 0x001C3E3D
		public virtual ILoopRange LoopRange
		{
			get
			{
				if (this._LoopRangeInited)
				{
					return this._LoopRangeCache;
				}
				this._LoopRangeInited = true;
				if (this.FbInstance != null)
				{
					this._LoopRangeCache = ILoopRange.Create(this.FbInstance.LoopRange);
				}
				else
				{
					PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
					this._LoopRangeCache = ((pocoInterface != null) ? pocoInterface.LoopRange : null);
				}
				return this._LoopRangeCache;
			}
			set
			{
				this.GetOrCreatePoco().LoopRange = value;
				this._LoopRangeInited = false;
			}
		}

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x0600C5F2 RID: 50674 RVA: 0x001C5C52 File Offset: 0x001C3E52
		// (set) Token: 0x0600C5F3 RID: 50675 RVA: 0x001C5C79 File Offset: 0x001C3E79
		public virtual ILevelSequenceTransitionType Intro
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Intro;
				}
				PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Intro;
			}
			set
			{
				this.GetOrCreatePoco().Intro = value;
			}
		}

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x0600C5F4 RID: 50676 RVA: 0x001C5C87 File Offset: 0x001C3E87
		// (set) Token: 0x0600C5F5 RID: 50677 RVA: 0x001C5CAE File Offset: 0x001C3EAE
		public virtual ILevelSequenceTransitionType Outro
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Outro;
				}
				PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Outro;
			}
			set
			{
				this.GetOrCreatePoco().Outro = value;
			}
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x0600C5F6 RID: 50678 RVA: 0x001C5CBC File Offset: 0x001C3EBC
		// (set) Token: 0x0600C5F7 RID: 50679 RVA: 0x001C5CF6 File Offset: 0x001C3EF6
		public virtual float? Rate
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Rate;
				}
				PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Rate;
			}
			set
			{
				this.GetOrCreatePoco().Rate = value;
			}
		}

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x0600C5F8 RID: 50680 RVA: 0x001C5D04 File Offset: 0x001C3F04
		// (set) Token: 0x0600C5F9 RID: 50681 RVA: 0x001C5D65 File Offset: 0x001C3F65
		public virtual IEaseData RateEase
		{
			get
			{
				if (this._RateEaseInited)
				{
					return this._RateEaseCache;
				}
				this._RateEaseInited = true;
				if (this.FbInstance != null)
				{
					this._RateEaseCache = IEaseData.Create(this.FbInstance.RateEase);
				}
				else
				{
					PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
					this._RateEaseCache = ((pocoInterface != null) ? pocoInterface.RateEase : null);
				}
				return this._RateEaseCache;
			}
			set
			{
				this.GetOrCreatePoco().RateEase = value;
				this._RateEaseInited = false;
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x0600C5FA RID: 50682 RVA: 0x001C5D7C File Offset: 0x001C3F7C
		// (set) Token: 0x0600C5FB RID: 50683 RVA: 0x001C5DB6 File Offset: 0x001C3FB6
		public virtual bool? IsPlayOnTeleport
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPlayOnTeleport;
				}
				PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsPlayOnTeleport;
			}
			set
			{
				this.GetOrCreatePoco().IsPlayOnTeleport = value;
			}
		}

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x0600C5FC RID: 50684 RVA: 0x001C5DC4 File Offset: 0x001C3FC4
		// (set) Token: 0x0600C5FD RID: 50685 RVA: 0x001C5DFE File Offset: 0x001C3FFE
		public virtual bool? IsCarryCharacter
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCarryCharacter;
				}
				PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsCarryCharacter;
			}
			set
			{
				this.GetOrCreatePoco().IsCarryCharacter = value;
			}
		}

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0600C5FE RID: 50686 RVA: 0x001C5E0C File Offset: 0x001C400C
		// (set) Token: 0x0600C5FF RID: 50687 RVA: 0x001C5E6D File Offset: 0x001C406D
		public virtual IFloatingSubtitleLanguageDiff PreprocessOperation
		{
			get
			{
				if (this._PreprocessOperationInited)
				{
					return this._PreprocessOperationCache;
				}
				this._PreprocessOperationInited = true;
				if (this.FbInstance != null)
				{
					this._PreprocessOperationCache = IFloatingSubtitleLanguageDiff.Create(this.FbInstance.PreprocessOperation);
				}
				else
				{
					PlayLevelSequence_SetValue pocoInterface = this.PocoInterface;
					this._PreprocessOperationCache = ((pocoInterface != null) ? pocoInterface.PreprocessOperation : null);
				}
				return this._PreprocessOperationCache;
			}
			set
			{
				this.GetOrCreatePoco().PreprocessOperation = value;
				this._PreprocessOperationInited = false;
			}
		}

		// Token: 0x040075B9 RID: 30137
		protected new PlayLevelSequence FbInstance;

		// Token: 0x040075BA RID: 30138
		protected PlayLevelSequence_SetValue PocoInterface;

		// Token: 0x040075BB RID: 30139
		[Nullable(0)]
		private ILoopRange _LoopRangeCache;

		// Token: 0x040075BC RID: 30140
		private bool _LoopRangeInited;

		// Token: 0x040075BD RID: 30141
		[Nullable(0)]
		private IEaseData _RateEaseCache;

		// Token: 0x040075BE RID: 30142
		private bool _RateEaseInited;

		// Token: 0x040075BF RID: 30143
		[Nullable(0)]
		private IFloatingSubtitleLanguageDiff _PreprocessOperationCache;

		// Token: 0x040075C0 RID: 30144
		private bool _PreprocessOperationInited;
	}
}
