using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024F0 RID: 9456
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowListInfo
	{
		// Token: 0x0600D321 RID: 54049 RVA: 0x001F4F72 File Offset: 0x001F3172
		[NullableContext(1)]
		public static IFlowListInfo Create(IFlowListInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowListInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x0600D322 RID: 54050 RVA: 0x001F4F91 File Offset: 0x001F3191
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x0600D323 RID: 54051 RVA: 0x001F4FA0 File Offset: 0x001F31A0
		[Nullable(1)]
		public virtual Dictionary<int, IFlowTextConfig> Texts
		{
			[NullableContext(1)]
			get
			{
				if (this._TextsInited)
				{
					return this._TextsCache;
				}
				this._TextsInited = true;
				this._TextsCache = new Dictionary<int, IFlowTextConfig>();
				int textsLength = this.Instance.TextsLength;
				for (int i = 0; i < textsLength; i++)
				{
					Record_Int_IFlowTextConfig? record_Int_IFlowTextConfig = this.Instance.Texts(i);
					if (record_Int_IFlowTextConfig != null)
					{
						Record_Int_IFlowTextConfig value = record_Int_IFlowTextConfig.Value;
						int key = value.Key;
						this._TextsCache[key] = IFlowTextConfig.Create(value.Value);
					}
				}
				return this._TextsCache;
			}
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x0600D324 RID: 54052 RVA: 0x001F502C File Offset: 0x001F322C
		[Nullable(1)]
		public virtual List<IFlowInfo> Flows
		{
			[NullableContext(1)]
			get
			{
				if (this._FlowsInited)
				{
					return this._FlowsCache;
				}
				this._FlowsInited = true;
				int flowsLength = this.Instance.FlowsLength;
				this._FlowsCache = new List<IFlowInfo>(flowsLength);
				for (int i = 0; i < flowsLength; i++)
				{
					this._FlowsCache.Add(IFlowInfo.Create(this.Instance.Flows(i)));
				}
				return this._FlowsCache;
			}
		}

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x0600D325 RID: 54053 RVA: 0x001F5098 File Offset: 0x001F3298
		public virtual int? _SelectedFlowId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance._SelectedFlowId);
			}
		}

		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x0600D326 RID: 54054 RVA: 0x001F50CE File Offset: 0x001F32CE
		public virtual string _FilterText
		{
			get
			{
				return this.Instance._FilterText;
			}
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x0600D327 RID: 54055 RVA: 0x001F50DB File Offset: 0x001F32DB
		public virtual string _HighlightText
		{
			get
			{
				return this.Instance._HighlightText;
			}
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x0600D328 RID: 54056 RVA: 0x001F50E8 File Offset: 0x001F32E8
		public virtual List<EAction> _FilterActions
		{
			get
			{
				if (this.__FilterActionsInited)
				{
					return this.__FilterActionsCache;
				}
				this.__FilterActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int filterActionsLength = this.Instance._FilterActionsLength;
				this.__FilterActionsCache = new List<EAction>(filterActionsLength);
				for (int i = 0; i < filterActionsLength; i++)
				{
					this.__FilterActionsCache.Add((EAction)this.Instance._FilterActions(i));
				}
				return this.__FilterActionsCache;
			}
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x0600D329 RID: 54057 RVA: 0x001F5160 File Offset: 0x001F3360
		public virtual List<EAction> _HighlightActions
		{
			get
			{
				if (this.__HighlightActionsInited)
				{
					return this.__HighlightActionsCache;
				}
				this.__HighlightActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int highlightActionsLength = this.Instance._HighlightActionsLength;
				this.__HighlightActionsCache = new List<EAction>(highlightActionsLength);
				for (int i = 0; i < highlightActionsLength; i++)
				{
					this.__HighlightActionsCache.Add((EAction)this.Instance._HighlightActions(i));
				}
				return this.__HighlightActionsCache;
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x0600D32A RID: 54058 RVA: 0x001F51D5 File Offset: 0x001F33D5
		public virtual string _FilterEntityIdText
		{
			get
			{
				return this.Instance._FilterEntityIdText;
			}
		}

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x0600D32B RID: 54059 RVA: 0x001F51E2 File Offset: 0x001F33E2
		public virtual string _HighlightEntityIdText
		{
			get
			{
				return this.Instance._HighlightEntityIdText;
			}
		}

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x0600D32C RID: 54060 RVA: 0x001F51F0 File Offset: 0x001F33F0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> _HighlightDataPaths
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.__HighlightDataPathsInited)
				{
					return this.__HighlightDataPathsCache;
				}
				this.__HighlightDataPathsInited = true;
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int highlightDataPathsLength = this.Instance._HighlightDataPathsLength;
				this.__HighlightDataPathsCache = new List<string>(highlightDataPathsLength);
				for (int i = 0; i < highlightDataPathsLength; i++)
				{
					this.__HighlightDataPathsCache.Add(this.Instance._HighlightDataPaths(i));
				}
				return this.__HighlightDataPathsCache;
			}
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x0600D32D RID: 54061 RVA: 0x001F5265 File Offset: 0x001F3465
		public virtual string _FocusDataPath
		{
			get
			{
				return this.Instance._FocusDataPath;
			}
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x0600D32E RID: 54062 RVA: 0x001F5272 File Offset: 0x001F3472
		public virtual string EdPlotPath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x0600D32F RID: 54063 RVA: 0x001F5278 File Offset: 0x001F3478
		public virtual bool? EdPreviewOnly
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x0600D330 RID: 54064 RVA: 0x001F528E File Offset: 0x001F348E
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public virtual Dictionary<string, List<string>> EdBubbleActorNames
		{
			[return: Nullable(new byte[]
			{
				2,
				1,
				1,
				1
			})]
			get
			{
				return null;
			}
		}

		// Token: 0x040073C4 RID: 29636
		private IFlowListInfo Instance;

		// Token: 0x040073C5 RID: 29637
		[Nullable(1)]
		private Dictionary<int, IFlowTextConfig> _TextsCache;

		// Token: 0x040073C6 RID: 29638
		private bool _TextsInited;

		// Token: 0x040073C7 RID: 29639
		[Nullable(1)]
		private List<IFlowInfo> _FlowsCache;

		// Token: 0x040073C8 RID: 29640
		private bool _FlowsInited;

		// Token: 0x040073C9 RID: 29641
		private List<EAction> __FilterActionsCache;

		// Token: 0x040073CA RID: 29642
		private bool __FilterActionsInited;

		// Token: 0x040073CB RID: 29643
		private List<EAction> __HighlightActionsCache;

		// Token: 0x040073CC RID: 29644
		private bool __HighlightActionsInited;

		// Token: 0x040073CD RID: 29645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> __HighlightDataPathsCache;

		// Token: 0x040073CE RID: 29646
		private bool __HighlightDataPathsInited;
	}
}
