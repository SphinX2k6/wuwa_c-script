using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015D5 RID: 5589
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowTalk : ActionParams
	{
		// Token: 0x06007E12 RID: 32274 RVA: 0x0012B9FC File Offset: 0x00129BFC
		[NullableContext(0)]
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

		// Token: 0x06007E13 RID: 32275 RVA: 0x0012BA34 File Offset: 0x00129C34
		[NullableContext(0)]
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

		// Token: 0x06007E14 RID: 32276 RVA: 0x0012BA47 File Offset: 0x00129C47
		[NullableContext(0)]
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

		// Token: 0x06007E15 RID: 32277 RVA: 0x0012BA5C File Offset: 0x00129C5C
		[NullableContext(0)]
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

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x06007E16 RID: 32278 RVA: 0x0012BB0C File Offset: 0x00129D0C
		// (set) Token: 0x06007E17 RID: 32279 RVA: 0x0012BB46 File Offset: 0x00129D46
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

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x06007E18 RID: 32280 RVA: 0x0012BB54 File Offset: 0x00129D54
		// (set) Token: 0x06007E19 RID: 32281 RVA: 0x0012BB7B File Offset: 0x00129D7B
		[Nullable(0)]
		public virtual List<ITalkItem> TalkItems
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().TalkItems = value;
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x06007E1A RID: 32282 RVA: 0x0012BB8C File Offset: 0x00129D8C
		// (set) Token: 0x06007E1B RID: 32283 RVA: 0x0012BBED File Offset: 0x00129DED
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

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x06007E1C RID: 32284 RVA: 0x0012BC02 File Offset: 0x00129E02
		// (set) Token: 0x06007E1D RID: 32285 RVA: 0x0012BC29 File Offset: 0x00129E29
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

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x06007E1E RID: 32286 RVA: 0x0012BC38 File Offset: 0x00129E38
		// (set) Token: 0x06007E1F RID: 32287 RVA: 0x0012BCCB File Offset: 0x00129ECB
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().TalkFrameEvents = value;
				this._TalkFrameEventsInited = false;
			}
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x06007E20 RID: 32288 RVA: 0x0012BCE0 File Offset: 0x00129EE0
		// (set) Token: 0x06007E21 RID: 32289 RVA: 0x0012BDC8 File Offset: 0x00129FC8
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<List<int>> TalkSequence
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().TalkSequence = value;
				this._TalkSequenceInited = false;
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x06007E22 RID: 32290 RVA: 0x0012BDDD File Offset: 0x00129FDD
		// (set) Token: 0x06007E23 RID: 32291 RVA: 0x0012BE04 File Offset: 0x0012A004
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().SequenceNames = value;
			}
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x06007E24 RID: 32292 RVA: 0x0012BE14 File Offset: 0x0012A014
		// (set) Token: 0x06007E25 RID: 32293 RVA: 0x0012BF24 File Offset: 0x0012A124
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
				0,
				0
			})]
			set
			{
				this.GetOrCreatePoco().SequenceTransitions = value;
				this._SequenceTransitionsInited = false;
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x06007E26 RID: 32294 RVA: 0x0012BF3C File Offset: 0x0012A13C
		// (set) Token: 0x06007E27 RID: 32295 RVA: 0x0012BF76 File Offset: 0x0012A176
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

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x06007E28 RID: 32296 RVA: 0x0012BF84 File Offset: 0x0012A184
		// (set) Token: 0x06007E29 RID: 32297 RVA: 0x0012BFE5 File Offset: 0x0012A1E5
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

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x06007E2A RID: 32298 RVA: 0x0012BFFA File Offset: 0x0012A1FA
		// (set) Token: 0x06007E2B RID: 32299 RVA: 0x0012C011 File Offset: 0x0012A211
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

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x06007E2C RID: 32300 RVA: 0x0012C01F File Offset: 0x0012A21F
		// (set) Token: 0x06007E2D RID: 32301 RVA: 0x0012C036 File Offset: 0x0012A236
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

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x06007E2E RID: 32302 RVA: 0x0012C044 File Offset: 0x0012A244
		// (set) Token: 0x06007E2F RID: 32303 RVA: 0x0012C05B File Offset: 0x0012A25B
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

		// Token: 0x040048F4 RID: 18676
		protected new ShowTalk FbInstance;

		// Token: 0x040048F5 RID: 18677
		protected ShowTalk_SetValue PocoInterface;

		// Token: 0x040048F6 RID: 18678
		[Nullable(0)]
		private IShowTalkOutline _TalkOutlineCache;

		// Token: 0x040048F7 RID: 18679
		private bool _TalkOutlineInited;

		// Token: 0x040048F8 RID: 18680
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IShowTalkFrameEvent> _TalkFrameEventsCache;

		// Token: 0x040048F9 RID: 18681
		private bool _TalkFrameEventsInited;

		// Token: 0x040048FA RID: 18682
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<List<int>> _TalkSequenceCache;

		// Token: 0x040048FB RID: 18683
		private bool _TalkSequenceInited;

		// Token: 0x040048FC RID: 18684
		[Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		private Dictionary<int, List<ITalkSequenceTransition>> _SequenceTransitionsCache;

		// Token: 0x040048FD RID: 18685
		private bool _SequenceTransitionsInited;

		// Token: 0x040048FE RID: 18686
		[Nullable(0)]
		private SetBlendAnim _SeqBlendAnimCache;

		// Token: 0x040048FF RID: 18687
		private bool _SeqBlendAnimInited;
	}
}
