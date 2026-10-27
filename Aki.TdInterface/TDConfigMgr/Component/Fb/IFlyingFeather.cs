using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B02 RID: 2818
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlyingFeather : IHookInteractType
	{
		// Token: 0x060040F7 RID: 16631 RVA: 0x000A6802 File Offset: 0x000A4A02
		[NullableContext(1)]
		public static IFlyingFeather Create(IFlyingFeather? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlyingFeather
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x060040F8 RID: 16632 RVA: 0x000A6821 File Offset: 0x000A4A21
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x000A6830 File Offset: 0x000A4A30
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

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x060040FA RID: 16634 RVA: 0x000A68AC File Offset: 0x000A4AAC
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

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x000A6928 File Offset: 0x000A4B28
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

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x060040FC RID: 16636 RVA: 0x000A69A2 File Offset: 0x000A4BA2
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

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x060040FD RID: 16637 RVA: 0x000A69D8 File Offset: 0x000A4BD8
		public virtual int? EntityId
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EntityId);
			}
		}

		// Token: 0x0400247D RID: 9341
		private IFlyingFeather Instance;

		// Token: 0x0400247E RID: 9342
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400247F RID: 9343
		private bool _HookActionsInited;

		// Token: 0x04002480 RID: 9344
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002481 RID: 9345
		private bool _ExitHookActionsInited;

		// Token: 0x04002482 RID: 9346
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002483 RID: 9347
		private bool _FinishActionsInited;

		// Token: 0x04002484 RID: 9348
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002485 RID: 9349
		private bool _ClientHookActionConfigInited;
	}
}
