using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B05 RID: 2821
	[NullableContext(2)]
	[Nullable(0)]
	public class ISunSpiritLauncher : IHookInteractType
	{
		// Token: 0x0600411A RID: 16666 RVA: 0x000A6EA7 File Offset: 0x000A50A7
		[NullableContext(1)]
		public static ISunSpiritLauncher Create(ISunSpiritLauncher? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritLauncher
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x0600411B RID: 16667 RVA: 0x000A6EC6 File Offset: 0x000A50C6
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x000A6ED4 File Offset: 0x000A50D4
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

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x0600411D RID: 16669 RVA: 0x000A6F50 File Offset: 0x000A5150
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

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x000A6FCC File Offset: 0x000A51CC
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

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x000A7046 File Offset: 0x000A5246
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

		// Token: 0x04002496 RID: 9366
		private ISunSpiritLauncher Instance;

		// Token: 0x04002497 RID: 9367
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002498 RID: 9368
		private bool _HookActionsInited;

		// Token: 0x04002499 RID: 9369
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400249A RID: 9370
		private bool _ExitHookActionsInited;

		// Token: 0x0400249B RID: 9371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x0400249C RID: 9372
		private bool _FinishActionsInited;

		// Token: 0x0400249D RID: 9373
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400249E RID: 9374
		private bool _ClientHookActionConfigInited;
	}
}
