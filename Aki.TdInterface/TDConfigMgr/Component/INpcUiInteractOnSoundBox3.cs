using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FB RID: 1531
	public class INpcUiInteractOnSoundBox3 : INpcUiInteractType
	{
		// Token: 0x06001FA6 RID: 8102 RVA: 0x00059128 File Offset: 0x00057328
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

		// Token: 0x06001FA7 RID: 8103 RVA: 0x00059160 File Offset: 0x00057360
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

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00059173 File Offset: 0x00057373
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

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00059188 File Offset: 0x00057388
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

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x0005921E File Offset: 0x0005741E
		// (set) Token: 0x06001FAB RID: 8107 RVA: 0x00059249 File Offset: 0x00057449
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

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x00059257 File Offset: 0x00057457
		// (set) Token: 0x06001FAD RID: 8109 RVA: 0x00059282 File Offset: 0x00057482
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

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x00059290 File Offset: 0x00057490
		// (set) Token: 0x06001FAF RID: 8111 RVA: 0x000592BB File Offset: 0x000574BB
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

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x000592C9 File Offset: 0x000574C9
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x000592F4 File Offset: 0x000574F4
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

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x00059304 File Offset: 0x00057504
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x00059365 File Offset: 0x00057565
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

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x0005937C File Offset: 0x0005757C
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x000593DD File Offset: 0x000575DD
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

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x000593F4 File Offset: 0x000575F4
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00059455 File Offset: 0x00057655
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

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x0005946A File Offset: 0x0005766A
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x00059491 File Offset: 0x00057691
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

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x000594A0 File Offset: 0x000576A0
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00059501 File Offset: 0x00057701
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

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x00059516 File Offset: 0x00057716
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x0005953D File Offset: 0x0005773D
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

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0005954C File Offset: 0x0005774C
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x000595AD File Offset: 0x000577AD
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

		// Token: 0x04001688 RID: 5768
		[Nullable(2)]
		protected new INpcUiInteractOnSoundBox3 FbInstance;

		// Token: 0x04001689 RID: 5769
		[Nullable(2)]
		protected new INpcUiInteractOnSoundBox3_SetValue PocoInterface;

		// Token: 0x0400168A RID: 5770
		private PlayFlow _EnterFlowCache;

		// Token: 0x0400168B RID: 5771
		private bool _EnterFlowInited;

		// Token: 0x0400168C RID: 5772
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x0400168D RID: 5773
		private bool _ShopSuccessFlowInited;

		// Token: 0x0400168E RID: 5774
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x0400168F RID: 5775
		private bool _ShopFailedFlowInited;

		// Token: 0x04001690 RID: 5776
		private PlayFlow _UpgradeFlowCache;

		// Token: 0x04001691 RID: 5777
		private bool _UpgradeFlowInited;

		// Token: 0x04001692 RID: 5778
		private PlayFlow _ExitFlowCache;

		// Token: 0x04001693 RID: 5779
		private bool _ExitFlowInited;
	}
}
