using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000594 RID: 1428
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnSoundBox35 : INpcUiInteractType
	{
		// Token: 0x06001DBC RID: 7612 RVA: 0x00054718 File Offset: 0x00052918
		private INpcUiInteractOnSoundBox35_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnSoundBox35 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnSoundBox35_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnSoundBox35_SetValue());
			}
			return result;
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00054750 File Offset: 0x00052950
		public static INpcUiInteractOnSoundBox35 Create([Nullable(2)] INpcUiInteractOnSoundBox35 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnSoundBox35
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00054763 File Offset: 0x00052963
		public static INpcUiInteractOnSoundBox35 CreateFromSetValue([Nullable(2)] INpcUiInteractOnSoundBox35_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnSoundBox35
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00054778 File Offset: 0x00052978
		public new INpcUiInteractOnSoundBox35_SetValue ToSetValue()
		{
			return new INpcUiInteractOnSoundBox35_SetValue
			{
				Type = this.Type,
				EnterMontage = this.EnterMontage,
				StandByMontage = this.StandByMontage,
				ShopSuccessMontage = this.ShopSuccessMontage,
				EnterFlow = this.EnterFlow,
				ShopSuccessFlow = this.ShopSuccessFlow,
				ShopFailedFlow = this.ShopFailedFlow,
				UpgradeSequence = this.UpgradeSequence,
				UpgradeFlow = this.UpgradeFlow,
				ExitMontage = this.ExitMontage,
				ExitFlow = this.ExitFlow
			};
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x0005480E File Offset: 0x00052A0E
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x00054839 File Offset: 0x00052A39
		public override ENpcUiInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00054847 File Offset: 0x00052A47
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x00054872 File Offset: 0x00052A72
		public virtual string EnterMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EnterMontage;
			}
			set
			{
				this.GetOrCreatePoco().EnterMontage = value;
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x00054880 File Offset: 0x00052A80
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x000548AB File Offset: 0x00052AAB
		public virtual string StandByMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StandByMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.StandByMontage;
			}
			set
			{
				this.GetOrCreatePoco().StandByMontage = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x000548B9 File Offset: 0x00052AB9
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x000548E4 File Offset: 0x00052AE4
		public virtual string ShopSuccessMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShopSuccessMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ShopSuccessMontage;
			}
			set
			{
				this.GetOrCreatePoco().ShopSuccessMontage = value;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x000548F4 File Offset: 0x00052AF4
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x00054955 File Offset: 0x00052B55
		public virtual PlayFlow EnterFlow
		{
			get
			{
				if (this._EnterFlowInited)
				{
					return this._EnterFlowCache;
				}
				this._EnterFlowInited = true;
				if (this.FbInstance != null)
				{
					this._EnterFlowCache = PlayFlow.Create(this.FbInstance.EnterFlow);
				}
				else
				{
					INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
					this._EnterFlowCache = ((pocoInterface != null) ? pocoInterface.EnterFlow : null);
				}
				return this._EnterFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().EnterFlow = value;
				this._EnterFlowInited = false;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x0005496C File Offset: 0x00052B6C
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x000549CD File Offset: 0x00052BCD
		public virtual PlayFlow ShopSuccessFlow
		{
			get
			{
				if (this._ShopSuccessFlowInited)
				{
					return this._ShopSuccessFlowCache;
				}
				this._ShopSuccessFlowInited = true;
				if (this.FbInstance != null)
				{
					this._ShopSuccessFlowCache = PlayFlow.Create(this.FbInstance.ShopSuccessFlow);
				}
				else
				{
					INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
					this._ShopSuccessFlowCache = ((pocoInterface != null) ? pocoInterface.ShopSuccessFlow : null);
				}
				return this._ShopSuccessFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().ShopSuccessFlow = value;
				this._ShopSuccessFlowInited = false;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x000549E4 File Offset: 0x00052BE4
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x00054A45 File Offset: 0x00052C45
		public virtual PlayFlow ShopFailedFlow
		{
			get
			{
				if (this._ShopFailedFlowInited)
				{
					return this._ShopFailedFlowCache;
				}
				this._ShopFailedFlowInited = true;
				if (this.FbInstance != null)
				{
					this._ShopFailedFlowCache = PlayFlow.Create(this.FbInstance.ShopFailedFlow);
				}
				else
				{
					INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
					this._ShopFailedFlowCache = ((pocoInterface != null) ? pocoInterface.ShopFailedFlow : null);
				}
				return this._ShopFailedFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().ShopFailedFlow = value;
				this._ShopFailedFlowInited = false;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x00054A5A File Offset: 0x00052C5A
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x00054A81 File Offset: 0x00052C81
		[Nullable(2)]
		public virtual string UpgradeSequence
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UpgradeSequence;
				}
				INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UpgradeSequence;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UpgradeSequence = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00054A90 File Offset: 0x00052C90
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x00054AF1 File Offset: 0x00052CF1
		[Nullable(2)]
		public virtual PlayFlow UpgradeFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._UpgradeFlowInited)
				{
					return this._UpgradeFlowCache;
				}
				this._UpgradeFlowInited = true;
				if (this.FbInstance != null)
				{
					this._UpgradeFlowCache = PlayFlow.Create(this.FbInstance.UpgradeFlow);
				}
				else
				{
					INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
					this._UpgradeFlowCache = ((pocoInterface != null) ? pocoInterface.UpgradeFlow : null);
				}
				return this._UpgradeFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UpgradeFlow = value;
				this._UpgradeFlowInited = false;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00054B06 File Offset: 0x00052D06
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x00054B2D File Offset: 0x00052D2D
		[Nullable(2)]
		public virtual IMontageConfig ExitMontage
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitMontage;
				}
				INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExitMontage;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ExitMontage = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00054B3C File Offset: 0x00052D3C
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x00054B9D File Offset: 0x00052D9D
		[Nullable(2)]
		public virtual PlayFlow ExitFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._ExitFlowInited)
				{
					return this._ExitFlowCache;
				}
				this._ExitFlowInited = true;
				if (this.FbInstance != null)
				{
					this._ExitFlowCache = PlayFlow.Create(this.FbInstance.ExitFlow);
				}
				else
				{
					INpcUiInteractOnSoundBox35_SetValue pocoInterface = this.PocoInterface;
					this._ExitFlowCache = ((pocoInterface != null) ? pocoInterface.ExitFlow : null);
				}
				return this._ExitFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ExitFlow = value;
				this._ExitFlowInited = false;
			}
		}

		// Token: 0x04001531 RID: 5425
		[Nullable(2)]
		protected new INpcUiInteractOnSoundBox35 FbInstance;

		// Token: 0x04001532 RID: 5426
		[Nullable(2)]
		protected new INpcUiInteractOnSoundBox35_SetValue PocoInterface;

		// Token: 0x04001533 RID: 5427
		private PlayFlow _EnterFlowCache;

		// Token: 0x04001534 RID: 5428
		private bool _EnterFlowInited;

		// Token: 0x04001535 RID: 5429
		private PlayFlow _ShopSuccessFlowCache;

		// Token: 0x04001536 RID: 5430
		private bool _ShopSuccessFlowInited;

		// Token: 0x04001537 RID: 5431
		private PlayFlow _ShopFailedFlowCache;

		// Token: 0x04001538 RID: 5432
		private bool _ShopFailedFlowInited;

		// Token: 0x04001539 RID: 5433
		private PlayFlow _UpgradeFlowCache;

		// Token: 0x0400153A RID: 5434
		private bool _UpgradeFlowInited;

		// Token: 0x0400153B RID: 5435
		private PlayFlow _ExitFlowCache;

		// Token: 0x0400153C RID: 5436
		private bool _ExitFlowInited;
	}
}
