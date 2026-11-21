using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000200 RID: 512
	public class IAudioPointNearbyTracking : INearbyTracking
	{
		// Token: 0x06000804 RID: 2052 RVA: 0x000269A4 File Offset: 0x00024BA4
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

		// Token: 0x06000805 RID: 2053 RVA: 0x000269DC File Offset: 0x00024BDC
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

		// Token: 0x06000806 RID: 2054 RVA: 0x000269EF File Offset: 0x00024BEF
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

		// Token: 0x06000807 RID: 2055 RVA: 0x00026A02 File Offset: 0x00024C02
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00026A39 File Offset: 0x00024C39
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00026A64 File Offset: 0x00024C64
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00026A72 File Offset: 0x00024C72
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00026A9D File Offset: 0x00024C9D
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

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00026AAB File Offset: 0x00024CAB
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00026AD6 File Offset: 0x00024CD6
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

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00026AE4 File Offset: 0x00024CE4
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x00026B0F File Offset: 0x00024D0F
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

		// Token: 0x04000938 RID: 2360
		[Nullable(2)]
		protected new IAudioPointNearbyTracking FbInstance;

		// Token: 0x04000939 RID: 2361
		[Nullable(2)]
		protected new IAudioPointNearbyTracking_SetValue PocoInterface;
	}
}
