using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000225 RID: 549
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceed : ICategoryMatchingSucceedBase
	{
		// Token: 0x06000972 RID: 2418 RVA: 0x00029244 File Offset: 0x00027444
		[NullableContext(1)]
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

		// Token: 0x06000973 RID: 2419 RVA: 0x0002927C File Offset: 0x0002747C
		[NullableContext(1)]
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

		// Token: 0x06000974 RID: 2420 RVA: 0x0002928F File Offset: 0x0002748F
		[NullableContext(1)]
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

		// Token: 0x06000975 RID: 2421 RVA: 0x000292A4 File Offset: 0x000274A4
		[NullableContext(1)]
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

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00029330 File Offset: 0x00027530
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0002936A File Offset: 0x0002756A
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

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00029378 File Offset: 0x00027578
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x000293B2 File Offset: 0x000275B2
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

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x000293C0 File Offset: 0x000275C0
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x000293FA File Offset: 0x000275FA
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00029408 File Offset: 0x00027608
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x0002942F File Offset: 0x0002762F
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00029440 File Offset: 0x00027640
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x000294A1 File Offset: 0x000276A1
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

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x000294B8 File Offset: 0x000276B8
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x000294F2 File Offset: 0x000276F2
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

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00029500 File Offset: 0x00027700
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00029561 File Offset: 0x00027761
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

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00029576 File Offset: 0x00027776
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x0002959D File Offset: 0x0002779D
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

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x000295AC File Offset: 0x000277AC
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x0002960D File Offset: 0x0002780D
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

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00029622 File Offset: 0x00027822
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00029649 File Offset: 0x00027849
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

		// Token: 0x040009CD RID: 2509
		protected new ICategoryMatchingSucceed FbInstance;

		// Token: 0x040009CE RID: 2510
		protected new ICategoryMatchingSucceed_SetValue PocoInterface;

		// Token: 0x040009CF RID: 2511
		[Nullable(1)]
		private IEntityState _ChangeItemStateCache;

		// Token: 0x040009D0 RID: 2512
		private bool _ChangeItemStateInited;

		// Token: 0x040009D1 RID: 2513
		[Nullable(1)]
		private IEntityState _ChangeItemStateAfterDischargedCache;

		// Token: 0x040009D2 RID: 2514
		private bool _ChangeItemStateAfterDischargedInited;

		// Token: 0x040009D3 RID: 2515
		[Nullable(1)]
		private IItemChangeAdsorbateState _ChangeAdsorbateStateCache;

		// Token: 0x040009D4 RID: 2516
		private bool _ChangeAdsorbateStateInited;
	}
}
