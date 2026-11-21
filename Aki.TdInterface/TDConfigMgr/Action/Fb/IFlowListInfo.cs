using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002796 RID: 10134
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowListInfo
	{
		// Token: 0x0600E07C RID: 57468 RVA: 0x002108EE File Offset: 0x0020EAEE
		[NullableContext(0)]
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

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x0600E07D RID: 57469 RVA: 0x0021090D File Offset: 0x0020EB0D
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x0600E07E RID: 57470 RVA: 0x0021091C File Offset: 0x0020EB1C
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

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x0600E07F RID: 57471 RVA: 0x002109A8 File Offset: 0x0020EBA8
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
				int flowsLength = this.Instance.FlowsLength;
				this._FlowsCache = new List<IFlowInfo>(flowsLength);
				for (int i = 0; i < flowsLength; i++)
				{
					this._FlowsCache.Add(IFlowInfo.Create(this.Instance.Flows(i)));
				}
				return this._FlowsCache;
			}
		}

		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x0600E080 RID: 57472 RVA: 0x00210A14 File Offset: 0x0020EC14
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

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x0600E081 RID: 57473 RVA: 0x00210A4C File Offset: 0x0020EC4C
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
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int multiSelectedNodesLength = this.Instance._MultiSelectedNodesLength;
				this.__MultiSelectedNodesCache = new List<IFlowSelectedNode>(multiSelectedNodesLength);
				for (int i = 0; i < multiSelectedNodesLength; i++)
				{
					this.__MultiSelectedNodesCache.Add(IFlowSelectedNode.Create(this.Instance._MultiSelectedNodes(i)));
				}
				return this.__MultiSelectedNodesCache;
			}
		}

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x0600E082 RID: 57474 RVA: 0x00210AC6 File Offset: 0x0020ECC6
		public virtual string _FilterText
		{
			get
			{
				return this.Instance._FilterText;
			}
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x0600E083 RID: 57475 RVA: 0x00210AD3 File Offset: 0x0020ECD3
		public virtual string _HighlightText
		{
			get
			{
				return this.Instance._HighlightText;
			}
		}

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x0600E084 RID: 57476 RVA: 0x00210AE0 File Offset: 0x0020ECE0
		public virtual List<EAction> _FilterActions
		{
			get
			{
				if (this.__FilterActionsInited)
				{
					return this.__FilterActionsCache;
				}
				this.__FilterActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
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

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x0600E085 RID: 57477 RVA: 0x00210B58 File Offset: 0x0020ED58
		public virtual List<EAction> _HighlightActions
		{
			get
			{
				if (this.__HighlightActionsInited)
				{
					return this.__HighlightActionsCache;
				}
				this.__HighlightActionsInited = true;
				if ((this.Instance.NullMask & 8) == 0)
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

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x0600E086 RID: 57478 RVA: 0x00210BCD File Offset: 0x0020EDCD
		public virtual string _FilterEntityIdText
		{
			get
			{
				return this.Instance._FilterEntityIdText;
			}
		}

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x0600E087 RID: 57479 RVA: 0x00210BDA File Offset: 0x0020EDDA
		public virtual string _HighlightEntityIdText
		{
			get
			{
				return this.Instance._HighlightEntityIdText;
			}
		}

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x0600E088 RID: 57480 RVA: 0x00210BE8 File Offset: 0x0020EDE8
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
				if (this.__HighlightDataPathsInited)
				{
					return this.__HighlightDataPathsCache;
				}
				this.__HighlightDataPathsInited = true;
				if ((this.Instance.NullMask & 16) == 0)
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

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x0600E089 RID: 57481 RVA: 0x00210C5E File Offset: 0x0020EE5E
		public virtual string _FocusDataPath
		{
			get
			{
				return this.Instance._FocusDataPath;
			}
		}

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x0600E08A RID: 57482 RVA: 0x00210C6B File Offset: 0x0020EE6B
		public virtual string EdPlotPath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x0600E08B RID: 57483 RVA: 0x00210C70 File Offset: 0x0020EE70
		public virtual bool? EdPreviewOnly
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x0600E08C RID: 57484 RVA: 0x00210C86 File Offset: 0x0020EE86
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
				return null;
			}
		}

		// Token: 0x04007A14 RID: 31252
		private IFlowListInfo Instance;

		// Token: 0x04007A15 RID: 31253
		[Nullable(0)]
		private Dictionary<int, IFlowTextConfig> _TextsCache;

		// Token: 0x04007A16 RID: 31254
		private bool _TextsInited;

		// Token: 0x04007A17 RID: 31255
		[Nullable(0)]
		private List<IFlowInfo> _FlowsCache;

		// Token: 0x04007A18 RID: 31256
		private bool _FlowsInited;

		// Token: 0x04007A19 RID: 31257
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IFlowSelectedNode> __MultiSelectedNodesCache;

		// Token: 0x04007A1A RID: 31258
		private bool __MultiSelectedNodesInited;

		// Token: 0x04007A1B RID: 31259
		private List<EAction> __FilterActionsCache;

		// Token: 0x04007A1C RID: 31260
		private bool __FilterActionsInited;

		// Token: 0x04007A1D RID: 31261
		private List<EAction> __HighlightActionsCache;

		// Token: 0x04007A1E RID: 31262
		private bool __HighlightActionsInited;

		// Token: 0x04007A1F RID: 31263
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> __HighlightDataPathsCache;

		// Token: 0x04007A20 RID: 31264
		private bool __HighlightDataPathsInited;
	}
}
