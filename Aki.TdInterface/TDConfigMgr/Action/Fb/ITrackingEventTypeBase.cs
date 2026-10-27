using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF0 RID: 10992
	public class ITrackingEventTypeBase
	{
		// Token: 0x0600F0DB RID: 61659 RVA: 0x0022F44C File Offset: 0x0022D64C
		[NullableContext(1)]
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

		// Token: 0x17004CBD RID: 19645
		// (get) Token: 0x0600F0DC RID: 61660 RVA: 0x0022F46B File Offset: 0x0022D66B
		public virtual ETrackingEventType Type
		{
			get
			{
				return (ETrackingEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008480 RID: 33920
		private ITrackingEventTypeBase Instance;
	}
}
