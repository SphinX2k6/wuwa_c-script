using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200058C RID: 1420
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnHandInItem : INpcUiInteractType
	{
		// Token: 0x06001D5A RID: 7514 RVA: 0x00053700 File Offset: 0x00051900
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

		// Token: 0x06001D5B RID: 7515 RVA: 0x00053738 File Offset: 0x00051938
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

		// Token: 0x06001D5C RID: 7516 RVA: 0x0005374B File Offset: 0x0005194B
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

		// Token: 0x06001D5D RID: 7517 RVA: 0x00053760 File Offset: 0x00051960
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

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x000537BA File Offset: 0x000519BA
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x000537E5 File Offset: 0x000519E5
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

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x000537F3 File Offset: 0x000519F3
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0005381E File Offset: 0x00051A1E
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

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0005382C File Offset: 0x00051A2C
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x00053857 File Offset: 0x00051A57
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

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x00053865 File Offset: 0x00051A65
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x00053890 File Offset: 0x00051A90
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

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x000538A0 File Offset: 0x00051AA0
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x00053901 File Offset: 0x00051B01
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

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00053918 File Offset: 0x00051B18
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x00053979 File Offset: 0x00051B79
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

		// Token: 0x040014E2 RID: 5346
		[Nullable(2)]
		protected new INpcUiInteractOnHandInItem FbInstance;

		// Token: 0x040014E3 RID: 5347
		[Nullable(2)]
		protected new INpcUiInteractOnHandInItem_SetValue PocoInterface;

		// Token: 0x040014E4 RID: 5348
		private PlayFlow _EnterFlowCache;

		// Token: 0x040014E5 RID: 5349
		private bool _EnterFlowInited;

		// Token: 0x040014E6 RID: 5350
		private PlayFlow _HandInFailedFlowCache;

		// Token: 0x040014E7 RID: 5351
		private bool _HandInFailedFlowInited;
	}
}
