using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000590 RID: 1424
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShopNew : INpcUiInteractType
	{
		// Token: 0x06001D86 RID: 7558 RVA: 0x00053E0C File Offset: 0x0005200C
		[NullableContext(1)]
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

		// Token: 0x06001D87 RID: 7559 RVA: 0x00053E44 File Offset: 0x00052044
		[NullableContext(1)]
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

		// Token: 0x06001D88 RID: 7560 RVA: 0x00053E57 File Offset: 0x00052057
		[NullableContext(1)]
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

		// Token: 0x06001D89 RID: 7561 RVA: 0x00053E6C File Offset: 0x0005206C
		[NullableContext(1)]
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

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x00053EF6 File Offset: 0x000520F6
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x00053F21 File Offset: 0x00052121
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

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00053F2F File Offset: 0x0005212F
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x00053F56 File Offset: 0x00052156
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

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x00053F64 File Offset: 0x00052164
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x00053F8B File Offset: 0x0005218B
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

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x00053F99 File Offset: 0x00052199
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x00053FC0 File Offset: 0x000521C0
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

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x00053FD0 File Offset: 0x000521D0
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x00054031 File Offset: 0x00052231
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

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00054048 File Offset: 0x00052248
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x000540A9 File Offset: 0x000522A9
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

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x000540C0 File Offset: 0x000522C0
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x00054121 File Offset: 0x00052321
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

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x00054138 File Offset: 0x00052338
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x00054199 File Offset: 0x00052399
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

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x000541AE File Offset: 0x000523AE
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x000541D5 File Offset: 0x000523D5
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

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000541E4 File Offset: 0x000523E4
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x00054245 File Offset: 0x00052445
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

		// Token: 0x04001504 RID: 5380
		protected new INpcUiInteractOnShopNew FbInstance;

		// Token: 0x04001505 RID: 5381
		protected new INpcUiInteractOnShopNew_SetValue PocoInterface;

		// Token: 0x04001506 RID: 5382
		[Nullable(1)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x04001507 RID: 5383
		private bool _EnterFlowInited;

		// Token: 0x04001508 RID: 5384
		[Nullable(1)]
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04001509 RID: 5385
		private bool _ShopSuccessFlowInited;

		// Token: 0x0400150A RID: 5386
		[Nullable(1)]
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x0400150B RID: 5387
		private bool _ShopFailedFlowInited;

		// Token: 0x0400150C RID: 5388
		[Nullable(1)]
		private PlayFlow _WorkingFlowCache;

		// Token: 0x0400150D RID: 5389
		private bool _WorkingFlowInited;

		// Token: 0x0400150E RID: 5390
		[Nullable(1)]
		private PlayFlow _ExitFlowCache;

		// Token: 0x0400150F RID: 5391
		private bool _ExitFlowInited;
	}
}
