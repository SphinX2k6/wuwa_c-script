using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E2F RID: 3631
	public class ChessmanComponent : IComponentBase
	{
		// Token: 0x06005241 RID: 21057 RVA: 0x000CB6EA File Offset: 0x000C98EA
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

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06005242 RID: 21058 RVA: 0x000CB70C File Offset: 0x000C990C
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

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06005243 RID: 21059 RVA: 0x000CB744 File Offset: 0x000C9944
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06005244 RID: 21060 RVA: 0x000CB75C File Offset: 0x000C995C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> StartMovingActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06005245 RID: 21061 RVA: 0x000CB7D8 File Offset: 0x000C99D8
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> EndMovingActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x04002EF8 RID: 12024
		private IChessmanComponent Instance;

		// Token: 0x04002EF9 RID: 12025
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _StartMovingActionsCache;

		// Token: 0x04002EFA RID: 12026
		private bool _StartMovingActionsInited;

		// Token: 0x04002EFB RID: 12027
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _EndMovingActionsCache;

		// Token: 0x04002EFC RID: 12028
		private bool _EndMovingActionsInited;
	}
}
