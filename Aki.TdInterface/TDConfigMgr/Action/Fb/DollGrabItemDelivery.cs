using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AFC RID: 11004
	public class DollGrabItemDelivery : ActionParams
	{
		// Token: 0x0600F10C RID: 61708 RVA: 0x0022F959 File Offset: 0x0022DB59
		[NullableContext(1)]
		public static DollGrabItemDelivery Create(IDollGrabItemDelivery? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DollGrabItemDelivery
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CD6 RID: 19670
		// (get) Token: 0x0600F10D RID: 61709 RVA: 0x0022F978 File Offset: 0x0022DB78
		public virtual int ShowcaseId
		{
			get
			{
				return this.Instance.ShowcaseId;
			}
		}

		// Token: 0x0400849A RID: 33946
		private IDollGrabItemDelivery Instance;
	}
}
