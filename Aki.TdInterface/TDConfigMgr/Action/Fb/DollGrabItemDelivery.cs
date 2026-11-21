using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DF0 RID: 11760
	public class DollGrabItemDelivery : ActionParams
	{
		// Token: 0x0600FFC2 RID: 65474 RVA: 0x0024D665 File Offset: 0x0024B865
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

		// Token: 0x17005090 RID: 20624
		// (get) Token: 0x0600FFC3 RID: 65475 RVA: 0x0024D684 File Offset: 0x0024B884
		public virtual int ShowcaseId
		{
			get
			{
				return this.Instance.ShowcaseId;
			}
		}

		// Token: 0x04008B9E RID: 35742
		private IDollGrabItemDelivery Instance;
	}
}
