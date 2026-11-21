using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C92 RID: 3218
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShopNew : INpcUiInteractType
	{
		// Token: 0x0600498C RID: 18828 RVA: 0x000B9618 File Offset: 0x000B7818
		[NullableContext(0)]
		public static INpcUiInteractOnShopNew Create(INpcUiInteractOnShopNew? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnShopNew
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x000B9637 File Offset: 0x000B7837
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x0600498E RID: 18830 RVA: 0x000B9644 File Offset: 0x000B7844
		[Nullable(0)]
		public virtual Aki.TDConfigMgr.Action.IMontageConfig EnterMontage
		{
			[NullableContext(0)]
			get
			{
				if (this._EnterMontageInited)
				{
					return this._EnterMontageCache;
				}
				this._EnterMontageInited = true;
				this._EnterMontageCache = ComponentReadHelper.ReadINpcUiInteractOnShopNew_EnterMontage(this.Instance);
				return this._EnterMontageCache;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x000B9673 File Offset: 0x000B7873
		[Nullable(0)]
		public virtual Aki.TDConfigMgr.Action.IMontageConfig StandByMontage
		{
			[NullableContext(0)]
			get
			{
				if (this._StandByMontageInited)
				{
					return this._StandByMontageCache;
				}
				this._StandByMontageInited = true;
				this._StandByMontageCache = ComponentReadHelper.ReadINpcUiInteractOnShopNew_StandByMontage(this.Instance);
				return this._StandByMontageCache;
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06004990 RID: 18832 RVA: 0x000B96A2 File Offset: 0x000B78A2
		[Nullable(0)]
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ShopSuccessMontage
		{
			[NullableContext(0)]
			get
			{
				if (this._ShopSuccessMontageInited)
				{
					return this._ShopSuccessMontageCache;
				}
				this._ShopSuccessMontageInited = true;
				this._ShopSuccessMontageCache = ComponentReadHelper.ReadINpcUiInteractOnShopNew_ShopSuccessMontage(this.Instance);
				return this._ShopSuccessMontageCache;
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06004991 RID: 18833 RVA: 0x000B96D1 File Offset: 0x000B78D1
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

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x06004992 RID: 18834 RVA: 0x000B9705 File Offset: 0x000B7905
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

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06004993 RID: 18835 RVA: 0x000B9739 File Offset: 0x000B7939
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

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06004994 RID: 18836 RVA: 0x000B976D File Offset: 0x000B796D
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow WorkingFlow
		{
			get
			{
				if (this._WorkingFlowInited)
				{
					return this._WorkingFlowCache;
				}
				this._WorkingFlowInited = true;
				this._WorkingFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.WorkingFlow);
				return this._WorkingFlowCache;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06004995 RID: 18837 RVA: 0x000B97A1 File Offset: 0x000B79A1
		[Nullable(0)]
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ExitMontage
		{
			[NullableContext(0)]
			get
			{
				if (this._ExitMontageInited)
				{
					return this._ExitMontageCache;
				}
				this._ExitMontageInited = true;
				this._ExitMontageCache = ComponentReadHelper.ReadINpcUiInteractOnShopNew_ExitMontage(this.Instance);
				return this._ExitMontageCache;
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06004996 RID: 18838 RVA: 0x000B97D0 File Offset: 0x000B79D0
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow ExitFlow
		{
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

		// Token: 0x04002983 RID: 10627
		private INpcUiInteractOnShopNew Instance;

		// Token: 0x04002984 RID: 10628
		[Nullable(0)]
		private Aki.TDConfigMgr.Action.IMontageConfig _EnterMontageCache;

		// Token: 0x04002985 RID: 10629
		private bool _EnterMontageInited;

		// Token: 0x04002986 RID: 10630
		[Nullable(0)]
		private Aki.TDConfigMgr.Action.IMontageConfig _StandByMontageCache;

		// Token: 0x04002987 RID: 10631
		private bool _StandByMontageInited;

		// Token: 0x04002988 RID: 10632
		[Nullable(0)]
		private Aki.TDConfigMgr.Action.IMontageConfig _ShopSuccessMontageCache;

		// Token: 0x04002989 RID: 10633
		private bool _ShopSuccessMontageInited;

		// Token: 0x0400298A RID: 10634
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x0400298B RID: 10635
		private bool _EnterFlowInited;

		// Token: 0x0400298C RID: 10636
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x0400298D RID: 10637
		private bool _ShopSuccessFlowInited;

		// Token: 0x0400298E RID: 10638
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x0400298F RID: 10639
		private bool _ShopFailedFlowInited;

		// Token: 0x04002990 RID: 10640
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _WorkingFlowCache;

		// Token: 0x04002991 RID: 10641
		private bool _WorkingFlowInited;

		// Token: 0x04002992 RID: 10642
		[Nullable(0)]
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x04002993 RID: 10643
		private bool _ExitMontageInited;

		// Token: 0x04002994 RID: 10644
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x04002995 RID: 10645
		private bool _ExitFlowInited;
	}
}
