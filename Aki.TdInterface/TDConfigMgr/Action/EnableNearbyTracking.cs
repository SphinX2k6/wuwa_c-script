using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001644 RID: 5700
	[NullableContext(2)]
	[Nullable(0)]
	public class EnableNearbyTracking : ActionParams
	{
		// Token: 0x06007C73 RID: 31859 RVA: 0x0012B3F0 File Offset: 0x001295F0
		[NullableContext(1)]
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

		// Token: 0x06007C74 RID: 31860 RVA: 0x0012B428 File Offset: 0x00129628
		[NullableContext(1)]
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

		// Token: 0x06007C75 RID: 31861 RVA: 0x0012B43B File Offset: 0x0012963B
		[NullableContext(1)]
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

		// Token: 0x06007C76 RID: 31862 RVA: 0x0012B44E File Offset: 0x0012964E
		[NullableContext(1)]
		public EnableNearbyTracking_SetValue ToSetValue()
		{
			return new EnableNearbyTracking_SetValue
			{
				IsEnable = this.IsEnable,
				ControlType = this.ControlType
			};
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x0012B46D File Offset: 0x0012966D
		// (set) Token: 0x06007C78 RID: 31864 RVA: 0x0012B498 File Offset: 0x00129698
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

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x0012B4A6 File Offset: 0x001296A6
		// (set) Token: 0x06007C7A RID: 31866 RVA: 0x0012B4CD File Offset: 0x001296CD
		public virtual IControlTrackingType ControlType
		{
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
			set
			{
				this.GetOrCreatePoco().ControlType = value;
			}
		}

		// Token: 0x04004C70 RID: 19568
		protected new EnableNearbyTracking FbInstance;

		// Token: 0x04004C71 RID: 19569
		protected EnableNearbyTracking_SetValue PocoInterface;
	}
}
