using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005AB RID: 1451
	public class INearbyTracking
	{
		// Token: 0x06001D8C RID: 7564 RVA: 0x000547B0 File Offset: 0x000529B0
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

		// Token: 0x06001D8D RID: 7565 RVA: 0x000547E8 File Offset: 0x000529E8
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

		// Token: 0x06001D8E RID: 7566 RVA: 0x000547FB File Offset: 0x000529FB
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

		// Token: 0x06001D8F RID: 7567 RVA: 0x0005480E File Offset: 0x00052A0E
		public INearbyTracking_SetValue ToSetValue()
		{
			return new INearbyTracking_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x00054821 File Offset: 0x00052A21
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x0005484C File Offset: 0x00052A4C
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

		// Token: 0x0400153F RID: 5439
		[Nullable(2)]
		protected INearbyTracking FbInstance;

		// Token: 0x04001540 RID: 5440
		[Nullable(2)]
		protected INearbyTracking_SetValue PocoInterface;
	}
}
