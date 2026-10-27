using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC4 RID: 3012
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShopNew : INpcUiInteractType
	{
		// Token: 0x06004533 RID: 17715 RVA: 0x000AF554 File Offset: 0x000AD754
		[NullableContext(1)]
		public static INpcUiInteractOnShopNew Create(INpcUiInteractOnShopNew? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnShopNew
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06004534 RID: 17716 RVA: 0x000AF573 File Offset: 0x000AD773
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x000AF580 File Offset: 0x000AD780
		[Nullable(1)]
		public virtual Aki.TDConfigMgr.Action.IMontageConfig EnterMontage
		{
			[NullableContext(1)]
			get
			{
				if (this._EnterMontageInited)
				{
					return this._EnterMontageCache;
				}
				this._EnterMontageInited = true;
				this._EnterMontageCache = ComponentReadHelper.ReadINpcUiInteractOnShopNew_EnterMontage(this.Instance);
				return this._EnterMontageCache;
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06004536 RID: 17718 RVA: 0x000AF5AF File Offset: 0x000AD7AF
		[Nullable(1)]
		public virtual Aki.TDConfigMgr.Action.IMontageConfig StandByMontage
		{
			[NullableContext(1)]
			get
			{
				if (this._StandByMontageInited)
				{
					return this._StandByMontageCache;
				}
				this._StandByMontageInited = true;
				this._StandByMontageCache = ComponentReadHelper.ReadINpcUiInteractOnShopNew_StandByMontage(this.Instance);
				return this._StandByMontageCache;
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x000AF5DE File Offset: 0x000AD7DE
		[Nullable(1)]
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ShopSuccessMontage
		{
			[NullableContext(1)]
			get
			{
				if (this._ShopSuccessMontageInited)
				{
					return this._ShopSuccessMontageCache;
				}
				this._ShopSuccessMontageInited = true;
				this._ShopSuccessMontageCache = ComponentReadHelper.ReadINpcUiInteractOnShopNew_ShopSuccessMontage(this.Instance);
				return this._ShopSuccessMontageCache;
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x000AF60D File Offset: 0x000AD80D
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

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06004539 RID: 17721 RVA: 0x000AF641 File Offset: 0x000AD841
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

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x000AF675 File Offset: 0x000AD875
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

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x0600453B RID: 17723 RVA: 0x000AF6A9 File Offset: 0x000AD8A9
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow WorkingFlow
		{
			get
			{
				if (this._WorkingFlowInited)
				{
					return this._WorkingFlowCache;
				}
				this._WorkingFlowInited = true;
				this._WorkingFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.WorkingFlow);
				return this._WorkingFlowCache;
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x0600453C RID: 17724 RVA: 0x000AF6DD File Offset: 0x000AD8DD
		[Nullable(1)]
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ExitMontage
		{
			[NullableContext(1)]
			get
			{
				if (this._ExitMontageInited)
				{
					return this._ExitMontageCache;
				}
				this._ExitMontageInited = true;
				this._ExitMontageCache = ComponentReadHelper.ReadINpcUiInteractOnShopNew_ExitMontage(this.Instance);
				return this._ExitMontageCache;
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x0600453D RID: 17725 RVA: 0x000AF70C File Offset: 0x000AD90C
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow ExitFlow
		{
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

		// Token: 0x0400273B RID: 10043
		private INpcUiInteractOnShopNew Instance;

		// Token: 0x0400273C RID: 10044
		[Nullable(1)]
		private Aki.TDConfigMgr.Action.IMontageConfig _EnterMontageCache;

		// Token: 0x0400273D RID: 10045
		private bool _EnterMontageInited;

		// Token: 0x0400273E RID: 10046
		[Nullable(1)]
		private Aki.TDConfigMgr.Action.IMontageConfig _StandByMontageCache;

		// Token: 0x0400273F RID: 10047
		private bool _StandByMontageInited;

		// Token: 0x04002740 RID: 10048
		[Nullable(1)]
		private Aki.TDConfigMgr.Action.IMontageConfig _ShopSuccessMontageCache;

		// Token: 0x04002741 RID: 10049
		private bool _ShopSuccessMontageInited;

		// Token: 0x04002742 RID: 10050
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x04002743 RID: 10051
		private bool _EnterFlowInited;

		// Token: 0x04002744 RID: 10052
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04002745 RID: 10053
		private bool _ShopSuccessFlowInited;

		// Token: 0x04002746 RID: 10054
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x04002747 RID: 10055
		private bool _ShopFailedFlowInited;

		// Token: 0x04002748 RID: 10056
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _WorkingFlowCache;

		// Token: 0x04002749 RID: 10057
		private bool _WorkingFlowInited;

		// Token: 0x0400274A RID: 10058
		[Nullable(1)]
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x0400274B RID: 10059
		private bool _ExitMontageInited;

		// Token: 0x0400274C RID: 10060
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x0400274D RID: 10061
		private bool _ExitFlowInited;
	}
}
