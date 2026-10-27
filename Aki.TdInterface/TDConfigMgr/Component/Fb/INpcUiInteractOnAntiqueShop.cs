using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBF RID: 3007
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnAntiqueShop : INpcUiInteractType
	{
		// Token: 0x060044F7 RID: 17655 RVA: 0x000AEE6B File Offset: 0x000AD06B
		public static INpcUiInteractOnAntiqueShop Create(INpcUiInteractOnAntiqueShop? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnAntiqueShop
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x000AEE8A File Offset: 0x000AD08A
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x060044F9 RID: 17657 RVA: 0x000AEE97 File Offset: 0x000AD097
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x000AEEA4 File Offset: 0x000AD0A4
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x060044FB RID: 17659 RVA: 0x000AEEB1 File Offset: 0x000AD0B1
		public virtual string ShopSuccessMontage
		{
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x000AEEBE File Offset: 0x000AD0BE
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow EnterFlow
		{
			get
			{
				if (this._EnterFlowInited)
				{
					return this._EnterFlowCache;
				}
				this._EnterFlowInited = true;
				this._EnterFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.EnterFlow);
				return this._EnterFlowCache;
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x060044FD RID: 17661 RVA: 0x000AEEF2 File Offset: 0x000AD0F2
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow ShopSuccessFlow
		{
			get
			{
				if (this._ShopSuccessFlowInited)
				{
					return this._ShopSuccessFlowCache;
				}
				this._ShopSuccessFlowInited = true;
				this._ShopSuccessFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.ShopSuccessFlow);
				return this._ShopSuccessFlowCache;
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x000AEF26 File Offset: 0x000AD126
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow ShopFailedFlow
		{
			get
			{
				if (this._ShopFailedFlowInited)
				{
					return this._ShopFailedFlowCache;
				}
				this._ShopFailedFlowInited = true;
				this._ShopFailedFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.ShopFailedFlow);
				return this._ShopFailedFlowCache;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x060044FF RID: 17663 RVA: 0x000AEF5A File Offset: 0x000AD15A
		public virtual string UpgradeSequence
		{
			get
			{
				return this.Instance.UpgradeSequence;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06004500 RID: 17664 RVA: 0x000AEF67 File Offset: 0x000AD167
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ExitMontage
		{
			get
			{
				if (this._ExitMontageInited)
				{
					return this._ExitMontageCache;
				}
				this._ExitMontageInited = true;
				this._ExitMontageCache = ComponentReadHelper.ReadINpcUiInteractOnAntiqueShop_ExitMontage(this.Instance);
				return this._ExitMontageCache;
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06004501 RID: 17665 RVA: 0x000AEF96 File Offset: 0x000AD196
		[Nullable(2)]
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow ExitFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._ExitFlowInited)
				{
					return this._ExitFlowCache;
				}
				this._ExitFlowInited = true;
				this._ExitFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.ExitFlow);
				return this._ExitFlowCache;
			}
		}

		// Token: 0x04002708 RID: 9992
		private INpcUiInteractOnAntiqueShop Instance;

		// Token: 0x04002709 RID: 9993
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x0400270A RID: 9994
		private bool _EnterFlowInited;

		// Token: 0x0400270B RID: 9995
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x0400270C RID: 9996
		private bool _ShopSuccessFlowInited;

		// Token: 0x0400270D RID: 9997
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x0400270E RID: 9998
		private bool _ShopFailedFlowInited;

		// Token: 0x0400270F RID: 9999
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x04002710 RID: 10000
		private bool _ExitMontageInited;

		// Token: 0x04002711 RID: 10001
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x04002712 RID: 10002
		private bool _ExitFlowInited;
	}
}
