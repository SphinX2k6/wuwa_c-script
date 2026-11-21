using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DE5 RID: 11749
	public class IEasterEggTrackingEvent : ITrackingEventTypeBase
	{
		// Token: 0x0600FF94 RID: 65428 RVA: 0x0024D18C File Offset: 0x0024B38C
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

		// Token: 0x17005078 RID: 20600
		// (get) Token: 0x0600FF95 RID: 65429 RVA: 0x0024D1AB File Offset: 0x0024B3AB
		public override ETrackingEventType Type
		{
			get
			{
				return (ETrackingEventType)this.Instance.Type;
			}
		}

		// Token: 0x17005079 RID: 20601
		// (get) Token: 0x0600FF96 RID: 65430 RVA: 0x0024D1B8 File Offset: 0x0024B3B8
		public virtual int EasterEggId
		{
			get
			{
				return this.Instance.EasterEggId;
			}
		}

		// Token: 0x04008B85 RID: 35717
		private IEasterEggTrackingEvent Instance;
	}
}
