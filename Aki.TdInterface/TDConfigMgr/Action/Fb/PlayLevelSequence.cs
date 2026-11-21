using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BE9 RID: 11241
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayLevelSequence : ActionParams
	{
		// Token: 0x0600F794 RID: 63380 RVA: 0x00240700 File Offset: 0x0023E900
		[NullableContext(0)]
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

		// Token: 0x17004C70 RID: 19568
		// (get) Token: 0x0600F795 RID: 63381 RVA: 0x0024071F File Offset: 0x0023E91F
		[Nullable(0)]
		public virtual string LevelSequencePath
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.LevelSequencePath;
			}
		}

		// Token: 0x17004C71 RID: 19569
		// (get) Token: 0x0600F796 RID: 63382 RVA: 0x0024072C File Offset: 0x0023E92C
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

		// Token: 0x17004C72 RID: 19570
		// (get) Token: 0x0600F797 RID: 63383 RVA: 0x00240764 File Offset: 0x0023E964
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

		// Token: 0x17004C73 RID: 19571
		// (get) Token: 0x0600F798 RID: 63384 RVA: 0x0024079A File Offset: 0x0023E99A
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x17004C74 RID: 19572
		// (get) Token: 0x0600F799 RID: 63385 RVA: 0x002407A8 File Offset: 0x0023E9A8
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

		// Token: 0x17004C75 RID: 19573
		// (get) Token: 0x0600F79A RID: 63386 RVA: 0x002407DE File Offset: 0x0023E9DE
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

		// Token: 0x17004C76 RID: 19574
		// (get) Token: 0x0600F79B RID: 63387 RVA: 0x00240812 File Offset: 0x0023EA12
		[Nullable(0)]
		public virtual ILevelSequenceTransitionType Intro
		{
			[NullableContext(0)]
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

		// Token: 0x17004C77 RID: 19575
		// (get) Token: 0x0600F79C RID: 63388 RVA: 0x00240841 File Offset: 0x0023EA41
		[Nullable(0)]
		public virtual ILevelSequenceTransitionType Outro
		{
			[NullableContext(0)]
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

		// Token: 0x17004C78 RID: 19576
		// (get) Token: 0x0600F79D RID: 63389 RVA: 0x00240870 File Offset: 0x0023EA70
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

		// Token: 0x17004C79 RID: 19577
		// (get) Token: 0x0600F79E RID: 63390 RVA: 0x002408A6 File Offset: 0x0023EAA6
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

		// Token: 0x17004C7A RID: 19578
		// (get) Token: 0x0600F79F RID: 63391 RVA: 0x002408DC File Offset: 0x0023EADC
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

		// Token: 0x17004C7B RID: 19579
		// (get) Token: 0x0600F7A0 RID: 63392 RVA: 0x00240914 File Offset: 0x0023EB14
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

		// Token: 0x17004C7C RID: 19580
		// (get) Token: 0x0600F7A1 RID: 63393 RVA: 0x0024094B File Offset: 0x0023EB4B
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

		// Token: 0x04008791 RID: 34705
		private IPlayLevelSequence Instance;

		// Token: 0x04008792 RID: 34706
		private ILoopRange _LoopRangeCache;

		// Token: 0x04008793 RID: 34707
		private bool _LoopRangeInited;

		// Token: 0x04008794 RID: 34708
		[Nullable(0)]
		private ILevelSequenceTransitionType _IntroCache;

		// Token: 0x04008795 RID: 34709
		private bool _IntroInited;

		// Token: 0x04008796 RID: 34710
		[Nullable(0)]
		private ILevelSequenceTransitionType _OutroCache;

		// Token: 0x04008797 RID: 34711
		private bool _OutroInited;

		// Token: 0x04008798 RID: 34712
		private IEaseData _RateEaseCache;

		// Token: 0x04008799 RID: 34713
		private bool _RateEaseInited;

		// Token: 0x0400879A RID: 34714
		private IFloatingSubtitleLanguageDiff _PreprocessOperationCache;

		// Token: 0x0400879B RID: 34715
		private bool _PreprocessOperationInited;
	}
}
