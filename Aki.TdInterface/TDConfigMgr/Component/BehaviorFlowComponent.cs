using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000030 RID: 48
	public class BehaviorFlowComponent : IComponentBase
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x00018540 File Offset: 0x00016740
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

		// Token: 0x060001B3 RID: 435 RVA: 0x00018578 File Offset: 0x00016778
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

		// Token: 0x060001B4 RID: 436 RVA: 0x0001858B File Offset: 0x0001678B
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

		// Token: 0x060001B5 RID: 437 RVA: 0x000185A0 File Offset: 0x000167A0
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x000185F0 File Offset: 0x000167F0
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0001862A File Offset: 0x0001682A
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00018638 File Offset: 0x00016838
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00018662 File Offset: 0x00016862
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00018670 File Offset: 0x00016870
		// (set) Token: 0x060001BB RID: 443 RVA: 0x000186AA File Offset: 0x000168AA
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000186B8 File Offset: 0x000168B8
		// (set) Token: 0x060001BD RID: 445 RVA: 0x000186E3 File Offset: 0x000168E3
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001BE RID: 446 RVA: 0x000186F4 File Offset: 0x000168F4
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00018755 File Offset: 0x00016955
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

		// Token: 0x0400011F RID: 287
		[Nullable(2)]
		protected new BehaviorFlowComponent FbInstance;

		// Token: 0x04000120 RID: 288
		[Nullable(2)]
		protected new BehaviorFlowComponent_SetValue PocoInterface;

		// Token: 0x04000121 RID: 289
		private IFlowInfo _FlowInfoCache;

		// Token: 0x04000122 RID: 290
		private bool _FlowInfoInited;
	}
}
