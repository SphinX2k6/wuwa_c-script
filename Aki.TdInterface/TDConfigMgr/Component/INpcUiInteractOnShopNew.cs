using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F9 RID: 1529
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShopNew : INpcUiInteractType
	{
		// Token: 0x06001F8C RID: 8076 RVA: 0x00058CC8 File Offset: 0x00056EC8
		[NullableContext(0)]
		private INpcUiInteractOnShopNew_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnShopNew 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnShopNew_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnShopNew_SetValue());
			}
			return result;
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00058D00 File Offset: 0x00056F00
		[NullableContext(0)]
		public static INpcUiInteractOnShopNew Create([Nullable(2)] INpcUiInteractOnShopNew instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnShopNew
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00058D13 File Offset: 0x00056F13
		[NullableContext(0)]
		public static INpcUiInteractOnShopNew CreateFromSetValue([Nullable(2)] INpcUiInteractOnShopNew_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnShopNew
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00058D28 File Offset: 0x00056F28
		[NullableContext(0)]
		public new INpcUiInteractOnShopNew_SetValue ToSetValue()
		{
			return new INpcUiInteractOnShopNew_SetValue
			{
				Type = this.Type,
				EnterMontage = this.EnterMontage,
				StandByMontage = this.StandByMontage,
				ShopSuccessMontage = this.ShopSuccessMontage,
				EnterFlow = this.EnterFlow,
				ShopSuccessFlow = this.ShopSuccessFlow,
				ShopFailedFlow = this.ShopFailedFlow,
				WorkingFlow = this.WorkingFlow,
				ExitMontage = this.ExitMontage,
				ExitFlow = this.ExitFlow
			};
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00058DB2 File Offset: 0x00056FB2
		// (set) Token: 0x06001F91 RID: 8081 RVA: 0x00058DDD File Offset: 0x00056FDD
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

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x00058DEB File Offset: 0x00056FEB
		// (set) Token: 0x06001F93 RID: 8083 RVA: 0x00058E12 File Offset: 0x00057012
		public virtual IMontageConfig EnterMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterMontage;
				}
				INpcUiInteractOnShopNew_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00058E20 File Offset: 0x00057020
		// (set) Token: 0x06001F95 RID: 8085 RVA: 0x00058E47 File Offset: 0x00057047
		public virtual IMontageConfig StandByMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StandByMontage;
				}
				INpcUiInteractOnShopNew_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StandByMontage;
			}
			set
			{
				this.GetOrCreatePoco().StandByMontage = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001F96 RID: 8086 RVA: 0x00058E55 File Offset: 0x00057055
		// (set) Token: 0x06001F97 RID: 8087 RVA: 0x00058E7C File Offset: 0x0005707C
		public virtual IMontageConfig ShopSuccessMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShopSuccessMontage;
				}
				INpcUiInteractOnShopNew_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShopSuccessMontage;
			}
			set
			{
				this.GetOrCreatePoco().ShopSuccessMontage = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x00058E8C File Offset: 0x0005708C
		// (set) Token: 0x06001F99 RID: 8089 RVA: 0x00058EED File Offset: 0x000570ED
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
					INpcUiInteractOnShopNew_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00058F04 File Offset: 0x00057104
		// (set) Token: 0x06001F9B RID: 8091 RVA: 0x00058F65 File Offset: 0x00057165
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
					INpcUiInteractOnShopNew_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x00058F7C File Offset: 0x0005717C
		// (set) Token: 0x06001F9D RID: 8093 RVA: 0x00058FDD File Offset: 0x000571DD
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
					INpcUiInteractOnShopNew_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x00058FF4 File Offset: 0x000571F4
		// (set) Token: 0x06001F9F RID: 8095 RVA: 0x00059055 File Offset: 0x00057255
		public virtual PlayFlow WorkingFlow
		{
			get
			{
				if (this._WorkingFlowInited)
				{
					return this._WorkingFlowCache;
				}
				this._WorkingFlowInited = true;
				if (this.FbInstance != null)
				{
					this._WorkingFlowCache = PlayFlow.Create(this.FbInstance.WorkingFlow);
				}
				else
				{
					INpcUiInteractOnShopNew_SetValue pocoInterface = this.PocoInterface;
					this._WorkingFlowCache = ((pocoInterface != null) ? pocoInterface.WorkingFlow : null);
				}
				return this._WorkingFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().WorkingFlow = value;
				this._WorkingFlowInited = false;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x0005906A File Offset: 0x0005726A
		// (set) Token: 0x06001FA1 RID: 8097 RVA: 0x00059091 File Offset: 0x00057291
		public virtual IMontageConfig ExitMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitMontage;
				}
				INpcUiInteractOnShopNew_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExitMontage;
			}
			set
			{
				this.GetOrCreatePoco().ExitMontage = value;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x000590A0 File Offset: 0x000572A0
		// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x00059101 File Offset: 0x00057301
		public virtual PlayFlow ExitFlow
		{
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
					INpcUiInteractOnShopNew_SetValue pocoInterface = this.PocoInterface;
					this._ExitFlowCache = ((pocoInterface != null) ? pocoInterface.ExitFlow : null);
				}
				return this._ExitFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().ExitFlow = value;
				this._ExitFlowInited = false;
			}
		}

		// Token: 0x04001672 RID: 5746
		protected new INpcUiInteractOnShopNew FbInstance;

		// Token: 0x04001673 RID: 5747
		protected new INpcUiInteractOnShopNew_SetValue PocoInterface;

		// Token: 0x04001674 RID: 5748
		[Nullable(0)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x04001675 RID: 5749
		private bool _EnterFlowInited;

		// Token: 0x04001676 RID: 5750
		[Nullable(0)]
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04001677 RID: 5751
		private bool _ShopSuccessFlowInited;

		// Token: 0x04001678 RID: 5752
		[Nullable(0)]
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x04001679 RID: 5753
		private bool _ShopFailedFlowInited;

		// Token: 0x0400167A RID: 5754
		[Nullable(0)]
		private PlayFlow _WorkingFlowCache;

		// Token: 0x0400167B RID: 5755
		private bool _WorkingFlowInited;

		// Token: 0x0400167C RID: 5756
		[Nullable(0)]
		private PlayFlow _ExitFlowCache;

		// Token: 0x0400167D RID: 5757
		private bool _ExitFlowInited;
	}
}
