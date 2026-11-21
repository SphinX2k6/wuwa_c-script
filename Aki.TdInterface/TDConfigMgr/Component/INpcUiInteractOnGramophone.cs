using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F3 RID: 1523
	public class INpcUiInteractOnGramophone : INpcUiInteractType
	{
		// Token: 0x06001F4A RID: 8010 RVA: 0x00058254 File Offset: 0x00056454
		private INpcUiInteractOnGramophone_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnGramophone 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnGramophone_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnGramophone_SetValue());
			}
			return result;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0005828C File Offset: 0x0005648C
		public static INpcUiInteractOnGramophone Create([Nullable(2)] INpcUiInteractOnGramophone instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnGramophone
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0005829F File Offset: 0x0005649F
		public static INpcUiInteractOnGramophone CreateFromSetValue([Nullable(2)] INpcUiInteractOnGramophone_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnGramophone
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x000582B4 File Offset: 0x000564B4
		public new INpcUiInteractOnGramophone_SetValue ToSetValue()
		{
			return new INpcUiInteractOnGramophone_SetValue
			{
				Type = this.Type,
				EnterMontage = this.EnterMontage,
				StandByMontage = this.StandByMontage,
				SwitchMusicMontage = this.SwitchMusicMontage,
				ExitMontage = this.ExitMontage,
				EnterFlow = this.EnterFlow,
				FailedFlow = this.FailedFlow,
				SuccessFlow = this.SuccessFlow
			};
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00058326 File Offset: 0x00056526
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x00058351 File Offset: 0x00056551
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

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x0005835F File Offset: 0x0005655F
		// (set) Token: 0x06001F51 RID: 8017 RVA: 0x0005838A File Offset: 0x0005658A
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

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x00058398 File Offset: 0x00056598
		// (set) Token: 0x06001F53 RID: 8019 RVA: 0x000583C3 File Offset: 0x000565C3
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

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x000583D1 File Offset: 0x000565D1
		// (set) Token: 0x06001F55 RID: 8021 RVA: 0x000583FC File Offset: 0x000565FC
		public virtual string SwitchMusicMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SwitchMusicMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SwitchMusicMontage;
			}
			set
			{
				this.GetOrCreatePoco().SwitchMusicMontage = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x0005840A File Offset: 0x0005660A
		// (set) Token: 0x06001F57 RID: 8023 RVA: 0x00058435 File Offset: 0x00056635
		public virtual string ExitMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ExitMontage;
			}
			set
			{
				this.GetOrCreatePoco().ExitMontage = value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x00058444 File Offset: 0x00056644
		// (set) Token: 0x06001F59 RID: 8025 RVA: 0x000584A5 File Offset: 0x000566A5
		[Nullable(2)]
		public virtual PlayFlow EnterFlow
		{
			[NullableContext(2)]
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
					INpcUiInteractOnGramophone_SetValue pocoInterface = this.PocoInterface;
					this._EnterFlowCache = ((pocoInterface != null) ? pocoInterface.EnterFlow : null);
				}
				return this._EnterFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EnterFlow = value;
				this._EnterFlowInited = false;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x000584BC File Offset: 0x000566BC
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x0005851D File Offset: 0x0005671D
		[Nullable(2)]
		public virtual PlayFlow FailedFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._FailedFlowInited)
				{
					return this._FailedFlowCache;
				}
				this._FailedFlowInited = true;
				if (this.FbInstance != null)
				{
					this._FailedFlowCache = PlayFlow.Create(this.FbInstance.FailedFlow);
				}
				else
				{
					INpcUiInteractOnGramophone_SetValue pocoInterface = this.PocoInterface;
					this._FailedFlowCache = ((pocoInterface != null) ? pocoInterface.FailedFlow : null);
				}
				return this._FailedFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FailedFlow = value;
				this._FailedFlowInited = false;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x00058534 File Offset: 0x00056734
		// (set) Token: 0x06001F5D RID: 8029 RVA: 0x00058595 File Offset: 0x00056795
		[Nullable(2)]
		public virtual PlayFlow SuccessFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._SuccessFlowInited)
				{
					return this._SuccessFlowCache;
				}
				this._SuccessFlowInited = true;
				if (this.FbInstance != null)
				{
					this._SuccessFlowCache = PlayFlow.Create(this.FbInstance.SuccessFlow);
				}
				else
				{
					INpcUiInteractOnGramophone_SetValue pocoInterface = this.PocoInterface;
					this._SuccessFlowCache = ((pocoInterface != null) ? pocoInterface.SuccessFlow : null);
				}
				return this._SuccessFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SuccessFlow = value;
				this._SuccessFlowInited = false;
			}
		}

		// Token: 0x04001640 RID: 5696
		[Nullable(2)]
		protected new INpcUiInteractOnGramophone FbInstance;

		// Token: 0x04001641 RID: 5697
		[Nullable(2)]
		protected new INpcUiInteractOnGramophone_SetValue PocoInterface;

		// Token: 0x04001642 RID: 5698
		private PlayFlow _EnterFlowCache;

		// Token: 0x04001643 RID: 5699
		private bool _EnterFlowInited;

		// Token: 0x04001644 RID: 5700
		private PlayFlow _FailedFlowCache;

		// Token: 0x04001645 RID: 5701
		private bool _FailedFlowInited;

		// Token: 0x04001646 RID: 5702
		private PlayFlow _SuccessFlowCache;

		// Token: 0x04001647 RID: 5703
		private bool _SuccessFlowInited;
	}
}
