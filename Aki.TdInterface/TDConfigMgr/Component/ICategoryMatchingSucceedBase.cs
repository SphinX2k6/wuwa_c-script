using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200024E RID: 590
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceedBase
	{
		// Token: 0x06000A00 RID: 2560 RVA: 0x0002AE28 File Offset: 0x00029028
		[NullableContext(0)]
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

		// Token: 0x06000A01 RID: 2561 RVA: 0x0002AE60 File Offset: 0x00029060
		[NullableContext(0)]
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

		// Token: 0x06000A02 RID: 2562 RVA: 0x0002AE73 File Offset: 0x00029073
		[NullableContext(0)]
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

		// Token: 0x06000A03 RID: 2563 RVA: 0x0002AE88 File Offset: 0x00029088
		[NullableContext(0)]
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

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0002AEFC File Offset: 0x000290FC
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x0002AF36 File Offset: 0x00029136
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0002AF44 File Offset: 0x00029144
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x0002AF7E File Offset: 0x0002917E
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

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0002AF8C File Offset: 0x0002918C
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x0002AFC6 File Offset: 0x000291C6
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

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0002AFD4 File Offset: 0x000291D4
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0002AFFB File Offset: 0x000291FB
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

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0002B00C File Offset: 0x0002920C
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0002B06D File Offset: 0x0002926D
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

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0002B084 File Offset: 0x00029284
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x0002B0BE File Offset: 0x000292BE
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

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0002B0CC File Offset: 0x000292CC
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x0002B12D File Offset: 0x0002932D
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

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0002B142 File Offset: 0x00029342
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x0002B169 File Offset: 0x00029369
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

		// Token: 0x04000A69 RID: 2665
		protected ICategoryMatchingSucceedBase FbInstance;

		// Token: 0x04000A6A RID: 2666
		protected ICategoryMatchingSucceedBase_SetValue PocoInterface;

		// Token: 0x04000A6B RID: 2667
		[Nullable(0)]
		private IEntityState _ChangeItemStateCache;

		// Token: 0x04000A6C RID: 2668
		private bool _ChangeItemStateInited;

		// Token: 0x04000A6D RID: 2669
		[Nullable(0)]
		private IEntityState _ChangeItemStateAfterDischargedCache;

		// Token: 0x04000A6E RID: 2670
		private bool _ChangeItemStateAfterDischargedInited;
	}
}
