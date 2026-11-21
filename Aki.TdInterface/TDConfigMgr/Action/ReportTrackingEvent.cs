using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B9 RID: 9145
	public class ReportTrackingEvent : ActionParams
	{
		// Token: 0x0600C768 RID: 51048 RVA: 0x001C8968 File Offset: 0x001C6B68
		private ReportTrackingEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReportTrackingEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReportTrackingEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReportTrackingEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600C769 RID: 51049 RVA: 0x001C89A0 File Offset: 0x001C6BA0
		public static ReportTrackingEvent Create([Nullable(2)] ReportTrackingEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReportTrackingEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C76A RID: 51050 RVA: 0x001C89B3 File Offset: 0x001C6BB3
		public static ReportTrackingEvent CreateFromSetValue([Nullable(2)] ReportTrackingEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReportTrackingEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C76B RID: 51051 RVA: 0x001C89C6 File Offset: 0x001C6BC6
		public ReportTrackingEvent_SetValue ToSetValue()
		{
			return new ReportTrackingEvent_SetValue
			{
				TrackingEventType = this.TrackingEventType
			};
		}

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x0600C76C RID: 51052 RVA: 0x001C89D9 File Offset: 0x001C6BD9
		// (set) Token: 0x0600C76D RID: 51053 RVA: 0x001C8A00 File Offset: 0x001C6C00
		public virtual ITrackingEventTypeBase TrackingEventType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrackingEventType;
				}
				ReportTrackingEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TrackingEventType;
			}
			set
			{
				this.GetOrCreatePoco().TrackingEventType = value;
			}
		}

		// Token: 0x04007679 RID: 30329
		[Nullable(2)]
		protected new ReportTrackingEvent FbInstance;

		// Token: 0x0400767A RID: 30330
		[Nullable(2)]
		protected ReportTrackingEvent_SetValue PocoInterface;
	}
}
