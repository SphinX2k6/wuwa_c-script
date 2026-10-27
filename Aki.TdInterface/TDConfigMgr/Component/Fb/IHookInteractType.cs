using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AF1 RID: 2801
	[NullableContext(2)]
	[Nullable(0)]
	public class IHookInteractType
	{
		// Token: 0x06004077 RID: 16503 RVA: 0x000A4A0A File Offset: 0x000A2C0A
		[NullableContext(1)]
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

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x000A4A29 File Offset: 0x000A2C29
		public virtual EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06004079 RID: 16505 RVA: 0x000A4A38 File Offset: 0x000A2C38
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> HookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x000A4AB4 File Offset: 0x000A2CB4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> ExitHookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x0600407B RID: 16507 RVA: 0x000A4B30 File Offset: 0x000A2D30
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> FinishActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x000A4BAA File Offset: 0x000A2DAA
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

		// Token: 0x040023F4 RID: 9204
		private IHookInteractType Instance;

		// Token: 0x040023F5 RID: 9205
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040023F6 RID: 9206
		private bool _HookActionsInited;

		// Token: 0x040023F7 RID: 9207
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040023F8 RID: 9208
		private bool _ExitHookActionsInited;

		// Token: 0x040023F9 RID: 9209
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040023FA RID: 9210
		private bool _FinishActionsInited;

		// Token: 0x040023FB RID: 9211
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040023FC RID: 9212
		private bool _ClientHookActionConfigInited;
	}
}
