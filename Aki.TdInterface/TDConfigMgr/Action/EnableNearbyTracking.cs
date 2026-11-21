using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017B1 RID: 6065
	public class EnableNearbyTracking : ActionParams
	{
		// Token: 0x06008351 RID: 33617 RVA: 0x0013A49C File Offset: 0x0013869C
		private EnableNearbyTracking_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableNearbyTracking 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableNearbyTracking_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableNearbyTracking_SetValue());
			}
			return result;
		}

		// Token: 0x06008352 RID: 33618 RVA: 0x0013A4D4 File Offset: 0x001386D4
		public static EnableNearbyTracking Create([Nullable(2)] EnableNearbyTracking instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableNearbyTracking
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008353 RID: 33619 RVA: 0x0013A4E7 File Offset: 0x001386E7
		public static EnableNearbyTracking CreateFromSetValue([Nullable(2)] EnableNearbyTracking_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableNearbyTracking
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x0013A4FA File Offset: 0x001386FA
		public EnableNearbyTracking_SetValue ToSetValue()
		{
			return new EnableNearbyTracking_SetValue
			{
				IsEnable = this.IsEnable,
				ControlType = this.ControlType
			};
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x06008355 RID: 33621 RVA: 0x0013A519 File Offset: 0x00138719
		// (set) Token: 0x06008356 RID: 33622 RVA: 0x0013A544 File Offset: 0x00138744
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

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x06008357 RID: 33623 RVA: 0x0013A552 File Offset: 0x00138752
		// (set) Token: 0x06008358 RID: 33624 RVA: 0x0013A579 File Offset: 0x00138779
		[Nullable(2)]
		public virtual IControlTrackingType ControlType
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ControlType;
				}
				EnableNearbyTracking_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ControlType;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ControlType = value;
			}
		}

		// Token: 0x04005064 RID: 20580
		[Nullable(2)]
		protected new EnableNearbyTracking FbInstance;

		// Token: 0x04005065 RID: 20581
		[Nullable(2)]
		protected EnableNearbyTracking_SetValue PocoInterface;
	}
}
