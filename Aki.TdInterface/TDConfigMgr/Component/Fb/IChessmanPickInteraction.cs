using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D33 RID: 3379
	[NullableContext(2)]
	[Nullable(0)]
	public class IChessmanPickInteraction : IPickInteraction
	{
		// Token: 0x06004D19 RID: 19737 RVA: 0x000BFDB6 File Offset: 0x000BDFB6
		[NullableContext(1)]
		public static IChessmanPickInteraction Create(IChessmanPickInteraction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChessmanPickInteraction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06004D1A RID: 19738 RVA: 0x000BFDD5 File Offset: 0x000BDFD5
		public override EPickInteraction Type
		{
			get
			{
				return (EPickInteraction)this.Instance.Type;
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06004D1B RID: 19739 RVA: 0x000BFDE4 File Offset: 0x000BDFE4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> CheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._CheckedActionsInited)
				{
					return this._CheckedActionsCache;
				}
				this._CheckedActionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int checkedActionsLength = this.Instance.CheckedActionsLength;
				this._CheckedActionsCache = new List<ActionInfo>(checkedActionsLength);
				for (int i = 0; i < checkedActionsLength; i++)
				{
					this._CheckedActionsCache.Add(ActionInfo.Create(this.Instance.CheckedActions(i)));
				}
				return this._CheckedActionsCache;
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06004D1C RID: 19740 RVA: 0x000BFE60 File Offset: 0x000BE060
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> UncheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._UncheckedActionsInited)
				{
					return this._UncheckedActionsCache;
				}
				this._UncheckedActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int uncheckedActionsLength = this.Instance.UncheckedActionsLength;
				this._UncheckedActionsCache = new List<ActionInfo>(uncheckedActionsLength);
				for (int i = 0; i < uncheckedActionsLength; i++)
				{
					this._UncheckedActionsCache.Add(ActionInfo.Create(this.Instance.UncheckedActions(i)));
				}
				return this._UncheckedActionsCache;
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06004D1D RID: 19741 RVA: 0x000BFEDA File Offset: 0x000BE0DA
		public virtual int TargetChessboard
		{
			get
			{
				return this.Instance.TargetChessboard;
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06004D1E RID: 19742 RVA: 0x000BFEE7 File Offset: 0x000BE0E7
		public virtual string AvailablePosEffect
		{
			get
			{
				return this.Instance.AvailablePosEffect;
			}
		}

		// Token: 0x04002C30 RID: 11312
		private IChessmanPickInteraction Instance;

		// Token: 0x04002C31 RID: 11313
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _CheckedActionsCache;

		// Token: 0x04002C32 RID: 11314
		private bool _CheckedActionsInited;

		// Token: 0x04002C33 RID: 11315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _UncheckedActionsCache;

		// Token: 0x04002C34 RID: 11316
		private bool _UncheckedActionsInited;
	}
}
