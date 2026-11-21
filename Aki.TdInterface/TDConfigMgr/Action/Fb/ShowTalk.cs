using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002862 RID: 10338
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowTalk : ActionParams
	{
		// Token: 0x0600E690 RID: 59024 RVA: 0x00221FAE File Offset: 0x002201AE
		[NullableContext(0)]
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

		// Token: 0x1700427A RID: 17018
		// (get) Token: 0x0600E691 RID: 59025 RVA: 0x00221FD0 File Offset: 0x002201D0
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

		// Token: 0x1700427B RID: 17019
		// (get) Token: 0x0600E692 RID: 59026 RVA: 0x00222006 File Offset: 0x00220206
		[Nullable(0)]
		public virtual List<ITalkItem> TalkItems
		{
			[NullableContext(0)]
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

		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x0600E693 RID: 59027 RVA: 0x00222035 File Offset: 0x00220235
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

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x0600E694 RID: 59028 RVA: 0x00222069 File Offset: 0x00220269
		public virtual string SequenceDataAsset
		{
			get
			{
				return this.Instance.SequenceDataAsset;
			}
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x0600E695 RID: 59029 RVA: 0x00222078 File Offset: 0x00220278
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IShowTalkFrameEvent> TalkFrameEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x0600E696 RID: 59030 RVA: 0x002220F4 File Offset: 0x002202F4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IShowTalk_TalkSequenceRow> TalkSequence
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x0600E697 RID: 59031 RVA: 0x00222170 File Offset: 0x00220370
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> SequenceNames
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x0600E698 RID: 59032 RVA: 0x002221E8 File Offset: 0x002203E8
		[Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		public virtual Dictionary<int, List<ITalkSequenceTransition>> SequenceTransitions
		{
			[return: Nullable(new byte[]
			{
				2,
				0,
				0
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

		// Token: 0x17004282 RID: 17026
		// (get) Token: 0x0600E699 RID: 59033 RVA: 0x002222B8 File Offset: 0x002204B8
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

		// Token: 0x17004283 RID: 17027
		// (get) Token: 0x0600E69A RID: 59034 RVA: 0x002222EF File Offset: 0x002204EF
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

		// Token: 0x17004284 RID: 17028
		// (get) Token: 0x0600E69B RID: 59035 RVA: 0x00222323 File Offset: 0x00220523
		public virtual string EdSequencePath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x0600E69C RID: 59036 RVA: 0x00222326 File Offset: 0x00220526
		public virtual IPlotConfig EdPlotConfig
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004286 RID: 17030
		// (get) Token: 0x0600E69D RID: 59037 RVA: 0x00222329 File Offset: 0x00220529
		public virtual string EdPreSeqSavePath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007EFC RID: 32508
		private IShowTalk Instance;

		// Token: 0x04007EFD RID: 32509
		[Nullable(0)]
		private List<ITalkItem> _TalkItemsCache;

		// Token: 0x04007EFE RID: 32510
		private bool _TalkItemsInited;

		// Token: 0x04007EFF RID: 32511
		private IShowTalkOutline _TalkOutlineCache;

		// Token: 0x04007F00 RID: 32512
		private bool _TalkOutlineInited;

		// Token: 0x04007F01 RID: 32513
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IShowTalkFrameEvent> _TalkFrameEventsCache;

		// Token: 0x04007F02 RID: 32514
		private bool _TalkFrameEventsInited;

		// Token: 0x04007F03 RID: 32515
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IShowTalk_TalkSequenceRow> _TalkSequenceCache;

		// Token: 0x04007F04 RID: 32516
		private bool _TalkSequenceInited;

		// Token: 0x04007F05 RID: 32517
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _SequenceNamesCache;

		// Token: 0x04007F06 RID: 32518
		private bool _SequenceNamesInited;

		// Token: 0x04007F07 RID: 32519
		[Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		private Dictionary<int, List<ITalkSequenceTransition>> _SequenceTransitionsCache;

		// Token: 0x04007F08 RID: 32520
		private bool _SequenceTransitionsInited;

		// Token: 0x04007F09 RID: 32521
		private SetBlendAnim _SeqBlendAnimCache;

		// Token: 0x04007F0A RID: 32522
		private bool _SeqBlendAnimInited;
	}
}
