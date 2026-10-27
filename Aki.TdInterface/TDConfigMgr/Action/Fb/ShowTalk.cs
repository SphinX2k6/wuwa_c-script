using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025B3 RID: 9651
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowTalk : ActionParams
	{
		// Token: 0x0600D916 RID: 55574 RVA: 0x002062DA File Offset: 0x002044DA
		[NullableContext(1)]
		public static ShowTalk Create(IShowTalk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowTalk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x0600D917 RID: 55575 RVA: 0x002062FC File Offset: 0x002044FC
		public virtual bool? ResetCamera
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ResetCamera);
			}
		}

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x0600D918 RID: 55576 RVA: 0x00206332 File Offset: 0x00204532
		[Nullable(1)]
		public virtual List<ITalkItem> TalkItems
		{
			[NullableContext(1)]
			get
			{
				if (this._TalkItemsInited)
				{
					return this._TalkItemsCache;
				}
				this._TalkItemsInited = true;
				this._TalkItemsCache = ActionReadHelper.ReadShowTalk_TalkItems(this.Instance);
				return this._TalkItemsCache;
			}
		}

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x0600D919 RID: 55577 RVA: 0x00206361 File Offset: 0x00204561
		public virtual IShowTalkOutline TalkOutline
		{
			get
			{
				if (this._TalkOutlineInited)
				{
					return this._TalkOutlineCache;
				}
				this._TalkOutlineInited = true;
				this._TalkOutlineCache = IShowTalkOutline.Create(this.Instance.TalkOutline);
				return this._TalkOutlineCache;
			}
		}

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x0600D91A RID: 55578 RVA: 0x00206395 File Offset: 0x00204595
		public virtual string SequenceDataAsset
		{
			get
			{
				return this.Instance.SequenceDataAsset;
			}
		}

		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x0600D91B RID: 55579 RVA: 0x002063A4 File Offset: 0x002045A4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IShowTalkFrameEvent> TalkFrameEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._TalkFrameEventsInited)
				{
					return this._TalkFrameEventsCache;
				}
				this._TalkFrameEventsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int talkFrameEventsLength = this.Instance.TalkFrameEventsLength;
				this._TalkFrameEventsCache = new List<IShowTalkFrameEvent>(talkFrameEventsLength);
				for (int i = 0; i < talkFrameEventsLength; i++)
				{
					this._TalkFrameEventsCache.Add(IShowTalkFrameEvent.Create(this.Instance.TalkFrameEvents(i)));
				}
				return this._TalkFrameEventsCache;
			}
		}

		// Token: 0x17003F77 RID: 16247
		// (get) Token: 0x0600D91C RID: 55580 RVA: 0x00206420 File Offset: 0x00204620
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IShowTalk_TalkSequenceRow> TalkSequence
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._TalkSequenceInited)
				{
					return this._TalkSequenceCache;
				}
				this._TalkSequenceInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int talkSequenceLength = this.Instance.TalkSequenceLength;
				this._TalkSequenceCache = new List<IShowTalk_TalkSequenceRow>(talkSequenceLength);
				for (int i = 0; i < talkSequenceLength; i++)
				{
					this._TalkSequenceCache.Add(IShowTalk_TalkSequenceRow.Create(this.Instance.TalkSequence(i)));
				}
				return this._TalkSequenceCache;
			}
		}

		// Token: 0x17003F78 RID: 16248
		// (get) Token: 0x0600D91D RID: 55581 RVA: 0x0020649C File Offset: 0x0020469C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> SequenceNames
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._SequenceNamesInited)
				{
					return this._SequenceNamesCache;
				}
				this._SequenceNamesInited = true;
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int sequenceNamesLength = this.Instance.SequenceNamesLength;
				this._SequenceNamesCache = new List<string>(sequenceNamesLength);
				for (int i = 0; i < sequenceNamesLength; i++)
				{
					this._SequenceNamesCache.Add(this.Instance.SequenceNames(i));
				}
				return this._SequenceNamesCache;
			}
		}

		// Token: 0x17003F79 RID: 16249
		// (get) Token: 0x0600D91E RID: 55582 RVA: 0x00206514 File Offset: 0x00204714
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public virtual Dictionary<int, List<ITalkSequenceTransition>> SequenceTransitions
		{
			[return: Nullable(new byte[]
			{
				2,
				1,
				1
			})]
			get
			{
				if (this._SequenceTransitionsInited)
				{
					return this._SequenceTransitionsCache;
				}
				this._SequenceTransitionsInited = true;
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				this._SequenceTransitionsCache = new Dictionary<int, List<ITalkSequenceTransition>>();
				int sequenceTransitionsLength = this.Instance.SequenceTransitionsLength;
				for (int i = 0; i < sequenceTransitionsLength; i++)
				{
					Record_Int_ITalkSequenceTransitions? record_Int_ITalkSequenceTransitions = this.Instance.SequenceTransitions(i);
					if (record_Int_ITalkSequenceTransitions != null)
					{
						Record_Int_ITalkSequenceTransitions value = record_Int_ITalkSequenceTransitions.Value;
						int key = value.Key;
						List<ITalkSequenceTransition> list = new List<ITalkSequenceTransition>(value.ValuesLength);
						for (int j = 0; j < value.ValuesLength; j++)
						{
							list.Add(ITalkSequenceTransition.Create(value.Values(j)));
						}
						this._SequenceTransitionsCache[key] = list;
					}
				}
				return this._SequenceTransitionsCache;
			}
		}

		// Token: 0x17003F7A RID: 16250
		// (get) Token: 0x0600D91F RID: 55583 RVA: 0x002065E4 File Offset: 0x002047E4
		public virtual bool? SaveFinalPos
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.SaveFinalPos);
			}
		}

		// Token: 0x17003F7B RID: 16251
		// (get) Token: 0x0600D920 RID: 55584 RVA: 0x0020661B File Offset: 0x0020481B
		public virtual SetBlendAnim SeqBlendAnim
		{
			get
			{
				if (this._SeqBlendAnimInited)
				{
					return this._SeqBlendAnimCache;
				}
				this._SeqBlendAnimInited = true;
				this._SeqBlendAnimCache = SetBlendAnim.Create(this.Instance.SeqBlendAnim);
				return this._SeqBlendAnimCache;
			}
		}

		// Token: 0x17003F7C RID: 16252
		// (get) Token: 0x0600D921 RID: 55585 RVA: 0x0020664F File Offset: 0x0020484F
		public virtual string EdSequencePath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F7D RID: 16253
		// (get) Token: 0x0600D922 RID: 55586 RVA: 0x00206652 File Offset: 0x00204852
		public virtual IPlotConfig EdPlotConfig
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F7E RID: 16254
		// (get) Token: 0x0600D923 RID: 55587 RVA: 0x00206655 File Offset: 0x00204855
		public virtual string EdPreSeqSavePath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007895 RID: 30869
		private IShowTalk Instance;

		// Token: 0x04007896 RID: 30870
		[Nullable(1)]
		private List<ITalkItem> _TalkItemsCache;

		// Token: 0x04007897 RID: 30871
		private bool _TalkItemsInited;

		// Token: 0x04007898 RID: 30872
		private IShowTalkOutline _TalkOutlineCache;

		// Token: 0x04007899 RID: 30873
		private bool _TalkOutlineInited;

		// Token: 0x0400789A RID: 30874
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IShowTalkFrameEvent> _TalkFrameEventsCache;

		// Token: 0x0400789B RID: 30875
		private bool _TalkFrameEventsInited;

		// Token: 0x0400789C RID: 30876
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IShowTalk_TalkSequenceRow> _TalkSequenceCache;

		// Token: 0x0400789D RID: 30877
		private bool _TalkSequenceInited;

		// Token: 0x0400789E RID: 30878
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _SequenceNamesCache;

		// Token: 0x0400789F RID: 30879
		private bool _SequenceNamesInited;

		// Token: 0x040078A0 RID: 30880
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<ITalkSequenceTransition>> _SequenceTransitionsCache;

		// Token: 0x040078A1 RID: 30881
		private bool _SequenceTransitionsInited;

		// Token: 0x040078A2 RID: 30882
		private SetBlendAnim _SeqBlendAnimCache;

		// Token: 0x040078A3 RID: 30883
		private bool _SeqBlendAnimInited;
	}
}
