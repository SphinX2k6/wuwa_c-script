using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC7 RID: 3015
	[NullableContext(2)]
	[Nullable(0)]
	public class IRagDollClimbingPoint : IHookInteractType
	{
		// Token: 0x060044F9 RID: 17657 RVA: 0x000AF5CE File Offset: 0x000AD7CE
		[NullableContext(0)]
		public static IRagDollClimbingPoint Create(IRagDollClimbingPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRagDollClimbingPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x000AF5ED File Offset: 0x000AD7ED
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x060044FB RID: 17659 RVA: 0x000AF5FC File Offset: 0x000AD7FC
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

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x000AF678 File Offset: 0x000AD878
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

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x060044FD RID: 17661 RVA: 0x000AF6F4 File Offset: 0x000AD8F4
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

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x000AF76E File Offset: 0x000AD96E
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

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x060044FF RID: 17663 RVA: 0x000AF7A4 File Offset: 0x000AD9A4
		public virtual bool? IsSummitPoint
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSummitPoint);
			}
		}

		// Token: 0x04002678 RID: 9848
		private IRagDollClimbingPoint Instance;

		// Token: 0x04002679 RID: 9849
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400267A RID: 9850
		private bool _HookActionsInited;

		// Token: 0x0400267B RID: 9851
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400267C RID: 9852
		private bool _ExitHookActionsInited;

		// Token: 0x0400267D RID: 9853
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x0400267E RID: 9854
		private bool _FinishActionsInited;

		// Token: 0x0400267F RID: 9855
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002680 RID: 9856
		private bool _ClientHookActionConfigInited;
	}
}
