using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DE4 RID: 11748
	public class ITrackingEventTypeBase
	{
		// Token: 0x0600FF91 RID: 65425 RVA: 0x0024D158 File Offset: 0x0024B358
		public static ITrackingEventTypeBase Create(ITrackingEventTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackingEventTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005077 RID: 20599
		// (get) Token: 0x0600FF92 RID: 65426 RVA: 0x0024D177 File Offset: 0x0024B377
		public virtual ETrackingEventType Type
		{
			get
			{
				return (ETrackingEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008B84 RID: 35716
		private ITrackingEventTypeBase Instance;
	}
}
