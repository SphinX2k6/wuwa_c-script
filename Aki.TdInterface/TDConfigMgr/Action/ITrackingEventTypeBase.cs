using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FDC RID: 8156
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackingEventTypeBase
	{
		// Token: 0x0600B372 RID: 45938 RVA: 0x001A1C38 File Offset: 0x0019FE38
		private ITrackingEventTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackingEventTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackingEventTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackingEventTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B373 RID: 45939 RVA: 0x001A1C70 File Offset: 0x0019FE70
		public static ITrackingEventTypeBase Create([Nullable(2)] ITrackingEventTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackingEventTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x001A1C83 File Offset: 0x0019FE83
		public static ITrackingEventTypeBase CreateFromSetValue([Nullable(2)] ITrackingEventTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackingEventTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B375 RID: 45941 RVA: 0x001A1C96 File Offset: 0x0019FE96
		public ITrackingEventTypeBase_SetValue ToSetValue()
		{
			return new ITrackingEventTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0600B376 RID: 45942 RVA: 0x001A1CA9 File Offset: 0x0019FEA9
		// (set) Token: 0x0600B377 RID: 45943 RVA: 0x001A1CD4 File Offset: 0x0019FED4
		public virtual ETrackingEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrackingEventType.EasterEgg;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006C42 RID: 27714
		[Nullable(2)]
		protected ITrackingEventTypeBase FbInstance;

		// Token: 0x04006C43 RID: 27715
		[Nullable(2)]
		protected ITrackingEventTypeBase_SetValue PocoInterface;
	}
}
