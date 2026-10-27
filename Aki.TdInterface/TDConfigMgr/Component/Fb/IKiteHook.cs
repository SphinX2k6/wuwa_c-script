using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AFA RID: 2810
	[NullableContext(2)]
	[Nullable(0)]
	public class IKiteHook : IHookInteractType
	{
		// Token: 0x060040AE RID: 16558 RVA: 0x000A569D File Offset: 0x000A389D
		[NullableContext(1)]
		public static IKiteHook Create(IKiteHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKiteHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x060040AF RID: 16559 RVA: 0x000A56BC File Offset: 0x000A38BC
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x060040B0 RID: 16560 RVA: 0x000A56CC File Offset: 0x000A38CC
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

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x060040B1 RID: 16561 RVA: 0x000A5748 File Offset: 0x000A3948
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

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x000A57C4 File Offset: 0x000A39C4
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

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x060040B3 RID: 16563 RVA: 0x000A583E File Offset: 0x000A3A3E
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

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x000A5872 File Offset: 0x000A3A72
		public virtual string HookDataAssetOverride
		{
			get
			{
				return this.Instance.HookDataAssetOverride;
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x060040B5 RID: 16565 RVA: 0x000A5880 File Offset: 0x000A3A80
		public virtual bool? SupportSwitchHookMidway
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.SupportSwitchHookMidway);
			}
		}

		// Token: 0x04002433 RID: 9267
		private IKiteHook Instance;

		// Token: 0x04002434 RID: 9268
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002435 RID: 9269
		private bool _HookActionsInited;

		// Token: 0x04002436 RID: 9270
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002437 RID: 9271
		private bool _ExitHookActionsInited;

		// Token: 0x04002438 RID: 9272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002439 RID: 9273
		private bool _FinishActionsInited;

		// Token: 0x0400243A RID: 9274
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400243B RID: 9275
		private bool _ClientHookActionConfigInited;
	}
}
