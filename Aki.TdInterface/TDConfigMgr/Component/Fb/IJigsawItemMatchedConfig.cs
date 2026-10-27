using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C95 RID: 3221
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawItemMatchedConfig
	{
		// Token: 0x060049A4 RID: 18852 RVA: 0x000B8822 File Offset: 0x000B6A22
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

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x000B8841 File Offset: 0x000B6A41
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

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x060049A6 RID: 18854 RVA: 0x000B8878 File Offset: 0x000B6A78
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

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x000B88DC File Offset: 0x000B6ADC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> Actions
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

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x060049A8 RID: 18856 RVA: 0x000B8958 File Offset: 0x000B6B58
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

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x000B89D4 File Offset: 0x000B6BD4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> UnmatchedActions
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

		// Token: 0x04002A02 RID: 10754
		private IJigsawItemMatchedConfig Instance;

		// Token: 0x04002A03 RID: 10755
		[Nullable(2)]
		private IPieceIndex _TargetIndexCache;

		// Token: 0x04002A04 RID: 10756
		private bool _TargetIndexInited;

		// Token: 0x04002A05 RID: 10757
		private List<int> _JigsawItemIdsCache;

		// Token: 0x04002A06 RID: 10758
		private bool _JigsawItemIdsInited;

		// Token: 0x04002A07 RID: 10759
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002A08 RID: 10760
		private bool _ActionsInited;

		// Token: 0x04002A09 RID: 10761
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IConditionAction> _ConditionActionsCache;

		// Token: 0x04002A0A RID: 10762
		private bool _ConditionActionsInited;

		// Token: 0x04002A0B RID: 10763
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _UnmatchedActionsCache;

		// Token: 0x04002A0C RID: 10764
		private bool _UnmatchedActionsInited;
	}
}
