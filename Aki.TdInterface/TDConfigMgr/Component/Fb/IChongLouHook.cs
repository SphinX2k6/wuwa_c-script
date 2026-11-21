using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BDC RID: 3036
	[NullableContext(2)]
	[Nullable(0)]
	public class IChongLouHook : IHookInteractType
	{
		// Token: 0x060045AF RID: 17839 RVA: 0x000B1BFB File Offset: 0x000AFDFB
		[NullableContext(0)]
		public static IChongLouHook Create(IChongLouHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChongLouHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x000B1C1A File Offset: 0x000AFE1A
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x060045B1 RID: 17841 RVA: 0x000B1C28 File Offset: 0x000AFE28
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

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x000B1CA4 File Offset: 0x000AFEA4
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

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x060045B3 RID: 17843 RVA: 0x000B1D20 File Offset: 0x000AFF20
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

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x000B1D9A File Offset: 0x000AFF9A
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

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x060045B5 RID: 17845 RVA: 0x000B1DCE File Offset: 0x000AFFCE
		public virtual float HookMoveSpeed
		{
			get
			{
				return this.Instance.HookMoveSpeed;
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x000B1DDB File Offset: 0x000AFFDB
		public virtual float Acceleration
		{
			get
			{
				return this.Instance.Acceleration;
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060045B7 RID: 17847 RVA: 0x000B1DE8 File Offset: 0x000AFFE8
		public virtual float? LateralMoveSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LateralMoveSpeed);
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060045B8 RID: 17848 RVA: 0x000B1E20 File Offset: 0x000B0020
		public virtual float? LateralAccelerateTime
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LateralAccelerateTime);
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060045B9 RID: 17849 RVA: 0x000B1E58 File Offset: 0x000B0058
		public virtual float? LateralDecelerateTime
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LateralDecelerateTime);
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060045BA RID: 17850 RVA: 0x000B1E90 File Offset: 0x000B0090
		public virtual float? MaxLateralOffset
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MaxLateralOffset);
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060045BB RID: 17851 RVA: 0x000B1EC8 File Offset: 0x000B00C8
		public virtual float? VerticalMoveSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new float?(this.Instance.VerticalMoveSpeed);
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060045BC RID: 17852 RVA: 0x000B1F04 File Offset: 0x000B0104
		public virtual float? VerticalAccelerateTime
		{
			get
			{
				if ((this.Instance.NullMask & 256) == 0)
				{
					return null;
				}
				return new float?(this.Instance.VerticalAccelerateTime);
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x000B1F40 File Offset: 0x000B0140
		public virtual float? VerticalDecelerateTime
		{
			get
			{
				if ((this.Instance.NullMask & 512) == 0)
				{
					return null;
				}
				return new float?(this.Instance.VerticalDecelerateTime);
			}
		}

		// Token: 0x04002715 RID: 10005
		private IChongLouHook Instance;

		// Token: 0x04002716 RID: 10006
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002717 RID: 10007
		private bool _HookActionsInited;

		// Token: 0x04002718 RID: 10008
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002719 RID: 10009
		private bool _ExitHookActionsInited;

		// Token: 0x0400271A RID: 10010
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x0400271B RID: 10011
		private bool _FinishActionsInited;

		// Token: 0x0400271C RID: 10012
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400271D RID: 10013
		private bool _ClientHookActionConfigInited;
	}
}
