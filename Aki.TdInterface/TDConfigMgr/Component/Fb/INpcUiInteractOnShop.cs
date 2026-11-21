using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8C RID: 3212
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShop : INpcUiInteractType
	{
		// Token: 0x06004944 RID: 18756 RVA: 0x000B8DA1 File Offset: 0x000B6FA1
		[NullableContext(0)]
		public static INpcUiInteractOnShop Create(INpcUiInteractOnShop? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnShop
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06004945 RID: 18757 RVA: 0x000B8DC0 File Offset: 0x000B6FC0
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06004946 RID: 18758 RVA: 0x000B8DCD File Offset: 0x000B6FCD
		[Nullable(0)]
		public virtual string EnterMontage
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06004947 RID: 18759 RVA: 0x000B8DDA File Offset: 0x000B6FDA
		[Nullable(0)]
		public virtual string StandByMontage
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06004948 RID: 18760 RVA: 0x000B8DE7 File Offset: 0x000B6FE7
		[Nullable(0)]
		public virtual string ShopSuccessMontage
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x000B8DF4 File Offset: 0x000B6FF4
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

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x0600494A RID: 18762 RVA: 0x000B8E28 File Offset: 0x000B7028
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

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x000B8E5C File Offset: 0x000B705C
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

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x000B8E90 File Offset: 0x000B7090
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

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x000B8EC4 File Offset: 0x000B70C4
		[Nullable(0)]
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ExitMontage
		{
			[NullableContext(0)]
			get
			{
				if (this._ExitMontageInited)
				{
					return this._ExitMontageCache;
				}
				this._ExitMontageInited = true;
				this._ExitMontageCache = ComponentReadHelper.ReadINpcUiInteractOnShop_ExitMontage(this.Instance);
				return this._ExitMontageCache;
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x0600494E RID: 18766 RVA: 0x000B8EF3 File Offset: 0x000B70F3
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

		// Token: 0x04002943 RID: 10563
		private INpcUiInteractOnShop Instance;

		// Token: 0x04002944 RID: 10564
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x04002945 RID: 10565
		private bool _EnterFlowInited;

		// Token: 0x04002946 RID: 10566
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04002947 RID: 10567
		private bool _ShopSuccessFlowInited;

		// Token: 0x04002948 RID: 10568
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x04002949 RID: 10569
		private bool _ShopFailedFlowInited;

		// Token: 0x0400294A RID: 10570
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _WorkingFlowCache;

		// Token: 0x0400294B RID: 10571
		private bool _WorkingFlowInited;

		// Token: 0x0400294C RID: 10572
		[Nullable(0)]
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x0400294D RID: 10573
		private bool _ExitMontageInited;

		// Token: 0x0400294E RID: 10574
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x0400294F RID: 10575
		private bool _ExitFlowInited;
	}
}
