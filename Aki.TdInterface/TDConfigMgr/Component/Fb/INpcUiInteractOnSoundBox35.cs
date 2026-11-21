using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C94 RID: 3220
	public class INpcUiInteractOnSoundBox35 : INpcUiInteractType
	{
		// Token: 0x060049A1 RID: 18849 RVA: 0x000B9969 File Offset: 0x000B7B69
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

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x060049A2 RID: 18850 RVA: 0x000B9988 File Offset: 0x000B7B88
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x000B9995 File Offset: 0x000B7B95
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x060049A4 RID: 18852 RVA: 0x000B99A2 File Offset: 0x000B7BA2
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x000B99AF File Offset: 0x000B7BAF
		public virtual string ShopSuccessMontage
		{
			get
			{
				return this.Instance.ShopSuccessMontage;
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x060049A6 RID: 18854 RVA: 0x000B99BC File Offset: 0x000B7BBC
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

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x000B99F0 File Offset: 0x000B7BF0
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

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x060049A8 RID: 18856 RVA: 0x000B9A24 File Offset: 0x000B7C24
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

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x000B9A58 File Offset: 0x000B7C58
		[Nullable(2)]
		public virtual string UpgradeSequence
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.UpgradeSequence;
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x060049AA RID: 18858 RVA: 0x000B9A65 File Offset: 0x000B7C65
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

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x060049AB RID: 18859 RVA: 0x000B9A99 File Offset: 0x000B7C99
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

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x060049AC RID: 18860 RVA: 0x000B9AC8 File Offset: 0x000B7CC8
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

		// Token: 0x040029A3 RID: 10659
		private INpcUiInteractOnSoundBox35 Instance;

		// Token: 0x040029A4 RID: 10660
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _EnterFlowCache;

		// Token: 0x040029A5 RID: 10661
		private bool _EnterFlowInited;

		// Token: 0x040029A6 RID: 10662
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopSuccessFlowCache;

		// Token: 0x040029A7 RID: 10663
		private bool _ShopSuccessFlowInited;

		// Token: 0x040029A8 RID: 10664
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ShopFailedFlowCache;

		// Token: 0x040029A9 RID: 10665
		private bool _ShopFailedFlowInited;

		// Token: 0x040029AA RID: 10666
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _UpgradeFlowCache;

		// Token: 0x040029AB RID: 10667
		private bool _UpgradeFlowInited;

		// Token: 0x040029AC RID: 10668
		private Aki.TDConfigMgr.Action.IMontageConfig _ExitMontageCache;

		// Token: 0x040029AD RID: 10669
		private bool _ExitMontageInited;

		// Token: 0x040029AE RID: 10670
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PlayFlow _ExitFlowCache;

		// Token: 0x040029AF RID: 10671
		private bool _ExitFlowInited;
	}
}
