using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C2A RID: 7210
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowListInfo
	{
		// Token: 0x06009946 RID: 39238 RVA: 0x00163434 File Offset: 0x00161634
		[NullableContext(0)]
		private IFlowListInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowListInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowListInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowListInfo_SetValue());
			}
			return result;
		}

		// Token: 0x06009947 RID: 39239 RVA: 0x0016346C File Offset: 0x0016166C
		[NullableContext(0)]
		public static IFlowListInfo Create([Nullable(2)] IFlowListInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowListInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009948 RID: 39240 RVA: 0x0016347F File Offset: 0x0016167F
		[NullableContext(0)]
		public static IFlowListInfo CreateFromSetValue([Nullable(2)] IFlowListInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowListInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009949 RID: 39241 RVA: 0x00163494 File Offset: 0x00161694
		[NullableContext(0)]
		public IFlowListInfo_SetValue ToSetValue()
		{
			return new IFlowListInfo_SetValue
			{
				Id = this.Id,
				Texts = this.Texts,
				Flows = this.Flows,
				_selectedFlowId = this._SelectedFlowId,
				_multiSelectedNodes = this._MultiSelectedNodes,
				_filterText = this._FilterText,
				_highlightText = this._HighlightText,
				_filterActions = this._FilterActions,
				_highlightActions = this._HighlightActions,
				_filterEntityIdText = this._FilterEntityIdText,
				_highlightEntityIdText = this._HighlightEntityIdText,
				_highlightDataPaths = this._HighlightDataPaths,
				_focusDataPath = this._FocusDataPath,
				EdPlotPath = this.EdPlotPath,
				EdPreviewOnly = this.EdPreviewOnly,
				EdBubbleActorNames = this.EdBubbleActorNames
			};
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x0600994A RID: 39242 RVA: 0x00163566 File Offset: 0x00161766
		// (set) Token: 0x0600994B RID: 39243 RVA: 0x00163591 File Offset: 0x00161791
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x0600994C RID: 39244 RVA: 0x001635A0 File Offset: 0x001617A0
		// (set) Token: 0x0600994D RID: 39245 RVA: 0x00163664 File Offset: 0x00161864
		[Nullable(0)]
		public virtual Dictionary<int, IFlowTextConfig> Texts
		{
			[NullableContext(0)]
			get
			{
				if (this._TextsInited)
				{
					return this._TextsCache;
				}
				this._TextsInited = true;
				if (this.FbInstance != null)
				{
					Dictionary<int, IFlowTextConfig> texts = this.FbInstance.Texts;
					if (texts == null)
					{
						goto IL_A0;
					}
					this._TextsCache = new Dictionary<int, IFlowTextConfig>();
					using (Dictionary<int, IFlowTextConfig>.Enumerator enumerator = texts.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<int, IFlowTextConfig> keyValuePair = enumerator.Current;
							this._TextsCache[keyValuePair.Key] = IFlowTextConfig.Create(keyValuePair.Value);
						}
						goto IL_A0;
					}
				}
				if (this.PocoInterface != null)
				{
					IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
					this._TextsCache = ((pocoInterface != null) ? pocoInterface.Texts : null);
				}
				IL_A0:
				return this._TextsCache;
			}
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().Texts = value;
				this._TextsInited = false;
			}
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x0600994E RID: 39246 RVA: 0x0016367C File Offset: 0x0016187C
		// (set) Token: 0x0600994F RID: 39247 RVA: 0x0016370F File Offset: 0x0016190F
		[Nullable(0)]
		public virtual List<IFlowInfo> Flows
		{
			[NullableContext(0)]
			get
			{
				if (this._FlowsInited)
				{
					return this._FlowsCache;
				}
				this._FlowsInited = true;
				if (this.FbInstance != null)
				{
					List<IFlowInfo> flows = this.FbInstance.Flows;
					if (flows != null)
					{
						this._FlowsCache = new List<IFlowInfo>(flows.Count);
						for (int i = 0; i < flows.Count; i++)
						{
							this._FlowsCache.Add(IFlowInfo.Create(flows[i]));
						}
					}
				}
				else
				{
					IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
					this._FlowsCache = ((pocoInterface != null) ? pocoInterface.Flows : null);
				}
				return this._FlowsCache;
			}
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().Flows = value;
				this._FlowsInited = false;
			}
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x06009950 RID: 39248 RVA: 0x00163724 File Offset: 0x00161924
		// (set) Token: 0x06009951 RID: 39249 RVA: 0x0016375E File Offset: 0x0016195E
		public virtual int? _SelectedFlowId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._SelectedFlowId;
				}
				IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._selectedFlowId;
			}
			set
			{
				this.GetOrCreatePoco()._selectedFlowId = value;
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x06009952 RID: 39250 RVA: 0x0016376C File Offset: 0x0016196C
		// (set) Token: 0x06009953 RID: 39251 RVA: 0x001637FF File Offset: 0x001619FF
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IFlowSelectedNode> _MultiSelectedNodes
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.__MultiSelectedNodesInited)
				{
					return this.__MultiSelectedNodesCache;
				}
				this.__MultiSelectedNodesInited = true;
				if (this.FbInstance != null)
				{
					List<IFlowSelectedNode> multiSelectedNodes = this.FbInstance._MultiSelectedNodes;
					if (multiSelectedNodes != null)
					{
						this.__MultiSelectedNodesCache = new List<IFlowSelectedNode>(multiSelectedNodes.Count);
						for (int i = 0; i < multiSelectedNodes.Count; i++)
						{
							this.__MultiSelectedNodesCache.Add(IFlowSelectedNode.Create(multiSelectedNodes[i]));
						}
					}
				}
				else
				{
					IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
					this.__MultiSelectedNodesCache = ((pocoInterface != null) ? pocoInterface._multiSelectedNodes : null);
				}
				return this.__MultiSelectedNodesCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco()._multiSelectedNodes = value;
				this.__MultiSelectedNodesInited = false;
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x06009954 RID: 39252 RVA: 0x00163814 File Offset: 0x00161A14
		// (set) Token: 0x06009955 RID: 39253 RVA: 0x0016383B File Offset: 0x00161A3B
		public virtual string _FilterText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._FilterText;
				}
				IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._filterText;
			}
			set
			{
				this.GetOrCreatePoco()._filterText = value;
			}
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x06009956 RID: 39254 RVA: 0x00163849 File Offset: 0x00161A49
		// (set) Token: 0x06009957 RID: 39255 RVA: 0x00163870 File Offset: 0x00161A70
		public virtual string _HighlightText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._HighlightText;
				}
				IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._highlightText;
			}
			set
			{
				this.GetOrCreatePoco()._highlightText = value;
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x06009958 RID: 39256 RVA: 0x0016387E File Offset: 0x00161A7E
		// (set) Token: 0x06009959 RID: 39257 RVA: 0x001638A5 File Offset: 0x00161AA5
		public virtual List<EAction> _FilterActions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._FilterActions;
				}
				IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._filterActions;
			}
			set
			{
				this.GetOrCreatePoco()._filterActions = value;
			}
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x0600995A RID: 39258 RVA: 0x001638B3 File Offset: 0x00161AB3
		// (set) Token: 0x0600995B RID: 39259 RVA: 0x001638DA File Offset: 0x00161ADA
		public virtual List<EAction> _HighlightActions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._HighlightActions;
				}
				IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._highlightActions;
			}
			set
			{
				this.GetOrCreatePoco()._highlightActions = value;
			}
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x0600995C RID: 39260 RVA: 0x001638E8 File Offset: 0x00161AE8
		// (set) Token: 0x0600995D RID: 39261 RVA: 0x0016390F File Offset: 0x00161B0F
		public virtual string _FilterEntityIdText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._FilterEntityIdText;
				}
				IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._filterEntityIdText;
			}
			set
			{
				this.GetOrCreatePoco()._filterEntityIdText = value;
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x0600995E RID: 39262 RVA: 0x0016391D File Offset: 0x00161B1D
		// (set) Token: 0x0600995F RID: 39263 RVA: 0x00163944 File Offset: 0x00161B44
		public virtual string _HighlightEntityIdText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._HighlightEntityIdText;
				}
				IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._highlightEntityIdText;
			}
			set
			{
				this.GetOrCreatePoco()._highlightEntityIdText = value;
			}
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x06009960 RID: 39264 RVA: 0x00163952 File Offset: 0x00161B52
		// (set) Token: 0x06009961 RID: 39265 RVA: 0x00163979 File Offset: 0x00161B79
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> _HighlightDataPaths
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
					return this.FbInstance._HighlightDataPaths;
				}
				IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._highlightDataPaths;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco()._highlightDataPaths = value;
			}
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x06009962 RID: 39266 RVA: 0x00163987 File Offset: 0x00161B87
		// (set) Token: 0x06009963 RID: 39267 RVA: 0x001639AE File Offset: 0x00161BAE
		public virtual string _FocusDataPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._FocusDataPath;
				}
				IFlowListInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._focusDataPath;
			}
			set
			{
				this.GetOrCreatePoco()._focusDataPath = value;
			}
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x06009964 RID: 39268 RVA: 0x001639BC File Offset: 0x00161BBC
		// (set) Token: 0x06009965 RID: 39269 RVA: 0x001639D3 File Offset: 0x00161BD3
		public virtual string EdPlotPath
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlotPath;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPlotPath = value;
			}
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x06009966 RID: 39270 RVA: 0x001639E4 File Offset: 0x00161BE4
		// (set) Token: 0x06009967 RID: 39271 RVA: 0x00163A0E File Offset: 0x00161C0E
		public virtual bool? EdPreviewOnly
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPreviewOnly;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPreviewOnly = value;
			}
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x06009968 RID: 39272 RVA: 0x00163A1C File Offset: 0x00161C1C
		// (set) Token: 0x06009969 RID: 39273 RVA: 0x00163A33 File Offset: 0x00161C33
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0
		})]
		public virtual Dictionary<string, List<string>> EdBubbleActorNames
		{
			[return: Nullable(new byte[]
			{
				2,
				0,
				0,
				0
			})]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdBubbleActorNames;
				}
				return null;
			}
			[param: Nullable(new byte[]
			{
				2,
				0,
				0,
				0
			})]
			set
			{
				this.GetOrCreatePoco().EdBubbleActorNames = value;
			}
		}

		// Token: 0x04005E46 RID: 24134
		protected IFlowListInfo FbInstance;

		// Token: 0x04005E47 RID: 24135
		protected IFlowListInfo_SetValue PocoInterface;

		// Token: 0x04005E48 RID: 24136
		[Nullable(0)]
		private Dictionary<int, IFlowTextConfig> _TextsCache;

		// Token: 0x04005E49 RID: 24137
		private bool _TextsInited;

		// Token: 0x04005E4A RID: 24138
		[Nullable(0)]
		private List<IFlowInfo> _FlowsCache;

		// Token: 0x04005E4B RID: 24139
		private bool _FlowsInited;

		// Token: 0x04005E4C RID: 24140
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IFlowSelectedNode> __MultiSelectedNodesCache;

		// Token: 0x04005E4D RID: 24141
		private bool __MultiSelectedNodesInited;
	}
}
