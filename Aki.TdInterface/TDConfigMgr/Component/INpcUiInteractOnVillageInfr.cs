using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000598 RID: 1432
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnVillageInfr : INpcUiInteractType
	{
		// Token: 0x06001DF4 RID: 7668 RVA: 0x00055070 File Offset: 0x00053270
		[NullableContext(1)]
		private INpcUiInteractOnVillageInfr_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnVillageInfr 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnVillageInfr_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnVillageInfr_SetValue());
			}
			return result;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x000550A8 File Offset: 0x000532A8
		[NullableContext(1)]
		public static INpcUiInteractOnVillageInfr Create([Nullable(2)] INpcUiInteractOnVillageInfr instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnVillageInfr
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x000550BB File Offset: 0x000532BB
		[NullableContext(1)]
		public static INpcUiInteractOnVillageInfr CreateFromSetValue([Nullable(2)] INpcUiInteractOnVillageInfr_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnVillageInfr
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x000550D0 File Offset: 0x000532D0
		[NullableContext(1)]
		public new INpcUiInteractOnVillageInfr_SetValue ToSetValue()
		{
			return new INpcUiInteractOnVillageInfr_SetValue
			{
				Type = this.Type,
				EnterMontage = this.EnterMontage,
				DeliverSuccessMontage = this.DeliverSuccessMontage,
				CompleteMontage = this.CompleteMontage,
				EnterFlow = this.EnterFlow,
				DeliverSuccessFlow = this.DeliverSuccessFlow,
				CompleteFlow = this.CompleteFlow
			};
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x00055136 File Offset: 0x00053336
		// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x00055161 File Offset: 0x00053361
		public override ENpcUiInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x0005516F File Offset: 0x0005336F
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x00055196 File Offset: 0x00053396
		public virtual IMontageConfig EnterMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterMontage;
				}
				INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnterMontage;
			}
			set
			{
				this.GetOrCreatePoco().EnterMontage = value;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x000551A4 File Offset: 0x000533A4
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x000551CB File Offset: 0x000533CB
		public virtual IMontageConfig DeliverSuccessMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DeliverSuccessMontage;
				}
				INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DeliverSuccessMontage;
			}
			set
			{
				this.GetOrCreatePoco().DeliverSuccessMontage = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x000551D9 File Offset: 0x000533D9
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x00055200 File Offset: 0x00053400
		public virtual IMontageConfig CompleteMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CompleteMontage;
				}
				INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CompleteMontage;
			}
			set
			{
				this.GetOrCreatePoco().CompleteMontage = value;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x00055210 File Offset: 0x00053410
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x00055271 File Offset: 0x00053471
		public virtual PlayFlow EnterFlow
		{
			get
			{
				if (this._EnterFlowInited)
				{
					return this._EnterFlowCache;
				}
				this._EnterFlowInited = true;
				if (this.FbInstance != null)
				{
					this._EnterFlowCache = PlayFlow.Create(this.FbInstance.EnterFlow);
				}
				else
				{
					INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
					this._EnterFlowCache = ((pocoInterface != null) ? pocoInterface.EnterFlow : null);
				}
				return this._EnterFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().EnterFlow = value;
				this._EnterFlowInited = false;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00055288 File Offset: 0x00053488
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x000552E9 File Offset: 0x000534E9
		public virtual PlayFlow DeliverSuccessFlow
		{
			get
			{
				if (this._DeliverSuccessFlowInited)
				{
					return this._DeliverSuccessFlowCache;
				}
				this._DeliverSuccessFlowInited = true;
				if (this.FbInstance != null)
				{
					this._DeliverSuccessFlowCache = PlayFlow.Create(this.FbInstance.DeliverSuccessFlow);
				}
				else
				{
					INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
					this._DeliverSuccessFlowCache = ((pocoInterface != null) ? pocoInterface.DeliverSuccessFlow : null);
				}
				return this._DeliverSuccessFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().DeliverSuccessFlow = value;
				this._DeliverSuccessFlowInited = false;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00055300 File Offset: 0x00053500
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x00055361 File Offset: 0x00053561
		public virtual PlayFlow CompleteFlow
		{
			get
			{
				if (this._CompleteFlowInited)
				{
					return this._CompleteFlowCache;
				}
				this._CompleteFlowInited = true;
				if (this.FbInstance != null)
				{
					this._CompleteFlowCache = PlayFlow.Create(this.FbInstance.CompleteFlow);
				}
				else
				{
					INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
					this._CompleteFlowCache = ((pocoInterface != null) ? pocoInterface.CompleteFlow : null);
				}
				return this._CompleteFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().CompleteFlow = value;
				this._CompleteFlowInited = false;
			}
		}

		// Token: 0x0400155F RID: 5471
		protected new INpcUiInteractOnVillageInfr FbInstance;

		// Token: 0x04001560 RID: 5472
		protected new INpcUiInteractOnVillageInfr_SetValue PocoInterface;

		// Token: 0x04001561 RID: 5473
		[Nullable(1)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x04001562 RID: 5474
		private bool _EnterFlowInited;

		// Token: 0x04001563 RID: 5475
		[Nullable(1)]
		private PlayFlow _DeliverSuccessFlowCache;

		// Token: 0x04001564 RID: 5476
		private bool _DeliverSuccessFlowInited;

		// Token: 0x04001565 RID: 5477
		[Nullable(1)]
		private PlayFlow _CompleteFlowCache;

		// Token: 0x04001566 RID: 5478
		private bool _CompleteFlowInited;
	}
}
