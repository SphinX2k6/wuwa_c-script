using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF1 RID: 10993
	public class IEasterEggTrackingEvent : ITrackingEventTypeBase
	{
		// Token: 0x0600F0DE RID: 61662 RVA: 0x0022F480 File Offset: 0x0022D680
		[NullableContext(1)]
		public static IEasterEggTrackingEvent Create(IEasterEggTrackingEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEasterEggTrackingEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CBE RID: 19646
		// (get) Token: 0x0600F0DF RID: 61663 RVA: 0x0022F49F File Offset: 0x0022D69F
		public override ETrackingEventType Type
		{
			get
			{
				return (ETrackingEventType)this.Instance.Type;
			}
		}

		// Token: 0x17004CBF RID: 19647
		// (get) Token: 0x0600F0E0 RID: 61664 RVA: 0x0022F4AC File Offset: 0x0022D6AC
		public virtual int EasterEggId
		{
			get
			{
				return this.Instance.EasterEggId;
			}
		}

		// Token: 0x04008481 RID: 33921
		private IEasterEggTrackingEvent Instance;
	}
}
