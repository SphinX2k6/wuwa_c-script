using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AFB RID: 2811
	[NullableContext(2)]
	[Nullable(0)]
	public class IRagDollJumpingPoint : IHookInteractType
	{
		// Token: 0x060040B7 RID: 16567 RVA: 0x000A58BE File Offset: 0x000A3ABE
		[NullableContext(1)]
		public static IRagDollJumpingPoint Create(IRagDollJumpingPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRagDollJumpingPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x060040B8 RID: 16568 RVA: 0x000A58DD File Offset: 0x000A3ADD
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x060040B9 RID: 16569 RVA: 0x000A58EC File Offset: 0x000A3AEC
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

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x000A5968 File Offset: 0x000A3B68
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

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x060040BB RID: 16571 RVA: 0x000A59E4 File Offset: 0x000A3BE4
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

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x060040BC RID: 16572 RVA: 0x000A5A5E File Offset: 0x000A3C5E
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

		// Token: 0x0400243C RID: 9276
		private IRagDollJumpingPoint Instance;

		// Token: 0x0400243D RID: 9277
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400243E RID: 9278
		private bool _HookActionsInited;

		// Token: 0x0400243F RID: 9279
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002440 RID: 9280
		private bool _ExitHookActionsInited;

		// Token: 0x04002441 RID: 9281
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002442 RID: 9282
		private bool _FinishActionsInited;

		// Token: 0x04002443 RID: 9283
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002444 RID: 9284
		private bool _ClientHookActionConfigInited;
	}
}
