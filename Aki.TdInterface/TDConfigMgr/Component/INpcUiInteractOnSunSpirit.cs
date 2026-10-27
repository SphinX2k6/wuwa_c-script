using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000596 RID: 1430
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnSunSpirit : INpcUiInteractType
	{
		// Token: 0x06001DD8 RID: 7640 RVA: 0x00054BC4 File Offset: 0x00052DC4
		private INpcUiInteractOnSunSpirit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnSunSpirit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnSunSpirit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnSunSpirit_SetValue());
			}
			return result;
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00054BFC File Offset: 0x00052DFC
		public static INpcUiInteractOnSunSpirit Create([Nullable(2)] INpcUiInteractOnSunSpirit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnSunSpirit
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00054C0F File Offset: 0x00052E0F
		public static INpcUiInteractOnSunSpirit CreateFromSetValue([Nullable(2)] INpcUiInteractOnSunSpirit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnSunSpirit
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00054C24 File Offset: 0x00052E24
		public new INpcUiInteractOnSunSpirit_SetValue ToSetValue()
		{
			return new INpcUiInteractOnSunSpirit_SetValue
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00054CBA File Offset: 0x00052EBA
		// (set) Token: 0x06001DDD RID: 7645 RVA: 0x00054CE5 File Offset: 0x00052EE5
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

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x00054CF3 File Offset: 0x00052EF3
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x00054D1E File Offset: 0x00052F1E
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

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00054D2C File Offset: 0x00052F2C
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00054D57 File Offset: 0x00052F57
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

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00054D65 File Offset: 0x00052F65
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x00054D90 File Offset: 0x00052F90
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

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00054DA0 File Offset: 0x00052FA0
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00054E01 File Offset: 0x00053001
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
					INpcUiInteractOnSunSpirit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x00054E18 File Offset: 0x00053018
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x00054E79 File Offset: 0x00053079
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
					INpcUiInteractOnSunSpirit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00054E90 File Offset: 0x00053090
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x00054EF1 File Offset: 0x000530F1
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
					INpcUiInteractOnSunSpirit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x00054F06 File Offset: 0x00053106
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x00054F2D File Offset: 0x0005312D
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
				INpcUiInteractOnSunSpirit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00054F3C File Offset: 0x0005313C
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x00054F9D File Offset: 0x0005319D
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
					INpcUiInteractOnSunSpirit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00054FB2 File Offset: 0x000531B2
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x00054FD9 File Offset: 0x000531D9
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
				INpcUiInteractOnSunSpirit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00054FE8 File Offset: 0x000531E8
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x00055049 File Offset: 0x00053249
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
					INpcUiInteractOnSunSpirit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001548 RID: 5448
		[Nullable(2)]
		protected new INpcUiInteractOnSunSpirit FbInstance;

		// Token: 0x04001549 RID: 5449
		[Nullable(2)]
		protected new INpcUiInteractOnSunSpirit_SetValue PocoInterface;

		// Token: 0x0400154A RID: 5450
		private PlayFlow _EnterFlowCache;

		// Token: 0x0400154B RID: 5451
		private bool _EnterFlowInited;

		// Token: 0x0400154C RID: 5452
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x0400154D RID: 5453
		private bool _ShopSuccessFlowInited;

		// Token: 0x0400154E RID: 5454
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x0400154F RID: 5455
		private bool _ShopFailedFlowInited;

		// Token: 0x04001550 RID: 5456
		private PlayFlow _UpgradeFlowCache;

		// Token: 0x04001551 RID: 5457
		private bool _UpgradeFlowInited;

		// Token: 0x04001552 RID: 5458
		private PlayFlow _ExitFlowCache;

		// Token: 0x04001553 RID: 5459
		private bool _ExitFlowInited;
	}
}
