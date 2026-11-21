using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC4 RID: 3012
	[NullableContext(2)]
	[Nullable(0)]
	public class IMechFixedPointHookInteract : IMechHookInteractType
	{
		// Token: 0x060044E1 RID: 17633 RVA: 0x000AEFC2 File Offset: 0x000AD1C2
		[NullableContext(0)]
		public static IMechFixedPointHookInteract Create(IMechFixedPointHookInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechFixedPointHookInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x000AEFE1 File Offset: 0x000AD1E1
		public override EMechHookInteractType Type
		{
			get
			{
				return (EMechHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
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

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x000AF06C File Offset: 0x000AD26C
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

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x000AF0E8 File Offset: 0x000AD2E8
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

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x000AF162 File Offset: 0x000AD362
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

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x000AF196 File Offset: 0x000AD396
		public virtual IMechBehaviorConfig MechBehaviorConfig
		{
			get
			{
				if (this._MechBehaviorConfigInited)
				{
					return this._MechBehaviorConfigCache;
				}
				this._MechBehaviorConfigInited = true;
				this._MechBehaviorConfigCache = IMechBehaviorConfig.Create(this.Instance.MechBehaviorConfig);
				return this._MechBehaviorConfigCache;
			}
		}

		// Token: 0x0400265B RID: 9819
		private IMechFixedPointHookInteract Instance;

		// Token: 0x0400265C RID: 9820
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400265D RID: 9821
		private bool _HookActionsInited;

		// Token: 0x0400265E RID: 9822
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400265F RID: 9823
		private bool _ExitHookActionsInited;

		// Token: 0x04002660 RID: 9824
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002661 RID: 9825
		private bool _FinishActionsInited;

		// Token: 0x04002662 RID: 9826
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002663 RID: 9827
		private bool _ClientHookActionConfigInited;

		// Token: 0x04002664 RID: 9828
		private IMechBehaviorConfig _MechBehaviorConfigCache;

		// Token: 0x04002665 RID: 9829
		private bool _MechBehaviorConfigInited;
	}
}
