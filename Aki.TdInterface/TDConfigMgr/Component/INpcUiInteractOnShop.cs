using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200058E RID: 1422
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShop : INpcUiInteractType
	{
		// Token: 0x06001D6C RID: 7532 RVA: 0x000539A0 File Offset: 0x00051BA0
		[NullableContext(1)]
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

		// Token: 0x06001D6D RID: 7533 RVA: 0x000539D8 File Offset: 0x00051BD8
		[NullableContext(1)]
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

		// Token: 0x06001D6E RID: 7534 RVA: 0x000539EB File Offset: 0x00051BEB
		[NullableContext(1)]
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

		// Token: 0x06001D6F RID: 7535 RVA: 0x00053A00 File Offset: 0x00051C00
		[NullableContext(1)]
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

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x00053A8A File Offset: 0x00051C8A
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x00053AB5 File Offset: 0x00051CB5
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

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00053AC3 File Offset: 0x00051CC3
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x00053AEE File Offset: 0x00051CEE
		[Nullable(1)]
		public virtual string EnterMontage
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().EnterMontage = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00053AFC File Offset: 0x00051CFC
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x00053B27 File Offset: 0x00051D27
		[Nullable(1)]
		public virtual string StandByMontage
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().StandByMontage = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00053B35 File Offset: 0x00051D35
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x00053B60 File Offset: 0x00051D60
		[Nullable(1)]
		public virtual string ShopSuccessMontage
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().ShopSuccessMontage = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00053B70 File Offset: 0x00051D70
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x00053BD1 File Offset: 0x00051DD1
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

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x00053BE8 File Offset: 0x00051DE8
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x00053C49 File Offset: 0x00051E49
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

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00053C60 File Offset: 0x00051E60
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x00053CC1 File Offset: 0x00051EC1
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

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00053CD8 File Offset: 0x00051ED8
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x00053D39 File Offset: 0x00051F39
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

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00053D4E File Offset: 0x00051F4E
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x00053D75 File Offset: 0x00051F75
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

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x00053D84 File Offset: 0x00051F84
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x00053DE5 File Offset: 0x00051FE5
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

		// Token: 0x040014EE RID: 5358
		protected new INpcUiInteractOnShop FbInstance;

		// Token: 0x040014EF RID: 5359
		protected new INpcUiInteractOnShop_SetValue PocoInterface;

		// Token: 0x040014F0 RID: 5360
		[Nullable(1)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x040014F1 RID: 5361
		private bool _EnterFlowInited;

		// Token: 0x040014F2 RID: 5362
		[Nullable(1)]
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x040014F3 RID: 5363
		private bool _ShopSuccessFlowInited;

		// Token: 0x040014F4 RID: 5364
		[Nullable(1)]
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x040014F5 RID: 5365
		private bool _ShopFailedFlowInited;

		// Token: 0x040014F6 RID: 5366
		[Nullable(1)]
		private PlayFlow _WorkingFlowCache;

		// Token: 0x040014F7 RID: 5367
		private bool _WorkingFlowInited;

		// Token: 0x040014F8 RID: 5368
		[Nullable(1)]
		private PlayFlow _ExitFlowCache;

		// Token: 0x040014F9 RID: 5369
		private bool _ExitFlowInited;
	}
}
