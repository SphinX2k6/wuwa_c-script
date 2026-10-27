using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A95 RID: 6805
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowListInfo
	{
		// Token: 0x060091DA RID: 37338 RVA: 0x001534C8 File Offset: 0x001516C8
		[NullableContext(1)]
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

		// Token: 0x060091DB RID: 37339 RVA: 0x00153500 File Offset: 0x00151700
		[NullableContext(1)]
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

		// Token: 0x060091DC RID: 37340 RVA: 0x00153513 File Offset: 0x00151713
		[NullableContext(1)]
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

		// Token: 0x060091DD RID: 37341 RVA: 0x00153528 File Offset: 0x00151728
		[NullableContext(1)]
		public IFlowListInfo_SetValue ToSetValue()
		{
			return new IFlowListInfo_SetValue
			{
				Id = this.Id,
				Texts = this.Texts,
				Flows = this.Flows,
				_selectedFlowId = this._SelectedFlowId,
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

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x060091DE RID: 37342 RVA: 0x001535EE File Offset: 0x001517EE
		// (set) Token: 0x060091DF RID: 37343 RVA: 0x00153619 File Offset: 0x00151819
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

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x060091E0 RID: 37344 RVA: 0x00153628 File Offset: 0x00151828
		// (set) Token: 0x060091E1 RID: 37345 RVA: 0x001536EC File Offset: 0x001518EC
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().Texts = value;
				this._TextsInited = false;
			}
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x060091E2 RID: 37346 RVA: 0x00153704 File Offset: 0x00151904
		// (set) Token: 0x060091E3 RID: 37347 RVA: 0x00153797 File Offset: 0x00151997
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().Flows = value;
				this._FlowsInited = false;
			}
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x060091E4 RID: 37348 RVA: 0x001537AC File Offset: 0x001519AC
		// (set) Token: 0x060091E5 RID: 37349 RVA: 0x001537E6 File Offset: 0x001519E6
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

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x060091E6 RID: 37350 RVA: 0x001537F4 File Offset: 0x001519F4
		// (set) Token: 0x060091E7 RID: 37351 RVA: 0x0015381B File Offset: 0x00151A1B
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

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x060091E8 RID: 37352 RVA: 0x00153829 File Offset: 0x00151A29
		// (set) Token: 0x060091E9 RID: 37353 RVA: 0x00153850 File Offset: 0x00151A50
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

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x060091EA RID: 37354 RVA: 0x0015385E File Offset: 0x00151A5E
		// (set) Token: 0x060091EB RID: 37355 RVA: 0x00153885 File Offset: 0x00151A85
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

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x060091EC RID: 37356 RVA: 0x00153893 File Offset: 0x00151A93
		// (set) Token: 0x060091ED RID: 37357 RVA: 0x001538BA File Offset: 0x00151ABA
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

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x060091EE RID: 37358 RVA: 0x001538C8 File Offset: 0x00151AC8
		// (set) Token: 0x060091EF RID: 37359 RVA: 0x001538EF File Offset: 0x00151AEF
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

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x060091F0 RID: 37360 RVA: 0x001538FD File Offset: 0x00151AFD
		// (set) Token: 0x060091F1 RID: 37361 RVA: 0x00153924 File Offset: 0x00151B24
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

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x060091F2 RID: 37362 RVA: 0x00153932 File Offset: 0x00151B32
		// (set) Token: 0x060091F3 RID: 37363 RVA: 0x00153959 File Offset: 0x00151B59
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
				1
			})]
			set
			{
				this.GetOrCreatePoco()._highlightDataPaths = value;
			}
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x060091F4 RID: 37364 RVA: 0x00153967 File Offset: 0x00151B67
		// (set) Token: 0x060091F5 RID: 37365 RVA: 0x0015398E File Offset: 0x00151B8E
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

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x060091F6 RID: 37366 RVA: 0x0015399C File Offset: 0x00151B9C
		// (set) Token: 0x060091F7 RID: 37367 RVA: 0x001539B3 File Offset: 0x00151BB3
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

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x060091F8 RID: 37368 RVA: 0x001539C4 File Offset: 0x00151BC4
		// (set) Token: 0x060091F9 RID: 37369 RVA: 0x001539EE File Offset: 0x00151BEE
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

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x060091FA RID: 37370 RVA: 0x001539FC File Offset: 0x00151BFC
		// (set) Token: 0x060091FB RID: 37371 RVA: 0x00153A13 File Offset: 0x00151C13
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
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdBubbleActorNames;
				}
				return null;
			}
			[param: Nullable(new byte[]
			{
				2,
				1,
				1,
				1
			})]
			set
			{
				this.GetOrCreatePoco().EdBubbleActorNames = value;
			}
		}

		// Token: 0x040059E0 RID: 23008
		protected IFlowListInfo FbInstance;

		// Token: 0x040059E1 RID: 23009
		protected IFlowListInfo_SetValue PocoInterface;

		// Token: 0x040059E2 RID: 23010
		[Nullable(1)]
		private Dictionary<int, IFlowTextConfig> _TextsCache;

		// Token: 0x040059E3 RID: 23011
		private bool _TextsInited;

		// Token: 0x040059E4 RID: 23012
		[Nullable(1)]
		private List<IFlowInfo> _FlowsCache;

		// Token: 0x040059E5 RID: 23013
		private bool _FlowsInited;
	}
}
