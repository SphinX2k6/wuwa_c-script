using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC3 RID: 3011
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnSunSpirit : INpcUiInteractType
	{
		// Token: 0x06004526 RID: 17702 RVA: 0x000AF3B9 File Offset: 0x000AD5B9
		public static INpcUiInteractOnSunSpirit Create(INpcUiInteractOnSunSpirit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnSunSpirit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06004527 RID: 17703 RVA: 0x000AF3D8 File Offset: 0x000AD5D8
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06004528 RID: 17704 RVA: 0x000AF3E5 File Offset: 0x000AD5E5
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06004529 RID: 17705 RVA: 0x000AF3F2 File Offset: 0x000AD5F2
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x0600452A RID: 17706 RVA: 0x000AF3FF File Offset: 0x000AD5FF
		public virtual string ShopSuccessMontage
		{
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x0600452B RID: 17707 RVA: 0x000AF40C File Offset: 0x000AD60C
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

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x0600452C RID: 17708 RVA: 0x000AF440 File Offset: 0x000AD640
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

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x0600452D RID: 17709 RVA: 0x000AF474 File Offset: 0x000AD674
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

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x0600452E RID: 17710 RVA: 0x000AF4A8 File Offset: 0x000AD6A8
		[Nullable(2)]
		public virtual string UpgradeSequence
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.UpgradeSequence;
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x0600452F RID: 17711 RVA: 0x000AF4B5 File Offset: 0x000AD6B5
		[Nullable(2)]
		public virtual Aki.TDConfigMgr.Action.Fb.PlayFlow UpgradeFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._UpgradeFlowInited)
				{
					return this._UpgradeFlowCache;
				}
				this._UpgradeFlowInited = true;
				this._UpgradeFlowCache = Aki.TDConfigMgr.Action.Fb.PlayFlow.Create(this.Instance.UpgradeFlow);
				return this._UpgradeFlowCache;
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06004530 RID: 17712 RVA: 0x000AF4E9 File Offset: 0x000AD6E9
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ExitMontage
		{
			get
			{
				if (this._ExitMontageInited)
				{
					return this._ExitMontageCache;
				}
				this._ExitMontageInited = true;
				this._ExitMontageCache = ComponentReadHelper.ReadINpcUiInteractOnSunSpirit_ExitMontage(this.Instance);
				return this._ExitMontageCache;
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06004531 RID: 17713 RVA: 0x000AF518 File Offset: 0x000AD718
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

		// Token: 0x0400272E RID: 10030
		private INpcUiInteractOnSunSpirit Instance;

		// Token: 0x0400272F RID: 10031
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x04002730 RID: 10032
		private bool _EnterFlowInited;

		// Token: 0x04002731 RID: 10033
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04002732 RID: 10034
		private bool _ShopSuccessFlowInited;

		// Token: 0x04002733 RID: 10035
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x04002734 RID: 10036
		private bool _ShopFailedFlowInited;

		// Token: 0x04002735 RID: 10037
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _UpgradeFlowCache;

		// Token: 0x04002736 RID: 10038
		private bool _UpgradeFlowInited;

		// Token: 0x04002737 RID: 10039
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x04002738 RID: 10040
		private bool _ExitMontageInited;

		// Token: 0x04002739 RID: 10041
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x0400273A RID: 10042
		private bool _ExitFlowInited;
	}
}
