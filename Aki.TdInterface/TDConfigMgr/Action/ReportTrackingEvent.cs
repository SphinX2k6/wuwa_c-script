using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002158 RID: 8536
	[NullableContext(1)]
	[Nullable(0)]
	public class ReportTrackingEvent : ActionParams
	{
		// Token: 0x0600BBDA RID: 48090 RVA: 0x001B17B4 File Offset: 0x001AF9B4
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

		// Token: 0x0600BBDB RID: 48091 RVA: 0x001B17EC File Offset: 0x001AF9EC
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

		// Token: 0x0600BBDC RID: 48092 RVA: 0x001B17FF File Offset: 0x001AF9FF
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

		// Token: 0x0600BBDD RID: 48093 RVA: 0x001B1812 File Offset: 0x001AFA12
		public ReportTrackingEvent_SetValue ToSetValue()
		{
			return new ReportTrackingEvent_SetValue
			{
				TrackingEventType = this.TrackingEventType
			};
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x0600BBDE RID: 48094 RVA: 0x001B1825 File Offset: 0x001AFA25
		// (set) Token: 0x0600BBDF RID: 48095 RVA: 0x001B184C File Offset: 0x001AFA4C
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

		// Token: 0x04007044 RID: 28740
		[Nullable(2)]
		protected new ReportTrackingEvent FbInstance;

		// Token: 0x04007045 RID: 28741
		[Nullable(2)]
		protected ReportTrackingEvent_SetValue PocoInterface;
	}
}
