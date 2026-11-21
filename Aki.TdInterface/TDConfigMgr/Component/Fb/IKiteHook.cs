using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC5 RID: 3013
	[NullableContext(2)]
	[Nullable(0)]
	public class IKiteHook : IHookInteractType
	{
		// Token: 0x060044E9 RID: 17641 RVA: 0x000AF1D2 File Offset: 0x000AD3D2
		[NullableContext(0)]
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

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x000AF1F1 File Offset: 0x000AD3F1
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x000AF200 File Offset: 0x000AD400
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> HookActions
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

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x000AF27C File Offset: 0x000AD47C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> ExitHookActions
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

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x060044ED RID: 17645 RVA: 0x000AF2F8 File Offset: 0x000AD4F8
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> FinishActions
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

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x000AF372 File Offset: 0x000AD572
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

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x060044EF RID: 17647 RVA: 0x000AF3A6 File Offset: 0x000AD5A6
		public virtual string HookDataAssetOverride
		{
			get
			{
				return this.Instance.HookDataAssetOverride;
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x000AF3B4 File Offset: 0x000AD5B4
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

		// Token: 0x04002666 RID: 9830
		private IKiteHook Instance;

		// Token: 0x04002667 RID: 9831
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002668 RID: 9832
		private bool _HookActionsInited;

		// Token: 0x04002669 RID: 9833
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400266A RID: 9834
		private bool _ExitHookActionsInited;

		// Token: 0x0400266B RID: 9835
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x0400266C RID: 9836
		private bool _FinishActionsInited;

		// Token: 0x0400266D RID: 9837
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400266E RID: 9838
		private bool _ClientHookActionConfigInited;
	}
}
