using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD3 RID: 3027
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorPullInteract : IHookInteractType
	{
		// Token: 0x0600456B RID: 17771 RVA: 0x000B0F7A File Offset: 0x000AF17A
		[NullableContext(0)]
		public static IMotorPullInteract Create(IMotorPullInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorPullInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x000B0F99 File Offset: 0x000AF199
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x0600456D RID: 17773 RVA: 0x000B0FA8 File Offset: 0x000AF1A8
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

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x0600456E RID: 17774 RVA: 0x000B1024 File Offset: 0x000AF224
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

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600456F RID: 17775 RVA: 0x000B10A0 File Offset: 0x000AF2A0
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

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x000B111A File Offset: 0x000AF31A
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

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06004571 RID: 17777 RVA: 0x000B1150 File Offset: 0x000AF350
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

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x000B1188 File Offset: 0x000AF388
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

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06004573 RID: 17779 RVA: 0x000B11C0 File Offset: 0x000AF3C0
		public virtual bool? IsFixedWhenNotRide
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFixedWhenNotRide);
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x000B11F8 File Offset: 0x000AF3F8
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

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06004575 RID: 17781 RVA: 0x000B1230 File Offset: 0x000AF430
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

		// Token: 0x040026E4 RID: 9956
		private IMotorPullInteract Instance;

		// Token: 0x040026E5 RID: 9957
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040026E6 RID: 9958
		private bool _HookActionsInited;

		// Token: 0x040026E7 RID: 9959
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040026E8 RID: 9960
		private bool _ExitHookActionsInited;

		// Token: 0x040026E9 RID: 9961
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040026EA RID: 9962
		private bool _FinishActionsInited;

		// Token: 0x040026EB RID: 9963
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040026EC RID: 9964
		private bool _ClientHookActionConfigInited;
	}
}
