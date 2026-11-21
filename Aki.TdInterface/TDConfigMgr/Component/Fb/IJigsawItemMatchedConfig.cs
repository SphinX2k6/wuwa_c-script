using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D77 RID: 3447
	public class IJigsawItemMatchedConfig
	{
		// Token: 0x06004E52 RID: 20050 RVA: 0x000C3232 File Offset: 0x000C1432
		public static IJigsawItemMatchedConfig Create(IJigsawItemMatchedConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawItemMatchedConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06004E53 RID: 20051 RVA: 0x000C3251 File Offset: 0x000C1451
		public virtual IPieceIndex TargetIndex
		{
			get
			{
				if (this._TargetIndexInited)
				{
					return this._TargetIndexCache;
				}
				this._TargetIndexInited = true;
				this._TargetIndexCache = IPieceIndex.Create(this.Instance.TargetIndex);
				return this._TargetIndexCache;
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x000C3288 File Offset: 0x000C1488
		public virtual List<int> JigsawItemIds
		{
			get
			{
				if (this._JigsawItemIdsInited)
				{
					return this._JigsawItemIdsCache;
				}
				this._JigsawItemIdsInited = true;
				int jigsawItemIdsLength = this.Instance.JigsawItemIdsLength;
				this._JigsawItemIdsCache = new List<int>(jigsawItemIdsLength);
				for (int i = 0; i < jigsawItemIdsLength; i++)
				{
					this._JigsawItemIdsCache.Add(this.Instance.JigsawItemIds(i));
				}
				return this._JigsawItemIdsCache;
			}
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x000C32EC File Offset: 0x000C14EC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> Actions
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06004E56 RID: 20054 RVA: 0x000C3368 File Offset: 0x000C1568
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
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int conditionActionsLength = this.Instance.ConditionActionsLength;
				this._ConditionActionsCache = new List<IConditionAction>(conditionActionsLength);
				for (int i = 0; i < conditionActionsLength; i++)
				{
					this._ConditionActionsCache.Add(IConditionAction.Create(this.Instance.ConditionActions(i)));
				}
				return this._ConditionActionsCache;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x000C33E4 File Offset: 0x000C15E4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> UnmatchedActions
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
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int unmatchedActionsLength = this.Instance.UnmatchedActionsLength;
				this._UnmatchedActionsCache = new List<ActionInfo>(unmatchedActionsLength);
				for (int i = 0; i < unmatchedActionsLength; i++)
				{
					this._UnmatchedActionsCache.Add(ActionInfo.Create(this.Instance.UnmatchedActions(i)));
				}
				return this._UnmatchedActionsCache;
			}
		}

		// Token: 0x04002C7C RID: 11388
		private IJigsawItemMatchedConfig Instance;

		// Token: 0x04002C7D RID: 11389
		[Nullable(2)]
		private IPieceIndex _TargetIndexCache;

		// Token: 0x04002C7E RID: 11390
		private bool _TargetIndexInited;

		// Token: 0x04002C7F RID: 11391
		private List<int> _JigsawItemIdsCache;

		// Token: 0x04002C80 RID: 11392
		private bool _JigsawItemIdsInited;

		// Token: 0x04002C81 RID: 11393
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002C82 RID: 11394
		private bool _ActionsInited;

		// Token: 0x04002C83 RID: 11395
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IConditionAction> _ConditionActionsCache;

		// Token: 0x04002C84 RID: 11396
		private bool _ConditionActionsInited;

		// Token: 0x04002C85 RID: 11397
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _UnmatchedActionsCache;

		// Token: 0x04002C86 RID: 11398
		private bool _UnmatchedActionsInited;
	}
}
