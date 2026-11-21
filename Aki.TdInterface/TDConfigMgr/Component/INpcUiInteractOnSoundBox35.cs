using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FD RID: 1533
	public class INpcUiInteractOnSoundBox35 : INpcUiInteractType
	{
		// Token: 0x06001FC2 RID: 8130 RVA: 0x000595D4 File Offset: 0x000577D4
		private INpcUiInteractOnSoundBox35_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnSoundBox35 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnSoundBox35_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnSoundBox35_SetValue());
			}
			return result;
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0005960C File Offset: 0x0005780C
		public static INpcUiInteractOnSoundBox35 Create([Nullable(2)] INpcUiInteractOnSoundBox35 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnSoundBox35
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0005961F File Offset: 0x0005781F
		public static INpcUiInteractOnSoundBox35 CreateFromSetValue([Nullable(2)] INpcUiInteractOnSoundBox35_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnSoundBox35
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00059634 File Offset: 0x00057834
		public new INpcUiInteractOnSoundBox35_SetValue ToSetValue()
		{
			return new INpcUiInteractOnSoundBox35_SetValue
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

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x000596CA File Offset: 0x000578CA
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x000596F5 File Offset: 0x000578F5
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

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00059703 File Offset: 0x00057903
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x0005972E File Offset: 0x0005792E
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

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x0005973C File Offset: 0x0005793C
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x00059767 File Offset: 0x00057967
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

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x00059775 File Offset: 0x00057975
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x000597A0 File Offset: 0x000579A0
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

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x000597B0 File Offset: 0x000579B0
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x00059811 File Offset: 0x00057A11
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
					INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x00059828 File Offset: 0x00057A28
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x00059889 File Offset: 0x00057A89
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
					INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x000598A0 File Offset: 0x00057AA0
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00059901 File Offset: 0x00057B01
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
					INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x00059916 File Offset: 0x00057B16
		// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x0005993D File Offset: 0x00057B3D
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
				INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x0005994C File Offset: 0x00057B4C
		// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x000599AD File Offset: 0x00057BAD
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
					INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x000599C2 File Offset: 0x00057BC2
		// (set) Token: 0x06001FD9 RID: 8153 RVA: 0x000599E9 File Offset: 0x00057BE9
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
				INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x000599F8 File Offset: 0x00057BF8
		// (set) Token: 0x06001FDB RID: 8155 RVA: 0x00059A59 File Offset: 0x00057C59
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
					INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400169F RID: 5791
		[Nullable(2)]
		protected new INpcUiInteractOnSoundBox35 FbInstance;

		// Token: 0x040016A0 RID: 5792
		[Nullable(2)]
		protected new INpcUiInteractOnSoundBox35_SetValue PocoInterface;

		// Token: 0x040016A1 RID: 5793
		private PlayFlow _EnterFlowCache;

		// Token: 0x040016A2 RID: 5794
		private bool _EnterFlowInited;

		// Token: 0x040016A3 RID: 5795
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x040016A4 RID: 5796
		private bool _ShopSuccessFlowInited;

		// Token: 0x040016A5 RID: 5797
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x040016A6 RID: 5798
		private bool _ShopFailedFlowInited;

		// Token: 0x040016A7 RID: 5799
		private PlayFlow _UpgradeFlowCache;

		// Token: 0x040016A8 RID: 5800
		private bool _UpgradeFlowInited;

		// Token: 0x040016A9 RID: 5801
		private PlayFlow _ExitFlowCache;

		// Token: 0x040016AA RID: 5802
		private bool _ExitFlowInited;
	}
}
