using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C93 RID: 3219
	public class INpcUiInteractOnVillageInfr : INpcUiInteractType
	{
		// Token: 0x06004998 RID: 18840 RVA: 0x000B980C File Offset: 0x000B7A0C
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

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06004999 RID: 18841 RVA: 0x000B982B File Offset: 0x000B7A2B
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x0600499A RID: 18842 RVA: 0x000B9838 File Offset: 0x000B7A38
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

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x0600499B RID: 18843 RVA: 0x000B9867 File Offset: 0x000B7A67
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

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x0600499C RID: 18844 RVA: 0x000B9896 File Offset: 0x000B7A96
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

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x000B98C5 File Offset: 0x000B7AC5
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

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x0600499E RID: 18846 RVA: 0x000B98F9 File Offset: 0x000B7AF9
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

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x0600499F RID: 18847 RVA: 0x000B992D File Offset: 0x000B7B2D
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

		// Token: 0x04002996 RID: 10646
		private INpcUiInteractOnVillageInfr Instance;

		// Token: 0x04002997 RID: 10647
		private Aki.TDConfigMgr.Action.IMontageConfig _EnterMontageCache;

		// Token: 0x04002998 RID: 10648
		private bool _EnterMontageInited;

		// Token: 0x04002999 RID: 10649
		private Aki.TDConfigMgr.Action.IMontageConfig _DeliverSuccessMontageCache;

		// Token: 0x0400299A RID: 10650
		private bool _DeliverSuccessMontageInited;

		// Token: 0x0400299B RID: 10651
		private Aki.TDConfigMgr.Action.IMontageConfig _CompleteMontageCache;

		// Token: 0x0400299C RID: 10652
		private bool _CompleteMontageInited;

		// Token: 0x0400299D RID: 10653
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x0400299E RID: 10654
		private bool _EnterFlowInited;

		// Token: 0x0400299F RID: 10655
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _DeliverSuccessFlowCache;

		// Token: 0x040029A0 RID: 10656
		private bool _DeliverSuccessFlowInited;

		// Token: 0x040029A1 RID: 10657
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _CompleteFlowCache;

		// Token: 0x040029A2 RID: 10658
		private bool _CompleteFlowInited;
	}
}
