using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C90 RID: 3216
	public class INpcUiInteractOnSoundBox3 : INpcUiInteractType
	{
		// Token: 0x06004972 RID: 18802 RVA: 0x000B92E2 File Offset: 0x000B74E2
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

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06004973 RID: 18803 RVA: 0x000B9301 File Offset: 0x000B7501
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06004974 RID: 18804 RVA: 0x000B930E File Offset: 0x000B750E
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06004975 RID: 18805 RVA: 0x000B931B File Offset: 0x000B751B
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06004976 RID: 18806 RVA: 0x000B9328 File Offset: 0x000B7528
		public virtual string ShopSuccessMontage
		{
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x000B9335 File Offset: 0x000B7535
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

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06004978 RID: 18808 RVA: 0x000B9369 File Offset: 0x000B7569
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

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06004979 RID: 18809 RVA: 0x000B939D File Offset: 0x000B759D
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

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x0600497A RID: 18810 RVA: 0x000B93D1 File Offset: 0x000B75D1
		[Nullable(2)]
		public virtual string UpgradeSequence
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.UpgradeSequence;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x0600497B RID: 18811 RVA: 0x000B93DE File Offset: 0x000B75DE
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

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x0600497C RID: 18812 RVA: 0x000B9412 File Offset: 0x000B7612
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

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x0600497D RID: 18813 RVA: 0x000B9441 File Offset: 0x000B7641
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

		// Token: 0x04002969 RID: 10601
		private INpcUiInteractOnSoundBox3 Instance;

		// Token: 0x0400296A RID: 10602
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x0400296B RID: 10603
		private bool _EnterFlowInited;

		// Token: 0x0400296C RID: 10604
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x0400296D RID: 10605
		private bool _ShopSuccessFlowInited;

		// Token: 0x0400296E RID: 10606
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x0400296F RID: 10607
		private bool _ShopFailedFlowInited;

		// Token: 0x04002970 RID: 10608
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _UpgradeFlowCache;

		// Token: 0x04002971 RID: 10609
		private bool _UpgradeFlowInited;

		// Token: 0x04002972 RID: 10610
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x04002973 RID: 10611
		private bool _ExitMontageInited;

		// Token: 0x04002974 RID: 10612
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x04002975 RID: 10613
		private bool _ExitFlowInited;
	}
}
