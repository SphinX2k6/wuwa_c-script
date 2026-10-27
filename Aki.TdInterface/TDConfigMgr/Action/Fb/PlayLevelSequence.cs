using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290D RID: 10509
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayLevelSequence : ActionParams
	{
		// Token: 0x0600E943 RID: 59715 RVA: 0x002233E0 File Offset: 0x002215E0
		[NullableContext(1)]
		public static PlayLevelSequence Create(IPlayLevelSequence? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayLevelSequence
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048EB RID: 18667
		// (get) Token: 0x0600E944 RID: 59716 RVA: 0x002233FF File Offset: 0x002215FF
		[Nullable(1)]
		public virtual string LevelSequencePath
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.LevelSequencePath;
			}
		}

		// Token: 0x170048EC RID: 18668
		// (get) Token: 0x0600E945 RID: 59717 RVA: 0x0022340C File Offset: 0x0022160C
		public virtual bool? IsEnableCenterOffset
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsEnableCenterOffset);
			}
		}

		// Token: 0x170048ED RID: 18669
		// (get) Token: 0x0600E946 RID: 59718 RVA: 0x00223444 File Offset: 0x00221644
		public virtual bool? KeepUI
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepUI);
			}
		}

		// Token: 0x170048EE RID: 18670
		// (get) Token: 0x0600E947 RID: 59719 RVA: 0x0022347A File Offset: 0x0022167A
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x170048EF RID: 18671
		// (get) Token: 0x0600E948 RID: 59720 RVA: 0x00223488 File Offset: 0x00221688
		public virtual TPlayMode? PlayMode
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new TPlayMode?((TPlayMode)this.Instance.PlayMode);
			}
		}

		// Token: 0x170048F0 RID: 18672
		// (get) Token: 0x0600E949 RID: 59721 RVA: 0x002234BE File Offset: 0x002216BE
		public virtual ILoopRange LoopRange
		{
			get
			{
				if (this._LoopRangeInited)
				{
					return this._LoopRangeCache;
				}
				this._LoopRangeInited = true;
				this._LoopRangeCache = ILoopRange.Create(this.Instance.LoopRange);
				return this._LoopRangeCache;
			}
		}

		// Token: 0x170048F1 RID: 18673
		// (get) Token: 0x0600E94A RID: 59722 RVA: 0x002234F2 File Offset: 0x002216F2
		[Nullable(1)]
		public virtual ILevelSequenceTransitionType Intro
		{
			[NullableContext(1)]
			get
			{
				if (this._IntroInited)
				{
					return this._IntroCache;
				}
				this._IntroInited = true;
				this._IntroCache = ActionReadHelper.ReadPlayLevelSequence_Intro(this.Instance);
				return this._IntroCache;
			}
		}

		// Token: 0x170048F2 RID: 18674
		// (get) Token: 0x0600E94B RID: 59723 RVA: 0x00223521 File Offset: 0x00221721
		[Nullable(1)]
		public virtual ILevelSequenceTransitionType Outro
		{
			[NullableContext(1)]
			get
			{
				if (this._OutroInited)
				{
					return this._OutroCache;
				}
				this._OutroInited = true;
				this._OutroCache = ActionReadHelper.ReadPlayLevelSequence_Outro(this.Instance);
				return this._OutroCache;
			}
		}

		// Token: 0x170048F3 RID: 18675
		// (get) Token: 0x0600E94C RID: 59724 RVA: 0x00223550 File Offset: 0x00221750
		public virtual float? Rate
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Rate);
			}
		}

		// Token: 0x170048F4 RID: 18676
		// (get) Token: 0x0600E94D RID: 59725 RVA: 0x00223586 File Offset: 0x00221786
		public virtual IEaseData RateEase
		{
			get
			{
				if (this._RateEaseInited)
				{
					return this._RateEaseCache;
				}
				this._RateEaseInited = true;
				this._RateEaseCache = IEaseData.Create(this.Instance.RateEase);
				return this._RateEaseCache;
			}
		}

		// Token: 0x170048F5 RID: 18677
		// (get) Token: 0x0600E94E RID: 59726 RVA: 0x002235BC File Offset: 0x002217BC
		public virtual bool? IsPlayOnTeleport
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsPlayOnTeleport);
			}
		}

		// Token: 0x170048F6 RID: 18678
		// (get) Token: 0x0600E94F RID: 59727 RVA: 0x002235F4 File Offset: 0x002217F4
		public virtual bool? IsCarryCharacter
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsCarryCharacter);
			}
		}

		// Token: 0x170048F7 RID: 18679
		// (get) Token: 0x0600E950 RID: 59728 RVA: 0x0022362B File Offset: 0x0022182B
		public virtual IFloatingSubtitleLanguageDiff PreprocessOperation
		{
			get
			{
				if (this._PreprocessOperationInited)
				{
					return this._PreprocessOperationCache;
				}
				this._PreprocessOperationInited = true;
				this._PreprocessOperationCache = IFloatingSubtitleLanguageDiff.Create(this.Instance.PreprocessOperation);
				return this._PreprocessOperationCache;
			}
		}

		// Token: 0x040080C3 RID: 32963
		private IPlayLevelSequence Instance;

		// Token: 0x040080C4 RID: 32964
		private ILoopRange _LoopRangeCache;

		// Token: 0x040080C5 RID: 32965
		private bool _LoopRangeInited;

		// Token: 0x040080C6 RID: 32966
		[Nullable(1)]
		private ILevelSequenceTransitionType _IntroCache;

		// Token: 0x040080C7 RID: 32967
		private bool _IntroInited;

		// Token: 0x040080C8 RID: 32968
		[Nullable(1)]
		private ILevelSequenceTransitionType _OutroCache;

		// Token: 0x040080C9 RID: 32969
		private bool _OutroInited;

		// Token: 0x040080CA RID: 32970
		private IEaseData _RateEaseCache;

		// Token: 0x040080CB RID: 32971
		private bool _RateEaseInited;

		// Token: 0x040080CC RID: 32972
		private IFloatingSubtitleLanguageDiff _PreprocessOperationCache;

		// Token: 0x040080CD RID: 32973
		private bool _PreprocessOperationInited;
	}
}
