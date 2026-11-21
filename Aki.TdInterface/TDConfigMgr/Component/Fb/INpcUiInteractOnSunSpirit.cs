using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C91 RID: 3217
	public class INpcUiInteractOnSunSpirit : INpcUiInteractType
	{
		// Token: 0x0600497F RID: 18815 RVA: 0x000B947D File Offset: 0x000B767D
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

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06004980 RID: 18816 RVA: 0x000B949C File Offset: 0x000B769C
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06004981 RID: 18817 RVA: 0x000B94A9 File Offset: 0x000B76A9
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06004982 RID: 18818 RVA: 0x000B94B6 File Offset: 0x000B76B6
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06004983 RID: 18819 RVA: 0x000B94C3 File Offset: 0x000B76C3
		public virtual string ShopSuccessMontage
		{
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06004984 RID: 18820 RVA: 0x000B94D0 File Offset: 0x000B76D0
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

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06004985 RID: 18821 RVA: 0x000B9504 File Offset: 0x000B7704
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

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06004986 RID: 18822 RVA: 0x000B9538 File Offset: 0x000B7738
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

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06004987 RID: 18823 RVA: 0x000B956C File Offset: 0x000B776C
		[Nullable(2)]
		public virtual string UpgradeSequence
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.UpgradeSequence;
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06004988 RID: 18824 RVA: 0x000B9579 File Offset: 0x000B7779
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

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x000B95AD File Offset: 0x000B77AD
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

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x000B95DC File Offset: 0x000B77DC
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

		// Token: 0x04002976 RID: 10614
		private INpcUiInteractOnSunSpirit Instance;

		// Token: 0x04002977 RID: 10615
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x04002978 RID: 10616
		private bool _EnterFlowInited;

		// Token: 0x04002979 RID: 10617
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x0400297A RID: 10618
		private bool _ShopSuccessFlowInited;

		// Token: 0x0400297B RID: 10619
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x0400297C RID: 10620
		private bool _ShopFailedFlowInited;

		// Token: 0x0400297D RID: 10621
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _UpgradeFlowCache;

		// Token: 0x0400297E RID: 10622
		private bool _UpgradeFlowInited;

		// Token: 0x0400297F RID: 10623
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x04002980 RID: 10624
		private bool _ExitMontageInited;

		// Token: 0x04002981 RID: 10625
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x04002982 RID: 10626
		private bool _ExitFlowInited;
	}
}
