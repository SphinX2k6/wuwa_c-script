using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F5 RID: 1525
	public class INpcUiInteractOnHandInItem : INpcUiInteractType
	{
		// Token: 0x06001F60 RID: 8032 RVA: 0x000585BC File Offset: 0x000567BC
		private INpcUiInteractOnHandInItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnHandInItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnHandInItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnHandInItem_SetValue());
			}
			return result;
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000585F4 File Offset: 0x000567F4
		public static INpcUiInteractOnHandInItem Create([Nullable(2)] INpcUiInteractOnHandInItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnHandInItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x00058607 File Offset: 0x00056807
		public static INpcUiInteractOnHandInItem CreateFromSetValue([Nullable(2)] INpcUiInteractOnHandInItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnHandInItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x0005861C File Offset: 0x0005681C
		public new INpcUiInteractOnHandInItem_SetValue ToSetValue()
		{
			return new INpcUiInteractOnHandInItem_SetValue
			{
				Type = this.Type,
				EnterMontage = this.EnterMontage,
				StandByMontage = this.StandByMontage,
				HandInFailedMontage = this.HandInFailedMontage,
				EnterFlow = this.EnterFlow,
				HandInFailedFlow = this.HandInFailedFlow
			};
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x00058676 File Offset: 0x00056876
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x000586A1 File Offset: 0x000568A1
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

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x000586AF File Offset: 0x000568AF
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x000586DA File Offset: 0x000568DA
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

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x000586E8 File Offset: 0x000568E8
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00058713 File Offset: 0x00056913
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

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x00058721 File Offset: 0x00056921
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x0005874C File Offset: 0x0005694C
		public virtual string HandInFailedMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandInFailedMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.HandInFailedMontage;
			}
			set
			{
				this.GetOrCreatePoco().HandInFailedMontage = value;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0005875C File Offset: 0x0005695C
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x000587BD File Offset: 0x000569BD
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
					INpcUiInteractOnHandInItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x000587D4 File Offset: 0x000569D4
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x00058835 File Offset: 0x00056A35
		[Nullable(2)]
		public virtual PlayFlow HandInFailedFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._HandInFailedFlowInited)
				{
					return this._HandInFailedFlowCache;
				}
				this._HandInFailedFlowInited = true;
				if (this.FbInstance != null)
				{
					this._HandInFailedFlowCache = PlayFlow.Create(this.FbInstance.HandInFailedFlow);
				}
				else
				{
					INpcUiInteractOnHandInItem_SetValue pocoInterface = this.PocoInterface;
					this._HandInFailedFlowCache = ((pocoInterface != null) ? pocoInterface.HandInFailedFlow : null);
				}
				return this._HandInFailedFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().HandInFailedFlow = value;
				this._HandInFailedFlowInited = false;
			}
		}

		// Token: 0x04001650 RID: 5712
		[Nullable(2)]
		protected new INpcUiInteractOnHandInItem FbInstance;

		// Token: 0x04001651 RID: 5713
		[Nullable(2)]
		protected new INpcUiInteractOnHandInItem_SetValue PocoInterface;

		// Token: 0x04001652 RID: 5714
		private PlayFlow _EnterFlowCache;

		// Token: 0x04001653 RID: 5715
		private bool _EnterFlowInited;

		// Token: 0x04001654 RID: 5716
		private PlayFlow _HandInFailedFlowCache;

		// Token: 0x04001655 RID: 5717
		private bool _HandInFailedFlowInited;
	}
}
