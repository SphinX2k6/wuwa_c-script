using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005ED RID: 1517
	public class INpcUiInteractOnAntiqueShop : INpcUiInteractType
	{
		// Token: 0x06001F06 RID: 7942 RVA: 0x00057750 File Offset: 0x00055950
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

		// Token: 0x06001F07 RID: 7943 RVA: 0x00057788 File Offset: 0x00055988
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

		// Token: 0x06001F08 RID: 7944 RVA: 0x0005779B File Offset: 0x0005599B
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

		// Token: 0x06001F09 RID: 7945 RVA: 0x000577B0 File Offset: 0x000559B0
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

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x0005783A File Offset: 0x00055A3A
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x00057865 File Offset: 0x00055A65
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

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00057873 File Offset: 0x00055A73
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x0005789E File Offset: 0x00055A9E
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

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000578AC File Offset: 0x00055AAC
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x000578D7 File Offset: 0x00055AD7
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

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x000578E5 File Offset: 0x00055AE5
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x00057910 File Offset: 0x00055B10
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

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x00057920 File Offset: 0x00055B20
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00057981 File Offset: 0x00055B81
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

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x00057998 File Offset: 0x00055B98
		// (set) Token: 0x06001F15 RID: 7957 RVA: 0x000579F9 File Offset: 0x00055BF9
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

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x00057A10 File Offset: 0x00055C10
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x00057A71 File Offset: 0x00055C71
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

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x00057A86 File Offset: 0x00055C86
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x00057AB1 File Offset: 0x00055CB1
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

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x00057ABF File Offset: 0x00055CBF
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00057AE6 File Offset: 0x00055CE6
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

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00057AF4 File Offset: 0x00055CF4
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x00057B55 File Offset: 0x00055D55
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

		// Token: 0x0400160B RID: 5643
		[Nullable(2)]
		protected new INpcUiInteractOnAntiqueShop FbInstance;

		// Token: 0x0400160C RID: 5644
		[Nullable(2)]
		protected new INpcUiInteractOnAntiqueShop_SetValue PocoInterface;

		// Token: 0x0400160D RID: 5645
		private PlayFlow _EnterFlowCache;

		// Token: 0x0400160E RID: 5646
		private bool _EnterFlowInited;

		// Token: 0x0400160F RID: 5647
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04001610 RID: 5648
		private bool _ShopSuccessFlowInited;

		// Token: 0x04001611 RID: 5649
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x04001612 RID: 5650
		private bool _ShopFailedFlowInited;

		// Token: 0x04001613 RID: 5651
		private PlayFlow _ExitFlowCache;

		// Token: 0x04001614 RID: 5652
		private bool _ExitFlowInited;
	}
}
