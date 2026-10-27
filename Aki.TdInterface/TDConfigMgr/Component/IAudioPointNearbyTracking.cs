using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001D9 RID: 473
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioPointNearbyTracking : INearbyTracking
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x000252C4 File Offset: 0x000234C4
		private IAudioPointNearbyTracking_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAudioPointNearbyTracking 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAudioPointNearbyTracking_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAudioPointNearbyTracking_SetValue());
			}
			return result;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000252FC File Offset: 0x000234FC
		public static IAudioPointNearbyTracking Create([Nullable(2)] IAudioPointNearbyTracking instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioPointNearbyTracking
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0002530F File Offset: 0x0002350F
		public static IAudioPointNearbyTracking CreateFromSetValue([Nullable(2)] IAudioPointNearbyTracking_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAudioPointNearbyTracking
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00025322 File Offset: 0x00023522
		public new IAudioPointNearbyTracking_SetValue ToSetValue()
		{
			return new IAudioPointNearbyTracking_SetValue
			{
				Type = this.Type,
				NearRadius = this.NearRadius,
				MiddleRadius = this.MiddleRadius,
				FarRadius = this.FarRadius
			};
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00025359 File Offset: 0x00023559
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x00025384 File Offset: 0x00023584
		public override ENearbyTrackingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENearbyTrackingType.Icon;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00025392 File Offset: 0x00023592
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x000253BD File Offset: 0x000235BD
		public virtual int NearRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NearRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.NearRadius;
			}
			set
			{
				this.GetOrCreatePoco().NearRadius = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x000253CB File Offset: 0x000235CB
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x000253F6 File Offset: 0x000235F6
		public virtual int MiddleRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MiddleRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MiddleRadius;
			}
			set
			{
				this.GetOrCreatePoco().MiddleRadius = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00025404 File Offset: 0x00023604
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x0002542F File Offset: 0x0002362F
		public virtual int FarRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FarRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FarRadius;
			}
			set
			{
				this.GetOrCreatePoco().FarRadius = value;
			}
		}

		// Token: 0x040008B1 RID: 2225
		[Nullable(2)]
		protected new IAudioPointNearbyTracking FbInstance;

		// Token: 0x040008B2 RID: 2226
		[Nullable(2)]
		protected new IAudioPointNearbyTracking_SetValue PocoInterface;
	}
}
