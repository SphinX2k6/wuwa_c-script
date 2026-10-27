using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF3 RID: 10995
	[NullableContext(1)]
	[Nullable(0)]
	public class ReportTrackingEvent : ActionParams
	{
		// Token: 0x0600F0E7 RID: 61671 RVA: 0x0022F531 File Offset: 0x0022D731
		public static ReportTrackingEvent Create(IReportTrackingEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReportTrackingEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CC3 RID: 19651
		// (get) Token: 0x0600F0E8 RID: 61672 RVA: 0x0022F550 File Offset: 0x0022D750
		public virtual ITrackingEventTypeBase TrackingEventType
		{
			get
			{
				if (this._TrackingEventTypeInited)
				{
					return this._TrackingEventTypeCache;
				}
				this._TrackingEventTypeInited = true;
				this._TrackingEventTypeCache = ActionReadHelper.ReadReportTrackingEvent_TrackingEventType(this.Instance);
				return this._TrackingEventTypeCache;
			}
		}

		// Token: 0x04008485 RID: 33925
		private IReportTrackingEvent Instance;

		// Token: 0x04008486 RID: 33926
		private ITrackingEventTypeBase _TrackingEventTypeCache;

		// Token: 0x04008487 RID: 33927
		private bool _TrackingEventTypeInited;
	}
}
