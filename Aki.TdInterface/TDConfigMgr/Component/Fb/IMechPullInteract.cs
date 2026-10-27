using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B09 RID: 2825
	[NullableContext(2)]
	[Nullable(0)]
	public class IMechPullInteract : IHookInteractType
	{
		// Token: 0x0600413C RID: 16700 RVA: 0x000A773E File Offset: 0x000A593E
		[NullableContext(1)]
		public static IMechPullInteract Create(IMechPullInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechPullInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x000A775D File Offset: 0x000A595D
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x0600413E RID: 16702 RVA: 0x000A776C File Offset: 0x000A596C
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

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x0600413F RID: 16703 RVA: 0x000A77E8 File Offset: 0x000A59E8
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

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x000A7864 File Offset: 0x000A5A64
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

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x000A78DE File Offset: 0x000A5ADE
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

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x000A7914 File Offset: 0x000A5B14
		public virtual bool? IsPlayPullProgress
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsPlayPullProgress);
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x000A794C File Offset: 0x000A5B4C
		public virtual float? PullMoveSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new float?(this.Instance.PullMoveSpeed);
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06004144 RID: 16708 RVA: 0x000A7984 File Offset: 0x000A5B84
		public virtual bool? IsFixedWhenNotMech
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFixedWhenNotMech);
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x000A79BC File Offset: 0x000A5BBC
		public virtual bool? DisableAreaEffect
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableAreaEffect);
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x000A79F4 File Offset: 0x000A5BF4
		public virtual bool? DisableCollectEffect
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableCollectEffect);
			}
		}

		// Token: 0x040024BA RID: 9402
		private IMechPullInteract Instance;

		// Token: 0x040024BB RID: 9403
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040024BC RID: 9404
		private bool _HookActionsInited;

		// Token: 0x040024BD RID: 9405
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040024BE RID: 9406
		private bool _ExitHookActionsInited;

		// Token: 0x040024BF RID: 9407
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040024C0 RID: 9408
		private bool _FinishActionsInited;

		// Token: 0x040024C1 RID: 9409
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040024C2 RID: 9410
		private bool _ClientHookActionConfigInited;
	}
}
