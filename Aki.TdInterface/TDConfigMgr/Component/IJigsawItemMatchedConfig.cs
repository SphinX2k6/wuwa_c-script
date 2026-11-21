using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004FF RID: 1279
	public class IJigsawItemMatchedConfig
	{
		// Token: 0x06001990 RID: 6544 RVA: 0x0004BCE8 File Offset: 0x00049EE8
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

		// Token: 0x06001991 RID: 6545 RVA: 0x0004BD20 File Offset: 0x00049F20
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

		// Token: 0x06001992 RID: 6546 RVA: 0x0004BD33 File Offset: 0x00049F33
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

		// Token: 0x06001993 RID: 6547 RVA: 0x0004BD48 File Offset: 0x00049F48
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

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x0004BD98 File Offset: 0x00049F98
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x0004BDF9 File Offset: 0x00049FF9
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

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x0004BE0E File Offset: 0x0004A00E
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x0004BE35 File Offset: 0x0004A035
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

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x0004BE44 File Offset: 0x0004A044
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x0004BED7 File Offset: 0x0004A0D7
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x0004BEEC File Offset: 0x0004A0EC
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x0004BF7F File Offset: 0x0004A17F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IConditionAction> ConditionActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().ConditionActions = value;
				this._ConditionActionsInited = false;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x0004BF94 File Offset: 0x0004A194
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x0004C027 File Offset: 0x0004A227
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> UnmatchedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().UnmatchedActions = value;
				this._UnmatchedActionsInited = false;
			}
		}

		// Token: 0x040012F3 RID: 4851
		[Nullable(2)]
		protected IJigsawItemMatchedConfig FbInstance;

		// Token: 0x040012F4 RID: 4852
		[Nullable(2)]
		protected IJigsawItemMatchedConfig_SetValue PocoInterface;

		// Token: 0x040012F5 RID: 4853
		private Aki.TDConfigMgr.Action.IPieceIndex _TargetIndexCache;

		// Token: 0x040012F6 RID: 4854
		private bool _TargetIndexInited;

		// Token: 0x040012F7 RID: 4855
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x040012F8 RID: 4856
		private bool _ActionsInited;

		// Token: 0x040012F9 RID: 4857
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IConditionAction> _ConditionActionsCache;

		// Token: 0x040012FA RID: 4858
		private bool _ConditionActionsInited;

		// Token: 0x040012FB RID: 4859
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _UnmatchedActionsCache;

		// Token: 0x040012FC RID: 4860
		private bool _UnmatchedActionsInited;
	}
}
