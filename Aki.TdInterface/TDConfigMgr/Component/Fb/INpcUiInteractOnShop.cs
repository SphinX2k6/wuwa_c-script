using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBE RID: 3006
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShop : INpcUiInteractType
	{
		// Token: 0x060044EB RID: 17643 RVA: 0x000AECDD File Offset: 0x000ACEDD
		[NullableContext(1)]
		public static INpcUiInteractOnShop Create(INpcUiInteractOnShop? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnShop
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x000AECFC File Offset: 0x000ACEFC
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x060044ED RID: 17645 RVA: 0x000AED09 File Offset: 0x000ACF09
		[Nullable(1)]
		public virtual string EnterMontage
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x000AED16 File Offset: 0x000ACF16
		[Nullable(1)]
		public virtual string StandByMontage
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x060044EF RID: 17647 RVA: 0x000AED23 File Offset: 0x000ACF23
		[Nullable(1)]
		public virtual string ShopSuccessMontage
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x000AED30 File Offset: 0x000ACF30
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

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x060044F1 RID: 17649 RVA: 0x000AED64 File Offset: 0x000ACF64
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

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x000AED98 File Offset: 0x000ACF98
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

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x000AEDCC File Offset: 0x000ACFCC
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

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x000AEE00 File Offset: 0x000AD000
		[Nullable(1)]
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ExitMontage
		{
			[NullableContext(1)]
			get
			{
				if (this._ExitMontageInited)
				{
					return this._ExitMontageCache;
				}
				this._ExitMontageInited = true;
				this._ExitMontageCache = ComponentReadHelper.ReadINpcUiInteractOnShop_ExitMontage(this.Instance);
				return this._ExitMontageCache;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x000AEE2F File Offset: 0x000AD02F
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

		// Token: 0x040026FB RID: 9979
		private INpcUiInteractOnShop Instance;

		// Token: 0x040026FC RID: 9980
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x040026FD RID: 9981
		private bool _EnterFlowInited;

		// Token: 0x040026FE RID: 9982
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x040026FF RID: 9983
		private bool _ShopSuccessFlowInited;

		// Token: 0x04002700 RID: 9984
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x04002701 RID: 9985
		private bool _ShopFailedFlowInited;

		// Token: 0x04002702 RID: 9986
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _WorkingFlowCache;

		// Token: 0x04002703 RID: 9987
		private bool _WorkingFlowInited;

		// Token: 0x04002704 RID: 9988
		[Nullable(1)]
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x04002705 RID: 9989
		private bool _ExitMontageInited;

		// Token: 0x04002706 RID: 9990
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x04002707 RID: 9991
		private bool _ExitFlowInited;
	}
}
