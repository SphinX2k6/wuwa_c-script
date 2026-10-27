using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AF9 RID: 2809
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechHook : IHookInteractType
	{
		// Token: 0x060040A6 RID: 16550 RVA: 0x000A5492 File Offset: 0x000A3692
		public static IMechHook Create(IMechHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x060040A7 RID: 16551 RVA: 0x000A54B1 File Offset: 0x000A36B1
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x060040A8 RID: 16552 RVA: 0x000A54C0 File Offset: 0x000A36C0
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

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x000A553C File Offset: 0x000A373C
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

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x060040AA RID: 16554 RVA: 0x000A55B8 File Offset: 0x000A37B8
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

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x060040AB RID: 16555 RVA: 0x000A5632 File Offset: 0x000A3832
		[Nullable(2)]
		public override IClientHookActionConfig ClientHookActionConfig
		{
			[NullableContext(2)]
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

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x060040AC RID: 16556 RVA: 0x000A5666 File Offset: 0x000A3866
		public virtual IMechHookConfigType HookConfig
		{
			get
			{
				if (this._HookConfigInited)
				{
					return this._HookConfigCache;
				}
				this._HookConfigInited = true;
				this._HookConfigCache = ComponentReadHelper.ReadIMechHook_HookConfig(this.Instance);
				return this._HookConfigCache;
			}
		}

		// Token: 0x04002428 RID: 9256
		private IMechHook Instance;

		// Token: 0x04002429 RID: 9257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400242A RID: 9258
		private bool _HookActionsInited;

		// Token: 0x0400242B RID: 9259
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400242C RID: 9260
		private bool _ExitHookActionsInited;

		// Token: 0x0400242D RID: 9261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x0400242E RID: 9262
		private bool _FinishActionsInited;

		// Token: 0x0400242F RID: 9263
		[Nullable(2)]
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002430 RID: 9264
		private bool _ClientHookActionConfigInited;

		// Token: 0x04002431 RID: 9265
		private IMechHookConfigType _HookConfigCache;

		// Token: 0x04002432 RID: 9266
		private bool _HookConfigInited;
	}
}
