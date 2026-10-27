using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC2 RID: 3010
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnSoundBox3 : INpcUiInteractType
	{
		// Token: 0x06004519 RID: 17689 RVA: 0x000AF21E File Offset: 0x000AD41E
		public static INpcUiInteractOnSoundBox3 Create(INpcUiInteractOnSoundBox3? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnSoundBox3
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x000AF23D File Offset: 0x000AD43D
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x000AF24A File Offset: 0x000AD44A
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x000AF257 File Offset: 0x000AD457
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x0600451D RID: 17693 RVA: 0x000AF264 File Offset: 0x000AD464
		public virtual string ShopSuccessMontage
		{
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x0600451E RID: 17694 RVA: 0x000AF271 File Offset: 0x000AD471
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

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x0600451F RID: 17695 RVA: 0x000AF2A5 File Offset: 0x000AD4A5
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

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x000AF2D9 File Offset: 0x000AD4D9
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

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06004521 RID: 17697 RVA: 0x000AF30D File Offset: 0x000AD50D
		[Nullable(2)]
		public virtual string UpgradeSequence
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.UpgradeSequence;
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x000AF31A File Offset: 0x000AD51A
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

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06004523 RID: 17699 RVA: 0x000AF34E File Offset: 0x000AD54E
		public virtual Aki.TDConfigMgr.Action.IMontageConfig ExitMontage
		{
			get
			{
				if (this._ExitMontageInited)
				{
					return this._ExitMontageCache;
				}
				this._ExitMontageInited = true;
				this._ExitMontageCache = ComponentReadHelper.ReadINpcUiInteractOnSoundBox3_ExitMontage(this.Instance);
				return this._ExitMontageCache;
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06004524 RID: 17700 RVA: 0x000AF37D File Offset: 0x000AD57D
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

		// Token: 0x04002721 RID: 10017
		private INpcUiInteractOnSoundBox3 Instance;

		// Token: 0x04002722 RID: 10018
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x04002723 RID: 10019
		private bool _EnterFlowInited;

		// Token: 0x04002724 RID: 10020
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04002725 RID: 10021
		private bool _ShopSuccessFlowInited;

		// Token: 0x04002726 RID: 10022
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x04002727 RID: 10023
		private bool _ShopFailedFlowInited;

		// Token: 0x04002728 RID: 10024
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _UpgradeFlowCache;

		// Token: 0x04002729 RID: 10025
		private bool _UpgradeFlowInited;

		// Token: 0x0400272A RID: 10026
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x0400272B RID: 10027
		private bool _ExitMontageInited;

		// Token: 0x0400272C RID: 10028
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x0400272D RID: 10029
		private bool _ExitFlowInited;
	}
}
