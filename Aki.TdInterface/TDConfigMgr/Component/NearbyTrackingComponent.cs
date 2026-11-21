using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008E6 RID: 2278
	public class NearbyTrackingComponent : IComponentBase
	{
		// Token: 0x06003197 RID: 12695 RVA: 0x0007F254 File Offset: 0x0007D454
		private NearbyTrackingComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("NearbyTrackingComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			NearbyTrackingComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new NearbyTrackingComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x0007F28C File Offset: 0x0007D48C
		public static NearbyTrackingComponent Create([Nullable(2)] NearbyTrackingComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NearbyTrackingComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x0007F29F File Offset: 0x0007D49F
		public static NearbyTrackingComponent CreateFromSetValue([Nullable(2)] NearbyTrackingComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new NearbyTrackingComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x0007F2B4 File Offset: 0x0007D4B4
		public new NearbyTrackingComponent_SetValue ToSetValue()
		{
			return new NearbyTrackingComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				IsEnable = this.IsEnable,
				IsEnableWhileUnlock = this.IsEnableWhileUnlock,
				IsEnbaleWhileHoming = this.IsEnbaleWhileHoming,
				TrackingType = this.TrackingType
			};
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x0007F310 File Offset: 0x0007D510
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x0007F34A File Offset: 0x0007D54A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				NearbyTrackingComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x0007F358 File Offset: 0x0007D558
		// (set) Token: 0x0600319E RID: 12702 RVA: 0x0007F382 File Offset: 0x0007D582
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

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x0007F390 File Offset: 0x0007D590
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x0007F3BB File Offset: 0x0007D5BB
		public virtual bool IsEnable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsEnable;
			}
			set
			{
				this.GetOrCreatePoco().IsEnable = value;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x0007F3CC File Offset: 0x0007D5CC
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x0007F406 File Offset: 0x0007D606
		public virtual bool? IsEnableWhileUnlock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnableWhileUnlock;
				}
				NearbyTrackingComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsEnableWhileUnlock;
			}
			set
			{
				this.GetOrCreatePoco().IsEnableWhileUnlock = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x0007F414 File Offset: 0x0007D614
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x0007F44E File Offset: 0x0007D64E
		public virtual bool? IsEnbaleWhileHoming
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnbaleWhileHoming;
				}
				NearbyTrackingComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsEnbaleWhileHoming;
			}
			set
			{
				this.GetOrCreatePoco().IsEnbaleWhileHoming = value;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x0007F45C File Offset: 0x0007D65C
		// (set) Token: 0x060031A6 RID: 12710 RVA: 0x0007F483 File Offset: 0x0007D683
		public virtual INearbyTracking TrackingType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrackingType;
				}
				NearbyTrackingComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TrackingType;
			}
			set
			{
				this.GetOrCreatePoco().TrackingType = value;
			}
		}

		// Token: 0x040020AE RID: 8366
		[Nullable(2)]
		protected new NearbyTrackingComponent FbInstance;

		// Token: 0x040020AF RID: 8367
		[Nullable(2)]
		protected new NearbyTrackingComponent_SetValue PocoInterface;
	}
}
