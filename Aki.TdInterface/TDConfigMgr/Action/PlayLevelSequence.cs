using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002117 RID: 8471
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayLevelSequence : ActionParams
	{
		// Token: 0x0600BA56 RID: 47702 RVA: 0x001AE824 File Offset: 0x001ACA24
		[NullableContext(1)]
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

		// Token: 0x0600BA57 RID: 47703 RVA: 0x001AE85C File Offset: 0x001ACA5C
		[NullableContext(1)]
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

		// Token: 0x0600BA58 RID: 47704 RVA: 0x001AE86F File Offset: 0x001ACA6F
		[NullableContext(1)]
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

		// Token: 0x0600BA59 RID: 47705 RVA: 0x001AE884 File Offset: 0x001ACA84
		[NullableContext(1)]
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

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600BA5A RID: 47706 RVA: 0x001AE932 File Offset: 0x001ACB32
		// (set) Token: 0x0600BA5B RID: 47707 RVA: 0x001AE95D File Offset: 0x001ACB5D
		[Nullable(1)]
		public virtual string LevelSequencePath
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().LevelSequencePath = value;
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600BA5C RID: 47708 RVA: 0x001AE96C File Offset: 0x001ACB6C
		// (set) Token: 0x0600BA5D RID: 47709 RVA: 0x001AE9A6 File Offset: 0x001ACBA6
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

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600BA5E RID: 47710 RVA: 0x001AE9B4 File Offset: 0x001ACBB4
		// (set) Token: 0x0600BA5F RID: 47711 RVA: 0x001AE9EE File Offset: 0x001ACBEE
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

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600BA60 RID: 47712 RVA: 0x001AE9FC File Offset: 0x001ACBFC
		// (set) Token: 0x0600BA61 RID: 47713 RVA: 0x001AEA23 File Offset: 0x001ACC23
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

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600BA62 RID: 47714 RVA: 0x001AEA34 File Offset: 0x001ACC34
		// (set) Token: 0x0600BA63 RID: 47715 RVA: 0x001AEA6E File Offset: 0x001ACC6E
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

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600BA64 RID: 47716 RVA: 0x001AEA7C File Offset: 0x001ACC7C
		// (set) Token: 0x0600BA65 RID: 47717 RVA: 0x001AEADD File Offset: 0x001ACCDD
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

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600BA66 RID: 47718 RVA: 0x001AEAF2 File Offset: 0x001ACCF2
		// (set) Token: 0x0600BA67 RID: 47719 RVA: 0x001AEB19 File Offset: 0x001ACD19
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

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600BA68 RID: 47720 RVA: 0x001AEB27 File Offset: 0x001ACD27
		// (set) Token: 0x0600BA69 RID: 47721 RVA: 0x001AEB4E File Offset: 0x001ACD4E
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

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600BA6A RID: 47722 RVA: 0x001AEB5C File Offset: 0x001ACD5C
		// (set) Token: 0x0600BA6B RID: 47723 RVA: 0x001AEB96 File Offset: 0x001ACD96
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

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600BA6C RID: 47724 RVA: 0x001AEBA4 File Offset: 0x001ACDA4
		// (set) Token: 0x0600BA6D RID: 47725 RVA: 0x001AEC05 File Offset: 0x001ACE05
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

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600BA6E RID: 47726 RVA: 0x001AEC1C File Offset: 0x001ACE1C
		// (set) Token: 0x0600BA6F RID: 47727 RVA: 0x001AEC56 File Offset: 0x001ACE56
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

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600BA70 RID: 47728 RVA: 0x001AEC64 File Offset: 0x001ACE64
		// (set) Token: 0x0600BA71 RID: 47729 RVA: 0x001AEC9E File Offset: 0x001ACE9E
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

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600BA72 RID: 47730 RVA: 0x001AECAC File Offset: 0x001ACEAC
		// (set) Token: 0x0600BA73 RID: 47731 RVA: 0x001AED0D File Offset: 0x001ACF0D
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

		// Token: 0x04006F85 RID: 28549
		protected new PlayLevelSequence FbInstance;

		// Token: 0x04006F86 RID: 28550
		protected PlayLevelSequence_SetValue PocoInterface;

		// Token: 0x04006F87 RID: 28551
		[Nullable(1)]
		private ILoopRange _LoopRangeCache;

		// Token: 0x04006F88 RID: 28552
		private bool _LoopRangeInited;

		// Token: 0x04006F89 RID: 28553
		[Nullable(1)]
		private IEaseData _RateEaseCache;

		// Token: 0x04006F8A RID: 28554
		private bool _RateEaseInited;

		// Token: 0x04006F8B RID: 28555
		[Nullable(1)]
		private IFloatingSubtitleLanguageDiff _PreprocessOperationCache;

		// Token: 0x04006F8C RID: 28556
		private bool _PreprocessOperationInited;
	}
}
