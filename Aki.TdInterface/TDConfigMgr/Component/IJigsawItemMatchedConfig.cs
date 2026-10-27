using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004A6 RID: 1190
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawItemMatchedConfig
	{
		// Token: 0x060017F6 RID: 6134 RVA: 0x00047FA0 File Offset: 0x000461A0
		private IJigsawItemMatchedConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IJigsawItemMatchedConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IJigsawItemMatchedConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IJigsawItemMatchedConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00047FD8 File Offset: 0x000461D8
		public static IJigsawItemMatchedConfig Create([Nullable(2)] IJigsawItemMatchedConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawItemMatchedConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00047FEB File Offset: 0x000461EB
		public static IJigsawItemMatchedConfig CreateFromSetValue([Nullable(2)] IJigsawItemMatchedConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IJigsawItemMatchedConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00048000 File Offset: 0x00046200
		public IJigsawItemMatchedConfig_SetValue ToSetValue()
		{
			return new IJigsawItemMatchedConfig_SetValue
			{
				TargetIndex = this.TargetIndex,
				JigsawItemIds = this.JigsawItemIds,
				Actions = this.Actions,
				ConditionActions = this.ConditionActions,
				UnmatchedActions = this.UnmatchedActions
			};
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00048050 File Offset: 0x00046250
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x000480B1 File Offset: 0x000462B1
		public virtual Aki.TDConfigMgr.Action.IPieceIndex TargetIndex
		{
			get
			{
				if (this._TargetIndexInited)
				{
					return this._TargetIndexCache;
				}
				this._TargetIndexInited = true;
				if (this.FbInstance != null)
				{
					this._TargetIndexCache = Aki.TDConfigMgr.Action.IPieceIndex.Create(this.FbInstance.TargetIndex);
				}
				else
				{
					IJigsawItemMatchedConfig_SetValue pocoInterface = this.PocoInterface;
					this._TargetIndexCache = ((pocoInterface != null) ? pocoInterface.TargetIndex : null);
				}
				return this._TargetIndexCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetIndex = value;
				this._TargetIndexInited = false;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x000480C6 File Offset: 0x000462C6
		// (set) Token: 0x060017FD RID: 6141 RVA: 0x000480ED File Offset: 0x000462ED
		public virtual List<int> JigsawItemIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.JigsawItemIds;
				}
				IJigsawItemMatchedConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.JigsawItemIds;
			}
			set
			{
				this.GetOrCreatePoco().JigsawItemIds = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x000480FC File Offset: 0x000462FC
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x0004818F File Offset: 0x0004638F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IJigsawItemMatchedConfig_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x000481A4 File Offset: 0x000463A4
		// (set) Token: 0x06001801 RID: 6145 RVA: 0x00048237 File Offset: 0x00046437
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IConditionAction> ConditionActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ConditionActionsInited)
				{
					return this._ConditionActionsCache;
				}
				this._ConditionActionsInited = true;
				if (this.FbInstance != null)
				{
					List<IConditionAction> conditionActions = this.FbInstance.ConditionActions;
					if (conditionActions != null)
					{
						this._ConditionActionsCache = new List<IConditionAction>(conditionActions.Count);
						for (int i = 0; i < conditionActions.Count; i++)
						{
							this._ConditionActionsCache.Add(IConditionAction.Create(conditionActions[i]));
						}
					}
				}
				else
				{
					IJigsawItemMatchedConfig_SetValue pocoInterface = this.PocoInterface;
					this._ConditionActionsCache = ((pocoInterface != null) ? pocoInterface.ConditionActions : null);
				}
				return this._ConditionActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().ConditionActions = value;
				this._ConditionActionsInited = false;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0004824C File Offset: 0x0004644C
		// (set) Token: 0x06001803 RID: 6147 RVA: 0x000482DF File Offset: 0x000464DF
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> UnmatchedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._UnmatchedActionsInited)
				{
					return this._UnmatchedActionsCache;
				}
				this._UnmatchedActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> unmatchedActions = this.FbInstance.UnmatchedActions;
					if (unmatchedActions != null)
					{
						this._UnmatchedActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(unmatchedActions.Count);
						for (int i = 0; i < unmatchedActions.Count; i++)
						{
							this._UnmatchedActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(unmatchedActions[i]));
						}
					}
				}
				else
				{
					IJigsawItemMatchedConfig_SetValue pocoInterface = this.PocoInterface;
					this._UnmatchedActionsCache = ((pocoInterface != null) ? pocoInterface.UnmatchedActions : null);
				}
				return this._UnmatchedActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().UnmatchedActions = value;
				this._UnmatchedActionsInited = false;
			}
		}

		// Token: 0x040011D1 RID: 4561
		[Nullable(2)]
		protected IJigsawItemMatchedConfig FbInstance;

		// Token: 0x040011D2 RID: 4562
		[Nullable(2)]
		protected IJigsawItemMatchedConfig_SetValue PocoInterface;

		// Token: 0x040011D3 RID: 4563
		private Aki.TDConfigMgr.Action.IPieceIndex _TargetIndexCache;

		// Token: 0x040011D4 RID: 4564
		private bool _TargetIndexInited;

		// Token: 0x040011D5 RID: 4565
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x040011D6 RID: 4566
		private bool _ActionsInited;

		// Token: 0x040011D7 RID: 4567
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IConditionAction> _ConditionActionsCache;

		// Token: 0x040011D8 RID: 4568
		private bool _ConditionActionsInited;

		// Token: 0x040011D9 RID: 4569
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _UnmatchedActionsCache;

		// Token: 0x040011DA RID: 4570
		private bool _UnmatchedActionsInited;
	}
}
