using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8D RID: 3213
	public class INpcUiInteractOnAntiqueShop : INpcUiInteractType
	{
		// Token: 0x06004950 RID: 18768 RVA: 0x000B8F2F File Offset: 0x000B712F
		public static INpcUiInteractOnAntiqueShop Create(INpcUiInteractOnAntiqueShop? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnAntiqueShop
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06004951 RID: 18769 RVA: 0x000B8F4E File Offset: 0x000B714E
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06004952 RID: 18770 RVA: 0x000B8F5B File Offset: 0x000B715B
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x000B8F68 File Offset: 0x000B7168
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06004954 RID: 18772 RVA: 0x000B8F75 File Offset: 0x000B7175
		public virtual string ShopSuccessMontage
		{
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x000B8F82 File Offset: 0x000B7182
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow EnterFlow
		{
			get
			{
				if (this._EnterFlowInited)
				{
					return this._EnterFlowCache;
				}
				this._EnterFlowInited = true;
				this._EnterFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.EnterFlow);
				return this._EnterFlowCache;
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06004956 RID: 18774 RVA: 0x000B8FB6 File Offset: 0x000B71B6
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow ShopSuccessFlow
		{
			get
			{
				if (this._ShopSuccessFlowInited)
				{
					return this._ShopSuccessFlowCache;
				}
				this._ShopSuccessFlowInited = true;
				this._ShopSuccessFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.ShopSuccessFlow);
				return this._ShopSuccessFlowCache;
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x000B8FEA File Offset: 0x000B71EA
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow ShopFailedFlow
		{
			get
			{
				if (this._ShopFailedFlowInited)
				{
					return this._ShopFailedFlowCache;
				}
				this._ShopFailedFlowInited = true;
				this._ShopFailedFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.ShopFailedFlow);
				return this._ShopFailedFlowCache;
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06004958 RID: 18776 RVA: 0x000B901E File Offset: 0x000B721E
		public virtual string UpgradeSequence
		{
			get
			{
				return this.Instance.UpgradeSequence;
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06004959 RID: 18777 RVA: 0x000B902B File Offset: 0x000B722B
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ExitMontage
		{
			get
			{
				if (this._ExitMontageInited)
				{
					return this._ExitMontageCache;
				}
				this._ExitMontageInited = true;
				this._ExitMontageCache = ComponentReadHelper.ReadINpcUiInteractOnAntiqueShop_ExitMontage(this.Instance);
				return this._ExitMontageCache;
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x0600495A RID: 18778 RVA: 0x000B905A File Offset: 0x000B725A
		[Nullable(2)]
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow ExitFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._ExitFlowInited)
				{
					return this._ExitFlowCache;
				}
				this._ExitFlowInited = true;
				this._ExitFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.ExitFlow);
				return this._ExitFlowCache;
			}
		}

		// Token: 0x04002950 RID: 10576
		private INpcUiInteractOnAntiqueShop Instance;

		// Token: 0x04002951 RID: 10577
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x04002952 RID: 10578
		private bool _EnterFlowInited;

		// Token: 0x04002953 RID: 10579
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04002954 RID: 10580
		private bool _ShopSuccessFlowInited;

		// Token: 0x04002955 RID: 10581
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x04002956 RID: 10582
		private bool _ShopFailedFlowInited;

		// Token: 0x04002957 RID: 10583
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x04002958 RID: 10584
		private bool _ExitMontageInited;

		// Token: 0x04002959 RID: 10585
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x0400295A RID: 10586
		private bool _ExitFlowInited;
	}
}
