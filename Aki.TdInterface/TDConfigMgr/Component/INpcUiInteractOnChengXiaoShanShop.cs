using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005EF RID: 1519
	public class INpcUiInteractOnChengXiaoShanShop : INpcUiInteractType
	{
		// Token: 0x06001F20 RID: 7968 RVA: 0x00057B7C File Offset: 0x00055D7C
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

		// Token: 0x06001F21 RID: 7969 RVA: 0x00057BB4 File Offset: 0x00055DB4
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

		// Token: 0x06001F22 RID: 7970 RVA: 0x00057BC7 File Offset: 0x00055DC7
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

		// Token: 0x06001F23 RID: 7971 RVA: 0x00057BDC File Offset: 0x00055DDC
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

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00057C66 File Offset: 0x00055E66
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00057C91 File Offset: 0x00055E91
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

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x00057C9F File Offset: 0x00055E9F
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x00057CCA File Offset: 0x00055ECA
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

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x00057CD8 File Offset: 0x00055ED8
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x00057D03 File Offset: 0x00055F03
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

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x00057D11 File Offset: 0x00055F11
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x00057D3C File Offset: 0x00055F3C
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

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x00057D4C File Offset: 0x00055F4C
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x00057DAD File Offset: 0x00055FAD
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

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x00057DC4 File Offset: 0x00055FC4
		// (set) Token: 0x06001F2F RID: 7983 RVA: 0x00057E25 File Offset: 0x00056025
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

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00057E3C File Offset: 0x0005603C
		// (set) Token: 0x06001F31 RID: 7985 RVA: 0x00057E9D File Offset: 0x0005609D
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

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x00057EB2 File Offset: 0x000560B2
		// (set) Token: 0x06001F33 RID: 7987 RVA: 0x00057EDD File Offset: 0x000560DD
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

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00057EEB File Offset: 0x000560EB
		// (set) Token: 0x06001F35 RID: 7989 RVA: 0x00057F16 File Offset: 0x00056116
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

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x00057F24 File Offset: 0x00056124
		// (set) Token: 0x06001F37 RID: 7991 RVA: 0x00057F5E File Offset: 0x0005615E
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

		// Token: 0x0400161F RID: 5663
		[Nullable(2)]
		protected new INpcUiInteractOnChengXiaoShanShop FbInstance;

		// Token: 0x04001620 RID: 5664
		[Nullable(2)]
		protected new INpcUiInteractOnChengXiaoShanShop_SetValue PocoInterface;

		// Token: 0x04001621 RID: 5665
		private PlayFlow _EnterFlowCache;

		// Token: 0x04001622 RID: 5666
		private bool _EnterFlowInited;

		// Token: 0x04001623 RID: 5667
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04001624 RID: 5668
		private bool _ShopSuccessFlowInited;

		// Token: 0x04001625 RID: 5669
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x04001626 RID: 5670
		private bool _ShopFailedFlowInited;
	}
}
