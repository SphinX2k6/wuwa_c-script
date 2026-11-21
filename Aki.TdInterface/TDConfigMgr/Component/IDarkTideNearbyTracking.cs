using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002F2 RID: 754
	public class IDarkTideNearbyTracking : INearbyTracking
	{
		// Token: 0x06000DF5 RID: 3573 RVA: 0x00033B68 File Offset: 0x00031D68
		private IDarkTideNearbyTracking_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideNearbyTracking 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideNearbyTracking_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideNearbyTracking_SetValue());
			}
			return result;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00033BA0 File Offset: 0x00031DA0
		public static IDarkTideNearbyTracking Create([Nullable(2)] IDarkTideNearbyTracking instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideNearbyTracking
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00033BB3 File Offset: 0x00031DB3
		public static IDarkTideNearbyTracking CreateFromSetValue([Nullable(2)] IDarkTideNearbyTracking_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideNearbyTracking
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00033BC6 File Offset: 0x00031DC6
		public new IDarkTideNearbyTracking_SetValue ToSetValue()
		{
			return new IDarkTideNearbyTracking_SetValue
			{
				Type = this.Type,
				ShowRange = this.ShowRange,
				HideRange = this.HideRange
			};
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00033BF1 File Offset: 0x00031DF1
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x00033C1C File Offset: 0x00031E1C
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

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00033C2A File Offset: 0x00031E2A
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x00033C55 File Offset: 0x00031E55
		public virtual int ShowRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ShowRange;
			}
			set
			{
				this.GetOrCreatePoco().ShowRange = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00033C63 File Offset: 0x00031E63
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x00033C8E File Offset: 0x00031E8E
		public virtual int HideRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HideRange;
			}
			set
			{
				this.GetOrCreatePoco().HideRange = value;
			}
		}

		// Token: 0x04000CBC RID: 3260
		[Nullable(2)]
		protected new IDarkTideNearbyTracking FbInstance;

		// Token: 0x04000CBD RID: 3261
		[Nullable(2)]
		protected new IDarkTideNearbyTracking_SetValue PocoInterface;
	}
}
