using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8E RID: 3214
	public class INpcUiInteractOnChengXiaoShanShop : INpcUiInteractType
	{
		// Token: 0x0600495C RID: 18780 RVA: 0x000B9096 File Offset: 0x000B7296
		public static INpcUiInteractOnChengXiaoShanShop Create(INpcUiInteractOnChengXiaoShanShop? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnChengXiaoShanShop
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x0600495D RID: 18781 RVA: 0x000B90B5 File Offset: 0x000B72B5
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x0600495E RID: 18782 RVA: 0x000B90C2 File Offset: 0x000B72C2
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x000B90CF File Offset: 0x000B72CF
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06004960 RID: 18784 RVA: 0x000B90DC File Offset: 0x000B72DC
		public virtual string ShopSuccessMontage
		{
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06004961 RID: 18785 RVA: 0x000B90E9 File Offset: 0x000B72E9
		public virtual PlayFlow EnterFlow
		{
			get
			{
				if (this._EnterFlowInited)
				{
					return this._EnterFlowCache;
				}
				this._EnterFlowInited = true;
				this._EnterFlowCache = PlayFlow.Create(this.Instance.EnterFlow);
				return this._EnterFlowCache;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06004962 RID: 18786 RVA: 0x000B911D File Offset: 0x000B731D
		public virtual PlayFlow ShopSuccessFlow
		{
			get
			{
				if (this._ShopSuccessFlowInited)
				{
					return this._ShopSuccessFlowCache;
				}
				this._ShopSuccessFlowInited = true;
				this._ShopSuccessFlowCache = PlayFlow.Create(this.Instance.ShopSuccessFlow);
				return this._ShopSuccessFlowCache;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06004963 RID: 18787 RVA: 0x000B9151 File Offset: 0x000B7351
		public virtual PlayFlow ShopFailedFlow
		{
			get
			{
				if (this._ShopFailedFlowInited)
				{
					return this._ShopFailedFlowCache;
				}
				this._ShopFailedFlowInited = true;
				this._ShopFailedFlowCache = PlayFlow.Create(this.Instance.ShopFailedFlow);
				return this._ShopFailedFlowCache;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06004964 RID: 18788 RVA: 0x000B9185 File Offset: 0x000B7385
		public virtual string UpgradeSequence
		{
			get
			{
				return this.Instance.UpgradeSequence;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x000B9192 File Offset: 0x000B7392
		public virtual string FinishDeliverySequence
		{
			get
			{
				return this.Instance.FinishDeliverySequence;
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06004966 RID: 18790 RVA: 0x000B91A0 File Offset: 0x000B73A0
		public virtual bool? ShowNpcWhilePlayingSequence
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowNpcWhilePlayingSequence);
			}
		}

		// Token: 0x0400295B RID: 10587
		private INpcUiInteractOnChengXiaoShanShop Instance;

		// Token: 0x0400295C RID: 10588
		[Nullable(2)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x0400295D RID: 10589
		private bool _EnterFlowInited;

		// Token: 0x0400295E RID: 10590
		[Nullable(2)]
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x0400295F RID: 10591
		private bool _ShopSuccessFlowInited;

		// Token: 0x04002960 RID: 10592
		[Nullable(2)]
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x04002961 RID: 10593
		private bool _ShopFailedFlowInited;
	}
}
