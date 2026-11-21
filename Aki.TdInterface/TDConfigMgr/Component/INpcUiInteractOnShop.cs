using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F7 RID: 1527
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShop : INpcUiInteractType
	{
		// Token: 0x06001F72 RID: 8050 RVA: 0x0005885C File Offset: 0x00056A5C
		[NullableContext(0)]
		private INpcUiInteractOnShop_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnShop 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnShop_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnShop_SetValue());
			}
			return result;
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00058894 File Offset: 0x00056A94
		[NullableContext(0)]
		public static INpcUiInteractOnShop Create([Nullable(2)] INpcUiInteractOnShop instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnShop
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x000588A7 File Offset: 0x00056AA7
		[NullableContext(0)]
		public static INpcUiInteractOnShop CreateFromSetValue([Nullable(2)] INpcUiInteractOnShop_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnShop
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x000588BC File Offset: 0x00056ABC
		[NullableContext(0)]
		public new INpcUiInteractOnShop_SetValue ToSetValue()
		{
			return new INpcUiInteractOnShop_SetValue
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

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x00058946 File Offset: 0x00056B46
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x00058971 File Offset: 0x00056B71
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

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x0005897F File Offset: 0x00056B7F
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x000589AA File Offset: 0x00056BAA
		[Nullable(0)]
		public virtual string EnterMontage
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().EnterMontage = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x000589B8 File Offset: 0x00056BB8
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x000589E3 File Offset: 0x00056BE3
		[Nullable(0)]
		public virtual string StandByMontage
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().StandByMontage = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x000589F1 File Offset: 0x00056BF1
		// (set) Token: 0x06001F7D RID: 8061 RVA: 0x00058A1C File Offset: 0x00056C1C
		[Nullable(0)]
		public virtual string ShopSuccessMontage
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().ShopSuccessMontage = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x00058A2C File Offset: 0x00056C2C
		// (set) Token: 0x06001F7F RID: 8063 RVA: 0x00058A8D File Offset: 0x00056C8D
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
					INpcUiInteractOnShop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x00058AA4 File Offset: 0x00056CA4
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x00058B05 File Offset: 0x00056D05
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
					INpcUiInteractOnShop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x00058B1C File Offset: 0x00056D1C
		// (set) Token: 0x06001F83 RID: 8067 RVA: 0x00058B7D File Offset: 0x00056D7D
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
					INpcUiInteractOnShop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x00058B94 File Offset: 0x00056D94
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x00058BF5 File Offset: 0x00056DF5
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
					INpcUiInteractOnShop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x00058C0A File Offset: 0x00056E0A
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x00058C31 File Offset: 0x00056E31
		public virtual IMontageConfig ExitMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitMontage;
				}
				INpcUiInteractOnShop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x00058C40 File Offset: 0x00056E40
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x00058CA1 File Offset: 0x00056EA1
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
					INpcUiInteractOnShop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400165C RID: 5724
		protected new INpcUiInteractOnShop FbInstance;

		// Token: 0x0400165D RID: 5725
		protected new INpcUiInteractOnShop_SetValue PocoInterface;

		// Token: 0x0400165E RID: 5726
		[Nullable(0)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x0400165F RID: 5727
		private bool _EnterFlowInited;

		// Token: 0x04001660 RID: 5728
		[Nullable(0)]
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04001661 RID: 5729
		private bool _ShopSuccessFlowInited;

		// Token: 0x04001662 RID: 5730
		[Nullable(0)]
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x04001663 RID: 5731
		private bool _ShopFailedFlowInited;

		// Token: 0x04001664 RID: 5732
		[Nullable(0)]
		private PlayFlow _WorkingFlowCache;

		// Token: 0x04001665 RID: 5733
		private bool _WorkingFlowInited;

		// Token: 0x04001666 RID: 5734
		[Nullable(0)]
		private PlayFlow _ExitFlowCache;

		// Token: 0x04001667 RID: 5735
		private bool _ExitFlowInited;
	}
}
