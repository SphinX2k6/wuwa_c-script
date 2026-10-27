using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000030 RID: 48
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorFlowComponent : IComponentBase
	{
		// Token: 0x060001AE RID: 430 RVA: 0x00017BCC File Offset: 0x00015DCC
		private BehaviorFlowComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BehaviorFlowComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BehaviorFlowComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BehaviorFlowComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00017C04 File Offset: 0x00015E04
		public static BehaviorFlowComponent Create([Nullable(2)] BehaviorFlowComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BehaviorFlowComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00017C17 File Offset: 0x00015E17
		public static BehaviorFlowComponent CreateFromSetValue([Nullable(2)] BehaviorFlowComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BehaviorFlowComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00017C2C File Offset: 0x00015E2C
		public new BehaviorFlowComponent_SetValue ToSetValue()
		{
			return new BehaviorFlowComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				_folded = this._Folded,
				InitStateId = this.InitStateId,
				FlowInfo = this.FlowInfo
			};
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00017C7C File Offset: 0x00015E7C
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00017CB6 File Offset: 0x00015EB6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				BehaviorFlowComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00017CC4 File Offset: 0x00015EC4
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00017CEE File Offset: 0x00015EEE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00017CFC File Offset: 0x00015EFC
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00017D36 File Offset: 0x00015F36
		public virtual bool? _Folded
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._Folded;
				}
				BehaviorFlowComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._folded;
			}
			set
			{
				this.GetOrCreatePoco()._folded = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00017D44 File Offset: 0x00015F44
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00017D6F File Offset: 0x00015F6F
		public virtual int InitStateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitStateId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InitStateId;
			}
			set
			{
				this.GetOrCreatePoco().InitStateId = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00017D80 File Offset: 0x00015F80
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00017DE1 File Offset: 0x00015FE1
		public virtual IFlowInfo FlowInfo
		{
			get
			{
				if (this._FlowInfoInited)
				{
					return this._FlowInfoCache;
				}
				this._FlowInfoInited = true;
				if (this.FbInstance != null)
				{
					this._FlowInfoCache = IFlowInfo.Create(this.FbInstance.FlowInfo);
				}
				else
				{
					BehaviorFlowComponent_SetValue pocoInterface = this.PocoInterface;
					this._FlowInfoCache = ((pocoInterface != null) ? pocoInterface.FlowInfo : null);
				}
				return this._FlowInfoCache;
			}
			set
			{
				this.GetOrCreatePoco().FlowInfo = value;
				this._FlowInfoInited = false;
			}
		}

		// Token: 0x0400011A RID: 282
		[Nullable(2)]
		protected new BehaviorFlowComponent FbInstance;

		// Token: 0x0400011B RID: 283
		[Nullable(2)]
		protected new BehaviorFlowComponent_SetValue PocoInterface;

		// Token: 0x0400011C RID: 284
		private IFlowInfo _FlowInfoCache;

		// Token: 0x0400011D RID: 285
		private bool _FlowInfoInited;
	}
}
