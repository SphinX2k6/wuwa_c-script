using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000843 RID: 2115
	[NullableContext(1)]
	[Nullable(0)]
	public class NearbyTrackingComponent : IComponentBase
	{
		// Token: 0x06002E61 RID: 11873 RVA: 0x00077E30 File Offset: 0x00076030
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

		// Token: 0x06002E62 RID: 11874 RVA: 0x00077E68 File Offset: 0x00076068
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

		// Token: 0x06002E63 RID: 11875 RVA: 0x00077E7B File Offset: 0x0007607B
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

		// Token: 0x06002E64 RID: 11876 RVA: 0x00077E90 File Offset: 0x00076090
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

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x00077EEC File Offset: 0x000760EC
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x00077F26 File Offset: 0x00076126
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

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x00077F34 File Offset: 0x00076134
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x00077F5E File Offset: 0x0007615E
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

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x00077F6C File Offset: 0x0007616C
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x00077F97 File Offset: 0x00076197
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

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x00077FA8 File Offset: 0x000761A8
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x00077FE2 File Offset: 0x000761E2
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

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x00077FF0 File Offset: 0x000761F0
		// (set) Token: 0x06002E6E RID: 11886 RVA: 0x0007802A File Offset: 0x0007622A
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

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x00078038 File Offset: 0x00076238
		// (set) Token: 0x06002E70 RID: 11888 RVA: 0x0007805F File Offset: 0x0007625F
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

		// Token: 0x04001E9F RID: 7839
		[Nullable(2)]
		protected new NearbyTrackingComponent FbInstance;

		// Token: 0x04001EA0 RID: 7840
		[Nullable(2)]
		protected new NearbyTrackingComponent_SetValue PocoInterface;
	}
}
