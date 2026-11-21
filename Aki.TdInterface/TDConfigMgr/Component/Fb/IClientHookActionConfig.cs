using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBB RID: 3003
	public class IClientHookActionConfig
	{
		// Token: 0x060044A1 RID: 17569 RVA: 0x000ADEA5 File Offset: 0x000AC0A5
		public static IClientHookActionConfig Create(IClientHookActionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientHookActionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x060044A2 RID: 17570 RVA: 0x000ADEC4 File Offset: 0x000AC0C4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> HookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._HookActionsInited)
				{
					return this._HookActionsCache;
				}
				this._HookActionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int hookActionsLength = this.Instance.HookActionsLength;
				this._HookActionsCache = new List<ActionInfo>(hookActionsLength);
				for (int i = 0; i < hookActionsLength; i++)
				{
					this._HookActionsCache.Add(ActionInfo.Create(this.Instance.HookActions(i)));
				}
				return this._HookActionsCache;
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x000ADF40 File Offset: 0x000AC140
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> ExitHookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ExitHookActionsInited)
				{
					return this._ExitHookActionsCache;
				}
				this._ExitHookActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int exitHookActionsLength = this.Instance.ExitHookActionsLength;
				this._ExitHookActionsCache = new List<ActionInfo>(exitHookActionsLength);
				for (int i = 0; i < exitHookActionsLength; i++)
				{
					this._ExitHookActionsCache.Add(ActionInfo.Create(this.Instance.ExitHookActions(i)));
				}
				return this._ExitHookActionsCache;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x060044A4 RID: 17572 RVA: 0x000ADFBC File Offset: 0x000AC1BC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> FinishActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._FinishActionsInited)
				{
					return this._FinishActionsCache;
				}
				this._FinishActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int finishActionsLength = this.Instance.FinishActionsLength;
				this._FinishActionsCache = new List<ActionInfo>(finishActionsLength);
				for (int i = 0; i < finishActionsLength; i++)
				{
					this._FinishActionsCache.Add(ActionInfo.Create(this.Instance.FinishActions(i)));
				}
				return this._FinishActionsCache;
			}
		}

		// Token: 0x0400260A RID: 9738
		private IClientHookActionConfig Instance;

		// Token: 0x0400260B RID: 9739
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400260C RID: 9740
		private bool _HookActionsInited;

		// Token: 0x0400260D RID: 9741
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400260E RID: 9742
		private bool _ExitHookActionsInited;

		// Token: 0x0400260F RID: 9743
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002610 RID: 9744
		private bool _FinishActionsInited;
	}
}
