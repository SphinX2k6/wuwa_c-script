using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC5 RID: 3013
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnVillageInfr : INpcUiInteractType
	{
		// Token: 0x0600453F RID: 17727 RVA: 0x000AF748 File Offset: 0x000AD948
		public static INpcUiInteractOnVillageInfr Create(INpcUiInteractOnVillageInfr? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnVillageInfr
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06004540 RID: 17728 RVA: 0x000AF767 File Offset: 0x000AD967
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06004541 RID: 17729 RVA: 0x000AF774 File Offset: 0x000AD974
		public virtual Aki.TDConfigMgr.Action.IMontageConfig EnterMontage
		{
			get
			{
				if (this._EnterMontageInited)
				{
					return this._EnterMontageCache;
				}
				this._EnterMontageInited = true;
				this._EnterMontageCache = ComponentReadHelper.ReadINpcUiInteractOnVillageInfr_EnterMontage(this.Instance);
				return this._EnterMontageCache;
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06004542 RID: 17730 RVA: 0x000AF7A3 File Offset: 0x000AD9A3
		public virtual Aki.TDConfigMgr.Action.IMontageConfig DeliverSuccessMontage
		{
			get
			{
				if (this._DeliverSuccessMontageInited)
				{
					return this._DeliverSuccessMontageCache;
				}
				this._DeliverSuccessMontageInited = true;
				this._DeliverSuccessMontageCache = ComponentReadHelper.ReadINpcUiInteractOnVillageInfr_DeliverSuccessMontage(this.Instance);
				return this._DeliverSuccessMontageCache;
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x000AF7D2 File Offset: 0x000AD9D2
		public virtual Aki.TDConfigMgr.Action.IMontageConfig CompleteMontage
		{
			get
			{
				if (this._CompleteMontageInited)
				{
					return this._CompleteMontageCache;
				}
				this._CompleteMontageInited = true;
				this._CompleteMontageCache = ComponentReadHelper.ReadINpcUiInteractOnVillageInfr_CompleteMontage(this.Instance);
				return this._CompleteMontageCache;
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06004544 RID: 17732 RVA: 0x000AF801 File Offset: 0x000ADA01
		[Nullable(2)]
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow EnterFlow
		{
			[NullableContext(2)]
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

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x000AF835 File Offset: 0x000ADA35
		[Nullable(2)]
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow DeliverSuccessFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._DeliverSuccessFlowInited)
				{
					return this._DeliverSuccessFlowCache;
				}
				this._DeliverSuccessFlowInited = true;
				this._DeliverSuccessFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.DeliverSuccessFlow);
				return this._DeliverSuccessFlowCache;
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06004546 RID: 17734 RVA: 0x000AF869 File Offset: 0x000ADA69
		[Nullable(2)]
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow CompleteFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._CompleteFlowInited)
				{
					return this._CompleteFlowCache;
				}
				this._CompleteFlowInited = true;
				this._CompleteFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.CompleteFlow);
				return this._CompleteFlowCache;
			}
		}

		// Token: 0x0400274E RID: 10062
		private INpcUiInteractOnVillageInfr Instance;

		// Token: 0x0400274F RID: 10063
		private Aki.TDConfigMgr.Action.IMontageConfig _EnterMontageCache;

		// Token: 0x04002750 RID: 10064
		private bool _EnterMontageInited;

		// Token: 0x04002751 RID: 10065
		private Aki.TDConfigMgr.Action.IMontageConfig _DeliverSuccessMontageCache;

		// Token: 0x04002752 RID: 10066
		private bool _DeliverSuccessMontageInited;

		// Token: 0x04002753 RID: 10067
		private Aki.TDConfigMgr.Action.IMontageConfig _CompleteMontageCache;

		// Token: 0x04002754 RID: 10068
		private bool _CompleteMontageInited;

		// Token: 0x04002755 RID: 10069
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x04002756 RID: 10070
		private bool _EnterFlowInited;

		// Token: 0x04002757 RID: 10071
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _DeliverSuccessFlowCache;

		// Token: 0x04002758 RID: 10072
		private bool _DeliverSuccessFlowInited;

		// Token: 0x04002759 RID: 10073
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _CompleteFlowCache;

		// Token: 0x0400275A RID: 10074
		private bool _CompleteFlowInited;
	}
}
