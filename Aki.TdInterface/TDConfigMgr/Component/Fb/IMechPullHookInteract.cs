using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD4 RID: 3028
	[NullableContext(2)]
	[Nullable(0)]
	public class IMechPullHookInteract : IMechHookInteractType
	{
		// Token: 0x06004577 RID: 17783 RVA: 0x000B1272 File Offset: 0x000AF472
		[NullableContext(0)]
		public static IMechPullHookInteract Create(IMechPullHookInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechPullHookInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x000B1291 File Offset: 0x000AF491
		public override EMechHookInteractType Type
		{
			get
			{
				return (EMechHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x000B12A0 File Offset: 0x000AF4A0
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

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x000B131C File Offset: 0x000AF51C
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

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x000B1398 File Offset: 0x000AF598
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

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x000B1412 File Offset: 0x000AF612
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

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x0600457D RID: 17789 RVA: 0x000B1448 File Offset: 0x000AF648
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

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600457E RID: 17790 RVA: 0x000B1480 File Offset: 0x000AF680
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

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x000B14B8 File Offset: 0x000AF6B8
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

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x000B14F0 File Offset: 0x000AF6F0
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

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06004581 RID: 17793 RVA: 0x000B1528 File Offset: 0x000AF728
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

		// Token: 0x040026ED RID: 9965
		private IMechPullHookInteract Instance;

		// Token: 0x040026EE RID: 9966
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040026EF RID: 9967
		private bool _HookActionsInited;

		// Token: 0x040026F0 RID: 9968
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040026F1 RID: 9969
		private bool _ExitHookActionsInited;

		// Token: 0x040026F2 RID: 9970
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040026F3 RID: 9971
		private bool _FinishActionsInited;

		// Token: 0x040026F4 RID: 9972
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040026F5 RID: 9973
		private bool _ClientHookActionConfigInited;
	}
}
