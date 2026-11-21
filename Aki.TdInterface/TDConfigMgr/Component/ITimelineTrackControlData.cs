using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000817 RID: 2071
	public class ITimelineTrackControlData
	{
		// Token: 0x06002C93 RID: 11411 RVA: 0x00074734 File Offset: 0x00072934
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

		// Token: 0x06002C94 RID: 11412 RVA: 0x0007476C File Offset: 0x0007296C
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

		// Token: 0x06002C95 RID: 11413 RVA: 0x0007477F File Offset: 0x0007297F
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

		// Token: 0x06002C96 RID: 11414 RVA: 0x00074792 File Offset: 0x00072992
		public ITimelineTrackControlData_SetValue ToSetValue()
		{
			return new ITimelineTrackControlData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x000747A5 File Offset: 0x000729A5
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x000747D0 File Offset: 0x000729D0
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

		// Token: 0x04001DD1 RID: 7633
		[Nullable(2)]
		protected ITimelineTrackControlData FbInstance;

		// Token: 0x04001DD2 RID: 7634
		[Nullable(2)]
		protected ITimelineTrackControlData_SetValue PocoInterface;
	}
}
