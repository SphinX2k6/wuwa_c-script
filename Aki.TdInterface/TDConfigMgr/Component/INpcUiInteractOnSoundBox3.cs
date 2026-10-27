using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000592 RID: 1426
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnSoundBox3 : INpcUiInteractType
	{
		// Token: 0x06001DA0 RID: 7584 RVA: 0x0005426C File Offset: 0x0005246C
		private INpcUiInteractOnSoundBox3_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnSoundBox3 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnSoundBox3_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnSoundBox3_SetValue());
			}
			return result;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x000542A4 File Offset: 0x000524A4
		public static INpcUiInteractOnSoundBox3 Create([Nullable(2)] INpcUiInteractOnSoundBox3 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnSoundBox3
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x000542B7 File Offset: 0x000524B7
		public static INpcUiInteractOnSoundBox3 CreateFromSetValue([Nullable(2)] INpcUiInteractOnSoundBox3_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnSoundBox3
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x000542CC File Offset: 0x000524CC
		public new INpcUiInteractOnSoundBox3_SetValue ToSetValue()
		{
			return new INpcUiInteractOnSoundBox3_SetValue
			{
				Type = this.Type,
				EnterMontage = this.EnterMontage,
				StandByMontage = this.StandByMontage,
				ShopSuccessMontage = this.ShopSuccessMontage,
				EnterFlow = this.EnterFlow,
				ShopSuccessFlow = this.ShopSuccessFlow,
				ShopFailedFlow = this.ShopFailedFlow,
				UpgradeSequence = this.UpgradeSequence,
				UpgradeFlow = this.UpgradeFlow,
				ExitMontage = this.ExitMontage,
				ExitFlow = this.ExitFlow
			};
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00054362 File Offset: 0x00052562
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x0005438D File Offset: 0x0005258D
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

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0005439B File Offset: 0x0005259B
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x000543C6 File Offset: 0x000525C6
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

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x000543D4 File Offset: 0x000525D4
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x000543FF File Offset: 0x000525FF
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

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x0005440D File Offset: 0x0005260D
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x00054438 File Offset: 0x00052638
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

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x00054448 File Offset: 0x00052648
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x000544A9 File Offset: 0x000526A9
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
					INpcUiInteractOnSoundBox3_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x000544C0 File Offset: 0x000526C0
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x00054521 File Offset: 0x00052721
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
					INpcUiInteractOnSoundBox3_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00054538 File Offset: 0x00052738
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x00054599 File Offset: 0x00052799
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
					INpcUiInteractOnSoundBox3_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x000545AE File Offset: 0x000527AE
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x000545D5 File Offset: 0x000527D5
		[Nullable(2)]
		public virtual string UpgradeSequence
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UpgradeSequence;
				}
				INpcUiInteractOnSoundBox3_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UpgradeSequence;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UpgradeSequence = value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x000545E4 File Offset: 0x000527E4
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x00054645 File Offset: 0x00052845
		[Nullable(2)]
		public virtual PlayFlow UpgradeFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._UpgradeFlowInited)
				{
					return this._UpgradeFlowCache;
				}
				this._UpgradeFlowInited = true;
				if (this.FbInstance != null)
				{
					this._UpgradeFlowCache = PlayFlow.Create(this.FbInstance.UpgradeFlow);
				}
				else
				{
					INpcUiInteractOnSoundBox3_SetValue pocoInterface = this.PocoInterface;
					this._UpgradeFlowCache = ((pocoInterface != null) ? pocoInterface.UpgradeFlow : null);
				}
				return this._UpgradeFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UpgradeFlow = value;
				this._UpgradeFlowInited = false;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x0005465A File Offset: 0x0005285A
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x00054681 File Offset: 0x00052881
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
				INpcUiInteractOnSoundBox3_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00054690 File Offset: 0x00052890
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x000546F1 File Offset: 0x000528F1
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
					INpcUiInteractOnSoundBox3_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400151A RID: 5402
		[Nullable(2)]
		protected new INpcUiInteractOnSoundBox3 FbInstance;

		// Token: 0x0400151B RID: 5403
		[Nullable(2)]
		protected new INpcUiInteractOnSoundBox3_SetValue PocoInterface;

		// Token: 0x0400151C RID: 5404
		private PlayFlow _EnterFlowCache;

		// Token: 0x0400151D RID: 5405
		private bool _EnterFlowInited;

		// Token: 0x0400151E RID: 5406
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x0400151F RID: 5407
		private bool _ShopSuccessFlowInited;

		// Token: 0x04001520 RID: 5408
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x04001521 RID: 5409
		private bool _ShopFailedFlowInited;

		// Token: 0x04001522 RID: 5410
		private PlayFlow _UpgradeFlowCache;

		// Token: 0x04001523 RID: 5411
		private bool _UpgradeFlowInited;

		// Token: 0x04001524 RID: 5412
		private PlayFlow _ExitFlowCache;

		// Token: 0x04001525 RID: 5413
		private bool _ExitFlowInited;
	}
}
