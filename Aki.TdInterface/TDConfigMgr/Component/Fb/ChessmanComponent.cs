using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D35 RID: 3381
	public class ChessmanComponent : IComponentBase
	{
		// Token: 0x06004D25 RID: 19749 RVA: 0x000BFFA6 File Offset: 0x000BE1A6
		[NullableContext(1)]
		public static ChessmanComponent Create(IChessmanComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChessmanComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06004D26 RID: 19750 RVA: 0x000BFFC8 File Offset: 0x000BE1C8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06004D27 RID: 19751 RVA: 0x000C0000 File Offset: 0x000BE200
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06004D28 RID: 19752 RVA: 0x000C0018 File Offset: 0x000BE218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> StartMovingActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._StartMovingActionsInited)
				{
					return this._StartMovingActionsCache;
				}
				this._StartMovingActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int startMovingActionsLength = this.Instance.StartMovingActionsLength;
				this._StartMovingActionsCache = new List<ActionInfo>(startMovingActionsLength);
				for (int i = 0; i < startMovingActionsLength; i++)
				{
					this._StartMovingActionsCache.Add(ActionInfo.Create(this.Instance.StartMovingActions(i)));
				}
				return this._StartMovingActionsCache;
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06004D29 RID: 19753 RVA: 0x000C0094 File Offset: 0x000BE294
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> EndMovingActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._EndMovingActionsInited)
				{
					return this._EndMovingActionsCache;
				}
				this._EndMovingActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int endMovingActionsLength = this.Instance.EndMovingActionsLength;
				this._EndMovingActionsCache = new List<ActionInfo>(endMovingActionsLength);
				for (int i = 0; i < endMovingActionsLength; i++)
				{
					this._EndMovingActionsCache.Add(ActionInfo.Create(this.Instance.EndMovingActions(i)));
				}
				return this._EndMovingActionsCache;
			}
		}

		// Token: 0x04002C38 RID: 11320
		private IChessmanComponent Instance;

		// Token: 0x04002C39 RID: 11321
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _StartMovingActionsCache;

		// Token: 0x04002C3A RID: 11322
		private bool _StartMovingActionsInited;

		// Token: 0x04002C3B RID: 11323
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _EndMovingActionsCache;

		// Token: 0x04002C3C RID: 11324
		private bool _EndMovingActionsInited;
	}
}
