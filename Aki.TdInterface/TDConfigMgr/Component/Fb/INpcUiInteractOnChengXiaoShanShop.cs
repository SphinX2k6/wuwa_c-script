using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC0 RID: 3008
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnChengXiaoShanShop : INpcUiInteractType
	{
		// Token: 0x06004503 RID: 17667 RVA: 0x000AEFD2 File Offset: 0x000AD1D2
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

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x000AEFF1 File Offset: 0x000AD1F1
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06004505 RID: 17669 RVA: 0x000AEFFE File Offset: 0x000AD1FE
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x000AF00B File Offset: 0x000AD20B
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06004507 RID: 17671 RVA: 0x000AF018 File Offset: 0x000AD218
		public virtual string ShopSuccessMontage
		{
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06004508 RID: 17672 RVA: 0x000AF025 File Offset: 0x000AD225
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

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06004509 RID: 17673 RVA: 0x000AF059 File Offset: 0x000AD259
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

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x0600450A RID: 17674 RVA: 0x000AF08D File Offset: 0x000AD28D
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

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x0600450B RID: 17675 RVA: 0x000AF0C1 File Offset: 0x000AD2C1
		public virtual string UpgradeSequence
		{
			get
			{
				return this.Instance.UpgradeSequence;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x0600450C RID: 17676 RVA: 0x000AF0CE File Offset: 0x000AD2CE
		public virtual string FinishDeliverySequence
		{
			get
			{
				return this.Instance.FinishDeliverySequence;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x0600450D RID: 17677 RVA: 0x000AF0DC File Offset: 0x000AD2DC
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

		// Token: 0x04002713 RID: 10003
		private INpcUiInteractOnChengXiaoShanShop Instance;

		// Token: 0x04002714 RID: 10004
		[Nullable(2)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x04002715 RID: 10005
		private bool _EnterFlowInited;

		// Token: 0x04002716 RID: 10006
		[Nullable(2)]
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04002717 RID: 10007
		private bool _ShopSuccessFlowInited;

		// Token: 0x04002718 RID: 10008
		[Nullable(2)]
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x04002719 RID: 10009
		private bool _ShopFailedFlowInited;
	}
}
