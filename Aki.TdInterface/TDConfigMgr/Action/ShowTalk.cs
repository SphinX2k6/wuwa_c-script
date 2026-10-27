using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200147C RID: 5244
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowTalk : ActionParams
	{
		// Token: 0x06007745 RID: 30533 RVA: 0x0011CDF0 File Offset: 0x0011AFF0
		[NullableContext(1)]
		private ShowTalk_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ShowTalk 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ShowTalk_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ShowTalk_SetValue());
			}
			return result;
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x0011CE28 File Offset: 0x0011B028
		[NullableContext(1)]
		public static ShowTalk Create([Nullable(2)] ShowTalk instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowTalk
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x0011CE3B File Offset: 0x0011B03B
		[NullableContext(1)]
		public static ShowTalk CreateFromSetValue([Nullable(2)] ShowTalk_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ShowTalk
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x0011CE50 File Offset: 0x0011B050
		[NullableContext(1)]
		public ShowTalk_SetValue ToSetValue()
		{
			return new ShowTalk_SetValue
			{
				ResetCamera = this.ResetCamera,
				TalkItems = this.TalkItems,
				TalkOutline = this.TalkOutline,
				SequenceDataAsset = this.SequenceDataAsset,
				TalkFrameEvents = this.TalkFrameEvents,
				TalkSequence = this.TalkSequence,
				SequenceNames = this.SequenceNames,
				SequenceTransitions = this.SequenceTransitions,
				SaveFinalPos = this.SaveFinalPos,
				SeqBlendAnim = this.SeqBlendAnim,
				EdSequencePath = this.EdSequencePath,
				EdPlotConfig = this.EdPlotConfig,
				EdPreSeqSavePath = this.EdPreSeqSavePath
			};
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x06007749 RID: 30537 RVA: 0x0011CF00 File Offset: 0x0011B100
		// (set) Token: 0x0600774A RID: 30538 RVA: 0x0011CF3A File Offset: 0x0011B13A
		public virtual bool? ResetCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetCamera;
				}
				ShowTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetCamera;
			}
			set
			{
				this.GetOrCreatePoco().ResetCamera = value;
			}
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x0600774B RID: 30539 RVA: 0x0011CF48 File Offset: 0x0011B148
		// (set) Token: 0x0600774C RID: 30540 RVA: 0x0011CF6F File Offset: 0x0011B16F
		[Nullable(1)]
		public virtual List<ITalkItem> TalkItems
		{
			[NullableContext(1)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkItems;
				}
				ShowTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TalkItems;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().TalkItems = value;
			}
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x0600774D RID: 30541 RVA: 0x0011CF80 File Offset: 0x0011B180
		// (set) Token: 0x0600774E RID: 30542 RVA: 0x0011CFE1 File Offset: 0x0011B1E1
		public virtual IShowTalkOutline TalkOutline
		{
			get
			{
				if (this._TalkOutlineInited)
				{
					return this._TalkOutlineCache;
				}
				this._TalkOutlineInited = true;
				if (this.FbInstance != null)
				{
					this._TalkOutlineCache = IShowTalkOutline.Create(this.FbInstance.TalkOutline);
				}
				else
				{
					ShowTalk_SetValue pocoInterface = this.PocoInterface;
					this._TalkOutlineCache = ((pocoInterface != null) ? pocoInterface.TalkOutline : null);
				}
				return this._TalkOutlineCache;
			}
			set
			{
				this.GetOrCreatePoco().TalkOutline = value;
				this._TalkOutlineInited = false;
			}
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x0600774F RID: 30543 RVA: 0x0011CFF6 File Offset: 0x0011B1F6
		// (set) Token: 0x06007750 RID: 30544 RVA: 0x0011D01D File Offset: 0x0011B21D
		public virtual string SequenceDataAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SequenceDataAsset;
				}
				ShowTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SequenceDataAsset;
			}
			set
			{
				this.GetOrCreatePoco().SequenceDataAsset = value;
			}
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x06007751 RID: 30545 RVA: 0x0011D02C File Offset: 0x0011B22C
		// (set) Token: 0x06007752 RID: 30546 RVA: 0x0011D0BF File Offset: 0x0011B2BF
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
				if (this.FbInstance != null)
				{
					List<IShowTalkFrameEvent> talkFrameEvents = this.FbInstance.TalkFrameEvents;
					if (talkFrameEvents != null)
					{
						this._TalkFrameEventsCache = new List<IShowTalkFrameEvent>(talkFrameEvents.Count);
						for (int i = 0; i < talkFrameEvents.Count; i++)
						{
							this._TalkFrameEventsCache.Add(IShowTalkFrameEvent.Create(talkFrameEvents[i]));
						}
					}
				}
				else
				{
					ShowTalk_SetValue pocoInterface = this.PocoInterface;
					this._TalkFrameEventsCache = ((pocoInterface != null) ? pocoInterface.TalkFrameEvents : null);
				}
				return this._TalkFrameEventsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().TalkFrameEvents = value;
				this._TalkFrameEventsInited = false;
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x06007753 RID: 30547 RVA: 0x0011D0D4 File Offset: 0x0011B2D4
		// (set) Token: 0x06007754 RID: 30548 RVA: 0x0011D1BC File Offset: 0x0011B3BC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<List<int>> TalkSequence
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
				if (this.FbInstance != null)
				{
					List<IShowTalk_TalkSequenceRow> talkSequence = this.FbInstance.TalkSequence;
					if (talkSequence != null)
					{
						this._TalkSequenceCache = new List<List<int>>(talkSequence.Count);
						for (int i = 0; i < talkSequence.Count; i++)
						{
							List<int> items = talkSequence[i].Items;
							List<int> list = new List<int>(items.Count);
							foreach (int item in items)
							{
								list.Add(item);
							}
							this._TalkSequenceCache.Add(list);
						}
					}
				}
				else
				{
					ShowTalk_SetValue pocoInterface = this.PocoInterface;
					this._TalkSequenceCache = ((pocoInterface != null) ? pocoInterface.TalkSequence : null);
				}
				return this._TalkSequenceCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().TalkSequence = value;
				this._TalkSequenceInited = false;
			}
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x06007755 RID: 30549 RVA: 0x0011D1D1 File Offset: 0x0011B3D1
		// (set) Token: 0x06007756 RID: 30550 RVA: 0x0011D1F8 File Offset: 0x0011B3F8
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
				if (this.FbInstance != null)
				{
					return this.FbInstance.SequenceNames;
				}
				ShowTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SequenceNames;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().SequenceNames = value;
			}
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x06007757 RID: 30551 RVA: 0x0011D208 File Offset: 0x0011B408
		// (set) Token: 0x06007758 RID: 30552 RVA: 0x0011D318 File Offset: 0x0011B518
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
				if (this.FbInstance != null)
				{
					Dictionary<int, List<ITalkSequenceTransition>> sequenceTransitions = this.FbInstance.SequenceTransitions;
					if (sequenceTransitions == null)
					{
						goto IL_E0;
					}
					this._SequenceTransitionsCache = new Dictionary<int, List<ITalkSequenceTransition>>();
					using (Dictionary<int, List<ITalkSequenceTransition>>.Enumerator enumerator = sequenceTransitions.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<int, List<ITalkSequenceTransition>> keyValuePair = enumerator.Current;
							List<ITalkSequenceTransition> list = new List<ITalkSequenceTransition>();
							foreach (ITalkSequenceTransition instance in keyValuePair.Value)
							{
								list.Add(ITalkSequenceTransition.Create(instance));
							}
							this._SequenceTransitionsCache[keyValuePair.Key] = list;
						}
						goto IL_E0;
					}
				}
				if (this.PocoInterface != null)
				{
					ShowTalk_SetValue pocoInterface = this.PocoInterface;
					this._SequenceTransitionsCache = ((pocoInterface != null) ? pocoInterface.SequenceTransitions : null);
				}
				IL_E0:
				return this._SequenceTransitionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1,
				1
			})]
			set
			{
				this.GetOrCreatePoco().SequenceTransitions = value;
				this._SequenceTransitionsInited = false;
			}
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x06007759 RID: 30553 RVA: 0x0011D330 File Offset: 0x0011B530
		// (set) Token: 0x0600775A RID: 30554 RVA: 0x0011D36A File Offset: 0x0011B56A
		public virtual bool? SaveFinalPos
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SaveFinalPos;
				}
				ShowTalk_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SaveFinalPos;
			}
			set
			{
				this.GetOrCreatePoco().SaveFinalPos = value;
			}
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x0600775B RID: 30555 RVA: 0x0011D378 File Offset: 0x0011B578
		// (set) Token: 0x0600775C RID: 30556 RVA: 0x0011D3D9 File Offset: 0x0011B5D9
		public virtual SetBlendAnim SeqBlendAnim
		{
			get
			{
				if (this._SeqBlendAnimInited)
				{
					return this._SeqBlendAnimCache;
				}
				this._SeqBlendAnimInited = true;
				if (this.FbInstance != null)
				{
					this._SeqBlendAnimCache = SetBlendAnim.Create(this.FbInstance.SeqBlendAnim);
				}
				else
				{
					ShowTalk_SetValue pocoInterface = this.PocoInterface;
					this._SeqBlendAnimCache = ((pocoInterface != null) ? pocoInterface.SeqBlendAnim : null);
				}
				return this._SeqBlendAnimCache;
			}
			set
			{
				this.GetOrCreatePoco().SeqBlendAnim = value;
				this._SeqBlendAnimInited = false;
			}
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x0600775D RID: 30557 RVA: 0x0011D3EE File Offset: 0x0011B5EE
		// (set) Token: 0x0600775E RID: 30558 RVA: 0x0011D405 File Offset: 0x0011B605
		public virtual string EdSequencePath
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdSequencePath;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdSequencePath = value;
			}
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x0600775F RID: 30559 RVA: 0x0011D413 File Offset: 0x0011B613
		// (set) Token: 0x06007760 RID: 30560 RVA: 0x0011D42A File Offset: 0x0011B62A
		public virtual IPlotConfig EdPlotConfig
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlotConfig;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPlotConfig = value;
			}
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x06007761 RID: 30561 RVA: 0x0011D438 File Offset: 0x0011B638
		// (set) Token: 0x06007762 RID: 30562 RVA: 0x0011D44F File Offset: 0x0011B64F
		public virtual string EdPreSeqSavePath
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPreSeqSavePath;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPreSeqSavePath = value;
			}
		}

		// Token: 0x04004559 RID: 17753
		protected new ShowTalk FbInstance;

		// Token: 0x0400455A RID: 17754
		protected ShowTalk_SetValue PocoInterface;

		// Token: 0x0400455B RID: 17755
		[Nullable(1)]
		private IShowTalkOutline _TalkOutlineCache;

		// Token: 0x0400455C RID: 17756
		private bool _TalkOutlineInited;

		// Token: 0x0400455D RID: 17757
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IShowTalkFrameEvent> _TalkFrameEventsCache;

		// Token: 0x0400455E RID: 17758
		private bool _TalkFrameEventsInited;

		// Token: 0x0400455F RID: 17759
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<List<int>> _TalkSequenceCache;

		// Token: 0x04004560 RID: 17760
		private bool _TalkSequenceInited;

		// Token: 0x04004561 RID: 17761
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<ITalkSequenceTransition>> _SequenceTransitionsCache;

		// Token: 0x04004562 RID: 17762
		private bool _SequenceTransitionsInited;

		// Token: 0x04004563 RID: 17763
		[Nullable(1)]
		private SetBlendAnim _SeqBlendAnimCache;

		// Token: 0x04004564 RID: 17764
		private bool _SeqBlendAnimInited;
	}
}
