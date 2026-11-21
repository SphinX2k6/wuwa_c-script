using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A39 RID: 10809
	public class IControlTrackingSelf : IControlTrackingType
	{
		// Token: 0x0600EECF RID: 61135 RVA: 0x002302B1 File Offset: 0x0022E4B1
		public static IControlTrackingSelf Create(IControlTrackingSelf? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlTrackingSelf
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700470B RID: 18187
		// (get) Token: 0x0600EED0 RID: 61136 RVA: 0x002302D0 File Offset: 0x0022E4D0
		public override EControlTrackingType Type
		{
			get
			{
				return (EControlTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x04008321 RID: 33569
		private IControlTrackingSelf Instance;
	}
}
