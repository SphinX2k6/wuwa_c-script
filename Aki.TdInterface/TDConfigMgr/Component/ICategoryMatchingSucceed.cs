using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200024C RID: 588
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceed : ICategoryMatchingSucceedBase
	{
		// Token: 0x060009E6 RID: 2534 RVA: 0x0002AA04 File Offset: 0x00028C04
		[NullableContext(0)]
		private ICategoryMatchingSucceed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICategoryMatchingSucceed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICategoryMatchingSucceed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICategoryMatchingSucceed_SetValue());
			}
			return result;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0002AA3C File Offset: 0x00028C3C
		[NullableContext(0)]
		public static ICategoryMatchingSucceed Create([Nullable(2)] ICategoryMatchingSucceed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingSucceed
			{
				FbInstance = instance
			};
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002AA4F File Offset: 0x00028C4F
		[NullableContext(0)]
		public static ICategoryMatchingSucceed CreateFromSetValue([Nullable(2)] ICategoryMatchingSucceed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICategoryMatchingSucceed
			{
				PocoInterface = value
			};
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0002AA64 File Offset: 0x00028C64
		[NullableContext(0)]
		public new ICategoryMatchingSucceed_SetValue ToSetValue()
		{
			return new ICategoryMatchingSucceed_SetValue
			{
				IsSilent = this.IsSilent,
				IsDestroy = this.IsDestroy,
				SyncAdsorbatePerformance = this.SyncAdsorbatePerformance,
				ChangeSelfState = this.ChangeSelfState,
				ChangeItemState = this.ChangeItemState,
				DelayDischarge = this.DelayDischarge,
				ChangeItemStateAfterDischarged = this.ChangeItemStateAfterDischarged,
				ChangeSelfStateAfterDischarged = this.ChangeSelfStateAfterDischarged,
				ChangeAdsorbateState = this.ChangeAdsorbateState,
				DischargeSequence = this.DischargeSequence
			};
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0002AAF0 File Offset: 0x00028CF0
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x0002AB2A File Offset: 0x00028D2A
		public override bool? IsSilent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSilent;
				}
				ICategoryMatchingSucceed_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSilent;
			}
			set
			{
				this.GetOrCreatePoco().IsSilent = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0002AB38 File Offset: 0x00028D38
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0002AB72 File Offset: 0x00028D72
		public override bool? IsDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDestroy;
				}
				ICategoryMatchingSucceed_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDestroy;
			}
			set
			{
				this.GetOrCreatePoco().IsDestroy = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002AB80 File Offset: 0x00028D80
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0002ABBA File Offset: 0x00028DBA
		public override bool? SyncAdsorbatePerformance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SyncAdsorbatePerformance;
				}
				ICategoryMatchingSucceed_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SyncAdsorbatePerformance;
			}
			set
			{
				this.GetOrCreatePoco().SyncAdsorbatePerformance = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0002ABC8 File Offset: 0x00028DC8
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0002ABEF File Offset: 0x00028DEF
		public override string ChangeSelfState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSelfState;
				}
				ICategoryMatchingSucceed_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ChangeSelfState;
			}
			set
			{
				this.GetOrCreatePoco().ChangeSelfState = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0002AC00 File Offset: 0x00028E00
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x0002AC61 File Offset: 0x00028E61
		public override IEntityState ChangeItemState
		{
			get
			{
				if (this._ChangeItemStateInited)
				{
					return this._ChangeItemStateCache;
				}
				this._ChangeItemStateInited = true;
				if (this.FbInstance != null)
				{
					this._ChangeItemStateCache = IEntityState.Create(this.FbInstance.ChangeItemState);
				}
				else
				{
					ICategoryMatchingSucceed_SetValue pocoInterface = this.PocoInterface;
					this._ChangeItemStateCache = ((pocoInterface != null) ? pocoInterface.ChangeItemState : null);
				}
				return this._ChangeItemStateCache;
			}
			set
			{
				this.GetOrCreatePoco().ChangeItemState = value;
				this._ChangeItemStateInited = false;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0002AC78 File Offset: 0x00028E78
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x0002ACB2 File Offset: 0x00028EB2
		public override int? DelayDischarge
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayDischarge;
				}
				ICategoryMatchingSucceed_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayDischarge;
			}
			set
			{
				this.GetOrCreatePoco().DelayDischarge = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0002ACC0 File Offset: 0x00028EC0
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x0002AD21 File Offset: 0x00028F21
		public override IEntityState ChangeItemStateAfterDischarged
		{
			get
			{
				if (this._ChangeItemStateAfterDischargedInited)
				{
					return this._ChangeItemStateAfterDischargedCache;
				}
				this._ChangeItemStateAfterDischargedInited = true;
				if (this.FbInstance != null)
				{
					this._ChangeItemStateAfterDischargedCache = IEntityState.Create(this.FbInstance.ChangeItemStateAfterDischarged);
				}
				else
				{
					ICategoryMatchingSucceed_SetValue pocoInterface = this.PocoInterface;
					this._ChangeItemStateAfterDischargedCache = ((pocoInterface != null) ? pocoInterface.ChangeItemStateAfterDischarged : null);
				}
				return this._ChangeItemStateAfterDischargedCache;
			}
			set
			{
				this.GetOrCreatePoco().ChangeItemStateAfterDischarged = value;
				this._ChangeItemStateAfterDischargedInited = false;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0002AD36 File Offset: 0x00028F36
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x0002AD5D File Offset: 0x00028F5D
		public override string ChangeSelfStateAfterDischarged
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSelfStateAfterDischarged;
				}
				ICategoryMatchingSucceed_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ChangeSelfStateAfterDischarged;
			}
			set
			{
				this.GetOrCreatePoco().ChangeSelfStateAfterDischarged = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0002AD6C File Offset: 0x00028F6C
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x0002ADCD File Offset: 0x00028FCD
		public virtual IItemChangeAdsorbateState ChangeAdsorbateState
		{
			get
			{
				if (this._ChangeAdsorbateStateInited)
				{
					return this._ChangeAdsorbateStateCache;
				}
				this._ChangeAdsorbateStateInited = true;
				if (this.FbInstance != null)
				{
					this._ChangeAdsorbateStateCache = IItemChangeAdsorbateState.Create(this.FbInstance.ChangeAdsorbateState);
				}
				else
				{
					ICategoryMatchingSucceed_SetValue pocoInterface = this.PocoInterface;
					this._ChangeAdsorbateStateCache = ((pocoInterface != null) ? pocoInterface.ChangeAdsorbateState : null);
				}
				return this._ChangeAdsorbateStateCache;
			}
			set
			{
				this.GetOrCreatePoco().ChangeAdsorbateState = value;
				this._ChangeAdsorbateStateInited = false;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0002ADE2 File Offset: 0x00028FE2
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x0002AE09 File Offset: 0x00029009
		public virtual string DischargeSequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DischargeSequence;
				}
				ICategoryMatchingSucceed_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DischargeSequence;
			}
			set
			{
				this.GetOrCreatePoco().DischargeSequence = value;
			}
		}

		// Token: 0x04000A57 RID: 2647
		protected new ICategoryMatchingSucceed FbInstance;

		// Token: 0x04000A58 RID: 2648
		protected new ICategoryMatchingSucceed_SetValue PocoInterface;

		// Token: 0x04000A59 RID: 2649
		[Nullable(0)]
		private IEntityState _ChangeItemStateCache;

		// Token: 0x04000A5A RID: 2650
		private bool _ChangeItemStateInited;

		// Token: 0x04000A5B RID: 2651
		[Nullable(0)]
		private IEntityState _ChangeItemStateAfterDischargedCache;

		// Token: 0x04000A5C RID: 2652
		private bool _ChangeItemStateAfterDischargedInited;

		// Token: 0x04000A5D RID: 2653
		[Nullable(0)]
		private IItemChangeAdsorbateState _ChangeAdsorbateStateCache;

		// Token: 0x04000A5E RID: 2654
		private bool _ChangeAdsorbateStateInited;
	}
}
