using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AF4 RID: 2804
	[NullableContext(2)]
	[Nullable(0)]
	public class ISuiGuangHook : IHookInteractType
	{
		// Token: 0x0600408C RID: 16524 RVA: 0x000A4F9E File Offset: 0x000A319E
		[NullableContext(1)]
		public static ISuiGuangHook Create(ISuiGuangHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuiGuangHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x0600408D RID: 16525 RVA: 0x000A4FBD File Offset: 0x000A31BD
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x0600408E RID: 16526 RVA: 0x000A4FCC File Offset: 0x000A31CC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> HookActions
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

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x0600408F RID: 16527 RVA: 0x000A5048 File Offset: 0x000A3248
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> ExitHookActions
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

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06004090 RID: 16528 RVA: 0x000A50C4 File Offset: 0x000A32C4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> FinishActions
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

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06004091 RID: 16529 RVA: 0x000A513E File Offset: 0x000A333E
		public override IClientHookActionConfig ClientHookActionConfig
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

		// Token: 0x0400240F RID: 9231
		private ISuiGuangHook Instance;

		// Token: 0x04002410 RID: 9232
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002411 RID: 9233
		private bool _HookActionsInited;

		// Token: 0x04002412 RID: 9234
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002413 RID: 9235
		private bool _ExitHookActionsInited;

		// Token: 0x04002414 RID: 9236
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002415 RID: 9237
		private bool _FinishActionsInited;

		// Token: 0x04002416 RID: 9238
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002417 RID: 9239
		private bool _ClientHookActionConfigInited;
	}
}
