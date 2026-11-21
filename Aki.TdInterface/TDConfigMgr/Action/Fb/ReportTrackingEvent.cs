using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DE7 RID: 11751
	public class ReportTrackingEvent : ActionParams
	{
		// Token: 0x0600FF9D RID: 65437 RVA: 0x0024D23D File Offset: 0x0024B43D
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

		// Token: 0x1700507D RID: 20605
		// (get) Token: 0x0600FF9E RID: 65438 RVA: 0x0024D25C File Offset: 0x0024B45C
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

		// Token: 0x04008B89 RID: 35721
		private IReportTrackingEvent Instance;

		// Token: 0x04008B8A RID: 35722
		private ITrackingEventTypeBase _TrackingEventTypeCache;

		// Token: 0x04008B8B RID: 35723
		private bool _TrackingEventTypeInited;
	}
}
