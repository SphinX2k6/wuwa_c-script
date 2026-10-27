using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000776 RID: 1910
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimelineTrackControlData
	{
		// Token: 0x0600296F RID: 10607 RVA: 0x0006D58C File Offset: 0x0006B78C
		private ITimelineTrackControlData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimelineTrackControlData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimelineTrackControlData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimelineTrackControlData_SetValue());
			}
			return result;
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x0006D5C4 File Offset: 0x0006B7C4
		public static ITimelineTrackControlData Create([Nullable(2)] ITimelineTrackControlData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimelineTrackControlData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x0006D5D7 File Offset: 0x0006B7D7
		public static ITimelineTrackControlData CreateFromSetValue([Nullable(2)] ITimelineTrackControlData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimelineTrackControlData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x0006D5EA File Offset: 0x0006B7EA
		public ITimelineTrackControlData_SetValue ToSetValue()
		{
			return new ITimelineTrackControlData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x0006D5FD File Offset: 0x0006B7FD
		// (set) Token: 0x06002974 RID: 10612 RVA: 0x0006D628 File Offset: 0x0006B828
		public virtual ETrackControlMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrackControlMode.Sequence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001BCC RID: 7116
		[Nullable(2)]
		protected ITimelineTrackControlData FbInstance;

		// Token: 0x04001BCD RID: 7117
		[Nullable(2)]
		protected ITimelineTrackControlData_SetValue PocoInterface;
	}
}
