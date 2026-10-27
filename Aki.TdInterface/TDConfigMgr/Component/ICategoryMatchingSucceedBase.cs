using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000227 RID: 551
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceedBase
	{
		// Token: 0x0600098C RID: 2444 RVA: 0x00029668 File Offset: 0x00027868
		[NullableContext(1)]
		private ICategoryMatchingSucceedBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICategoryMatchingSucceedBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICategoryMatchingSucceedBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICategoryMatchingSucceedBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000296A0 File Offset: 0x000278A0
		[NullableContext(1)]
		public static ICategoryMatchingSucceedBase Create([Nullable(2)] ICategoryMatchingSucceedBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingSucceedBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000296B3 File Offset: 0x000278B3
		[NullableContext(1)]
		public static ICategoryMatchingSucceedBase CreateFromSetValue([Nullable(2)] ICategoryMatchingSucceedBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICategoryMatchingSucceedBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000296C8 File Offset: 0x000278C8
		[NullableContext(1)]
		public ICategoryMatchingSucceedBase_SetValue ToSetValue()
		{
			return new ICategoryMatchingSucceedBase_SetValue
			{
				IsSilent = this.IsSilent,
				IsDestroy = this.IsDestroy,
				SyncAdsorbatePerformance = this.SyncAdsorbatePerformance,
				ChangeSelfState = this.ChangeSelfState,
				ChangeItemState = this.ChangeItemState,
				DelayDischarge = this.DelayDischarge,
				ChangeItemStateAfterDischarged = this.ChangeItemStateAfterDischarged,
				ChangeSelfStateAfterDischarged = this.ChangeSelfStateAfterDischarged
			};
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0002973C File Offset: 0x0002793C
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00029776 File Offset: 0x00027976
		public virtual bool? IsSilent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSilent;
				}
				ICategoryMatchingSucceedBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00029784 File Offset: 0x00027984
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x000297BE File Offset: 0x000279BE
		public virtual bool? IsDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDestroy;
				}
				ICategoryMatchingSucceedBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x000297CC File Offset: 0x000279CC
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00029806 File Offset: 0x00027A06
		public virtual bool? SyncAdsorbatePerformance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SyncAdsorbatePerformance;
				}
				ICategoryMatchingSucceedBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00029814 File Offset: 0x00027A14
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x0002983B File Offset: 0x00027A3B
		public virtual string ChangeSelfState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSelfState;
				}
				ICategoryMatchingSucceedBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0002984C File Offset: 0x00027A4C
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x000298AD File Offset: 0x00027AAD
		public virtual IEntityState ChangeItemState
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
					ICategoryMatchingSucceedBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x000298C4 File Offset: 0x00027AC4
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x000298FE File Offset: 0x00027AFE
		public virtual int? DelayDischarge
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayDischarge;
				}
				ICategoryMatchingSucceedBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002990C File Offset: 0x00027B0C
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x0002996D File Offset: 0x00027B6D
		public virtual IEntityState ChangeItemStateAfterDischarged
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
					ICategoryMatchingSucceedBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00029982 File Offset: 0x00027B82
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x000299A9 File Offset: 0x00027BA9
		public virtual string ChangeSelfStateAfterDischarged
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSelfStateAfterDischarged;
				}
				ICategoryMatchingSucceedBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040009DF RID: 2527
		protected ICategoryMatchingSucceedBase FbInstance;

		// Token: 0x040009E0 RID: 2528
		protected ICategoryMatchingSucceedBase_SetValue PocoInterface;

		// Token: 0x040009E1 RID: 2529
		[Nullable(1)]
		private IEntityState _ChangeItemStateCache;

		// Token: 0x040009E2 RID: 2530
		private bool _ChangeItemStateInited;

		// Token: 0x040009E3 RID: 2531
		[Nullable(1)]
		private IEntityState _ChangeItemStateAfterDischargedCache;

		// Token: 0x040009E4 RID: 2532
		private bool _ChangeItemStateAfterDischargedInited;
	}
}
