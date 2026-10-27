using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B08 RID: 2824
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorPullInteract : IHookInteractType
	{
		// Token: 0x06004130 RID: 16688 RVA: 0x000A7446 File Offset: 0x000A5646
		[NullableContext(1)]
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

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06004131 RID: 16689 RVA: 0x000A7465 File Offset: 0x000A5665
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x000A7474 File Offset: 0x000A5674
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

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06004133 RID: 16691 RVA: 0x000A74F0 File Offset: 0x000A56F0
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

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x000A756C File Offset: 0x000A576C
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

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x000A75E6 File Offset: 0x000A57E6
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

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x000A761C File Offset: 0x000A581C
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

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06004137 RID: 16695 RVA: 0x000A7654 File Offset: 0x000A5854
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

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06004138 RID: 16696 RVA: 0x000A768C File Offset: 0x000A588C
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

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x000A76C4 File Offset: 0x000A58C4
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

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x000A76FC File Offset: 0x000A58FC
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

		// Token: 0x040024B1 RID: 9393
		private IMotorPullInteract Instance;

		// Token: 0x040024B2 RID: 9394
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040024B3 RID: 9395
		private bool _HookActionsInited;

		// Token: 0x040024B4 RID: 9396
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040024B5 RID: 9397
		private bool _ExitHookActionsInited;

		// Token: 0x040024B6 RID: 9398
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040024B7 RID: 9399
		private bool _FinishActionsInited;

		// Token: 0x040024B8 RID: 9400
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040024B9 RID: 9401
		private bool _ClientHookActionConfigInited;
	}
}
