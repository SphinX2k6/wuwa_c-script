using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000584 RID: 1412
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnAntiqueShop : INpcUiInteractType
	{
		// Token: 0x06001D00 RID: 7424 RVA: 0x00052894 File Offset: 0x00050A94
		private INpcUiInteractOnAntiqueShop_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnAntiqueShop 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnAntiqueShop_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnAntiqueShop_SetValue());
			}
			return result;
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x000528CC File Offset: 0x00050ACC
		public static INpcUiInteractOnAntiqueShop Create([Nullable(2)] INpcUiInteractOnAntiqueShop instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnAntiqueShop
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000528DF File Offset: 0x00050ADF
		public static INpcUiInteractOnAntiqueShop CreateFromSetValue([Nullable(2)] INpcUiInteractOnAntiqueShop_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnAntiqueShop
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000528F4 File Offset: 0x00050AF4
		public new INpcUiInteractOnAntiqueShop_SetValue ToSetValue()
		{
			return new INpcUiInteractOnAntiqueShop_SetValue
			{
				Type = this.Type,
				EnterMontage = this.EnterMontage,
				StandByMontage = this.StandByMontage,
				ShopSuccessMontage = this.ShopSuccessMontage,
				EnterFlow = this.EnterFlow,
				ShopSuccessFlow = this.ShopSuccessFlow,
				ShopFailedFlow = this.ShopFailedFlow,
				UpgradeSequence = this.UpgradeSequence,
				ExitMontage = this.ExitMontage,
				ExitFlow = this.ExitFlow
			};
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0005297E File Offset: 0x00050B7E
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x000529A9 File Offset: 0x00050BA9
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

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000529B7 File Offset: 0x00050BB7
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x000529E2 File Offset: 0x00050BE2
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

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x000529F0 File Offset: 0x00050BF0
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x00052A1B File Offset: 0x00050C1B
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

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00052A29 File Offset: 0x00050C29
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x00052A54 File Offset: 0x00050C54
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

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x00052A64 File Offset: 0x00050C64
		// (set) Token: 0x06001D0D RID: 7437 RVA: 0x00052AC5 File Offset: 0x00050CC5
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
					INpcUiInteractOnAntiqueShop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x00052ADC File Offset: 0x00050CDC
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x00052B3D File Offset: 0x00050D3D
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
					INpcUiInteractOnAntiqueShop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00052B54 File Offset: 0x00050D54
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x00052BB5 File Offset: 0x00050DB5
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
					INpcUiInteractOnAntiqueShop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00052BCA File Offset: 0x00050DCA
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x00052BF5 File Offset: 0x00050DF5
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

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00052C03 File Offset: 0x00050E03
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x00052C2A File Offset: 0x00050E2A
		[Nullable(2)]
		public virtual IMontageConfig ExitMontage
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitMontage;
				}
				INpcUiInteractOnAntiqueShop_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExitMontage;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ExitMontage = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00052C38 File Offset: 0x00050E38
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x00052C99 File Offset: 0x00050E99
		[Nullable(2)]
		public virtual PlayFlow ExitFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._ExitFlowInited)
				{
					return this._ExitFlowCache;
				}
				this._ExitFlowInited = true;
				if (this.FbInstance != null)
				{
					this._ExitFlowCache = PlayFlow.Create(this.FbInstance.ExitFlow);
				}
				else
				{
					INpcUiInteractOnAntiqueShop_SetValue pocoInterface = this.PocoInterface;
					this._ExitFlowCache = ((pocoInterface != null) ? pocoInterface.ExitFlow : null);
				}
				return this._ExitFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ExitFlow = value;
				this._ExitFlowInited = false;
			}
		}

		// Token: 0x0400149D RID: 5277
		[Nullable(2)]
		protected new INpcUiInteractOnAntiqueShop FbInstance;

		// Token: 0x0400149E RID: 5278
		[Nullable(2)]
		protected new INpcUiInteractOnAntiqueShop_SetValue PocoInterface;

		// Token: 0x0400149F RID: 5279
		private PlayFlow _EnterFlowCache;

		// Token: 0x040014A0 RID: 5280
		private bool _EnterFlowInited;

		// Token: 0x040014A1 RID: 5281
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x040014A2 RID: 5282
		private bool _ShopSuccessFlowInited;

		// Token: 0x040014A3 RID: 5283
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x040014A4 RID: 5284
		private bool _ShopFailedFlowInited;

		// Token: 0x040014A5 RID: 5285
		private PlayFlow _ExitFlowCache;

		// Token: 0x040014A6 RID: 5286
		private bool _ExitFlowInited;
	}
}
