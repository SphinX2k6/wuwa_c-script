using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FF RID: 1535
	public class INpcUiInteractOnSunSpirit : INpcUiInteractType
	{
		// Token: 0x06001FDE RID: 8158 RVA: 0x00059A80 File Offset: 0x00057C80
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

		// Token: 0x06001FDF RID: 8159 RVA: 0x00059AB8 File Offset: 0x00057CB8
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

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00059ACB File Offset: 0x00057CCB
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

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00059AE0 File Offset: 0x00057CE0
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

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x00059B76 File Offset: 0x00057D76
		// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x00059BA1 File Offset: 0x00057DA1
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

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x00059BAF File Offset: 0x00057DAF
		// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x00059BDA File Offset: 0x00057DDA
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

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x00059BE8 File Offset: 0x00057DE8
		// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x00059C13 File Offset: 0x00057E13
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

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x00059C21 File Offset: 0x00057E21
		// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x00059C4C File Offset: 0x00057E4C
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

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x00059C5C File Offset: 0x00057E5C
		// (set) Token: 0x06001FEB RID: 8171 RVA: 0x00059CBD File Offset: 0x00057EBD
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

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x00059CD4 File Offset: 0x00057ED4
		// (set) Token: 0x06001FED RID: 8173 RVA: 0x00059D35 File Offset: 0x00057F35
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

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x00059D4C File Offset: 0x00057F4C
		// (set) Token: 0x06001FEF RID: 8175 RVA: 0x00059DAD File Offset: 0x00057FAD
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

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x00059DC2 File Offset: 0x00057FC2
		// (set) Token: 0x06001FF1 RID: 8177 RVA: 0x00059DE9 File Offset: 0x00057FE9
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

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x00059DF8 File Offset: 0x00057FF8
		// (set) Token: 0x06001FF3 RID: 8179 RVA: 0x00059E59 File Offset: 0x00058059
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

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x00059E6E File Offset: 0x0005806E
		// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x00059E95 File Offset: 0x00058095
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

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x00059EA4 File Offset: 0x000580A4
		// (set) Token: 0x06001FF7 RID: 8183 RVA: 0x00059F05 File Offset: 0x00058105
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

		// Token: 0x040016B6 RID: 5814
		[Nullable(2)]
		protected new INpcUiInteractOnSunSpirit FbInstance;

		// Token: 0x040016B7 RID: 5815
		[Nullable(2)]
		protected new INpcUiInteractOnSunSpirit_SetValue PocoInterface;

		// Token: 0x040016B8 RID: 5816
		private PlayFlow _EnterFlowCache;

		// Token: 0x040016B9 RID: 5817
		private bool _EnterFlowInited;

		// Token: 0x040016BA RID: 5818
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x040016BB RID: 5819
		private bool _ShopSuccessFlowInited;

		// Token: 0x040016BC RID: 5820
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x040016BD RID: 5821
		private bool _ShopFailedFlowInited;

		// Token: 0x040016BE RID: 5822
		private PlayFlow _UpgradeFlowCache;

		// Token: 0x040016BF RID: 5823
		private bool _UpgradeFlowInited;

		// Token: 0x040016C0 RID: 5824
		private PlayFlow _ExitFlowCache;

		// Token: 0x040016C1 RID: 5825
		private bool _ExitFlowInited;
	}
}
