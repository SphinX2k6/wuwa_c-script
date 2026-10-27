using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000544 RID: 1348
	[NullableContext(1)]
	[Nullable(0)]
	public class INearbyTracking
	{
		// Token: 0x06001B90 RID: 7056 RVA: 0x0004F9F4 File Offset: 0x0004DBF4
		private INearbyTracking_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INearbyTracking 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INearbyTracking_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INearbyTracking_SetValue());
			}
			return result;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0004FA2C File Offset: 0x0004DC2C
		public static INearbyTracking Create([Nullable(2)] INearbyTracking instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INearbyTracking
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0004FA3F File Offset: 0x0004DC3F
		public static INearbyTracking CreateFromSetValue([Nullable(2)] INearbyTracking_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INearbyTracking
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0004FA52 File Offset: 0x0004DC52
		public INearbyTracking_SetValue ToSetValue()
		{
			return new INearbyTracking_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x0004FA65 File Offset: 0x0004DC65
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x0004FA90 File Offset: 0x0004DC90
		public virtual ENearbyTrackingType Type
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

		// Token: 0x040013D5 RID: 5077
		[Nullable(2)]
		protected INearbyTracking FbInstance;

		// Token: 0x040013D6 RID: 5078
		[Nullable(2)]
		protected INearbyTracking_SetValue PocoInterface;
	}
}
