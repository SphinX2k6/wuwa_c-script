using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC6 RID: 3014
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnSoundBox35 : INpcUiInteractType
	{
		// Token: 0x06004548 RID: 17736 RVA: 0x000AF8A5 File Offset: 0x000ADAA5
		public static INpcUiInteractOnSoundBox35 Create(INpcUiInteractOnSoundBox35? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnSoundBox35
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x000AF8C4 File Offset: 0x000ADAC4
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x0600454A RID: 17738 RVA: 0x000AF8D1 File Offset: 0x000ADAD1
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x0600454B RID: 17739 RVA: 0x000AF8DE File Offset: 0x000ADADE
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x0600454C RID: 17740 RVA: 0x000AF8EB File Offset: 0x000ADAEB
		public virtual string ShopSuccessMontage
		{
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x000AF8F8 File Offset: 0x000ADAF8
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

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x0600454E RID: 17742 RVA: 0x000AF92C File Offset: 0x000ADB2C
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

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x0600454F RID: 17743 RVA: 0x000AF960 File Offset: 0x000ADB60
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

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06004550 RID: 17744 RVA: 0x000AF994 File Offset: 0x000ADB94
		[Nullable(2)]
		public virtual string UpgradeSequence
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.UpgradeSequence;
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06004551 RID: 17745 RVA: 0x000AF9A1 File Offset: 0x000ADBA1
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

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06004552 RID: 17746 RVA: 0x000AF9D5 File Offset: 0x000ADBD5
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ExitMontage
		{
			get
			{
				if (this._ExitMontageInited)
				{
					return this._ExitMontageCache;
				}
				this._ExitMontageInited = true;
				this._ExitMontageCache = ComponentReadHelper.ReadINpcUiInteractOnSoundBox35_ExitMontage(this.Instance);
				return this._ExitMontageCache;
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06004553 RID: 17747 RVA: 0x000AFA04 File Offset: 0x000ADC04
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

		// Token: 0x0400275B RID: 10075
		private INpcUiInteractOnSoundBox35 Instance;

		// Token: 0x0400275C RID: 10076
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x0400275D RID: 10077
		private bool _EnterFlowInited;

		// Token: 0x0400275E RID: 10078
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x0400275F RID: 10079
		private bool _ShopSuccessFlowInited;

		// Token: 0x04002760 RID: 10080
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x04002761 RID: 10081
		private bool _ShopFailedFlowInited;

		// Token: 0x04002762 RID: 10082
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _UpgradeFlowCache;

		// Token: 0x04002763 RID: 10083
		private bool _UpgradeFlowInited;

		// Token: 0x04002764 RID: 10084
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x04002765 RID: 10085
		private bool _ExitMontageInited;

		// Token: 0x04002766 RID: 10086
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x04002767 RID: 10087
		private bool _ExitFlowInited;
	}
}
