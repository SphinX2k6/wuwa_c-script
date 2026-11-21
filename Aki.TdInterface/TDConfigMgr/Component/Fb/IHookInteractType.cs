using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBC RID: 3004
	[NullableContext(2)]
	[Nullable(0)]
	public class IHookInteractType
	{
		// Token: 0x060044A6 RID: 17574 RVA: 0x000AE03E File Offset: 0x000AC23E
		[NullableContext(0)]
		public static IHookInteractType Create(IHookInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x000AE05D File Offset: 0x000AC25D
		public virtual EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x000AE06C File Offset: 0x000AC26C
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

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x060044A9 RID: 17577 RVA: 0x000AE0E8 File Offset: 0x000AC2E8
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

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x000AE164 File Offset: 0x000AC364
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

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x060044AB RID: 17579 RVA: 0x000AE1DE File Offset: 0x000AC3DE
		public virtual IClientHookActionConfig ClientHookActionConfig
		{
			get
			{
				if (this._ClientHookActionConfigInited)
				{
					return this._ClientHookActionConfigCache;
				}
				this._ClientHookActionConfigInited = true;
				this._ClientHookActionConfigCache = IClientHookActionConfig.Create(this.Instance.ClientHookActionConfig);
				return this._ClientHookActionConfigCache;
			}
		}

		// Token: 0x04002611 RID: 9745
		private IHookInteractType Instance;

		// Token: 0x04002612 RID: 9746
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002613 RID: 9747
		private bool _HookActionsInited;

		// Token: 0x04002614 RID: 9748
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002615 RID: 9749
		private bool _ExitHookActionsInited;

		// Token: 0x04002616 RID: 9750
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002617 RID: 9751
		private bool _FinishActionsInited;

		// Token: 0x04002618 RID: 9752
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002619 RID: 9753
		private bool _ClientHookActionConfigInited;
	}
}
