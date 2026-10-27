using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000586 RID: 1414
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnChengXiaoShanShop : INpcUiInteractType
	{
		// Token: 0x06001D1A RID: 7450 RVA: 0x00052CC0 File Offset: 0x00050EC0
		private INpcUiInteractOnChengXiaoShanShop_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnChengXiaoShanShop 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnChengXiaoShanShop_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnChengXiaoShanShop_SetValue());
			}
			return result;
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00052CF8 File Offset: 0x00050EF8
		public static INpcUiInteractOnChengXiaoShanShop Create([Nullable(2)] INpcUiInteractOnChengXiaoShanShop instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnChengXiaoShanShop
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00052D0B File Offset: 0x00050F0B
		public static INpcUiInteractOnChengXiaoShanShop CreateFromSetValue([Nullable(2)] INpcUiInteractOnChengXiaoShanShop_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnChengXiaoShanShop
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00052D20 File Offset: 0x00050F20
		public new INpcUiInteractOnChengXiaoShanShop_SetValue ToSetValue()
		{
			return new INpcUiInteractOnChengXiaoShanShop_SetValue
			{
				Type = this.Type,
				EnterMontage = this.EnterMontage,
				StandByMontage = this.StandByMontage,
				ShopSuccessMontage = this.ShopSuccessMontage,
				EnterFlow = this.EnterFlow,
				ShopSuccessFlow = this.ShopSuccessFlow,
				ShopFailedFlow = this.ShopFailedFlow,
				UpgradeSequence = this.UpgradeSequence,
				FinishDeliverySequence = this.FinishDeliverySequence,
				ShowNpcWhilePlayingSequence = this.ShowNpcWhilePlayingSequence
			};
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00052DAA File Offset: 0x00050FAA
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00052DD5 File Offset: 0x00050FD5
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

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00052DE3 File Offset: 0x00050FE3
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x00052E0E File Offset: 0x0005100E
		public virtual string EnterMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EnterMontage;
			}
			set
			{
				this.GetOrCreatePoco().EnterMontage = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x00052E1C File Offset: 0x0005101C
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00052E47 File Offset: 0x00051047
		public virtual string StandByMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StandByMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.StandByMontage;
			}
			set
			{
				this.GetOrCreatePoco().StandByMontage = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x00052E55 File Offset: 0x00051055
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00052E80 File Offset: 0x00051080
		public virtual string ShopSuccessMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShopSuccessMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ShopSuccessMontage;
			}
			set
			{
				this.GetOrCreatePoco().ShopSuccessMontage = value;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x00052E90 File Offset: 0x00051090
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x00052EF1 File Offset: 0x000510F1
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
					INpcUiInteractOnChengXiaoShanShop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00052F08 File Offset: 0x00051108
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x00052F69 File Offset: 0x00051169
		public virtual PlayFlow ShopSuccessFlow
		{
			get
			{
				if (this._ShopSuccessFlowInited)
				{
					return this._ShopSuccessFlowCache;
				}
				this._ShopSuccessFlowInited = true;
				if (this.FbInstance != null)
				{
					this._ShopSuccessFlowCache = PlayFlow.Create(this.FbInstance.ShopSuccessFlow);
				}
				else
				{
					INpcUiInteractOnChengXiaoShanShop_SetValue pocoInterface = this.PocoInterface;
					this._ShopSuccessFlowCache = ((pocoInterface != null) ? pocoInterface.ShopSuccessFlow : null);
				}
				return this._ShopSuccessFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().ShopSuccessFlow = value;
				this._ShopSuccessFlowInited = false;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00052F80 File Offset: 0x00051180
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x00052FE1 File Offset: 0x000511E1
		public virtual PlayFlow ShopFailedFlow
		{
			get
			{
				if (this._ShopFailedFlowInited)
				{
					return this._ShopFailedFlowCache;
				}
				this._ShopFailedFlowInited = true;
				if (this.FbInstance != null)
				{
					this._ShopFailedFlowCache = PlayFlow.Create(this.FbInstance.ShopFailedFlow);
				}
				else
				{
					INpcUiInteractOnChengXiaoShanShop_SetValue pocoInterface = this.PocoInterface;
					this._ShopFailedFlowCache = ((pocoInterface != null) ? pocoInterface.ShopFailedFlow : null);
				}
				return this._ShopFailedFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().ShopFailedFlow = value;
				this._ShopFailedFlowInited = false;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00052FF6 File Offset: 0x000511F6
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x00053021 File Offset: 0x00051221
		public virtual string UpgradeSequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UpgradeSequence;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.UpgradeSequence;
			}
			set
			{
				this.GetOrCreatePoco().UpgradeSequence = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x0005302F File Offset: 0x0005122F
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x0005305A File Offset: 0x0005125A
		public virtual string FinishDeliverySequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FinishDeliverySequence;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.FinishDeliverySequence;
			}
			set
			{
				this.GetOrCreatePoco().FinishDeliverySequence = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00053068 File Offset: 0x00051268
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x000530A2 File Offset: 0x000512A2
		public virtual bool? ShowNpcWhilePlayingSequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowNpcWhilePlayingSequence;
				}
				INpcUiInteractOnChengXiaoShanShop_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowNpcWhilePlayingSequence;
			}
			set
			{
				this.GetOrCreatePoco().ShowNpcWhilePlayingSequence = value;
			}
		}

		// Token: 0x040014B1 RID: 5297
		[Nullable(2)]
		protected new INpcUiInteractOnChengXiaoShanShop FbInstance;

		// Token: 0x040014B2 RID: 5298
		[Nullable(2)]
		protected new INpcUiInteractOnChengXiaoShanShop_SetValue PocoInterface;

		// Token: 0x040014B3 RID: 5299
		private PlayFlow _EnterFlowCache;

		// Token: 0x040014B4 RID: 5300
		private bool _EnterFlowInited;

		// Token: 0x040014B5 RID: 5301
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x040014B6 RID: 5302
		private bool _ShopSuccessFlowInited;

		// Token: 0x040014B7 RID: 5303
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x040014B8 RID: 5304
		private bool _ShopFailedFlowInited;
	}
}
